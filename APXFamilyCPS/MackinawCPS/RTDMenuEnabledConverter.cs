using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x02000017 RID: 23
	public class RTDMenuEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000053 RID: 83 RVA: 0x0000BA44 File Offset: 0x00009C44
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool flag3;
			for (;;)
			{
				IL_0A:
				global::AcpCommonLib.ApplicationMode applicationMode;
				bool flag;
				bool flag2;
				switch (num)
				{
				case 0:
					goto IL_C8;
				case 1:
				{
					num2 = (short)201897925;
					short num3 = num2;
					num2 = (short)334870469;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C8;
					default:
					{
						num2 = (short)206176256;
						if (num2 != 0)
						{
						}
						num2 = (short)457572352;
						short num4 = num2;
						num2 = (short)2004221952;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					num2 = (short)1563492359;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
					{
						num2 = (short)1944322049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1924661252;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					flag = true;
					goto IL_10D;
				case 5:
					applicationMode = (global::AcpCommonLib.ApplicationMode)values[0];
					flag2 = (bool)values[1];
					num2 = (short)1880621059;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (values.Length == 2)
					{
						num2 = (short)827654146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1ED;
				case 7:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)16842757;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1ED;
				case 8:
					goto IL_129;
				}
				goto IL_34;
				IL_10D:
				flag3 = (flag && flag2);
				num2 = (short)1887961096;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_C8:
				flag = (applicationMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode);
				goto IL_10D;
			}
			IL_129:
			IL_1ED:
			return flag3;
			IL_34:
			num2 = (short)1309540353;
			if (num2 != 0)
			{
			}
			flag3 = false;
			num2 = (short)1453326342;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000BC44 File Offset: 0x00009E44
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)60434916;
			short num2 = num;
			num = (short)959785444;
			switch (num2 == num)
			{
			}
			num = (short)453181440;
			if (num != 0)
			{
			}
			num = (short)13041665;
			if (num != 0)
			{
			}
			num = (short)1811546112;
			short num3 = num;
			return null;
		}

		// Token: 0x0400002B RID: 43
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
