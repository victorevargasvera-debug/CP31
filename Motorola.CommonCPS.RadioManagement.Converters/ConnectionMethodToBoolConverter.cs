using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000090 RID: 144
	public class ConnectionMethodToBoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001B4 RID: 436 RVA: 0x00016568 File Offset: 0x00014768
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)675158984;
			short num2 = num;
			num = (short)579541960;
			switch (num2 == num)
			{
			}
			num = (short)1177288704;
			short num3 = num;
			num = (short)68812801;
			if (num != 0)
			{
			}
			num = (short)81395712;
			if (num != 0)
			{
			}
			return value.ToString() == (string)parameter;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00016624 File Offset: 0x00014824
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 15;
			short num = (short)1818624000;
			short num2 = num;
			num = (short)1728070772;
			short num3 = num;
			num = (short)524502132;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)737148928;
				if (num != 0)
				{
				}
				num = (short)287703043;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						string a;
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("극闻賽旿昁", a_)))
						{
							num = (short)1140850692;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_181;
					}
					case 1:
					{
						string a;
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뗹ꣻ뿽", a_)))
						{
							num = (short)480968711;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18E;
					}
					case 2:
					{
						string a;
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("극闻賽旿昁䬃琅䜇帉䴋", a_)))
						{
							num = (short)1186004998;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					}
					case 3:
						num = (short)1174405121;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_F4;
						}
						continue;
					case 4:
						num = (short)2102460418;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_12D;
					case 6:
						num = (short)936247301;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)510525449;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_110;
					case 9:
					{
						string a;
						if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("꣹껻껽", a_)))
						{
							num = (short)2083651594;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_112;
					}
					case 10:
						num = (short)2013462528;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F4:
					if (!(bool)value)
					{
						num = (short)145948680;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						string a = (string)parameter;
						num = (short)1894187009;
						num4 = (int)((global::System.IntPtr)num);
					}
				}
				IL_110:
				return global::System.Windows.Data.Binding.DoNothing;
				IL_12D:
				return global::System.Windows.Data.Binding.DoNothing;
				IL_181:
				return global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.Wired;
				IL_18E:
				return global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.OTA;
				IL_195:
				return global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.WiredOrOTA;
			}
			}
			IL_112:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.TransportPreference.RRP;
		}
	}
}
