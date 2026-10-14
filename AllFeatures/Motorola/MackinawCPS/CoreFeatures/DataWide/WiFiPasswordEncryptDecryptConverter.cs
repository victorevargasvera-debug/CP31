using System;
using System.Globalization;
using System.Windows.Data;
using Common;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004C8 RID: 1224
	public sealed class WiFiPasswordEncryptDecryptConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600A0ED RID: 41197 RVA: 0x00966A90 File Offset: 0x00964C90
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_95;
			}
			short num;
			int num4;
			string text;
			for (;;)
			{
				IL_0A:
				num = (short)1604355948;
				short num2 = num;
				num = (short)1794148204;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1114374144;
					short num3 = num;
					num = (short)21233664;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						if (text.Length != 128)
						{
							goto IL_11C;
						}
						goto IL_13C;
					case 1:
						num = (short)1242759169;
						if (num != 0)
						{
						}
						if (text == null)
						{
							num = (short)1507786755;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)268959744;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return text;
					case 3:
						goto IL_F3;
					}
					goto IL_95;
				}
				}
				IL_11C:
				num = (short)1552547842;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_F3:
			return "";
			IL_13C:
			return global::Common.AESCryptoUtil.AESDecryptWithDefKey_ForWiFiPassword(text);
			IL_95:
			text = (value as string);
			num = (short)1562705921;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x00966BE0 File Offset: 0x00964DE0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num3;
			string text2;
			for (;;)
			{
				IL_0A:
				int num2;
				string text;
				switch (num)
				{
				case 0:
					if (num2 >= text.Length)
					{
						num3 = (short)901054467;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)475725825;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					if (text[num2] > '\u007f')
					{
						num3 = (short)744882186;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2++;
					num3 = (short)1944453125;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					num3 = (short)1105985537;
					if (num3 != 0)
					{
					}
					goto IL_F2;
				case 3:
					goto IL_12D;
				case 4:
					goto IL_6F;
				case 5:
					goto IL_F2;
				case 6:
					if (text2.Length > 64)
					{
						num3 = (short)758972425;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1A4;
				case 7:
					goto IL_1A4;
				case 8:
					if (text2 == null)
					{
						num3 = (short)273088516;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1441595398;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					text2 = text2.Substring(0, 64);
					num3 = (short)1721040903;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					return value;
				}
				goto IL_3C;
				IL_F2:
				num3 = (short)1185284096;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1A4:
				text = text2;
				num2 = 0;
				num3 = (short)1408368642;
				num = (int)((global::System.IntPtr)num3);
			}
			for (;;)
			{
				IL_6F:
				num3 = (short)1425391897;
				short num4 = num3;
				num3 = (short)1924448537;
				switch ((num4 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_169;
				}
			}
			IL_169:
			num3 = (short)933625856;
			if (num3 != 0)
			{
			}
			return "";
			IL_12D:
			num3 = (short)1408434176;
			short num5 = num3;
			return global::Common.AESCryptoUtil.AESEncryptWithDefKey_ForWiFiPassword(text2);
			IL_3C:
			text2 = (value as string);
			num3 = (short)1851719688;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}
	}
}
