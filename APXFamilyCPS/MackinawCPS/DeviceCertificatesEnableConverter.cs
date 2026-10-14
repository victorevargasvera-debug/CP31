using System;
using System.Globalization;
using System.Windows.Data;

namespace MackinawCPS
{
	// Token: 0x02000010 RID: 16
	public class DeviceCertificatesEnableConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000A3B0 File Offset: 0x000085B0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)953090048;
			short num2 = num;
			num = (short)1296349760;
			short num3 = num;
			num = (short)1730853440;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F7:
				num = (short)824049665;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)710279169;
				if (num != 0)
				{
				}
				num = (short)1425997824;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				break;
			}
			for (;;)
			{
				IL_A5:
				switch (num4)
				{
				case 0:
					if (value is bool)
					{
						num = (short)1076690946;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E;
				case 1:
					goto IL_10C;
				case 2:
					goto IL_EB;
				}
				goto IL_B7;
			}
			IL_EB:
			bool flag = !(bool)value;
			goto IL_F7;
			IL_10C:
			IL_10E:
			return flag;
			IL_B7:
			flag = false;
			num = (short)1494810624;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A5;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)40424829;
			short num2 = num;
			num = (short)1258411389;
			switch (num2 == num)
			{
			}
			num = (short)266665984;
			if (num != 0)
			{
			}
			num = (short)1297809409;
			if (num != 0)
			{
			}
			num = (short)171180032;
			short num3 = num;
			return null;
		}

		// Token: 0x04000024 RID: 36
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
