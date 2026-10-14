using System;
using System.Globalization;
using System.Text;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000E4 RID: 228
	public class NumericFieldInfoToTextConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000643 RID: 1603 RVA: 0x00064170 File Offset: 0x00062370
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)635568128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9F;
				}
				global::System.Text.StringBuilder stringBuilder;
				global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField rangeField;
				for (;;)
				{
					IL_30:
					decimal[][] array2;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_2E2;
					case 1:
						goto IL_2C3;
					case 2:
						goto IL_2C3;
					case 3:
						goto IL_2C3;
					case 4:
					{
						decimal[] array;
						if (array[0] == array[1])
						{
							num = (short)787611662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stringBuilder.Append(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8a2閤\udaa6覨햪趬풮肰캲", a_), global::System.Convert.ToInt64(array[0]).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﮢ", a_), global::System.Globalization.CultureInfo.CurrentCulture), global::System.Convert.ToInt64(array[1]).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﮢ", a_), global::System.Globalization.CultureInfo.CurrentCulture)));
						num = (short)1088880647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						decimal[] array;
						if (array[0] == array[1])
						{
							num = (short)130154521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stringBuilder.Append(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8a2閤\udaa6覨햪趬풮肰캲", a_), array[0], array[1]));
						num = (short)2054029313;
						if (num != 0)
						{
						}
						num = (short)1815871510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (!string.IsNullOrEmpty(rangeField.GetCustomToolTip()))
						{
							num = (short)93192215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B3;
					case 7:
						goto IL_2C3;
					case 8:
						goto IL_4F2;
					case 9:
						goto IL_2C3;
					case 10:
						if (parameter.ToString() == global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("삤\udfa6", a_))
						{
							num = (short)158007315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1433600017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_41A;
					case 12:
						num = (short)346488838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (parameter == null)
						{
							num = (short)950468623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1015676938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)1822906954;
						short num3 = num;
						num = (short)139221578;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E2;
						default:
						{
							num = (short)1279721472;
							if (num != 0)
							{
							}
							decimal[] array;
							stringBuilder.Append(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8a2閤\udaa6", a_), global::System.Convert.ToInt64(array[0]).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ﮢ", a_), global::System.Globalization.CultureInfo.CurrentCulture)));
							num = (short)1749614601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 15:
						num = (short)2061172741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (array2 == null)
						{
							num = (short)1194393608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stringBuilder = new global::System.Text.StringBuilder(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Tip_Ranges);
						decimal[][] array3 = array2;
						num4 = 0;
						num = (short)245039128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						decimal[] array;
						if (array[0] == array[1])
						{
							num = (short)932053013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stringBuilder.Append(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8a2閤\udaa6覨햪趬풮肰캲", a_), global::System.Convert.ToString(global::System.Convert.ToInt64(array[0]), 8), global::System.Convert.ToString(global::System.Convert.ToInt64(array[1]), 8)));
						num = (short)735903747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						decimal[][] array3;
						if (num4 >= array3.Length)
						{
							num = (short)2144862219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						decimal[] array = array3[num4];
						stringBuilder.AppendLine();
						num = (short)838336525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						num = (short)2029518848;
						short num5 = num;
						num = (short)1758461956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (rangeField != null)
						{
							num = (short)1719074828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B3;
					case 21:
					{
						decimal[] array;
						stringBuilder.Append(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("\ud8a2閤\udaa6", a_), global::System.Convert.ToString(global::System.Convert.ToInt64(array[0]), 8)));
						num = (short)2070216705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_2C3;
					case 23:
						goto IL_4AE;
					case 24:
						goto IL_3E0;
					case 25:
					{
						decimal[] array;
						stringBuilder.Append(array[0]);
						num = (short)1515716610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_9F;
					IL_2C3:
					num4++;
					num = (short)268304384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E0:
					num = (short)1051918354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E2:
					goto IL_3E0;
					IL_4B3:
					array2 = (values[0] as decimal[][]);
					num = (short)1663696912;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_41A:
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Tip_Step);
				stringBuilder.Append(values[1]);
				return stringBuilder.ToString();
				IL_4AE:
				return rangeField.GetCustomToolTip();
				IL_4F2:
				return string.Empty;
				IL_9F:
				rangeField = (values[2] as global::Motorola.CommonCPS.RadioManagement.UIModels.RangeField);
				num = (short)807665684;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x000647F8 File Offset: 0x000629F8
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)638068198;
			short num2 = num;
			num = (short)134030822;
			switch (num2 == num)
			{
			}
			num = (short)1012137985;
			if (num != 0)
			{
			}
			num = (short)1358495744;
			short num3 = num;
			num = (short)348848128;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
