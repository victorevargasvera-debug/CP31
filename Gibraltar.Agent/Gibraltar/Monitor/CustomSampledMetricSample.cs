using System;
using System.Globalization;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B1 RID: 433
	internal sealed class CustomSampledMetricSample : global::Gibraltar.Monitor.SampledMetricSample, global::System.IComparable<global::Gibraltar.Monitor.CustomSampledMetricSample>, global::System.IEquatable<global::Gibraltar.Monitor.CustomSampledMetricSample>
	{
		// Token: 0x06001383 RID: 4995 RVA: 0x000393CC File Offset: 0x000375CC
		internal CustomSampledMetricSample(global::Gibraltar.Monitor.CustomSampledMetric metric, global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket metricSamplePacket) : base(metric, metricSamplePacket, metric.Definition.RequiresMultipleSamples)
		{
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x000393F0 File Offset: 0x000375F0
		public override double ComputeValue(global::Gibraltar.Monitor.SampledMetricSample baselineSample)
		{
			if (baselineSample == null && base.RequiresMultipleSamples)
			{
				throw new global::System.ArgumentNullException("baselineSample", "A baseline metric sample is required and none was provided.");
			}
			if (baselineSample != null && baselineSample.Timestamp > this.Timestamp)
			{
				throw new global::System.ArgumentOutOfRangeException("baselineSample", baselineSample.Timestamp, "The baseline sample must be for a date & time before this sample to be valid for comparison.");
			}
			global::Gibraltar.Monitor.MetricSampleType metricSampleType = this.Metric.Definition.MetricSampleType;
			if (!base.RequiresMultipleSamples)
			{
				return this.Value;
			}
			global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket customSampledMetricSamplePacket = (global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket)baselineSample.Packet;
			double result;
			if (metricSampleType == global::Gibraltar.Monitor.MetricSampleType.TotalCount)
			{
				result = this.Packet.RawValue - customSampledMetricSamplePacket.RawValue;
			}
			else if (metricSampleType == global::Gibraltar.Monitor.MetricSampleType.TotalFraction)
			{
				double num = this.Packet.RawValue - customSampledMetricSamplePacket.RawValue;
				double num2 = this.Packet.BaseValue - customSampledMetricSamplePacket.BaseValue;
				if (num2 == 0.0 && num != 0.0)
				{
					throw new global::System.DivideByZeroException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The baseline delta is zero however the value delta is not, indicating a data collection problem in the original data.  Value delta: {0}", new object[]
					{
						num
					}));
				}
				result = num / num2;
			}
			else if (metricSampleType == global::Gibraltar.Monitor.MetricSampleType.IncrementalCount)
			{
				result = this.Value;
			}
			else if (metricSampleType == global::Gibraltar.Monitor.MetricSampleType.IncrementalFraction)
			{
				double value = this.Value;
				double baseValue = this.BaseValue;
				if (baseValue == 0.0 && value != 0.0)
				{
					throw new global::System.DivideByZeroException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The baseline value is zero however the value is not, indicating a data collection problem in the original data.  Value: {0}", new object[]
					{
						value
					}));
				}
				result = value / baseValue;
			}
			else
			{
				global::Gibraltar.Monitor.CustomSampledMetricSample baselineSample2 = (global::Gibraltar.Monitor.CustomSampledMetricSample)baselineSample;
				if (metricSampleType == global::Gibraltar.Monitor.MetricSampleType.RawCount)
				{
					global::Gibraltar.Monitor.CustomSampledMetricSample[] sampleRange = this.SampleRange(baselineSample2);
					result = this.CalculateWeightedAverageValue(sampleRange);
				}
				else
				{
					if (metricSampleType != global::Gibraltar.Monitor.MetricSampleType.RawFraction)
					{
						throw new global::System.ArgumentOutOfRangeException();
					}
					global::Gibraltar.Monitor.CustomSampledMetricSample[] sampleRange2 = this.SampleRange(baselineSample2);
					double num3 = this.CalculateWeightedAverageValue(sampleRange2);
					double num4 = this.CalculateWeightedAverageBaseValue(sampleRange2);
					if (num4 == 0.0 && num3 != 0.0)
					{
						throw new global::System.DivideByZeroException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "The baseline value is zero however the value is not, indicating a data collection problem in the original data.  Value: {0}", new object[]
						{
							num3
						}));
					}
					result = num3 / num4;
				}
			}
			return result;
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x0003964C File Offset: 0x0003784C
		public new global::Gibraltar.Monitor.CustomSampledMetric Metric
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetric)base.Metric;
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x0003965C File Offset: 0x0003785C
		public int CompareTo(global::Gibraltar.Monitor.CustomSampledMetricSample other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00039668 File Offset: 0x00037868
		public bool Equals(global::Gibraltar.Monitor.CustomSampledMetricSample other)
		{
			return base.Equals(other);
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x00039674 File Offset: 0x00037874
		public double BaseValue
		{
			get
			{
				switch (this.Metric.Definition.MetricSampleType)
				{
				case global::Gibraltar.Monitor.MetricSampleType.RawCount:
				case global::Gibraltar.Monitor.MetricSampleType.IncrementalCount:
				case global::Gibraltar.Monitor.MetricSampleType.TotalCount:
					throw new global::System.ArgumentException("Base values are not available for metrics that are not fractions.");
				case global::Gibraltar.Monitor.MetricSampleType.RawFraction:
				case global::Gibraltar.Monitor.MetricSampleType.IncrementalFraction:
				case global::Gibraltar.Monitor.MetricSampleType.TotalFraction:
					if (this.m_BaseValue == null)
					{
						int num = this.Metric.Samples.IndexOf(this);
						if (num == 0)
						{
							this.m_BaseValue = new double?(this.Packet.BaseValue);
						}
						else
						{
							global::Gibraltar.Monitor.CustomSampledMetricSample customSampledMetricSample = this.Metric.Samples[num - 1];
							this.m_BaseValue = new double?(customSampledMetricSample.BaseValue + this.Packet.BaseValue);
						}
					}
					return this.m_BaseValue.Value;
				default:
					throw new global::System.ArgumentOutOfRangeException();
				}
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001389 RID: 5001 RVA: 0x0003974C File Offset: 0x0003794C
		public new double Value
		{
			get
			{
				double result;
				switch (this.Metric.Definition.MetricSampleType)
				{
				case global::Gibraltar.Monitor.MetricSampleType.RawCount:
				case global::Gibraltar.Monitor.MetricSampleType.RawFraction:
					result = this.Packet.RawValue;
					break;
				case global::Gibraltar.Monitor.MetricSampleType.IncrementalCount:
				case global::Gibraltar.Monitor.MetricSampleType.IncrementalFraction:
					if (this.m_Value == null)
					{
						int num = this.Metric.Samples.IndexOf(this);
						if (num == 0)
						{
							this.m_Value = new double?(this.Packet.RawValue);
						}
						else
						{
							global::Gibraltar.Monitor.CustomSampledMetricSample customSampledMetricSample = this.Metric.Samples[num - 1];
							this.m_Value = new double?(customSampledMetricSample.Value + this.Packet.RawValue);
						}
					}
					result = this.m_Value.Value;
					break;
				case global::Gibraltar.Monitor.MetricSampleType.TotalCount:
				case global::Gibraltar.Monitor.MetricSampleType.TotalFraction:
					if (this.m_Value == null)
					{
						int num2 = this.Metric.Samples.IndexOf(this);
						if (num2 == 0)
						{
							this.m_Value = new double?(this.Packet.RawValue);
						}
						else
						{
							global::Gibraltar.Monitor.CustomSampledMetricSample customSampledMetricSample2 = this.Metric.Samples[num2 - 1];
							this.m_Value = new double?(this.Packet.RawValue - customSampledMetricSample2.Packet.RawValue);
						}
					}
					result = this.m_Value.Value;
					break;
				default:
					throw new global::System.ArgumentOutOfRangeException();
				}
				return result;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000398C0 File Offset: 0x00037AC0
		internal new global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket)base.Packet;
			}
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x000398D0 File Offset: 0x00037AD0
		private static double WeightedAverage(double[] basis, global::System.TimeSpan[] weight)
		{
			double num = 0.0;
			global::System.TimeSpan t = new global::System.TimeSpan(0L);
			foreach (global::System.TimeSpan t2 in weight)
			{
				t += t2;
			}
			for (int j = 0; j < basis.Length; j++)
			{
				num += basis[j] * (weight[j].TotalMilliseconds / t.TotalMilliseconds);
			}
			return num;
		}

		// Token: 0x0600138C RID: 5004 RVA: 0x0003994C File Offset: 0x00037B4C
		private global::Gibraltar.Monitor.CustomSampledMetricSample[] SampleRange(global::Gibraltar.Monitor.CustomSampledMetricSample baselineSample)
		{
			if (baselineSample == this)
			{
				return new global::Gibraltar.Monitor.CustomSampledMetricSample[]
				{
					baselineSample
				};
			}
			global::Gibraltar.Monitor.CustomSampledMetricSampleCollection samples = this.Metric.Samples;
			int num = samples.IndexOf(baselineSample);
			int num2 = samples.IndexOf(this);
			if (num < 0 || num2 < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("baselineSample", "Unable to use the provided baseline because either it or our sample are not in the same sample collection.");
			}
			if (num > num2)
			{
				throw new global::System.ArgumentOutOfRangeException("baselineSample", "Unable to use the provided baseline because it is later than our sample in the samples collection, indicating they are in the wrong order.");
			}
			if (num2 < samples.Count - 1 && this.Packet.RawTimestamp != this.Timestamp)
			{
				num2++;
			}
			global::Gibraltar.Monitor.CustomSampledMetricSample[] array = new global::Gibraltar.Monitor.CustomSampledMetricSample[num2 - num + 1];
			for (int i = num; i <= num2; i++)
			{
				array[i - num] = samples[i];
			}
			return array;
		}

		// Token: 0x0600138D RID: 5005 RVA: 0x00039A2C File Offset: 0x00037C2C
		private double CalculateWeightedAverageValue(global::Gibraltar.Monitor.CustomSampledMetricSample[] sampleRange)
		{
			global::Gibraltar.Monitor.CustomSampledMetricSample customSampledMetricSample = sampleRange[0];
			double[] array = new double[sampleRange.Length];
			global::System.TimeSpan[] array2 = new global::System.TimeSpan[sampleRange.Length];
			for (int i = 1; i < sampleRange.Length; i++)
			{
				array[i - 1] = sampleRange[i].Packet.RawValue - sampleRange[i - 1].Packet.RawValue;
				global::System.DateTimeOffset right = (sampleRange[i - 1].Packet.RawTimestamp < customSampledMetricSample.Packet.Timestamp) ? customSampledMetricSample.Packet.Timestamp : sampleRange[i - 1].Packet.RawTimestamp;
				global::System.DateTimeOffset left = (sampleRange[i].Packet.RawTimestamp < this.Timestamp) ? this.Timestamp : sampleRange[i].Packet.RawTimestamp;
				array2[i - 1] = left - right;
			}
			return global::Gibraltar.Monitor.CustomSampledMetricSample.WeightedAverage(array, array2);
		}

		// Token: 0x0600138E RID: 5006 RVA: 0x00039B3C File Offset: 0x00037D3C
		private double CalculateWeightedAverageBaseValue(global::Gibraltar.Monitor.CustomSampledMetricSample[] sampleRange)
		{
			global::Gibraltar.Monitor.CustomSampledMetricSample customSampledMetricSample = sampleRange[0];
			double[] array = new double[sampleRange.Length];
			global::System.TimeSpan[] array2 = new global::System.TimeSpan[sampleRange.Length];
			for (int i = 1; i < sampleRange.Length; i++)
			{
				array[i - 1] = sampleRange[i].Packet.BaseValue - sampleRange[i - 1].Packet.BaseValue;
				global::System.DateTimeOffset right = (sampleRange[i - 1].Packet.RawTimestamp < customSampledMetricSample.Packet.Timestamp) ? customSampledMetricSample.Packet.Timestamp : sampleRange[i - 1].Packet.RawTimestamp;
				global::System.DateTimeOffset left = (sampleRange[i].Packet.RawTimestamp < this.Timestamp) ? this.Timestamp : sampleRange[i].Packet.RawTimestamp;
				array2[i - 1] = left - right;
			}
			return global::Gibraltar.Monitor.CustomSampledMetricSample.WeightedAverage(array, array2);
		}

		// Token: 0x0400067F RID: 1663
		private double? m_Value;

		// Token: 0x04000680 RID: 1664
		private double? m_BaseValue;
	}
}
