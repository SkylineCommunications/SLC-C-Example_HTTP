namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;

	public class WidgetLayout : IWidgetLayout
	{
		private int column;
		private int columnSpan;
		private Margin margin;
		private int row;
		private int rowSpan;

		public WidgetLayout(
			int fromRow,
			int fromColumn,
			int rowSpan,
			int columnSpan,
			HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left,
			VerticalAlignment verticalAlignment = VerticalAlignment.Top)
		{
			Row = fromRow;
			Column = fromColumn;
			RowSpan = rowSpan;
			ColumnSpan = columnSpan;
			HorizontalAlignment = horizontalAlignment;
			VerticalAlignment = verticalAlignment;
			Margin = new Margin();
		}

		public WidgetLayout(
			int row,
			int column,
			HorizontalAlignment horizontalAlignment = HorizontalAlignment.Left,
			VerticalAlignment verticalAlignment = VerticalAlignment.Top) : this(
			row,
			column,
			1,
			1,
			horizontalAlignment,
			verticalAlignment)
		{
		}

		/// <summary>
		///     Gets or sets the column location of the widget on the grid.
		/// </summary>
		/// <remarks>The top-left position is (0, 0) by default.</remarks>
		public int Column
		{
			get
			{
				return column;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				column = value;
			}
		}

		/// <summary>
		///     Gets or sets how many columns the widget is spanning in the grid.
		/// </summary>
		/// <remarks>The widget will start at <see cref="Column" /></remarks>
		public int ColumnSpan
		{
			get
			{
				return columnSpan;
			}

			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				columnSpan = value;
			}
		}

		/// <inheritdoc />
		public HorizontalAlignment HorizontalAlignment { get; set; }

		/// <inheritdoc />
		public Margin Margin
		{
			get
			{
				return margin;
			}

			set
			{
				if (value == null)
				{
					throw new ArgumentNullException("value");
				}

				margin = value;
			}
		}

		/// <summary>
		///     Gets or sets the row location of the widget on the grid.
		/// </summary>
		/// <remarks>The top-left position is (0, 0) by default.</remarks>
		public int Row
		{
			get
			{
				return row;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				row = value;
			}
		}

		/// <summary>
		///     Gets or sets how many rows the widget is spanning in the grid.
		/// </summary>
		/// <remarks>The widget will start at <see cref="Row" /></remarks>
		public int RowSpan
		{
			get
			{
				return rowSpan;
			}

			set
			{
				if (value <= 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				rowSpan = value;
			}
		}

		/// <inheritdoc />
		public VerticalAlignment VerticalAlignment { get; set; }
	}
}
