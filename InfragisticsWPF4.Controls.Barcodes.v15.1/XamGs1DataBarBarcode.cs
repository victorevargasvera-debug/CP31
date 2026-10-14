using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using Infragistics.Windows;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000049 RID: 73
	[global::Infragistics.Windows.Licensing.UltraLicense("XamGs1DataBarBarcode", global::Infragistics.Windows.Licensing.UltraLicenseAttribute.WpfProductType.DV)]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamGs1DataBarBarcode : global::Infragistics.Controls.Barcodes.XamGridBarcode
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600028B RID: 651 RVA: 0x0001D274 File Offset: 0x0001B474
		// (set) Token: 0x0600028C RID: 652 RVA: 0x0001D27C File Offset: 0x0001B47C
		private global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder Gs1DataBarEncoder { get; set; }

		// Token: 0x0600028D RID: 653 RVA: 0x0001D288 File Offset: 0x0001B488
		static XamGs1DataBarBarcode()
		{
			global::Infragistics.Controls.Barcodes.XamGridBarcode.XDimensionProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode), new global::System.Windows.PropertyMetadata(0.6, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGridBarcode.OnXDimensionChanged)));
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001D330 File Offset: 0x0001B530
		public XamGs1DataBarBarcode()
		{
			this.Gs1DataBarEncoder = new global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder();
			base.DefaultStyleKey = typeof(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode);
			this.SetQueitZonesAndDimensionsValues();
			global::Infragistics.Windows.Utilities.ValidateLicense(typeof(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode), this);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600028F RID: 655 RVA: 0x0001D36A File Offset: 0x0001B56A
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0001D37C File Offset: 0x0001B57C
		public bool ShowText
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.ShowTextProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.ShowTextProperty, value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000291 RID: 657 RVA: 0x0001D38F File Offset: 0x0001B58F
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0001D3A1 File Offset: 0x0001B5A1
		public global::Infragistics.Controls.Barcodes.GS1CodeType CodeType
		{
			get
			{
				return (global::Infragistics.Controls.Barcodes.GS1CodeType)base.GetValue(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.CodeTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.CodeTypeProperty, value);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0001D3B4 File Offset: 0x0001B5B4
		private static void OnCodeTypeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode)d).OnCodeTypeChanged((global::Infragistics.Controls.Barcodes.GS1CodeType)e.OldValue, (global::Infragistics.Controls.Barcodes.GS1CodeType)e.NewValue);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001D3D9 File Offset: 0x0001B5D9
		private void OnCodeTypeChanged(global::Infragistics.Controls.Barcodes.GS1CodeType oldValue, global::Infragistics.Controls.Barcodes.GS1CodeType newValue)
		{
			this.SetQueitZonesAndDimensionsValues();
			this.ArrangeBarcode();
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0001D3F0 File Offset: 0x0001B5F0
		protected override bool ValidateData(string data)
		{
			bool flag = base.ValidateData(data);
			if (flag)
			{
				switch (this.CodeType)
				{
				case global::Infragistics.Controls.Barcodes.GS1CodeType.Omnidirectional:
				case global::Infragistics.Controls.Barcodes.GS1CodeType.StackedOmnidirectional:
				case global::Infragistics.Controls.Barcodes.GS1CodeType.Truncated:
				case global::Infragistics.Controls.Barcodes.GS1CodeType.Stacked:
				case global::Infragistics.Controls.Barcodes.GS1CodeType.Limited:
					flag = (flag && global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(data, "0123456789"));
					if (data.Length != 11 && data.Length != 12 && data.Length != 13)
					{
						return false;
					}
					if (this.CodeType == global::Infragistics.Controls.Barcodes.GS1CodeType.Limited && !data[0].Equals('0') && !data[0].Equals('1'))
					{
						return false;
					}
					return flag;
				}
				bool flag2 = data.ToCharArray().All((char t) => char.IsDigit(t));
				if (!global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.AreAllAscii(data))
				{
					return false;
				}
				if (flag2 && data.Length > 70)
				{
					return false;
				}
				if (!flag2 && data.Length > 40)
				{
					return false;
				}
			}
			return flag;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0001D4E8 File Offset: 0x0001B6E8
		protected override void DrawBarcode()
		{
			string data = base.Data;
			string text;
			if (this.CodeType != global::Infragistics.Controls.Barcodes.GS1CodeType.Expanded)
			{
				text = "(01)" + data + global::Infragistics.Controls.Barcodes.Gs1Helper.GenerateCheckDigit(base.Data);
			}
			else
			{
				text = data;
			}
			byte[] array;
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Omnidirectional:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.StackedOmnidirectional:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Truncated:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Stacked:
				array = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.EncodeRss14(data);
				goto IL_155;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Expanded:
				try
				{
					this.dblPattern = this.Gs1DataBarEncoder.EncodeRssExtended(data);
					if (this.dblPattern == null)
					{
						break;
					}
				}
				catch (global::System.ArgumentException ex)
				{
					base.ErrorMessage(ex.Message);
					base.ClearBarcodeGrid();
					break;
				}
				array = new byte[508];
				if (this.Gs1DataBarEncoder.Segments > 0)
				{
					int num = 0;
					int i;
					for (i = 0; i < this.Gs1DataBarEncoder.Segments - 1; i += 2)
					{
						for (int j = 0; j < 21; j++)
						{
							array[num++] = this.dblPattern[i / 2][j];
						}
					}
					if (i == this.Gs1DataBarEncoder.Segments - 1)
					{
						for (int k = 0; k < 13; k++)
						{
							array[num++] = this.dblPattern[i / 2][k];
						}
					}
					array = global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.CompactData(array);
					goto IL_155;
				}
				goto IL_155;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Limited:
				array = global::Infragistics.Controls.Barcodes.Gs1DataBarEncoder.EncodeRssLimited(data);
				goto IL_155;
			default:
				base.IsValid = false;
				break;
			}
			return;
			IL_155:
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			this.DrawBarcodeMatrix(array);
			int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
			base.TextBlock = base.AddText(text, count, count2 - count, base.BarcodeGrid.RowsDefinition.Count - 1, 1);
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001D6AC File Offset: 0x0001B8AC
		protected override string GetDesignTimeFakeData()
		{
			return "123456789012";
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0001D6B4 File Offset: 0x0001B8B4
		private void DrawBarcodeMatrix(byte[] dataPattern)
		{
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Omnidirectional:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Expanded:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Truncated:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Limited:
				base.AddRow(base.WidthToHeightRatio, global::System.Windows.GridUnitType.Star);
				break;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.StackedOmnidirectional:
				base.AddRow(33.0, global::System.Windows.GridUnitType.Star);
				base.AddRow(1.0, global::System.Windows.GridUnitType.Star);
				base.AddRow(1.0, global::System.Windows.GridUnitType.Star);
				base.AddRow(1.0, global::System.Windows.GridUnitType.Star);
				base.AddRow(33.0, global::System.Windows.GridUnitType.Star);
				break;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Stacked:
				base.AddRow(5.0, global::System.Windows.GridUnitType.Star);
				base.AddRow(1.0, global::System.Windows.GridUnitType.Star);
				base.AddRow(7.0, global::System.Windows.GridUnitType.Star);
				break;
			}
			base.AddRow(base.FontSize + 2.0 * base.XDimension, global::System.Windows.GridUnitType.Auto);
			base.AddHorizontalQuietZone(base.LeftQuietZoneWidth);
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Omnidirectional:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Expanded:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Truncated:
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Limited:
				this.DrawPattern(dataPattern);
				break;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.StackedOmnidirectional:
				this.DrawStackedOmnidirectionalPattern(dataPattern);
				break;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Stacked:
				this.DrawStackedPattern(dataPattern);
				break;
			}
			base.AddHorizontalQuietZone(base.RightQuietZoneWidth);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0001D7F8 File Offset: 0x0001B9F8
		private void DrawExtendedStackedPattern(byte[] dataPattern)
		{
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			byte[][] array = new byte[this.Gs1DataBarEncoder.ExpandedStackedRows][];
			for (int i = 0; i < this.Gs1DataBarEncoder.ExpandedStackedRows; i++)
			{
				byte[] array2 = global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.CompactData(this.dblPattern[2 * i]);
				byte[] array3 = global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.CompactData(this.dblPattern[2 * i + 1]);
				int num = array2.Length + array3.Length;
				array[i] = new byte[num];
				for (int j = 0; j < array2.Length; j++)
				{
					array[i][j] = array2[j];
				}
				for (int k = 0; k < array3.Length; k++)
				{
					array[i][array2.Length + k] = array3[k];
				}
			}
			base.AddColumns(1.0);
			base.AddColumns(1.0);
			base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count, 1, 0, 1, true);
			bool flag = false;
			foreach (byte b in array[0])
			{
				for (byte b2 = 0; b2 < b; b2 += 1)
				{
					if (flag)
					{
						base.AddColumns(1.0);
						base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count, 1, 0, 1, true);
					}
					else
					{
						base.AddColumns(1.0);
					}
				}
				flag = !flag;
			}
			int num2 = base.BarcodeGrid.ColumnsDefinition.Count;
			for (byte b3 = 0; b3 < 2; b3 += 1)
			{
				if (flag)
				{
					base.AddColumns(1.0);
					base.FillCell(base.BarcodeGrid.ColumnsDefinition.Count, 1, 0, 1, true);
				}
				else
				{
					base.AddColumns(1.0);
				}
				flag = !flag;
			}
			for (int m = 1; m < this.Gs1DataBarEncoder.ExpandedStackedRows; m++)
			{
				int num3 = m + (m - 1) * 3;
				int num4;
				bool flag2;
				if (this.Gs1DataBarEncoder.Segments % 4 <= 2)
				{
					num4 = count + 1;
					flag2 = false;
				}
				else
				{
					num4 = count;
					flag2 = true;
				}
				this.FillSeparatorPattern(dataPattern, array[m - 1], array[m], count, num4, num3);
				num3 += 3;
				base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, flag2, num3, 1, num4);
				base.FillBars(array[m], flag2, num3, 1, num4 + 2);
				num2 = ((m == this.Gs1DataBarEncoder.ExpandedStackedRows - 1) ? (global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.GetColumnsNumber(array[m]) + 2 + base.LeftQuietZoneWidth) : num2);
				flag2 = (num2 % 2 == 0 && flag2);
				base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, flag2, num3, 1, num2);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0001DAA5 File Offset: 0x0001BCA5
		private static int GetColumnsNumber(byte[] patternArray)
		{
			return patternArray.Sum((byte weight) => (int)weight);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0001DACA File Offset: 0x0001BCCA
		private void DrawStackedOmnidirectionalPattern(byte[] dataPattern)
		{
			this.DrawStackedPattern(dataPattern);
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
		private void DrawStackedPattern(byte[] dataPattern)
		{
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			int num = dataPattern.Length / 2;
			byte[] array = new byte[num];
			byte[] array2 = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = dataPattern[i];
				array2[i] = dataPattern[num + i];
			}
			int count2 = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddColumns(2.0);
			base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, false, 0, 1, count2);
			bool flag = false;
			foreach (byte b in array)
			{
				for (byte b2 = 0; b2 < b; b2 += 1)
				{
					count2 = base.BarcodeGrid.ColumnsDefinition.Count;
					if (flag)
					{
						base.AddColumns(1.0);
						base.FillCell(count2, 1, 0, 1, true);
					}
					else
					{
						base.AddColumns(1.0);
					}
				}
				flag = !flag;
			}
			int count3 = base.BarcodeGrid.ColumnsDefinition.Count;
			count2 = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddColumns(2.0);
			base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, true, 0, 1, count2);
			this.FillSeparatorPattern(dataPattern, array, array2, count, count, 1);
			int startRow = base.BarcodeGrid.RowsDefinition.Count - 2;
			base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, true, startRow, 1, count);
			base.FillBars(array2, num % 2 != 0, startRow, 1, count + 2);
			base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, false, startRow, 1, count3);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001DC70 File Offset: 0x0001BE70
		private void DrawPattern(byte[] dataPattern)
		{
			int count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, false, 0, 1, count);
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(dataPattern);
			base.FillBars(dataPattern, false, 0, 1, count);
			count = base.BarcodeGrid.ColumnsDefinition.Count;
			base.AddBarsColumns(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern);
			base.FillBars(global::Infragistics.Controls.Barcodes.Gs1DataBarAlgorithm.FinderPattern, dataPattern.Length % 2 != 0, 0, 1, count);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001DD00 File Offset: 0x0001BF00
		private static byte[] CompactData(byte[] dataPattern)
		{
			if (dataPattern == null)
			{
				return new byte[0];
			}
			int num = 0;
			while (num < dataPattern.Length && dataPattern[num] != 0)
			{
				num++;
			}
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = dataPattern[i];
			}
			return array;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0001DD44 File Offset: 0x0001BF44
		private void FillSeparatorPattern(byte[] dataPattern, byte[] upRowPattern, byte[] lowerRowPattern, int startColFirstPattern, int startColSecondPattern, int startRow)
		{
			global::Infragistics.Controls.Barcodes.GS1CodeType codeType = this.CodeType;
			if (codeType == global::Infragistics.Controls.Barcodes.GS1CodeType.StackedOmnidirectional)
			{
				byte[] array = new byte[base.BarcodeGrid.ColumnsDefinition.Count - 2];
				array[0] = 5;
				for (int i = 1; i < base.BarcodeGrid.ColumnsDefinition.Count - 2; i++)
				{
					array[i] = 1;
				}
				base.FillBars(this.GetStackedOmnidirectionalSeparatorPattern(upRowPattern, true), false, startRow, 1, startColFirstPattern);
				base.FillBars(this.FixGuardBarsOfSeparatorPattern(array), false, startRow + 1, 1, startColFirstPattern);
				base.FillBars(this.GetStackedOmnidirectionalSeparatorPattern(lowerRowPattern, false), false, startRow + 2, 1, startColSecondPattern);
				return;
			}
			if (codeType != global::Infragistics.Controls.Barcodes.GS1CodeType.Stacked)
			{
				return;
			}
			base.FillBars(this.GetStackedSeparatorPattern(dataPattern), false, 1, 1, startColFirstPattern);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001DDF0 File Offset: 0x0001BFF0
		private byte[] GetStackedOmnidirectionalSeparatorPattern(byte[] pattern, bool isFirstBarWhite)
		{
			byte[] array = new byte[50];
			int num = 0;
			int i = 2;
			while (i <= 4)
			{
				i += (int)pattern[num];
				num++;
			}
			int num2;
			if ((isFirstBarWhite && (num & 1) == 1) || (isFirstBarWhite && (num & 1) == 0))
			{
				array[0] = 4;
				array[1] = (byte)(i - 4);
				num2 = 2;
			}
			else
			{
				array[0] = (byte)i;
				num2 = 1;
			}
			while (num < pattern.Length && num2 < pattern.Length)
			{
				array[num2] = pattern[num];
				if (num + 3 < pattern.Length && pattern[num] + pattern[num + 1] + pattern[num + 2] == 13)
				{
					if ((num2 & 1) == 1)
					{
						for (i = 0; i < (int)pattern[num]; i++)
						{
							array[num2 + i] = 1;
						}
						num2 += i - 1;
						if ((i & 1) == 0)
						{
							num++;
							byte[] array2 = array;
							int num3 = num2;
							array2[num3] += pattern[num];
						}
						else
						{
							num++;
							num2++;
							array[num2] = pattern[num];
						}
						num++;
						num2++;
						for (i = 0; i < (int)pattern[num]; i++)
						{
							array[num2 + i] = 1;
						}
						num2 += i - 1;
						if ((i & 1) == 0)
						{
							num++;
							byte[] array3 = array;
							int num4 = num2;
							array3[num4] += pattern[num];
						}
						else
						{
							num++;
							num2++;
							array[num2] = pattern[num];
						}
					}
					else
					{
						num++;
						if (pattern[num] > 1)
						{
							num2++;
							for (i = 0; i < (int)pattern[num]; i++)
							{
								array[num2 + i] = 1;
							}
							num2 += i - 1;
							if ((i & 1) == 0)
							{
								num++;
								byte[] array4 = array;
								int num5 = num2;
								array4[num5] += pattern[num];
							}
							else
							{
								num++;
								num2++;
								array[num2] = pattern[num];
							}
						}
						else
						{
							num++;
							array[num2] = 10;
							array[num2 + 1] = 1;
							array[num2 + 2] = 2;
							num2 += 2;
						}
					}
				}
				num++;
				num2++;
			}
			i = 2;
			num2--;
			while (i <= 4)
			{
				i += (int)array[num2];
				num2--;
			}
			if ((num2 & 1) == 0)
			{
				num2 += 2;
				array[num2 - 1] = (byte)(i - 4);
				array[num2] = 4;
			}
			else
			{
				num2++;
				array[num2] = (byte)i;
			}
			return this.FixGuardBarsOfSeparatorPattern(array);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001DFE4 File Offset: 0x0001C1E4
		private byte[] GetStackedSeparatorPattern(byte[] pattern)
		{
			byte[] fullSeparatorPattern = global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.GetFullSeparatorPattern(pattern);
			return this.FixGuardBarsOfSeparatorPattern(fullSeparatorPattern);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001E000 File Offset: 0x0001C200
		private byte[] FixGuardBarsOfSeparatorPattern(byte[] originalSeparatorPattern)
		{
			int num = 0;
			int i = 0;
			while (originalSeparatorPattern.Length != i)
			{
				num += (int)originalSeparatorPattern[i];
				if (num > base.BarcodeGrid.ColumnsDefinition.Count - 2 || originalSeparatorPattern[i] == 0)
				{
					break;
				}
				i++;
			}
			byte[] array = new byte[i];
			for (i = 0; i < array.Length; i++)
			{
				array[i] = originalSeparatorPattern[i];
			}
			return array;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001E05C File Offset: 0x0001C25C
		private static byte[] GetFullSeparatorPattern(byte[] pattern)
		{
			byte[] array = new byte[50];
			array[0] = (array[1] = 1);
			int num = 0;
			int num2 = 21;
			int num3 = 2;
			int num4 = 0;
			int num5 = 0;
			byte b = 0;
			int i = 0;
			while (i < 46)
			{
				if (num4 == 0)
				{
					num4 = (int)pattern[num++];
				}
				if (num5 == 0)
				{
					num5 = (int)pattern[num2++];
				}
				if ((num - num2 & 1) == 1)
				{
					if (b > 0)
					{
						array[num3++] = b;
						b = 0;
					}
					array[num3++] = 1;
				}
				else if (b == 0)
				{
					if ((num - num3 & 1) == 0)
					{
						b = 1;
					}
					else
					{
						num3--;
						b = 2;
					}
				}
				else if ((num - num3 & 1) == 1)
				{
					array[num3++] = b;
					b = 1;
				}
				else
				{
					b += 1;
				}
				i++;
				num4--;
				num5--;
			}
			array[num3] = (array[num3 + 1] = 1);
			byte b2 = (byte)(i = 0);
			while (b2 <= 4)
			{
				b2 += array[i];
				i++;
			}
			int num6;
			if ((i & 1) == 0)
			{
				array[0] = 4;
				array[1] = b2 - 4;
				num6 = 2;
			}
			else
			{
				array[0] = b2;
				num6 = 1;
			}
			while (i < num3 + 2)
			{
				array[num6] = array[i];
				i++;
				num6++;
			}
			num6--;
			b2 = 0;
			while (b2 <= 4)
			{
				b2 += array[num6];
				num6--;
			}
			if ((num6 & 1) == 0)
			{
				num6 += 2;
				array[num6 - 1] = b2 - 4;
				array[num6] = 4;
			}
			else
			{
				num6++;
				array[num6] = b2;
			}
			return array;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0001E1D8 File Offset: 0x0001C3D8
		private void SetQueitZonesAndDimensionsValues()
		{
			base.LeftQuietZoneWidth = 1;
			base.RightQuietZoneWidth = 1;
			switch (this.CodeType)
			{
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Omnidirectional:
				base.WidthToHeightRatio = 33.0;
				return;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.StackedOmnidirectional:
				base.WidthToHeightRatio = 69.0;
				return;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Expanded:
				base.WidthToHeightRatio = 34.0;
				return;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Stacked:
				base.WidthToHeightRatio = 13.0;
				return;
			case global::Infragistics.Controls.Barcodes.GS1CodeType.Limited:
				base.WidthToHeightRatio = 10.0;
				return;
			}
			base.WidthToHeightRatio = 13.0;
		}

		// Token: 0x040001DC RID: 476
		public static readonly global::System.Windows.DependencyProperty ShowTextProperty = global::System.Windows.DependencyProperty.Register("ShowText", typeof(bool), typeof(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode), new global::System.Windows.PropertyMetadata(true));

		// Token: 0x040001DD RID: 477
		public static readonly global::System.Windows.DependencyProperty CodeTypeProperty = global::System.Windows.DependencyProperty.Register("CodeType", typeof(global::Infragistics.Controls.Barcodes.GS1CodeType), typeof(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode), new global::System.Windows.PropertyMetadata(global::Infragistics.Controls.Barcodes.GS1CodeType.Omnidirectional, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Barcodes.XamGs1DataBarBarcode.OnCodeTypeChanged)));

		// Token: 0x040001DE RID: 478
		private byte[][] dblPattern;
	}
}
