using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x0200019E RID: 414
	public sealed class PackandunpackUUID : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600451C RID: 17692 RVA: 0x004039C8 File Offset: 0x00401BC8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 14;
			short num = (short)1371734016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				string text2;
				string text8;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_1A6;
					case 1:
					{
						num = (short)643235841;
						if (num != 0)
						{
						}
						num = (short)1576468480;
						short num3 = num;
						string text = text2.Substring(0, 8);
						string text3 = text2.Substring(8, 4);
						string text4 = text2.Substring(12, 4);
						string text5 = text2.Substring(16, 2);
						string text6 = text2.Substring(18, 2);
						string text7 = text2.Substring(20, 12);
						text8 = string.Concat(new string[]
						{
							text.Substring(6, 2),
							text.Substring(4, 2),
							text.Substring(2, 2),
							text.Substring(0, 2),
							global::AllFeatures.CodeplugGuid.b("", a_),
							text3.Substring(2, 2),
							text3.Substring(0, 2),
							global::AllFeatures.CodeplugGuid.b("", a_),
							text4.Substring(2, 2),
							text4.Substring(0, 2),
							global::AllFeatures.CodeplugGuid.b("", a_),
							text5,
							text6,
							global::AllFeatures.CodeplugGuid.b("", a_),
							text7
						});
						num = (short)1983578112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (text2.Length == 32)
						{
							num = (short)168558593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28A;
					case 3:
						if (text2 != null)
						{
							num = (short)12189700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28A;
					case 4:
						for (;;)
						{
							num = (short)772269713;
							short num4 = num;
							num = (short)1723786897;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_1E1;
							}
						}
						IL_1E1:
						num = (short)473104384;
						if (num != 0)
						{
						}
						num = (short)249167874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B;
				}
				IL_1A6:
				IL_28A:
				return text8.ToUpper();
				IL_4B:
				text2 = (string)value;
				text8 = "";
				num = (short)1883176963;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600451D RID: 17693 RVA: 0x00403C68 File Offset: 0x00401E68
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 0;
			short num = (short)195231744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_DB;
				}
				string text;
				string text5;
				for (;;)
				{
					IL_30:
					int num3;
					int num7;
					int num12;
					switch (num2)
					{
					case 0:
						goto IL_780;
					case 1:
						num3 = 0;
						num = (short)1547304993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)858996549;
						short num4 = num;
						num = (short)1147092805;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_733;
						default:
						{
							num = (short)1489698816;
							if (num != 0)
							{
							}
							int num5;
							byte[] array;
							if (num5 >= array.Length)
							{
								num = (short)1711144989;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							uint num6;
							array[num5] = (byte)(num6 & 255U);
							num6 >>= 8;
							num5++;
							num = (short)865927180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_125;
					case 4:
						num7 = 0;
						num = (short)115867687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						int num8;
						byte[] array2;
						if (num8 >= array2.Length)
						{
							num = (short)1184169988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						uint num9;
						array2[num8] = (byte)(num9 & 255U);
						num9 >>= 8;
						num8++;
						num = (short)664731669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						string value2 = text.Substring(0, 8);
						string value3 = text.Substring(9, 4);
						string value4 = text.Substring(14, 4);
						string text2 = text.Substring(19, 2);
						string text3 = text.Substring(21, 2);
						string text4 = text.Substring(24, 12);
						ulong num10 = global::System.Convert.ToUInt64(value2, 16);
						uint num6 = global::System.Convert.ToUInt32(value3, 16);
						uint num9 = global::System.Convert.ToUInt32(value4, 16);
						byte[] array3 = new byte[4];
						int num11 = 0;
						num = (short)1166409759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						byte[] array2;
						if (array2[num12] <= 16)
						{
							num = (short)1398276136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text5 += global::System.Convert.ToString(array2[num12], 16);
						num = (short)2066481170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						num = (short)491585537;
						if (num != 0)
						{
						}
						byte[] array;
						if (array[num3] <= 16)
						{
							num = (short)1639907339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text5 += global::System.Convert.ToString(array[num3], 16);
						num = (short)1187512350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (text.Length == 36)
						{
							num = (short)1332281350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text5;
					case 10:
						goto IL_780;
					case 11:
					{
						byte[] array;
						text5 = text5 + global::AllFeatures.CodeplugGuid.b("", a_) + global::System.Convert.ToString(array[num3], 16);
						num = (short)40894467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_481;
					case 13:
					{
						byte[] array;
						if (num3 >= array.Length)
						{
							num = (short)1218707484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)50331656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_536;
					case 15:
					{
						byte[] array3;
						if (num7 >= array3.Length)
						{
							num = (short)658112513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)597032983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_276;
					case 17:
					{
						string text4;
						string text6 = text4.Substring(0, 2);
						string text7 = text4.Substring(2, 2);
						string text8 = text4.Substring(4, 2);
						string text9 = text4.Substring(6, 2);
						string text10 = text4.Substring(8, 2);
						string text11 = text4.Substring(10, 2);
						string text2;
						string text3;
						text5 = string.Concat(new string[]
						{
							text5,
							text2.ToLower(),
							text3.ToLower(),
							text6.ToLower(),
							text7.ToLower(),
							text8.ToLower(),
							text9.ToLower(),
							text10.ToLower(),
							text11.ToLower()
						});
						num = (short)1189150758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_252;
					case 19:
						goto IL_481;
					case 20:
					{
						num = (short)1406337024;
						short num13 = num;
						num = (short)1620967433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_536;
					case 22:
						goto IL_828;
					case 23:
					{
						byte[] array3;
						if (array3[num7] <= 16)
						{
							num = (short)819462176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text5 += global::System.Convert.ToString(array3[num7], 16);
						num = (short)1940848650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_252;
					case 25:
					{
						byte[] array = new byte[2];
						int num5 = 0;
						num = (short)2092040211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_1DE;
					case 27:
					{
						byte[] array3;
						int num11;
						if (num11 >= array3.Length)
						{
							num = (short)1053687833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						ulong num10;
						array3[num11] = (byte)(num10 & 255UL);
						num10 >>= 8;
						num11++;
						num = (short)1874198554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						num12 = 0;
						goto IL_733;
					case 29:
					{
						byte[] array2 = new byte[2];
						int num8 = 0;
						num = (short)382468110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_125;
					case 31:
						goto IL_1DE;
					case 32:
					{
						byte[] array3;
						text5 = text5 + global::AllFeatures.CodeplugGuid.b("", a_) + global::System.Convert.ToString(array3[num7], 16);
						num = (short)882376704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_5B9;
					case 34:
						goto IL_828;
					case 35:
					{
						byte[] array2;
						if (num12 >= array2.Length)
						{
							num = (short)1377042449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)824049671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						if (text != null)
						{
							num = (short)643760148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text5;
					case 37:
						goto IL_5B9;
					case 38:
						return text5;
					case 39:
						goto IL_276;
					case 40:
					{
						byte[] array2;
						text5 = text5 + global::AllFeatures.CodeplugGuid.b("", a_) + global::System.Convert.ToString(array2[num12], 16);
						num = (short)2107375640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_DB;
					IL_125:
					num3++;
					num = (short)568524837;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DE:
					num = (short)617676827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_252:
					num12++;
					num = (short)1756233750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_276:
					num = (short)1907032079;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_481:
					num = (short)456327170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_536:
					num = (short)2120810501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B9:
					num = (short)879165453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_733:
					num = (short)413925410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_780:
					num7++;
					num = (short)311558160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_828:
					num = (short)2040463395;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text5;
				IL_DB:
				text = (string)value;
				text5 = "";
				num = (short)576520228;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
