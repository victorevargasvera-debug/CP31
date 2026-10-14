using System;
using System.Windows;
using System.Windows.Media;

namespace DevComponents.WpfDock
{
	// Token: 0x0200003A RID: 58
	internal class i
	{
		// Token: 0x0600028C RID: 652 RVA: 0x00042430 File Offset: 0x00040630
		public static global::System.Windows.Size b(global::System.Windows.Size A_0, global::System.Windows.Size A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)109182977;
				if (num != 0)
				{
				}
				num = (short)79626240;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (A_1.Height > A_0.Height)
					{
						num = (short)420610050;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EE;
				case 1:
					goto IL_EE;
				case 2:
					A_0.Height = A_1.Height;
					num = (short)1501888513;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_70;
				IL_EE:
				num = (short)45818767;
				short num4 = num;
				num = (short)548021135;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_123;
				}
			}
			IL_123:
			num = (short)1678573568;
			if (num != 0)
			{
			}
			return A_0;
			IL_70:
			A_0.Width += A_1.Width;
			num = (short)1424883712;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00042578 File Offset: 0x00040778
		public static global::System.Windows.Size a(global::System.Windows.Size A_0, global::System.Windows.Size A_1)
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
					if (A_1.Width > A_0.Width)
					{
						num2 = (short)1326776322;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EA;
				case 1:
					goto IL_EA;
				case 2:
					A_0.Width = A_1.Width;
					num2 = (short)2116354049;
					if (num2 != 0)
					{
					}
					num2 = (short)1769734145;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
				IL_EA:
				num2 = (short)632827100;
				short num3 = num2;
				num2 = (short)1466379484;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_120;
				}
			}
			IL_120:
			num2 = (short)92798976;
			if (num2 != 0)
			{
			}
			return A_0;
			IL_1C:
			num2 = (short)61800448;
			short num4 = num2;
			A_0.Height += A_1.Height;
			num2 = (short)1120927744;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000426BC File Offset: 0x000408BC
		public static bool a(double A_0)
		{
			short num = (short)1938995674;
			short num2 = num;
			num = (short)911325658;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1802698752;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1070727169;
			if (num != 0)
			{
			}
			num = (short)718929920;
			if (num != 0)
			{
			}
			return global::System.Math.Abs(A_0) < 2.220446049250313E-15;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00042778 File Offset: 0x00040978
		public static bool b(double A_0, double A_1)
		{
			short num = (short)1000618398;
			short num2 = num;
			num = (short)1616591262;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1782710272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)749535233;
			if (num != 0)
			{
			}
			num = (short)911540224;
			if (num != 0)
			{
			}
			return global::System.Math.Abs(A_0 - A_1) < 1.0;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00042834 File Offset: 0x00040A34
		public static bool a(double A_0, double A_1)
		{
			short num = (short)448987137;
			if (num != 0)
			{
			}
			num = (short)632517908;
			short num2 = num;
			num = (short)1637381396;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			case 1:
				break;
			default:
			{
				num = (short)1678180352;
				short num3 = num;
				break;
			}
			}
			num = (short)1735786496;
			if (num != 0)
			{
			}
			if (A_0 > A_1)
			{
				return !global::DevComponents.WpfDock.i.b(A_0, A_1);
			}
			return false;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000428F0 File Offset: 0x00040AF0
		public static bool b(global::System.Windows.Size A_0)
		{
			short num = (short)21735304;
			short num2 = num;
			num = (short)549693320;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)563412992;
				short num3 = num;
				num = (short)360054784;
				if (num != 0)
				{
				}
				num = (short)1440808961;
				if (num != 0)
				{
				}
				if (global::DevComponents.WpfDock.i.a(A_0.Width))
				{
					return global::DevComponents.WpfDock.i.a(A_0.Height);
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000429B8 File Offset: 0x00040BB8
		public static global::System.Windows.Rect a(global::System.Windows.Rect A_0, global::System.Windows.Thickness A_1)
		{
			short num = (short)998984938;
			short num2 = num;
			num = (short)1313164522;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1646854144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2100756481;
			if (num != 0)
			{
			}
			num = (short)1642594304;
			if (num != 0)
			{
			}
			return new global::System.Windows.Rect(A_0.Left + A_1.Left, A_0.Top + A_1.Top, global::System.Math.Max(0.0, A_0.Width - A_1.Left - A_1.Right), global::System.Math.Max(0.0, A_0.Height - A_1.Top - A_1.Bottom));
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00042AD0 File Offset: 0x00040CD0
		public static global::System.Windows.Size b(global::System.Windows.Thickness A_0)
		{
			short num = (short)1109906205;
			short num2 = num;
			num = (short)1897517853;
			switch (num2 == num)
			{
			default:
			{
				num = (short)193396736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1208156160;
			if (num != 0)
			{
			}
			num = (short)1537671169;
			if (num != 0)
			{
			}
			return new global::System.Windows.Size(A_0.Left + A_0.Right, A_0.Top + A_0.Bottom);
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00042B9C File Offset: 0x00040D9C
		public static global::System.Windows.CornerRadius a(global::System.Windows.CornerRadius A_0, double A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::System.Windows.CornerRadius result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result.BottomLeft = global::System.Math.Max(0.0, A_0.BottomLeft - A_1);
					num2 = (short)1493237770;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (A_0.TopRight > 0.0)
					{
						num2 = (short)432668674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result.TopRight = global::System.Math.Max(0.0, A_0.TopRight - A_1);
					num2 = (short)1522204678;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					result.TopLeft = global::System.Math.Max(0.0, A_0.TopLeft - A_1);
					num2 = (short)1259753345;
					short num3 = num2;
					num2 = (short)135614337;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B0;
					default:
						num2 = (short)363790336;
						if (num2 != 0)
						{
						}
						num2 = (short)1019478024;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
				{
					num2 = (short)129105920;
					short num4 = num2;
					goto IL_146;
				}
				case 5:
					if (A_0.TopLeft > 0.0)
					{
						num2 = (short)1621295107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24A;
				case 6:
					return result;
				case 7:
					if (A_0.BottomLeft > 0.0)
					{
						num2 = (short)786235392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18F;
				case 8:
					goto IL_24A;
				case 9:
					result.BottomRight = global::System.Math.Max(0.0, A_0.BottomRight - A_1);
					goto IL_2B0;
				case 10:
					goto IL_18F;
				case 11:
					if (A_0.BottomRight > 0.0)
					{
						num2 = (short)558956553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_146;
				}
				goto IL_40;
				IL_146:
				num2 = (short)686686213;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18F:
				num2 = (short)1591672843;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_24A:
				num2 = (short)788463617;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2B0:
				num2 = (short)1801650180;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_40:
			num2 = (short)1698037761;
			if (num2 != 0)
			{
			}
			result = new global::System.Windows.CornerRadius(0.0);
			num2 = (short)1123483655;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00042EA0 File Offset: 0x000410A0
		public static void a(global::System.Windows.Media.StreamGeometryContext A_0, global::System.Windows.Rect A_1, global::DevComponents.WpfDock.i.a A_2)
		{
			short num = (short)1526923264;
			short num2 = num;
			num = (short)1901199360;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B6;
				}
				global::System.Windows.Point point;
				global::System.Windows.Point point2;
				global::System.Windows.Point point3;
				global::System.Windows.Point point4;
				global::System.Windows.Point point5;
				global::System.Windows.Point startPoint;
				global::System.Windows.Point point6;
				global::System.Windows.Point point7;
				for (;;)
				{
					IL_4F:
					global::System.Windows.Size size;
					switch (num3)
					{
					case 0:
						IL_487:
						point.Y = A_1.Y + A_1.Height / 2.0;
						point2.Y = point.Y;
						num = (short)2041118733;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						A_0.ArcTo(point3, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)1276379153;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (point4.X > point5.X)
						{
							num = (short)1582039047;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_442;
					case 3:
						goto IL_337;
					case 4:
						goto IL_589;
					case 5:
						if (!global::DevComponents.WpfDock.i.b(size))
						{
							num = (short)1548812300;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_589;
					case 6:
						if (startPoint.Y > point6.Y)
						{
							num = (short)1885470739;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ED;
					case 7:
						point4.X = A_1.X + A_1.Width / 2.0;
						point5.X = point4.X;
						num = (short)713818120;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_442;
					case 9:
						if (!global::DevComponents.WpfDock.i.b(size))
						{
							num = (short)869531662;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_337;
					case 10:
						point6.X = A_1.X + A_1.Width / 2.0;
						point7.X = point6.X;
						num = (short)1245052951;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (point6.X > point7.X)
						{
							num = (short)754778122;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F3;
					case 12:
						A_0.ArcTo(point, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)735379460;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_6AC;
					case 14:
						A_0.ArcTo(point4, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)941162499;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!global::DevComponents.WpfDock.i.b(size))
						{
							num = (short)1527644182;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					case 16:
						if (point.Y > point2.Y)
						{
							num = (short)99614720;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AC;
					case 17:
						return;
					case 18:
						goto IL_2ED;
					case 19:
						startPoint.Y = A_1.Y + A_1.Height / 2.0;
						point3.Y = startPoint.Y;
						num = (short)1873346578;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_48C;
					case 21:
						if (!global::DevComponents.WpfDock.i.b(size))
						{
							num = (short)1530200065;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
						A_0.ArcTo(point7, size, 0.0, false, global::System.Windows.Media.SweepDirection.Clockwise, true, false);
						num = (short)1581056020;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_6F3;
					}
					goto IL_B6;
					IL_2ED:
					num = (short)1653080066;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_337:
					A_0.LineTo(point5, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, A_1.Right - point5.X), global::System.Math.Max(0.0, point.Y - A_1.Y));
					num = (short)1125711877;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_442:
					num = (short)1393033232;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_48C:
					num = (short)104647332;
					short num4 = num;
					num = (short)572246692;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_487;
					default:
						num = (short)1950613505;
						if (num != 0)
						{
						}
						num = (short)93978624;
						if (num != 0)
						{
						}
						A_0.LineTo(point6, true, false);
						size = new global::System.Windows.Size(global::System.Math.Max(0.0, point6.X - A_1.X), global::System.Math.Max(0.0, A_1.Bottom - point3.Y));
						num = (short)1894973461;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_589:
					A_0.LineTo(point2, true, false);
					size = new global::System.Windows.Size(global::System.Math.Max(0.0, A_1.Right - point7.X), global::System.Math.Max(0.0, A_1.Bottom - point2.Y));
					num = (short)954662927;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6AC:
					num = (short)181927947;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F3:
					A_0.BeginFigure(startPoint, true, true);
					size = new global::System.Windows.Size(global::System.Math.Max(point4.X - A_1.X, 0.0), global::System.Math.Max(0.0, startPoint.Y - A_1.Y));
					num = (short)630390793;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_B6:
				startPoint = new global::System.Windows.Point(A_1.X, A_1.Y + A_2.a.Y);
				point4 = new global::System.Windows.Point(A_1.X + A_2.a.X, A_1.Y);
				point5 = new global::System.Windows.Point(A_1.Right - A_2.b.X, A_1.Y);
				point = new global::System.Windows.Point(A_1.Right, A_1.Y + A_2.b.Y);
				point2 = new global::System.Windows.Point(A_1.Right, A_1.Bottom - A_2.d.Y);
				point7 = new global::System.Windows.Point(A_1.Right - A_2.d.X, A_1.Bottom);
				point6 = new global::System.Windows.Point(A_2.c.X, A_1.Bottom);
				point3 = new global::System.Windows.Point(A_1.X, A_1.Bottom - A_2.c.Y);
				num = (short)299040774;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0004362C File Offset: 0x0004182C
		public static bool a(object A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1496973312;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				int num3;
				global::System.Windows.Thickness thickness;
				for (;;)
				{
					IL_34:
					switch (num3)
					{
					case 0:
						if (!double.IsNegativeInfinity(thickness.Left))
						{
							num = (short)474546202;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						num = (short)305922069;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!double.IsPositiveInfinity(thickness.Left))
						{
							num = (short)1591738391;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						if (thickness.Left >= 0.0)
						{
							num = (short)1228210193;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						if (thickness.Right >= 0.0)
						{
							num = (short)1735393307;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						return false;
					case 6:
						if (!double.IsNegativeInfinity(thickness.Bottom))
						{
							num = (short)746389532;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						num = (short)855244830;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (double.IsNaN(thickness.Bottom))
						{
							num = (short)1183383557;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)464650242;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1169686534;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)2011103254;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_2CF;
					case 12:
						num = (short)1423376413;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!double.IsNaN(thickness.Right))
						{
							num = (short)1858863105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
						if (!double.IsNegativeInfinity(thickness.Right))
						{
							num = (short)1543569424;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						if (!double.IsPositiveInfinity(thickness.Right))
						{
							num = (short)1892155404;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 16:
						num = (short)1840185368;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)358154244;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)592314369;
						if (num != 0)
						{
						}
						num = (short)1756430349;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1051131912;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1339424799;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!double.IsNaN(thickness.Top))
						{
							num = (short)1827078163;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						if (thickness.Bottom >= 0.0)
						{
							num = (short)1933574151;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
						num = (short)2006056975;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (!double.IsNegativeInfinity(thickness.Top))
						{
							num = (short)551485449;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 25:
						if (thickness.Top >= 0.0)
						{
							num = (short)1968766986;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 26:
						num = (short)976814094;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1372586009;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						return true;
					case 29:
						if (!double.IsPositiveInfinity(thickness.Top))
						{
							num = (short)601096212;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 30:
					{
						num = (short)1690482079;
						short num4 = num;
						num = (short)654292383;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1902772224;
							if (num != 0)
							{
							}
							if (!double.IsNaN(thickness.Left))
							{
								num = (short)1357643794;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 31:
						if (double.IsPositiveInfinity(thickness.Bottom))
						{
							num = (short)1751580683;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)811073536;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_BA:
				thickness = (global::System.Windows.Thickness)A_0;
				num = (short)1893335043;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_34;
			}
			return false;
			IL_2CF:
			return false;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00043BC8 File Offset: 0x00041DC8
		public static bool a(global::System.Windows.Thickness A_0)
		{
			short num = (short)485621760;
			short num2 = num;
			num = (short)1363597346;
			short num3 = num;
			num = (short)246601762;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E3:
				num = (short)1339817989;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)798556160;
				if (num != 0)
				{
				}
				num = (short)686555140;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					if (global::DevComponents.WpfDock.i.a(A_0.Right))
					{
						num = (short)680067081;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					if (global::DevComponents.WpfDock.i.a(A_0.Left))
					{
						num = (short)1048051715;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)1857552385;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)953155584;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_BF;
					}
					continue;
				case 5:
					if (global::DevComponents.WpfDock.i.a(A_0.Bottom))
					{
						num = (short)1034027010;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					return true;
				case 7:
					if (global::DevComponents.WpfDock.i.a(A_0.Top))
					{
						num = (short)1210253318;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 8:
					goto IL_E3;
				case 9:
					num = (short)1046740993;
					if (num != 0)
					{
					}
					num = (short)766705671;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BF:
				if (!global::DevComponents.WpfDock.i.a(A_0))
				{
					return true;
				}
				num = (short)1291255816;
				num4 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00043DF0 File Offset: 0x00041FF0
		public static bool a(global::System.Windows.Rect A_0)
		{
			short num = (short)519110658;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_136;
				case 1:
				{
					num = (short)1163334590;
					short num3 = num;
					num = (short)918164414;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)661651457;
						if (num != 0)
						{
						}
						num = (short)1709506560;
						if (num != 0)
						{
						}
						if (!global::DevComponents.WpfDock.i.a(A_0.Height))
						{
							num = (short)1497038848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
				{
					num = (short)1514536960;
					short num4 = num;
					num = (short)1364328449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_34:
				if (!global::DevComponents.WpfDock.i.a(A_0.Width))
				{
					break;
				}
				num = (short)1156907011;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_58:
			return A_0.IsEmpty;
			IL_136:
			goto IL_58;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00043F3C File Offset: 0x0004213C
		public static bool a(global::System.Windows.Size A_0)
		{
			short num = (short)2007957506;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_140;
				case 1:
				{
					num = (short)604098051;
					short num3 = num;
					num = (short)1347341827;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)216334336;
						if (num != 0)
						{
						}
						if (!global::DevComponents.WpfDock.i.a(A_0.Height))
						{
							num = (short)668139520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				case 3:
					num = (short)1130889217;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_36:
				num = (short)1004994561;
				if (num != 0)
				{
				}
				if (!global::DevComponents.WpfDock.i.a(A_0.Width))
				{
					break;
				}
				num = (short)793575427;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_82:
			num = (short)1662320640;
			short num4 = num;
			return A_0.IsEmpty;
			IL_140:
			goto IL_82;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00044090 File Offset: 0x00042290
		public static bool a(global::System.Windows.Point A_0)
		{
			if (!global::DevComponents.WpfDock.i.a(A_0.X))
			{
				short num = (short)1517748225;
				if (num != 0)
				{
				}
				num = (short)43290250;
				short num2 = num;
				num = (short)1302564490;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1939996672;
					short num3 = num;
					num = (short)864813056;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return global::DevComponents.WpfDock.i.a(A_0.Y);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00044154 File Offset: 0x00042354
		public static global::System.Windows.Point b(global::System.Windows.Media.Visual A_0)
		{
			global::System.Windows.Point result = new global::System.Windows.Point(120.0, 120.0);
			global::System.Windows.PresentationSource presentationSource = global::System.Windows.PresentationSource.FromVisual(A_0);
			if (presentationSource != null)
			{
				short num = (short)1158757913;
				short num2 = num;
				num = (short)1174683161;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1662713857;
					if (num != 0)
					{
					}
					num = (short)689242112;
					short num3 = num;
					num = (short)1259274240;
					if (num != 0)
					{
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
			return result;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x000442A4 File Offset: 0x000424A4
		public static global::System.Windows.Rect a(global::System.Windows.UIElement A_0, global::System.Windows.UIElement A_1)
		{
			short num = (short)1294635159;
			short num2 = num;
			num = (short)344887447;
			switch (num2 == num)
			{
			}
			num = (short)1037959168;
			if (num != 0)
			{
			}
			num = (short)693043201;
			if (num != 0)
			{
			}
			num = (short)1885798400;
			short num3 = num;
			global::System.Windows.Point point = A_0.PointToScreen(new global::System.Windows.Point(0.0, 0.0));
			point = A_1.PointFromScreen(point);
			return new global::System.Windows.Rect(point, new global::System.Windows.Size(global::System.Math.Ceiling(A_0.RenderSize.Width), global::System.Math.Ceiling(A_0.RenderSize.Height)));
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000443A4 File Offset: 0x000425A4
		internal static void a(ref global::System.Windows.Size A_0)
		{
			short num = (short)496238596;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (double.IsPositiveInfinity(A_0.Height))
					{
						num = (short)714342403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)250019841;
					if (num != 0)
					{
					}
					num = (short)1378316177;
					short num3 = num;
					num = (short)1024356241;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4E;
					default:
						goto IL_E6;
					}
					break;
				}
				case 2:
					goto IL_126;
				case 3:
					A_0.Height = 0.0;
					num = (short)1312227329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 5:
					A_0.Width = 0.0;
					num = (short)1615855618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3E;
				IL_4E:
				num = (short)712507397;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E:
				if (double.IsPositiveInfinity(A_0.Width))
				{
					goto IL_4E;
				}
				IL_126:
				num = (short)736755712;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			num = (short)1855586304;
			short num4 = num;
			num = (short)1452736512;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00044544 File Offset: 0x00042744
		public static bool a(global::System.Windows.UIElement A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)979435521;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_F8;
				case 1:
					return result;
				case 2:
				{
					global::System.Windows.Point point;
					if (global::System.Windows.Media.VisualTreeHelper.HitTest(A_0, point) != null)
					{
						num = (short)372244480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				}
				goto IL_43;
			}
			return result;
			IL_43:
			num = (short)1340080128;
			short num3 = num;
			num = (short)354118378;
			short num4 = num;
			num = (short)1909943018;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F8:
				result = true;
				num = (short)3997697;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)1015873536;
				if (num != 0)
				{
				}
				result = false;
				global::System.Windows.Point point = global::DevComponents.WpfDock.i.a(A_0);
				num = (short)1300103170;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00044668 File Offset: 0x00042868
		private static global::System.Windows.Point a(global::System.Windows.Media.Visual A_0)
		{
			short num = (short)1358086529;
			short num2 = num;
			num = (short)63357313;
			switch (num2 == num)
			{
			}
			num = (short)2111504384;
			if (num != 0)
			{
			}
			num = (short)1846476801;
			if (num != 0)
			{
			}
			num = (short)2005729280;
			short num3 = num;
			global::DevComponents.WpfDock.j.g g = default(global::DevComponents.WpfDock.j.g);
			global::DevComponents.WpfDock.j.GetCursorPos(ref g);
			return A_0.PointFromScreen(new global::System.Windows.Point((double)g.a, (double)g.b));
		}

		// Token: 0x0200003B RID: 59
		public struct a
		{
			// Token: 0x060002A1 RID: 673 RVA: 0x00044750 File Offset: 0x00042950
			public a(global::System.Windows.CornerRadius A_0, global::System.Windows.Thickness A_1, bool A_2)
			{
				double num = A_1.Left * 0.5;
				double num2 = A_1.Right * 0.5;
				double num3 = A_1.Top * 0.5;
				double num4 = A_1.Bottom * 0.5;
				this.a = new global::System.Windows.Point(0.0, 0.0);
				this.b = new global::System.Windows.Point(0.0, 0.0);
				this.c = new global::System.Windows.Point(0.0, 0.0);
				this.d = new global::System.Windows.Point(0.0, 0.0);
				if (A_2)
				{
					if (!global::DevComponents.WpfDock.i.a(A_0.TopLeft))
					{
						this.a = new global::System.Windows.Point(A_0.TopLeft + num3, A_0.TopLeft + num);
					}
					if (!global::DevComponents.WpfDock.i.a(A_0.TopRight))
					{
						this.b = new global::System.Windows.Point(A_0.TopRight + num3, A_0.TopRight + num2);
					}
					if (!global::DevComponents.WpfDock.i.a(A_0.BottomLeft))
					{
						this.c = new global::System.Windows.Point(A_0.BottomLeft + num4, A_0.BottomLeft + num);
					}
					if (!global::DevComponents.WpfDock.i.a(A_0.BottomRight))
					{
						this.d = new global::System.Windows.Point(A_0.BottomRight + num4, A_0.BottomRight + num2);
						return;
					}
				}
				else
				{
					this.a = new global::System.Windows.Point(global::System.Math.Max(0.0, A_0.TopLeft - num3), global::System.Math.Max(0.0, A_0.TopLeft - num));
					this.b = new global::System.Windows.Point(global::System.Math.Max(0.0, A_0.TopRight - num3), global::System.Math.Max(0.0, A_0.TopRight - num2));
					this.c = new global::System.Windows.Point(global::System.Math.Max(0.0, A_0.BottomLeft - num4), global::System.Math.Max(0.0, A_0.BottomLeft - num));
					this.d = new global::System.Windows.Point(global::System.Math.Max(0.0, A_0.BottomRight - num4), global::System.Math.Max(0.0, A_0.BottomRight - num2));
				}
			}

			// Token: 0x0400019A RID: 410
			public global::System.Windows.Point a;

			// Token: 0x0400019B RID: 411
			public global::System.Windows.Point b;

			// Token: 0x0400019C RID: 412
			public global::System.Windows.Point c;

			// Token: 0x0400019D RID: 413
			public global::System.Windows.Point d;
		}
	}
}
