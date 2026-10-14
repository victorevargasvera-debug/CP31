using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000048 RID: 72
	public class XamGridBarcodeView : global::Infragistics.Controls.Barcodes.XamBarcodeView
	{
		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0001CDBF File Offset: 0x0001AFBF
		// (set) Token: 0x06000283 RID: 643 RVA: 0x0001CDC7 File Offset: 0x0001AFC7
		private global::Infragistics.Controls.Barcodes.XamGridBarcode GridBarcode { get; set; }

		// Token: 0x06000284 RID: 644 RVA: 0x0001CDD0 File Offset: 0x0001AFD0
		public XamGridBarcodeView(global::Infragistics.Controls.Barcodes.XamGridBarcode barcode) : base(barcode)
		{
			this.GridBarcode = barcode;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
		public override void OnTemplateProvided(global::System.Func<string, global::System.Windows.DependencyObject> getTemplateChild)
		{
			base.OnTemplateProvided(getTemplateChild);
			this.GridBarcode.BarcodeGrid = (getTemplateChild("BarcodeGrid") as global::Infragistics.Controls.Barcodes.BarcodeGrid);
			if (this.GridBarcode.BarcodeGrid != null)
			{
				this.GridBarcode.BarcodeGrid.Barcode = this.GridBarcode;
				global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding();
				binding.Path = new global::System.Windows.PropertyPath("Background", new object[0]);
				binding.Source = this.GridBarcode;
				this.GridBarcode.BarcodeGrid.SetBinding(global::System.Windows.Controls.Panel.BackgroundProperty, binding);
				this.GridBarcode.BarcodeGrid.VerticalAlignment = global::System.Windows.VerticalAlignment.Center;
				this.GridBarcode.BarcodeGrid.HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center;
				if (this.GridBarcode.BarcodeGrid.FiguresPath != null)
				{
					this.GridBarcode.BarcodeGrid.FiguresPath.Fill = this.GridBarcode.Foreground;
				}
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x0001CEC8 File Offset: 0x0001B0C8
		internal void ErrorMessage(string errorMessage)
		{
			global::System.Exception e_ = new global::System.ArgumentException(errorMessage);
			base.Barcode.ErrorMessage(e_);
			this.GridBarcode.ClearBarcodeGrid();
		}

		// Token: 0x06000287 RID: 647 RVA: 0x0001CEF3 File Offset: 0x0001B0F3
		internal void MeasureBarcodeGrid()
		{
		}

		// Token: 0x06000288 RID: 648 RVA: 0x0001CEF8 File Offset: 0x0001B0F8
		internal global::System.Windows.Shapes.Path ExportFiguresPathRect()
		{
			global::System.Windows.Rect bounds = this.GetBounds(this.GridBarcode.BarcodeGrid, base.Barcode);
			global::System.Windows.Rect bounds2 = this.GridBarcode.BarcodeGrid.FiguresPath.Data.Bounds;
			bounds2.X += bounds.X;
			bounds2.Y += bounds.Y;
			return new global::System.Windows.Shapes.Path
			{
				Data = new global::System.Windows.Media.RectangleGeometry
				{
					Rect = bounds2
				}
			};
		}

		// Token: 0x06000289 RID: 649 RVA: 0x0001CF80 File Offset: 0x0001B180
		private global::System.Windows.Rect GetBounds(global::System.Windows.FrameworkElement element, global::System.Windows.FrameworkElement relativeTo)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			element.UpdateLayout();
			global::System.Windows.Media.GeneralTransform generalTransform;
			global::System.Windows.Point point;
			double num;
			double num2;
			try
			{
				try
				{
					if (relativeTo != null)
					{
						global::System.Windows.Media.Visual visualParentRoot = global::Infragistics.Controls.Barcodes.XamGridBarcodeView.GetVisualParentRoot(element);
						global::System.Windows.Media.Visual visualParentRoot2 = global::Infragistics.Controls.Barcodes.XamGridBarcodeView.GetVisualParentRoot(relativeTo);
						if (visualParentRoot == visualParentRoot2)
						{
							generalTransform = element.TransformToVisual(relativeTo);
							point = generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0));
							num = point.X;
							num2 = point.Y;
						}
						else
						{
							generalTransform = element.TransformToVisual(visualParentRoot);
							global::System.Windows.Point point2 = generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0));
							global::System.Windows.Point point3 = visualParentRoot.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
							global::System.Windows.Media.GeneralTransform generalTransform2 = relativeTo.TransformToVisual(visualParentRoot2);
							global::System.Windows.Point point4 = generalTransform2.Transform(new global::System.Windows.Point(0.0, 0.0));
							global::System.Windows.Point point5 = visualParentRoot2.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
							num = point2.X + point3.X - (point4.X + point5.X);
							num2 = point2.Y + point3.Y - (point4.Y + point5.Y);
							point = new global::System.Windows.Point(num, num2);
						}
					}
					else
					{
						global::System.Windows.Media.Visual visualParentRoot3 = global::Infragistics.Controls.Barcodes.XamGridBarcodeView.GetVisualParentRoot(element);
						generalTransform = element.TransformToVisual(visualParentRoot3);
						global::System.Windows.Point point6 = visualParentRoot3.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
						global::System.Windows.Point point7 = global::System.Windows.Application.Current.MainWindow.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
						point = generalTransform.Transform(new global::System.Windows.Point(0.0, 0.0));
						num = point.X + point6.X - point7.X;
						num2 = point.Y + point6.Y - point7.Y;
					}
				}
				catch (global::System.InvalidOperationException ex)
				{
					throw new global::System.ArgumentException(ex.Message, ex);
				}
			}
			catch (global::System.ArgumentException innerException)
			{
				throw new global::System.ArgumentException("The element may be not visible. GetBounds can only be used on visible elements.", innerException);
			}
			global::System.Windows.Point point8 = generalTransform.Transform(new global::System.Windows.Point(element.ActualWidth, element.ActualHeight));
			double num3 = point8.X - point.X;
			if (num3 < 0.0)
			{
				num3 = -num3;
				num -= num3;
			}
			double num4 = point8.Y - point.Y;
			if (num4 < 0.0)
			{
				num4 = -num4;
				num2 -= num4;
			}
			return new global::System.Windows.Rect(num, num2, num3, num4);
		}

		// Token: 0x0600028A RID: 650 RVA: 0x0001D24C File Offset: 0x0001B44C
		private static global::System.Windows.Media.Visual GetVisualParentRoot(global::System.Windows.Media.Visual element)
		{
			global::System.Windows.Media.Visual visual;
			global::System.Windows.Media.Visual visual2;
			for (visual = element; visual != null; visual = visual2)
			{
				visual2 = (global::System.Windows.Media.VisualTreeHelper.GetParent(visual) as global::System.Windows.Media.Visual);
				if (visual2 == null)
				{
					return visual;
				}
			}
			return visual;
		}

		// Token: 0x040001DA RID: 474
		internal const string BarcodeGridName = "BarcodeGrid";
	}
}
