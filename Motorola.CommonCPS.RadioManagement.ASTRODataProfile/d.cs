using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200000E RID: 14
	internal class d : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00004BBC File Offset: 0x00002DBC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)208998002;
			short num2 = num;
			num = (short)1528761970;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1512177664;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1159790593;
			if (num != 0)
			{
			}
			num = (short)1629487104;
			if (num != 0)
			{
			}
			return value.ToString() == (string)parameter;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004C7C File Offset: 0x00002E7C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			short num = (short)1431044097;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string a;
				switch (num2)
				{
				case 0:
				{
					num = (short)1373569024;
					short num3 = num;
					num = (short)387448835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 2:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("좣쪥", a_)))
					{
						num = (short)1112735752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71;
				case 3:
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("얣슥솧얩\udfab", a_)))
					{
						goto IL_14A;
					}
					goto IL_E2;
				case 4:
				{
					num = (short)1116221637;
					short num4 = num;
					num = (short)851456197;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14A;
					default:
						num = (short)1410269185;
						if (num != 0)
						{
						}
						num = (short)1175846912;
						if (num != 0)
						{
						}
						if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("얣튥즧睊\udeab솭횯\udbb1\ud8b3펵쮷", a_)))
						{
							num = (short)1472724992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					}
					break;
				}
				case 5:
					num = (short)962854918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_8C;
				case 7:
					goto IL_6F;
				case 8:
					num = (short)855965700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_52:
				if (!(bool)value)
				{
					num = (short)2005729287;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				a = (string)parameter;
				num = (short)519241730;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14A:
				num = (short)1056702469;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6F:
			return null;
			IL_71:
			return global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.All;
			IL_8C:
			return null;
			IL_E2:
			return global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.Radios;
			IL_EB:
			return global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.FilterOption.DataProfiles;
		}
	}
}
