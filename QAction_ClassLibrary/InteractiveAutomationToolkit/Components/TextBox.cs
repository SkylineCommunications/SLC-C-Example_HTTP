namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;
	using System.Linq;
	using Skyline.DataMiner.Automation;

	/// <summary>
	///     Widget that is used to edit and display text.
	/// </summary>
	public class TextBox : InteractiveWidget
	{
		private bool changed;
		private string previous;

		/// <summary>
		///     Initializes a new instance of the <see cref="TextBox" /> class.
		/// </summary>
		/// <param name="text">The text displayed in the text box.</param>
		public TextBox(string text)
		{
			Type = UIBlockType.TextBox;
			Text = text;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="TextBox" /> class.
		/// </summary>
		public TextBox() : this(String.Empty)
		{
		}

		/// <summary>
		///     Triggers when the text in the text box changed.
		///     WantsOnChange will be set to true when this event is subscribed to.
		/// </summary>
		public event EventHandler<TextBoxChangedEventArgs> Changed
		{
			add
			{
				OnChanged += value;
				WantsOnChange = true;
			}

			remove
			{
				OnChanged -= value;
				if(OnChanged == null || !OnChanged.GetInvocationList().Any())
				{
					WantsOnChange = false;
				}
			}
		}

		private event EventHandler<TextBoxChangedEventArgs> OnChanged;

		/// <summary>
		///     Gets or sets a value indicating whether users are able to enter multiple lines of text.
		/// </summary>
		public bool IsMultiline
		{
			get
			{
				return BlockDefinition.IsMultiline;
			}

			set
			{
				BlockDefinition.IsMultiline = value;
			}
		}

		/// <summary>
		///     Gets or sets the text displayed in the text box.
		/// </summary>
		public string Text
		{
			get
			{
				return BlockDefinition.InitialValue;
			}

			set
			{
				BlockDefinition.InitialValue = value;
			}
		}

		internal override void LoadResult(UIResults uiResults)
		{
			string value = uiResults.GetString(this);
			if (WantsOnChange)
			{
				changed = value != Text;
				previous = Text;
			}

			Text = value;
		}

		/// <inheritdoc />
		internal override void RaiseResultEvents()
		{
			if (changed && OnChanged != null)
			{
				OnChanged(this, new TextBoxChangedEventArgs(Text, previous));
			}

			changed = false;
		}

		/// <summary>
		///     Provides data for the <see cref="Changed" /> event.
		/// </summary>
		public class TextBoxChangedEventArgs : EventArgs
		{
			internal TextBoxChangedEventArgs(string value, string previous)
			{
				Value = value;
				Previous = previous;
			}

			/// <summary>
			///     Gets the text before the change.
			/// </summary>
			public string Previous { get; private set; }

			/// <summary>
			///     Gets the changed text.
			/// </summary>
			public string Value { get; private set; }
		}
	}
}
