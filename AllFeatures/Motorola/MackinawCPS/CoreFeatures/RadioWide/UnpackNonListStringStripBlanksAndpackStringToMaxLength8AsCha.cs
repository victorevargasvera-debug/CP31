using System;
using System.Globalization;
using System.Windows.Data;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000126 RID: 294
	public sealed class UnpackNonListStringStripBlanksAndpackStringToMaxLength8AsChars : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06002E09 RID: 11785 RVA: 0x002D6904 File Offset: 0x002D4B04
		internal UnpackNonListStringStripBlanksAndpackStringToMaxLength8AsChars(global::AcpCommonLib.IAcpFeatureSection selfSection)
		{
			this.a = selfSection;
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x002D6920 File Offset: 0x002D4B20
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1397200268;
			short num2 = num;
			num = (short)703894924;
			switch (num2 == num)
			{
			}
			num = (short)1261174784;
			short num3 = num;
			num = (short)437780480;
			if (num != 0)
			{
			}
			num = (short)1661403137;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A = (this.a as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;
			return global::System.Convert.ToString(value).TrimEnd(global::System.Array.Empty<char>());
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x002D69E8 File Offset: 0x002D4BE8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 3;
			short num = (short)525664256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				string text;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						int length;
						int value2;
						if (length < value2)
						{
							num = (short)1952514060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					case 1:
						return text;
					case 2:
						num = (short)591069185;
						if (num != 0)
						{
						}
						goto IL_1F4;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset;
						string text2 = (string)value;
						num = (short)908132361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1F4;
					case 5:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)1664942088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += global::AllFeatures.CodeplugGuid.b("", a_);
						num3++;
						num = (short)1621426178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
						string text2;
						(radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsername_A9169.SetValue(text2.TrimEnd(global::System.Array.Empty<char>()));
						num = (short)841482241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1504772110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return text;
					case 9:
					{
						string text2;
						if (text2.Length > text2.TrimEnd(global::System.Array.Empty<char>()).Length)
						{
							num = (short)1859715085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
						if (radioWideRecset != null)
						{
							num = (short)1620967431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					case 11:
					{
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)355139587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int length = text.Length;
						global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A;
						int value2 = radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A.Value;
						num = (short)2027028480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int length;
						int value2;
						int num4 = value2 - length;
						int num3 = 0;
						num = (short)613154820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1931345930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
						if (radioWideRecset.Count >= 1)
						{
							num = (short)188088326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					}
					}
					goto IL_73;
					IL_1F4:
					num = (short)877461509;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				for (;;)
				{
					IL_73:
					global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A = (this.a as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;
					text = global::System.Convert.ToString(value).TrimEnd(global::System.Array.Empty<char>());
					num = (short)225050624;
					short num5 = num;
					num = (short)1798432342;
					short num6 = num;
					num = (short)1393485398;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_F2;
					}
				}
				IL_F2:
				num = (short)1067057152;
				if (num != 0)
				{
				}
				num = (short)1983840267;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x04000FF6 RID: 4086
		private global::AcpCommonLib.IAcpFeatureSection a;
	}
}
