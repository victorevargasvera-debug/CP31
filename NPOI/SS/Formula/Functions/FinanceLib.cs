using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000187 RID: 391
	public class FinanceLib
	{
		// Token: 0x06000B2E RID: 2862 RVA: 0x0000253E File Offset: 0x0000073E
		private FinanceLib()
		{
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0001E46C File Offset: 0x0001C66C
		public static double fv(double r, double n, double y, double p, bool t)
		{
			double result;
			if (r == 0.0)
			{
				result = -1.0 * (p + n * y);
			}
			else
			{
				double num = r + 1.0;
				result = (1.0 - global::System.Math.Pow(num, n)) * (t ? num : 1.0) * y / r - p * global::System.Math.Pow(num, n);
			}
			return result;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x0001E4E0 File Offset: 0x0001C6E0
		public static double pv(double r, double n, double y, double f, bool t)
		{
			double result;
			if (r == 0.0)
			{
				result = -1.0 * (n * y + f);
			}
			else
			{
				double num = r + 1.0;
				result = ((1.0 - global::System.Math.Pow(num, n)) / r * (t ? num : 1.0) * y - f) / global::System.Math.Pow(num, n);
			}
			return result;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0001E554 File Offset: 0x0001C754
		public static double npv(double r, double[] cfs)
		{
			double num = 0.0;
			double num2 = r + 1.0;
			double num3 = num2;
			int i = 0;
			int num4 = cfs.Length;
			while (i < num4)
			{
				num += cfs[i] / num3;
				num3 *= num2;
				i++;
			}
			return num;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0001E598 File Offset: 0x0001C798
		public static double pmt(double r, double n, double p, double f, bool t)
		{
			double result;
			if (r == 0.0)
			{
				result = -1.0 * (f + p) / n;
			}
			else
			{
				double num = r + 1.0;
				result = (f + p * global::System.Math.Pow(num, n)) * r / ((t ? num : 1.0) * (1.0 - global::System.Math.Pow(num, n)));
			}
			return result;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0001E60C File Offset: 0x0001C80C
		public static double nper(double r, double y, double p, double f, bool t)
		{
			double result;
			if (r == 0.0)
			{
				result = -1.0 * (f + p) / y;
			}
			else
			{
				double num = r + 1.0;
				double num2 = (t ? num : 1.0) * y / r;
				double num3 = (num2 - f < 0.0) ? global::System.Math.Log(f - num2) : global::System.Math.Log(num2 - f);
				double num4 = (num2 - f < 0.0) ? global::System.Math.Log(-p - num2) : global::System.Math.Log(p + num2);
				double num5 = global::System.Math.Log(num);
				result = (num3 - num4) / num5;
			}
			return result;
		}
	}
}
