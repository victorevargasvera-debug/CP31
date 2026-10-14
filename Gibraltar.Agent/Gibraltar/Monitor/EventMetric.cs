using System;
using System.Collections.Generic;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B5 RID: 437
	internal class EventMetric : global::Gibraltar.Monitor.Metric, global::Loupe.Extensibility.Data.IEventMetric, global::Loupe.Extensibility.Data.IMetric
	{
		// Token: 0x060013D2 RID: 5074 RVA: 0x0003A4EC File Offset: 0x000386EC
		public EventMetric(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName, string instanceName) : this((global::Gibraltar.Monitor.EventMetricDefinition)definitions[global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName)], instanceName)
		{
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x0003A50C File Offset: 0x0003870C
		public EventMetric(global::Gibraltar.Monitor.EventMetricDefinition definition, string instanceName) : this(definition, new global::Gibraltar.Monitor.Internal.EventMetricPacket(definition.Packet, instanceName))
		{
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x0003A524 File Offset: 0x00038724
		internal EventMetric(global::Gibraltar.Monitor.EventMetricDefinition definition, global::Gibraltar.Monitor.Internal.EventMetricPacket packet) : base(definition, packet)
		{
			this.m_Samples = (global::Gibraltar.Monitor.EventMetricSampleCollection)base.Samples;
			this.m_MetricDefinition = definition;
			this.m_Packet = packet;
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x0003A550 File Offset: 0x00038750
		public static global::Gibraltar.Monitor.EventMetric AddOrGet(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName, string instanceName)
		{
			if (definitions == null)
			{
				throw new global::System.ArgumentNullException("definitions");
			}
			string key = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName);
			global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
			if (definitions.TryGetValue(key, out metricDefinition))
			{
				if (!(metricDefinition is global::Gibraltar.Monitor.EventMetricDefinition))
				{
					throw new global::System.ArgumentException("A metric already exists with the provided type, category, and counter name but it is not compatible with being an event metric.  Please use a different counter name.", "counterName");
				}
			}
			else
			{
				metricDefinition = new global::Gibraltar.Monitor.EventMetricDefinition(definitions, metricTypeName, categoryName, counterName);
				definitions.Add(metricDefinition);
			}
			string key2 = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName, instanceName);
			object @lock = ((global::Gibraltar.Monitor.MetricCollection)metricDefinition.Metrics).Lock;
			global::Loupe.Extensibility.Data.IMetric metric;
			lock (@lock)
			{
				if (!metricDefinition.Metrics.TryGetValue(key2, out metric))
				{
					metric = new global::Gibraltar.Monitor.EventMetric((global::Gibraltar.Monitor.EventMetricDefinition)metricDefinition, instanceName);
				}
			}
			return (global::Gibraltar.Monitor.EventMetric)metric;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x0003A618 File Offset: 0x00038818
		public static global::Gibraltar.Monitor.EventMetric AddOrGet(string metricTypeName, string categoryName, string counterName, string instanceName)
		{
			return global::Gibraltar.Monitor.EventMetric.AddOrGet(global::Gibraltar.Monitor.Log.Metrics, metricTypeName, categoryName, counterName, instanceName);
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x0003A628 File Offset: 0x00038828
		public static global::Gibraltar.Monitor.EventMetric AddOrGet(global::Gibraltar.Monitor.EventMetricDefinition definition, string instanceName)
		{
			return global::Gibraltar.Monitor.EventMetric.AddOrGet(global::Gibraltar.Monitor.Log.Metrics, definition.MetricTypeName, definition.CategoryName, definition.CounterName, instanceName);
		}

		// Token: 0x060013D8 RID: 5080 RVA: 0x0003A658 File Offset: 0x00038858
		public global::Gibraltar.Monitor.EventMetricSample CreateSample()
		{
			return new global::Gibraltar.Monitor.EventMetricSample(this, new global::Gibraltar.Monitor.Internal.EventMetricSamplePacket(this));
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x0003A668 File Offset: 0x00038868
		public int CompareTo(global::Gibraltar.Monitor.EventMetric other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x060013DA RID: 5082 RVA: 0x0003A674 File Offset: 0x00038874
		public bool Equals(global::Gibraltar.Monitor.EventMetric other)
		{
			return base.Equals(other);
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x060013DB RID: 5083 RVA: 0x0003A680 File Offset: 0x00038880
		public new global::Gibraltar.Monitor.EventMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x060013DC RID: 5084 RVA: 0x0003A688 File Offset: 0x00038888
		public new global::Gibraltar.Monitor.EventMetricSampleCollection Samples
		{
			get
			{
				return this.m_Samples;
			}
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0003A690 File Offset: 0x00038890
		public global::Loupe.Extensibility.Data.IMetricValueCollection CalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset? startDateTime, global::System.DateTimeOffset? endDateTime, global::Loupe.Extensibility.Data.IEventMetricValueDefinition trendValue)
		{
			global::System.DateTimeOffset startDateTime2 = (startDateTime == null) ? base.StartDateTime : startDateTime.Value;
			global::System.DateTimeOffset endDateTime2 = (endDateTime == null) ? base.EndDateTime : endDateTime.Value;
			return this.OnCalculateValues(interval, intervals, startDateTime2, endDateTime2, trendValue);
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x060013DE RID: 5086 RVA: 0x0003A6EC File Offset: 0x000388EC
		internal new global::Gibraltar.Monitor.Internal.EventMetricPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0003A6F4 File Offset: 0x000388F4
		internal override global::Gibraltar.Monitor.MetricSample OnMetricSampleRead(global::Gibraltar.Monitor.Internal.MetricSamplePacket packet)
		{
			return new global::Gibraltar.Monitor.EventMetricSample(this, (global::Gibraltar.Monitor.Internal.EventMetricSamplePacket)packet);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0003A704 File Offset: 0x00038904
		protected override global::Gibraltar.Monitor.MetricSampleCollection OnSampleCollectionCreate()
		{
			return new global::Gibraltar.Monitor.EventMetricSampleCollection(this);
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0003A70C File Offset: 0x0003890C
		protected override global::Gibraltar.Monitor.MetricValueCollection OnCalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime)
		{
			return this.OnCalculateValues(interval, intervals, startDateTime, endDateTime, this.Definition.DefaultValue);
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0003A734 File Offset: 0x00038934
		internal double CalculateSample(global::Gibraltar.Monitor.MetricValueCollection metricValueCollection, global::System.Collections.Generic.IList<global::Gibraltar.Monitor.EventMetricSample> samples, double previousValue, int previousCount, global::System.DateTimeOffset timeStamp, global::Gibraltar.Monitor.EventMetricValueDefinition trendValue)
		{
			double num;
			if (trendValue == null)
			{
				num = (double)samples.Count;
			}
			else if (!trendValue.IsTrendable || trendValue.DefaultTrend == global::Loupe.Extensibility.Data.EventMetricValueTrend.Count)
			{
				int num2 = 0;
				if (samples.Count > 0)
				{
					int num3 = this.Definition.Values.IndexOf(trendValue);
					using (global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.EventMetricSample> enumerator = samples.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							if (enumerator.Current.Values[num3] != null)
							{
								num2++;
							}
						}
					}
				}
				num = (double)num2;
			}
			else
			{
				double num4 = 0.0;
				int num5 = samples.Count;
				int valueIndex = this.Definition.Values.IndexOf(trendValue);
				if (trendValue.DefaultTrend == global::Loupe.Extensibility.Data.EventMetricValueTrend.RunningAverage || trendValue.DefaultTrend == global::Loupe.Extensibility.Data.EventMetricValueTrend.RunningSum)
				{
					num4 = previousValue;
					num5 += previousCount;
				}
				foreach (global::Gibraltar.Monitor.EventMetricSample eventMetricSample in samples)
				{
					num4 += eventMetricSample.GetEffectiveValue(valueIndex);
				}
				if (num5 > 1 && (trendValue.DefaultTrend == global::Loupe.Extensibility.Data.EventMetricValueTrend.Average || trendValue.DefaultTrend == global::Loupe.Extensibility.Data.EventMetricValueTrend.RunningAverage))
				{
					num = num4 / (double)num5;
				}
				else
				{
					num = num4;
				}
			}
			if (metricValueCollection != null)
			{
				new global::Gibraltar.Monitor.MetricValue(metricValueCollection, timeStamp, num);
			}
			return num;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0003A8B8 File Offset: 0x00038AB8
		private global::Gibraltar.Monitor.MetricValueCollection OnCalculateValues(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime, global::Loupe.Extensibility.Data.IEventMetricValueDefinition trendValue)
		{
			global::Gibraltar.Monitor.MetricValueCollection result;
			if (interval == global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest)
			{
				result = this.OnCalculateValuesShortest(startDateTime, endDateTime, trendValue);
			}
			else
			{
				if (intervals < 1)
				{
					throw new global::System.ArgumentOutOfRangeException("intervals", intervals, "The number of intervals must be positive and greater than zero.");
				}
				result = this.OnCalculateValuesInterval(interval, intervals, startDateTime, endDateTime, trendValue);
			}
			return result;
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x0003A910 File Offset: 0x00038B10
		private global::Gibraltar.Monitor.MetricValueCollection OnCalculateValuesShortest(global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime, global::Loupe.Extensibility.Data.IEventMetricValueDefinition trendValue)
		{
			string text = null;
			if (trendValue != null)
			{
				text = trendValue.UnitCaption;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = "Events";
			}
			global::Gibraltar.Monitor.MetricValueCollection metricValueCollection;
			if (trendValue == null)
			{
				metricValueCollection = new global::Gibraltar.Monitor.MetricValueCollection(this, global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest, 0, text);
			}
			else
			{
				metricValueCollection = new global::Gibraltar.Monitor.MetricValueCollection((global::Gibraltar.Monitor.EventMetricValueDefinition)trendValue, global::Loupe.Extensibility.Data.MetricSampleInterval.Shortest, 0, text);
			}
			double previousValue = 0.0;
			for (int i = 0; i < this.Samples.Count; i++)
			{
				global::Gibraltar.Monitor.EventMetricSample eventMetricSample = this.Samples[i];
				if (eventMetricSample.Timestamp >= startDateTime)
				{
					this.CalculateSample(metricValueCollection, new global::System.Collections.Generic.List<global::Gibraltar.Monitor.EventMetricSample>(new global::Gibraltar.Monitor.EventMetricSample[]
					{
						eventMetricSample
					}), previousValue, i, eventMetricSample.Timestamp, (global::Gibraltar.Monitor.EventMetricValueDefinition)trendValue);
				}
				else if (eventMetricSample.Timestamp > endDateTime)
				{
					break;
				}
			}
			return metricValueCollection;
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x0003A9E8 File Offset: 0x00038BE8
		private global::Gibraltar.Monitor.MetricValueCollection OnCalculateValuesInterval(global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, global::System.DateTimeOffset startDateTime, global::System.DateTimeOffset endDateTime, global::Loupe.Extensibility.Data.IEventMetricValueDefinition trendValue)
		{
			string text = null;
			if (trendValue != null)
			{
				text = trendValue.UnitCaption;
			}
			if (string.IsNullOrEmpty(text))
			{
				text = "Events";
			}
			global::Gibraltar.Monitor.MetricValueCollection metricValueCollection;
			if (trendValue == null)
			{
				metricValueCollection = new global::Gibraltar.Monitor.MetricValueCollection(this, interval, intervals, text);
			}
			else
			{
				metricValueCollection = new global::Gibraltar.Monitor.MetricValueCollection((global::Gibraltar.Monitor.EventMetricValueDefinition)trendValue, interval, intervals, text);
			}
			global::System.DateTimeOffset dateTimeOffset = startDateTime;
			global::System.DateTimeOffset dateTimeOffset2 = base.CalculateOffset(dateTimeOffset, interval, intervals);
			double previousValue = 0.0;
			int num = 0;
			while (dateTimeOffset < endDateTime)
			{
				global::System.Collections.Generic.List<global::Gibraltar.Monitor.EventMetricSample> list = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.EventMetricSample>();
				for (int i = num; i < this.Samples.Count; i++)
				{
					global::Gibraltar.Monitor.EventMetricSample eventMetricSample = this.Samples[i];
					if (eventMetricSample.Timestamp < dateTimeOffset || eventMetricSample.Timestamp > dateTimeOffset2)
					{
						num = i;
						break;
					}
					list.Add(eventMetricSample);
				}
				previousValue = this.CalculateSample(metricValueCollection, list, previousValue, num, dateTimeOffset2, (global::Gibraltar.Monitor.EventMetricValueDefinition)trendValue);
				dateTimeOffset = dateTimeOffset2;
				dateTimeOffset2 = base.CalculateOffset(dateTimeOffset2, interval, intervals);
				if (dateTimeOffset2 > endDateTime)
				{
					dateTimeOffset2 = endDateTime;
				}
			}
			return metricValueCollection;
		}

		// Token: 0x04000697 RID: 1687
		private readonly global::Gibraltar.Monitor.EventMetricSampleCollection m_Samples;

		// Token: 0x04000698 RID: 1688
		private readonly global::Gibraltar.Monitor.EventMetricDefinition m_MetricDefinition;

		// Token: 0x04000699 RID: 1689
		private readonly global::Gibraltar.Monitor.Internal.EventMetricPacket m_Packet;
	}
}
