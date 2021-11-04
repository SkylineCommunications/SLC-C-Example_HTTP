namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Skyline.DataMiner.Automation;

	/// <summary>
	///     A list of checkboxes.
	/// </summary>
	public class CheckBoxList : InteractiveWidget
	{
		private readonly IDictionary<string, bool> options = new Dictionary<string, bool>();
		private bool changed;
		private string changedOption;
		private bool changedValue;

		/// <summary>
		///     Initializes a new instance of the <see cref="CheckBoxList" /> class.
		/// </summary>
		/// <param name="options">Name of options that can be checked.</param>
		/// <exception cref="ArgumentNullException">When options is null.</exception>
		public CheckBoxList(IEnumerable<string> options)
		{
			Type = UIBlockType.CheckBoxList;
			SetOptions(options);
		}

		/// <summary>
		///     Event tiggers when the state of a checkbox has changed.
		///     WantsOnChange will be set to true when this event is subscribed to.
		/// </summary>
		public event EventHandler<CheckBoxListChangedEventArgs> Changed
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

		private event EventHandler<CheckBoxListChangedEventArgs> OnChanged;

		/// <summary>
		///     Gets all checked options.
		/// </summary>
		public IEnumerable<string> Checked
		{
			get
			{
				return options.Where(option => option.Value).Select(option => option.Key);
			}
		}

#if DM9_6

		/// <summary>
		///     Gets or sets a value indicating whether the options are sorted naturally.
		/// </summary>
		/// <remarks>Available from DataMiner 9.5.6 onwards.</remarks>
		public bool IsSorted
		{
			get
			{
				return BlockDefinition.IsSorted;
			}

			set
			{
				BlockDefinition.IsSorted = value;
			}
		}
#endif

		/// <summary>
		///     Gets all options.
		/// </summary>
		public IEnumerable<string> Options
		{
			get
			{
				return options.Keys;
			}
		}

		/// <summary>
		///     Gets all unchecked options.
		/// </summary>
		public IEnumerable<string> Unchecked
		{
			get
			{
				return options.Where(option => !option.Value).Select(option => option.Key);
			}
		}

		/// <summary>
		///     Adds an option to the checkbox list.
		/// </summary>
		/// <param name="option">Option to add.</param>
		/// <exception cref="ArgumentNullException">When optionsToAdd is null.</exception>
		public void AddOption(string option)
		{
			if (option == null)
			{
				throw new ArgumentNullException("option");
			}

			if (!options.ContainsKey(option))
			{
				options.Add(option, false);
				BlockDefinition.AddCheckBoxListOption(option);
			}
		}

		/// <summary>
		///     Checks an option.
		/// </summary>
		/// <param name="option">Option to be checked.</param>
		/// <exception cref="ArgumentNullException">When option is null.</exception>
		/// <exception cref="ArgumentException">When the option does not exist.</exception>
		public void Check(string option)
		{
			if (option == null)
			{
				throw new ArgumentNullException("option");
			}

			if (!options.ContainsKey(option))
			{
				throw new ArgumentException("CheckboxList does not have option: " + option, option);
			}

			if (!options[option])
			{
				options[option] = true;
				BlockDefinition.InitialValue = String.Join(";", BlockDefinition.InitialValue, option);
			}
		}

		/// <summary>
		///     Checks all options.
		/// </summary>
		public void CheckAll()
		{
			foreach (string option in options.Keys.ToList())
			{
				options[option] = true;
			}

			BlockDefinition.InitialValue = String.Join(";", options.Keys);
		}

		/// <summary>
		///     Sets the displayed options.
		///     Replaces existing options.
		/// </summary>
		/// <param name="optionsToSet">Options to set.</param>
		/// <exception cref="ArgumentNullException">When optionsToSet is null.</exception>
		public void SetOptions(IEnumerable<string> optionsToSet)
		{
			ClearOptions();
			foreach (string option in optionsToSet)
			{
				AddOption(option);
			}
		}

		/// <summary>
		/// 	Removes an option from the checkbox list.
		/// </summary>
		/// <param name="option">Option to remove.</param>
		/// <exception cref="NullReferenceException">When option is null.</exception>
		public void RemoveOption(string option)
		{
			if (option == null)
			{
				throw new ArgumentNullException("option");
			}

			if (options.Remove(option))
			{
				RecreateUiBlock();
				foreach (string optionsKey in options.Keys)
				{
					BlockDefinition.AddCheckBoxListOption(optionsKey);
				}
			}
		}

		/// <summary>
		///     Unchecks an option.
		/// </summary>
		/// <param name="option">Option to be checked.</param>
		/// <exception cref="ArgumentNullException">When option is null.</exception>
		/// <exception cref="ArgumentException">When the option does not exist.</exception>
		public void Uncheck(string option)
		{
			if (option == null)
			{
				throw new ArgumentNullException("option");
			}

			if (!options.ContainsKey(option))
			{
				throw new ArgumentException("CheckboxList does not have option: " + option, option);
			}

			if (options[option])
			{
				options[option] = false;
				BlockDefinition.InitialValue = String.Join(";", Checked);
			}
		}

		/// <summary>
		///     Unchecks all options.
		/// </summary>
		public void UncheckAll()
		{
			foreach (string option in options.Keys.ToList())
			{
				options[option] = false;
			}

			BlockDefinition.InitialValue = null;
		}

		internal override void LoadResult(UIResults uiResults)
		{
			var checkedOptions = new HashSet<string>(uiResults.GetString(this).Split(';'));

			foreach (string option in options.Keys.ToList())
			{
				bool isChecked = checkedOptions.Contains(option);
				bool hasChanged = options[option] != isChecked;

				options[option] = isChecked;

				if (hasChanged && WantsOnChange)
				{
					changed = true;
					changedOption = option;
					changedValue = isChecked;

					// only a single checkbox can be toggled when WantsOnChange is true
					break;
				}
			}

			BlockDefinition.InitialValue = GenerateInitialValue();
		}

		/// <inheritdoc />
		internal override void RaiseResultEvents()
		{
			if (changed && (OnChanged != null))
			{
				OnChanged(this, new CheckBoxListChangedEventArgs(changedOption, changedValue));
			}

			changed = false;
		}

		private void ClearOptions()
		{
			options.Clear();
			RecreateUiBlock();
			BlockDefinition.InitialValue = null;
		}

		private string GenerateInitialValue()
		{
			return String.Join(";", Checked);
		}

		/// <summary>
		///     Provides data for the <see cref="Changed" /> event.
		/// </summary>
		public class CheckBoxListChangedEventArgs : EventArgs
		{
			internal CheckBoxListChangedEventArgs(string option, bool isChecked)
			{
				Option = option;
				IsChecked = isChecked;
			}

			/// <summary>
			///     Gets a value indicating whether the checkbox has been checked.
			/// </summary>
			public bool IsChecked { get; private set; }

			/// <summary>
			///     Gets the option who's state changed.
			/// </summary>
			public string Option { get; private set; }
		}
	}
}
