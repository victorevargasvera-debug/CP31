using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace Infragistics
{
	// Token: 0x02000099 RID: 153
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class Flattener
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		private Flattener()
		{
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001CFC0 File Offset: 0x0001B1C0
		public static global::System.Collections.Generic.List<double> Spiral(double startAngle, double startRadius, double endAngle, double endRadius, double error)
		{
			if (double.IsNaN(error) || error <= 0.0)
			{
				error = 1.0;
			}
			global::System.Collections.Generic.List<double> list = new global::System.Collections.Generic.List<double>();
			global::System.Collections.Generic.Stack<global::Infragistics.SpiralTodo> stack = new global::System.Collections.Generic.Stack<global::Infragistics.SpiralTodo>();
			double num = (endRadius - startRadius) / (endAngle - startAngle);
			double num2 = startRadius - num * startAngle;
			double num3 = num * num;
			double num4 = num2 * num2;
			double num5 = num2 * num;
			stack.Push(new global::Infragistics.SpiralTodo
			{
				p0 = 0.0,
				p1 = 1.0
			});
			while (stack.Count != 0)
			{
				global::Infragistics.SpiralTodo spiralTodo = stack.Pop();
				double num6 = startRadius + spiralTodo.p0 * (endRadius - startRadius);
				double num7 = startAngle + spiralTodo.p0 * (endAngle - startAngle);
				double num8 = num7 * num7;
				double num9 = num8 * num7;
				double num10 = startRadius + spiralTodo.p1 * (endRadius - startRadius);
				double num11 = startAngle + spiralTodo.p1 * (endAngle - startAngle);
				double num12 = num11 * num11;
				double num13 = num12 * num11;
				double num14;
				if (num == 0.0)
				{
					num14 = num4 * (num11 - num7) / 2.0 + num5 * (num12 - num8) / 2.0 + num3 * (num13 - num9) / 6.0;
				}
				else
				{
					num14 = (global::System.Math.Pow(num2 + num * num11, 3.0) - global::System.Math.Pow(num2 + num * num7, 3.0)) / (6.0 * num);
				}
				double num15 = 0.5 * num6 * num10 * global::System.Math.Sin(num11 - num7);
				if (num14 - num15 > error)
				{
					double num16 = 0.5 * (spiralTodo.p0 + spiralTodo.p1);
					stack.Push(new global::Infragistics.SpiralTodo
					{
						p0 = num16,
						p1 = spiralTodo.p1
					});
					stack.Push(new global::Infragistics.SpiralTodo
					{
						p0 = spiralTodo.p0,
						p1 = num16
					});
				}
				else
				{
					list.Add(spiralTodo.p0);
				}
			}
			list.Add(1.0);
			return list;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001D1E4 File Offset: 0x0001B3E4
		public static global::System.Collections.Generic.IList<int> Flatten(int count, global::System.Func<int, double> X, global::System.Func<int, double> Y, double resolution)
		{
			global::System.Collections.Generic.List<int> result = new global::System.Collections.Generic.List<int>();
			global::Infragistics.Flattener.Flatten(result, X, Y, 0, count - 1, resolution);
			return result;
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x0001D209 File Offset: 0x0001B409
		public static global::System.Collections.Generic.IList<int> Flatten(global::System.Collections.Generic.IList<int> result, global::System.Func<int, double> X, global::System.Func<int, double> Y, int b, int e, double E)
		{
			return global::Infragistics.Flattener.Flatten(result, (int i) => i, X, Y, b, e, E);
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x0001D24C File Offset: 0x0001B44C
		public static global::System.Collections.Generic.IList<int> Flatten(global::System.Collections.Generic.IList<int> result, global::System.Collections.Generic.IList<int> indices, global::System.Func<int, double> X, global::System.Func<int, double> Y, int b, int e, double E)
		{
			return global::Infragistics.Flattener.Flatten(result, (int i) => indices[i], X, Y, b, e, E);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001D280 File Offset: 0x0001B480
		private static global::System.Collections.Generic.IList<int> Flatten(global::System.Collections.Generic.IList<int> result, global::System.Func<int, int> getIndex, global::System.Func<int, double> X, global::System.Func<int, double> Y, int b, int e, double E)
		{
			if (b > e)
			{
				return result;
			}
			double d = X(getIndex(b));
			double d2 = Y(getIndex(b));
			while ((double.IsNaN(d) || double.IsNaN(d2)) && b < e)
			{
				b++;
				d = X(getIndex(b));
				d2 = Y(getIndex(b));
			}
			double d3 = X(getIndex(e));
			double d4 = Y(getIndex(e));
			while ((double.IsNaN(d3) || double.IsNaN(d4)) && b < e)
			{
				e--;
				d3 = X(getIndex(e));
				d4 = Y(getIndex(e));
			}
			if (b == e)
			{
				result.Add(getIndex(b));
				return result;
			}
			result.Add(getIndex(b));
			global::Infragistics.Flattener.FlattenRecursive(result, getIndex, X, Y, b, e, E);
			result.Add(getIndex(e));
			return result;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001D38C File Offset: 0x0001B58C
		public static global::System.Collections.Generic.List<int> FastFlatten(global::System.Collections.Generic.List<int> result, double[] X, double[] Y, int b, int e, double E)
		{
			if (b > e)
			{
				return result;
			}
			double d = X[b];
			double d2 = Y[b];
			while ((double.IsNaN(d) || double.IsNaN(d2)) && b < e)
			{
				b++;
				d = X[b];
				d2 = Y[b];
			}
			double d3 = X[e];
			double d4 = Y[e];
			while ((double.IsNaN(d3) || double.IsNaN(d4)) && b < e)
			{
				e--;
				d3 = X[e];
				d4 = Y[e];
			}
			if (b == e)
			{
				result.Add(b);
				return result;
			}
			result.Add(b);
			global::Infragistics.Flattener.FastFlattenRecursive(result, X, Y, b, e, E);
			result.Add(e);
			return result;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001D428 File Offset: 0x0001B628
		public static global::System.Collections.Generic.IList<int> FastFlatten(int count, global::System.Collections.Generic.List<float[]> buckets, bool point0, bool useX0AsX1, double resolution)
		{
			int xIndex;
			int yIndex;
			if (point0)
			{
				xIndex = 0;
				yIndex = 1;
			}
			else if (useX0AsX1)
			{
				xIndex = 0;
				yIndex = 2;
			}
			else
			{
				xIndex = 2;
				yIndex = 3;
			}
			return global::Infragistics.Flattener.FastFlatten(count, buckets, xIndex, yIndex, resolution);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001D458 File Offset: 0x0001B658
		public static global::System.Collections.Generic.IList<int> FastFlatten(int count, global::System.Collections.Generic.List<float[]> buckets, int xIndex, int yIndex, double resolution)
		{
			global::System.Collections.Generic.List<int> result = new global::System.Collections.Generic.List<int>();
			global::Infragistics.Flattener.FastFlatten(result, buckets, xIndex, yIndex, 0, count - 1, resolution);
			return result;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001D47C File Offset: 0x0001B67C
		public static global::System.Collections.Generic.IList<int> ChunkedFastFlatten(global::System.Collections.Generic.List<int> result, global::System.Collections.Generic.List<float[]> buckets, bool point0, bool useX0AsX1, int b, int e, double E)
		{
			if (e - b + 1 <= 3000)
			{
				return global::Infragistics.Flattener.FastFlatten(result, buckets, point0, useX0AsX1, b, e, E);
			}
			int num = b;
			for (int i = e - num + 1; i > 0; i = e - num + 1)
			{
				if (i <= 3000)
				{
					global::Infragistics.Flattener.FastFlatten(result, buckets, point0, useX0AsX1, num, e, E);
					num = e + 1;
				}
				else
				{
					int num2 = num + 3000 - 1;
					global::Infragistics.Flattener.FastFlatten(result, buckets, point0, useX0AsX1, num, num2, E);
					num = num2 + 1;
				}
			}
			return result;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001D500 File Offset: 0x0001B700
		public static global::System.Collections.Generic.List<int> FastFlatten(global::System.Collections.Generic.List<int> result, global::System.Collections.Generic.List<float[]> buckets, bool point0, bool useX0AsX1, int b, int e, double E)
		{
			int xIndex;
			int yIndex;
			if (point0)
			{
				xIndex = 0;
				yIndex = 1;
			}
			else if (useX0AsX1)
			{
				xIndex = 0;
				yIndex = 2;
			}
			else
			{
				xIndex = 2;
				yIndex = 3;
			}
			return global::Infragistics.Flattener.FastFlatten(result, buckets, xIndex, yIndex, b, e, E);
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x0001D534 File Offset: 0x0001B734
		public static global::System.Collections.Generic.List<int> FastFlatten(global::System.Collections.Generic.List<int> result, global::System.Collections.Generic.List<float[]> buckets, int xIndex, int yIndex, int b, int e, double E)
		{
			if (b > e)
			{
				return result;
			}
			float[] array = buckets[b];
			double d = (double)array[xIndex];
			double d2 = (double)array[yIndex];
			while ((double.IsNaN(d) || double.IsNaN(d2)) && b < e)
			{
				b++;
				array = buckets[b];
				d = (double)array[xIndex];
				d2 = (double)array[yIndex];
			}
			float[] array2 = buckets[e];
			double d3 = (double)array2[xIndex];
			double d4 = (double)array2[yIndex];
			while ((double.IsNaN(d3) || double.IsNaN(d4)) && b < e)
			{
				e--;
				array2 = buckets[e];
				d3 = (double)array2[xIndex];
				d4 = (double)array2[yIndex];
			}
			if (b == e)
			{
				result.Add(b);
				return result;
			}
			result.Add(b);
			global::Infragistics.Flattener.FastFlattenRecursive(result, buckets, xIndex, yIndex, b, e, E);
			result.Add(e);
			return result;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x0001D608 File Offset: 0x0001B808
		private static void FastFlattenRecursive(global::System.Collections.Generic.List<int> result, double[] X, double[] Y, int b, int e, double E)
		{
			double num = X[b];
			double num2 = Y[b];
			while ((double.IsNaN(num) || double.IsNaN(num2)) && b < e)
			{
				b++;
				num = X[b];
				num2 = Y[b];
			}
			double num3 = X[e];
			double num4 = Y[e];
			while ((double.IsNaN(num3) || double.IsNaN(num4)) && b < e)
			{
				e--;
				num3 = X[e];
				num4 = Y[e];
			}
			if (b + 1 >= e)
			{
				return;
			}
			int num5 = -1;
			double num6 = E * E;
			double num7 = num3 - num;
			double num8 = num4 - num2;
			double num9 = num7 * num7 + num8 * num8;
			if (num9 == 0.0)
			{
				for (int i = b + 1; i < e; i++)
				{
					double num10 = X[i];
					double num11 = Y[i];
					if (!double.IsNaN(num10) && !double.IsNaN(num11))
					{
						num7 = num3 - num10;
						num8 = num4 - num11;
						double num12 = num7 * num7 + num8 * num8;
						if (num12 >= num6)
						{
							num6 = num12;
							num5 = i;
						}
					}
				}
			}
			else
			{
				double num13 = num3 - num;
				double num14 = num4 - num2;
				for (int j = b + 1; j < e; j++)
				{
					double num15 = X[j];
					double num16 = Y[j];
					if (!double.IsNaN(num15) && !double.IsNaN(num16))
					{
						double num17 = X[j] - num;
						double num18 = Y[j] - num2;
						double num19 = num13 * num17 + num14 * num18;
						double num20;
						if (num19 <= 0.0)
						{
							num7 = num - num15;
							num8 = num2 - num16;
							num20 = num7 * num7 + num8 * num8;
						}
						else
						{
							double num21 = num13 * num13 + num14 * num14;
							if (num21 <= num19)
							{
								num7 = num3 - num15;
								num8 = num4 - num16;
								num20 = num7 * num7 + num8 * num8;
							}
							else
							{
								double num22 = num19 / num21;
								num7 = num + num22 * num13 - num15;
								num8 = num2 + num22 * num14 - num16;
								num20 = num7 * num7 + num8 * num8;
							}
						}
						if (num20 >= num6)
						{
							num6 = num20;
							num5 = j;
						}
					}
				}
			}
			if (num5 != -1)
			{
				global::Infragistics.Flattener.FastFlattenRecursive(result, X, Y, b, num5, E);
				result.Add(num5);
				global::Infragistics.Flattener.FastFlattenRecursive(result, X, Y, num5, e, E);
			}
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0001D82C File Offset: 0x0001BA2C
		private static void FastFlattenRecursive(global::System.Collections.Generic.List<int> result, global::System.Collections.Generic.List<float[]> buckets, int xIndex, int yIndex, int b, int e, double E)
		{
			float[] array = buckets[b];
			double num = (double)array[xIndex];
			double num2 = (double)array[yIndex];
			while (num != num || (num2 != num2 && b < e))
			{
				b++;
				array = buckets[b];
				num = (double)array[xIndex];
				num2 = (double)array[yIndex];
			}
			float[] array2 = buckets[e];
			double num3 = (double)array2[xIndex];
			double num4 = (double)array2[yIndex];
			while (num3 != num3 || (num4 != num4 && b < e))
			{
				e--;
				array2 = buckets[e];
				num3 = (double)array2[xIndex];
				num4 = (double)array2[yIndex];
			}
			if (b + 1 >= e)
			{
				return;
			}
			int num5 = -1;
			double num6 = E * E;
			double num7 = num3 - num;
			double num8 = num4 - num2;
			double num9 = num7 * num7 + num8 * num8;
			if (num9 == 0.0)
			{
				for (int i = b + 1; i < e; i++)
				{
					float[] array3 = buckets[i];
					double num10 = (double)array3[xIndex];
					double num11 = (double)array3[yIndex];
					if (num10 == num10 && num11 == num11)
					{
						num7 = num3 - num10;
						num8 = num4 - num11;
						double num12 = num7 * num7 + num8 * num8;
						if (num12 >= num6)
						{
							num6 = num12;
							num5 = i;
						}
					}
				}
			}
			else
			{
				double num13 = num3 - num;
				double num14 = num4 - num2;
				for (int j = b + 1; j < e; j++)
				{
					float[] array4 = buckets[j];
					double num15 = (double)array4[xIndex];
					double num16 = (double)array4[yIndex];
					if (num15 == num15 && num16 == num16)
					{
						double num17 = num15 - num;
						double num18 = num16 - num2;
						double num19 = num13 * num17 + num14 * num18;
						double num20;
						if (num19 <= 0.0)
						{
							num7 = num - num15;
							num8 = num2 - num16;
							num20 = num7 * num7 + num8 * num8;
						}
						else
						{
							double num21 = num13 * num13 + num14 * num14;
							if (num21 <= num19)
							{
								num7 = num3 - num15;
								num8 = num4 - num16;
								num20 = num7 * num7 + num8 * num8;
							}
							else
							{
								double num22 = num19 / num21;
								num7 = num + num22 * num13 - num15;
								num8 = num2 + num22 * num14 - num16;
								num20 = num7 * num7 + num8 * num8;
							}
						}
						if (num20 >= num6)
						{
							num6 = num20;
							num5 = j;
						}
					}
				}
			}
			if (num5 != -1)
			{
				global::Infragistics.Flattener.FastFlattenRecursive(result, buckets, xIndex, yIndex, b, num5, E);
				result.Add(num5);
				global::Infragistics.Flattener.FastFlattenRecursive(result, buckets, xIndex, yIndex, num5, e, E);
			}
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0001DA8C File Offset: 0x0001BC8C
		private static void FlattenRecursive(global::System.Collections.Generic.IList<int> result, global::System.Func<int, int> getIndex, global::System.Func<int, double> X, global::System.Func<int, double> Y, int b, int e, double E)
		{
			double num = X(getIndex(b));
			double num2 = Y(getIndex(b));
			while ((double.IsNaN(num) || double.IsNaN(num2)) && b < e)
			{
				b++;
				num = X(getIndex(b));
				num2 = Y(getIndex(b));
			}
			double num3 = X(getIndex(e));
			double num4 = Y(getIndex(e));
			while ((double.IsNaN(num3) || double.IsNaN(num4)) && b < e)
			{
				e--;
				num3 = X(getIndex(e));
				num4 = Y(getIndex(e));
			}
			if (b + 1 >= e)
			{
				return;
			}
			int num5 = -1;
			double num6 = E;
			double num7 = global::Infragistics.MathUtil.Hypot(num3 - num, num4 - num2);
			if (num7 == 0.0)
			{
				for (int i = b + 1; i < e; i++)
				{
					double num8 = X(getIndex(i));
					double num9 = Y(getIndex(i));
					if (!double.IsNaN(num8) && !double.IsNaN(num9))
					{
						double num10 = global::Infragistics.MathUtil.Hypot(num3 - num8, num4 - num9);
						if (num10 >= num6)
						{
							num6 = num10;
							num5 = i;
						}
					}
				}
			}
			else
			{
				double num11 = num3 - num;
				double num12 = num4 - num2;
				for (int j = b + 1; j < e; j++)
				{
					double num13 = X(getIndex(j));
					double num14 = Y(getIndex(j));
					if (!double.IsNaN(num13) && !double.IsNaN(num14))
					{
						double num15 = X(getIndex(j)) - num;
						double num16 = Y(getIndex(j)) - num2;
						double num17 = num11 * num15 + num12 * num16;
						double num18;
						if (num17 <= 0.0)
						{
							num18 = global::Infragistics.MathUtil.Hypot(num - num13, num2 - num14);
						}
						else
						{
							double num19 = num11 * num11 + num12 * num12;
							if (num19 <= num17)
							{
								num18 = global::Infragistics.MathUtil.Hypot(num3 - num13, num4 - num14);
							}
							else
							{
								double num20 = num17 / num19;
								num18 = global::Infragistics.MathUtil.Hypot(num + num20 * num11 - num13, num2 + num20 * num12 - num14);
							}
						}
						if (num18 >= num6)
						{
							num6 = num18;
							num5 = j;
						}
					}
				}
			}
			if (num5 != -1)
			{
				global::Infragistics.Flattener.FlattenRecursive(result, getIndex, X, Y, b, num5, E);
				result.Add(getIndex(num5));
				global::Infragistics.Flattener.FlattenRecursive(result, getIndex, X, Y, num5, e, E);
			}
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0001DD54 File Offset: 0x0001BF54
		public static global::System.Windows.Media.PathFigure Smooth(int count, global::System.Func<int, double> X, global::System.Func<int, double> Y, double resolution)
		{
			global::System.Collections.Generic.IList<int> indices = global::Infragistics.Flattener.Flatten(count, X, Y, resolution);
			return global::Infragistics.Flattener.Smooth(indices.Count, (int i) => X(indices[i]), (int i) => Y(indices[i]));
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0001DDB8 File Offset: 0x0001BFB8
		public static global::System.Windows.Media.PointCollection Spline(int count, global::System.Func<int, double> X, global::System.Func<int, double> Y)
		{
			global::System.Windows.Media.PointCollection pointCollection = new global::System.Windows.Media.PointCollection();
			if (count < 5)
			{
				for (int i = 0; i < count; i++)
				{
					pointCollection.Add(new global::System.Windows.Point(X(i), Y(i)));
				}
				return pointCollection;
			}
			pointCollection.Add(new global::System.Windows.Point(X(0), Y(0)));
			int num = count - 1;
			global::System.Windows.Point point = new global::System.Windows.Point(X(0), Y(0));
			global::System.Windows.Point point2 = new global::System.Windows.Point(X(1), Y(1));
			global::System.Windows.Point point3 = new global::System.Windows.Point(X(2), Y(2));
			global::System.Windows.Point point4 = new global::System.Windows.Point(point2.X - point.X, point2.Y - point.Y);
			double num2 = global::Infragistics.MathUtil.Hypot(point4.X, point4.Y);
			global::System.Windows.Point point5 = new global::System.Windows.Point(point3.X - point2.X, point3.Y - point2.Y);
			double num3 = global::Infragistics.MathUtil.Hypot(point5.X, point5.Y);
			double num4 = 0.1;
			double num5 = 0.3;
			global::System.Windows.Point point6 = new global::System.Windows.Point(point3.X - point.X, point3.Y - point.Y);
			double num6 = global::Infragistics.MathUtil.Hypot(point6.X, point6.Y);
			point6.X /= num6;
			point6.Y /= num6;
			double num7 = 0.5 + (point4.X * point5.X + point4.Y * point5.Y) / (2.0 * num2 * num3);
			pointCollection.Add(new global::System.Windows.Point(point2.X - point6.X * (num4 + num5 * num7) * num2, point2.Y - point6.Y * (num4 + num5 * num7) * num2));
			pointCollection.Add(point2);
			for (int j = 1; j < num - 1; j++)
			{
				point = point2;
				point2 = point3;
				point3 = new global::System.Windows.Point(X(j + 2), Y(j + 2));
				point4 = point5;
				num2 = num3;
				point5 = new global::System.Windows.Point(point3.X - point2.X, point3.Y - point2.Y);
				num3 = global::Infragistics.MathUtil.Hypot(point5.X, point5.Y);
				global::System.Windows.Point point7 = point6;
				double num8 = num7;
				point6 = new global::System.Windows.Point(point3.X - point.X, point3.Y - point.Y);
				double num9 = global::Infragistics.MathUtil.Hypot(point6.X, point6.Y);
				point6.X /= num9;
				point6.Y /= num9;
				num7 = 0.5 + (point4.X * point5.X + point4.Y * point5.Y) / (2.0 * num2 * num3);
				pointCollection.Add(new global::System.Windows.Point(point.X + point7.X * (num4 + num5 * num8) * num2, point.Y + point7.Y * (num4 + num5 * num8) * num2));
				pointCollection.Add(new global::System.Windows.Point(point2.X - point6.X * (num4 + num5 * num7) * num2, point2.Y - point6.Y * (num4 + num5 * num7) * num2));
				pointCollection.Add(point2);
			}
			point = point2;
			point2 = point3;
			point4 = point5;
			num2 = num3;
			global::System.Windows.Point point8 = point6;
			double num10 = num7;
			pointCollection.Add(new global::System.Windows.Point(point.X + point8.X * (num4 + num5 * num10) * num2, point.Y + point8.Y * (num4 + num5 * num10) * num2));
			pointCollection.Add(point2);
			return pointCollection;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
		public static global::System.Windows.Media.PathFigure Smooth(int count, global::System.Func<int, double> X, global::System.Func<int, double> Y)
		{
			global::System.Windows.Media.PathFigure pathFigure = new global::System.Windows.Media.PathFigure
			{
				StartPoint = new global::System.Windows.Point(X(0), Y(0))
			};
			int num = count - 1;
			global::System.Windows.Point point = new global::System.Windows.Point(X(0), Y(0));
			global::System.Windows.Point point2 = new global::System.Windows.Point(X(1), Y(1));
			global::System.Windows.Point point3 = new global::System.Windows.Point(X(2), Y(2));
			global::System.Windows.Point point4 = new global::System.Windows.Point(point2.X - point.X, point2.Y - point.Y);
			double num2 = global::Infragistics.MathUtil.Hypot(point4.X, point4.Y);
			global::System.Windows.Point point5 = new global::System.Windows.Point(point3.X - point2.X, point3.Y - point2.Y);
			double num3 = global::Infragistics.MathUtil.Hypot(point5.X, point5.Y);
			double num4 = 0.15;
			double num5 = 0.45;
			global::System.Windows.Point point6 = new global::System.Windows.Point(point3.X - point.X, point3.Y - point.Y);
			double num6 = global::Infragistics.MathUtil.Hypot(point6.X, point6.Y);
			point6.X /= num6;
			point6.Y /= num6;
			double num7 = 0.5 + (point4.X * point5.X + point4.Y * point5.Y) / (2.0 * num2 * num3);
			global::System.Windows.Media.QuadraticBezierSegment value = new global::System.Windows.Media.QuadraticBezierSegment
			{
				Point1 = new global::System.Windows.Point(point2.X - point6.X * (num4 + num5 * num7) * num2, point2.Y - point6.Y * (num4 + num5 * num7) * num2),
				Point2 = point2
			};
			pathFigure.Segments.Add(value);
			for (int i = 1; i < num - 1; i++)
			{
				point = point2;
				point2 = point3;
				point3 = new global::System.Windows.Point(X(i + 2), Y(i + 2));
				point4 = point5;
				num2 = num3;
				point5 = new global::System.Windows.Point(point3.X - point2.X, point3.Y - point2.Y);
				num3 = global::Infragistics.MathUtil.Hypot(point5.X, point5.Y);
				global::System.Windows.Point point7 = point6;
				double num8 = num7;
				point6 = new global::System.Windows.Point(point3.X - point.X, point3.Y - point.Y);
				double num9 = global::Infragistics.MathUtil.Hypot(point6.X, point6.Y);
				point6.X /= num9;
				point6.Y /= num9;
				num7 = 0.5 + (point4.X * point5.X + point4.Y * point5.Y) / (2.0 * num2 * num3);
				global::System.Windows.Media.BezierSegment value2 = new global::System.Windows.Media.BezierSegment
				{
					Point1 = new global::System.Windows.Point(point.X + point7.X * (num4 + num5 * num8) * num2, point.Y + point7.Y * (num4 + num5 * num8) * num2),
					Point2 = new global::System.Windows.Point(point2.X - point6.X * (num4 + num5 * num7) * num2, point2.Y - point6.Y * (num4 + num5 * num7) * num2),
					Point3 = point2
				};
				pathFigure.Segments.Add(value2);
			}
			point = point2;
			point2 = point3;
			point4 = point5;
			num2 = num3;
			global::System.Windows.Point point8 = point6;
			double num10 = num7;
			global::System.Windows.Media.QuadraticBezierSegment value3 = new global::System.Windows.Media.QuadraticBezierSegment
			{
				Point1 = new global::System.Windows.Point(point.X + point8.X * (num4 + num5 * num10) * num2, point.Y + point8.Y * (num4 + num5 * num10) * num2),
				Point2 = point2
			};
			pathFigure.Segments.Add(value3);
			return pathFigure;
		}

		// Token: 0x04000295 RID: 661
		private const int FLATTENER_CHUNKING = 3000;
	}
}
