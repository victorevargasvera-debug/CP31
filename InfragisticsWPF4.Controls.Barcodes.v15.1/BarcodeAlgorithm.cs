using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000003 RID: 3
	internal class BarcodeAlgorithm
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002334 File Offset: 0x00000534
		static BarcodeAlgorithm()
		{
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[-1] = 28591;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[0] = 437;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[1] = 28591;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[2] = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[0];
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[3] = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[1];
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[4] = 28592;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[5] = 28593;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[6] = 28594;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[7] = 28595;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[8] = 28596;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[9] = 28597;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[10] = 28598;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[11] = 28599;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[13] = 874;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[15] = 28603;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[17] = 28605;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[20] = 932;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[21] = 1250;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[22] = 1251;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[23] = 1252;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[24] = 1256;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[25] = 1200;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[26] = 65001;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[27] = 20127;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[28] = 950;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[29] = 936;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.CodePageByEci[30] = 949;
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci = new global::System.Collections.Generic.Dictionary<int, string>();
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[-1] = "iso-8859-1";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[0] = "Cp437";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[1] = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[-1];
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[2] = "Cp437";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[3] = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[1];
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[4] = "iso-8859-2";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[5] = "iso-8859-3";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[6] = "iso-8859-4";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[7] = "iso-8859-5";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[8] = "iso-8859-6";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[9] = "iso-8859-7";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[10] = "iso-8859-8";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[11] = "iso-8859-9";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[13] = "iso-8859-11";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[15] = "iso-8859-13";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[17] = "iso-8859-15";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[20] = "shift_jis";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[21] = "windows-1250";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[22] = "windows-1251";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[23] = "windows-1252";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[24] = "windows-1256";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[25] = "ISO-10646-UCS-2";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[26] = "UTF-8";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[27] = "ISO646-US";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[28] = "Big5";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[29] = "gb2312";
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.EncodingNameByEci[30] = "KSC5601";
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < 256; i++)
			{
				stringBuilder.Append((char)i);
			}
			global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AsciiChars = stringBuilder.ToString();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000271C File Offset: 0x0000091C
		public static string BaseConvert(int to, string text, int from)
		{
			text = text.ToUpper(global::Infragistics.CultureInfoHelper.CultureToUse);
			int length = text.Length;
			int[] array = new int[length];
			int num = 0;
			for (int i = text.Length - 1; i >= 0; i--)
			{
				array[num++] = (int)((text[i] <= '9') ? (text[i] - '0') : ('\n' + (text[i] - 'A')));
			}
			int num2 = length * (from / to + 1);
			int[] array2 = new int[num2 + 10];
			int[] array3 = new int[num2 + 10];
			array2[0] = 1;
			for (int j = 0; j < length; j++)
			{
				for (int k = 0; k < num2; k++)
				{
					array3[k] += array2[k] * array[j];
					int num3 = array3[k];
					int num4 = k;
					do
					{
						int num5 = num3 / to;
						array3[num4] = num3 - num5 * to;
						num4++;
						array3[num4] += num5;
						num3 = array3[num4];
					}
					while (num3 >= to);
				}
				for (int l = 0; l < num2; l++)
				{
					array2[l] *= from;
				}
				for (int m = 0; m < num2; m++)
				{
					int num6 = array2[m];
					int num7 = m;
					do
					{
						int num8 = num6 / to;
						array2[num7] = num6 - num8 * to;
						num7++;
						array2[num7] += num8;
						num6 = array2[num7];
					}
					while (num6 >= to);
				}
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			bool flag = false;
			for (int n = num2; n >= 0; n--)
			{
				if (array3[n] != 0)
				{
					flag = true;
				}
				if (flag)
				{
					if (array3[n] < 10)
					{
						stringBuilder.Append((char)(array3[n] + 48));
					}
					else
					{
						stringBuilder.Append((char)(array3[n] + 65 - 10));
					}
				}
			}
			if (string.IsNullOrEmpty(stringBuilder.ToString()))
			{
				return "0";
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002920 File Offset: 0x00000B20
		internal static int Pow(int baseValue, int powerValue)
		{
			int num = 1;
			while (powerValue > 0)
			{
				num *= baseValue;
				powerValue--;
			}
			return num;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002940 File Offset: 0x00000B40
		internal static int ReverseInt(int value)
		{
			int num = 0;
			for (int i = 0; i < 16; i++)
			{
				num <<= 1;
				num |= (value & 1);
				value >>= 1;
			}
			return num;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000296C File Offset: 0x00000B6C
		internal static int ConvertHexToIntValue(string value)
		{
			return int.Parse(value, global::System.Globalization.NumberStyles.HexNumber, global::Infragistics.CultureInfoHelper.CultureToUse);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000297E File Offset: 0x00000B7E
		internal static string ConvertDecimalToHexValue(string number)
		{
			return global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(16, number, 10);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000298A File Offset: 0x00000B8A
		internal static string ConvertHexToDecimalValue(string hex)
		{
			return global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.BaseConvert(10, hex, 16);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002998 File Offset: 0x00000B98
		public static string GetRemainder(string number, int divider)
		{
			if (divider == 0 || string.IsNullOrEmpty(number))
			{
				return string.Empty;
			}
			int length = divider.ToString(global::Infragistics.CultureInfoHelper.CultureToUse).Length;
			if (number.Length < length || (number.Length == length && int.Parse(number, global::Infragistics.CultureInfoHelper.CultureToUse) < divider))
			{
				return number;
			}
			for (;;)
			{
				int num = int.Parse(number.Substring(0, length), global::Infragistics.CultureInfoHelper.CultureToUse);
				string text;
				if (num / divider > 0)
				{
					text = number.Substring(length);
				}
				else
				{
					num = int.Parse(number.Substring(0, length + 1), global::Infragistics.CultureInfoHelper.CultureToUse);
					text = number.Substring(length + 1);
				}
				number = (num % divider).ToString(global::Infragistics.CultureInfoHelper.CultureToUse) + text;
				if (number.Length <= length && int.Parse(number, global::Infragistics.CultureInfoHelper.CultureToUse) < divider)
				{
					break;
				}
				if (string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			return number;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002A68 File Offset: 0x00000C68
		public static string GetDivisor(string number, int divider)
		{
			if (divider == 0 || string.IsNullOrEmpty(number))
			{
				return string.Empty;
			}
			int length = divider.ToString(global::Infragistics.CultureInfoHelper.CultureToUse).Length;
			if (number.Length < length || (number.Length == length && int.Parse(number, global::Infragistics.CultureInfoHelper.CultureToUse) < divider))
			{
				return "0";
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = 0;
			for (;;)
			{
				int num2 = int.Parse(number.Substring(0, length), global::Infragistics.CultureInfoHelper.CultureToUse);
				string text;
				if (num2 / divider > 0)
				{
					text = number.Substring(length);
					if (num > 1)
					{
						for (int i = 1; i < num; i++)
						{
							stringBuilder.Append("0");
						}
					}
				}
				else if (num > 0)
				{
					for (int j = 0; j < num; j++)
					{
						stringBuilder.Append("0");
					}
					int num3 = (length + num > number.Length) ? number.Length : (length + num);
					num2 = int.Parse(number.Substring(0, num3), global::Infragistics.CultureInfoHelper.CultureToUse);
					text = number.Substring(num3);
				}
				else
				{
					num2 = int.Parse(number.Substring(0, length + 1), global::Infragistics.CultureInfoHelper.CultureToUse);
					text = number.Substring(length + 1);
				}
				stringBuilder.Append((num2 / divider).ToString());
				int num4 = num2 % divider;
				num = ((num4.ToString(global::Infragistics.CultureInfoHelper.CultureToUse).Length == length) ? 0 : (length - num4.ToString(global::Infragistics.CultureInfoHelper.CultureToUse).Length));
				number = num4.ToString(global::Infragistics.CultureInfoHelper.CultureToUse) + text;
				if (number.Length <= length && int.Parse(number, global::Infragistics.CultureInfoHelper.CultureToUse) < divider)
				{
					break;
				}
				if (string.IsNullOrEmpty(text))
				{
					goto IL_1BC;
				}
			}
			int num5 = number.Length + num - length;
			if (num5 > 0)
			{
				for (int k = 0; k < num5; k++)
				{
					stringBuilder.Append("0");
				}
			}
			IL_1BC:
			return stringBuilder.ToString();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002C38 File Offset: 0x00000E38
		public static bool AreCharsValid(string code, string validChars)
		{
			if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(validChars))
			{
				return false;
			}
			for (int i = 0; i < code.Length; i++)
			{
				bool flag = false;
				for (int j = 0; j < validChars.Length; j++)
				{
					if (code[i].Equals(validChars[j]))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002CA0 File Offset: 0x00000EA0
		internal static bool AreCharsValid(byte[] dataBytes, string validString, global::System.Text.Encoding encoding)
		{
			foreach (byte b in dataBytes)
			{
				bool flag = false;
				foreach (byte obj in encoding.GetBytes(validString))
				{
					if (b.Equals(obj))
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002D05 File Offset: 0x00000F05
		public static bool ValidateNumericCodeLength(string code, int length)
		{
			return !string.IsNullOrEmpty(code) && code.Length == length && global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(code, "0123456789");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002D28 File Offset: 0x00000F28
		public static int CountConsecutiveDigits(string msg, int startPos)
		{
			int num = 0;
			int num2 = startPos;
			if (startPos < msg.Length)
			{
				while (char.IsDigit(msg[num2]) && num2 < msg.Length)
				{
					num++;
					num2++;
					if (num2 == msg.Length)
					{
						break;
					}
				}
			}
			return num;
		}

		// Token: 0x04000003 RID: 3
		public const string NumericChars = "0123456789";

		// Token: 0x04000004 RID: 4
		public const string AlphanumericChars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		// Token: 0x04000005 RID: 5
		public const double MinWidthToHeightRatio = 0.001;

		// Token: 0x04000006 RID: 6
		public const double MaxWidthToHeightRatio = 1000.0;

		// Token: 0x04000007 RID: 7
		public const double DefaultAspectRatio = 0.5;

		// Token: 0x04000008 RID: 8
		public const double MinXDimension = 0.01;

		// Token: 0x04000009 RID: 9
		public const double MaxXDimension = 100.0;

		// Token: 0x0400000A RID: 10
		public const double DefaultWidthToHeightRatio = 3.0;

		// Token: 0x0400000B RID: 11
		public const double DefaultXDimension = 0.25;

		// Token: 0x0400000C RID: 12
		public static string AsciiChars;

		// Token: 0x0400000D RID: 13
		public static readonly global::System.Collections.Generic.Dictionary<int, int> CodePageByEci = new global::System.Collections.Generic.Dictionary<int, int>();

		// Token: 0x0400000E RID: 14
		public static readonly global::System.Collections.Generic.Dictionary<int, string> EncodingNameByEci;
	}
}
