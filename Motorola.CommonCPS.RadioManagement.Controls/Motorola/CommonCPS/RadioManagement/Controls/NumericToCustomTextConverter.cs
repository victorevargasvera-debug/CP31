using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000D8 RID: 216
	internal class NumericToCustomTextConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000614 RID: 1556 RVA: 0x00061FBC File Offset: 0x000601BC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 9;
			short num = (short)762099679;
			short num2 = num;
			num = (short)597014495;
			global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit numericEdit;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_EA:
				if (numericEdit == null)
				{
					goto IL_19C;
				}
				num = (short)1967718402;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)992870400;
				if (num != 0)
				{
				}
				num = (short)579731456;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_B9;
					}
					break;
				}
				break;
			}
			global::System.Collections.Generic.KeyValuePair<decimal, string> keyValuePair;
			string text;
			global::Motorola.CommonCPS.RadioManagement.Controls.NumericToCustomTextConverter.<>c__DisplayClass0_0 CS$<>8__locals1;
			for (;;)
			{
				IL_7A:
				switch (num3)
				{
				case 0:
					goto IL_358;
				case 1:
					text = global::System.Convert.ToString((int)keyValuePair.Key, 8);
					num = (short)1648295945;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)10485763;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1281032193;
					if (num != 0)
					{
					}
					if (numericEdit is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField)
					{
						num = (short)1198456839;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					keyValuePair = numericEdit.CustomValueChoiceMap.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<decimal, string>, bool>(CS$<>8__locals1.b));
					num = (short)1538981892;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					if (keyValuePair.Value == null)
					{
						num = (short)1559756800;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					text = keyValuePair.Key.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					string text2 = parameter as string;
					num = (short)548798469;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					string text2;
					if (text2 != null)
					{
						num = (short)1438515206;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35A;
				}
				case 6:
					num = (short)1878196236;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_27B;
				case 8:
					goto IL_EA;
				case 9:
					goto IL_2FC;
				case 10:
					text = global::System.Convert.ToString((int)keyValuePair.Key, 16);
					num = (short)2109407245;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					string text2;
					if (text2.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삢톤", a_)))
					{
						num = (short)551550977;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35A;
				}
				case 12:
				{
					string text2;
					if (text2.Equals(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("욢\udda4", a_)))
					{
						num = (short)487456778;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1222049803;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					goto IL_13B;
				}
				goto IL_B9;
			}
			IL_13B:
			goto IL_35A;
			IL_27B:
			goto IL_19C;
			IL_2FC:
			goto IL_35A;
			IL_358:
			return string.Empty;
			IL_35A:
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\udaa0鎢\ud8a4螦蒨讪횬麮첰", a_), text.ToUpperInvariant(), keyValuePair.Value);
			IL_B9:
			CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.NumericToCustomTextConverter.<>c__DisplayClass0_0();
			CS$<>8__locals1.a = values;
			numericEdit = (CS$<>8__locals1.a[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit);
			num = (short)262930440;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7A;
			IL_19C:
			num = (short)1693122560;
			short num4 = num;
			return null;
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00062348 File Offset: 0x00060548
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1735996986;
			short num2 = num;
			num = (short)1678587450;
			switch (num2 == num)
			{
			}
			num = (short)1577582593;
			if (num != 0)
			{
			}
			num = (short)1484390400;
			if (num != 0)
			{
			}
			num = (short)991100928;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
