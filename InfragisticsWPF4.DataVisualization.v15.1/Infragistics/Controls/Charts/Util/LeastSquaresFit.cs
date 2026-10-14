using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Controls.Charts.Util
{
	// Token: 0x020000A1 RID: 161
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class LeastSquaresFit : global::Infragistics.Controls.Charts.Util.Numeric
	{
		// Token: 0x06000708 RID: 1800 RVA: 0x00020B20 File Offset: 0x0001ED20
		public static bool Test()
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.LinearTest() && global::Infragistics.Controls.Charts.Util.LeastSquaresFit.LogarithmicTest() && global::Infragistics.Controls.Charts.Util.LeastSquaresFit.ExponentialTest() && global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PowerLawTest() && global::Infragistics.Controls.Charts.Util.LeastSquaresFit.QuadraticTest() && global::Infragistics.Controls.Charts.Util.LeastSquaresFit.CubicTest() && global::Infragistics.Controls.Charts.Util.LeastSquaresFit.QuarticTest() && global::Infragistics.Controls.Charts.Util.LeastSquaresFit.QuinticTest();
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00020B5A File Offset: 0x0001ED5A
		private LeastSquaresFit()
		{
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x00020B64 File Offset: 0x0001ED64
		public static double[] LinearFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			int num5 = 0;
			for (int i = 0; i < n; i++)
			{
				double num6 = x(i);
				double num7 = y(i);
				if (!double.IsNaN(num6) && !double.IsNaN(num7))
				{
					num += num7;
					num2 += num6 * num6;
					num3 += num6;
					num4 += num6 * num7;
					num5++;
				}
			}
			if (num5 < 2)
			{
				return null;
			}
			double num8 = (num * num2 - num3 * num4) / ((double)num5 * num2 - num3 * num3);
			double num9 = ((double)num5 * num4 - num3 * num) / ((double)num5 * num2 - num3 * num3);
			return new double[]
			{
				num8,
				num9
			};
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00020C37 File Offset: 0x0001EE37
		public static double LinearEvaluate(double[] a, double x)
		{
			if (a.Length != 2)
			{
				return double.NaN;
			}
			return a[0] + a[1] * x;
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00020C78 File Offset: 0x0001EE78
		public static bool LinearTest()
		{
			global::System.Random random = new global::System.Random();
			double[] array = new double[2];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 10.0 * random.NextDouble();
			}
			global::System.Collections.Generic.List<double> x = new global::System.Collections.Generic.List<double>();
			global::System.Collections.Generic.List<double> y = new global::System.Collections.Generic.List<double>();
			for (int j = -100; j < 100; j++)
			{
				double num = (double)j;
				double num2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.LinearEvaluate(array, num);
				if (!double.IsNaN(num2))
				{
					x.Add(num);
					y.Add(num2);
				}
			}
			double[] array2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.LinearFit(x.Count, (int i) => x[i], (int i) => y[i]);
			for (int k = 0; k < array.Length; k++)
			{
				global::System.Math.Abs(array[k] - array2[k]);
			}
			return true;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00020D70 File Offset: 0x0001EF70
		public static double[] LogarithmicFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			int num5 = 0;
			for (int i = 0; i < n; i++)
			{
				double num6 = x(i);
				double num7 = y(i);
				if (!double.IsNaN(num6) && !double.IsNaN(num7) && num6 > 0.0)
				{
					double num8 = global::System.Math.Log(num6);
					num += num7 * num8;
					num2 += num7;
					num3 += num8;
					num4 += num8 * num8;
					num5++;
				}
			}
			if (num5 < 2)
			{
				return null;
			}
			double num9 = ((double)num5 * num - num2 * num3) / ((double)num5 * num4 - num3 * num3);
			double num10 = (num2 - num9 * num3) / (double)num5;
			return new double[]
			{
				num10,
				num9
			};
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x00020E52 File Offset: 0x0001F052
		public static double LogarithmicEvaluate(double[] a, double x)
		{
			if (a.Length != 2 || x < 0.0 || double.IsInfinity(x) || double.IsNaN(x))
			{
				return double.NaN;
			}
			return a[0] + a[1] * global::System.Math.Log(x);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00020EB4 File Offset: 0x0001F0B4
		public static bool LogarithmicTest()
		{
			global::System.Random random = new global::System.Random();
			double[] array = new double[2];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 10.0 * random.NextDouble();
			}
			global::System.Collections.Generic.List<double> x = new global::System.Collections.Generic.List<double>();
			global::System.Collections.Generic.List<double> y = new global::System.Collections.Generic.List<double>();
			for (int j = 1; j < 100; j++)
			{
				double num = (double)j;
				double num2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.LogarithmicEvaluate(array, num);
				if (!double.IsNaN(num2))
				{
					x.Add(num);
					y.Add(num2);
				}
			}
			double[] array2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.LogarithmicFit(x.Count, (int i) => x[i], (int i) => y[i]);
			for (int k = 0; k < array.Length; k++)
			{
				global::System.Math.Abs(array[k] - array2[k]);
			}
			return true;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00020FA8 File Offset: 0x0001F1A8
		public static double[] ExponentialFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			double num5 = 0.0;
			int num6 = 0;
			for (int i = 0; i < n; i++)
			{
				double num7 = x(i);
				double num8 = y(i);
				if (!double.IsNaN(num7) && !double.IsNaN(num8) && num8 > 0.0)
				{
					double num9 = global::System.Math.Log(num8);
					num += num7 * num7 * num8;
					num2 += num8 * num9;
					num3 += num7 * num8;
					num4 += num7 * num8 * num9;
					num5 += num8;
					num6++;
				}
			}
			if (num6 < 2)
			{
				return null;
			}
			double d = (num * num2 - num3 * num4) / (num5 * num - num3 * num3);
			double num10 = (num5 * num4 - num3 * num2) / (num5 * num - num3 * num3);
			return new double[]
			{
				global::System.Math.Exp(d),
				num10
			};
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000210B1 File Offset: 0x0001F2B1
		public static double ExponentialEvaluate(double[] a, double x)
		{
			if (a.Length != 2 || x < 0.0 || double.IsInfinity(x) || double.IsNaN(x))
			{
				return double.NaN;
			}
			return a[0] * global::System.Math.Exp(a[1] * x);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00021114 File Offset: 0x0001F314
		public static bool ExponentialTest()
		{
			global::System.Random random = new global::System.Random();
			double[] array = new double[2];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 2.0 * random.NextDouble();
			}
			global::System.Collections.Generic.List<double> x = new global::System.Collections.Generic.List<double>();
			global::System.Collections.Generic.List<double> y = new global::System.Collections.Generic.List<double>();
			for (int j = 1; j < 100; j++)
			{
				double num = (double)j;
				double num2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.ExponentialEvaluate(array, num);
				if (!double.IsNaN(num2))
				{
					x.Add(num);
					y.Add(num2);
				}
			}
			double[] array2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.ExponentialFit(x.Count, (int i) => x[i], (int i) => y[i]);
			for (int k = 0; k < array.Length; k++)
			{
				if (global::System.Math.Abs(array[k] - array2[k]) > 0.0001)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0002120C File Offset: 0x0001F40C
		public static double[] PowerLawFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			int num5 = 0;
			for (int i = 0; i < n; i++)
			{
				double num6 = x(i);
				double num7 = y(i);
				if (!double.IsNaN(num6) && !double.IsNaN(num7) && num6 > 0.0 && num7 > 0.0)
				{
					double num8 = global::System.Math.Log(x(i));
					double num9 = global::System.Math.Log(y(i));
					num += num8 * num9;
					num2 += num8;
					num3 += num9;
					num4 += num8 * num8;
					num5++;
				}
			}
			if (num5 < 2)
			{
				return null;
			}
			double num10 = ((double)num5 * num - num2 * num3) / ((double)num5 * num4 - num2 * num2);
			double num11 = global::System.Math.Exp((num3 - num10 * num2) / (double)num5);
			return new double[]
			{
				num11,
				num10
			};
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0002131B File Offset: 0x0001F51B
		public static double PowerLawEvaluate(double[] a, double x)
		{
			if (a.Length != 2 || x < 0.0 || double.IsInfinity(x) || double.IsNaN(x))
			{
				return double.NaN;
			}
			return a[0] * global::System.Math.Pow(x, a[1]);
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0002137C File Offset: 0x0001F57C
		public static bool PowerLawTest()
		{
			global::System.Random random = new global::System.Random();
			double[] array = new double[2];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 10.0 * random.NextDouble();
			}
			global::System.Collections.Generic.List<double> x = new global::System.Collections.Generic.List<double>();
			global::System.Collections.Generic.List<double> y = new global::System.Collections.Generic.List<double>();
			for (int j = -100; j < 100; j++)
			{
				x.Add((double)j);
				y.Add(global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PowerLawEvaluate(array, (double)j));
			}
			double[] array2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PowerLawFit(x.Count, (int i) => x[i], (int i) => y[i]);
			for (int k = 0; k < array.Length; k++)
			{
				if (global::System.Math.Abs(array[k] - array2[k]) > 0.0001)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00021462 File Offset: 0x0001F662
		public static double[] QuadraticFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialFit(n, 2, x, y);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0002146D File Offset: 0x0001F66D
		public static double QuadraticEvaluate(double[] a, double x)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialEvaluate(a, x);
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00021476 File Offset: 0x0001F676
		public static bool QuadraticTest()
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialTest(2);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0002147E File Offset: 0x0001F67E
		public static double[] CubicFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialFit(n, 3, x, y);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00021489 File Offset: 0x0001F689
		public static double CubicEvaluate(double[] a, double x)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialEvaluate(a, x);
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00021492 File Offset: 0x0001F692
		public static bool CubicTest()
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialTest(3);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0002149A File Offset: 0x0001F69A
		public static double[] QuarticFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialFit(n, 4, x, y);
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x000214A5 File Offset: 0x0001F6A5
		public static double QuarticEvaluate(double[] a, double x)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialEvaluate(a, x);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000214AE File Offset: 0x0001F6AE
		public static bool QuarticTest()
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialTest(4);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000214B6 File Offset: 0x0001F6B6
		public static double[] QuinticFit(int n, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialFit(n, 5, x, y);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000214C1 File Offset: 0x0001F6C1
		public static double QuinticEvaluate(double[] a, double x)
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialEvaluate(a, x);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000214CA File Offset: 0x0001F6CA
		public static bool QuinticTest()
		{
			return global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialTest(5);
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000214D4 File Offset: 0x0001F6D4
		public static double[] PolynomialFit(int n, int k, global::System.Func<int, double> x, global::System.Func<int, double> y)
		{
			double[] array = new double[1 + 2 * k];
			double[,] array2 = new double[k + 1, k + 1];
			double[] array3 = new double[k + 1];
			int num = 0;
			for (int i = 0; i < n; i++)
			{
				double num2 = 1.0;
				double num3 = x(i);
				if (!double.IsNaN(num3) && !double.IsNaN(y(i)))
				{
					for (int j = 0; j < array.Length; j++)
					{
						array[j] += num2;
						num2 *= num3;
						num++;
					}
				}
			}
			if (num < k)
			{
				return null;
			}
			for (int l = 0; l <= k; l++)
			{
				for (int m = 0; m <= k; m++)
				{
					array2[l, m] = array[l + m];
				}
			}
			for (int num4 = 0; num4 < n; num4++)
			{
				double num5 = x(num4);
				double num6 = y(num4);
				if (!double.IsNaN(num5) && !double.IsNaN(num6))
				{
					for (int num7 = 0; num7 <= k; num7++)
					{
						array3[num7] += global::System.Math.Pow(num5, (double)num7) * num6;
					}
				}
			}
			if (!global::Infragistics.Controls.Charts.Util.Numeric.Solve(array2, array3))
			{
				return null;
			}
			return array3;
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00021620 File Offset: 0x0001F820
		public static double PolynomialEvaluate(double[] a, double x)
		{
			if (a.Length < 1 || double.IsInfinity(x) || double.IsNaN(x))
			{
				return double.NaN;
			}
			double num = 0.0;
			for (int i = 0; i < a.Length; i++)
			{
				num += a[i] * global::System.Math.Pow(x, (double)i);
			}
			return num;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0002169C File Offset: 0x0001F89C
		public static bool PolynomialTest(int k)
		{
			global::System.Random random = new global::System.Random();
			double[] array = new double[k + 1];
			for (int m = 0; m < array.Length; m++)
			{
				array[m] = 2.0 * random.NextDouble();
			}
			global::System.Collections.Generic.List<double> x = new global::System.Collections.Generic.List<double>();
			global::System.Collections.Generic.List<double> y = new global::System.Collections.Generic.List<double>();
			for (int j = -100; j < 100; j++)
			{
				double num = (double)j;
				double num2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialEvaluate(array, num);
				if (!double.IsNaN(num2))
				{
					x.Add(num);
					y.Add(num2);
				}
			}
			double[] array2 = global::Infragistics.Controls.Charts.Util.LeastSquaresFit.PolynomialFit(x.Count, k, (int i) => x[i], (int i) => y[i]);
			for (int l = 0; l < k; l++)
			{
				if (global::System.Math.Abs(array[l] - array2[l]) > 0.0001)
				{
					return false;
				}
			}
			return true;
		}
	}
}
