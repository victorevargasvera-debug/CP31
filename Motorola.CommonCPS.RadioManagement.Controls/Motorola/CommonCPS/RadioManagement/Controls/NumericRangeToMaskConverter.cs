using System;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x02000017 RID: 23
	public class NumericRangeToMaskConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000045 RID: 69 RVA: 0x00005858 File Offset: 0x00003A58
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			short num = (short)176947200;
			switch (num)
			{
			default:
			{
				num = (short)1784283166;
				int num2 = (int)((global::System.IntPtr)num);
				long num3;
				long num5;
				long num6;
				long num7;
				int num8;
				string text;
				long num10;
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						num3 = (long)num4;
						num = (short)736100359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_28D;
					case 2:
						if ((long)num4 > num3)
						{
							num = (short)1672085504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51E;
					case 3:
						num5 = (long)num4;
						num = (short)637009953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)810876933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						bool flag;
						if (!flag)
						{
							num = (short)200343579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123;
					}
					case 6:
						num6 = global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.c(global::System.Convert.ToInt64(values[0]));
						num3 = global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.a(global::System.Convert.ToInt64(values[1]));
						num = (short)1499070484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_680;
					case 8:
						if ((long)num4 > num7)
						{
							num = (short)228392970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32F;
					case 9:
						goto IL_65E;
					case 10:
						num7 = (long)num4;
						num = (short)962723849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num4 > num8)
						{
							num = (short)1732313110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_685;
					case 12:
						num = (short)923729944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_FF;
					case 14:
					{
						bool flag2;
						if (!flag2)
						{
							num = (short)21430276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123;
					}
					case 15:
					{
						num = (short)1356005376;
						short num9 = num;
						bool flag2;
						if (flag2)
						{
							num = (short)1257963532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE;
					}
					case 16:
					{
						if (text != global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("풠캢잤슦\udba8횪", a_))
						{
							num = (short)47120413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag = (bool)values[4];
						bool flag2 = (bool)values[5];
						num4 = global::System.Convert.ToInt32(values[6]);
						num = (short)1551499278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if ((long)num4 < num10)
						{
							num = (short)1310326816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CC;
					case 18:
					{
						global::System.Type left;
						if (left != typeof(int))
						{
							num = (short)639434777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = values[3].ToString();
						num = (short)445448208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_482;
					case 20:
						if ((long)num4 < num6)
						{
							num = (short)1791557645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28D;
					case 21:
						goto IL_397;
					case 22:
						num = (short)255852545;
						if (num != 0)
						{
						}
						num8 = num4;
						num = (short)1202257941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)958791708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						bool flag;
						if (!flag)
						{
							num = (short)684392454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DE;
					}
					case 25:
						goto IL_288;
					case 26:
					{
						if ((long)num4 >= num5)
						{
							goto IL_5A4;
						}
						num = (short)1411960670;
						short num11 = num;
						num = (short)541773662;
						switch ((num11 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FF;
						default:
							num = (short)95158272;
							if (num != 0)
							{
							}
							num = (short)199819267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 27:
						num5 = global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.c(global::System.Convert.ToInt64(values[0]));
						num7 = global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.b(global::System.Convert.ToInt64(values[1]));
						num = (short)1760690202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						if (values[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField)
						{
							num = (short)1200750611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Type left = (global::System.Type)values[2];
						num = (short)502202386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						return text;
					case 30:
						switch (0)
						{
						case 0:
							goto IL_D5;
						}
						continue;
					case 31:
						goto IL_2CC;
					case 32:
						num10 = (long)num4;
						num = (short)1941831711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_5A4;
					}
					IL_D5:
					if (values[0] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1612709911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63C;
					IL_FF:
					num6 = (long)num4;
					num = (short)986972161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_123:
					num = (short)1230897167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DE:
					num10 = global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.c(global::System.Convert.ToInt64(values[0]));
					num8 = global::System.Convert.ToInt32(values[1]);
					num = (short)2028666897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28D:
					num = (short)689176578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CC:
					num = (short)2022834187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A4:
					num = (short)813760520;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_288:
				return values[3];
				IL_32F:
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾠횢좤얦첨\ud9aa鞬풮膰캲颴첶袸욺삼슾", a_), num5, num7);
				IL_397:
				goto IL_685;
				IL_482:
				goto IL_63C;
				IL_51E:
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾠횢좤얦첨\ud9aa鞬풮膰캲颴첶袸욺삼슾", a_), num6, num3);
				IL_63C:
				return values[2];
				IL_65E:
				goto IL_32F;
				IL_680:
				goto IL_51E;
				IL_685:
				return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾠횢좤얦첨\ud9aa鞬풮膰캲颴첶袸욺삼슾", a_), num10, num8);
			}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00005F10 File Offset: 0x00004110
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1768359723;
			short num2 = num;
			num = (short)1380058923;
			switch (num2 == num)
			{
			}
			num = (short)110231552;
			short num3 = num;
			num = (short)165412865;
			if (num != 0)
			{
			}
			num = (short)1239613440;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00005FC0 File Offset: 0x000041C0
		private static long c(long A_0)
		{
			int a_ = 2;
			if (A_0 >= 0L)
			{
				short num = (short)276037633;
				if (num != 0)
				{
				}
				num = (short)1164912981;
				short num2 = num;
				num = (short)2031102293;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AD;
				case 1:
					break;
				default:
				{
					num = (short)473432064;
					short num3 = num;
					break;
				}
				}
				num = (short)752812032;
				if (num != 0)
				{
				}
				IL_AD:
				return 0L;
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.a(A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture).Length - 1, global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("랙", a_));
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000060A4 File Offset: 0x000042A4
		private static long b(long A_0)
		{
			if (A_0 < 0L)
			{
				short num = (short)2021735009;
				short num2 = num;
				num = (short)982596193;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1654980608;
					short num3 = num;
					num = (short)762707969;
					if (num != 0)
					{
					}
					num = (short)1501036544;
					if (num != 0)
					{
					}
					break;
				}
				}
				return 0L;
			}
			return global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.a(A_0.ToString(global::System.Globalization.CultureInfo.InvariantCulture).Length, null);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006170 File Offset: 0x00004370
		private static long a(long A_0)
		{
			int a_ = 17;
			if (A_0 >= 0L)
			{
				short num = (short)2005745102;
				short num2 = num;
				num = (short)129908174;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)290979840;
					short num3 = num;
					num = (short)200015873;
					if (num != 0)
					{
					}
					num = (short)465829888;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.Controls.NumericRangeToMaskConverter.a(A_0.ToString(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("", a_), global::System.Globalization.CultureInfo.InvariantCulture).Length);
				}
				}
			}
			return 0L;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006250 File Offset: 0x00004450
		private static long a(int A_0, string A_1 = null)
		{
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_00:
				short num = (short)1125711873;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					switch (num2)
					{
					case 0:
						if (num3 >= A_0)
						{
							num = (short)413401094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						stringBuilder.Append('9');
						num3++;
						num = (short)2005860356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 2:
						if (A_1 != null)
						{
							num = (short)650051589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B3;
					case 3:
					{
						num = (short)552629719;
						short num4 = num;
						num = (short)695498199;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1112801281;
							if (num != 0)
							{
							}
							num = (short)819527680;
							if (num != 0)
							{
							}
							goto IL_EE;
						}
						break;
					}
					case 4:
						goto IL_EE;
					case 5:
						goto IL_EC;
					case 6:
						goto IL_121;
					case 7:
						num = (short)552468482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_46:
					num = (short)2143354880;
					short num5 = num;
					if (A_0 >= 10)
					{
						num = (short)1895497735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					stringBuilder = new global::System.Text.StringBuilder(A_1);
					num3 = 0;
					num = (short)1930493955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EE:
					num = (short)1308360704;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_B3:
			return 2147483647L;
			IL_EC:
			return -2147483648L;
			IL_121:
			return long.Parse(stringBuilder.ToString());
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000642C File Offset: 0x0000462C
		private static long a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			int num3;
			global::System.Text.StringBuilder stringBuilder;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1905852417;
					if (num2 != 0)
					{
					}
					if (num3 >= A_0)
					{
						num2 = (short)301727748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1677061514;
					short num4 = num2;
					num2 = (short)396881290;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)684392448;
						if (num2 != 0)
						{
						}
						stringBuilder.Append('F');
						num3++;
						num2 = (short)252116994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_93;
				case 2:
					goto IL_93;
				case 3:
					goto IL_8E;
				case 4:
				{
					long num5 = global::System.Convert.ToInt64(stringBuilder.ToString(), 16);
					num2 = (short)1141309445;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					long num5;
					if (num5 > 2147483647L)
					{
						num2 = (short)719912963;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return num5;
				}
				}
				goto IL_28;
				IL_93:
				num2 = (short)718864384;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8E:
			num2 = (short)1927348224;
			short num6 = num2;
			return 2147483647L;
			IL_28:
			stringBuilder = new global::System.Text.StringBuilder();
			num3 = 0;
			num2 = (short)565575681;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
