using System;
using System.Globalization;
using System.Windows.Data;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000071 RID: 113
	public class PlanNameConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000157 RID: 343 RVA: 0x0001253C File Offset: 0x0001073C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			short num;
			int num3;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)1296105472;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_D9;
				case 1:
					num = (short)326172672;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (num4)
					{
					case 0:
						goto IL_12C;
					case 1:
						goto IL_BC;
					case 2:
						goto IL_B6;
					case 3:
						goto IL_126;
					default:
						num = (short)1926627329;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				goto IL_45;
			}
			IL_B6:
			return global::RFResourceRepository.RFResources.ID_PLAN3;
			IL_BC:
			return global::RFResourceRepository.RFResources.ID_PLAN2;
			IL_D9:
			num = (short)496489785;
			short num5 = num;
			num = (short)382391609;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B6;
			default:
				num = (short)665255936;
				if (num != 0)
				{
				}
				return string.Empty;
			}
			IL_126:
			return global::RFResourceRepository.RFResources.ID_PLAN4;
			IL_12C:
			return global::RFResourceRepository.RFResources.ID_PLAN1;
			IL_45:
			num = (short)1439563777;
			if (num != 0)
			{
			}
			num4 = (int)value;
			num = (short)201392130;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00012680 File Offset: 0x00010880
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1845428224;
			short num2 = num;
			num = (short)2029993361;
			short num3 = num;
			num = (short)258424209;
			switch (num3 == num)
			{
			}
			num = (short)1057095680;
			if (num != 0)
			{
			}
			num = (short)285736961;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
