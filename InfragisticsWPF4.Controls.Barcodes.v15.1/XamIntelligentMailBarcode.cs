using System;
using System.ComponentModel;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x0200004A RID: 74
	[global::Infragistics.Windows.Licensing.UltraLicense("XamIntelligentMailBarcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamIntelligentMailBarcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x0001E279 File Offset: 0x0001C479
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x0001E281 File Offset: 0x0001C481
		private global::Infragistics.Controls.Barcodes.IntelligentMailEncoder IntelligentMailEncoder { get; set; }

		// Token: 0x060002A9 RID: 681 RVA: 0x0001E28C File Offset: 0x0001C48C
		static XamIntelligentMailBarcode()
		{
			double num = 0.635;
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamIntelligentMailBarcode), new global::System.Windows.PropertyMetadata(num, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
			global::Infragistics.Controls.Barcodes.XamGridBarcode.WidthToHeightRatioProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamIntelligentMailBarcode), new global::System.Windows.PropertyMetadata(130.0 * num / (global::Infragistics.Controls.Barcodes.MeasureHelper.ConvertToMilimeters(0.165) + 4.0 * num), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnWidthToHeightRatioChanged)));
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0001E320 File Offset: 0x0001C520
		public XamIntelligentMailBarcode()
		{
			this.IntelligentMailEncoder = new global::Infragistics.Controls.Barcodes.IntelligentMailEncoder();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamIntelligentMailBarcode);
			base.LeftQuietZoneWidth = 5;
			base.RightQuietZoneWidth = 5;
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamIntelligentMailBarcode), this);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0001E370 File Offset: 0x0001C570
		protected override bool ValidateData(string data)
		{
			if (string.IsNullOrEmpty(data) || (data.Length != 20 && data.Length != 25 && data.Length != 29 && data.Length != 31))
			{
				return false;
			}
			bool flag = base.ValidateData(data) && global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789");
			return (data[1] == '4' || data[1] == '3' || data[1] == '2' || data[1] == '1' || data[1] == '0') && flag;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0001E404 File Offset: 0x0001C604
		protected override void DrawBarcode()
		{
			base.AddVerticalQuietZone(2);
			base.AddRow(54.0, global::System.Windows.GridUnitType.Star);
			base.AddRow(57.0, global::System.Windows.GridUnitType.Star);
			base.AddRow(54.0, global::System.Windows.GridUnitType.Star);
			base.AddVerticalQuietZone(2);
			string str = base.Data.Substring(0, 2);
			string str2 = base.Data.Substring(2, 3);
			int num = base.Data[5].Equals('9') ? 9 : 6;
			string str3 = base.Data.Substring(5, num);
			string str4 = base.Data.Substring(5 + num, 20 - (5 + num));
			string routingCode = base.Data.Substring(20);
			string trackingCode = str + str2 + str3 + str4;
			string barcodeLetters = global::Infragistics.Controls.Barcodes.IntelligentMailEncoder.GetBarcodeLetters(routingCode, trackingCode);
			base.AddHorizontalQuietZone(base.LeftQuietZoneWidth);
			foreach (int num2 in barcodeLetters)
			{
				base.AddColumns(1.0);
				base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, 0, 7, false);
				int num3 = num2;
				if (num3 != 65)
				{
					switch (num3)
					{
					case 68:
						base.AddColumns(1.0);
						base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, 3, 2, true);
						goto IL_1EF;
					case 69:
					case 70:
						break;
					default:
						if (num3 == 84)
						{
							base.AddColumns(1.0);
							base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, 3, 1, true);
							goto IL_1EF;
						}
						break;
					}
					base.AddColumns(1.0);
					base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, 2, 3, true);
				}
				else
				{
					base.AddColumns(1.0);
					base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count - 1, 1, 2, 2, true);
				}
				IL_1EF:;
			}
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0001E620 File Offset: 0x0001C820
		protected override string GetDesignTimeFakeData()
		{
			return "12345678901234567890";
		}
	}
}
