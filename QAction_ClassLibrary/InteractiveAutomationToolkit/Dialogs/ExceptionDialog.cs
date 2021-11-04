namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;
	using Skyline.DataMiner.Automation;

	/// <summary>
	///		Dialog used to display an Exception.
	/// </summary>
	public class ExceptionDialog : Dialog
	{
		private readonly TextBox exceptionTextBox = new TextBox();
		private Exception exception;

		public ExceptionDialog(Engine engine) : base(engine)
		{
#if DM10_0
			Title = "Exception Occurred";
#endif   
			OkButton = new Button("OK");

			AddWidget(exceptionTextBox, 0, 0);
			AddWidget(OkButton, 1, 0);
		}

		public ExceptionDialog(Engine engine, Exception exception) : this(engine)
		{
			Exception = exception;
		}

		public Exception Exception
		{
			get
			{
				return exception;
			}

			set
			{
				exception = value;
				exceptionTextBox.Text = exception.ToString();
			}
		}

		public Button OkButton { get; private set; }
	}
}
