using System;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001CD RID: 461
	internal abstract class SampledMetric : global::Gibraltar.Monitor.Metric
	{
		// Token: 0x060015F3 RID: 5619 RVA: 0x00042110 File Offset: 0x00040310
		internal SampledMetric(global::Gibraltar.Monitor.SampledMetricDefinition definition, global::Gibraltar.Monitor.Internal.SampledMetricPacket packet) : base(definition, packet)
		{
			this.m_MetricDefinition = definition;
			this.m_Packet = packet;
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x060015F4 RID: 5620 RVA: 0x00042128 File Offset: 0x00040328
		public new global::Gibraltar.Monitor.SampledMetricDefinition Definition
		{
			get
			{
				return (global::Gibraltar.Monitor.SampledMetricDefinition)base.Definition;
			}
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00042138 File Offset: 0x00040338
		protected override global::Gibraltar.Monitor.MetricValueCollection OnCalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime)
		{
			global::Gibraltar.Monitor.MetricValueCollection result;
			if (interval == global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest)
			{
				result = this.OnCalculateValuesShortest(startDateTime, endDateTime);
			}
			else
			{
				if (intervals < 1)
				{
					throw new global::System.ArgumentOutOfRangeException("intervals", intervals, "The number of intervals must be positive and greater than zero.");
				}
				result = this.OnCalculateValuesOnInterval(interval, intervals, startDateTime, endDateTime);
			}
			return result;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x0004218C File Offset: 0x0004038C
		private global::Gibraltar.Monitor.MetricValueCollection OnCalculateValuesOnInterval(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime)
		{
			global::Gibraltar.Monitor.MetricValueCollection metricValueCollection = new global::Gibraltar.Monitor.MetricValueCollection(this, interval, intervals, this.Definition.UnitCaption);
			global::System.TimeSpan timeSpan = global::Gibraltar.Monitor.Metric.CalculateOffsetTolerance(interval);
			global::System.DateTimeOffset right = startDateTime + timeSpan;
			global::Gibraltar.Monitor.SampledMetricSample sampledMetricSample = null;
			double value = 0.0;
			int num = 0;
			for (int i = 0; i < base.Samples.Count; i++)
			{
				global::Gibraltar.Monitor.SampledMetricSample sampledMetricSample2 = (global::Gibraltar.Monitor.SampledMetricSample)base.Samples[i];
				if (sampledMetricSample2.Timestamp == startDateTime || (sampledMetricSample2.Timestamp < right && base.Samples[i + 1].Timestamp > right))
				{
					if (sampledMetricSample2.RequiresMultipleSamples)
					{
						global::System.DateTimeOffset right2 = base.CalculateOffset(startDateTime, interval, -intervals);
						for (int j = i - 1; j >= 0; j--)
						{
							sampledMetricSample = (global::Gibraltar.Monitor.SampledMetricSample)base.Samples[i];
							if (sampledMetricSample.Timestamp <= right2)
							{
								break;
							}
						}
					}
					if (sampledMetricSample != null || !sampledMetricSample2.RequiresMultipleSamples)
					{
						value = global::Gibraltar.Monitor.SampledMetric.CalculateSample(metricValueCollection, sampledMetricSample, sampledMetricSample2, new global::System.DateTimeOffset?(startDateTime));
					}
					sampledMetricSample = sampledMetricSample2;
					num = i;
					break;
				}
			}
			num++;
			if (num < base.Samples.Count - 1)
			{
				global::System.DateTimeOffset dateTimeOffset = base.CalculateOffset(startDateTime, interval, intervals);
				right = dateTimeOffset + timeSpan;
				int num2 = num;
				global::Gibraltar.Monitor.SampledMetricSample sampledMetricSample3 = null;
				while (dateTimeOffset <= endDateTime && num2 < base.Samples.Count - 1)
				{
					if (sampledMetricSample3 == null)
					{
						sampledMetricSample3 = (global::Gibraltar.Monitor.SampledMetricSample)base.Samples[num2];
					}
					if (sampledMetricSample3.Timestamp == dateTimeOffset || (sampledMetricSample3.Timestamp < right && base.Samples[num2 + 1].Timestamp > right))
					{
						if (sampledMetricSample != null || !sampledMetricSample3.RequiresMultipleSamples)
						{
							value = global::Gibraltar.Monitor.SampledMetric.CalculateSample(metricValueCollection, sampledMetricSample, sampledMetricSample3, new global::System.DateTimeOffset?(dateTimeOffset));
						}
						sampledMetricSample = sampledMetricSample3;
						sampledMetricSample3 = null;
						num2++;
						dateTimeOffset = base.CalculateOffset(dateTimeOffset, interval, intervals);
						right = dateTimeOffset + timeSpan;
					}
					else if (sampledMetricSample3.Timestamp < right)
					{
						sampledMetricSample3 = null;
						num2++;
					}
					else
					{
						new global::Gibraltar.Monitor.MetricValue(metricValueCollection, dateTimeOffset, value);
						dateTimeOffset = base.CalculateOffset(dateTimeOffset, interval, intervals);
						right = dateTimeOffset + timeSpan;
					}
				}
			}
			return metricValueCollection;
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x00042420 File Offset: 0x00040620
		private global::Gibraltar.Monitor.MetricValueCollection OnCalculateValuesShortest(global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime)
		{
			global::Gibraltar.Monitor.MetricValueCollection metricValueCollection = new global::Gibraltar.Monitor.MetricValueCollection(this, global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest, 0, this.Definition.UnitCaption);
			global::Gibraltar.Monitor.SampledMetricSample sampledMetricSample = null;
			global::Gibraltar.Monitor.SampledMetricSample sampledMetricSample2 = null;
			foreach (global::Loupe.Extensibility.Data.IMetricSample metricSample in base.Samples)
			{
				global::Gibraltar.Monitor.SampledMetricSample sampledMetricSample3 = (global::Gibraltar.Monitor.SampledMetricSample)metricSample;
				if (sampledMetricSample3.Timestamp < startDateTime)
				{
					sampledMetricSample2 = sampledMetricSample;
					sampledMetricSample = sampledMetricSample3;
				}
				else if (sampledMetricSample3.Timestamp > endDateTime)
				{
					if (sampledMetricSample != null && sampledMetricSample.Timestamp < endDateTime)
					{
						global::Gibraltar.Monitor.SampledMetric.CalculateSample(metricValueCollection, sampledMetricSample, sampledMetricSample3, new global::System.DateTimeOffset?(endDateTime));
						break;
					}
					break;
				}
				else
				{
					if (sampledMetricSample != null && sampledMetricSample.Timestamp < startDateTime && sampledMetricSample3.Timestamp > startDateTime && (sampledMetricSample2 != null || !sampledMetricSample.RequiresMultipleSamples))
					{
						global::Gibraltar.Monitor.SampledMetric.CalculateSample(metricValueCollection, sampledMetricSample2, sampledMetricSample, new global::System.DateTimeOffset?(startDateTime));
					}
					if (sampledMetricSample != null || !sampledMetricSample3.RequiresMultipleSamples)
					{
						global::Gibraltar.Monitor.SampledMetric.CalculateSample(metricValueCollection, sampledMetricSample, sampledMetricSample3, null);
					}
					sampledMetricSample = sampledMetricSample3;
				}
			}
			return metricValueCollection;
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00042584 File Offset: 0x00040784
		private static double CalculateSample(global::Gibraltar.Monitor.MetricValueCollection metricValueCollection, global::Gibraltar.Monitor.SampledMetricSample baselineSample, global::Gibraltar.Monitor.SampledMetricSample valueSample, global::System.DateTimeOffset? timeStampOverride)
		{
			double num;
			if (!valueSample.RequiresMultipleSamples)
			{
				num = valueSample.ComputeValue();
			}
			else
			{
				num = valueSample.ComputeValue(baselineSample);
			}
			global::System.DateTimeOffset timeStamp = (timeStampOverride == null) ? valueSample.Timestamp : timeStampOverride.Value;
			new global::Gibraltar.Monitor.MetricValue(metricValueCollection, timeStamp, num);
			return num;
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x000425E0 File Offset: 0x000407E0
		internal new global::Gibraltar.Monitor.Internal.SampledMetricPacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.SampledMetricPacket)base.Packet;
			}
		}

		// Token: 0x04000712 RID: 1810
		private readonly global::Gibraltar.Monitor.SampledMetricDefinition m_MetricDefinition;

		// Token: 0x04000713 RID: 1811
		private readonly global::Gibraltar.Monitor.Internal.SampledMetricPacket m_Packet;
	}
}
