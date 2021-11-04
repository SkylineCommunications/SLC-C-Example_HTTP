namespace Skyline.DataMiner.DeveloperCommunityLibrary.InteractiveAutomationToolkit
{
	using System;

	public class Margin
	{
		private int bottom;
		private int left;
		private int right;
		private int top;

		public Margin(int left, int top, int right, int bottom)
		{
			Left = left;
			Top = top;
			Right = right;
			Bottom = bottom;
		}

		public Margin() : this(3, 3, 3, 3)
		{
		}

		public int Bottom
		{
			get
			{
				return bottom;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				bottom = value;
			}
		}

		public int Left
		{
			get
			{
				return left;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				left = value;
			}
		}

		public int Right
		{
			get
			{
				return right;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				right = value;
			}
		}

		public int Top
		{
			get
			{
				return top;
			}

			set
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("value");
				}

				top = value;
			}
		}

		/// <inheritdoc />
		public override string ToString()
		{
			return String.Format("{0};{1};{2};{3}", left, right, top, bottom);
		}
	}
}
