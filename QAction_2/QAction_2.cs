using System;
using System.Collections.Generic;
using System.Linq;

using DataXml;
using Skyline.DataMiner.Scripting;
using XmlMethods;

/// <summary>
/// DataMiner QAction Class: parseData.
/// </summary>
public class QAction
{
	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocol protocol)
	{
		uint[] paramsToGet = new uint[] { Parameter.receivedataxmlhttpcode_10, Parameter.receivedataxmlhttpanswer_20 };
		object[] httpValues = (object[])protocol.GetParameters(paramsToGet);
		string answerCode = Convert.ToString(httpValues[0]);
		string answer = Convert.ToString(httpValues[1]);

		if (String.IsNullOrWhiteSpace(answer) || String.IsNullOrWhiteSpace(answerCode) || !answerCode.Contains("200 OK"))
		{
			protocol.Log("QA" + protocol.QActionID + "|Run|ERR: HTTP response invalid. Received status: " + answerCode, LogType.Error, LogLevel.NoLogging);
			return;
		}

		try
		{
			Server server = answer.XmlDeserializeFromString<Server>(protocol);
			if (server == null || server.devices == null)
			{
				protocol.Log("QA" + protocol.QActionID + "|Run|Server Information could not be processed | Answer Received: " + answer, LogType.Error, LogLevel.NoLogging);
				return;
			}

			ServerDevice[] devices = server.devices;

			string tempUnit = CheckTemperatureUnit(server);

			Dictionary<int, object> paramsToSet = new Dictionary<int, object>()
			{
				{ Parameter.elementname_50, server.name },
				{ Parameter.hostname_51, server.host },
				{ Parameter.ipaddress_52, server.address },
				{ Parameter.backupipaddress_53, server.addressbackup },
				{ Parameter.macaddress_54, server.macaddress },
				{ Parameter.consoleidentifier_55, server.consoleid },
				{ Parameter.version_56, server.version },
				{ Parameter.layoutrevision_57, server.layoutrev },
				{ Parameter.bootloaderrevision_58, server.bootldrrev },
				{ Parameter.productid_59, server.productid },
				{ Parameter.companyname_60, server.company },
				{ Parameter.companyurl_61, server.companyurl },
				{ Parameter.supportemail_62, server.supportemail },
				{ Parameter.supporttelephone_63, server.supportphone },
				{ Parameter.buzzer_64, server.buzzer },
				{ Parameter.servertemperatureunit_65, tempUnit }
			};

			protocol.SetParameters(paramsToSet.Keys.ToArray(), paramsToSet.Values.ToArray());

			List<object[]> deviceList = new List<object[]>();
			List<object[]> fieldsList = new List<object[]>();

			foreach (ServerDevice device in devices)
			{
				deviceList.Add(new object[] { device.id, device.name, device.type, device.available, device.index });

				foreach (serverDeviceField field in device.field)
				{
					fieldsList.Add(new object[] { device.id + "/" + field.key, field.key, field.value, field.niceName, field.min, field.max, field.type, device.name + "/" + field.niceName });
				}
			}

			protocol.FillArray(Parameter.Devices.tablePid, deviceList, NotifyProtocol.SaveOption.Full);
			protocol.FillArray(Parameter.Fields.tablePid, fieldsList, NotifyProtocol.SaveOption.Full);
		}
		catch (Exception e)
		{
			protocol.Log("QA" + protocol.QActionID + "|Run|Error parsing XML file | Answer Received: " + answer + " | Error: " + e, LogType.Error, LogLevel.NoLogging);
		}
	}

	private static string CheckTemperatureUnit(Server server)
	{
		string tempUnit;
		switch (server.tempunit.ToUpper())
		{
			case "C":
				{
					tempUnit = "Celsius";
					break;
				}

			case "F":
				{
					tempUnit = "Fahrenheit";
					break;
				}

			case "K":
				{
					tempUnit = "Kelvin";
					break;
				}

			default:
				{
					tempUnit = "Other";
					break;
				}
		}

		return tempUnit;
	}
}