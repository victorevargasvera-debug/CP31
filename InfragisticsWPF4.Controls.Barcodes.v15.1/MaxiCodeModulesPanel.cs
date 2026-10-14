using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000020 RID: 32
	public class MaxiCodeModulesPanel : global::System.Windows.Controls.Panel
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000F3EE File Offset: 0x0000D5EE
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000F3F6 File Offset: 0x0000D5F6
		internal double LDimension
		{
			get
			{
				return this._LDimension;
			}
			set
			{
				this._LDimension = value;
				this.Dimensions.UpdateDimensions(value);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000F40B File Offset: 0x0000D60B
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000F413 File Offset: 0x0000D613
		internal global::Infragistics.Controls.Barcodes.Dimensions Dimensions
		{
			get
			{
				return this._dimensions;
			}
			set
			{
				this._dimensions = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000F41C File Offset: 0x0000D61C
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000F424 File Offset: 0x0000D624
		internal global::Infragistics.Controls.Barcodes.XamMaxiCodeBarcode Barcode { private get; set; }

		// Token: 0x060000FB RID: 251 RVA: 0x0000F430 File Offset: 0x0000D630
		public MaxiCodeModulesPanel()
		{
			base.UseLayoutRounding = false;
			this.Dimensions = new global::Infragistics.Controls.Barcodes.Dimensions();
			this.Modules = new global::System.Collections.Generic.List<global::Infragistics.Controls.Barcodes.Module>();
			this.FiguresPath = new global::System.Windows.Shapes.Path();
			this.FiguresPath.StrokeThickness = 0.0;
			global::System.Windows.Controls.Canvas canvas = new global::System.Windows.Controls.Canvas();
			canvas.Children.Add(this.FiguresPath);
			base.Children.Add(canvas);
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Barcodes.Module> Modules { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000F4B5 File Offset: 0x0000D6B5
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000F4BD File Offset: 0x0000D6BD
		internal global::System.Windows.Shapes.Path FiguresPath { get; set; }

		// Token: 0x06000100 RID: 256 RVA: 0x0000F4C8 File Offset: 0x0000D6C8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this.Barcode != null)
			{
				this.UpdateModulePanelLDimension(availableSize);
			}
			global::System.Windows.Size availableSize2 = new global::System.Windows.Size(double.MaxValue, double.MaxValue);
			foreach (object obj in base.Children)
			{
				global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
				uielement.Measure(availableSize2);
			}
			double width = 32.0 * this.Dimensions.ModuleX;
			double height = 35.0 * this.Dimensions.ModuleY;
			return new global::System.Windows.Size(width, height);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000F584 File Offset: 0x0000D784
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this.Barcode == null)
			{
				return finalSize;
			}
			double moduleX = this.Dimensions.ModuleX;
			double moduleV = this.Dimensions.ModuleV;
			double num = 1.0 * moduleX;
			double moduleY = this.Dimensions.ModuleY;
			global::System.Windows.Media.PathFigureCollection pathFigureCollection = new global::System.Windows.Media.PathFigureCollection();
			if (this.Barcode.IsValid)
			{
				foreach (global::Infragistics.Controls.Barcodes.Module module in this.Modules)
				{
					int row = module.Row;
					int column = module.Column;
					double num2 = num + (double)column * moduleX;
					if (row % 2 != 0)
					{
						num2 += moduleX / 2.0;
					}
					double top = moduleY + (double)row * this.Dimensions.ModuleY;
					pathFigureCollection.Add(global::Infragistics.Controls.Barcodes.MaxiCodeModulesPanel.CreateModuleFigure(num2, top, moduleX, moduleV));
				}
				double centerY = 16.0 * this.Dimensions.ModuleY + 0.5 * this.Dimensions.ModuleV + moduleY;
				double num3 = 14.0 * this.Dimensions.ModuleW + 0.5 * this.Dimensions.ModuleX + num;
				double num4 = this.Dimensions.RDimensions[5];
				double patternLeft = num3 - num4;
				global::System.Collections.Generic.List<global::System.Windows.Media.PathFigure> ellipsesFigures = global::Infragistics.Controls.Barcodes.MaxiCodeModulesPanel.GetEllipsesFigures(this.Dimensions, patternLeft, centerY);
				foreach (global::System.Windows.Media.PathFigure value in ellipsesFigures)
				{
					pathFigureCollection.Add(value);
				}
			}
			global::System.Windows.Media.PathGeometry data = new global::System.Windows.Media.PathGeometry
			{
				Figures = pathFigureCollection
			};
			this.FiguresPath.Data = data;
			this.FiguresPath.Arrange(new global::System.Windows.Rect(0.0, 0.0, finalSize.Width, finalSize.Height));
			return finalSize;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000F794 File Offset: 0x0000D994
		private static global::System.Windows.Media.PathFigure CreateModuleFigure(double left, double top, double moduleWidth, double moduleHeight)
		{
			global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
			pathFigure.IsClosed = true;
			pathFigure.StartPoint = new global::System.Windows.Point(left + moduleWidth / 2.0, top + 0.5);
			global::System.Windows.Media.LineSegment lineSegment = new global::System.Windows.Media.LineSegment();
			lineSegment.Point = new global::System.Windows.Point(left + moduleWidth - 0.5, top + moduleHeight / 4.0 + 0.25);
			pathFigure.Segments.Add(lineSegment);
			global::System.Windows.Media.LineSegment lineSegment2 = new global::System.Windows.Media.LineSegment();
			lineSegment2.Point = new global::System.Windows.Point(left + moduleWidth - 0.5, top + moduleHeight * 3.0 / 4.0 - 0.25);
			pathFigure.Segments.Add(lineSegment2);
			global::System.Windows.Media.LineSegment lineSegment3 = new global::System.Windows.Media.LineSegment();
			lineSegment3.Point = new global::System.Windows.Point(left + moduleWidth / 2.0, top + moduleHeight - 0.5);
			pathFigure.Segments.Add(lineSegment3);
			global::System.Windows.Media.LineSegment lineSegment4 = new global::System.Windows.Media.LineSegment();
			lineSegment4.Point = new global::System.Windows.Point(left + 0.5, top + moduleHeight * 3.0 / 4.0 - 0.25);
			pathFigure.Segments.Add(lineSegment4);
			global::System.Windows.Media.LineSegment lineSegment5 = new global::System.Windows.Media.LineSegment();
			lineSegment5.Point = new global::System.Windows.Point(left + 0.5, top + moduleHeight / 4.0 + 0.25);
			pathFigure.Segments.Add(lineSegment5);
			return pathFigure;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000F924 File Offset: 0x0000DB24
		private static global::System.Collections.Generic.List<global::System.Windows.Media.PathFigure> GetEllipsesFigures(global::Infragistics.Controls.Barcodes.Dimensions dimensions, double patternLeft, double centerY)
		{
			global::System.Collections.Generic.List<global::System.Windows.Media.PathFigure> list = new global::System.Collections.Generic.List<global::System.Windows.Media.PathFigure>();
			double num = dimensions.RDimensions[5];
			for (int i = 0; i < 6; i++)
			{
				double num2 = dimensions.RDimensions[5 - i];
				double x = patternLeft + num - num2;
				double x2 = patternLeft + num + num2;
				global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
				{
					StartPoint = new global::System.Windows.Point(x, centerY)
				};
				global::System.Windows.Media.ArcSegment value = new global::System.Windows.Media.ArcSegment
				{
					Point = new global::System.Windows.Point(x2, centerY),
					Size = new global::System.Windows.Size(num2, num2)
				};
				pathFigure.Segments.Add(value);
				global::System.Windows.Media.ArcSegment value2 = new global::System.Windows.Media.ArcSegment
				{
					Point = new global::System.Windows.Point(x, centerY),
					Size = new global::System.Windows.Size(num2, num2)
				};
				pathFigure.Segments.Add(value2);
				list.Add(pathFigure);
			}
			return list;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000F9FC File Offset: 0x0000DBFC
		private void UpdateModulePanelLDimension(global::System.Windows.Size size)
		{
			if (double.IsInfinity(size.Width) && double.IsInfinity(size.Height))
			{
				size.Width = (size.Height = 0.0);
			}
			switch (this.Barcode.Stretch)
			{
			case global::System.Windows.Media.Stretch.None:
				this.LDimension = 25.5;
				return;
			case global::System.Windows.Media.Stretch.UniformToFill:
				if (size.Width > size.Height)
				{
					if (double.IsInfinity(size.Width))
					{
						size.Width = 0.0;
					}
					this.LDimension = global::Infragistics.Controls.Barcodes.MeasureHelper.GetXMilimeters(size.Width) * 29.0 / 32.0;
					return;
				}
				if (double.IsInfinity(size.Height))
				{
					size.Height = 0.0;
				}
				this.LDimension = global::Infragistics.Controls.Barcodes.MeasureHelper.GetYMilimenters(size.Height) * global::System.Math.Sqrt(3.0) * 29.0 / 52.5;
				return;
			}
			if (size.Width < size.Height)
			{
				if (double.IsInfinity(size.Width))
				{
					size.Width = 0.0;
				}
				this.LDimension = global::Infragistics.Controls.Barcodes.MeasureHelper.GetXMilimeters(size.Width) * 29.0 / 32.0;
				return;
			}
			if (double.IsInfinity(size.Height))
			{
				size.Height = 0.0;
			}
			this.LDimension = global::Infragistics.Controls.Barcodes.MeasureHelper.GetYMilimenters(size.Height) * global::System.Math.Sqrt(3.0) * 29.0 / 52.5;
		}

		// Token: 0x040000F9 RID: 249
		private const double Padding = 0.5;

		// Token: 0x040000FA RID: 250
		private double _LDimension;

		// Token: 0x040000FB RID: 251
		private global::Infragistics.Controls.Barcodes.Dimensions _dimensions;
	}
}
