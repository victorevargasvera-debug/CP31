using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000066 RID: 102
	public class IsMismatchAndDelaySyncNeedFixToToolTipConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000136 RID: 310 RVA: 0x00010DD0 File Offset: 0x0000EFD0
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)74448896;
			switch (num)
			{
			default:
			{
				num = (short)895877123;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)811270144;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1270087686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26F;
					case 1:
						goto IL_228;
					case 2:
					{
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1293418509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)44040197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 4:
						if (values.Length != 3)
						{
							num = (short)830603273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)753532928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						bool flag3;
						if (flag3)
						{
							num = (short)455081985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_310;
					}
					case 6:
						num = (short)1102839820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)109903876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_30B;
					case 9:
						goto IL_261;
					case 10:
						goto IL_1E7;
					case 11:
					{
						global::Motorola.Common.CustomException.CommonErrorCode? commonErrorCode;
						if (commonErrorCode != null)
						{
							num = (short)1971912714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag4;
						bool? flag = flag4;
						bool flag2 = true;
						num = (short)50659330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_2E5;
					case 13:
						goto IL_163;
					}
					IL_A5:
					if (values == null)
					{
						goto IL_1EC;
					}
					num = (short)1706892549;
					short num4 = num;
					num = (short)664149253;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1597505536;
						if (num != 0)
						{
						}
						num = (short)1766457351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2E5:
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1367670792;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						bool? flag4 = (bool?)values[0];
						bool flag3 = (bool)values[1];
						global::Motorola.Common.CustomException.CommonErrorCode? commonErrorCode = (global::Motorola.Common.CustomException.CommonErrorCode?)values[2];
						num = (short)298647563;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_163:
				num = (short)1882849281;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Radio_Configuration_OutOfSync;
				IL_1E7:
				return global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(((global::Motorola.Common.CustomException.CommonErrorCode)values[2]).ToString(), null);
				IL_1EC:
				return string.Empty;
				IL_228:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Radio_Feature_Mismatched_ToolTip;
				IL_261:
				goto IL_1EC;
				IL_26F:
				return null;
				IL_30B:
				goto IL_26F;
				IL_310:
				return null;
			}
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000110F0 File Offset: 0x0000F2F0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1767702528;
			short num2 = num;
			num = (short)517602242;
			short num3 = num;
			num = (short)530971586;
			switch (num3 == num)
			{
			}
			num = (short)460128257;
			if (num != 0)
			{
			}
			num = (short)279052288;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
