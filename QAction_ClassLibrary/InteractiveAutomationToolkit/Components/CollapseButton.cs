namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Skyline.DataMiner.Automation;

	/// <summary>
	///		A button that can be used to show/hide a collection of widgets.
	/// </summary>
	public class CollapseButton : InteractiveWidget
	{
		private const string COLLAPSE = "Collapse";
		private const string EXPAND = "Expand";

		private bool pressed;
		private bool isCollapsed;
		private IEnumerable<Widget> widgets;

		public CollapseButton(IEnumerable<Widget> widgets, bool isCollapsed)
		{
			Type = UIBlockType.Button;
			this.widgets = widgets;
			IsCollapsed = isCollapsed;
		}

		/// <summary>
		///     Event triggers when the button is pressed.
		///     WantsOnChange will be set to true when this event is subscribed to.
		/// </summary>
		public event EventHandler<EventArgs> Pressed
		{
			add
			{
				OnPressed += value;
				WantsOnChange = true;
			}

			remove
			{
				OnPressed -= value;
				if(OnPressed == null || !OnPressed.GetInvocationList().Any())
				{
					WantsOnChange = false;
				}
			}
		}

		private event EventHandler<EventArgs> OnPressed;

		public bool IsCollapsed
		{
			get
			{
				return isCollapsed;
			}

			set
			{
				isCollapsed = value;
				BlockDefinition.Text = value ? EXPAND : COLLAPSE;
				foreach (Widget widget in widgets) widget.IsVisible = !value;
			}
		}

		internal override void LoadResult(UIResults uiResults)
		{
			pressed = uiResults.WasCollapseButtonPressed(this);
		}

		internal override void RaiseResultEvents()
		{
			if (pressed)
			{
				IsCollapsed = !IsCollapsed;
				OnPressed?.Invoke(this, EventArgs.Empty);
			}

			pressed = false;
		}
	}
}
