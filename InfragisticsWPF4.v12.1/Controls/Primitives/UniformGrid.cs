using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Primitives
{
	// Token: 0x02000086 RID: 134
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class UniformGrid : global::System.Windows.Controls.Panel
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001416C File Offset: 0x0001236C
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0001417E File Offset: 0x0001237E
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600053D RID: 1341 RVA: 0x00014191 File Offset: 0x00012391
		// (set) Token: 0x0600053E RID: 1342 RVA: 0x000141A3 File Offset: 0x000123A3
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x000141B6 File Offset: 0x000123B6
		// (set) Token: 0x06000540 RID: 1344 RVA: 0x000141C8 File Offset: 0x000123C8
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

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x000141DB File Offset: 0x000123DB
		// (set) Token: 0x06000542 RID: 1346 RVA: 0x000141ED File Offset: 0x000123ED
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

		// Token: 0x06000543 RID: 1347 RVA: 0x00014200 File Offset: 0x00012400
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

		// Token: 0x06000544 RID: 1348 RVA: 0x00014248 File Offset: 0x00012448
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

		// Token: 0x06000545 RID: 1349 RVA: 0x00014428 File Offset: 0x00012628
		private static void OnColumnRowPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Primitives.UniformGrid uniformGrid = (global::Infragistics.Controls.Primitives.UniformGrid)d;
			global::Infragistics.CoreUtilities.ValidateIsNotNegative((double)((int)e.NewValue), global::Infragistics.DependencyPropertyUtilities.GetName(e.Property));
			uniformGrid.InvalidateMeasure();
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00014460 File Offset: 0x00012660
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

		// Token: 0x06000547 RID: 1351 RVA: 0x00014590 File Offset: 0x00012790
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

		// Token: 0x040001EB RID: 491
		private int _columns;

		// Token: 0x040001EC RID: 492
		private int _rows;

		// Token: 0x040001ED RID: 493
		private int _firstCol;

		// Token: 0x040001EE RID: 494
		private int _firstRow;

		// Token: 0x040001EF RID: 495
		public static readonly global::System.Windows.DependencyProperty ColumnsProperty = global::Infragistics.DependencyPropertyUtilities.Register("Columns", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));

		// Token: 0x040001F0 RID: 496
		public static readonly global::System.Windows.DependencyProperty FirstColumnProperty = global::Infragistics.DependencyPropertyUtilities.Register("FirstColumn", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));

		// Token: 0x040001F1 RID: 497
		public static readonly global::System.Windows.DependencyProperty FirstRowProperty = global::Infragistics.DependencyPropertyUtilities.Register("FirstRow", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));

		// Token: 0x040001F2 RID: 498
		public static readonly global::System.Windows.DependencyProperty RowsProperty = global::Infragistics.DependencyPropertyUtilities.Register("Rows", typeof(int), typeof(global::Infragistics.Controls.Primitives.UniformGrid), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Primitives.UniformGrid.OnColumnRowPropertyChanged)));
	}
}
