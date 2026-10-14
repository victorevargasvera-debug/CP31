using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200001C RID: 28
	public class RibbonUpdataCallListVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000062 RID: 98 RVA: 0x0000C90C File Offset: 0x0000AB0C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1106313216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::System.Windows.Visibility visibility;
				for (;;)
				{
					IL_27:
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						flag = true;
						goto IL_261;
					case 1:
						num = (short)981336075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1722023940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)811532290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)401670144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						flag = (applicationMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode);
						goto IL_261;
					}
					case 5:
						visibility = global::System.Windows.Visibility.Visible;
						num = (short)1942421513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (!(values[0] is global::AcpCommonLib.ApplicationMode))
						{
							goto IL_282;
						}
						num = (short)1019740160;
						short num3 = num;
						num = (short)1794706193;
						short num4 = num;
						num = (short)1018170129;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_172;
						default:
							num = (short)390201344;
							if (num != 0)
							{
							}
							num = (short)1693450248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)790888454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)645791745;
						if (num != 0)
						{
						}
						global::AcpCommonLib.ApplicationMode applicationMode = (global::AcpCommonLib.ApplicationMode)values[0];
						flag2 = (bool)values[1];
						bool flag3 = (bool)values[2];
						num = (short)426508291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_14E;
					case 10:
						if (values.Length == 3)
						{
							num = (short)970588167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 11:
					{
						bool flag3;
						if (!flag3)
						{
							goto IL_172;
						}
						goto IL_282;
					}
					}
					goto IL_5E;
					IL_172:
					num = (short)1860501509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_261:
					if (!flag || !flag2)
					{
						break;
					}
					num = (short)1948450817;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14E:
				IL_282:
				return visibility;
				IL_5E:
				visibility = global::System.Windows.Visibility.Collapsed;
				num = (short)2063400970;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)243402870;
			short num2 = num;
			num = (short)1769539702;
			switch (num2 == num)
			{
			}
			num = (short)1064697857;
			if (num != 0)
			{
			}
			num = (short)954204160;
			if (num != 0)
			{
			}
			num = (short)21299200;
			short num3 = num;
			return null;
		}

		// Token: 0x04000030 RID: 48
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
