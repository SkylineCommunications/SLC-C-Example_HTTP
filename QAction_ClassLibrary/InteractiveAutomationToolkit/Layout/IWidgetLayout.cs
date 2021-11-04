namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;

	public interface IWidgetLayout
	{
		/// <summary>
		///     Gets the column location of the widget on the grid.
		/// </summary>
		/// <remarks>The top-left position is (0, 0) by default.</remarks>
		int Column { get; }

		/// <summary>
		///     Gets how many columns the widget is spanning in the grid.
		/// </summary>
		/// <remarks>The widget will start at <see cref="Column" /></remarks>
		int ColumnSpan { get; }

		/// <summary>
		///     Gets or sets the horizontal alignment of the widget.
		/// </summary>
		HorizontalAlignment HorizontalAlignment { get; set; }

		/// <summary>
		///     Gets or sets the margin around the widget.
		/// </summary>
		/// <exception cref="ArgumentNullException">When value is null.</exception>
		Margin Margin { get; set; }

		/// <summary>
		///     Gets the row location of the widget on the grid.
		/// </summary>
		/// <remarks>The top-left position is (0, 0) by default.</remarks>
		int Row { get; }

		/// <summary>
		///     Gets how many rows the widget is spanning in the grid.
		/// </summary>
		/// <remarks>The widget will start at <see cref="Row" /></remarks>
		int RowSpan { get; }

		/// <summary>
		///     Gets or sets the vertical alignment of the widget.
		/// </summary>
		VerticalAlignment VerticalAlignment { get; set; }
	}
}
