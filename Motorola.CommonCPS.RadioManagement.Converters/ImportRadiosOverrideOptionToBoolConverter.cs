using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200009D RID: 157
	public class ImportRadiosOverrideOptionToBoolConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060001DB RID: 475 RVA: 0x00018BE8 File Offset: 0x00016DE8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num;
			if (value != null)
			{
				num = (short)509083649;
				if (num != 0)
				{
				}
				num = (short)2104299514;
				short num2 = num;
				num = (short)2121666554;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1688010752;
					if (num != 0)
					{
					}
					return value.ToString() == (string)parameter;
				}
			}
			num = (short)2028797952;
			short num3 = num;
			return false;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00018CB4 File Offset: 0x00016EB4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 1;
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
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꏫ飭闯胱菳蓵釷軹駻ꇽ仿朁爃挅稇", a_)))
					{
						num2 = (short)1238695939;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18A;
				}
				case 1:
				{
					num2 = (short)897318912;
					short num3 = num2;
					num2 = (short)51838980;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_113;
				case 3:
					num2 = (short)1896808450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					string a;
					if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꏫ飭闯胱菳蓵釷軹駻ꇽ䛿渁攃甅怇䤉挋樍甏䴑娓夕嬗爙紛瀝䜟䜡", a_)))
					{
						num2 = (short)970850310;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F5;
				}
				case 5:
					goto IL_9C;
				case 6:
					num2 = (short)1319698432;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_35;
			}
			IL_F5:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_FlashCode_NOChange;
			IL_113:
			return null;
			IL_18A:
			return global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_Never;
			IL_35:
			num2 = (short)1452451838;
			short num4 = num2;
			num2 = (short)298035198;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_9C:
				num2 = (short)1189412865;
				if (num2 != 0)
				{
				}
				string a;
				if (!(a == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("ꏫ飭闯胱菳蓵釷軹駻ꇽ䇿渁猃朅焇礉", a_)))
				{
					num2 = (short)1466892289;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				return global::Motorola.CommonCPS.Server.CommonDBConstants.OverwriteOption.Overwrite_Always;
			}
			default:
			{
				num2 = (short)1688469504;
				if (num2 != 0)
				{
				}
				string a = (string)parameter;
				num2 = (short)1185742853;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}
	}
}
