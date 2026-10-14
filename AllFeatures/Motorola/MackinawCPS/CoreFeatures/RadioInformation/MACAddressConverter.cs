using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x0200019C RID: 412
	public sealed class MACAddressConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06004516 RID: 17686 RVA: 0x00403208 File Offset: 0x00401408
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			string result;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = string.Concat(new string[]
					{
						text.Substring(0, 2),
						global::AllFeatures.CodeplugGuid.b("﯀", a_),
						text.Substring(2, 2),
						global::AllFeatures.CodeplugGuid.b("﯀", a_),
						text.Substring(4, 2),
						global::AllFeatures.CodeplugGuid.b("﯀", a_),
						text.Substring(6, 2),
						global::AllFeatures.CodeplugGuid.b("﯀", a_),
						text.Substring(8, 2),
						global::AllFeatures.CodeplugGuid.b("﯀", a_),
						text.Substring(10, 2)
					});
					num2 = (short)1386348544;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (text.Length == 12)
					{
						num2 = (short)1563426817;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (text != null)
					{
						goto IL_55;
					}
					return result;
				case 4:
				{
					num2 = (short)974009247;
					short num3 = num2;
					num2 = (short)1750479775;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
					{
						num2 = (short)1032519681;
						if (num2 != 0)
						{
						}
						num2 = (short)1551761408;
						if (num2 != 0)
						{
						}
						num2 = (short)2060845056;
						short num4 = num2;
						num2 = (short)127598594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_2D;
				IL_55:
				num2 = (short)1099890692;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2D:
			text = (string)value;
			result = "";
			num2 = (short)1369767939;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06004517 RID: 17687 RVA: 0x0040341C File Offset: 0x0040161C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			string result;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = string.Concat(new string[]
					{
						text.Substring(0, 2),
						text.Substring(3, 2),
						text.Substring(6, 2),
						text.Substring(9, 2),
						text.Substring(12, 2),
						text.Substring(15, 2)
					});
					num2 = (short)1943994368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (text.Length == 17)
					{
						num2 = (short)143458305;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					if (text != null)
					{
						goto IL_4C;
					}
					return result;
				case 4:
				{
					num2 = (short)1176233088;
					short num3 = num2;
					num2 = (short)1845421184;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
					{
						num2 = (short)1951203329;
						if (num2 != 0)
						{
						}
						num2 = (short)437387264;
						if (num2 != 0)
						{
						}
						num2 = (short)1847984128;
						short num4 = num2;
						num2 = (short)238682114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_24;
				IL_4C:
				num2 = (short)1948516356;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			text = (string)value;
			result = "";
			num2 = (short)674955267;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
