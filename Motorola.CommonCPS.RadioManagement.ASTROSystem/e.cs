using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x02000008 RID: 8
	internal class e : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002CC8 File Offset: 0x00000EC8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)805832532;
			short num2 = num;
			num = (short)463144788;
			switch (num2 == num)
			{
			}
			num = (short)1598685185;
			if (num != 0)
			{
			}
			num = (short)2116681728;
			short num3 = num;
			num = (short)2048262144;
			if (num != 0)
			{
			}
			return value.ToString() == (string)parameter;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002D88 File Offset: 0x00000F88
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num = (short)53936129;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)973406209;
					if (num != 0)
					{
					}
					string a;
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("\udba1힣튥춧잩\udfab", a_)))
					{
						num = (short)1428815875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E2;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 2:
				{
					num = (short)512753664;
					short num3 = num;
					string a;
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("쎡삣쾥잧\ud9a9", a_)))
					{
						num = (short)1262944261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				}
				case 3:
				{
					num = (short)1445654750;
					short num4 = num;
					num = (short)442888414;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_71;
					default:
						num = (short)320274432;
						if (num != 0)
						{
						}
						num = (short)1575223300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_8C;
				case 5:
					num = (short)1450704896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					string a;
					if (!(a == global::Motorola.CommonCPS.RadioManagement.ASTROSystem.ModuleASTROSystem.b("캡좣", a_)))
					{
						num = (short)587530248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71;
				}
				case 7:
					goto IL_6F;
				case 8:
					num = (short)331087874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_52:
				if (!(bool)value)
				{
					num = (short)1604780039;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					string a = (string)parameter;
					num = (short)841285638;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6F:
			return null;
			IL_71:
			return global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.All;
			IL_8C:
			return null;
			IL_E2:
			return global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Systems;
			IL_EB:
			return global::Motorola.CommonCPS.RadioManagement.ASTROSystem.FilterOption.Radios;
		}
	}
}
