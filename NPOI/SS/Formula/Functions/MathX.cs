using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001B0 RID: 432
	public class MathX
	{
		// Token: 0x06000BB7 RID: 2999 RVA: 0x0000253E File Offset: 0x0000073E
		private MathX()
		{
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0001FDD0 File Offset: 0x0001DFD0
		public static double Round(double n, int p)
		{
			double result;
			if (double.IsNaN(n) || double.IsInfinity(n))
			{
				result = double.NaN;
			}
			else
			{
				if (1.7976931348623157E+308 == n)
				{
					return double.MaxValue;
				}
				if (-1.7976931348623157E+308 == n)
				{
					return 0.0;
				}
				if (p >= 0)
				{
					result = (double)global::System.Math.Round((decimal)n, p, global::System.MidpointRounding.AwayFromZero);
				}
				else
				{
					int value = (int)global::System.Math.Pow(10.0, (double)global::System.Math.Abs(p));
					result = (double)(global::System.Math.Round((decimal)n / value, global::System.MidpointRounding.AwayFromZero) * value);
				}
			}
			return result;
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0001FE84 File Offset: 0x0001E084
		public static double RoundUp(double n, int p)
		{
			double result;
			if (double.IsNaN(n) || double.IsInfinity(n))
			{
				result = double.NaN;
			}
			else
			{
				if (1.7976931348623157E+308 == n)
				{
					return double.MaxValue;
				}
				if (-1.7976931348623157E+308 == n)
				{
					double num = 1.0;
					while (p > 0)
					{
						num /= 10.0;
						p--;
					}
					return num;
				}
				if (p != 0)
				{
					double num2 = global::System.Math.Pow(10.0, (double)p);
					double num3 = (double)((decimal)global::System.Math.Abs(n * num2));
					result = (double)global::NPOI.SS.Formula.Functions.MathX.Sign(n) * ((num3 == (double)((long)num3)) ? (num3 / num2) : (global::System.Math.Round(num3 + 0.5) / num2));
				}
				else
				{
					double num4 = global::System.Math.Abs(n);
					result = (double)global::NPOI.SS.Formula.Functions.MathX.Sign(n) * ((num4 == (double)((long)num4)) ? num4 : ((double)((long)num4 + 1L)));
				}
			}
			return result;
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0001FF6C File Offset: 0x0001E16C
		public static double RoundDown(double n, int p)
		{
			double result;
			if (double.IsNaN(n) || double.IsInfinity(n))
			{
				result = double.NaN;
			}
			else
			{
				if (1.7976931348623157E+308 == n)
				{
					return double.MaxValue;
				}
				if (-1.7976931348623157E+308 == n)
				{
					return 0.0;
				}
				if (p != 0)
				{
					double num = global::System.Math.Pow(10.0, (double)p);
					result = (double)global::NPOI.SS.Formula.Functions.MathX.Sign(n) * global::System.Math.Round(global::System.Math.Abs(n) * num - 0.5, global::System.MidpointRounding.AwayFromZero) / num;
				}
				else
				{
					result = (double)((long)n);
				}
			}
			return result;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0001FFFF File Offset: 0x0001E1FF
		public static short Sign(double d)
		{
			return (d == 0.0) ? 0 : ((d < 0.0) ? -1 : 1);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x00020024 File Offset: 0x0001E224
		public static double Average(double[] values)
		{
			double num = 0.0;
			int i = 0;
			int num2 = values.Length;
			while (i < num2)
			{
				num += values[i];
				i++;
			}
			return num / (double)values.Length;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00020058 File Offset: 0x0001E258
		public static double Sum(double[] values)
		{
			double num = 0.0;
			int i = 0;
			int num2 = values.Length;
			while (i < num2)
			{
				num += values[i];
				i++;
			}
			return num;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00020088 File Offset: 0x0001E288
		public static double Sumsq(double[] values)
		{
			double num = 0.0;
			int i = 0;
			int num2 = values.Length;
			while (i < num2)
			{
				num += values[i] * values[i];
				i++;
			}
			return num;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000200BC File Offset: 0x0001E2BC
		public static double Product(double[] values)
		{
			double num = 0.0;
			if (values != null && values.Length != 0)
			{
				num = 1.0;
				int i = 0;
				int num2 = values.Length;
				while (i < num2)
				{
					num *= values[i];
					i++;
				}
			}
			return num;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000200FC File Offset: 0x0001E2FC
		public static double Min(double[] values)
		{
			double num = double.PositiveInfinity;
			int i = 0;
			int num2 = values.Length;
			while (i < num2)
			{
				num = global::System.Math.Min(num, values[i]);
				i++;
			}
			return num;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x00020130 File Offset: 0x0001E330
		public static double Max(double[] values)
		{
			double num = double.NegativeInfinity;
			int i = 0;
			int num2 = values.Length;
			while (i < num2)
			{
				num = global::System.Math.Max(num, values[i]);
				i++;
			}
			return num;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x00020164 File Offset: 0x0001E364
		public static double Floor(double n, double s)
		{
			double result;
			if ((n < 0.0 && s > 0.0) || (n > 0.0 && s < 0.0) || (s == 0.0 && n != 0.0))
			{
				result = double.NaN;
			}
			else
			{
				result = ((n == 0.0 || s == 0.0) ? 0.0 : (global::System.Math.Floor(n / s) * s));
			}
			return result;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000201F4 File Offset: 0x0001E3F4
		public static double Ceiling(double n, double s)
		{
			double result;
			if (n > 0.0 && s < 0.0)
			{
				result = double.NaN;
			}
			else
			{
				result = ((n == 0.0 || s == 0.0) ? 0.0 : (global::System.Math.Ceiling(n / s) * s));
			}
			return result;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00020254 File Offset: 0x0001E454
		public static double Factorial(int n)
		{
			double num = 1.0;
			if (n >= 0)
			{
				if (n <= 170)
				{
					for (int i = 1; i <= n; i++)
					{
						num *= (double)i;
					}
				}
				else
				{
					num = double.PositiveInfinity;
				}
			}
			else
			{
				num = double.NaN;
			}
			return num;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000202A4 File Offset: 0x0001E4A4
		public static double Mod(double n, double d)
		{
			double result;
			if (d == 0.0)
			{
				result = double.NaN;
			}
			else if (global::NPOI.SS.Formula.Functions.MathX.Sign(n) == global::NPOI.SS.Formula.Functions.MathX.Sign(d))
			{
				result = n % d;
			}
			else
			{
				result = (n % d + d) % d;
			}
			return result;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000202F0 File Offset: 0x0001E4F0
		public static double Acosh(double d)
		{
			return global::System.Math.Log(global::System.Math.Sqrt(global::System.Math.Pow(d, 2.0) - 1.0) + d);
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x00020317 File Offset: 0x0001E517
		public static double Asinh(double d)
		{
			return global::System.Math.Log(global::System.Math.Sqrt(d * d + 1.0) + d);
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00020332 File Offset: 0x0001E532
		public static double Atanh(double d)
		{
			return global::System.Math.Log((1.0 + d) / (1.0 - d)) / 2.0;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0002035C File Offset: 0x0001E55C
		public static double Cosh(double d)
		{
			double num = global::System.Math.Pow(2.718281828459045, d);
			double num2 = global::System.Math.Pow(2.718281828459045, -d);
			d = (num + num2) / 2.0;
			return d;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00020398 File Offset: 0x0001E598
		public static double Sinh(double d)
		{
			double num = global::System.Math.Pow(2.718281828459045, d);
			double num2 = global::System.Math.Pow(2.718281828459045, -d);
			d = (num - num2) / 2.0;
			return d;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000203D4 File Offset: 0x0001E5D4
		public static double Tanh(double d)
		{
			double num = global::System.Math.Pow(2.718281828459045, d);
			double num2 = global::System.Math.Pow(2.718281828459045, -d);
			d = (num - num2) / (num + num2);
			return d;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0002040C File Offset: 0x0001E60C
		public static double SumProduct(double[][] arrays)
		{
			double num = 0.0;
			try
			{
				int num2 = arrays.Length;
				int num3 = arrays[0].Length;
				for (int i = 0; i < num3; i++)
				{
					double num4 = 1.0;
					for (int j = 0; j < num2; j++)
					{
						num4 *= arrays[j][i];
					}
					num += num4;
				}
			}
			catch (global::System.IndexOutOfRangeException)
			{
				num = double.NaN;
			}
			return num;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x00020484 File Offset: 0x0001E684
		public static double Sumx2my2(double[] xarr, double[] yarr)
		{
			double num = 0.0;
			try
			{
				int i = 0;
				int num2 = xarr.Length;
				while (i < num2)
				{
					num += (xarr[i] + yarr[i]) * (xarr[i] - yarr[i]);
					i++;
				}
			}
			catch (global::System.IndexOutOfRangeException)
			{
				num = double.NaN;
			}
			return num;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000204E0 File Offset: 0x0001E6E0
		public static double Sumx2py2(double[] xarr, double[] yarr)
		{
			double num = 0.0;
			try
			{
				int i = 0;
				int num2 = xarr.Length;
				while (i < num2)
				{
					num += xarr[i] * xarr[i] + yarr[i] * yarr[i];
					i++;
				}
			}
			catch (global::System.IndexOutOfRangeException)
			{
				num = double.NaN;
			}
			return num;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0002053C File Offset: 0x0001E73C
		public static double Sumxmy2(double[] xarr, double[] yarr)
		{
			double num = 0.0;
			try
			{
				int i = 0;
				int num2 = xarr.Length;
				while (i < num2)
				{
					double num3 = xarr[i] - yarr[i];
					num += num3 * num3;
					i++;
				}
			}
			catch (global::System.IndexOutOfRangeException)
			{
				num = double.NaN;
			}
			return num;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00020594 File Offset: 0x0001E794
		public static double NChooseK(int n, int k)
		{
			double num = 1.0;
			if (n < 0 || k < 0 || n < k)
			{
				num = double.NaN;
			}
			else
			{
				int n2 = global::System.Math.Min(n - k, k);
				for (int i = global::System.Math.Max(n - k, k); i < n; i++)
				{
					num *= (double)(i + 1);
				}
				num /= global::NPOI.SS.Formula.Functions.MathX.Factorial(n2);
			}
			return num;
		}
	}
}
