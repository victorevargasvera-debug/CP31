using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x02000012 RID: 18
	public class CustomViewMenuVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000044 RID: 68 RVA: 0x0000A774 File Offset: 0x00008974
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)709652123;
			short num2 = num;
			num = (short)977825435;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_10E;
			case 1:
				break;
			default:
			{
				num = (short)482803712;
				short num3 = num;
				break;
			}
			}
			num = (short)298844160;
			if (num != 0)
			{
			}
			num = (short)718536705;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_C0;
			}
			int num4;
			global::System.Windows.Visibility visibility;
			for (;;)
			{
				IL_A6:
				switch (num4)
				{
				case 0:
					visibility = global::System.Windows.Visibility.Collapsed;
					num = (short)478871554;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (value is global::AcpCommonLib.ApplicationMode)
					{
						num = (short)1998979076;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
				case 2:
					goto IL_10E;
				case 3:
					if ((global::AcpCommonLib.ApplicationMode)value != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)657391616;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_146;
				case 4:
					num = (short)567738371;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
			}
			IL_C0:
			visibility = global::System.Windows.Visibility.Visible;
			num = (short)1886060545;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A6;
			IL_10E:
			IL_146:
			return visibility;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000A8D0 File Offset: 0x00008AD0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1399259137;
			if (num != 0)
			{
			}
			num = (short)2116115661;
			short num2 = num;
			num = (short)433413325;
			switch (num2 == num)
			{
			}
			num = (short)989200384;
			if (num != 0)
			{
			}
			num = (short)1536884736;
			short num3 = num;
			return null;
		}

		// Token: 0x04000026 RID: 38
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
