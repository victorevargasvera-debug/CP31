using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x02000019 RID: 25
	public class RibbonDVRSXMLVisibleConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000059 RID: 89 RVA: 0x0000C068 File Offset: 0x0000A268
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)591790080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				bool flag2;
				for (;;)
				{
					IL_28:
					bool flag;
					bool flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
					{
						num = (short)1202191584;
						short num3 = num;
						num = (short)948042976;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_92;
						default:
							num = (short)1241841664;
							if (num != 0)
							{
							}
							num = (short)585498628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (values[0] is global::AcpCommonLib.ApplicationMode)
						{
							num = (short)1739915272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A;
					case 2:
						num = (short)1002897409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)2064252928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)366215177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						flag = (applicationMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode);
						goto IL_10A;
					}
					case 5:
						goto IL_A7;
					case 6:
						flag2 = true;
						goto IL_92;
					case 7:
						if (values.Length == 3)
						{
							num = (short)318439426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A;
					case 8:
					{
						num = (short)249888768;
						short num4 = num;
						global::AcpCommonLib.ApplicationMode applicationMode = (global::AcpCommonLib.ApplicationMode)values[0];
						flag3 = (bool)values[1];
						flag4 = (bool)values[2];
						num = (short)1102512131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						flag = true;
						goto IL_10A;
					}
					goto IL_57;
					IL_92:
					num = (short)1635975173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10A:
					if (!flag || !flag3 || !flag4)
					{
						break;
					}
					num = (short)1212219393;
					if (num != 0)
					{
					}
					num = (short)1629093894;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A7:
				IL_23A:
				return flag2;
				IL_57:
				flag2 = false;
				num = (short)1823014919;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000C2B8 File Offset: 0x0000A4B8
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)268009737;
			short num2 = num;
			num = (short)705593609;
			switch (num2 == num)
			{
			}
			num = (short)1713700864;
			if (num != 0)
			{
			}
			num = (short)1546846209;
			if (num != 0)
			{
			}
			num = (short)1911095296;
			short num3 = num;
			return null;
		}

		// Token: 0x0400002D RID: 45
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
