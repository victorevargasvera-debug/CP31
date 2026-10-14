using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000045 RID: 69
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCode128Barcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	public class XamCode128Barcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0001B85F File Offset: 0x00019A5F
		// (set) Token: 0x0600024E RID: 590 RVA: 0x0001B867 File Offset: 0x00019A67
		private global::Infragistics.Controls.Barcodes.Code128Algorithm Code128Algorithm { get; set; }

		// Token: 0x0600024F RID: 591 RVA: 0x0001B870 File Offset: 0x00019A70
		static XamCode128Barcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamCode128Barcode), new global::System.Windows.PropertyMetadata(1.016, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
			global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamCode128Barcode), new global::System.Windows.PropertyMetadata(30.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnWidthToHeightRatioChanged)));
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001B94C File Offset: 0x00019B4C
		public XamCode128Barcode()
		{
			this.Code128Algorithm = new global::Infragistics.Controls.Barcodes.Code128Algorithm();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamCode128Barcode);
			base.LeftQuietZoneWidth = 10;
			base.RightQuietZoneWidth = 10;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamCode128Barcode), this);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001B99C File Offset: 0x00019B9C
		protected override bool ValidateData(string data)
		{
			if (!base.ValidateData(data) || !global::Infragistics.Controls.Barcodes.XamCode128Barcode.AreAllAscii(data))
			{
				return false;
			}
			if (this.CodeType == global::Infragistics.Controls.Barcodes.Code128CodeType.Ucc)
			{
				string text = global::Infragistics.Controls.Barcodes.Code128Encoder.VerifyUccValue(data, this.CodeType);
				if (text.Length == 0)
				{
					return false;
				}
			}
			return data.Length <= 48;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001B9FC File Offset: 0x00019BFC
		private static bool AreAllAscii(string data)
		{
			return data.ToCharArray().All((char c) => c >= '\0' && c <= 'ÿ');
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001BA28 File Offset: 0x00019C28
		protected override void DrawBarcode()
		{
			base.AddRow(base.WidthToHeightRatio, global::System.Windows.GridUnitType.Star);
			base.AddRow(base.FontSize + 2.0 * base.XDimension, global::System.Windows.GridUnitType.Auto);
			string text = global::Infragistics.Controls.Barcodes.Code128Encoder.VerifyUccValue(base.Data, this.CodeType);
			if (string.IsNullOrEmpty(text))
			{
				string errorMessage = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidAI"), new object[0]);
				base.ErrorMessage(errorMessage);
				base.ClearBarcodeGrid();
				return;
			}
			string text2 = (this.CodeType == global::Infragistics.Controls.Barcodes.Code128CodeType.Ucc) ? global::Infragistics.Controls.Barcodes.Code128Encoder.GetHumanReadableUccEan(text) : global::Infragistics.Controls.Barcodes.Code128Encoder.RemoveFnc1(text);
			string text3 = global::Infragistics.Controls.Barcodes.Code128Encoder.ConvertCode(text, this.CodeType == global::Infragistics.Controls.Barcodes.Code128CodeType.Ucc);
			if (text3.Length == 0)
			{
				base.IsValid = false;
				return;
			}
			text3 += global::Infragistics.Controls.Barcodes.Code128Algorithm.GenerateCheckDigit(text3);
			base.AddHorizontalQuietZone(base.LeftQuietZoneWidth);
			char[] array = text3.ToCharArray();
			int num = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[(int)array[0]]);
			base.FillBars(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[(int)array[0]], true, 0, 1, num);
			num = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[(int)array[1]]);
			base.FillBars(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[(int)array[1]], true, 0, 1, num);
			for (int i = 2; i < array.Length - 1; i++)
			{
				int key = (int)array[i];
				num = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[key]);
				base.FillBars(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[key], true, 0, 1, num);
			}
			num = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[(int)array[array.Length - 1]]);
			base.FillBars(global::Infragistics.Controls.Barcodes.Code128Algorithm.Code128Chars[(int)array[array.Length - 1]], true, 0, 1, num);
			num = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Code128Algorithm.StopChar);
			base.FillBars(global::Infragistics.Controls.Barcodes.Code128Algorithm.StopChar, true, 0, 1, num);
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
			num = base.BarcodeGrid.ColumnsDefinition.Count - base.LeftQuietZoneWidth - base.RightQuietZoneWidth;
			base.TextBlock = base.AddText(text2, base.LeftQuietZoneWidth, num, 1, 1);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001BC90 File Offset: 0x00019E90
		protected override string GetDesignTimeFakeData()
		{
			global::Infragistics.Controls.Barcodes.Code128CodeType codeType = this.CodeType;
			if (codeType == global::Infragistics.Controls.Barcodes.Code128CodeType.Ucc)
			{
				return "(01)12345678901234";
			}
			return "Code 128";
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000255 RID: 597 RVA: 0x0001BCB3 File Offset: 0x00019EB3
		// (set) Token: 0x06000256 RID: 598 RVA: 0x0001BCC5 File Offset: 0x00019EC5
		public bool ShowText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamCode128Barcode.ShowTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamCode128Barcode.ShowTextProperty, value);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0001BCD8 File Offset: 0x00019ED8
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0001BCEA File Offset: 0x00019EEA
		public global::Infragistics.Controls.Barcodes.Code128CodeType CodeType
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.Code128CodeType)base.GetValue(global::Infragistics.Controls.Barcodes.XamCode128Barcode.CodeTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamCode128Barcode.CodeTypeProperty, value);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0001BCFD File Offset: 0x00019EFD
		private static void OnCodeTypeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamCode128Barcode)d).OnCodeTypeChanged((global::Infragistics.Controls.Barcodes.Code128CodeType)e.OldValue, (global::Infragistics.Controls.Barcodes.Code128CodeType)e.NewValue);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0001BD22 File Offset: 0x00019F22
		private void OnCodeTypeChanged(global::Infragistics.Controls.Barcodes.Code128CodeType oldValue, global::Infragistics.Controls.Barcodes.Code128CodeType newValue)
		{
			this.ArrangeBarcode();
		}

		// Token: 0x040001CF RID: 463
		public static readonly global::System.Windows.DependencyProperty ShowTextProperty = global::System.Windows.DependencyProperty.Register("ShowText", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamCode128Barcode), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x040001D0 RID: 464
		public static readonly global::System.Windows.DependencyProperty CodeTypeProperty = global::System.Windows.DependencyProperty.Register("CodeType", typeof(global::Infragistics.Controls.Barcodes.Code128CodeType), typeof(global::Infragistics.Controls.Barcodes.XamCode128Barcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.Code128CodeType.Standard, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamCode128Barcode.OnCodeTypeChanged)));
	}
}
