using System;
using System.Windows;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS.CommandLineCPS
{
	// Token: 0x02000098 RID: 152
	public class MyMessageBox
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x000FC138 File Offset: 0x000FA338
		internal static global::System.Windows.MessageBoxResult Show(string messageBoxText, global::System.Windows.MessageBoxResult defaultResult = global::System.Windows.MessageBoxResult.OK)
		{
			int a_ = 3;
			short num = (short)378142720;
			short num2 = num;
			num = (short)1997654280;
			short num3 = num;
			num = (short)426625288;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)590479361;
				if (num != 0)
				{
				}
				num = (short)1903362048;
				if (num != 0)
				{
				}
				if ((bool)global::System.Windows.Application.Current.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃢ諤諦蓨諪菬诮뷰髲鯴鋶뫸꯺껼", a_)])
				{
					return defaultResult;
				}
				break;
			}
			return global::System.Windows.MessageBox.Show(messageBoxText);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000FC218 File Offset: 0x000FA418
		internal static global::System.Windows.MessageBoxResult Show(string messageBoxText, string caption, global::System.Windows.MessageBoxResult defaultResult = global::System.Windows.MessageBoxResult.OK)
		{
			int a_ = 5;
			short num = (short)401539072;
			short num2 = num;
			num = (short)2144241567;
			short num3 = num;
			num = (short)1075152799;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)280887297;
				if (num != 0)
				{
				}
				num = (short)2013331456;
				if (num != 0)
				{
				}
				if ((bool)global::System.Windows.Application.Current.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꛤ裦蓨蛪賬臮闰뿲鳴駶鳸룺근곾", a_)])
				{
					return defaultResult;
				}
				break;
			}
			return global::System.Windows.MessageBox.Show(messageBoxText, caption);
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x000FC2FC File Offset: 0x000FA4FC
		internal static global::System.Windows.MessageBoxResult Show(string messageBoxText, string caption, global::System.Windows.MessageBoxButton button, global::System.Windows.MessageBoxResult defaultResult = global::System.Windows.MessageBoxResult.OK)
		{
			int a_ = 2;
			short num = (short)1166868491;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.MessageBoxResult result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					result = defaultResult;
					num = (short)1106771973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					if (button == global::System.Windows.MessageBoxButton.OKCancel)
					{
						num = (short)498466822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1011744781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)2006384642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (defaultResult == global::System.Windows.MessageBoxResult.Yes)
					{
						num = (short)271319052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)801570825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (button != global::System.Windows.MessageBoxButton.OK)
					{
						num = (short)1980170243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_292;
				case 6:
					goto IL_292;
				case 7:
					goto IL_342;
				case 8:
					goto IL_1F9;
				case 9:
					if (defaultResult == global::System.Windows.MessageBoxResult.No)
					{
						num = (short)1557397520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 10:
					if (button == global::System.Windows.MessageBoxButton.YesNoCancel)
					{
						num = (short)193855496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 12:
					num = (short)1750794241;
					if (num != 0)
					{
					}
					result = global::System.Windows.MessageBoxResult.OK;
					num = (short)1587544071;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (button != global::System.Windows.MessageBoxButton.YesNo)
					{
						num = (short)1354170382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
				case 14:
				{
					num = (short)181801743;
					short num3 = num;
					num = (short)983044879;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1583546368;
						if (num != 0)
						{
						}
						num = (short)2046623754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					result = global::System.Windows.MessageBoxResult.Yes;
					num = (short)1081475089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					result = global::System.Windows.MessageBoxResult.Cancel;
					num = (short)968753153;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					return result;
				case 18:
					if (defaultResult == global::System.Windows.MessageBoxResult.OK)
					{
						num = (short)1063452672;
						short num4 = num;
						num = (short)535298063;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				IL_7A:
				if ((bool)global::System.Windows.Application.Current.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇡ诣该藧诩苫諭볯鯱髳鏵믷꫹꿻", a_)])
				{
					num = (short)896401408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_347;
				IL_1F9:
				num = (short)1313210386;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_292:
				num = (short)27525124;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_342:
			return result;
			IL_347:
			return global::System.Windows.MessageBox.Show(messageBoxText, caption, button);
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000FC658 File Offset: 0x000FA858
		internal static global::System.Windows.MessageBoxResult Show(string messageBoxText, string caption, global::System.Windows.MessageBoxButton button, global::System.Windows.MessageBoxImage icon, global::System.Windows.MessageBoxResult defaultResult)
		{
			int a_ = 11;
			short num = (short)2082078731;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.MessageBoxResult result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					result = defaultResult;
					num = (short)170065925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					if (button == global::System.Windows.MessageBoxButton.OKCancel)
					{
						num = (short)41549830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1300365325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1064960002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (defaultResult == global::System.Windows.MessageBoxResult.Yes)
					{
						num = (short)1308426252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1987706889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (button != global::System.Windows.MessageBoxButton.OK)
					{
						num = (short)805502979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2BC;
				case 6:
					goto IL_2BC;
				case 7:
					goto IL_346;
				case 8:
					goto IL_21D;
				case 9:
					if (defaultResult == global::System.Windows.MessageBoxResult.No)
					{
						num = (short)365756432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 10:
					if (button == global::System.Windows.MessageBoxButton.YesNoCancel)
					{
						num = (short)182190088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_79;
					}
					continue;
				case 12:
					result = global::System.Windows.MessageBoxResult.OK;
					num = (short)729939975;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (button != global::System.Windows.MessageBoxButton.YesNo)
					{
						num = (short)171769870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21D;
				case 14:
				{
					num = (short)1907328540;
					short num3 = num;
					num = (short)372016668;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)718667776;
						if (num != 0)
						{
						}
						num = (short)105381898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					result = global::System.Windows.MessageBoxResult.Yes;
					num = (short)1117192209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					result = global::System.Windows.MessageBoxResult.Cancel;
					num = (short)563347457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					return result;
				case 18:
				{
					num = (short)1717370880;
					short num4 = num;
					if (defaultResult == global::System.Windows.MessageBoxResult.OK)
					{
						num = (short)1244266511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				}
				IL_79:
				if ((bool)global::System.Windows.Application.Current.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꣪苬苮鳰鋲鯴鏶뗸鋺鏼髾䈀匂嘄", a_)])
				{
					num = (short)44826625;
					if (num != 0)
					{
					}
					num = (short)1035403264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_34B;
				IL_21D:
				num = (short)1042481170;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2BC:
				num = (short)862584836;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_346:
			return result;
			IL_34B:
			return global::System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, defaultResult);
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x000FC9BC File Offset: 0x000FABBC
		internal static global::System.Windows.MessageBoxResult Show(string messageBoxText, string caption, global::System.Windows.MessageBoxButton button, global::System.Windows.MessageBoxImage icon, global::System.Windows.MessageBoxResult defaultResult, global::System.Windows.MessageBoxOptions options)
		{
			int a_ = 9;
			short num = (short)26345483;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Windows.MessageBoxResult result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					result = defaultResult;
					num = (short)95092741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					if (button == global::System.Windows.MessageBoxButton.OKCancel)
					{
						num = (short)203423750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)891420685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)477102082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (defaultResult == global::System.Windows.MessageBoxResult.Yes)
					{
						num = (short)1411252236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2061041673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (button != global::System.Windows.MessageBoxButton.OK)
					{
						num = (short)1202454531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C2;
				case 6:
					goto IL_2C2;
				case 7:
					goto IL_34C;
				case 8:
					goto IL_225;
				case 9:
					if (defaultResult == global::System.Windows.MessageBoxResult.No)
					{
						num = (short)1950547984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 10:
					if (button == global::System.Windows.MessageBoxButton.YesNoCancel)
					{
						num = (short)372572168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 12:
					result = global::System.Windows.MessageBoxResult.OK;
					num = (short)981008391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (button != global::System.Windows.MessageBoxButton.YesNo)
					{
						num = (short)1563885582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_225;
				case 14:
				{
					num = (short)1068423567;
					short num3 = num;
					num = (short)1756158351;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)341901312;
						if (num != 0)
						{
						}
						num = (short)195428362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 15:
					result = global::System.Windows.MessageBoxResult.Yes;
					num = (short)1408696321;
					if (num != 0)
					{
					}
					num = (short)1364000785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					result = global::System.Windows.MessageBoxResult.Cancel;
					num = (short)214302721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					return result;
				case 18:
				{
					num = (short)696320000;
					short num4 = num;
					if (defaultResult == global::System.Windows.MessageBoxResult.OK)
					{
						num = (short)448462863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				}
				IL_7A:
				if ((bool)global::System.Windows.Application.Current.Properties[global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꫨ蓪胬苮郰鷲釴믶郸闺飼볾儀倂", a_)])
				{
					num = (short)311164928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_351;
				IL_225:
				num = (short)129695762;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C2:
				num = (short)33882116;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_34C:
			return result;
			IL_351:
			return global::System.Windows.MessageBox.Show(messageBoxText, caption, button, icon, defaultResult, options);
		}

		// Token: 0x040003A8 RID: 936
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
