using System;
using System.Text;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000022 RID: 34
	internal class Code128Encoder
	{
		// Token: 0x0600010F RID: 271 RVA: 0x0000FC38 File Offset: 0x0000DE38
		public static string VerifyUccValue(string code, global::Infragistics.Controls.Barcodes.Code128CodeType type)
		{
			if (type != global::Infragistics.Controls.Barcodes.Code128CodeType.Ucc)
			{
				return code;
			}
			return global::Infragistics.Controls.Barcodes.Gs1Helper.VerifyApplicationIdentifier(code, 'Ê');
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000FC4C File Offset: 0x0000DE4C
		public static string ConvertCode(string code, bool ucc)
		{
			string text = "";
			int length = code.Length;
			if (length == 0)
			{
				text += 'h';
				if (ucc)
				{
					text += 'f';
				}
				return text;
			}
			if (!global::Infragistics.Controls.Barcodes.Code128Encoder.AreCharsValidForCode128(code))
			{
				return string.Empty;
			}
			char c = code[0];
			char c2 = 'h';
			int i = 0;
			if (global::Infragistics.Controls.Barcodes.Code128Encoder.AreDigitsNext(code, i, 2))
			{
				c2 = 'i';
				text += c2;
				if (ucc)
				{
					text += 'f';
				}
				global::Infragistics.Controls.Barcodes.Code128Encoder.ConvertDigitsForSetC(code, ref text, ref i, 2);
			}
			else if (c < ' ')
			{
				c2 = 'g';
				text += c2;
				if (ucc)
				{
					text += 'f';
				}
				text += global::Infragistics.Controls.Barcodes.Code128Algorithm.ConvertToAscii(c, c2);
				i++;
			}
			else
			{
				text += c2;
				if (ucc || c == 'Ê')
				{
					text += 'f';
				}
				if (c != 'Ê')
				{
					text += global::Infragistics.Controls.Barcodes.Code128Algorithm.ConvertToAscii(c, c2);
				}
				i++;
			}
			while (i < length)
			{
				switch (c2)
				{
				case 'g':
					global::Infragistics.Controls.Barcodes.Code128Encoder.ProcessCurrentCodeA(code, ref text, ref c, ref c2, ref i);
					break;
				case 'h':
					global::Infragistics.Controls.Barcodes.Code128Encoder.ProcessCurrentCodeB(code, ref text, ref c, ref c2, ref i);
					break;
				case 'i':
					global::Infragistics.Controls.Barcodes.Code128Encoder.ProcessCurrentCodeC(code, ref text, ref c, ref c2, ref i);
					break;
				}
			}
			return text;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		public static string GetHumanReadableUccEan(string code)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string value = 'Ê'.ToString();
			for (;;)
			{
				if (code.StartsWith(value, global::System.StringComparison.CurrentCulture))
				{
					code = code.Substring(1);
				}
				else
				{
					int num = 0;
					int num2 = 0;
					int num3 = 2;
					while (num3 < 5 && code.Length >= num3)
					{
						int key = int.Parse(code.Substring(0, num3), global::Infragistics.CultureInfoHelper.CultureToUse);
						if (global::Infragistics.Controls.Barcodes.Gs1Helper.AIs.ContainsKey(key))
						{
							num = global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[key];
							if (num != 0)
							{
								num2 = num3;
								break;
							}
						}
						num3++;
					}
					if (num == 0 || num2 == 0)
					{
						break;
					}
					stringBuilder.Append('(').Append(code.Substring(0, num2)).Append(')');
					code = code.Substring(num2);
					if (num > 0)
					{
						num -= num2;
						if (code.Length <= num)
						{
							break;
						}
						stringBuilder.Append(global::Infragistics.Controls.Barcodes.Code128Encoder.RemoveFnc1(code.Substring(0, num)));
						code = code.Substring(num);
					}
					else
					{
						int num4 = code.IndexOf('Ê');
						if (num4 < 0)
						{
							break;
						}
						stringBuilder.Append(code.Substring(0, num4));
						code = code.Substring(num4 + 1);
					}
				}
			}
			stringBuilder.Append(global::Infragistics.Controls.Barcodes.Code128Encoder.RemoveFnc1(code));
			return stringBuilder.ToString();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000FEF8 File Offset: 0x0000E0F8
		public static string RemoveFnc1(string code)
		{
			int length = code.Length;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char c = code[i];
				if (c >= ' ' && c <= '~')
				{
					stringBuilder.Append(c.ToString());
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000FF44 File Offset: 0x0000E144
		private static void ProcessCurrentCodeC(string code, ref string res, ref char c, ref char currentCode, ref int index)
		{
			if (global::Infragistics.Controls.Barcodes.Code128Encoder.AreDigitsNext(code, index, 2))
			{
				global::Infragistics.Controls.Barcodes.Code128Encoder.ConvertDigitsForSetC(code, ref res, ref index, 2);
				return;
			}
			c = code[index++];
			if (c == 'Ê')
			{
				res += 'f';
				return;
			}
			if (c < ' ')
			{
				currentCode = 'g';
				res += 'e';
			}
			else
			{
				currentCode = 'h';
				res += 'd';
			}
			res += global::Infragistics.Controls.Barcodes.Code128Algorithm.ConvertToAscii(c, currentCode);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000FFDC File Offset: 0x0000E1DC
		private static void ProcessCurrentCodeB(string code, ref string res, ref char c, ref char currentCode, ref int index)
		{
			if (global::Infragistics.Controls.Barcodes.Code128Encoder.AreDigitsNext(code, index, 4))
			{
				currentCode = 'i';
				res += 'c';
				global::Infragistics.Controls.Barcodes.Code128Encoder.ConvertDigitsForSetC(code, ref res, ref index, 4);
				return;
			}
			c = code[index++];
			if (c == 'Ê')
			{
				res += 'f';
				return;
			}
			if (c < ' ')
			{
				currentCode = 'g';
				res += 'e';
			}
			res += global::Infragistics.Controls.Barcodes.Code128Algorithm.ConvertToAscii(c, currentCode);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00010074 File Offset: 0x0000E274
		private static void ProcessCurrentCodeA(string code, ref string res, ref char c, ref char currentCode, ref int index)
		{
			if (global::Infragistics.Controls.Barcodes.Code128Encoder.AreDigitsNext(code, index, 4))
			{
				currentCode = 'i';
				res += 'c';
				global::Infragistics.Controls.Barcodes.Code128Encoder.ConvertDigitsForSetC(code, ref res, ref index, 4);
				return;
			}
			c = code[index++];
			if (c == 'Ê')
			{
				res += 'f';
				return;
			}
			if (c > '_')
			{
				currentCode = 'h';
				res += 'd';
			}
			res += global::Infragistics.Controls.Barcodes.Code128Algorithm.ConvertToAscii(c, currentCode);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0001010C File Offset: 0x0000E30C
		private static void ConvertDigitsForSetC(string code, ref string res, ref int index, int digitNum)
		{
			string text = global::Infragistics.Controls.Barcodes.Code128Encoder.PackCodeDigits(code, index, digitNum);
			index += (int)text[0];
			res += text.Substring(1);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00010140 File Offset: 0x0000E340
		private static bool AreCharsValidForCode128(string code)
		{
			foreach (char c in code)
			{
				if (c > '\u007f' && c != 'Ê')
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00010178 File Offset: 0x0000E378
		private static string PackCodeDigits(string code, int textIndex, int digitsNum)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			int num = textIndex;
			while (digitsNum > 0)
			{
				if (code[textIndex] == 'Ê')
				{
					stringBuilder.Append('f');
					textIndex++;
				}
				else
				{
					digitsNum -= 2;
					int num2 = (int)(code[textIndex++] - '0');
					int num3 = (int)(code[textIndex++] - '0');
					stringBuilder.Append((char)(num2 * 10 + num3));
				}
			}
			stringBuilder.Insert(0, ((char)(textIndex - num)).ToString());
			return stringBuilder.ToString();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00010200 File Offset: 0x0000E400
		private static bool AreDigitsNext(string code, int codeIndex, int digitsNum)
		{
			int length = code.Length;
			while (codeIndex < length && digitsNum > 0)
			{
				if (code[codeIndex] == 'Ê')
				{
					codeIndex++;
				}
				else
				{
					int num = global::System.Math.Min(2, digitsNum);
					if (codeIndex + num > length)
					{
						return false;
					}
					while (num-- > 0)
					{
						char c = code[codeIndex++];
						if (c < '0' || c > '9')
						{
							return false;
						}
						digitsNum--;
					}
				}
			}
			return digitsNum == 0;
		}
	}
}
