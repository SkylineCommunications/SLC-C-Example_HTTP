using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

using Skyline.DataMiner.Scripting;

public static class LINQXMLHelper
{
	public static XElement GetElementOrDefault(this XElement parentEl, string elementName, string defaultElementName = "ParentNotFound")
	{
		var foundEl = parentEl.Element(elementName);
		if (foundEl != null)
		{
			return foundEl;
		}
		else
		{
			return new XElement(defaultElementName);
		}
	}

	public static string GetAttributeOrNull(this XElement parentEl, string attribute, string parentNotFoundName = "ParentNotFound")
	{
		if (parentEl.Name != parentNotFoundName)
		{
			XAttribute xA = parentEl.Attribute(attribute);
			if (xA != null)
			{
				return xA.Value;
			}
			else
			{
				return null;
			}
		}
		else
		{
			return null;
		}
	}
}

/// <summary>
/// DataMiner QAction Class: Parse XML.
/// </summary>
public class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocolExt protocol)
	{
		try
		{
			// HTTP/1.1 200 OK
			Dictionary<string, AlarmsQActionRow> polledAlarms = new Dictionary<string, AlarmsQActionRow>();

			object[] httpResponse = (object[])protocol.GetParameters(new uint[] { Parameter.statuscode_10, Parameter.xmlresponsecontent_20 });
			string statusCode = Convert.ToString(httpResponse[0]);
			string xmlResponse = Convert.ToString(httpResponse[1]);

			if (!statusCode.Contains("200 OK"))
			{
				protocol.Log("QA" + protocol.QActionID + "|Run|ERR: HTTP response invalid. Received status: " + statusCode, LogType.Error, LogLevel.NoLogging);
				return;
			}

			XDocument xmlData = XDocument.Parse(xmlResponse);

			foreach (XElement alarm in xmlData.Descendants("alarm"))
			{
				string alarmId = alarm.GetElementOrDefault("alarmId").GetAttributeOrNull("id");
				if (string.IsNullOrWhiteSpace(alarmId))
					continue;

				if (!polledAlarms.ContainsKey(alarmId))
				{
					AlarmsQActionRow alarmRow = new AlarmsQActionRow()
					{
						Alarmsid_101 = alarmId,
						Alarmsdisplayname_102 = alarm.GetAttributeOrNull("displayName"),
						Alarmstype_103 = alarm.GetElementOrDefault("alarmType").GetAttributeOrNull("value"),
						Alarmssource_104 = alarm.GetElementOrDefault("sourceText").GetAttributeOrNull("value"),
						Alarmsseverity_105 = alarm.GetElementOrDefault("severityLevel").GetAttributeOrNull("value"),
					};
					polledAlarms.Add(alarmId, alarmRow);
				}
				else
				{
					protocol.Log("QA" + protocol.QActionID + "|Run|Duplicate key found: " + alarmId, LogType.Information, LogLevel.NoLogging);
				}
			}

			protocol.alarms.FillArray(polledAlarms.Values.ToArray());
		}
		catch (Exception ex)
		{
			protocol.Log("Unexpected error in parsing the data " + ex.ToString(), LogType.Error, LogLevel.NoLogging);
		}
	}
}