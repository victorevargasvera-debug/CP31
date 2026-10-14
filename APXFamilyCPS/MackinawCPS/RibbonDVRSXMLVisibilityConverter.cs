using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200001A RID: 26
	public class RibbonDVRSXMLVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600005C RID: 92 RVA: 0x0000C378 File Offset: 0x0000A578
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)458162177;
			if (num != 0)
			{
			}
			num = (short)374341632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_81;
				}
				global::System.Windows.Visibility visibility;
				for (;;)
				{
					IL_52:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
					{
						num = (short)460225641;
						short num3 = num;
						num = (short)2077457513;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BA;
						default:
							num = (short)569180160;
							if (num != 0)
							{
							}
							num = (short)1584398340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (values[0] is global::AcpCommonLib.ApplicationMode)
						{
							num = (short)1415184392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					case 2:
						num = (short)1399848961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1277952000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)771751945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						flag = (applicationMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode);
						goto IL_132;
					}
					case 5:
						goto IL_D0;
					case 6:
						visibility = global::System.Windows.Visibility.Visible;
						goto IL_BA;
					case 7:
						if (values.Length == 3)
						{
							num = (short)1806565378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23D;
					case 8:
					{
						num = (short)2012086272;
						short num4 = num;
						global::AcpCommonLib.ApplicationMode applicationMode = (global::AcpCommonLib.ApplicationMode)values[0];
						flag2 = (bool)values[1];
						flag3 = (bool)values[2];
						num = (short)471269379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						flag = true;
						goto IL_132;
					}
					goto IL_81;
					IL_BA:
					num = (short)1546452997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_132:
					if (!flag || !flag2 || !flag3)
					{
						break;
					}
					num = (short)821035014;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D0:
				IL_23D:
				return visibility;
				IL_81:
				visibility = global::System.Windows.Visibility.Collapsed;
				num = (short)1343029255;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000C5C8 File Offset: 0x0000A7C8
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1790640129;
			if (num != 0)
			{
			}
			num = (short)1721958908;
			short num2 = num;
			num = (short)1936261628;
			switch (num2 == num)
			{
			}
			num = (short)760348672;
			if (num != 0)
			{
			}
			num = (short)1642921984;
			short num3 = num;
			return null;
		}

		// Token: 0x0400002E RID: 46
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
