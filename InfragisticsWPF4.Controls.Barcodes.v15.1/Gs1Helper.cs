using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000011 RID: 17
	public class Gs1Helper
	{
		// Token: 0x06000055 RID: 85 RVA: 0x00006B30 File Offset: 0x00004D30
		static Gs1Helper()
		{
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[0] = 20;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[1] = 16;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[2] = 16;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[10] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[11] = 8;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[12] = 8;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[13] = 8;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[15] = 8;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[17] = 8;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[20] = 4;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[21] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[22] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[240] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[241] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[242] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[250] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[251] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[253] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[254] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[30] = -1;
			for (int i = 3100; i < 3170; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = 10;
			}
			for (int i = 3200; i < 3380; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = 10;
			}
			for (int i = 3400; i < 3580; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = 10;
			}
			for (int i = 3600; i < 3700; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = 10;
			}
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[37] = -1;
			for (int i = 3900; i < 3940; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = -1;
			}
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[400] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[401] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[402] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[403] = -1;
			for (int i = 410; i < 416; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = 16;
			}
			for (int i = 420; i < 427; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = -1;
			}
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[7001] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[7002] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[7003] = -1;
			for (int i = 7030; i < 7040; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = -1;
			}
			for (int i = 8001; i < 8009; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = -1;
			}
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[8018] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[8020] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[8100] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[8101] = -1;
			global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[8102] = -1;
			for (int i = 90; i < 100; i++)
			{
				global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[i] = -1;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006E6C File Offset: 0x0000506C
		public static string VerifyApplicationIdentifier(string code, char fnc1)
		{
			if (string.IsNullOrEmpty(code))
			{
				return string.Empty;
			}
			if (code.StartsWith("(", global::System.StringComparison.CurrentCulture))
			{
				int i = 0;
				string text = "";
				while (i >= 0)
				{
					int num = code.IndexOf(')', i);
					if (num < 0)
					{
						return string.Empty;
					}
					string text2 = code.Substring(i + 1, num - (i + 1));
					if (text2.Length < 2 || !global::Infragistics.Controls.Barcodes.Gs1Helper.AreDigits(text2))
					{
						return string.Empty;
					}
					int key = int.Parse(text2, global::Infragistics.CultureInfoHelper.CultureToUse);
					if (!global::Infragistics.Controls.Barcodes.Gs1Helper.AIs.ContainsKey(key))
					{
						return string.Empty;
					}
					int num2 = global::Infragistics.Controls.Barcodes.Gs1Helper.AIs[key];
					if (num2 == 0)
					{
						return string.Empty;
					}
					i = code.IndexOf('(', num);
					int num3 = (i < 0) ? code.Length : i;
					text = text + text2 + code.Substring(num + 1, num3 - (num + 1));
					if (num2 < 0)
					{
						if (i >= 0)
						{
							text += fnc1;
						}
					}
					else if (num3 - num - 1 + text2.Length != num2)
					{
						return string.Empty;
					}
				}
				return text;
			}
			return string.Empty;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006F88 File Offset: 0x00005188
		private static bool AreDigits(string aiText)
		{
			for (int i = 0; i < aiText.Length; i++)
			{
				if (!char.IsDigit(aiText[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00006FB8 File Offset: 0x000051B8
		public static string GenerateCheckDigit(string code)
		{
			if (string.IsNullOrEmpty(code))
			{
				return string.Empty;
			}
			int num = 0;
			int num2;
			int num3;
			if (code.Length % 2 != 0)
			{
				num2 = 3;
				num3 = 1;
			}
			else
			{
				num2 = 1;
				num3 = 3;
			}
			for (int i = 0; i < code.Length; i++)
			{
				int num4 = (int)(code[i] - '0');
				if (i % 2 == 0)
				{
					num += num2 * num4;
				}
				else
				{
					num += num3 * num4;
				}
			}
			int num5 = 0;
			while ((num + num5) % 10 != 0)
			{
				num5++;
			}
			return num5.ToString(global::Infragistics.CultureInfoHelper.CultureToUse);
		}

		// Token: 0x0400005D RID: 93
		internal const int Fnc1Number = -1;

		// Token: 0x0400005E RID: 94
		public static readonly global::System.Collections.Generic.Dictionary<int, int> AIs = new global::System.Collections.Generic.Dictionary<int, int>();
	}
}
