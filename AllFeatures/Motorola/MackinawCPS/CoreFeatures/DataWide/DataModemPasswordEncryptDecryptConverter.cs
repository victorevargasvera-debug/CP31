using System;
using System.Globalization;
using System.Windows.Data;
using Common;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004C9 RID: 1225
	public sealed class DataModemPasswordEncryptDecryptConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600A0F0 RID: 41200 RVA: 0x00966E40 File Offset: 0x00965040
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			string text;
			short num2;
			string text2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_A6;
				case 1:
					if (text.Length != 66)
					{
						num2 = (short)1535442946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text2 = global::Common.AESCryptoUtil.AESDecryptWithDefKey_ForDataModemPassword(text);
					num2 = (short)1887043588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return text;
				case 3:
					if (text == null)
					{
						num2 = (short)903610373;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1400373249;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (text2.Length <= 32)
					{
						num2 = (short)906428416;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18C;
				case 5:
					goto IL_60;
				}
				goto IL_28;
			}
			IL_60:
			goto IL_144;
			IL_A6:
			num2 = (short)1042665850;
			short num3 = num2;
			num2 = (short)112120186;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_144:
				return "";
			default:
			{
				num2 = (short)1972699136;
				short num4 = num2;
				num2 = (short)1008795649;
				if (num2 != 0)
				{
				}
				num2 = (short)111935488;
				if (num2 != 0)
				{
				}
				return text2;
			}
			}
			return text;
			IL_18C:
			return text2.Substring(0, 32);
			IL_28:
			text = (value as string);
			num2 = (short)1717174275;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x00966FE4 File Offset: 0x009651E4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)577110016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				string text2;
				for (;;)
				{
					IL_28:
					string text3;
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_98;
					case 1:
					{
						string text;
						if (text.Length <= 66)
						{
							num = (short)220594184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BF;
					}
					case 2:
						goto IL_232;
					case 3:
						goto IL_9D;
					case 4:
						if (text2.Length > 32)
						{
							num = (short)1138884613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_232;
					case 5:
						text2 = text2.Substring(0, 32);
						num = (short)1256062978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						string text = global::Common.AESCryptoUtil.AESEncryptWithDefKey_ForDataModemPassword(text2);
						num = (short)911343617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (text2 == null)
						{
							num = (short)394854400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1088421892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_167;
					case 9:
						return value;
					case 10:
						if (text3[num3] > '\u007f')
						{
							num = (short)1555628041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1326841868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num3 >= text3.Length)
						{
							num = (short)1847263238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1501364234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)32440321;
						if (num != 0)
						{
						}
						goto IL_9D;
					}
					goto IL_63;
					IL_9D:
					num = (short)1693843467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_232:
					text3 = text2;
					num3 = 0;
					num = (short)1313210371;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_98:
				return "";
				IL_167:
				num = (short)1645261561;
				short num4 = num;
				num = (short)964145913;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_2BF:
					string text;
					return text.Substring(0, 66);
				}
				default:
				{
					num = (short)963903488;
					short num5 = num;
					num = (short)965148672;
					if (num != 0)
					{
					}
					string text;
					return text;
				}
				}
				return value;
				IL_63:
				text2 = (value as string);
				num = (short)1642266631;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
