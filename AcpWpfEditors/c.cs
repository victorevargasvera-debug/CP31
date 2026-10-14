using System;
using System.Windows;
using System.Windows.Media;

namespace DevComponents.WpfEditors
{
	// Token: 0x0200000C RID: 12
	internal static class c
	{
		// Token: 0x06000058 RID: 88 RVA: 0x0000932C File Offset: 0x0000752C
		public static float c(global::System.Windows.Media.Color A_0)
		{
			short num = (short)1120600064;
			switch (num)
			{
			default:
			{
				num = (short)944766999;
				int num2 = (int)((global::System.IntPtr)num);
				float num3;
				for (;;)
				{
					float num4;
					float num5;
					float num6;
					float num7;
					float num8;
					float num9;
					switch (num2)
					{
					case 0:
						if (num3 < 0f)
						{
							num = (short)1429012481;
							if (num != 0)
							{
							}
							num = (short)1675821081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num3;
					case 1:
						goto IL_374;
					case 2:
						num3 = (num4 - num5) / num6;
						num = (short)1519714314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_3F8;
					case 4:
						num = (short)1496776719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_379;
					case 6:
						if (num4 < num7)
						{
							num = (short)394723355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					case 7:
						num8 = num5;
						num = (short)1428815877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_1DB;
					case 9:
						num3 = 4f + (num9 - num4) / num6;
						num = (short)1366491160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_1DB;
					case 11:
						if (num4 > num8)
						{
							num = (short)288620562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28B;
					case 12:
						if (num9 == num8)
						{
							num = (short)1468334082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1906573331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)842129107;
						short num10 = num;
						num = (short)1128783571;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_46F;
						default:
							num = (short)2035089408;
							if (num != 0)
							{
							}
							if (num5 > num8)
							{
								num = (short)362676231;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_379;
						}
						break;
					}
					case 14:
						goto IL_4E1;
					case 15:
						if (A_0.G == A_0.B)
						{
							num = (short)1110048771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FD;
					case 16:
						num3 = 2f + (num5 - num9) / num6;
						num = (short)1482031112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (num5 == num8)
						{
							num = (short)75628553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					case 18:
						goto IL_46F;
					case 19:
						if (num4 == num8)
						{
							num = (short)1691353104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1649737745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_28B;
					case 21:
						if (num5 < num7)
						{
							num = (short)933101594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E1;
					case 22:
						goto IL_24C;
					case 23:
						switch (0)
						{
						case 0:
							goto IL_B5;
						}
						continue;
					case 24:
						goto IL_1DB;
					case 25:
						num3 += 360f;
						num = (short)375586817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						num = (short)638648320;
						short num11 = num;
						num7 = num5;
						num = (short)1462894606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						num7 = num4;
						num = (short)1511850006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B5:
					if (A_0.R == A_0.G)
					{
						num = (short)2125660164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3FD;
					IL_1DB:
					num3 *= 60f;
					num = (short)1402339328;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24C:
					num = (short)370802709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28B:
					num = (short)1817313293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_379:
					num = (short)259588102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FD:
					num9 = (float)A_0.R / 255f;
					num4 = (float)A_0.G / 255f;
					num5 = (float)A_0.B / 255f;
					num3 = 0f;
					num8 = num9;
					num7 = num9;
					num = (short)1375010827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46F:
					num8 = num4;
					num = (short)2013986836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E1:
					num6 = num8 - num7;
					num = (short)1661337612;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_374:
				return num3;
				IL_3F8:
				return 0f;
			}
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00009860 File Offset: 0x00007A60
		public static float b(global::System.Windows.Media.Color A_0)
		{
			short num = (short)576323584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)968163328;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				float num4;
				float num5;
				float num6;
				float num7;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						if (num4 > num5)
						{
							num = (short)1752236036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15C;
					case 1:
						num6 = num4;
						num = (short)242941963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num4 < num6)
						{
							num = (short)165543937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_295;
					case 3:
						goto IL_15C;
					case 4:
						num5 = num4;
						num = (short)268369923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1888681985;
						if (num != 0)
						{
						}
						goto IL_198;
					case 6:
						num5 = num7;
						num = (short)1639251973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_CC;
					case 8:
						goto IL_23B;
					case 9:
						if (num7 < num6)
						{
							num = (short)1106313226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23B;
					case 10:
					{
						num = (short)622586824;
						short num8 = num;
						num = (short)2020207560;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CC;
						default:
							num = (short)1590886400;
							if (num != 0)
							{
							}
							num6 = num7;
							num = (short)1558511624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						goto IL_1EF;
					}
					goto IL_88;
					IL_CC:
					if (num7 > num5)
					{
						num = (short)1290731526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_198;
					IL_15C:
					num = (short)608829449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_198:
					num = (short)1367605248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23B:
					num = (short)1634140162;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1EF:
				IL_295:
				return (num5 + num6) / 2f;
				IL_88:
				float num9 = (float)A_0.R / 255f;
				num7 = (float)A_0.G / 255f;
				num4 = (float)A_0.B / 255f;
				num5 = num9;
				num6 = num9;
				num = (short)159580167;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00009B0C File Offset: 0x00007D0C
		public static float a(global::System.Windows.Media.Color A_0)
		{
			short num = (short)776273920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				float num3;
				float num4;
				float result;
				float num5;
				float num6;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_30D;
					case 1:
						if (num3 < num4)
						{
							num = (short)1791098884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E1;
					case 2:
						goto IL_20A;
					case 3:
						goto IL_E1;
					case 4:
						num4 = num3;
						num = (short)1399521283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return result;
					case 6:
						if (num5 < num4)
						{
							num = (short)1273430023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E;
					case 7:
						goto IL_2AF;
					case 8:
						goto IL_159;
					case 9:
						if (num3 > num6)
						{
							num = (short)1607598093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30D;
					case 10:
						goto IL_11E;
					case 11:
						if (num6 == num4)
						{
							num = (short)573440005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)545193996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if ((double)((num6 + num4) / 2f) <= 0.5)
						{
							num = (short)1312423937;
							if (num != 0)
							{
							}
							num = (short)1269497858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34C;
					case 13:
						num6 = num3;
						num = (short)2081423360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num6 = num5;
						num = (short)16056320;
						short num7 = num;
						num = (short)1373305204;
						short num8 = num;
						num = (short)854522228;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AF;
						default:
							num = (short)1840185344;
							if (num != 0)
							{
							}
							num = (short)1392443400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						if (num5 > num6)
						{
							num = (short)2074869774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					}
					goto IL_6F;
					IL_E1:
					num = (short)1644691467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11E:
					num = (short)397279233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_159:
					num = (short)1563492361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AF:
					num4 = num5;
					num = (short)970784778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30D:
					num = (short)1022099462;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_20A:
				return (num6 - num4) / (num6 + num4);
				IL_34C:
				return (num6 - num4) / (2f - num6 - num4);
				IL_6F:
				float num9 = (float)A_0.R / 255f;
				num5 = (float)A_0.G / 255f;
				num3 = (float)A_0.B / 255f;
				result = 0f;
				num6 = num9;
				num4 = num9;
				num = (short)263192591;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00009E74 File Offset: 0x00008074
		public static global::System.Windows.Point a(global::System.Windows.Media.Visual A_0)
		{
			global::System.Windows.Point result = new global::System.Windows.Point(120.0, 120.0);
			global::System.Windows.PresentationSource presentationSource = global::System.Windows.PresentationSource.FromVisual(A_0);
			if (presentationSource == null)
			{
				short num;
				for (;;)
				{
					num = (short)1722941440;
					short num2 = num;
					num = (short)1177027217;
					short num3 = num;
					num = (short)1039729297;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_85;
					}
				}
				IL_85:
				num = (short)1467875329;
				if (num != 0)
				{
				}
				num = (short)667484160;
				if (num != 0)
				{
				}
				return result;
			}
			global::System.Windows.Media.MatrixTransform matrixTransform = new global::System.Windows.Media.MatrixTransform(presentationSource.CompositionTarget.TransformToDevice);
			global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
			point = matrixTransform.Transform(point);
			global::System.Windows.Point point2 = new global::System.Windows.Point(96.0, 96.0);
			point2 = matrixTransform.Transform(point2);
			result.X = point2.X - point.X;
			result.Y = point2.Y - point.Y;
			return result;
		}
	}
}
