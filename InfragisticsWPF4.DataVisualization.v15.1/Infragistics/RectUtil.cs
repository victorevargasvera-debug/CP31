using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics
{
	// Token: 0x020000B1 RID: 177
	public static class RectUtil
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x00023FD0 File Offset: 0x000221D0
		public static global::System.Windows.Point GetCenter(this global::System.Windows.Rect rect)
		{
			if (rect.IsEmpty)
			{
				return new global::System.Windows.Point(double.NaN, double.NaN);
			}
			return new global::System.Windows.Point(0.5 * (rect.Left + rect.Right), 0.5 * (rect.Bottom + rect.Top));
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00024035 File Offset: 0x00022235
		public static double GetArea(this global::System.Windows.Rect rect)
		{
			if (rect.IsEmpty)
			{
				return 0.0;
			}
			return rect.Width * rect.Height;
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00024059 File Offset: 0x00022259
		public static global::System.Windows.Rect Duplicate(this global::System.Windows.Rect rect)
		{
			if (rect.IsEmpty)
			{
				return rect;
			}
			return new global::System.Windows.Rect(rect.Left, rect.Top, rect.Width, rect.Height);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00024088 File Offset: 0x00022288
		public static global::System.Windows.Point GetLeader(this global::System.Windows.Rect rect, global::System.Windows.Point anchor)
		{
			if (rect.Contains(anchor))
			{
				return anchor;
			}
			global::System.Windows.Point point = new global::System.Windows.Point(rect.Left + 0.5 * rect.Width, rect.Top + 0.5 * rect.Height);
			global::System.Windows.Point point2 = new global::System.Windows.Point(anchor.X - point.X, anchor.Y - point.Y);
			double num;
			if (point2.X != 0.0)
			{
				num = (rect.Left - point.X) / point2.X;
				double num2 = point.Y + num * point2.Y;
				if (num2 > rect.Top && num2 < rect.Bottom)
				{
					if (num <= 0.0)
					{
						return new global::System.Windows.Point(rect.Right, point.Y - num * point2.Y);
					}
					return new global::System.Windows.Point(rect.Left, num2);
				}
			}
			num = (rect.Top - point.Y) / point2.Y;
			double x = point.X + num * point2.X;
			if (num <= 0.0)
			{
				return new global::System.Windows.Point(point.X - num * point2.X, rect.Bottom);
			}
			return new global::System.Windows.Point(x, rect.Top);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x000241EA File Offset: 0x000223EA
		public static double GetDistanceSquared(this global::System.Windows.Rect rect, global::System.Windows.Point pt)
		{
			if (rect.IsEmpty)
			{
				return double.NaN;
			}
			return rect.GetDistanceSquared(pt.X, pt.Y);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00024214 File Offset: 0x00022414
		public static double GetDistanceSquared(this global::System.Windows.Rect rect, global::System.Windows.Rect rc)
		{
			if (rect.IsEmpty)
			{
				return double.PositiveInfinity;
			}
			double num = rect.GetDistanceSquared(rc.Left, rc.Top);
			if (num > 0.0)
			{
				num = global::System.Math.Min(num, rect.GetDistanceSquared(rc.Left, rc.Bottom));
			}
			if (num > 0.0)
			{
				num = global::System.Math.Min(num, rect.GetDistanceSquared(rc.Right, rc.Bottom));
			}
			if (num > 0.0)
			{
				num = global::System.Math.Min(num, rect.GetDistanceSquared(rc.Right, rc.Top));
			}
			if (num > 0.0)
			{
				num = global::System.Math.Min(num, rc.GetDistanceSquared(rect.Left, rect.Top));
			}
			if (num > 0.0)
			{
				num = global::System.Math.Min(num, rc.GetDistanceSquared(rect.Left, rect.Bottom));
			}
			if (num > 0.0)
			{
				num = global::System.Math.Min(num, rc.GetDistanceSquared(rect.Right, rect.Bottom));
			}
			if (num > 0.0)
			{
				num = global::System.Math.Min(num, rc.GetDistanceSquared(rect.Right, rect.Top));
			}
			return num;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x0002435C File Offset: 0x0002255C
		private static double GetDistanceSquared(this global::System.Windows.Rect rc, double X, double Y)
		{
			double num = X - rc.Left;
			double num2 = Y - rc.Top;
			double num3 = rc.Width * num;
			double num4 = rc.Height * num2;
			if (num3 > 0.0)
			{
				double num5 = rc.Width * rc.Width;
				if (num3 < num5)
				{
					num -= num3 / num5 * rc.Width;
				}
				else
				{
					num -= rc.Width;
				}
			}
			if (num4 > 0.0)
			{
				double num6 = rc.Height * rc.Height;
				if (num4 < num6)
				{
					num2 -= num4 / num6 * rc.Height;
				}
				else
				{
					num2 -= rc.Height;
				}
			}
			return num * num + num2 * num2;
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00024414 File Offset: 0x00022614
		public static bool Contains(this global::System.Windows.Rect rect, global::System.Windows.Rect rc)
		{
			return !rect.IsEmpty && !rc.IsEmpty && rect.Left <= rc.Left && rect.Right >= rc.Right && rect.Top <= rc.Top && rect.Bottom >= rc.Bottom;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00024480 File Offset: 0x00022680
		public static bool IntersectsWith(this global::System.Windows.Rect rect, global::System.Windows.Rect rc)
		{
			return !rect.IsEmpty && !rc.IsEmpty && rect.Right >= rc.Left && rect.Left <= rc.Right && rect.Top <= rc.Bottom && rect.Bottom >= rc.Top;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000244EC File Offset: 0x000226EC
		public static double IntersectionArea(this global::System.Windows.Rect rect, global::System.Windows.Rect rc)
		{
			if (rect.IsEmpty || rc.IsEmpty)
			{
				return 0.0;
			}
			double num = global::System.Math.Min(rect.Right, rc.Right) - global::System.Math.Max(rect.Left, rc.Left);
			if (num <= 0.0)
			{
				return 0.0;
			}
			double num2 = global::System.Math.Min(rect.Bottom, rc.Bottom) - global::System.Math.Max(rect.Top, rc.Top);
			if (num2 <= 0.0)
			{
				return 0.0;
			}
			return num * num2;
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00024594 File Offset: 0x00022794
		public static global::System.Windows.Rect GetInflated(this global::System.Windows.Rect rect, double width, double height)
		{
			if (rect.IsEmpty)
			{
				return rect;
			}
			return new global::System.Windows.Rect(rect.X - width, rect.Y - height, global::System.Math.Max(0.0, rect.Width + 2.0 * width), global::System.Math.Max(0.0, rect.Height + 2.0 * height));
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00024608 File Offset: 0x00022808
		public static global::System.Windows.Rect InflateBy(global::System.Windows.Rect rect, double dx, double dy)
		{
			rect.X -= dx;
			rect.Y -= dy;
			double num = rect.Width + 2.0 * dx;
			double num2 = rect.Height + 2.0 * dy;
			rect.Width = ((num > 1.0) ? num : 1.0);
			rect.Height = ((num2 > 1.0) ? num2 : 1.0);
			return rect;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x0002469C File Offset: 0x0002289C
		public static global::System.Windows.Rect Inflate(this global::System.Windows.Rect rect, double dx, double dy)
		{
			rect.X -= dx;
			rect.Y -= dy;
			double num = rect.Width + 2.0 * dx;
			double num2 = rect.Height + 2.0 * dy;
			rect.Width = ((num > 1.0) ? num : 1.0);
			rect.Height = ((num2 > 1.0) ? num2 : 1.0);
			return rect;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00024730 File Offset: 0x00022930
		public static global::System.Windows.Rect Inflate(this global::System.Windows.Rect rect, double thickness)
		{
			double x = rect.X - thickness;
			double y = rect.Y - thickness;
			double num = rect.Width + thickness + thickness;
			double num2 = rect.Height + thickness + thickness;
			double width = (num > 0.0) ? num : 0.0;
			double height = (num2 > 0.0) ? num2 : 0.0;
			return new global::System.Windows.Rect(x, y, width, height);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x000247A8 File Offset: 0x000229A8
		public static global::System.Windows.Rect Inflate(this global::System.Windows.Rect rect, global::System.Windows.Thickness thickness)
		{
			rect.X -= thickness.Left;
			rect.Y -= thickness.Top;
			double num = rect.Width + thickness.Left + thickness.Right;
			double num2 = rect.Height + thickness.Top + thickness.Bottom;
			rect.Width = ((num > 0.0) ? num : 0.0);
			rect.Height = ((num2 > 0.0) ? num2 : 0.0);
			return rect;
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x00024850 File Offset: 0x00022A50
		public static global::System.Windows.Rect InflateBy(global::System.Windows.Rect rect, global::System.Windows.Thickness thickness)
		{
			rect.X -= thickness.Left;
			rect.Y -= thickness.Top;
			double num = rect.Width + thickness.Left + thickness.Right;
			double num2 = rect.Height + thickness.Top + thickness.Bottom;
			rect.Width = ((num > 0.0) ? num : 0.0);
			rect.Height = ((num2 > 0.0) ? num2 : 0.0);
			return rect;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x000248F8 File Offset: 0x00022AF8
		public static global::System.Windows.Rect Deflate(this global::System.Windows.Rect rect, global::System.Windows.Thickness thickness)
		{
			rect.X += thickness.Left;
			rect.Y += thickness.Top;
			double num = rect.Width - thickness.Left - thickness.Right;
			double num2 = rect.Height - thickness.Top - thickness.Bottom;
			rect.Width = ((num > 0.0) ? num : 0.0);
			rect.Height = ((num2 > 0.0) ? num2 : 0.0);
			return rect;
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x000249A0 File Offset: 0x00022BA0
		public static global::System.Windows.Rect Round(this global::System.Windows.Rect rect)
		{
			rect.X = global::System.Math.Round(rect.X);
			rect.Y = global::System.Math.Round(rect.Y);
			rect.Width = global::System.Math.Round(rect.Width);
			rect.Height = global::System.Math.Round(rect.Height);
			return rect;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x000249FC File Offset: 0x00022BFC
		public static bool IsNull(this global::System.Windows.Rect rect)
		{
			return rect.X == 0.0 && rect.Y == 0.0 && rect.Width == 0.0 && rect.Height == 0.0;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00024A54 File Offset: 0x00022C54
		public static global::System.Windows.Size Size(this global::System.Windows.Rect rect)
		{
			global::System.Windows.Size result = new global::System.Windows.Size(rect.Width, rect.Height);
			return result;
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00024A78 File Offset: 0x00022C78
		public static global::System.Windows.Rect Normalize(this global::System.Windows.Rect current, global::System.Windows.Rect rect)
		{
			return current.Normalize(rect.Size());
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00024A94 File Offset: 0x00022C94
		public static global::System.Windows.Rect Normalize(this global::System.Windows.Rect current, global::System.Windows.Size size)
		{
			global::System.Windows.Rect result = current;
			result.X = current.X / size.Width;
			result.Y = current.Y / size.Height;
			result.Width = current.Width / size.Width;
			result.Height = current.Height / size.Height;
			return result;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00024AFC File Offset: 0x00022CFC
		public static global::System.Windows.Point GetTopLeft(this global::System.Windows.Rect rect)
		{
			global::System.Windows.Point result = new global::System.Windows.Point(rect.X, rect.Y);
			return result;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00024B20 File Offset: 0x00022D20
		public static global::System.Windows.Point GetTopRight(this global::System.Windows.Rect rect)
		{
			global::System.Windows.Point result = new global::System.Windows.Point(rect.X + rect.Width, rect.Y);
			return result;
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00024B4C File Offset: 0x00022D4C
		public static global::System.Windows.Point GetBottomLeft(this global::System.Windows.Rect rect)
		{
			global::System.Windows.Point result = new global::System.Windows.Point(rect.X, rect.Y + rect.Height);
			return result;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00024B78 File Offset: 0x00022D78
		public static global::System.Windows.Point GetBottomRight(this global::System.Windows.Rect rect)
		{
			global::System.Windows.Point result = new global::System.Windows.Point(rect.X + rect.Width, rect.Y + rect.Height);
			return result;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00024BAC File Offset: 0x00022DAC
		public static global::System.Collections.Generic.List<global::System.Windows.Point> GetCorners(this global::System.Windows.Rect rect)
		{
			return new global::System.Collections.Generic.List<global::System.Windows.Point>
			{
				rect.GetTopLeft(),
				rect.GetTopRight(),
				rect.GetBottomRight(),
				rect.GetBottomLeft()
			};
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00024BF4 File Offset: 0x00022DF4
		public static global::System.Windows.Rect RotateAboutCenter(this global::System.Windows.Rect rect, double angle)
		{
			angle = global::Infragistics.GeometryUtil.SimplifyAngle(angle);
			if (angle == 0.0 || angle == 180.0)
			{
				return new global::System.Windows.Rect(rect.Left, rect.Top, rect.Width, rect.Height);
			}
			global::System.Windows.Point center = rect.GetCenter();
			if (angle == 90.0 || angle == 270.0)
			{
				double num = rect.Height / 2.0;
				double num2 = rect.Width / 2.0;
				return new global::System.Windows.Rect(center.X - num, center.Y - num2, rect.Height, rect.Width);
			}
			return rect.RotateAboutPoint(center.X, center.Y, angle);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00024CC4 File Offset: 0x00022EC4
		public static global::System.Windows.Rect RotateAboutPoint(this global::System.Windows.Rect rect, double x, double y, double angle)
		{
			global::System.Collections.Generic.List<global::System.Windows.Point> corners = rect.GetCorners();
			double num = global::Infragistics.MathUtil.Radians(angle);
			double num2 = global::System.Math.Cos(num);
			double num3 = global::System.Math.Sin(num);
			double num4 = double.MaxValue;
			double num5 = double.MaxValue;
			double num6 = double.MinValue;
			double num7 = double.MinValue;
			for (int i = 0; i < corners.Count; i++)
			{
				global::System.Windows.Point point = corners[i];
				double val = num2 * (point.X - x) - num3 * (point.Y - y) + x;
				double val2 = num3 * (point.X - x) + num2 * (point.Y - y) + y;
				num4 = global::System.Math.Min(num4, val2);
				num5 = global::System.Math.Min(num5, val);
				num6 = global::System.Math.Max(num6, val);
				num7 = global::System.Math.Max(num7, val2);
			}
			global::System.Windows.Rect result = new global::System.Windows.Rect(num5, num4, num6 - num5, num7 - num4);
			return result;
		}
	}
}
