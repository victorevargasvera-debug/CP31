using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000099 RID: 153
	public class LeaveSetOptionToBoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001CF RID: 463 RVA: 0x00017F50 File Offset: 0x00016150
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)243260159;
			short num2 = num;
			num = (short)1382079231;
			switch (num2 == num)
			{
			}
			num = (short)1666056192;
			if (num != 0)
			{
			}
			num = (short)1468596225;
			if (num != 0)
			{
			}
			num = (short)69533696;
			short num3 = num;
			return value.ToString() == (string)parameter;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00018010 File Offset: 0x00016210
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
				{
					string a;
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뻬軮蟰雲듴蓶럸黺諼", a_)))
					{
						num2 = (short)532152323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_165;
				}
				case 1:
					num2 = (short)1525350404;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_F0;
				case 3:
					num2 = (short)1305673729;
					if (num2 != 0)
					{
					}
					num2 = (short)1829830658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)788529152;
					short num3 = num2;
					string a;
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("뻬軮蟰雲", a_)))
					{
						num2 = (short)28835846;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				}
				case 5:
					goto IL_9F;
				case 6:
					num2 = (short)1345191936;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_D2:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetOption.Save;
			IL_F0:
			return null;
			IL_165:
			return global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetOption.SaveAsNew;
			IL_35:
			num2 = (short)347369643;
			short num4 = num2;
			num2 = (short)2053140651;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_9F:
				string a;
				if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꧬ蛮苰郲铴藶鷸", a_)))
				{
					num2 = (short)992018433;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.LeaveSetOption.Discard;
			}
			default:
			{
				num2 = (short)1840971776;
				if (num2 != 0)
				{
				}
				string a = (string)parameter;
				num2 = (short)557056005;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}
	}
}
