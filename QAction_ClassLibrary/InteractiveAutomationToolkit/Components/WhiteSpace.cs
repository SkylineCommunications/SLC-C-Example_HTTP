﻿namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;
	using Skyline.DataMiner.Automation;

	/// <summary>
	///		A whitespace.
	/// </summary>
	public class WhiteSpace : Widget
	{
		public WhiteSpace()
		{
			Type = UIBlockType.StaticText;
			BlockDefinition.Style = null;
			BlockDefinition.Text = String.Empty;
		}
	}
}
