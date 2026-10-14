using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200004B RID: 75
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamInterleaved2Of5Barcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	public class XamInterleaved2Of5Barcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0001E627 File Offset: 0x0001C827
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0001E62F File Offset: 0x0001C82F
		private global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm Interleaved2Of5Algorithm { get; set; }

		// Token: 0x060002B0 RID: 688 RVA: 0x0001E638 File Offset: 0x0001C838
		static XamInterleaved2Of5Barcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode), new global::System.Windows.PropertyMetadata(0.33, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
			global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode), new global::System.Windows.PropertyMetadata(30.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnWidthToHeightRatioChanged)));
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0001E714 File Offset: 0x0001C914
		public XamInterleaved2Of5Barcode()
		{
			this.Interleaved2Of5Algorithm = new global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode);
			base.LeftQuietZoneWidth = 10;
			base.RightQuietZoneWidth = 10;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode), this);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0001E764 File Offset: 0x0001C964
		protected override bool ValidateData(string data)
		{
			return base.ValidateData(data) && global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789");
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001E78C File Offset: 0x0001C98C
		protected override void DrawBarcode()
		{
			double height = base.FontSize + 2.0 * base.XDimension;
			base.AddRow(base.WidthToHeightRatio, global::System.Windows.GridUnitType.Star);
			base.AddRow(height, global::System.Windows.GridUnitType.Auto);
			string text = base.Data;
			if (this.ShouldGenerateChecksum)
			{
				text += global::Infragistics.Controls.Barcodes.Interleaved2Of5Encoder.GenerateCheckDigit(text);
			}
			string text2 = global::Infragistics.Controls.Barcodes.Interleaved2Of5Encoder.VerifyI25Code(text);
			base.AddHorizontalQuietZone(base.LeftQuietZoneWidth);
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.StartPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.StartPattern, true, 0, 1, count);
			int num = text2.Length / 2;
			for (int i = 0; i < num; i++)
			{
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				int key = (int)(text2[i * 2] - '0');
				int key2 = (int)(text2[i * 2 + 1] - '0');
				byte[] array = global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[key];
				byte[] array2 = global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.I25Chars[key2];
				for (int j = 0; j < 5; j++)
				{
					count = base.BarcodeGrid.ColumnsDefinition.Count;
					base.AddColumns((double)array[j]);
					base.FillCell(count, (int)array[j], 0, 1, true);
					base.AddColumns((double)array2[j]);
				}
				base.TextBlock = base.AddText(key.ToString(global::Infragistics.CultureInfoHelper.CultureToUse), count2, 7, 1, 1);
				base.AddText(key2.ToString(global::Infragistics.CultureInfoHelper.CultureToUse), count2 + 7, 7, 1, 1);
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.StopPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.Interleaved2Of5Algorithm.StopPattern, true, 0, 1, count);
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0001E94A File Offset: 0x0001CB4A
		protected override string GetDesignTimeFakeData()
		{
			return "01234567";
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0001E951 File Offset: 0x0001CB51
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0001E963 File Offset: 0x0001CB63
		public bool ShowText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode.ShowTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode.ShowTextProperty, value);
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0001E976 File Offset: 0x0001CB76
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x0001E988 File Offset: 0x0001CB88
		public bool ShouldGenerateChecksum
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode.ShouldGenerateChecksumProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode.ShouldGenerateChecksumProperty, value);
			}
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0001E99B File Offset: 0x0001CB9B
		private static void OnShouldGenerateChecksumChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode)d).OnShouldGenerateChecksumChanged((bool)e.OldValue, (bool)e.NewValue);
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0001E9C0 File Offset: 0x0001CBC0
		private void OnShouldGenerateChecksumChanged(bool oldValue, bool newValue)
		{
			this.ArrangeBarcode();
		}

		// Token: 0x040001E3 RID: 483
		public static readonly global::System.Windows.DependencyProperty ShowTextProperty = global::System.Windows.DependencyProperty.Register("ShowText", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x040001E4 RID: 484
		public static readonly global::System.Windows.DependencyProperty ShouldGenerateChecksumProperty = global::System.Windows.DependencyProperty.Register("ShouldGenerateChecksum", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamInterleaved2Of5Barcode.OnShouldGenerateChecksumChanged)));
	}
}
