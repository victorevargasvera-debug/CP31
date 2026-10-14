using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x02000013 RID: 19
	public class NavigationButtonEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000047 RID: 71 RVA: 0x0000A990 File Offset: 0x00008B90
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			short num = (short)1044512768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				bool flag7;
				for (;;)
				{
					IL_30:
					bool flag;
					bool flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
					{
						bool flag2;
						flag = !flag2;
						goto IL_541;
					}
					case 1:
						goto IL_285;
					case 2:
						flag3 = true;
						goto IL_5C3;
					case 3:
					{
						bool flag5;
						flag4 = !flag5;
						goto IL_26C;
					}
					case 4:
						num = (short)891093010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1376187100;
						short num3 = num;
						num = (short)1876816604;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5A5;
						default:
							num = (short)1227620352;
							if (num != 0)
							{
							}
							num = (short)978386953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						flag3 = false;
						goto IL_5C3;
					case 7:
					{
						num = (short)1062010880;
						short num4 = num;
						string a;
						if (a == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋟ韡郣鋥蟧蓩ꓫ臭鷯韱", a_))
						{
							num = (short)923861007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1469382672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (values[0] is global::AcpCommonLib.ApplicationMode)
						{
							num = (short)1693974559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61E;
					case 9:
					{
						bool flag5;
						flag3 = !flag5;
						goto IL_5C3;
					}
					case 10:
						flag4 = false;
						goto IL_26C;
					case 11:
						num = (short)365821955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1315110912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)377815048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1782382596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)170328084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)1988100110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						string a;
						if (a == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋟ韡郣鋥蟧蓩꿫黭韯볱闳胵", a_))
						{
							num = (short)960888858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1717174297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (values.Length == 4)
						{
							num = (short)1672871949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61E;
					case 18:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)325451787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)265617418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_55A;
					case 20:
						flag4 = true;
						goto IL_26C;
					case 21:
						goto IL_5DD;
					case 22:
					{
						bool flag6 = (bool)values[3];
						string a = (string)parameter;
						if (flag6)
						{
							num = (short)1972568094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)581894151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						num = (short)1867907073;
						if (num != 0)
						{
						}
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode != global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							goto IL_5A5;
						}
						num = (short)1202651163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode != global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1237123101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)833683458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						string a;
						if (a == global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꋟ韡郣鋥蟧蓩꿫鯭華蛱鯳鯵껷鏹駻觽䷿洁怃挅", a_))
						{
							num = (short)711393313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61E;
					}
					case 26:
						num = (short)1730871320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						flag = true;
						goto IL_541;
					case 28:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							num = (short)1445527557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1087045638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						num = (short)1637416988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_410;
					case 31:
					{
						global::AcpCommonLib.ApplicationMode applicationMode = (global::AcpCommonLib.ApplicationMode)values[0];
						bool flag2 = (bool)values[1];
						bool flag5 = (bool)values[2];
						num = (short)710672406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						flag = false;
						goto IL_541;
					case 33:
						num = (short)1895432215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1871904803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						global::AcpCommonLib.ApplicationMode applicationMode;
						if (applicationMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1810759692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1567621152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_C7;
					IL_26C:
					flag7 = flag4;
					num = (short)1194852353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_541:
					flag7 = flag;
					num = (short)1093337107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A5:
					num = (short)1061945378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C3:
					flag7 = flag3;
					num = (short)36503573;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_285:
				goto IL_61E;
				IL_410:
				return false;
				IL_55A:
				IL_5DD:
				IL_61E:
				return flag7;
				IL_C7:
				flag7 = true;
				num = (short)1542979601;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000AFC4 File Offset: 0x000091C4
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1346898899;
			short num2 = num;
			num = (short)1764232147;
			switch (num2 == num)
			{
			}
			num = (short)1084293120;
			if (num != 0)
			{
			}
			num = (short)1453260801;
			if (num != 0)
			{
			}
			num = (short)1579810816;
			short num3 = num;
			return null;
		}

		// Token: 0x04000027 RID: 39
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
