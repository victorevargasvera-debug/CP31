using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x0200009E RID: 158
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class UniformGrid : global::System.Windows.Controls.Panel
	{
		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x000172C4 File Offset: 0x000154C4
		// (set) Token: 0x06000604 RID: 1540 RVA: 0x000172D6 File Offset: 0x000154D6
		[global::System.ComponentModel.Bindable(true)]
		public int Columns
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Primitives.UniformGrid.ColumnsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.UniformGrid.ColumnsProperty, value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000605 RID: 1541 RVA: 0x000172E9 File Offset: 0x000154E9
		// (set) Token: 0x06000606 RID: 1542 RVA: 0x000172FB File Offset: 0x000154FB
		[global::System.ComponentModel.Bindable(true)]
		public int FirstColumn
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Primitives.UniformGrid.FirstColumnProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.UniformGrid.FirstColumnProperty, value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000607 RID: 1543 RVA: 0x0001730E File Offset: 0x0001550E
		// (set) Token: 0x06000608 RID: 1544 RVA: 0x00017320 File Offset: 0x00015520
		[global::System.ComponentModel.Bindable(true)]
		public int FirstRow
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Primitives.UniformGrid.FirstRowProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.UniformGrid.FirstRowProperty, value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000609 RID: 1545 RVA: 0x00017333 File Offset: 0x00015533
		// (set) Token: 0x0600060A RID: 1546 RVA: 0x00017345 File Offset: 0x00015545
		[global::System.ComponentModel.Bindable(true)]
		public int Rows
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Primitives.UniformGrid.RowsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Primitives.UniformGrid.RowsProperty, value);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00017358 File Offset: 0x00015558
		private static double CalculateLayoutRoundingOffset(int firstElementIndex, ref double extraAvailableExtent)
		{
			if (firstElementIndex == 0 || extraAvailableExtent == 0.0)
			{
				return 0.0;
			}
			double num = global::System.Math.Min((double)firstElementIndex, extraAvailableExtent);
			extraAvailableExtent = global::System.Math.Max(extraAvailableExtent - num, 0.0);
			return num;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000173A0 File Offset: 0x000155A0
		private void CalculateMetrics(bool preferColumns)
		{
			this._columns = this.Columns;
			this._rows = this.Rows;
			this._firstCol = this.FirstColumn;
			this._firstRow = this.FirstRow;
			if (this._columns > 0 && this._firstCol > this._columns)
			{
				this._firstCol = this._columns;
			}
			if (this._rows > 0 && this._firstRow > this._rows)
			{
				this._firstRow = this._rows;
			}
			if (this._rows == 0 || this._columns == 0)
			{
				int num = 0;
				int i = 0;
				int count = base.Children.Count;
				while (i < count)
				{
					if (base.Children[i].Visibility != global::System.Windows.Visibility.Collapsed)
					{
						num++;
					}
					i++;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (this._rows == 0)
				{
					if (this._columns != 0)
					{
						this._rows = (num + this._firstCol + (this._columns - 1)) / this._columns;
						this._rows += this._firstRow;
						return;
					}
					this._rows = (int)global::System.Math.Sqrt((double)num);
					if (this._rows * this._rows >= num)
					{
						this._columns = this._rows;
						return;
					}
					this._columns = this._rows;
					if (preferColumns)
					{
						this._columns++;
						if (this._columns * this._rows < num)
						{
							this._rows++;
							return;
						}
					}
					else
					{
						this._rows++;
						if (this._rows * this._columns < num)
						{
							this._columns++;
							return;
						}
					}
				}
				else
				{
					this._columns = (num + this._firstRow + (this._rows - 1)) / this._rows;
					this._columns += this._firstCol;
				}
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00017580 File Offset: 0x00015780
		private static void OnColumnRowPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.UniformGrid uniformGrid = (global::Infragistics.Controls.Primitives.UniformGrid)d;
			global::Infragistics.CoreUtilities.ValidateIsNotNegative((double)((int)e.NewValue), global::Infragistics.DependencyPropertyUtilities.GetName(e.Property));
			uniformGrid.InvalidateMeasure();
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000175B8 File Offset: 0x000157B8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			bool flag = true;
			this.CalculateMetrics(flag);
			global::System.Windows.Size availableSize2 = new global::System.Windows.Size(availableSize.Width / (double)this._columns, availableSize.Height / (double)this._rows);
			double num = 0.0;
			double num2 = 0.0;
			if (base.UseLayoutRounding)
			{
				availableSize2.Width = global::System.Math.Floor(availableSize2.Width);
				availableSize2.Height = global::System.Math.Floor(availableSize2.Height);
			}
			int i = 0;
			int count = base.Children.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = base.Children[i];
				uielement.Measure(availableSize2);
				global::System.Windows.Size desiredSize = uielement.DesiredSize;
				if (desiredSize.Width > num)
				{
					num = desiredSize.Width;
				}
				if (desiredSize.Height > num2)
				{
					num2 = desiredSize.Height;
				}
				i++;
			}
			global::System.Windows.Size result = new global::System.Windows.Size((double)this._columns * num, (double)this._rows * num2);
			if (flag && result.Width > availableSize.Width)
			{
				this.CalculateMetrics(false);
				result = new global::System.Windows.Size((double)this._columns * num, (double)this._rows * num2);
			}
			return result;
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000176E8 File Offset: 0x000158E8
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			double num = finalSize.Width / (double)this._columns;
			double num2 = finalSize.Height / (double)this._rows;
			double num3 = 0.0;
			double num4 = 0.0;
			if (base.UseLayoutRounding)
			{
				num = global::System.Math.Floor(num);
				num2 = global::System.Math.Floor(num2);
				num3 = global::System.Math.Floor(finalSize.Width - num * (double)this._columns);
				num4 = global::System.Math.Floor(finalSize.Height - num2 * (double)this._rows);
			}
			global::System.Windows.Rect finalRect = new global::System.Windows.Rect(num * (double)this._firstCol, num2 * (double)this._firstRow, num, num2);
			int num5 = this._firstCol;
			double num6 = num3;
			double num7 = num4;
			finalRect.X += global::Infragistics.Controls.Primitives.UniformGrid.CalculateLayoutRoundingOffset(this._firstCol, ref num6);
			finalRect.Y += global::Infragistics.Controls.Primitives.UniformGrid.CalculateLayoutRoundingOffset(this._firstRow, ref num7);
			int i = 0;
			int count = base.Children.Count;
			while (i < count)
			{
				global::System.Windows.UIElement uielement = base.Children[i];
				if (uielement.Visibility != global::System.Windows.Visibility.Collapsed)
				{
					num5++;
					finalRect.Width = num;
					finalRect.Height = num2;
					if (num7 > 0.0)
					{
						finalRect.Height += global::System.Math.Min(1.0, num7);
					}
					if (num6 > 0.0)
					{
						finalRect.Width += global::System.Math.Min(1.0, num6);
						num6 = global::System.Math.Max(num6 - 1.0, 0.0);
					}
					uielement.Arrange(finalRect);
					if (num5 < this._columns)
					{
						finalRect.X += finalRect.Width;
					}
					else
					{
						num5 = 0;
						finalRect.X = 0.0;
						finalRect.Y += finalRect.Height;
						num7 = global::System.Math.Max(num7 - 1.0, 0.0);
						num6 = num3;
					}
				}
				i++;
			}
			return finalSize;
		}

		// Token: 0x04000261 RID: 609
		private int _columns;

		// Token: 0x04000262 RID: 610
		private int _rows;

		// Token: 0x04000263 RID: 611
		private int _firstCol;

		// Token: 0x04000264 RID: 612
		private int _firstRow;

		// Token: 0x04000265 RID: 613
		public static readonly global::System.Windows.DependencyProperty ColumnsProperty = global::Infragistics.DependencyPropertyUtilities.Register("Columns", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));

		// Token: 0x04000266 RID: 614
		public static readonly global::System.Windows.DependencyProperty FirstColumnProperty = global::Infragistics.DependencyPropertyUtilities.Register("FirstColumn", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));

		// Token: 0x04000267 RID: 615
		public static readonly global::System.Windows.DependencyProperty FirstRowProperty = global::Infragistics.DependencyPropertyUtilities.Register("FirstRow", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));

		// Token: 0x04000268 RID: 616
		public static readonly global::System.Windows.DependencyProperty RowsProperty = global::Infragistics.DependencyPropertyUtilities.Register("Rows", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));
	}
}
