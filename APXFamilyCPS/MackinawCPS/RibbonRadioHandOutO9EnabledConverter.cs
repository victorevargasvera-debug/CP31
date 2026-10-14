using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200001E RID: 30
	public class RibbonRadioHandOutO9EnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000068 RID: 104 RVA: 0x0000CF28 File Offset: 0x0000B128
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool flag3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1129459397;
					short num3 = num2;
					num2 = (short)812723909;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_170;
					default:
					{
						num2 = (short)1617559552;
						if (num2 != 0)
						{
						}
						int num4 = (int)((global::AcpCommonLib.ApplicationMode)values[0]);
						bool flag = (bool)values[1];
						bool flag2 = (bool)values[2];
						flag3 = (num4 == 0 && flag && flag2);
						num2 = (short)1115422724;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
				{
					num2 = (short)1888878592;
					short num5 = num2;
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)1347551232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_170;
				}
				case 2:
					num2 = (short)1832386561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (values.Length == 3)
					{
						num2 = (short)1897005058;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_170;
				case 4:
					goto IL_93;
				}
				goto IL_24;
			}
			IL_93:
			num2 = (short)970260481;
			if (num2 != 0)
			{
			}
			IL_170:
			return flag3;
			IL_24:
			flag3 = true;
			num2 = (short)1649475587;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000D0AC File Offset: 0x0000B2AC
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)996737025;
			if (num != 0)
			{
			}
			num = (short)1993996419;
			short num2 = num;
			num = (short)1529673859;
			switch (num2 == num)
			{
			}
			num = (short)1210908672;
			if (num != 0)
			{
			}
			num = (short)1950482432;
			short num3 = num;
			return null;
		}

		// Token: 0x04000032 RID: 50
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
