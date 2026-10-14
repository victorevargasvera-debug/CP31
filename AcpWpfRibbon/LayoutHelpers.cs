using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000058 RID: 88
	internal class LayoutHelpers
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00058D5C File Offset: 0x00056F5C
		public static global::System.Windows.Size AddHorizontal(global::System.Windows.Size size1, global::System.Windows.Size size2)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_E1;
				case 1:
				{
					num2 = (short)829319136;
					short num3 = num2;
					num2 = (short)179136480;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					default:
						num2 = (short)1084948480;
						if (num2 != 0)
						{
						}
						num2 = (short)1444413441;
						if (num2 != 0)
						{
						}
						if (size2.Height > size1.Height)
						{
							num2 = (short)330498048;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return size1;
					}
					break;
				}
				case 2:
					return size1;
				}
				goto IL_1C;
				IL_E1:
				num2 = (short)1452998656;
				short num4 = num2;
				size1.Height = size2.Height;
				num2 = (short)391446530;
				num = (int)((global::System.IntPtr)num2);
			}
			return size1;
			IL_1C:
			size1.Width += size2.Width;
			num2 = (short)538771457;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00058EA0 File Offset: 0x000570A0
		public static global::System.Windows.Size AddVertical(global::System.Windows.Size size1, global::System.Windows.Size size2)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_BA;
				case 1:
				{
					num2 = (short)446744322;
					short num3 = num2;
					num2 = (short)1384433410;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA;
					default:
						num2 = (short)1105723392;
						if (num2 != 0)
						{
						}
						if (size2.Width > size1.Width)
						{
							num2 = (short)1633157120;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return size1;
					}
					break;
				}
				case 2:
					return size1;
				}
				goto IL_1C;
				IL_BA:
				size1.Width = size2.Width;
				num2 = (short)1374552064;
				short num4 = num2;
				num2 = (short)195362817;
				if (num2 != 0)
				{
				}
				num2 = (short)2100822018;
				num = (int)((global::System.IntPtr)num2);
			}
			return size1;
			IL_1C:
			size1.Height += size2.Height;
			num2 = (short)276037633;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00058FE0 File Offset: 0x000571E0
		public static bool IsUniform(global::System.Windows.Thickness borderThickness)
		{
			short num = (short)1677000706;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)816172089;
					short num3 = num;
					num = (short)539151417;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					case 1:
						break;
					default:
					{
						num = (short)804716544;
						short num4 = num;
						break;
					}
					}
					num = (short)196804608;
					if (num != 0)
					{
					}
					num = (short)941817859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_14B;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					if (borderThickness.Left == borderThickness.Right)
					{
						num = (short)476839937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_35:
				num = (short)1009451009;
				if (num != 0)
				{
				}
				if (borderThickness.Bottom != borderThickness.Top)
				{
					return false;
				}
				num = (short)884670464;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14B:
			return borderThickness.Top == borderThickness.Left;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0005913C File Offset: 0x0005733C
		public static bool IsZero(double value)
		{
			short num = (short)1880348117;
			short num2 = num;
			num = (short)1370412501;
			switch (num2 == num)
			{
			default:
			{
				num = (short)712835072;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1293352960;
			if (num != 0)
			{
			}
			num = (short)1462370305;
			if (num != 0)
			{
			}
			return global::System.Math.Abs(value) < 2.220446049250313E-15;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000591F4 File Offset: 0x000573F4
		public static bool IsClose(double val1, double val2)
		{
			short num = (short)438319353;
			short num2 = num;
			num = (short)1715091705;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1218248704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)332333057;
			if (num != 0)
			{
			}
			num = (short)1532952576;
			if (num != 0)
			{
			}
			return global::System.Math.Abs(val1 - val2) < 1.0;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000592B0 File Offset: 0x000574B0
		public static bool GreaterThan(double value1, double value2)
		{
			if (value1 > value2)
			{
				short num = (short)1004013010;
				short num2 = num;
				num = (short)967443922;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)658767872;
					short num3 = num;
					num = (short)2069037056;
					if (num != 0)
					{
					}
					num = (short)8650753;
					if (num != 0)
					{
					}
					return !global::DevComponents.WpfRibbon.LayoutHelpers.IsClose(value1, value2);
				}
				}
			}
			return false;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00059370 File Offset: 0x00057570
		public static bool IsZero(global::System.Windows.Size size)
		{
			if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size.Width))
			{
				short num = (short)1583452968;
				short num2 = num;
				num = (short)1670222632;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)411959296;
					short num3 = num;
					num = (short)1674248193;
					if (num != 0)
					{
					}
					num = (short)217513984;
					if (num != 0)
					{
					}
					return global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size.Height);
				}
				}
			}
			return false;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x0005943C File Offset: 0x0005763C
		public static global::System.Windows.Rect DeflateRect(global::System.Windows.Rect r, global::System.Windows.Thickness thick)
		{
			short num = (short)1083883587;
			short num2 = num;
			num = (short)1286717507;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1771241472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)549257217;
			if (num != 0)
			{
			}
			num = (short)714670080;
			if (num != 0)
			{
			}
			return new global::System.Windows.Rect(r.Left + thick.Left, r.Top + thick.Top, global::System.Math.Max(0.0, r.Width - thick.Left - thick.Right), global::System.Math.Max(0.0, r.Height - thick.Top - thick.Bottom));
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00059558 File Offset: 0x00057758
		public static global::System.Windows.Size GetThicknessSize(global::System.Windows.Thickness t)
		{
			short num = (short)1323318564;
			short num2 = num;
			num = (short)1744125220;
			switch (num2 == num)
			{
			default:
			{
				num = (short)966524928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1798701057;
			if (num != 0)
			{
			}
			num = (short)1262288896;
			if (num != 0)
			{
			}
			return new global::System.Windows.Size(t.Left + t.Right, t.Top + t.Bottom);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00059624 File Offset: 0x00057824
		public static void CreateGeometry(global::System.Windows.Media.StreamGeometryContext ctx, global::System.Windows.Rect rect, global::DevComponents.WpfRibbon.LayoutHelpers.RadiusDescription rd)
		{
			short num = (short)2067988480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				global::System.Windows.Point point;
				global::System.Windows.Point point2;
				global::System.Windows.Point point3;
				global::System.Windows.Point point4;
				global::System.Windows.Point point5;
				global::System.Windows.Point point6;
				global::System.Windows.Point point7;
				global::System.Windows.Point startPoint;
				for (;;)
				{
					IL_29:
					global::System.Windows.Size size;
					switch (num2)
					{
					case 0:
						goto IL_663;
					case 1:
						goto IL_447;
					case 2:
						ctx.ArcTo(point, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)761921555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)323551233;
						if (num != 0)
						{
						}
						ctx.ArcTo(point2, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)1482227728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						point.Y = rect.Y + rect.Height / 2.0;
						point3.Y = point.Y;
						goto IL_5FE;
					case 5:
					{
						num = (short)700827078;
						short num3 = num;
						num = (short)741262790;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5FE;
						default:
							num = (short)809041920;
							if (num != 0)
							{
							}
							if (point4.X > point5.X)
							{
								num = (short)1167065095;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6F7;
						}
						break;
					}
					case 6:
						ctx.ArcTo(point6, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)871497739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						point4.X = rect.X + rect.Width / 2.0;
						point5.X = point4.X;
						num = (short)1915944980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)26017798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_312;
					case 9:
						point6.X = rect.X + rect.Width / 2.0;
						point7.X = point6.X;
						num = (short)1451491329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)958070786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_543;
					case 11:
						goto IL_312;
					case 12:
						goto IL_48F;
					case 13:
						goto IL_2C8;
					case 14:
						if (startPoint.Y > point4.Y)
						{
							num = (short)302448657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					case 15:
						ctx.ArcTo(point5, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)2134245388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return;
					case 17:
						startPoint.Y = rect.Y + rect.Height / 2.0;
						point2.Y = startPoint.Y;
						num = (short)2009792525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (point6.X > point7.X)
						{
							num = (short)673382409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_447;
					case 19:
						goto IL_543;
					case 20:
						goto IL_6F7;
					case 21:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)1058865167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					case 22:
						if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(size))
						{
							num = (short)349306883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
						if (point.Y > point3.Y)
						{
							num = (short)15663108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_663;
					}
					goto IL_90;
					IL_2C8:
					num = (short)2055864338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_312:
					ctx.LineTo(point7, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, rect.Right - point7.X), global::System.Math.Max(0.0, point.Y - rect.Y));
					num = (short)526974976;
					short num4 = num;
					num = (short)178585610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_447:
					num = (short)1130430487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48F:
					ctx.LineTo(point4, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, point4.X - rect.X), global::System.Math.Max(0.0, rect.Bottom - point2.Y));
					num = (short)1564278806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_543:
					ctx.LineTo(point3, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, rect.Right - point5.X), global::System.Math.Max(0.0, rect.Bottom - point3.Y));
					num = (short)959119381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FE:
					num = (short)1173291008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_663:
					num = (short)1467154437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F7:
					ctx.BeginFigure(startPoint, true, true);
					size = new global::System.Windows.Size(global::System.Math.Max(point6.X - rect.X, 0.0), global::System.Math.Max(0.0, startPoint.Y - rect.Y));
					num = (short)1241972744;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_90:
				startPoint = new global::System.Windows.Point(rect.X, rect.Y + rd.TopLeft.Y);
				point6 = new global::System.Windows.Point(rect.X + rd.TopLeft.X, rect.Y);
				point7 = new global::System.Windows.Point(rect.Right - rd.TopRight.X, rect.Y);
				point = new global::System.Windows.Point(rect.Right, rect.Y + rd.TopRight.Y);
				point3 = new global::System.Windows.Point(rect.Right, rect.Bottom - rd.BottomRight.Y);
				point5 = new global::System.Windows.Point(rect.Right - rd.BottomRight.X, rect.Bottom);
				point4 = new global::System.Windows.Point(rd.BottomLeft.X, rect.Bottom);
				point2 = new global::System.Windows.Point(rect.X, rect.Bottom - rd.BottomLeft.Y);
				num = (short)669515790;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00059DB4 File Offset: 0x00057FB4
		public static bool IsThicknessValid(object value)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num;
			short num2;
			global::System.Windows.Thickness thickness;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
					num2 = (short)1811873809;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_3E5;
				case 3:
					num2 = (short)657850398;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)114425876;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (double.IsPositiveInfinity(thickness.Bottom))
					{
						num2 = (short)1354104846;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1342242826;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!double.IsPositiveInfinity(thickness.Top))
					{
						num2 = (short)1196556316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					num2 = (short)1276903450;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!double.IsNegativeInfinity(thickness.Top))
					{
						num2 = (short)1389821965;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					if (!double.IsNegativeInfinity(thickness.Right))
					{
						num2 = (short)1315569676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 10:
					if (!double.IsNegativeInfinity(thickness.Left))
					{
						num2 = (short)1813381135;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					if (!double.IsNegativeInfinity(thickness.Bottom))
					{
						num2 = (short)1361772544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 12:
					num2 = (short)436731912;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)1150287883;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_287;
				case 15:
					num2 = (short)331481097;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)1192034333;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (thickness.Bottom >= 0.0)
					{
						num2 = (short)1550516247;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 18:
					num2 = (short)1159397401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)931921951;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)2047475713;
					if (num2 != 0)
					{
					}
					if (!double.IsNaN(thickness.Top))
					{
						num2 = (short)464322563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4E5;
				case 21:
					if (!double.IsNaN(thickness.Left))
					{
						num2 = (short)1939079187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4E5;
				case 22:
					if (thickness.Left >= 0.0)
					{
						num2 = (short)1760231440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 23:
				{
					num2 = (short)1310657926;
					short num3 = num2;
					num2 = (short)1896615302;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_108;
					default:
						num2 = (short)646971392;
						if (num2 != 0)
						{
						}
						num2 = (short)1956380693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 24:
					if (!double.IsPositiveInfinity(thickness.Left))
					{
						num2 = (short)881917970;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 25:
					if (!double.IsPositiveInfinity(thickness.Right))
					{
						goto IL_108;
					}
					return false;
				case 26:
					if (thickness.Top >= 0.0)
					{
						num2 = (short)1889992705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 27:
					num2 = (short)1118306310;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					num2 = (short)1498152965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (thickness.Right >= 0.0)
					{
						num2 = (short)871956487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 30:
					if (double.IsNaN(thickness.Bottom))
					{
						num2 = (short)1265434626;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)409534488;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (!double.IsNaN(thickness.Right))
					{
						num2 = (short)384892932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4E5;
				}
				goto IL_90;
				IL_108:
				num2 = (short)1772421147;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_287:
			return false;
			IL_3E5:
			IL_4E5:
			num2 = (short)1672347648;
			short num4 = num2;
			return false;
			IL_90:
			thickness = (global::System.Windows.Thickness)value;
			num2 = (short)265551894;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0005A35C File Offset: 0x0005855C
		public static bool IsEmpty(global::System.Windows.Thickness t)
		{
			short num = (short)1414725637;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(t.Right))
					{
						num = (short)1481048070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(t.Left))
					{
						num = (short)317915139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)248840193;
					if (num != 0)
					{
					}
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(t.Bottom))
					{
						num = (short)243204105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
				{
					num = (short)1435893760;
					short num3 = num;
					num = (short)805306368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)305070082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 6:
					num = (short)1124663303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(t.Top))
					{
						num = (short)1687617544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					return true;
				case 9:
					goto IL_19A;
				}
				IL_4D:
				if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsThicknessValid(t))
				{
					return true;
				}
				num = (short)284772281;
				short num4 = num;
				num = (short)1720469433;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1141571584;
					if (num != 0)
					{
					}
					num = (short)650248196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_19A:
				num = (short)745603073;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0005A588 File Offset: 0x00058788
		public static bool IsEmpty(global::System.Windows.CornerRadius rad)
		{
			short num = (short)1970208769;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)423297025;
					if (num != 0)
					{
					}
					if (rad.BottomRight == 0.0)
					{
						goto IL_18D;
					}
					return false;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
					num = (short)629932032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (rad.TopLeft == 0.0)
					{
						num = (short)1832714245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					num = (short)101515267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1824629684;
					short num3 = num;
					num = (short)846570420;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18D;
					default:
						goto IL_A3;
					}
					break;
				}
				}
				IL_3D:
				if (rad.BottomLeft == 0.0)
				{
					num = (short)1750007810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_18D:
				num = (short)2031091716;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A3:
			num = (short)2078146560;
			short num4 = num;
			num = (short)409862144;
			if (num != 0)
			{
			}
			return rad.TopRight == 0.0;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0005A740 File Offset: 0x00058940
		public static bool IsEmpty(global::System.Windows.Rect r)
		{
			short num = (short)807469056;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					goto IL_13B;
				case 2:
				{
					num = (short)2124087296;
					short num3 = num;
					num = (short)2015559683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(r.Height))
					{
						return true;
					}
					num = (short)1924229733;
					short num4 = num;
					num = (short)591948389;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						num = (short)87949312;
						if (num != 0)
						{
						}
						num = (short)1095106561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_35;
				IL_6A:
				num = (short)320471042;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				num = (short)1006436353;
				if (num != 0)
				{
				}
				if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(r.Width))
				{
					goto IL_6A;
				}
				break;
			}
			IL_A9:
			return r.IsEmpty;
			IL_13B:
			goto IL_A9;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0005A890 File Offset: 0x00058A90
		public static bool IsEmpty(global::System.Windows.Size s)
		{
			short num = (short)363659264;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					goto IL_13C;
				case 2:
					num = (short)453443587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(s.Height))
					{
						return true;
					}
					num = (short)1057509107;
					short num3 = num;
					num = (short)386158323;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_43;
					default:
						num = (short)1633157121;
						if (num != 0)
						{
						}
						num = (short)1858338816;
						if (num != 0)
						{
						}
						num = (short)926941185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_35;
				IL_43:
				num = (short)24379394;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(s.Width))
				{
					goto IL_43;
				}
				break;
			}
			IL_5A:
			num = (short)1722744832;
			short num4 = num;
			return s.IsEmpty;
			IL_13C:
			goto IL_5A;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x0005A9E0 File Offset: 0x00058BE0
		public static bool IsEmpty(global::System.Windows.Point p)
		{
			short num = (short)983171073;
			if (num != 0)
			{
			}
			num = (short)1457389568;
			short num2 = num;
			num = (short)1234690632;
			short num3 = num;
			num = (short)1664606792;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2144993280;
				if (num != 0)
				{
				}
				if (global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(p.X))
				{
					return global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(p.Y);
				}
				break;
			}
			return false;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0005AAA4 File Offset: 0x00058CA4
		public static global::System.Windows.Point GetResolution(global::System.Windows.Media.Visual visual)
		{
			short num = (short)1237731710;
			short num2 = num;
			num = (short)1948469630;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C4;
			case 1:
				break;
			default:
			{
				num = (short)585498624;
				short num3 = num;
				break;
			}
			}
			num = (short)823525376;
			if (num != 0)
			{
			}
			global::System.Windows.Point result = new global::System.Windows.Point(120.0, 120.0);
			global::System.Windows.PresentationSource presentationSource = global::System.Windows.PresentationSource.FromVisual(visual);
			if (presentationSource == null)
			{
				num = (short)266862593;
				if (num != 0)
				{
				}
				return result;
			}
			IL_C4:
			global::System.Windows.Media.MatrixTransform matrixTransform = new global::System.Windows.Media.MatrixTransform(presentationSource.CompositionTarget.TransformToDevice);
			global::System.Windows.Point point = new global::System.Windows.Point(0.0, 0.0);
			point = matrixTransform.Transform(point);
			global::System.Windows.Point point2 = new global::System.Windows.Point(96.0, 96.0);
			point2 = matrixTransform.Transform(point2);
			result.X = point2.X - point.X;
			result.Y = point2.Y - point.Y;
			return result;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0005ABF4 File Offset: 0x00058DF4
		public static global::System.Windows.FrameworkElement GetElementAt(global::System.Windows.FrameworkElement elem, global::System.Windows.Point screenLocation)
		{
			short num = (short)1630011392;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)398262273;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 1:
					goto IL_F0;
				case 2:
					goto IL_A6;
				case 3:
					if (elem is global::System.Windows.Controls.Panel)
					{
						num = (short)1345191937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14C;
				}
				IL_5E:
				num = (short)1525481472;
				short num3 = num;
				if (elem is global::System.Windows.Controls.ItemsControl)
				{
					num = (short)488046594;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1853489155;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_A6:
			goto IL_13F;
			IL_F0:
			num = (short)1798667328;
			short num4 = num;
			num = (short)204373056;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13F:
				return global::DevComponents.WpfRibbon.LayoutHelpers.GetElementAt(elem as global::System.Windows.Controls.ItemsControl, screenLocation);
			default:
				num = (short)1934688256;
				if (num != 0)
				{
				}
				return global::DevComponents.WpfRibbon.LayoutHelpers.GetElementAt(elem as global::System.Windows.Controls.Panel, screenLocation);
			}
			IL_14C:
			return null;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0005AD50 File Offset: 0x00058F50
		public static global::System.Windows.FrameworkElement GetElementAt(global::System.Windows.Controls.ItemsControl ic, global::System.Windows.Point screenLocation)
		{
			short num = (short)903472863;
			short num2 = num;
			num = (short)1587668703;
			global::System.Windows.FrameworkElement result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1781596161;
				if (num != 0)
				{
				}
				num = (short)271908864;
				short num3 = num;
				num = (short)1394016256;
				if (num != 0)
				{
				}
				num = (short)458489856;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)ic.Items).GetEnumerator();
					try
					{
						num = (short)299237388;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement is global::System.Windows.Controls.Panel)
								{
									num = (short)65404933;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1804337162;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								object obj;
								if (obj is global::System.Windows.FrameworkElement)
								{
									num = (short)1782579211;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_406;
							case 3:
							{
								global::System.Windows.FrameworkElement elementAt;
								result = elementAt;
								num = (short)225181698;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1412956178;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								global::System.Windows.FrameworkElement elementAt = global::DevComponents.WpfRibbon.LayoutHelpers.GetElementAt(frameworkElement as global::System.Windows.Controls.Panel, screenLocation);
								num = (short)363266062;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_2EF;
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1730543624;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								num = (short)1457979393;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								num = (short)1104936969;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_424;
							case 10:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement is global::System.Windows.Controls.ItemsControl)
								{
									num = (short)84869136;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = frameworkElement;
								num = (short)1818427398;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
							{
								object obj;
								global::System.Windows.FrameworkElement frameworkElement = obj as global::System.Windows.FrameworkElement;
								global::System.Windows.Point point = frameworkElement.PointFromScreen(screenLocation);
								global::System.Windows.Rect rect = new global::System.Windows.Rect(frameworkElement.RenderSize);
								num = (short)1104609297;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								switch (0)
								{
								case 0:
									goto IL_148;
								}
								continue;
							case 13:
								goto IL_35B;
							case 14:
							{
								global::System.Windows.FrameworkElement elementAt;
								if (elementAt != null)
								{
									num = (short)1721368579;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 15:
								goto IL_167;
							case 16:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								global::System.Windows.FrameworkElement elementAt2 = global::DevComponents.WpfRibbon.LayoutHelpers.GetElementAt(frameworkElement as global::System.Windows.Controls.ItemsControl, screenLocation);
								num = (short)393478164;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 17:
							{
								global::System.Windows.Point point;
								global::System.Windows.Rect rect;
								if (rect.Contains(point))
								{
									num = (short)1141571588;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 18:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								if (frameworkElement is global::DevComponents.WpfRibbon.ButtonDropDown)
								{
									num = (short)1057947669;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)2103050240;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
							{
								global::System.Windows.FrameworkElement elementAt2;
								result = elementAt2;
								num = (short)422576143;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 20:
							{
								global::System.Windows.FrameworkElement elementAt2;
								if (elementAt2 != null)
								{
									num = (short)1343029267;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 21:
							{
								global::System.Windows.FrameworkElement frameworkElement;
								result = frameworkElement;
								num = (short)2127626253;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_20B:
							num = (short)1378222087;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_148:
							goto IL_20B;
						}
						IL_167:
						IL_2EF:
						IL_35B:
						IL_406:
						break;
						IL_424:
						goto IL_C8;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_446;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_433:
							switch (num4)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)1602682882;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4A0;
							case 1:
								goto IL_49E;
							case 2:
								disposable.Dispose();
								num = (short)188219393;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_446;
						}
						IL_49E:
						IL_4A0:
						break;
						IL_446:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1565458432;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_433;
					}
					break;
					IL_C8:
					return null;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0005B21C File Offset: 0x0005941C
		public static global::System.Windows.FrameworkElement GetElementAt(global::System.Windows.Controls.Panel panel, global::System.Windows.Point screenLocation)
		{
			short num = (short)1699020800;
			short num2 = num;
			num = (short)915275776;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = panel.Children.GetEnumerator();
				goto IL_57;
				global::System.Windows.FrameworkElement result;
				try
				{
					for (;;)
					{
						IL_57:
						num = (short)373751819;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								global::System.Windows.UIElement uielement;
								global::System.Windows.FrameworkElement elementAt = global::DevComponents.WpfRibbon.LayoutHelpers.GetElementAt(uielement as global::System.Windows.Controls.Panel, screenLocation);
								num = (short)2088960019;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_ED;
							case 2:
								num = (short)404553744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::System.Windows.UIElement uielement;
								if (uielement is global::System.Windows.Controls.Panel)
								{
									num = (short)2002714624;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1298333702;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::System.Windows.FrameworkElement elementAt;
								result = elementAt;
								num = (short)1501592481;
								short num4 = num;
								num = (short)499219361;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_57;
								default:
									num = (short)1299120128;
									if (num != 0)
									{
									}
									num = (short)78184460;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::System.Windows.Rect rect;
								global::System.Windows.Point point;
								if (rect.Contains(point))
								{
									num = (short)107282449;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								global::System.Windows.UIElement uielement;
								if (uielement is global::System.Windows.Controls.ItemsControl)
								{
									num = (short)100073480;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								result = (uielement as global::System.Windows.FrameworkElement);
								num = (short)69402634;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::System.Windows.UIElement uielement;
								if (uielement is global::DevComponents.WpfRibbon.ButtonDropDown)
								{
									num = (short)829423629;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1948254211;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								global::System.Windows.UIElement uielement;
								global::System.Windows.FrameworkElement elementAt2 = global::DevComponents.WpfRibbon.LayoutHelpers.GetElementAt(uielement as global::System.Windows.Controls.ItemsControl, screenLocation);
								num = (short)1144127502;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_248;
							case 10:
								goto IL_26F;
							case 11:
								switch (0)
								{
								case 0:
									goto IL_CF;
								}
								continue;
							case 12:
								goto IL_221;
							case 13:
							{
								global::System.Windows.UIElement uielement;
								result = (uielement as global::System.Windows.FrameworkElement);
								num = (short)684523529;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
							{
								global::System.Windows.FrameworkElement elementAt2;
								if (elementAt2 != null)
								{
									num = (short)1467940879;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 15:
							{
								global::System.Windows.FrameworkElement elementAt2;
								result = elementAt2;
								num = (short)1318256641;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
								goto IL_3BA;
							case 17:
								num = (short)700776455;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)606994434;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)enumerator.Current;
								global::System.Windows.Point point = uielement.PointFromScreen(screenLocation);
								global::System.Windows.Rect rect = new global::System.Windows.Rect(uielement.RenderSize);
								num = (short)2021916677;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 19:
							{
								global::System.Windows.FrameworkElement elementAt;
								if (elementAt != null)
								{
									num = (short)913637380;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_17A:
							num = (short)239730706;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_CF:
							goto IL_17A;
						}
					}
					IL_ED:
					IL_221:
					IL_248:
					IL_26F:
					goto IL_434;
					IL_3BA:
					goto IL_55;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_3DC;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_3C9:
						switch (num3)
						{
						case 0:
							disposable.Dispose();
							num = (short)1864171522;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (disposable != null)
							{
								num = (short)1407647744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_433;
						case 2:
							goto IL_431;
						}
						goto IL_3DC;
					}
					IL_431:
					IL_433:
					goto EndFinally_11;
					IL_3DC:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1602355201;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_3C9;
					EndFinally_11:;
				}
				goto IL_434;
				IL_55:
				return null;
				IL_434:
				num = (short)1479475201;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x02000059 RID: 89
		public struct RadiusDescription
		{
			// Token: 0x06000426 RID: 1062 RVA: 0x0005B6B8 File Offset: 0x000598B8
			public RadiusDescription(global::System.Windows.CornerRadius rad, global::System.Windows.Thickness border, bool isOutterBorder)
			{
				double num = border.Left * 0.5;
				double num2 = border.Right * 0.5;
				double num3 = border.Top * 0.5;
				double num4 = border.Bottom * 0.5;
				this.TopLeft = new global::System.Windows.Point(0.0, 0.0);
				this.TopRight = new global::System.Windows.Point(0.0, 0.0);
				this.BottomLeft = new global::System.Windows.Point(0.0, 0.0);
				this.BottomRight = new global::System.Windows.Point(0.0, 0.0);
				if (isOutterBorder)
				{
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rad.TopLeft))
					{
						this.TopLeft = new global::System.Windows.Point(rad.TopLeft + num3, rad.TopLeft + num);
					}
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rad.TopRight))
					{
						this.TopRight = new global::System.Windows.Point(rad.TopRight + num3, rad.TopRight + num2);
					}
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rad.BottomLeft))
					{
						this.BottomLeft = new global::System.Windows.Point(rad.BottomLeft + num4, rad.BottomLeft + num);
					}
					if (!global::DevComponents.WpfRibbon.LayoutHelpers.IsZero(rad.BottomRight))
					{
						this.BottomRight = new global::System.Windows.Point(rad.BottomRight + num4, rad.BottomRight + num2);
						return;
					}
				}
				else
				{
					this.TopLeft = new global::System.Windows.Point(global::System.Math.Max(0.0, rad.TopLeft - num3), global::System.Math.Max(0.0, rad.TopLeft - num));
					this.TopRight = new global::System.Windows.Point(global::System.Math.Max(0.0, rad.TopRight - num3), global::System.Math.Max(0.0, rad.TopRight - num2));
					this.BottomLeft = new global::System.Windows.Point(global::System.Math.Max(0.0, rad.BottomLeft - num4), global::System.Math.Max(0.0, rad.BottomLeft - num));
					this.BottomRight = new global::System.Windows.Point(global::System.Math.Max(0.0, rad.BottomRight - num4), global::System.Math.Max(0.0, rad.BottomRight - num2));
				}
			}

			// Token: 0x040001E9 RID: 489
			public global::System.Windows.Point TopLeft;

			// Token: 0x040001EA RID: 490
			public global::System.Windows.Point TopRight;

			// Token: 0x040001EB RID: 491
			public global::System.Windows.Point BottomLeft;

			// Token: 0x040001EC RID: 492
			public global::System.Windows.Point BottomRight;
		}
	}
}
