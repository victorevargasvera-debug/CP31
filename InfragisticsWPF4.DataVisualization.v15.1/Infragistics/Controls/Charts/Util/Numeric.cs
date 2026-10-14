using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Infragistics.Controls.Charts.Util
{
	// Token: 0x0200009F RID: 159
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class Numeric
	{
		// Token: 0x060006FB RID: 1787 RVA: 0x0001FFB3 File Offset: 0x0001E1B3
		protected Numeric()
		{
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		internal static bool Solve(global::System.Collections.Generic.List<double> a, global::System.Collections.Generic.List<double> b, global::System.Collections.Generic.List<double> c, global::System.Collections.Generic.List<double> r, global::System.Collections.Generic.List<double> u)
		{
			int count = a.Count;
			double[] array = new double[count];
			if (b[0] == 0.0)
			{
				return false;
			}
			double num = b[0];
			u[0] = r[0] / num;
			for (int i = 1; i < count; i++)
			{
				array[i] = c[i - 1] / num;
				num = b[i] - a[i] * array[i];
				if (num == 0.0)
				{
					return false;
				}
				u[i] = (r[i] - a[i] * u[i - 1]) / num;
			}
			for (int i = count - 2; i >= 0; i--)
			{
				int index;
				u[index = i] = u[index] - array[i + 1] * u[i + 1];
			}
			return true;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0002009C File Offset: 0x0001E29C
		internal static bool Solve(double[,] a, double[] b)
		{
			int length = a.GetLength(0);
			int[] array = new int[length];
			int[] array2 = new int[length];
			int[] array3 = new int[length];
			for (int i = 0; i < length; i++)
			{
				array3[i] = 0;
			}
			for (int j = 0; j < length; j++)
			{
				double num = 0.0;
				int num2 = 0;
				int num3 = 0;
				for (int k = 0; k < length; k++)
				{
					if (array3[k] != 1)
					{
						for (int l = 0; l < length; l++)
						{
							if (array3[l] == 0 && global::System.Math.Abs(a[k, l]) >= num)
							{
								num = global::System.Math.Abs(a[k, l]);
								num2 = k;
								num3 = l;
							}
						}
					}
				}
				array3[num3]++;
				if (num2 != num3)
				{
					for (int m = 0; m < length; m++)
					{
						double num4 = a[num2, m];
						a[num2, m] = a[num3, m];
						a[num3, m] = num4;
					}
					double num5 = b[num2];
					b[num2] = b[num3];
					b[num3] = num5;
				}
				array2[j] = num2;
				array[j] = num3;
				if (a[num3, num3] == 0.0)
				{
					return false;
				}
				double num6 = 1.0 / a[num3, num3];
				a[num3, num3] = 1.0;
				for (int n = 0; n < length; n++)
				{
					a[num3, n] *= num6;
				}
				b[num3] *= num6;
				for (int num7 = 0; num7 < length; num7++)
				{
					if (num7 != num3)
					{
						double num8 = a[num7, num3];
						a[num7, num3] = 0.0;
						for (int num9 = 0; num9 < length; num9++)
						{
							a[num7, num9] -= a[num3, num9] * num8;
						}
						b[num7] -= b[num3] * num8;
					}
				}
			}
			for (int num10 = length - 1; num10 >= 0; num10--)
			{
				if (array2[num10] != array[num10])
				{
					for (int num11 = 0; num11 < length; num11++)
					{
						double num12 = a[num11, array2[num10]];
						a[num11, array2[num10]] = a[num11, array[num10]];
						a[num11, array[num10]] = num12;
					}
				}
			}
			return true;
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x00020334 File Offset: 0x0001E534
		public static double[] SafeCubicSplineFit(int count, global::System.Func<int, double> x, global::System.Func<int, double> y, double yp1, double ypn)
		{
			global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
			for (int i = 0; i < count; i++)
			{
				while (i < count && (double.IsNaN(x(i)) || double.IsNaN(y(i))))
				{
					list.Add(double.NaN);
					i++;
				}
				int j = i;
				while (i < count && !double.IsNaN(x(i)) && !double.IsNaN(y(i)))
				{
					i++;
				}
				i--;
				if (i - j > 0)
				{
					list.AddRange(global::Infragistics.Controls.Charts.Util.Numeric.CubicSplineFit(j, i - j + 1, x, y, yp1, ypn));
				}
				else
				{
					while (j <= i)
					{
						list.Add(double.NaN);
						j++;
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x00020428 File Offset: 0x0001E628
		public static double[] CubicSplineFit(int start, int count, global::System.Func<int, double> x, global::System.Func<int, double> y, double yp1, double ypn)
		{
			return global::Infragistics.Controls.Charts.Util.Numeric.CubicSplineFit(count, (int i) => x(i + start), (int i) => y(i + start), yp1, ypn);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x00020474 File Offset: 0x0001E674
		public static double[] CubicSplineFit(int count, global::System.Func<int, double> x, global::System.Func<int, double> y, double yp1, double ypn)
		{
			double[] array = new double[count - 1];
			double[] array2 = new double[count];
			array2[0] = (double.IsNaN(yp1) ? 0.0 : -0.5);
			array[0] = (double.IsNaN(yp1) ? 0.0 : (3.0 / (x(1) - x(0)) * ((y(1) - y(0)) / (x(1) - x(0)) - yp1)));
			for (int i = 1; i < count - 1; i++)
			{
				double num = (x(i) - x(i - 1)) / (x(i + 1) - x(i - 1));
				double num2 = num * array2[i - 1] + 2.0;
				array2[i] = (num - 1.0) / num2;
				array[i] = (y(i + 1) - y(i)) / (x(i + 1) - x(i)) - (y(i) - y(i - 1)) / (x(i) - x(i - 1));
				array[i] = (6.0 * array[i] / (x(i + 1) - x(i - 1)) - num * array[i - 1]) / num2;
			}
			double num3 = double.IsNaN(ypn) ? 0.0 : 0.5;
			double num4 = double.IsNaN(ypn) ? 0.0 : (3.0 / (x(count - 1) - x(count - 2)) * (ypn - (y(count - 1) - y(count - 2)) / (x(count - 1) - x(count - 2))));
			array2[count - 1] = (num4 - num3 * array[count - 2]) / (num3 * array2[count - 2] + 1.0);
			for (int j = count - 2; j >= 0; j--)
			{
				array2[j] = array2[j] * array2[j + 1] + array[j];
			}
			return array2;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x000206A0 File Offset: 0x0001E8A0
		public double CubicSplineEvaluate(double x, double x1, double y1, double x2, double y2, double u1, double u2)
		{
			double num = x2 - x1;
			double num2 = (x2 - x) / num;
			double num3 = (x - x1) / num;
			return num2 * y1 + num3 * y2 + ((num2 * num2 * num2 - num2) * u1 + (num3 * num3 * num3 - num3) * u2) * (num * num) / 6.0;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x000206EC File Offset: 0x0001E8EC
		public static global::System.Windows.Media.PathFigureCollection Spline2D(int count, global::System.Func<int, double> x, global::System.Func<int, double> y, double stiffness)
		{
			global::System.Windows.Media.PathFigureCollection pathFigureCollection = new global::System.Windows.Media.PathFigureCollection();
			int num = 0;
			int num2 = -1;
			double d = double.NaN;
			double d2 = double.NaN;
			for (int i = 0; i < count; i++)
			{
				d = x(i);
				d2 = y(i);
				if (double.IsNaN(d) || double.IsNaN(d2))
				{
					num2 = i - 1;
					if (num2 - num > 0)
					{
						pathFigureCollection.Add(global::Infragistics.Controls.Charts.Util.Numeric.Spline2D(num, num2, x, y, stiffness));
					}
					num = i + 1;
				}
			}
			if (!double.IsNaN(d) && !double.IsNaN(d2))
			{
				num2 = count - 1;
			}
			if (num2 - num > 0)
			{
				pathFigureCollection.Add(global::Infragistics.Controls.Charts.Util.Numeric.Spline2D(num, num2, x, y, stiffness));
			}
			return pathFigureCollection;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00020798 File Offset: 0x0001E998
		public static global::System.Windows.Media.PathFigure Spline2D(int startIndex, int endIndex, global::System.Func<int, double> x, global::System.Func<int, double> y, double stiffness)
		{
			stiffness = 0.5 * global::Infragistics.MathUtil.Clamp(double.IsNaN(stiffness) ? 0.5 : stiffness, 0.0, 1.0);
			global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure();
			int num = endIndex - startIndex + 1;
			if (num < 2)
			{
				return pathFigure;
			}
			if (num == 2)
			{
				pathFigure.StartPoint = new global::System.Windows.Point(x(startIndex), y(startIndex));
				global::System.Windows.Media.LineSegment value = new global::System.Windows.Media.LineSegment
				{
					Point = new global::System.Windows.Point(x(startIndex + 1), y(startIndex + 1))
				};
				pathFigure.Segments.Add(value);
				return pathFigure;
			}
			global::System.Windows.Media.PolyBezierSegment polyBezierSegment = new global::System.Windows.Media.PolyBezierSegment();
			double num2 = x(startIndex);
			double num3 = y(startIndex);
			double num4 = x(startIndex + 1);
			double num5 = y(startIndex + 1);
			while (num4 == num2 && num5 == num3 && startIndex + 1 <= endIndex)
			{
				startIndex++;
				num4 = x(startIndex + 1);
				num5 = y(startIndex + 1);
			}
			double num6 = num4 - num2;
			double num7 = num5 - num3;
			double num8 = global::System.Math.Sqrt(num6 * num6 + num7 * num7);
			for (int i = startIndex + 1; i < endIndex; i++)
			{
				double num9 = x(i);
				double num10 = y(i);
				if (num9 != num2 || num10 != num3)
				{
					double num11 = x(i + 1) - x(i - 1);
					double num12 = y(i + 1) - y(i - 1);
					double num13 = num11 * num11 + num12 * num12;
					if (num13 < 0.01)
					{
						num11 = -(y(i + 1) - y(i));
						num12 = x(i + 1) - x(i);
						num13 = num11 * num11 + num12 * num12;
					}
					num13 = global::System.Math.Sqrt(num13);
					double num14 = stiffness * global::System.Math.Sqrt((num9 - num2) * (num9 - num2) + (num10 - num3) * (num10 - num3));
					if (num13 > 0.01)
					{
						polyBezierSegment.Points.Add(new global::System.Windows.Point(num2 + num6 * num14 / num8, num3 + num7 * num14 / num8));
						polyBezierSegment.Points.Add(new global::System.Windows.Point(num9 - num11 * num14 / num13, num10 - num12 * num14 / num13));
						polyBezierSegment.Points.Add(new global::System.Windows.Point(num9, num10));
						num2 = num9;
						num3 = num10;
						num6 = num11;
						num7 = num12;
						num8 = num13;
					}
				}
			}
			double num15 = x(endIndex);
			double num16 = y(endIndex);
			double num17 = x(endIndex) - x(endIndex - 1);
			double num18 = y(endIndex) - y(endIndex - 1);
			double num19 = num17 * num17 + num18 * num18;
			double num20 = stiffness * global::System.Math.Sqrt((num15 - num2) * (num15 - num2) + (num16 - num3) * (num16 - num3));
			polyBezierSegment.Points.Add(new global::System.Windows.Point(num2 + num6 * num20 / num8, num3 + num7 * num20 / num8));
			polyBezierSegment.Points.Add(new global::System.Windows.Point(num15 - num17 * num20 / num19, num16 - num18 * num20 / num19));
			polyBezierSegment.Points.Add(new global::System.Windows.Point(num15, num16));
			pathFigure.StartPoint = new global::System.Windows.Point(x(startIndex), y(startIndex));
			pathFigure.Segments.Add(polyBezierSegment);
			return pathFigure;
		}

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x06000705 RID: 1797
		public delegate global::System.IComparable ComparableDelegate(int index);
	}
}
