using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x02000018 RID: 24
	public class ReportsMenuItemsEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000056 RID: 86 RVA: 0x0000BD04 File Offset: 0x00009F04
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)902037517;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					flag = true;
					num2 = (short)1311834114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_1E0;
				case 3:
				{
					global::AcpCommonLib.ApplicationMode applicationMode;
					if (applicationMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1616773130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				}
				case 4:
				{
					global::AcpCommonLib.ApplicationMode applicationMode;
					if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num2 = (short)1185808389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C1;
				}
				case 5:
					num2 = (short)1579941889;
					if (num2 != 0)
					{
					}
					num2 = (short)1672937475;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if ((bool)values[2])
					{
						num2 = (short)2075787265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 7:
				{
					global::AcpCommonLib.ApplicationMode applicationMode = (global::AcpCommonLib.ApplicationMode)values[0];
					num2 = (short)1719402500;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					num2 = (short)804323334;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if ((bool)values[1])
					{
						num2 = (short)1351548936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 10:
					goto IL_C1;
				case 11:
					if (values.Length == 3)
					{
						num2 = (short)1760428032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_245;
				case 12:
					goto IL_180;
				case 13:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)1582235655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_245;
				}
				goto IL_48;
				IL_C1:
				num2 = (short)1182203913;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_13C:
				num2 = (short)1941635072;
				short num3 = num2;
				flag = false;
				num2 = (short)2065694732;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_180:
			IL_1E0:
			IL_245:
			num2 = (short)878656976;
			short num4 = num2;
			num2 = (short)1270496720;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1E0;
			default:
				num2 = (short)138477568;
				if (num2 != 0)
				{
				}
				return flag;
			}
			IL_48:
			flag = false;
			num2 = (short)1482227723;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000BFA8 File Offset: 0x0000A1A8
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1978949084;
			short num2 = num;
			num = (short)537157084;
			switch (num2 == num)
			{
			}
			num = (short)461635585;
			if (num != 0)
			{
			}
			num = (short)149880832;
			if (num != 0)
			{
			}
			num = (short)1201274880;
			short num3 = num;
			return null;
		}

		// Token: 0x0400002C RID: 44
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
