using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Charts
{
	// Token: 0x0200000D RID: 13
	public static class TrendCalculators
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00003EFC File Offset: 0x000020FC
		public static global::System.Collections.Generic.IEnumerable<double> WMA(global::System.Collections.Generic.IEnumerable<double> sequence, int period)
		{
			double[] buffer = new double[period];
			int i = 0;
			for (i = 0; i < period; i++)
			{
				buffer[i] = 0.0;
			}
			double total = double.NaN;
			double numerator = double.NaN;
			double weightsum = double.NaN;
			double wma = double.NaN;
			i = 0;
			foreach (double num in sequence)
			{
				double value = num;
				if (!double.IsNaN(value))
				{
					int num2 = i % period;
					if (i == 0)
					{
						weightsum = 1.0;
						wma = (numerator = (total = value));
					}
					else if (i < period)
					{
						weightsum += (double)(i + 1);
						total += value;
						numerator += (double)(i + 1) * value;
						wma = numerator / weightsum;
					}
					else
					{
						numerator = numerator + (double)period * value - total;
						wma = numerator / weightsum;
						total = total + value - buffer[num2];
					}
					buffer[num2] = value;
					i++;
				}
				yield return wma;
			}
			yield break;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00004190 File Offset: 0x00002390
		public static global::System.Collections.Generic.IEnumerable<double> EMA(global::System.Collections.Generic.IEnumerable<double> sequence, int period)
		{
			int i = 0;
			double ema = double.NaN;
			double alpha = 2.0 / (1.0 + (double)period);
			foreach (double num in sequence)
			{
				double value = num;
				if (!double.IsNaN(value))
				{
					if (i < period)
					{
						ema = (double.IsNaN(ema) ? value : ((ema * (double)i + value) / (double)(i + 1)));
					}
					else
					{
						ema = (value - ema) * alpha + ema;
					}
					i++;
				}
				yield return ema;
			}
			yield break;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004418 File Offset: 0x00002618
		public static global::System.Collections.Generic.IEnumerable<double> MMA(global::System.Collections.Generic.IEnumerable<double> sequence, int period)
		{
			int i = 0;
			double mma = double.NaN;
			double alpha = 1.0 / (double)period;
			foreach (double num in sequence)
			{
				double value = num;
				if (!double.IsNaN(value))
				{
					if (i < period)
					{
						mma = (double.IsNaN(mma) ? value : ((mma * (double)i + value) / (double)(i + 1)));
					}
					else
					{
						mma = (value - mma) * alpha + mma;
					}
					i++;
				}
				yield return mma;
			}
			yield break;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004640 File Offset: 0x00002840
		public static global::System.Collections.Generic.IEnumerable<double> CMA(global::System.Collections.Generic.IEnumerable<double> sequence)
		{
			double cma = double.NaN;
			int i = 0;
			foreach (double num in sequence)
			{
				double value = num;
				if (!double.IsNaN(value))
				{
					cma = (double.IsNaN(cma) ? value : ((cma * (double)i + value) / (double)(i + 1)));
					i++;
				}
				yield return cma;
			}
			yield break;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00004928 File Offset: 0x00002B28
		public static global::System.Collections.Generic.IEnumerable<double> SMA(global::System.Collections.Generic.IEnumerable<double> sequence, int period)
		{
			double[] buffer = new double[period];
			int i = 0;
			for (i = 0; i < period; i++)
			{
				buffer[i] = 0.0;
			}
			i = 0;
			double sma = double.NaN;
			foreach (double num in sequence)
			{
				double value = num;
				if (!double.IsNaN(value))
				{
					double num2 = value / (double)period;
					int num3 = i % period;
					if (i < period)
					{
						sma = (double.IsNaN(sma) ? value : ((sma * (double)i + value) / ((double)i + 1.0)));
					}
					else
					{
						sma = sma + num2 - buffer[num3];
					}
					buffer[num3] = num2;
					i++;
				}
				yield return sma;
			}
			yield break;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004BE4 File Offset: 0x00002DE4
		public static global::System.Collections.Generic.IEnumerable<double> MovingSum(global::System.Collections.Generic.IEnumerable<double> sequence, int period)
		{
			double[] buffer = new double[period];
			int i = 0;
			for (i = 0; i < period; i++)
			{
				buffer[i] = 0.0;
			}
			i = 0;
			double ms = double.NaN;
			foreach (double num in sequence)
			{
				double value = num;
				if (!double.IsNaN(value))
				{
					double num2 = value;
					int num3 = i % period;
					if (i < period)
					{
						ms = (double.IsNaN(ms) ? num2 : (ms + num2));
					}
					else
					{
						ms = ms + num2 - buffer[num3];
					}
					buffer[num3] = num2;
					i++;
				}
				yield return ms;
			}
			yield break;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004EAC File Offset: 0x000030AC
		public static global::System.Collections.Generic.IEnumerable<double> STDEV(global::System.Collections.Generic.IEnumerable<double> sequence, int period)
		{
			global::System.Collections.Generic.IEnumerator<double> sma = global::Infragistics.Controls.Charts.TrendCalculators.SMA(sequence, period).GetEnumerator();
			global::System.Collections.Generic.IEnumerator<double> price = sequence.GetEnumerator();
			double[] buffer = new double[period];
			int i = 0;
			for (i = 0; i < period; i++)
			{
				buffer[i] = 0.0;
			}
			i = 0;
			while (price.MoveNext() && sma.MoveNext())
			{
				double[] array = buffer;
				int num;
				i = (num = i) + 1;
				array[num % period] = price.Current;
				double S = 0.0;
				if (i < period)
				{
					int effectivePeriod = 0;
					for (int j = 0; j < i; j++)
					{
						double num2 = sma.Current - buffer[j];
						S += num2 * num2;
						effectivePeriod++;
					}
					yield return global::System.Math.Sqrt(S / (double)effectivePeriod);
				}
				else
				{
					for (int k = 0; k < period; k++)
					{
						double num3 = sma.Current - buffer[k];
						S += num3 * num3;
					}
					yield return global::System.Math.Sqrt(S / (double)period);
				}
			}
			yield break;
		}
	}
}
