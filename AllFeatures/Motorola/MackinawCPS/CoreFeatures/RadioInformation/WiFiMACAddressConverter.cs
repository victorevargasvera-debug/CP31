using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x0200019D RID: 413
	public sealed class WiFiMACAddressConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06004519 RID: 17689 RVA: 0x004035E4 File Offset: 0x004017E4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
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
						global::AllFeatures.CodeplugGuid.b("", a_),
						text.Substring(2, 2),
						global::AllFeatures.CodeplugGuid.b("", a_),
						text.Substring(4, 2),
						global::AllFeatures.CodeplugGuid.b("", a_),
						text.Substring(6, 2),
						global::AllFeatures.CodeplugGuid.b("", a_),
						text.Substring(8, 2),
						global::AllFeatures.CodeplugGuid.b("", a_),
						text.Substring(10, 2)
					});
					num2 = (short)1013121024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (text.Length == 12)
					{
						num2 = (short)1750597633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					num2 = (short)1094582273;
					if (num2 != 0)
					{
					}
					if (text != null)
					{
						goto IL_7D;
					}
					return result;
				case 4:
				{
					num2 = (short)1821288968;
					short num3 = num2;
					num2 = (short)869313032;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7D;
					default:
					{
						num2 = (short)1961885696;
						if (num2 != 0)
						{
						}
						num2 = (short)1394278400;
						short num4 = num2;
						num2 = (short)1400897538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_2D;
				IL_7D:
				num2 = (short)1655111684;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2D:
			text = (string)value;
			result = "";
			num2 = (short)1751646211;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600451A RID: 17690 RVA: 0x00403800 File Offset: 0x00401A00
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
					num2 = (short)525402112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)992935936;
					short num3 = num2;
					num2 = (short)721879041;
					if (num2 != 0)
					{
					}
					if (text.Length == 17)
					{
						num2 = (short)269811713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 3:
					if (text != null)
					{
						goto IL_4C;
					}
					return result;
				case 4:
				{
					num2 = (short)576871845;
					short num4 = num2;
					num2 = (short)378494373;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
						num2 = (short)1954349056;
						if (num2 != 0)
						{
						}
						num2 = (short)882245634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_4C:
				num2 = (short)1610481668;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			text = (string)value;
			result = "";
			num2 = (short)846462979;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
