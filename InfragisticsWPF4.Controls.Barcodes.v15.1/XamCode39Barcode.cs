using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000046 RID: 70
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCode39Barcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCode39Barcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600025C RID: 604 RVA: 0x0001BD2A File Offset: 0x00019F2A
		// (set) Token: 0x0600025D RID: 605 RVA: 0x0001BD32 File Offset: 0x00019F32
		private global::Infragistics.Controls.Barcodes.Code39Algorithm Code39Algorithm { get; set; }

		// Token: 0x0600025E RID: 606 RVA: 0x0001BD3C File Offset: 0x00019F3C
		static XamCode39Barcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamCode39Barcode), new global::System.Windows.PropertyMetadata(30.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnWidthToHeightRatioChanged)));
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamCode39Barcode), new global::System.Windows.PropertyMetadata(0.33, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0001BE60 File Offset: 0x0001A060
		public XamCode39Barcode()
		{
			this.Code39Algorithm = new global::Infragistics.Controls.Barcodes.Code39Algorithm();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamCode39Barcode);
			base.LeftQuietZoneWidth = 10;
			base.RightQuietZoneWidth = 10;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamCode39Barcode), this);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0001BEB0 File Offset: 0x0001A0B0
		protected override bool ValidateData(string data)
		{
			if (!base.ValidateData(data))
			{
				return false;
			}
			if (this.Extended)
			{
				for (int i = 0; i < data.Length; i++)
				{
					if (data[i] > '\u007f')
					{
						return false;
					}
				}
			}
			else
			{
				for (int j = 0; j < data.Length; j++)
				{
					int num = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. $/+%".IndexOf(data[j]);
					if (num < 0)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0001BF1C File Offset: 0x0001A11C
		protected override void DrawBarcode()
		{
			base.AddRow(base.WidthToHeightRatio, global::System.Windows.GridUnitType.Star);
			base.AddRow(base.FontSize + 2.0 * base.XDimension, global::System.Windows.GridUnitType.Auto);
			string text = base.Data;
			string text2 = text;
			if (this.Extended)
			{
				text = global::Infragistics.Controls.Barcodes.Code39Encoder.ConvertCode39ExCode(text);
			}
			if (this.ShouldGenerateChecksum)
			{
				string text3 = global::Infragistics.Controls.Barcodes.Code39Encoder.GenerateCheckDigit(text);
				if (string.IsNullOrEmpty(text3))
				{
					return;
				}
				text += text3;
				text2 += text3;
			}
			base.AddHorizontalQuietZone(base.LeftQuietZoneWidth);
			int num = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['*']);
			base.FillBars(global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['*'], true, 0, 1, num);
			base.AddColumns(1.0);
			for (int i = 0; i < text.Length; i++)
			{
				num = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars[text[i]]);
				base.FillBars(global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars[text[i]], true, 0, 1, num);
				base.AddColumns(1.0);
			}
			num = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['*']);
			base.FillBars(global::Infragistics.Controls.Barcodes.Code39Algorithm.Code39Chars['*'], true, 0, 1, num);
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
			num = base.BarcodeGrid.ColumnsDefinition.Count - base.RightQuietZoneWidth - base.LeftQuietZoneWidth;
			base.TextBlock = base.AddText(text2, base.LeftQuietZoneWidth, num, 1, 1);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0001C0CB File Offset: 0x0001A2CB
		protected override string GetDesignTimeFakeData()
		{
			return "CODE39";
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000263 RID: 611 RVA: 0x0001C0D2 File Offset: 0x0001A2D2
		// (set) Token: 0x06000264 RID: 612 RVA: 0x0001C0E4 File Offset: 0x0001A2E4
		public bool ShowText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamCode39Barcode.ShowTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamCode39Barcode.ShowTextProperty, value);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001C0F7 File Offset: 0x0001A2F7
		private static void OnShowTextChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamCode39Barcode)d).OnShowTextChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001C11C File Offset: 0x0001A31C
		private void OnShowTextChanged(bool oldValue, bool newValue)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0001C11E File Offset: 0x0001A31E
		// (set) Token: 0x06000268 RID: 616 RVA: 0x0001C130 File Offset: 0x0001A330
		public bool Extended
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamCode39Barcode.ExtendedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamCode39Barcode.ExtendedProperty, value);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0001C143 File Offset: 0x0001A343
		private static void OnExtendedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamCode39Barcode)d).OnExtendedChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0001C168 File Offset: 0x0001A368
		private void OnExtendedChanged(bool oldValue, bool newValue)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600026B RID: 619 RVA: 0x0001C175 File Offset: 0x0001A375
		// (set) Token: 0x0600026C RID: 620 RVA: 0x0001C187 File Offset: 0x0001A387
		public bool ShouldGenerateChecksum
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamCode39Barcode.ShouldGenerateChecksumProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamCode39Barcode.ShouldGenerateChecksumProperty, value);
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0001C19A File Offset: 0x0001A39A
		private static void OnShouldGenerateChecksumChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamCode39Barcode)d).OnShouldGenerateChecksumChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001C1BF File Offset: 0x0001A3BF
		private void OnShouldGenerateChecksumChanged(bool oldValue, bool newValue)
		{
			this.View.ScheduleArrange();
		}

		// Token: 0x040001D3 RID: 467
		public static readonly global::System.Windows.DependencyProperty ShowTextProperty = global::System.Windows.DependencyProperty.Register("ShowText", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamCode39Barcode), new global::System.Windows.PropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamCode39Barcode.OnShowTextChanged)));

		// Token: 0x040001D4 RID: 468
		public static readonly global::System.Windows.DependencyProperty ExtendedProperty = global::System.Windows.DependencyProperty.Register("Extended", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamCode39Barcode), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamCode39Barcode.OnExtendedChanged)));

		// Token: 0x040001D5 RID: 469
		public static readonly global::System.Windows.DependencyProperty ShouldGenerateChecksumProperty = global::System.Windows.DependencyProperty.Register("ShouldGenerateChecksum", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamCode39Barcode), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamCode39Barcode.OnShouldGenerateChecksumChanged)));
	}
}
