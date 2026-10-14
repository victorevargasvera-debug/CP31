using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200001F RID: 31
	public class BarcodeGrid : global::System.Windows.Controls.Panel
	{
		// Token: 0x060000BF RID: 191 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		public BarcodeGrid()
		{
			this.RowsDefinition = new global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.RowDefinition>();
			this.ColumnsDefinition = new global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.ColumnDefinition>();
			this.Modules = new global::System.Collections.Generic.List<global::Infragistics.Controls.Barcodes.Module>();
			this.TextSize = new global::System.Windows.Size(0.0, 0.0);
			this.TextPositions = new global::System.Collections.Generic.List<global::Infragistics.Controls.Barcodes.Module>();
			this.FiguresPath = new global::System.Windows.Shapes.Path();
			this.FiguresPath.StrokeThickness = 0.0;
			global::System.Windows.Controls.Canvas canvas = new global::System.Windows.Controls.Canvas();
			canvas.Children.Add(this.FiguresPath);
			base.Children.Add(canvas);
			base.SnapsToDevicePixels = true;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000E093 File Offset: 0x0000C293
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000E09B File Offset: 0x0000C29B
		internal global::System.Windows.Shapes.Path FiguresPath { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000E0A4 File Offset: 0x0000C2A4
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Barcodes.Module> Modules { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000E0B5 File Offset: 0x0000C2B5
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000E0BD File Offset: 0x0000C2BD
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Barcodes.Module> TextPositions { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000E0C6 File Offset: 0x0000C2C6
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000E0CE File Offset: 0x0000C2CE
		private global::System.Windows.Size TextSize
		{
			get
			{
				return this._textSize;
			}
			set
			{
				this._textSize = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000E0D7 File Offset: 0x0000C2D7
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000E0DF File Offset: 0x0000C2DF
		private global::System.Collections.Generic.List<double> RowPixelHeights
		{
			get
			{
				return this._rowPixelHeights;
			}
			set
			{
				this._rowPixelHeights = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000E0F0 File Offset: 0x0000C2F0
		private global::System.Collections.Generic.List<double> ColumnPixelWidths
		{
			get
			{
				return this._columnPixelWidths;
			}
			set
			{
				this._columnPixelWidths = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000E0F9 File Offset: 0x0000C2F9
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000E101 File Offset: 0x0000C301
		internal int AutoRowsNumber
		{
			get
			{
				return this._autoRowsNumber;
			}
			set
			{
				this._autoRowsNumber = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000E10A File Offset: 0x0000C30A
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000E112 File Offset: 0x0000C312
		internal global::Infragistics.Controls.Barcodes.XamGridBarcode Barcode
		{
			get
			{
				return this._barcode;
			}
			set
			{
				this._barcode = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000E11B File Offset: 0x0000C31B
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000E123 File Offset: 0x0000C323
		public global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.ColumnDefinition> ColumnsDefinition
		{
			get
			{
				return this._columnsDefinition;
			}
			private set
			{
				this._columnsDefinition = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000E12C File Offset: 0x0000C32C
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000E134 File Offset: 0x0000C334
		public global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.RowDefinition> RowsDefinition
		{
			get
			{
				return this._rowsDefinition;
			}
			private set
			{
				this._rowsDefinition = value;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000E140 File Offset: 0x0000C340
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = this.MeasureBarcodeGrid(availableSize);
			if (this.Barcode != null && this.Barcode.IsValid)
			{
				return result;
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000E173 File Offset: 0x0000C373
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			return this.ArrangeBarcodeGrid(finalSize);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000E17C File Offset: 0x0000C37C
		internal global::System.Windows.Size ArrangeBarcodeGrid(global::System.Windows.Size finalSize)
		{
			if (this.Barcode == null)
			{
				return finalSize;
			}
			bool flag = finalSize.Width == 0.0 || finalSize.Height == 0.0;
			global::System.Windows.Media.GeometryGroup geometryGroup = new global::System.Windows.Media.GeometryGroup();
			if (this.Barcode.IsValid && !flag)
			{
				foreach (global::Infragistics.Controls.Barcodes.Module module in this.Modules)
				{
					geometryGroup.Children.Add(this.GetBarGeomertry(module));
				}
			}
			int num = 0;
			foreach (object obj in base.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				global::System.Windows.Controls.TextBlock textBlock = uielement as global::System.Windows.Controls.TextBlock;
				if (textBlock != null)
				{
					this.ArrangeTextBlock(textBlock, finalSize, flag, this.TextPositions[num]);
					num++;
				}
			}
			this.FiguresPath.Data = geometryGroup;
			this.FiguresPath.Arrange(new global::System.Windows.Rect(0.0, 0.0, finalSize.Width, finalSize.Height));
			if (this.Barcode.IsValid)
			{
				global::System.Windows.Rect rect = new global::System.Windows.Rect(0.0, 0.0, finalSize.Width, finalSize.Height);
				base.Clip = new global::System.Windows.Media.RectangleGeometry
				{
					Rect = rect
				};
			}
			else
			{
				base.Clip = null;
			}
			return finalSize;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000E328 File Offset: 0x0000C528
		internal global::System.Windows.Size MeasureBarcodeGrid(global::System.Windows.Size availableSize)
		{
			new global::System.Windows.Size(double.MaxValue, double.MaxValue);
			foreach (object obj in base.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				global::System.Windows.Controls.TextBlock textBlock = uielement as global::System.Windows.Controls.TextBlock;
				if (textBlock != null)
				{
					this.TextSize = this.Barcode.View.GetLabelSize(textBlock);
				}
			}
			if (this.Barcode != null)
			{
				global::System.Windows.Size result = this.CorrectControlSize(this.GetControlSize(availableSize), availableSize);
				if (this.Barcode.BarsFillMode == global::Infragistics.Controls.Barcodes.BarsFillMode.EnsureEqualSize)
				{
					this.AreEnsureEqualSizeValidSettings(availableSize);
				}
				if (this.Barcode.IsValid)
				{
					return result;
				}
			}
			return availableSize;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000E3F4 File Offset: 0x0000C5F4
		public void Clear()
		{
			this.RowsDefinition.Clear();
			this.ColumnsDefinition.Clear();
			this.Modules.Clear();
			this.ClearTextBlock();
			this.FiguresPath.Data = null;
			base.InvalidateMeasure();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000E430 File Offset: 0x0000C630
		private void ClearTextBlock()
		{
			global::System.Collections.Generic.List<global::System.Windows.Controls.TextBlock> list = new global::System.Collections.Generic.List<global::System.Windows.Controls.TextBlock>();
			foreach (object obj in base.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				global::System.Windows.Controls.TextBlock item = uielement as global::System.Windows.Controls.TextBlock;
				list.Add(item);
			}
			foreach (global::System.Windows.Controls.TextBlock element in list)
			{
				base.Children.Remove(element);
			}
			this.TextPositions.Clear();
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000E4EC File Offset: 0x0000C6EC
		private bool AreEnsureEqualSizeValidSettings(global::System.Windows.Size finalSize)
		{
			if (this.Barcode.Stretch == global::System.Windows.Media.Stretch.None)
			{
				return true;
			}
			global::System.Windows.Size sumSize = this.GetSumSize();
			if (sumSize.Height == 0.0 || sumSize.Width == 0.0)
			{
				string message;
				if (sumSize.Height == 0.0 && this.Barcode.IsValid)
				{
					message = global::SR.GetString("InvalidHeight").Replace("{0}", this.RowsDefinition.Count.ToString()).Replace("{1}", finalSize.Height.ToString());
				}
				else
				{
					message = global::SR.GetString("InvalidWidth").Replace("{0}", this.ColumnsDefinition.Count.ToString()).Replace("{1}", finalSize.Width.ToString());
				}
				if (this.Barcode.IsValid)
				{
					global::System.Exception e_ = new global::System.ArgumentException(message);
					this.Barcode.ErrorMessage(e_);
					return false;
				}
			}
			if (!this.CheckDoesFit(finalSize, sumSize))
			{
				string message = global::SR.GetString("SmallSize").Replace("{0}", finalSize.Width.ToString()).Replace("{1}", finalSize.Height.ToString());
				if (this.Barcode.IsValid)
				{
					global::System.Exception e_2 = new global::System.ArgumentException(message);
					this.Barcode.ErrorMessage(e_2);
					return false;
				}
			}
			if (!this.Barcode.IsValid)
			{
				bool flag = this.CheckShouldClear(finalSize, sumSize);
				if (flag)
				{
					base.InvalidateMeasure();
					this.Barcode.ClearWarnings();
					return false;
				}
			}
			return true;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		private bool CheckDoesFit(global::System.Windows.Size finalSize, global::System.Windows.Size controlSize)
		{
			if (controlSize.Width == 0.0 || controlSize.Height == 0.0)
			{
				return true;
			}
			global::System.Windows.Media.Stretch stretch = this.Barcode.Stretch;
			if (stretch != global::System.Windows.Media.Stretch.UniformToFill)
			{
				return finalSize.Width >= (double)this.ColumnsDefinition.Count && finalSize.Height >= (double)this.AutoRowsNumber;
			}
			if (finalSize.Width <= controlSize.Width)
			{
				return finalSize.Height >= (double)this.AutoRowsNumber;
			}
			return finalSize.Height > controlSize.Height || finalSize.Width >= (double)this.ColumnsDefinition.Count;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000E75C File Offset: 0x0000C95C
		private bool CheckShouldClear(global::System.Windows.Size finalSize, global::System.Windows.Size controlSize)
		{
			double height = controlSize.Height;
			double width = controlSize.Width;
			bool flag = height > 0.0 && width > 0.0;
			if (this.Barcode.Stretch == global::System.Windows.Media.Stretch.UniformToFill)
			{
				return flag && (width <= finalSize.Width || height <= finalSize.Height);
			}
			return flag && width <= finalSize.Width && height <= finalSize.Height;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000E7E0 File Offset: 0x0000C9E0
		private global::System.Windows.Media.Geometry GetBarGeomertry(global::Infragistics.Controls.Barcodes.Module module)
		{
			double y = this.barsOffset.Y + this.GetTopOffset(module.Row);
			double x = this.barsOffset.X + this.GetLeftOffset(module.Column);
			double width = this.GetWidth(module.Column, module.ColSpan);
			double height = this.GetHeight(module.Row, module.RowSpan);
			global::System.Windows.Rect rect = new global::System.Windows.Rect(x, y, width, height);
			return new global::System.Windows.Media.RectangleGeometry
			{
				Rect = rect
			};
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000E868 File Offset: 0x0000CA68
		private void ArrangeTextBlock(global::System.Windows.Controls.TextBlock text, global::System.Windows.Size finalSize, bool shouldHide, global::Infragistics.Controls.Barcodes.Module textPosition)
		{
			global::System.Windows.Size sumSize = this.GetSumSize();
			global::System.Windows.Point point = this.Barcode.CalculateOffset(finalSize, sumSize);
			if (this.isTextLonger)
			{
				point.X -= this.barsOffset.X;
			}
			int row = textPosition.Row;
			int column = textPosition.Column;
			int colSpan = textPosition.ColSpan;
			double y = this.GetTopOffset(row) + point.Y;
			double x = this.GetLeftOffset(column) + point.X;
			double num = shouldHide ? 0.0 : this.GetWidth(column, colSpan);
			if (colSpan == this.ColumnsDefinition.Count && num < this.TextSize.Width && this.Barcode.IsValid)
			{
				num = this.TextSize.Width;
			}
			if (num == -1.0)
			{
				num = sumSize.Width;
			}
			double height = this.TextSize.Height;
			text.Arrange(new global::System.Windows.Rect(x, y, num, height));
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000E97C File Offset: 0x0000CB7C
		private double GetLeftOffset(int columnNumber)
		{
			double num = 0.0;
			if (this.ColumnPixelWidths == null)
			{
				return num;
			}
			if (this.RowsDefinition.Count > 0)
			{
				for (int i = 0; i < columnNumber; i++)
				{
					num += this.ColumnPixelWidths[i];
				}
			}
			return num;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		private double GetTopOffset(int rowNumber)
		{
			double num = 0.0;
			if (this.RowPixelHeights == null)
			{
				return num;
			}
			if (this.ColumnsDefinition.Count > 0)
			{
				for (int i = 0; i < rowNumber; i++)
				{
					num += this.RowPixelHeights[i];
				}
			}
			return num;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000EA14 File Offset: 0x0000CC14
		private global::System.Windows.Size CorrectControlSize(global::System.Windows.Size controlSize, global::System.Windows.Size availableSize)
		{
			this.isTextLonger = false;
			if (controlSize.Width < this.TextSize.Width && controlSize.Width <= availableSize.Width && controlSize.Width != 0.0)
			{
				this.barsOffset = this.Barcode.CalculateOffset(this.TextSize, controlSize);
				this.barsOffset.Y = 0.0;
				controlSize.Width = this.TextSize.Width;
				this.isTextLonger = true;
			}
			else if (controlSize.Width > availableSize.Width || controlSize.Height > availableSize.Height)
			{
				this.barsOffset = this.Barcode.CalculateOffset(availableSize, controlSize);
				if (controlSize.Width <= availableSize.Width)
				{
					this.barsOffset.X = 0.0;
				}
				if (controlSize.Height <= availableSize.Height)
				{
					this.barsOffset.Y = 0.0;
				}
			}
			else
			{
				this.barsOffset = default(global::System.Windows.Point);
			}
			if (controlSize.Width > availableSize.Width)
			{
				controlSize.Width = availableSize.Width;
			}
			if (controlSize.Height > availableSize.Height)
			{
				controlSize.Height = availableSize.Height;
			}
			return controlSize;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000EB74 File Offset: 0x0000CD74
		internal global::System.Windows.Size GetControlSize(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size finalSize = this.CorrectAspectRatio(availableSize);
			return this.CalculateSize(finalSize);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000EB94 File Offset: 0x0000CD94
		private global::System.Windows.Size CorrectAspectRatio(global::System.Windows.Size size)
		{
			if (size.Width == 0.0 || size.Height == 0.0)
			{
				return size;
			}
			double num = this.Barcode.CalculateAspectRatio();
			double num2 = size.Height;
			bool flag = false;
			if (this.Barcode.TextBlock != null && this.Barcode.TextBlock.Visibility == global::System.Windows.Visibility.Visible && num2 > this.TextSize.Height && !double.IsInfinity(num2))
			{
				num2 -= this.TextSize.Height;
				flag = true;
			}
			double num3;
			double num4;
			switch (this.Barcode.Stretch)
			{
			case global::System.Windows.Media.Stretch.None:
				return this.Barcode.CalculateDefaultSize(num);
			case global::System.Windows.Media.Stretch.Fill:
				if (double.IsInfinity(size.Width))
				{
					size.Width = this.Barcode.MinWidth;
				}
				if (double.IsInfinity(size.Height))
				{
					size.Height = this.Barcode.MinHeight;
				}
				return new global::System.Windows.Size(size.Width, size.Height);
			case global::System.Windows.Media.Stretch.UniformToFill:
				if (num2 * num > size.Width)
				{
					if (double.IsInfinity(num2))
					{
						num2 = this.Barcode.MinHeight;
					}
					num3 = num2;
					num4 = num * num3;
					goto IL_1C6;
				}
				if (double.IsInfinity(size.Width))
				{
					size.Width = this.Barcode.MinWidth;
				}
				num4 = size.Width;
				num3 = num4 / num;
				goto IL_1C6;
			}
			if (num2 * num > size.Width)
			{
				if (double.IsInfinity(size.Width))
				{
					size.Width = this.Barcode.MinWidth;
				}
				num4 = size.Width;
				num3 = num4 / num;
			}
			else
			{
				if (double.IsInfinity(num2))
				{
					num2 = this.Barcode.MinHeight;
				}
				num3 = num2;
				num4 = num * num3;
			}
			IL_1C6:
			if (flag)
			{
				num3 += this.TextSize.Height;
			}
			num4 = global::System.Math.Floor(num4 + 0.5);
			num3 = global::System.Math.Floor(num3 + 0.5);
			return new global::System.Windows.Size(num4, num3);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000EDAC File Offset: 0x0000CFAC
		private global::System.Windows.Size CalculateSize(global::System.Windows.Size finalSize)
		{
			if (finalSize.Width == 0.0 || finalSize.Height == 0.0)
			{
				return finalSize;
			}
			double height = this.CalculateHeight(finalSize.Height);
			double width = this.CalculateWidth(finalSize.Width);
			return new global::System.Windows.Size(width, height);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000EE04 File Offset: 0x0000D004
		internal global::System.Windows.Size GetSumSize()
		{
			double num = this.GetSumOfColumnsWidth();
			num = ((num == -1.0) ? 0.0 : num);
			double num2 = this.GetSumOfRowsHeight();
			num2 = ((num2 == -1.0) ? 0.0 : num2);
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000EE58 File Offset: 0x0000D058
		internal double GetSumOfColumnsWidth()
		{
			if (this.ColumnPixelWidths == null)
			{
				return -1.0;
			}
			return this.ColumnPixelWidths.Sum();
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000EE77 File Offset: 0x0000D077
		internal double GetSumOfRowsHeight()
		{
			if (this.RowPixelHeights == null)
			{
				return -1.0;
			}
			return this.RowPixelHeights.Sum();
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000EE98 File Offset: 0x0000D098
		private double CalculateHeight(double totalHeight)
		{
			if (totalHeight == 0.0)
			{
				return totalHeight;
			}
			double rowsStarsNumber = global::Infragistics.Controls.Barcodes.BarcodeGrid.GetRowsStarsNumber(this.RowsDefinition);
			this.SaveRowHeights(totalHeight, rowsStarsNumber);
			int num = 1;
			double sumOfRowsHeight;
			do
			{
				sumOfRowsHeight = this.GetSumOfRowsHeight();
				if (sumOfRowsHeight <= 0.0)
				{
					break;
				}
				if (sumOfRowsHeight > totalHeight)
				{
					double num2 = totalHeight - (double)num;
					if (num2 <= 0.0)
					{
						break;
					}
					this.SaveRowHeights(num2, rowsStarsNumber);
					num++;
				}
			}
			while (sumOfRowsHeight > totalHeight);
			return sumOfRowsHeight;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000EF04 File Offset: 0x0000D104
		private void SaveRowHeights(double totalHeight, double rowStarsNumber)
		{
			this.RowPixelHeights = new global::System.Collections.Generic.List<double>();
			if (rowStarsNumber == 0.0)
			{
				return;
			}
			totalHeight -= this.TextSize.Height;
			if (totalHeight < 0.0)
			{
				totalHeight = 0.0;
			}
			this.AutoRowsNumber = 0;
			double num = totalHeight / rowStarsNumber;
			double num2 = 0.0;
			double num3 = 0.0;
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>();
			for (int i = 0; i < this.RowsDefinition.Count; i++)
			{
				global::System.Windows.Controls.RowDefinition rowDefinition = this.RowsDefinition[i];
				double item;
				if (rowDefinition.Height.IsStar)
				{
					global::Infragistics.Controls.Barcodes.BarsFillMode barsFillMode = this.Barcode.BarsFillMode;
					if (barsFillMode == global::Infragistics.Controls.Barcodes.BarsFillMode.FillSpace)
					{
						num3 += rowDefinition.Height.Value;
						double num4 = global::System.Math.Round(num * num3);
						item = num4 - num2;
						num2 = num4;
					}
					else
					{
						item = global::System.Math.Floor(num * rowDefinition.Height.Value);
					}
				}
				else
				{
					item = 0.0;
					this.AutoRowsNumber++;
					list.Add(i);
				}
				this.RowPixelHeights.Add(item);
			}
			for (int j = 0; j < this.AutoRowsNumber; j++)
			{
				this.RowPixelHeights[list[j]] = this.TextSize.Height / (double)this.AutoRowsNumber;
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000F07C File Offset: 0x0000D27C
		private double CalculateWidth(double totalWidth)
		{
			if (totalWidth == 0.0)
			{
				return totalWidth;
			}
			double columnsStarsNumber = global::Infragistics.Controls.Barcodes.BarcodeGrid.GetColumnsStarsNumber(this.ColumnsDefinition);
			double num = totalWidth;
			if (this.Barcode.BarsFillMode == global::Infragistics.Controls.Barcodes.BarsFillMode.EnsureEqualSize && columnsStarsNumber > 0.0)
			{
				num = this.GetMaxWidthForColumns(totalWidth);
			}
			this.SaveColumnsWidths(num, columnsStarsNumber);
			return num;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000F0D0 File Offset: 0x0000D2D0
		private double GetMaxWidthForColumns(double totalWidth)
		{
			double num = totalWidth % (double)this.ColumnsDefinition.Count;
			return totalWidth - num;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000F0F0 File Offset: 0x0000D2F0
		private void SaveColumnsWidths(double totalWidth, double columnStarsNumber)
		{
			this.ColumnPixelWidths = new global::System.Collections.Generic.List<double>();
			if (columnStarsNumber == 0.0)
			{
				return;
			}
			double num = 0.0;
			double num2 = 0.0;
			double num3 = totalWidth / columnStarsNumber;
			foreach (global::System.Windows.Controls.ColumnDefinition columnDefinition in this.ColumnsDefinition)
			{
				double item = 0.0;
				if (columnDefinition.Width.IsStar)
				{
					switch (this.Barcode.BarsFillMode)
					{
					case global::Infragistics.Controls.Barcodes.BarsFillMode.FillSpace:
					{
						num2 += columnDefinition.Width.Value;
						double num4 = global::System.Math.Round(num3 * num2);
						item = num4 - num;
						num = num4;
						goto IL_C3;
					}
					}
					item = global::System.Math.Round(num3 * columnDefinition.Width.Value);
				}
				IL_C3:
				this.ColumnPixelWidths.Add(item);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		private double GetHeight(int row, int rowSpan)
		{
			if (this.RowPixelHeights == null)
			{
				return 0.0;
			}
			if (this.RowsDefinition.Count > 0 && row + rowSpan <= this.RowsDefinition.Count)
			{
				double num = 0.0;
				for (int i = 0; i < rowSpan; i++)
				{
					num += this.RowPixelHeights[row + i];
				}
				return num;
			}
			return -1.0;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000F268 File Offset: 0x0000D468
		private double GetWidth(int column, int colSpan)
		{
			if (this.ColumnPixelWidths == null)
			{
				return 0.0;
			}
			if (this.ColumnsDefinition.Count > 0 && column + colSpan <= this.ColumnsDefinition.Count)
			{
				double num = 0.0;
				for (int i = 0; i < colSpan; i++)
				{
					num += this.ColumnPixelWidths[column + i];
				}
				return num;
			}
			return -1.0;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000F310 File Offset: 0x0000D510
		private static double GetRowsStarsNumber(global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.RowDefinition> rowDefinitionCollection)
		{
			return (from rDef in rowDefinitionCollection
			where rDef.Height.IsStar
			select rDef).Sum((global::System.Windows.Controls.RowDefinition rDef) => rDef.Height.Value);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000F39C File Offset: 0x0000D59C
		private static double GetColumnsStarsNumber(global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.ColumnDefinition> columnDefinitionCollection)
		{
			return (from cDef in columnDefinitionCollection
			where cDef.Width.IsStar
			select cDef).Sum((global::System.Windows.Controls.ColumnDefinition cDef) => cDef.Width.Value);
		}

		// Token: 0x040000E8 RID: 232
		private const int InvalidValue = -1;

		// Token: 0x040000E9 RID: 233
		private global::System.Windows.Point barsOffset;

		// Token: 0x040000EA RID: 234
		private bool isTextLonger;

		// Token: 0x040000EB RID: 235
		private global::System.Windows.Size _textSize;

		// Token: 0x040000EC RID: 236
		private global::System.Collections.Generic.List<double> _rowPixelHeights;

		// Token: 0x040000ED RID: 237
		private global::System.Collections.Generic.List<double> _columnPixelWidths;

		// Token: 0x040000EE RID: 238
		private int _autoRowsNumber;

		// Token: 0x040000EF RID: 239
		private global::Infragistics.Controls.Barcodes.XamGridBarcode _barcode;

		// Token: 0x040000F0 RID: 240
		private global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.ColumnDefinition> _columnsDefinition;

		// Token: 0x040000F1 RID: 241
		private global::System.Collections.ObjectModel.Collection<global::System.Windows.Controls.RowDefinition> _rowsDefinition;
	}
}
