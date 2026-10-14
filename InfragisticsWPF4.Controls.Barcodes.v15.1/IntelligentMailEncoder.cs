using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000028 RID: 40
	internal class IntelligentMailEncoder : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00012828 File Offset: 0x00010A28
		public static string GetBarcodeLetters(string routingCode, string trackingCode)
		{
			string text = global::Infragistics.Controls.Barcodes.IntelligentMailEncoder.ConvertBinaryCode(trackingCode, routingCode);
			string[] array = new string[text.Length / 2];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text.Substring(2 * i, 2);
			}
			string fcs = global::Infragistics.Controls.Barcodes.IntelligentMailEncoder.GenerateFrameCheckSequence(array).PadLeft(3, '0');
			int[] codewords = global::Infragistics.Controls.Barcodes.IntelligentMailEncoder.ConvertBinaryToCodewords(text, fcs);
			int[] array2 = global::Infragistics.Controls.Barcodes.IntelligentMailEncoder.ConvertCodewordsToCharacters(codewords, fcs);
			string text2 = string.Empty;
			for (int j = 0; j < 65; j++)
			{
				bool flag = (array2[global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.AscChаr[j]] & global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.Pow(2, global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.AscPos[j])) > 0;
				bool flag2 = (array2[global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.DscChar[j]] & global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.Pow(2, global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.DscPos[j])) > 0;
				if (flag && flag2)
				{
					text2 += "F";
				}
				else if (flag)
				{
					text2 += "A";
				}
				else if (flag2)
				{
					text2 += "D";
				}
				else
				{
					text2 += "T";
				}
			}
			return text2;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00012934 File Offset: 0x00010B34
		private static int[] ConvertCodewordsToCharacters(int[] codewords, string fcs)
		{
			int[] array = new int[10];
			int num = 512;
			int num2 = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ConvertHexToIntValue(fcs);
			int num3 = 0;
			foreach (int num4 in codewords)
			{
				int num5;
				if (num4 <= 1286)
				{
					int key = num4;
					num5 = global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.Table5Of13[key];
				}
				else
				{
					int key = num4 - 1287;
					num5 = global::Infragistics.Controls.Barcodes.IntelligentMailAlgorithm.Table2Of13[key];
				}
				if ((num2 & num) > 0)
				{
					num5 = (~num5 & 8191);
				}
				array[num3++] = num5;
				num /= 2;
			}
			int num6 = array.Length;
			int[] array2 = new int[num6];
			for (int j = 0; j < array.Length; j++)
			{
				array2[num6 - j - 1] = array[j];
			}
			return array2;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000129F8 File Offset: 0x00010BF8
		private static string ConvertBinaryCode(string trackingCode, string routingCode)
		{
			decimal d = global::Infragistics.Controls.Barcodes.IntelligentMailEncoder.ConvertRoutingCode(routingCode);
			d *= 10m;
			d += decimal.Parse(trackingCode[0].ToString(), global::Infragistics.CultureInfoHelper.CultureToUse);
			d *= 5m;
			string number = (d + decimal.Parse(trackingCode[1].ToString(), global::Infragistics.CultureInfoHelper.CultureToUse)).ToString(global::Infragistics.CultureInfoHelper.CultureToUse) + trackingCode.Substring(2, 18);
			return global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ConvertDecimalToHexValue(number).PadLeft(26, '0');
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00012A94 File Offset: 0x00010C94
		private static decimal ConvertRoutingCode(string code)
		{
			int length = code.Length;
			decimal result;
			if (length != 0)
			{
				if (length != 5)
				{
					switch (length)
					{
					case 9:
						return decimal.Parse(code, global::Infragistics.CultureInfoHelper.CultureToUse) + 100001m;
					}
					result = decimal.Parse(code, global::Infragistics.CultureInfoHelper.CultureToUse) + 1000100001m;
				}
				else
				{
					result = ++decimal.Parse(code, global::Infragistics.CultureInfoHelper.CultureToUse);
				}
			}
			else
			{
				result = 0m;
			}
			return result;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00012B1C File Offset: 0x00010D1C
		private static string GenerateFrameCheckSequence(string[] binaryCodeArr)
		{
			int num = 2047;
			int num2 = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ConvertHexToIntValue(binaryCodeArr[0]) << 5;
			for (int i = 2; i < 8; i++)
			{
				int num3 = (num ^ num2) & 1024;
				if (num3 != 0)
				{
					num = (num << 1 ^ 3893);
				}
				else
				{
					num <<= 1;
				}
				num &= 2047;
				num2 <<= 1;
			}
			for (int j = 1; j < 13; j++)
			{
				num2 = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ConvertHexToIntValue(binaryCodeArr[j]) << 3;
				for (int k = 0; k < 8; k++)
				{
					int num3 = (num ^ num2) & 1024;
					if (num3 != 0)
					{
						num = (num << 1 ^ 3893);
					}
					else
					{
						num <<= 1;
					}
					num &= 2047;
					num2 <<= 1;
				}
			}
			return global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ConvertDecimalToHexValue(num.ToString(global::Infragistics.CultureInfoHelper.CultureToUse));
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00012BD8 File Offset: 0x00010DD8
		private static int[] ConvertBinaryToCodewords(string code, string fcs)
		{
			int[] array = new int[10];
			string text = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ConvertHexToDecimalValue(code);
			int divider = 636;
			int num = int.Parse(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.GetRemainder(text, divider), global::Infragistics.CultureInfoHelper.CultureToUse);
			array[0] = num * 2;
			text = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.GetDivisor(text, divider);
			divider = 1365;
			for (int i = 1; i < 9; i++)
			{
				array[i] = int.Parse(global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.GetRemainder(text, divider), global::Infragistics.CultureInfoHelper.CultureToUse);
				text = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.GetDivisor(text, divider);
			}
			array[9] = int.Parse(text, global::Infragistics.CultureInfoHelper.CultureToUse);
			int num2 = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.ConvertHexToIntValue(fcs);
			if (num2 >> 10 == 1)
			{
				array[9] += 659;
			}
			return array;
		}
	}
}
