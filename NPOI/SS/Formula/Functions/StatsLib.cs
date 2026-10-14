using System;
using NPOI.Util;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001E1 RID: 481
	public class StatsLib
	{
		// Token: 0x06000C5A RID: 3162 RVA: 0x0000253E File Offset: 0x0000073E
		private StatsLib()
		{
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00021898 File Offset: 0x0001FA98
		public static double avedev(double[] v)
		{
			double num = 0.0;
			int i = 0;
			int num2 = v.Length;
			while (i < num2)
			{
				num += v[i];
				i++;
			}
			double num3 = num / (double)v.Length;
			num = 0.0;
			int j = 0;
			int num4 = v.Length;
			while (j < num4)
			{
				num += global::System.Math.Abs(v[j] - num3);
				j++;
			}
			return num / (double)v.Length;
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x0002190C File Offset: 0x0001FB0C
		public static double stdev(double[] v)
		{
			double result = double.NaN;
			if (v != null && v.Length > 1)
			{
				result = global::System.Math.Sqrt(global::NPOI.SS.Formula.Functions.StatsLib.devsq(v) / (double)(v.Length - 1));
			}
			return result;
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00021940 File Offset: 0x0001FB40
		public static double var(double[] v)
		{
			double result = double.NaN;
			if (v != null && v.Length > 1)
			{
				result = global::NPOI.SS.Formula.Functions.StatsLib.devsq(v) / (double)(v.Length - 1);
			}
			return result;
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00021970 File Offset: 0x0001FB70
		public static double varp(double[] v)
		{
			double result = double.NaN;
			if (v != null && v.Length > 1)
			{
				result = global::NPOI.SS.Formula.Functions.StatsLib.devsq(v) / (double)v.Length;
			}
			return result;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x000219A0 File Offset: 0x0001FBA0
		public static double mode(double[] v)
		{
			double result = double.NaN;
			if (v != null && v.Length > 1)
			{
				int[] array = new int[v.Length];
				global::NPOI.Util.Arrays.Fill<int>(array, 1);
				int i = 0;
				int num = v.Length;
				while (i < num)
				{
					int j = i + 1;
					int num2 = v.Length;
					while (j < num2)
					{
						if (v[i] == v[j])
						{
							array[i]++;
						}
						j++;
					}
					i++;
				}
				double num3 = 0.0;
				int num4 = 0;
				int k = 0;
				int num5 = array.Length;
				while (k < num5)
				{
					if (array[k] > num4)
					{
						num3 = v[k];
						num4 = array[k];
					}
					k++;
				}
				result = ((num4 > 1) ? num3 : double.NaN);
			}
			return result;
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00021A64 File Offset: 0x0001FC64
		public static double median(double[] v)
		{
			double result = double.NaN;
			if (v != null && v.Length >= 1)
			{
				int num = v.Length;
				global::System.Array.Sort<double>(v);
				result = ((num % 2 == 0) ? ((v[num / 2] + v[num / 2 - 1]) / 2.0) : v[num / 2]);
			}
			return result;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00021AB4 File Offset: 0x0001FCB4
		public static double devsq(double[] v)
		{
			double result = double.NaN;
			if (v != null && v.Length >= 1)
			{
				double num = 0.0;
				int num2 = v.Length;
				for (int i = 0; i < num2; i++)
				{
					num += v[i];
				}
				double num3 = num / (double)num2;
				num = 0.0;
				for (int j = 0; j < num2; j++)
				{
					num += (v[j] - num3) * (v[j] - num3);
				}
				result = ((num2 == 1) ? 0.0 : num);
			}
			return result;
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x00021B44 File Offset: 0x0001FD44
		public static double kthLargest(double[] v, int k)
		{
			double result = double.NaN;
			k--;
			if (v != null && v.Length > k && k >= 0)
			{
				global::System.Array.Sort<double>(v);
				result = v[v.Length - k - 1];
			}
			return result;
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x00021B80 File Offset: 0x0001FD80
		public static double kthSmallest(double[] v, int k)
		{
			double result = double.NaN;
			k--;
			if (v != null && v.Length > k && k >= 0)
			{
				global::System.Array.Sort<double>(v);
				result = v[k];
			}
			return result;
		}
	}
}
