using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x0200004F RID: 79
	public class CheckforPasswordInApplicableConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000F0 RID: 240 RVA: 0x0000D36C File Offset: 0x0000B56C
		public object Convert(object[] value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			object obj;
			object obj2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1614367426;
					short num3 = num2;
					num2 = (short)535317186;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_27E;
					default:
						num2 = (short)1487273984;
						if (num2 != 0)
						{
						}
						if ((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)obj != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num2 = (short)1270349835;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_297;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1766916096;
					short num4 = num2;
					num2 = (short)1736245260;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (obj2 is global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy)
					{
						num2 = (short)112132099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_306;
				case 3:
					goto IL_17F;
				case 4:
					if (obj != null)
					{
						goto IL_27E;
					}
					goto IL_96;
				case 5:
					if (obj == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num2 = (short)2072576010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1082589188;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_CF;
				case 7:
					if (obj2 is global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy)
					{
						num2 = (short)1551630342;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1822621698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1260584965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (obj2 != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num2 = (short)1108017160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 10:
					goto IL_1BA;
				case 11:
					num2 = (short)1779761166;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)obj != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
					{
						num2 = (short)1780350989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_297;
				case 13:
					num2 = (short)736296960;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if ((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)obj == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
					{
						num2 = (short)1296367631;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_96;
				case 15:
					goto IL_13A;
				}
				goto IL_50;
				IL_96:
				num2 = (short)1253965831;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_27E:
				num2 = (short)1573978113;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_CF:
			num2 = (short)413138945;
			if (num2 != 0)
			{
			}
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.PCRPasswordPolicy)obj2).ToResourceString();
			IL_13A:
			goto IL_297;
			IL_13F:
			return string.Empty;
			IL_17F:
			return ((global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy)obj2).ToResourceString();
			IL_1BA:
			goto IL_13F;
			IL_297:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.NA;
			IL_306:
			return global::Motorola.CommonCPS.ResourceRepository.Resources.NA;
			IL_50:
			obj2 = value[0];
			obj = value[1];
			num2 = (short)1420427273;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000D684 File Offset: 0x0000B884
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)826174938;
			short num2 = num;
			num = (short)69823962;
			switch (num2 == num)
			{
			}
			num = (short)180158464;
			short num3 = num;
			num = (short)237895680;
			if (num != 0)
			{
			}
			num = (short)935067649;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
