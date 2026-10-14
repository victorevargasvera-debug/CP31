using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000047 RID: 71
	[global::Infragistics.Windows.Licensing.UltraLicense("XamEanUpcBarcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamEanUpcBarcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600026F RID: 623 RVA: 0x0001C1CC File Offset: 0x0001A3CC
		// (set) Token: 0x06000270 RID: 624 RVA: 0x0001C1D4 File Offset: 0x0001A3D4
		private global::Infragistics.Controls.Barcodes.EanUpcAlgorithm EanUpcAlgorithm { get; set; }

		// Token: 0x06000271 RID: 625 RVA: 0x0001C1E0 File Offset: 0x0001A3E0
		static XamEanUpcBarcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode), new global::System.Windows.PropertyMetadata(0.33, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
			global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode), new global::System.Windows.PropertyMetadata(79.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnWidthToHeightRatioChanged)));
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001C2BB File Offset: 0x0001A4BB
		public XamEanUpcBarcode()
		{
			this.EanUpcAlgorithm = new global::Infragistics.Controls.Barcodes.EanUpcAlgorithm();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode);
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode), this);
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
		protected override bool ValidateData(string data)
		{
			if (string.IsNullOrEmpty(data))
			{
				return base.ValidateData(data);
			}
			bool flag = false;
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean13:
				flag = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ValidateNumericCodeLength(data, 12);
				goto IL_C0;
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean8:
				flag = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ValidateNumericCodeLength(data, 7);
				goto IL_C0;
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.UpcA:
				flag = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ValidateNumericCodeLength(data, 11);
				goto IL_C0;
			}
			if ((data.Length == 11 || data.Length == 7) && data.StartsWith("0", global::System.StringComparison.CurrentCulture))
			{
				flag = (global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789") || global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789"));
			}
			if (data.Length == 10 || data.Length == 6)
			{
				flag = (global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789") || global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789"));
			}
			IL_C0:
			return flag && base.ValidateData(data);
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001C3C9 File Offset: 0x0001A5C9
		protected override void BeginDrawBarcode()
		{
			base.BeginDrawBarcode();
			this.SetQuietZonesValues();
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0001C3D8 File Offset: 0x0001A5D8
		protected override void DrawBarcode()
		{
			base.AddRow(base.WidthToHeightRatio, global::System.Windows.GridUnitType.Star);
			double num = base.FontSize + 2.0 * global::Infragistics.Controls.Barcodes.MeasureHelper.GetYPixels(base.XDimension);
			base.AddRow(num / 2.0, global::System.Windows.GridUnitType.Auto);
			base.AddRow(num / 2.0, global::System.Windows.GridUnitType.Auto);
			if (!base.IsValid)
			{
				return;
			}
			string text = base.Data;
			if (this.CodeType == global::Infragistics.Controls.Barcodes.EanUpcCodeType.UpcE)
			{
				if (text.Length == 10 || text.Length == 6)
				{
					text = "0" + text;
				}
				string code = text;
				if (text.Length == 7)
				{
					code = global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ConvertUpcEToUpcA(text);
				}
				text += global::Infragistics.Controls.Barcodes.Gs1Helper.GenerateCheckDigit(code);
				if (text.Length == 12)
				{
					text = global::Infragistics.Controls.Barcodes.EanUpcEncoder.EncodeGtin12ToUpcECode(text);
				}
				if (text.Length != 8)
				{
					base.IsValid = false;
					throw new global::System.ArgumentException(base.ErrorMessageText);
				}
			}
			else
			{
				text += global::Infragistics.Controls.Barcodes.Gs1Helper.GenerateCheckDigit(base.Data);
			}
			base.AddHorizontalQuietZone(base.LeftQuietZoneWidth);
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean13:
				this.AddBarsEan13(text);
				return;
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean8:
				this.AddBarsEan8(text);
				return;
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.UpcA:
				this.AddBarsUpcA(text);
				return;
			}
			this.AddBarsUpcE(text);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0001C514 File Offset: 0x0001A714
		protected override string GetDesignTimeFakeData()
		{
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean13:
				return "123456789012";
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean8:
				return "1234567";
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.UpcE:
				return "0123456";
			}
			return "12345678901";
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0001C557 File Offset: 0x0001A757
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0001C569 File Offset: 0x0001A769
		public bool ShowText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode.ShowTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode.ShowTextProperty, value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000279 RID: 633 RVA: 0x0001C57C File Offset: 0x0001A77C
		// (set) Token: 0x0600027A RID: 634 RVA: 0x0001C58E File Offset: 0x0001A78E
		public global::Infragistics.Controls.Barcodes.EanUpcCodeType CodeType
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.EanUpcCodeType)base.GetValue(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode.CodeTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode.CodeTypeProperty, value);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001C5A1 File Offset: 0x0001A7A1
		private static void OnCodeTypeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamEanUpcBarcode)d).OnCodeTypeChanged((global::Infragistics.Controls.Barcodes.EanUpcCodeType)e.OldValue, (global::Infragistics.Controls.Barcodes.EanUpcCodeType)e.NewValue);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0001C5C6 File Offset: 0x0001A7C6
		private void OnCodeTypeChanged(global::Infragistics.Controls.Barcodes.EanUpcCodeType oldValue, global::Infragistics.Controls.Barcodes.EanUpcCodeType newValue)
		{
			if (newValue == global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean8 && newValue != oldValue)
			{
				base.WidthToHeightRatio = 65.0;
			}
			else if (newValue != global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean8 && oldValue == global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean8)
			{
				base.WidthToHeightRatio = 79.0;
			}
			this.ArrangeBarcode();
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001C600 File Offset: 0x0001A800
		private void SetQuietZonesValues()
		{
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean13:
				base.LeftQuietZoneWidth = 11;
				base.RightQuietZoneWidth = 7;
				return;
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.Ean8:
				base.LeftQuietZoneWidth = 7;
				base.RightQuietZoneWidth = 7;
				return;
			case global::Infragistics.Controls.Barcodes.EanUpcCodeType.UpcA:
				base.LeftQuietZoneWidth = 9;
				base.RightQuietZoneWidth = 9;
				return;
			}
			base.LeftQuietZoneWidth = 9;
			base.RightQuietZoneWidth = 7;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x0001C66C File Offset: 0x0001A86C
		private void AddBarsUpcA(string code)
		{
			char[] array = code.ToCharArray();
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.TextBlock = base.AddText(array[0].ToString(), 0, count, 1, 2);
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern, true, 0, 2, count);
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			byte[] upcBars = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(array[0]);
			base.AddBarsColumns(upcBars);
			base.FillBars(upcBars, false, 0, 2, count);
			for (int i = 1; i < 6; i++)
			{
				count = base.BarcodeGrid.ColumnsDefinition.Count;
				char input = array[i];
				byte[] upcBars2 = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(input);
				base.AddBarsColumns(upcBars2);
				base.FillBars(upcBars2, false, 0, 1, count);
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddText(input.ToString(), count, count2 - count, 1, 2);
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.MiddlePattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.MiddlePattern, false, 0, 2, count);
			for (int j = 6; j < 11; j++)
			{
				count = base.BarcodeGrid.ColumnsDefinition.Count;
				char input2 = array[j];
				byte[] upcBars3 = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(input2);
				base.AddBarsColumns(upcBars3);
				base.FillBars(upcBars3, true, 0, 1, count);
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddText(input2.ToString(), count, count2 - count, 1, 2);
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			byte[] upcBars4 = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(array[11]);
			base.AddBarsColumns(upcBars4);
			base.FillBars(upcBars4, true, 0, 2, count);
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern, true, 0, 2, count);
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
			base.TextBlock = base.AddText(array[11].ToString(), count, base.RightQuietZoneWidth, 1, 2);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0001C88C File Offset: 0x0001AA8C
		private void AddBarsEan13(string code)
		{
			char[] array = code.ToCharArray();
			base.TextBlock = base.AddText(array[0].ToString(), 0, base.LeftQuietZoneWidth, 1, 2);
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern, true, 0, 2, count);
			byte[] array2 = global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.Parity13[array[0]];
			for (int i = 0; i < array2.Length; i++)
			{
				count = base.BarcodeGrid.ColumnsDefinition.Count;
				char input = array[i + 1];
				byte[] upcBars = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(input);
				if (array2[i] == 0)
				{
					base.AddBarsColumns(upcBars);
					base.FillBars(upcBars, false, 0, 1, count);
				}
				else
				{
					byte[] bars = new byte[]
					{
						upcBars[3],
						upcBars[2],
						upcBars[1],
						upcBars[0]
					};
					base.AddBarsColumns(bars);
					base.FillBars(bars, false, 0, 1, count);
				}
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddText(input.ToString(), count, count2 - count, 1, 2);
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.MiddlePattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.MiddlePattern, false, 0, 2, count);
			for (int j = 7; j < 13; j++)
			{
				char input2 = array[j];
				count = base.BarcodeGrid.ColumnsDefinition.Count;
				byte[] upcBars2 = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(input2);
				base.AddBarsColumns(upcBars2);
				base.FillBars(upcBars2, true, 0, 1, count);
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddText(input2.ToString(), count, count2 - count, 1, 2);
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern, true, 0, 2, count);
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0001CA84 File Offset: 0x0001AC84
		private void AddBarsEan8(string code)
		{
			char[] array = code.ToCharArray();
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern, true, 0, 2, count);
			for (int i = 0; i < 4; i++)
			{
				count = base.BarcodeGrid.ColumnsDefinition.Count;
				char input = array[i];
				byte[] upcBars = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(input);
				base.AddBarsColumns(upcBars);
				base.FillBars(upcBars, false, 0, 1, count);
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				if (base.TextBlock == null)
				{
					base.TextBlock = base.AddText(input.ToString(), count, count2 - count, 1, 2);
				}
				else
				{
					base.AddText(input.ToString(), count, count2 - count, 1, 2);
				}
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.MiddlePattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.MiddlePattern, false, 0, 2, count);
			for (int j = 4; j < 8; j++)
			{
				count = base.BarcodeGrid.ColumnsDefinition.Count;
				char input2 = array[j];
				byte[] upcBars2 = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(input2);
				base.AddBarsColumns(upcBars2);
				base.FillBars(upcBars2, true, 0, 1, count);
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddText(input2.ToString(), count, count2 - count, 1, 2);
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern, true, 0, 2, count);
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001CC18 File Offset: 0x0001AE18
		private void AddBarsUpcE(string code)
		{
			char[] array = code.ToCharArray();
			bool flag = array[0] != '0';
			base.TextBlock = base.AddText(array[0].ToString(), 0, base.LeftQuietZoneWidth, 1, 2);
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.FinderPattern, true, 0, 2, count);
			byte[] array2 = global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.ParityE[array[array.Length - 1]];
			for (int i = 1; i < array.Length - 1; i++)
			{
				count = base.BarcodeGrid.ColumnsDefinition.Count;
				char input = array[i];
				byte[] upcBars = global::Infragistics.Controls.Barcodes.EanUpcEncoder.GetUpcBars(input);
				if (array2[i - 1] == (flag ? 1 : 0))
				{
					base.AddBarsColumns(upcBars);
					base.FillBars(upcBars, false, 0, 1, count);
				}
				else
				{
					byte[] bars = new byte[]
					{
						upcBars[3],
						upcBars[2],
						upcBars[1],
						upcBars[0]
					};
					base.AddBarsColumns(bars);
					base.FillBars(bars, false, 0, 1, count);
				}
				int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddText(input.ToString(), count, count2 - count, 1, 2);
			}
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcEStopPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.EanUpcAlgorithm.UpcEStopPattern, false, 0, 2, count);
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
			base.AddText(array[7].ToString(), count, base.RightQuietZoneWidth, 1, 2);
		}

		// Token: 0x040001D7 RID: 471
		public static readonly global::System.Windows.DependencyProperty ShowTextProperty = global::System.Windows.DependencyProperty.Register("ShowText", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x040001D8 RID: 472
		public static readonly global::System.Windows.DependencyProperty CodeTypeProperty = global::System.Windows.DependencyProperty.Register("CodeType", typeof(global::Infragistics.Controls.Barcodes.EanUpcCodeType), typeof(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.EanUpcCodeType.UpcA, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamEanUpcBarcode.OnCodeTypeChanged)));
	}
}
