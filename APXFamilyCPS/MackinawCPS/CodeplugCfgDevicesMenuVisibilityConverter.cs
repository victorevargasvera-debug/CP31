using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200000F RID: 15
	public class CodeplugCfgDevicesMenuVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600003B RID: 59 RVA: 0x0000A178 File Offset: 0x00008378
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)379723269;
			short num2 = num;
			num = (short)1982864901;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_EC;
			case 1:
				break;
			default:
			{
				num = (short)674824192;
				short num3 = num;
				break;
			}
			}
			num = (short)1858600960;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_99;
			}
			int num4;
			global::System.Windows.Visibility visibility;
			for (;;)
			{
				IL_7F:
				switch (num4)
				{
				case 0:
					visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)1481703426;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num = (short)120979460;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_163;
				case 2:
					goto IL_EC;
				case 3:
				{
					int num5 = (int)((global::AcpCommonLib.ApplicationMode)values[0]);
					bool flag = (bool)values[1];
					if (num5 == 2 || flag)
					{
						num = (short)1453850625;
						if (num != 0)
						{
						}
						num = (short)938672128;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_163;
				}
				case 4:
					num = (short)486539267;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_99:
			visibility = global::System.Windows.Visibility.Visible;
			num = (short)1098579969;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_7F;
			IL_EC:
			IL_163:
			return visibility;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000A2F0 File Offset: 0x000084F0
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)593803694;
			short num2 = num;
			num = (short)288405934;
			switch (num2 == num)
			{
			}
			num = (short)1396310017;
			if (num != 0)
			{
			}
			num = (short)742653952;
			if (num != 0)
			{
			}
			num = (short)2104688640;
			short num3 = num;
			return null;
		}

		// Token: 0x04000023 RID: 35
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
