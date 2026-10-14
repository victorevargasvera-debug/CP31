using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000043 RID: 67
	public class XamBarcodeView
	{
		// Token: 0x0600020C RID: 524 RVA: 0x0001AD70 File Offset: 0x00018F70
		public XamBarcodeView(global::Infragistics.Controls.Barcodes.XamBarcode barcode)
		{
			this.Barcode = barcode;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600020D RID: 525 RVA: 0x0001ADB8 File Offset: 0x00018FB8
		// (set) Token: 0x0600020E RID: 526 RVA: 0x0001ADC0 File Offset: 0x00018FC0
		protected global::Infragistics.Controls.Barcodes.XamBarcode Barcode { get; set; }

		// Token: 0x0600020F RID: 527 RVA: 0x0001ADC9 File Offset: 0x00018FC9
		public virtual void OnTemplateProvided(global::System.Func<string, global::System.Windows.DependencyObject> getTemplateChild)
		{
			this._errorTextBlock = (getTemplateChild("ErrorTextBlock") as global::System.Windows.Controls.TextBlock);
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0001ADE1 File Offset: 0x00018FE1
		public global::System.Windows.Controls.TextBlock GetErrorTextBlock()
		{
			return this._errorTextBlock;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0001ADEC File Offset: 0x00018FEC
		public global::System.Windows.Size GetLabelSize(global::System.Windows.Controls.TextBlock tb)
		{
			if (tb.Parent == null)
			{
				this._hiddenText.Text = tb.Text;
				tb = this._hiddenText;
			}
			tb.InvalidateMeasure();
			tb.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
			return tb.DesiredSize;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0001AE45 File Offset: 0x00019045
		public void OnInit()
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001AE47 File Offset: 0x00019047
		public void ScheduleArrange()
		{
			this.Barcode.ArrangeBarcode();
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0001AE54 File Offset: 0x00019054
		internal void PositionLabel(global::System.Windows.Controls.TextBlock tb, double x, double y)
		{
			global::System.Windows.Controls.Canvas.SetLeft(tb, x);
			global::System.Windows.Controls.Canvas.SetTop(tb, y);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001AE64 File Offset: 0x00019064
		public void ArrangeComplete()
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0001AE66 File Offset: 0x00019066
		internal void SetTextBrush(global::System.Windows.Controls.TextBlock tb, global::System.Windows.Media.Brush b)
		{
			if (b != null)
			{
				tb.Foreground = b;
				return;
			}
			tb.ClearValue(global::System.Windows.Controls.TextBlock.ForegroundProperty);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0001AE7E File Offset: 0x0001907E
		internal void OnBrushChanged(string propertyName, object oldValue, object newValue)
		{
		}

		// Token: 0x040001C0 RID: 448
		private const string ErrorTextBlockName = "ErrorTextBlock";

		// Token: 0x040001C1 RID: 449
		private global::System.Windows.Controls.TextBlock _hiddenText = new global::System.Windows.Controls.TextBlock
		{
			IsHitTestVisible = false,
			Opacity = 0.0
		};

		// Token: 0x040001C2 RID: 450
		private global::System.Windows.Controls.TextBlock _errorTextBlock = new global::System.Windows.Controls.TextBlock();
	}
}
