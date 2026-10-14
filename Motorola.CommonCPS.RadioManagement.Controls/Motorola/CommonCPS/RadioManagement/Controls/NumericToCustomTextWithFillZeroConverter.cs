using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000033 RID: 51
	internal class NumericToCustomTextWithFillZeroConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600009C RID: 156 RVA: 0x0000A970 File Offset: 0x00008B70
		private string a(int A_0)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			int num4;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_6F;
				case 1:
				{
					num2 = (short)1456558363;
					short num3 = num2;
					num2 = (short)238702875;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11A;
					default:
						goto IL_103;
					}
					break;
				}
				case 2:
					goto IL_6F;
				case 3:
					if (num4 >= A_0)
					{
						num2 = (short)96272385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11A;
				}
				goto IL_29;
				IL_6F:
				num2 = (short)2022047744;
				short num5 = num2;
				num2 = (short)1602093059;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_11A:
				stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("ꮚ", a_));
				num4++;
				num2 = (short)382140416;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_103:
			num2 = (short)283967488;
			if (num2 != 0)
			{
			}
			return stringBuilder.ToString();
			IL_29:
			num2 = (short)1107558401;
			if (num2 != 0)
			{
			}
			stringBuilder = new global::System.Text.StringBuilder();
			num4 = 0;
			num2 = (short)222429186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			short num = (short)864550912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_58;
				}
				global::Motorola.CommonCPS.RadioManagement.Controls.NumericToCustomTextWithFillZeroConverter.<>c__DisplayClass1_0 CS$<>8__locals1;
				global::System.Collections.Generic.KeyValuePair<decimal, string> keyValuePair;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						if (CS$<>8__locals1.a != null)
						{
							keyValuePair = CS$<>8__locals1.a.CustomValueChoiceMap.FirstOrDefault(new global::System.Func<global::System.Collections.Generic.KeyValuePair<decimal, string>, bool>(CS$<>8__locals1.b));
							num = (short)490209285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1315866547;
						short num3 = num;
						num = (short)1123977139;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_125;
						default:
							num = (short)1994588160;
							if (num != 0)
							{
							}
							num = (short)1330708482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_226;
					case 2:
						goto IL_1E5;
					case 3:
						num = (short)1090912260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (values[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField)
						{
							num = (short)1616773121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 5:
						if (keyValuePair.Value == null)
						{
							num = (short)860815367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A;
					case 6:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)1148059649;
							if (num != 0)
							{
							}
							num = (short)1324023811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_230;
					case 7:
						goto IL_120;
					}
					goto IL_58;
					IL_125:
					num = (short)188547072;
					short num4 = num;
					CS$<>8__locals1.a = (values[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.INumericEdit);
					num = (short)1003552768;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_120:
				return this.a(values);
				IL_1E5:
				return this.a(values);
				IL_226:
				IL_230:
				return null;
				IL_23A:
				string arg = keyValuePair.Key.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("겛肟辡蒣\udda5馧힩", a_), arg, keyValuePair.Value);
				IL_58:
				CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.Controls.NumericToCustomTextWithFillZeroConverter.<>c__DisplayClass1_0();
				num = (short)1704132614;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000AD50 File Offset: 0x00008F50
		private object a(object[] A_0)
		{
			int a_ = 5;
			short num = (short)718209024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				string[] array;
				int num4;
				string text;
				for (;;)
				{
					IL_31:
					num = (short)125435905;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_C3;
					case 1:
						goto IL_347;
					case 2:
					{
						num = (short)1598053752;
						short num3 = num;
						num = (short)688610680;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_347;
						default:
							num = (short)861208576;
							if (num != 0)
							{
							}
							if (array[1].Length >= num4)
							{
								num = (short)1764294661;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_39A;
						}
						break;
					}
					case 3:
						goto IL_398;
					case 4:
						goto IL_1B5;
					case 5:
						goto IL_33E;
					case 6:
					{
						if (!A_0[2].ToString().Contains(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("列풠솢즤슦", a_)))
						{
							num = (short)1156120579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = A_0[1].ToString();
						string[] array2;
						num4 = int.Parse(array2[2].TrimEnd(new char[]
						{
							'}'
						}), global::System.Globalization.CultureInfo.CurrentCulture);
						array = text.Split(new string[]
						{
							global::System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						num = (short)86179847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						if (array.Length == 1)
						{
							num = (short)1443102724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2071396352;
						short num5 = num;
						num = (short)1644691458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						if (A_0[2] == null)
						{
							num = (short)1540685824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string[] array2 = A_0[2].ToString().Split(new char[]
						{
							':',
							'.'
						});
						num = (short)2137260041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						string[] array2;
						if (array2.Length == 3)
						{
							num = (short)641007617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_343;
					}
					}
					goto IL_87;
					IL_347:
					num = (short)937426950;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_C3:
				return A_0[1];
				IL_1B5:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("꾞\udca0\ud8a2钤\udaa6튨馪킬", a_), int.Parse(text, global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), global::System.Globalization.CultureInfo.CurrentCulture).Split(new string[]
				{
					global::System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
				}, global::System.StringSplitOptions.RemoveEmptyEntries)[0], global::System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator, this.a(num4));
				IL_33E:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("꾞\udca0\ud8a2钤\udaa6튨馪킬", a_), int.Parse(array[0], global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), global::System.Globalization.CultureInfo.CurrentCulture).Split(new string[]
				{
					global::System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
				}, global::System.StringSplitOptions.RemoveEmptyEntries)[0], global::System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator, array[1].Substring(0, num4));
				IL_343:
				return A_0[1];
				IL_398:
				goto IL_343;
				IL_39A:
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("꾞\udca0\ud8a2钤\udaa6튨馪킬풮芰캲", a_), new object[]
				{
					int.Parse(array[0], global::System.Globalization.CultureInfo.CurrentCulture).ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), global::System.Globalization.CultureInfo.CurrentCulture).Split(new string[]
					{
						global::System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
					}, global::System.StringSplitOptions.RemoveEmptyEntries)[0],
					global::System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator,
					array[1],
					this.a(num4 - array[1].Length)
				});
				IL_87:
				string empty = string.Empty;
				num = (short)1107886088;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000B188 File Offset: 0x00009388
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1657711637;
			short num2 = num;
			num = (short)2081795093;
			switch (num2 == num)
			{
			}
			num = (short)1468989441;
			if (num != 0)
			{
			}
			num = (short)1893072896;
			short num3 = num;
			num = (short)1014759424;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
