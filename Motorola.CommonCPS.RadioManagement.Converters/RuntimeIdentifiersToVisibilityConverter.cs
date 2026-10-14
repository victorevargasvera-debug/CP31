using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200001F RID: 31
	public class RuntimeIdentifiersToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00006364 File Offset: 0x00004564
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
			short num = (short)2009202688;
			short num2 = num;
			num = (short)1719040006;
			short num3 = num;
			num = (short)1387755526;
			switch (num3 == num)
			{
			}
			num = (short)1500905472;
			if (num != 0)
			{
			}
			num = (short)862781441;
			if (num != 0)
			{
			}
			return this.GetVisibility(parameter, global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("귫뷭ꓯꃱ믳", a_), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier.ToString().ToUpperInvariant(), global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily.ToString().ToUpperInvariant(), global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsMaintenanceMode);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000647C File Offset: 0x0000467C
		public global::System.Windows.Visibility GetVisibility(object parameter, string currentPACName, string currentModeName, string currentVersionName, string currentFamilyName, bool isMaintenanceMode)
		{
			int a_ = 18;
			short num = (short)807665664;
			short num2 = num;
			num = (short)1244485202;
			short num3 = num;
			num = (short)1732531794;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)650182656;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				int num4;
				global::Motorola.CommonCPS.RadioManagement.Converters.RuntimeIdentifiersToVisibilityConverter.a a;
				for (;;)
				{
					IL_86:
					switch (num4)
					{
					case 0:
						num = (short)1366687751;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (parameter == null)
						{
							num = (short)1962606594;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						string pattern = global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꇼ꓾⤀堂嬄嬆刈圊倌刎㬐㨒䤔䨖", a_);
						num = (short)946995203;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return global::System.Windows.Visibility.Collapsed;
					case 3:
					{
						string pattern;
						global::System.Collections.Generic.IEnumerable<string[]> source = global::System.Text.RegularExpressions.Regex.Matches(parameter.ToString(), pattern).Cast<global::System.Text.RegularExpressions.Match>().Select(new global::System.Func<global::System.Text.RegularExpressions.Match, string[]>(global::Motorola.CommonCPS.RadioManagement.Converters.RuntimeIdentifiersToVisibilityConverter.<>c.<>9.a));
						num = (short)161218568;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (isMaintenanceMode)
						{
							num = (short)1170866176;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A2;
					case 5:
						return global::System.Windows.Visibility.Collapsed;
					case 6:
					{
						global::System.Collections.Generic.IEnumerable<string[]> source;
						if (!source.All(new global::System.Func<string[], bool>(a.e)))
						{
							num = (short)1128398853;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return global::System.Windows.Visibility.Visible;
					}
					case 7:
					{
						global::System.Collections.Generic.IEnumerable<string[]> source;
						if (source.Select(new global::System.Func<string[], string>(global::Motorola.CommonCPS.RadioManagement.Converters.RuntimeIdentifiersToVisibilityConverter.<>c.<>9.b)).Contains(global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("냼뻾䠀䴂億䈆䜈䨊䌌䰎吐帒娔化尘", a_)))
						{
							num = (short)674824201;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A2;
					}
					case 8:
					{
						global::System.Collections.Generic.IEnumerable<string[]> source;
						if (source.Any(new global::System.Func<string[], bool>(global::Motorola.CommonCPS.RadioManagement.Converters.RuntimeIdentifiersToVisibilityConverter.<>c.<>9.a)))
						{
							num = (short)1663565834;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1901068292;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return global::System.Windows.Visibility.Visible;
					case 10:
						return global::System.Windows.Visibility.Collapsed;
					}
					goto IL_B8;
					IL_2A2:
					num = (short)1995243526;
					num4 = (int)((global::System.IntPtr)num);
				}
				return global::System.Windows.Visibility.Collapsed;
				IL_B8:
				a = new global::Motorola.CommonCPS.RadioManagement.Converters.RuntimeIdentifiersToVisibilityConverter.a();
				a.a = currentPACName;
				a.b = currentModeName;
				a.c = currentVersionName;
				a.d = currentFamilyName;
				num = (short)1760296961;
				if (num != 0)
				{
				}
				num = (short)829489153;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_86;
			}
			}
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006774 File Offset: 0x00004974
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)323354624;
			short num2 = num;
			num = (short)557816612;
			short num3 = num;
			num = (short)1223072548;
			switch (num3 == num)
			{
			}
			num = (short)1652359169;
			if (num != 0)
			{
			}
			num = (short)1035927552;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x02000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000062 RID: 98 RVA: 0x0000684C File Offset: 0x00004A4C
			internal bool e(string[] A_0)
			{
				int a_ = 8;
				short num = (short)2005216864;
				short num2 = num;
				num = (short)197537376;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_68;
				default:
				{
					num = (short)1122435072;
					short num3 = num;
					goto IL_68;
				}
				}
				int num4;
				string text;
				global::System.Version v;
				for (;;)
				{
					IL_87:
					switch (num4)
					{
					case 0:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뻲듴뻶럸꿺룼뇾䀀䴂䘄䈆䐈䐊䤌䨎", a_)))
						{
							num = (short)1325793293;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						return true;
					case 2:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꏲ듴듶", a_)))
						{
							num = (short)1828323333;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218;
					case 3:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뗲듴뫶냸럺ꓼ", a_)))
						{
							num = (short)573767686;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B3;
					case 4:
						if (global::System.Version.TryParse(A_0[1], out v))
						{
							num = (short)113967112;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						num = (short)1093992455;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)390987790;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뻲뫴돶본", a_)))
						{
							num = (short)460980235;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157;
					case 8:
						goto IL_2CA;
					case 9:
						num = (short)828899328;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)606076931;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1883504652;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꇲ룴ꇶ본ꧺ껼뛾一䴂", a_)))
						{
							num = (short)583467018;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1665007620;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1547698177;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!(text == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뛲귴듶뗸뷺볼닾䠀伂射", a_)))
						{
							num = (short)1550319625;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_273;
					}
					goto IL_C9;
				}
				IL_157:
				return A_0[1].ToUpperInvariant().Contains(this.b);
				IL_1B3:
				return A_0[1].ToUpperInvariant().Contains(this.d);
				IL_218:
				return A_0[1].ToUpperInvariant().Contains(this.a);
				IL_273:
				return !A_0[1].ToUpperInvariant().Contains(this.d);
				IL_2CA:
				return new global::System.Version(this.c) >= v;
				IL_68:
				num = (short)1728643072;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C9;
				}
				goto IL_87;
				IL_C9:
				num = (short)1445527553;
				if (num != 0)
				{
				}
				text = A_0[0].ToUpperInvariant();
				num = (short)1381105666;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_87;
			}

			// Token: 0x04000008 RID: 8
			public string a;

			// Token: 0x04000009 RID: 9
			public string b;

			// Token: 0x0400000A RID: 10
			public string c;

			// Token: 0x0400000B RID: 11
			public string d;
		}
	}
}
