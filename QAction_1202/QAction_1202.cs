using System;
using System.Net;

using Skyline.DataMiner.Scripting;

/// <summary>
/// DataMiner QAction Class: encodeData.
/// </summary>
public static class QAction
{

	/// <summary>
	/// The QAction entry point.
	/// </summary>
	/// <param name="protocol">Link with SLProtocol process.</param>
	public static void Run(SLProtocol protocol)
	{
		try
		{
			// DataMiner does not perform any encoding on the provided data.
			// Therefore, if you are, for example, building a URL for a GET request with a query string or the body of a POST request with content type "application/x-www-form-urlencoded", you must ensure that the data is using percent-encoding (also known as URL encoding) to avoid misinterpretation of the provided data.
			// Otherwise, the provided data might be misinterpreted by the server in case the data contains characters from the reserved character set (e.g. '&').
			// For more information, rever to https://docs.dataminer.services/develop/devguide/Connector/ConnectionsHttpImplementing.html.
			var query = Convert.ToString(protocol.GetParameter(Parameter.query_1200));
			var encodedQuery = WebUtility.UrlEncode(query);

			protocol.SetParameter(Parameter.searchquery_1204, encodedQuery);
			protocol.CheckTrigger(2);
		}
		catch (Exception ex)
		{
			protocol.Log($"QA{protocol.QActionID}|{protocol.GetTriggerParameter()}|Run|Exception thrown:{Environment.NewLine}{ex}", LogType.Error, LogLevel.NoLogging);
		}
	}
}