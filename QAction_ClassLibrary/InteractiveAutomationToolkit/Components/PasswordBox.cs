#if DM10_0
namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;
	using Skyline.DataMiner.Automation;

	/// <summary>
	///     A text box for passwords.
	/// </summary>
	/// <remarks>Available from DataMiner 9.6.6 onwards.</remarks>
	public class PasswordBox : InteractiveWidget
	{
		private bool changed;
		private string previous;

		/// <summary>
		///     Initializes a new instance of the <see cref="PasswordBox" /> class.
		/// </summary>
		/// <param name="hasPeekIcon">A value indicating whether the peek icon to reveal the password is shown.</param>
		public PasswordBox(bool hasPeekIcon)
		{
			Type = UIBlockType.PasswordBox;
			HasPeekIcon = hasPeekIcon;
		}

		/// <summary>
		///     Initializes a new instance of the <see cref="PasswordBox" /> class.
		/// </summary>
		public PasswordBox() : this(false)
		{
		}

		/// <summary>
		///     Event triggers when the password changed.
		/// </summary>
		public event EventHandler<PasswordBoxChangedEventArgs> Changed;

		/// <summary>
		///     Gets or sets a value indicating whether the peek icon to reveal the password is shown.
		///     Default: <c>false</c>
		/// </summary>
		public bool HasPeekIcon
		{
			get
			{
				return BlockDefinition.HasPeekIcon;
			}

			set
			{
				BlockDefinition.HasPeekIcon = value;
			}
		}

		/// <summary>
		///     Gets or sets the password set in the password box.
		/// </summary>
		public string Password
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

		/// <inheritdoc />
		internal override void LoadResult(UIResults uiResults)
		{
			string result = uiResults.GetString(this);
			if (WantsOnChange && (result != Password))
			{
				changed = true;
				previous = Password;
			}

			Password = result;
		}

		/// <inheritdoc />
		internal override void RaiseResultEvents()
		{
			if (changed && (Changed != null))
			{
				Changed(this, new PasswordBoxChangedEventArgs(Password, previous));
			}

			changed = false;
		}

		/// <summary>
		///     Provides data for the <see cref="Changed" /> event.
		/// </summary>
		public class PasswordBoxChangedEventArgs : EventArgs
		{
			internal PasswordBoxChangedEventArgs(string password, string previous)
			{
				Password = password;
				Previous = previous;
			}

			/// <summary>
			///     Gets the password.
			/// </summary>
			public string Password { get; private set; }

			/// <summary>
			///     Gets the previous password.
			/// </summary>
			public string Previous { get; private set; }
		}
	}
}
#endif