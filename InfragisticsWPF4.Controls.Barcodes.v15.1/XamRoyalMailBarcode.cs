using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200004F RID: 79
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamRoyalMailBarcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	public class XamRoyalMailBarcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00020BF1 File Offset: 0x0001EDF1
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00020BF9 File Offset: 0x0001EDF9
		private global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm RoyalMailAlgorithm { get; set; }

		// Token: 0x0600033C RID: 828 RVA: 0x00020C04 File Offset: 0x0001EE04
		static XamRoyalMailBarcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamRoyalMailBarcode), new global::System.Windows.PropertyMetadata(0.63, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
			global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamRoyalMailBarcode), new global::System.Windows.PropertyMetadata(11.0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnWidthToHeightRatioChanged)));
		}

		// Token: 0x0600033D RID: 829 RVA: 0x00020CA8 File Offset: 0x0001EEA8
		public XamRoyalMailBarcode()
		{
			this.RoyalMailAlgorithm = new global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamRoyalMailBarcode);
			base.LeftQuietZoneWidth = 5;
			base.RightQuietZoneWidth = 5;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamRoyalMailBarcode), this);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		protected override void DrawBarcode()
		{
			base.AddVerticalQuietZone(1);
			int count = base.BarcodeGrid.RowsDefinition.Count;
			base.AddRow(3.423, global::System.Windows.GridUnitType.Star);
			base.AddRow(2.413, global::System.Windows.GridUnitType.Star);
			base.AddRow(3.423, global::System.Windows.GridUnitType.Star);
			base.AddRow(base.FontSize + 2.0 * base.XDimension, global::System.Windows.GridUnitType.Auto);
			base.AddVerticalQuietZone(1);
			base.AddHorizontalQuietZone(base.LeftQuietZoneWidth);
			this.AddMailCharBars(global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars['('], count);
			int count2;
			int count3;
			foreach (char key in base.Data)
			{
				count2 = base.BarcodeGrid.ColumnsDefinition.Count;
				this.AddMailCharBars(global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars[key], count);
				count3 = base.BarcodeGrid.ColumnsDefinition.Count;
				base.AddText(key.ToString(), count2, count3 - count2, count + 3, 1);
			}
			count2 = base.BarcodeGrid.ColumnsDefinition.Count;
			char key2 = global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.GenerateCheckSum(base.Data);
			this.AddMailCharBars(global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars[key2], count);
			count3 = base.BarcodeGrid.ColumnsDefinition.Count;
			base.TextBlock = base.AddText(key2.ToString(), count2, count3 - count2, count + 3, 1);
			this.AddMailCharBars(global::Infragistics.Controls.Barcodes.RoyalMailAlgorithm.RoyalMailChars[')'], count);
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00020E80 File Offset: 0x0001F080
		protected override bool ValidateData(string data)
		{
			return base.ValidateData(data) && global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00020EA6 File Offset: 0x0001F0A6
		protected override string GetDesignTimeFakeData()
		{
			return "ROYALMAIL";
		}

		// Token: 0x06000341 RID: 833 RVA: 0x00020EB0 File Offset: 0x0001F0B0
		private void AddMailCharBars(byte[] bars, int startBarsRow)
		{
			int i = 0;
			while (i < bars.Length)
			{
				int num = (int)bars[i];
				base.AddColumns(1.0);
				base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, base.BarcodeGrid.RowsDefinition.Count - 1 - 1, 1, false);
				switch (num)
				{
				case 1:
					base.AddColumns(1.0);
					base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, startBarsRow + 1, 1, true);
					break;
				case 2:
					base.AddColumns(1.0);
					base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, startBarsRow, 2, true);
					break;
				case 3:
					base.AddColumns(1.0);
					base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, startBarsRow + 1, 2, true);
					break;
				case 4:
					goto IL_F8;
				default:
					goto IL_F8;
				}
				IL_123:
				i++;
				continue;
				IL_F8:
				base.AddColumns(1.0);
				base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, startBarsRow, 3, true);
				goto IL_123;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00020FED File Offset: 0x0001F1ED
		// (set) Token: 0x06000343 RID: 835 RVA: 0x00020FFF File Offset: 0x0001F1FF
		public bool ShowText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamRoyalMailBarcode.ShowTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamRoyalMailBarcode.ShowTextProperty, value);
			}
		}

		// Token: 0x04000203 RID: 515
		public static readonly global::System.Windows.DependencyProperty ShowTextProperty = global::System.Windows.DependencyProperty.Register("ShowText", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamRoyalMailBarcode), new global::System.Windows.PropertyMetadata(true));
	}
}
