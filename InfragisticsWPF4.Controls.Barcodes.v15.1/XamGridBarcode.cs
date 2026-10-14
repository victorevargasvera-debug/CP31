using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using Infragistics.Controls.Barcodes.VisualData;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000044 RID: 68
	public abstract class XamGridBarcode : global::Infragistics.Controls.Barcodes.XamBarcode
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000218 RID: 536 RVA: 0x0001AE80 File Offset: 0x00019080
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0001AE88 File Offset: 0x00019088
		protected int LeftQuietZoneWidth
		{
			get
			{
				return this._leftQuietZoneWidth;
			}
			set
			{
				this._leftQuietZoneWidth = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600021A RID: 538 RVA: 0x0001AE91 File Offset: 0x00019091
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0001AE99 File Offset: 0x00019099
		protected int RightQuietZoneWidth
		{
			get
			{
				return this._rightQuietZoneWidth;
			}
			set
			{
				this._rightQuietZoneWidth = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0001AEA2 File Offset: 0x000190A2
		// (set) Token: 0x0600021D RID: 541 RVA: 0x0001AEAA File Offset: 0x000190AA
		internal global::Infragistics.Controls.Barcodes.BarcodeGrid BarcodeGrid { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0001AEB3 File Offset: 0x000190B3
		// (set) Token: 0x0600021F RID: 543 RVA: 0x0001AEBB File Offset: 0x000190BB
		internal global::System.Windows.Controls.TextBlock TextBlock { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000220 RID: 544 RVA: 0x0001AEC4 File Offset: 0x000190C4
		// (set) Token: 0x06000221 RID: 545 RVA: 0x0001AECC File Offset: 0x000190CC
		private bool IsSymbolGenerated
		{
			get
			{
				return this._isSymbolGenerated;
			}
			set
			{
				this._isSymbolGenerated = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000222 RID: 546 RVA: 0x0001AED5 File Offset: 0x000190D5
		// (set) Token: 0x06000223 RID: 547 RVA: 0x0001AEDD File Offset: 0x000190DD
		private global::Infragistics.Controls.Barcodes.BarcodeAlgorithm BarcodeAlgorithm { get; set; }

		// Token: 0x06000224 RID: 548 RVA: 0x0001AEE6 File Offset: 0x000190E6
		internal override global::Infragistics.Controls.Barcodes.XamBarcodeView CreateView()
		{
			return new global::Infragistics.Controls.Barcodes.XamGridBarcodeView(this);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0001AEEE File Offset: 0x000190EE
		internal override void OnViewCreated(global::Infragistics.Controls.Barcodes.XamBarcodeView view)
		{
			base.OnViewCreated(view);
			this.GridBarcodeView = (global::Infragistics.Controls.Barcodes.XamGridBarcodeView)view;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0001AF03 File Offset: 0x00019103
		// (set) Token: 0x06000227 RID: 551 RVA: 0x0001AF0B File Offset: 0x0001910B
		internal global::Infragistics.Controls.Barcodes.XamGridBarcodeView GridBarcodeView { get; set; }

		// Token: 0x06000228 RID: 552 RVA: 0x0001AF14 File Offset: 0x00019114
		protected XamGridBarcode()
		{
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamGridBarcode);
			this.BarcodeAlgorithm = new global::Infragistics.Controls.Barcodes.BarcodeAlgorithm();
			double num = 1.0;
			while (global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(this.XDimension) < 1.0)
			{
				this.XDimension = global::System.Math.Round(global::Infragistics.Controls.Barcodes.MeasureHelper.GetXMilimeters(num), 3);
				num += 0.01;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000229 RID: 553 RVA: 0x0001AF89 File Offset: 0x00019189
		// (set) Token: 0x0600022A RID: 554 RVA: 0x0001AF9B File Offset: 0x0001919B
		[global::System.Runtime.CompilerServices.WidgetDefaultString("fillSpace")]
		public global::Infragistics.Controls.Barcodes.BarsFillMode BarsFillMode
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.BarsFillMode)base.GetValue(global::Infragistics.Controls.Barcodes.XamGridBarcode.BarsFillModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamGridBarcode.BarsFillModeProperty, value);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0001AFAE File Offset: 0x000191AE
		private static void OnBarsFillModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamGridBarcode)d).OnBarsFillModeChanged((global::Infragistics.Controls.Barcodes.BarsFillMode)e.OldValue, (global::Infragistics.Controls.Barcodes.BarsFillMode)e.NewValue);
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0001AFD3 File Offset: 0x000191D3
		private void OnBarsFillModeChanged(global::Infragistics.Controls.Barcodes.BarsFillMode oldValue, global::Infragistics.Controls.Barcodes.BarsFillMode newValue)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600022D RID: 557 RVA: 0x0001AFE0 File Offset: 0x000191E0
		// (set) Token: 0x0600022E RID: 558 RVA: 0x0001AFF2 File Offset: 0x000191F2
		[global::System.Runtime.CompilerServices.WidgetDefaultNumber(3.0)]
		public double WidthToHeightRatio
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty, value);
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0001B005 File Offset: 0x00019205
		internal static void OnWidthToHeightRatioChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamGridBarcode)d).OnWidthToHeightRatioChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0001B02C File Offset: 0x0001922C
		internal virtual void OnWidthToHeightRatioChanged(double oldValue, double newValue)
		{
			if (newValue <= 0.0)
			{
				string errorMessage = global::SR.GetString("InvalidPropertyValue").Replace("{0}", "WidthToHeightRatio").Replace("{1}", 0.001.ToString()).Replace("{2}", 1000.0.ToString());
				this.GridBarcodeView.ErrorMessage(errorMessage);
				return;
			}
			this.View.ScheduleArrange();
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000231 RID: 561 RVA: 0x0001B0AD File Offset: 0x000192AD
		// (set) Token: 0x06000232 RID: 562 RVA: 0x0001B0BF File Offset: 0x000192BF
		[global::System.Runtime.CompilerServices.WidgetDefaultNumber(0.25)]
		public double XDimension
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty, value);
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0001B0D2 File Offset: 0x000192D2
		internal static void OnXDimensionChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamGridBarcode)d).OnXDimensionChanged((double)e.OldValue, (double)e.NewValue);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001B0F8 File Offset: 0x000192F8
		internal virtual void OnXDimensionChanged(double oldValue, double newValue)
		{
			if (newValue < 0.01 || newValue > 100.0)
			{
				string errorMessage = global::SR.GetString("InvalidPropertyValue").Replace("{0}", "XDimension").Replace("{1}", 0.01.ToString()).Replace("{2}", 100.0.ToString());
				this.GridBarcodeView.ErrorMessage(errorMessage);
				return;
			}
			this.View.ScheduleArrange();
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0001B188 File Offset: 0x00019388
		protected override bool ValidateParameters()
		{
			return base.ValidateParameters() && this.WidthToHeightRatio > 0.0 && this.XDimension >= 0.01 && this.XDimension <= 100.0;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001B1D5 File Offset: 0x000193D5
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ArrangeBarcode();
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0001B1E3 File Offset: 0x000193E3
		protected override void OnStretchChanged(global::System.Windows.Media.Stretch oldValue, global::System.Windows.Media.Stretch newValue)
		{
			base.OnStretchChanged(oldValue, newValue);
			if (this.BarcodeGrid != null)
			{
				this.View.ScheduleArrange();
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0001B200 File Offset: 0x00019400
		protected internal override void ArrangeBarcode()
		{
			if (this.BarcodeGrid == null)
			{
				return;
			}
			base.ArrangeBarcode();
			if (!base.IsValid)
			{
				this.ClearBarcodeGrid();
			}
			else if (!this.IsDimensionValid())
			{
				string @string = global::SR.GetString("InvalidDimension");
				global::System.Exception e_ = new global::System.ArgumentException(@string);
				base.ErrorMessage(e_);
				this.ClearBarcodeGrid();
			}
			if (!base.IsValid || !this.IsSymbolGenerated)
			{
				this.GridBarcodeView.MeasureBarcodeGrid();
				this.View.ArrangeComplete();
				return;
			}
			this.IsSymbolGenerated = false;
			try
			{
				this.BeginDrawBarcode();
				this.DrawBarcode();
				this.EndDrawBarcode();
			}
			catch (global::System.ArgumentException e_2)
			{
				base.ErrorMessage(e_2);
			}
			this.IsSymbolGenerated = true;
			this.GridBarcodeView.MeasureBarcodeGrid();
			this.View.ArrangeComplete();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0001B2CC File Offset: 0x000194CC
		protected internal override void UpdateBackground()
		{
			if (this.BarcodeGrid == null)
			{
				return;
			}
			this.BarcodeGrid.Background = base.Background;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0001B2E8 File Offset: 0x000194E8
		protected internal override void UpdateForeground()
		{
			if (this.BarcodeGrid == null || this.BarcodeGrid.FiguresPath == null)
			{
				return;
			}
			this.BarcodeGrid.FiguresPath.Fill = base.Foreground;
			this.BarcodeGrid.FiguresPath.Stroke = base.Foreground;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0001B337 File Offset: 0x00019537
		protected virtual void BeginDrawBarcode()
		{
			this.ClearBarcodeGrid();
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0001B33F File Offset: 0x0001953F
		protected virtual void DrawBarcode()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001B344 File Offset: 0x00019544
		protected internal virtual global::System.Windows.Size CalculateDefaultSize(double aspectRatio)
		{
			double num = 150.0;
			double num2 = 100.0;
			if (!base.IsValid)
			{
				if (!double.IsNaN(base.Width))
				{
					num = base.Width;
				}
				if (!double.IsNaN(base.Height))
				{
					num2 = base.Height;
				}
				return new global::System.Windows.Size(num, num2);
			}
			num = (double)this.BarcodeGrid.ColumnsDefinition.Count * global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(this.XDimension);
			num2 = this.WidthToHeightRatio * global::Infragistics.Controls.Barcodes.MeasureHelper.GetYPixels(this.XDimension);
			if (this.TextBlock != null && this.TextBlock.Visibility == global::System.Windows.Visibility.Visible)
			{
				global::System.Windows.Size labelSize = this.View.GetLabelSize(this.TextBlock);
				if (labelSize.Width > num)
				{
					num = labelSize.Width;
					num2 = num / aspectRatio;
				}
				num2 += labelSize.Height;
			}
			num = global::System.Math.Round(num - 0.5);
			num2 = global::System.Math.Round(num2 - 0.5);
			return new global::System.Windows.Size(num, num2);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001B440 File Offset: 0x00019640
		protected internal virtual double CalculateAspectRatio()
		{
			if (!base.IsValid)
			{
				return 2.0;
			}
			double num = (double)this.BarcodeGrid.ColumnsDefinition.Count;
			double widthToHeightRatio = this.WidthToHeightRatio;
			return num / widthToHeightRatio;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001B47C File Offset: 0x0001967C
		public global::Infragistics.Controls.Barcodes.VisualData.GridBarcodeVisualData ExportVisualData()
		{
			global::Infragistics.Controls.Barcodes.VisualData.GridBarcodeVisualData gridBarcodeVisualData = new global::Infragistics.Controls.Barcodes.VisualData.GridBarcodeVisualData();
			this.ExportVisualDataInternal(gridBarcodeVisualData);
			return gridBarcodeVisualData;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001B498 File Offset: 0x00019698
		internal override void ExportVisualDataInternal(global::Infragistics.Controls.Barcodes.VisualData.BarcodeVisualData barcodeVisualData)
		{
			base.ExportVisualDataInternal(barcodeVisualData);
			global::Infragistics.Controls.Barcodes.VisualData.GridBarcodeVisualData gridBarcodeVisualData = (global::Infragistics.Controls.Barcodes.VisualData.GridBarcodeVisualData)barcodeVisualData;
			gridBarcodeVisualData.FiguresPath = new global::Infragistics.PathVisualData("Figures", this.BarcodeGrid.FiguresPath);
			gridBarcodeVisualData.FiguresPathRect = new global::Infragistics.PathVisualData("BarcodeGrid", this.GridBarcodeView.ExportFiguresPathRect());
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001B4E9 File Offset: 0x000196E9
		internal void ClearBarcodeGrid()
		{
			if (this.BarcodeGrid != null)
			{
				this.BarcodeGrid.Clear();
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0001B500 File Offset: 0x00019700
		protected global::System.Windows.Controls.TextBlock AddText(string text, int startColumn, int columnSpan, int startRow, int rowSpan)
		{
			global::System.Windows.Controls.TextBlock textBlock = new global::System.Windows.Controls.TextBlock
			{
				Text = text,
				HorizontalAlignment = global::System.Windows.HorizontalAlignment.Center,
				VerticalAlignment = global::System.Windows.VerticalAlignment.Center
			};
			this.BarcodeGrid.TextPositions.Add(new global::Infragistics.Controls.Barcodes.Module(startRow, startColumn, rowSpan, columnSpan));
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
			{
				Source = this,
				Path = new global::System.Windows.PropertyPath("ShowText", new object[0]),
				Mode = global::System.Windows.Data.BindingMode.OneWay,
				Converter = new global::Infragistics.Controls.Primitives.BoolToVisibilityConverter()
			};
			textBlock.SetBinding(global::System.Windows.UIElement.VisibilityProperty, binding);
			this.BarcodeGrid.Children.Add(textBlock);
			return textBlock;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0001B59C File Offset: 0x0001979C
		protected void AddBarsColumns(byte[] bars)
		{
			if (bars == null)
			{
				return;
			}
			foreach (byte b in bars)
			{
				if (b == 0)
				{
					return;
				}
				this.AddColumns((double)b);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0001B5D0 File Offset: 0x000197D0
		protected void AddColumns(double number)
		{
			int num = 0;
			while ((double)num < number)
			{
				global::System.Windows.Controls.ColumnDefinition item = new global::System.Windows.Controls.ColumnDefinition
				{
					Width = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star)
				};
				this.BarcodeGrid.ColumnsDefinition.Add(item);
				num++;
			}
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001B618 File Offset: 0x00019818
		protected void AddRow(double height, global::System.Windows.GridUnitType type)
		{
			this.BarcodeGrid.RowsDefinition.Add(new global::System.Windows.Controls.RowDefinition
			{
				Height = new global::System.Windows.GridLength(height, type)
			});
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001B64C File Offset: 0x0001984C
		protected void FillBars(byte[] bars, bool isFirstBarPrinted, int startRow, int rowSpan, int startColumn)
		{
			if (bars == null)
			{
				return;
			}
			foreach (byte b in bars)
			{
				if (this.BarcodeGrid.ColumnsDefinition.Count + (int)b <= startColumn)
				{
					break;
				}
				if (this.BarcodeGrid.RowsDefinition.Count + (int)b <= startRow)
				{
					return;
				}
				this.FillCell(startColumn, (int)b, startRow, rowSpan, isFirstBarPrinted);
				startColumn += (int)b;
				isFirstBarPrinted = !isFirstBarPrinted;
			}
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001B6B8 File Offset: 0x000198B8
		protected void FillCell(int columnNumber, int colSpan, int rowNumber, int rowSpan, bool isBarPrinted)
		{
			if (isBarPrinted)
			{
				global::Infragistics.Controls.Barcodes.Module item = new global::Infragistics.Controls.Barcodes.Module(rowNumber, columnNumber, rowSpan, colSpan);
				this.BarcodeGrid.Modules.Add(item);
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001B6E8 File Offset: 0x000198E8
		protected void AddHorizontalQuietZone(int modulesNumber)
		{
			for (int i = 0; i < modulesNumber; i++)
			{
				this.AddColumns(1.0);
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001B710 File Offset: 0x00019910
		protected void AddVerticalQuietZone(int modulesNumber)
		{
			for (int i = 0; i < modulesNumber; i++)
			{
				this.AddRow(1.0, global::System.Windows.GridUnitType.Star);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001B739 File Offset: 0x00019939
		private void EndDrawBarcode()
		{
			if (base.ActualWidth == 0.0 || base.ActualHeight == 0.0)
			{
				return;
			}
			base.InvalidateMeasure();
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001B764 File Offset: 0x00019964
		private bool IsDimensionValid()
		{
			return this.BarsFillMode != global::Infragistics.Controls.Barcodes.BarsFillMode.EnsureEqualSize || base.Stretch != global::System.Windows.Media.Stretch.None || global::Infragistics.Controls.Barcodes.MeasureHelper.GetXPixels(this.XDimension) >= 1.0;
		}

		// Token: 0x040001C4 RID: 452
		internal const string BarcodeGridName = "BarcodeGrid";

		// Token: 0x040001C5 RID: 453
		private int _leftQuietZoneWidth;

		// Token: 0x040001C6 RID: 454
		private int _rightQuietZoneWidth;

		// Token: 0x040001C7 RID: 455
		private bool _isSymbolGenerated = true;

		// Token: 0x040001C8 RID: 456
		public static readonly global::System.Windows.DependencyProperty BarsFillModeProperty = global::System.Windows.DependencyProperty.Register("BarsFillMode", typeof(global::Infragistics.Controls.Barcodes.BarsFillMode), typeof(global::Infragistics.Controls.Barcodes.XamGridBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.BarsFillMode.FillSpace, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnBarsFillModeChanged)));

		// Token: 0x040001C9 RID: 457
		public static readonly global::System.Windows.DependencyProperty WidthToHeightRatioProperty = global::System.Windows.DependencyProperty.Register("WidthToHeightRatio", typeof(double), typeof(global::Infragistics.Controls.Barcodes.XamGridBarcode), new global::System.Windows.PropertyMetadata(3.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnWidthToHeightRatioChanged)));

		// Token: 0x040001CA RID: 458
		public static readonly global::System.Windows.DependencyProperty XDimensionProperty = global::System.Windows.DependencyProperty.Register("XDimension", typeof(double), typeof(global::Infragistics.Controls.Barcodes.XamGridBarcode), new global::System.Windows.PropertyMetadata(0.25, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
	}
}
