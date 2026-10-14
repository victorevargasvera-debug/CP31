using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x0200019B RID: 411
	public sealed class DateTimeFormatConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06004513 RID: 17683 RVA: 0x00402C3C File Offset: 0x00400E3C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)664437471;
			short num2 = num;
			num = (short)1557758687;
			long num3;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_23C:
				num3 = (long)value;
				num = (short)38338564;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)614793216;
				short num5 = num;
				num = (short)205717504;
				if (num != 0)
				{
				}
				num = (short)2065629184;
				switch (num)
				{
				default:
					num = (short)1218838533;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				break;
			}
			}
			string text;
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_27A;
				case 1:
				{
					int num6 = text.IndexOf(global::AllFeatures.CodeplugGuid.b("", a_));
					string text2 = text.Substring(0, num6);
					string str = text.Substring(num6 + 1);
					text2 += '‎';
					text2 += global::AllFeatures.CodeplugGuid.b("", a_);
					text2 += '‎';
					text = text2 + str;
					num = (short)601948163;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (global::System.Globalization.CultureInfo.CurrentCulture.Name.ToLower() == global::AllFeatures.CodeplugGuid.b("꿆곈", a_))
					{
						num = (short)1718353921;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return text;
				case 3:
					goto IL_18E;
				case 4:
				{
					if (num3 == 0L)
					{
						num = (short)1766129664;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::System.DateTime dateTime = new global::System.DateTime(num3);
					text = dateTime.ToLocalTime().ToString(global::AllFeatures.CodeplugGuid.b("胆", a_), culture);
					num = (short)1545732097;
					if (num != 0)
					{
					}
					num = (short)1468596226;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_DB;
					}
					continue;
				case 6:
					goto IL_FD;
				}
				IL_DB:
				if (!(value is long))
				{
					goto IL_284;
				}
				num = (short)1242038278;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_FD:
			goto IL_23C;
			IL_18E:
			return text;
			IL_27A:
			return global::CommonResources.AcgResources.ID_NA;
			IL_284:
			return value.ToString();
		}

		// Token: 0x06004514 RID: 17684 RVA: 0x00402ED4 File Offset: 0x004010D4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 19;
			short num = (short)1198981120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				long num5;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_A8;
					case 1:
					{
						string text;
						global::System.DateTime dateTime;
						if (global::System.DateTime.TryParse(text, out dateTime))
						{
							num = (short)1843462147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					}
					case 2:
					{
						num = (short)976093184;
						short num3 = num;
						num = (short)1779610285;
						short num4 = num;
						num = (short)1375777453;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_112;
						default:
							num = (short)1595867136;
							if (num != 0)
							{
							}
							num = (short)1902313473;
							if (num != 0)
							{
							}
							goto IL_A8;
						}
						break;
					}
					case 3:
					{
						global::System.DateTime dateTime;
						long.TryParse(dateTime.ToUniversalTime().Ticks.ToString(), out num5);
						num = (short)1917190150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						string text;
						int startIndex;
						if ((startIndex = text.IndexOf('‎')) < 0)
						{
							num = (short)367984652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = text.Remove(startIndex, 1);
						num = (short)267976704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (global::System.Globalization.CultureInfo.CurrentCulture.Name.ToLower() == global::AllFeatures.CodeplugGuid.b("볓돕", a_))
						{
							num = (short)1851064327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					case 6:
						goto IL_152;
					case 7:
						num = (short)1028980738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_19E;
					case 9:
					{
						if ((string)value == global::CommonResources.AcgResources.ID_NA)
						{
							num = (short)616955912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.DateTime dateTime = new global::System.DateTime(0L);
						string text = value.ToString();
						num = (short)163905541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)167575561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (value is string)
						{
							num = (short)1370816522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					case 12:
						goto IL_1A3;
					}
					goto IL_6B;
					IL_A8:
					num = (short)990380036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A3:
					num = (short)1023868929;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_112:
				return num5;
				IL_152:
				goto IL_30C;
				IL_19E:
				goto IL_112;
				IL_30C:
				return num5;
				IL_6B:
				num5 = 0L;
				num = (short)491454475;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
