using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B7 RID: 439
	internal class EventMetricSample : global::Gibraltar.Monitor.MetricSample, global::System.IComparable<global::Gibraltar.Monitor.EventMetricSample>, global::System.IEquatable<global::Gibraltar.Monitor.EventMetricSample>, global::Loupe.Extensibility.Data.IEventMetricSample, global::Loupe.Extensibility.Data.IMetricSample, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricSample>
	{
		// Token: 0x060013F0 RID: 5104 RVA: 0x0003AD14 File Offset: 0x00038F14
		internal EventMetricSample(global::Gibraltar.Monitor.EventMetric metric, global::Gibraltar.Monitor.Internal.EventMetricSamplePacket metricSamplePacket) : base(metric, metricSamplePacket)
		{
			metric.Definition.IsReadOnly = true;
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x0003AD2C File Offset: 0x00038F2C
		public void SetValue(string name, object value)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentNullException("name");
			}
			global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition;
			if (!this.Metric.Definition.Values.TryGetValue(name, out eventMetricValueDefinition))
			{
				global::System.Diagnostics.Trace.TraceWarning("Unable to add metric value to the current sample because there is no value definition named {1} for metric definition {0}", new object[]
				{
					this.Metric.Definition.Name,
					name
				});
				return;
			}
			this.SetValue((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition, value);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x0003ADA8 File Offset: 0x00038FA8
		public void SetValue(global::Gibraltar.Monitor.EventMetricValueDefinition valueDefinition, object value)
		{
			if (valueDefinition == null)
			{
				throw new global::System.ArgumentNullException("valueDefinition");
			}
			int num = this.Metric.Definition.Values.IndexOf(valueDefinition);
			if (num < 0)
			{
				global::System.Diagnostics.Trace.TraceWarning("Unable to add metric value to the current sample because there is no value definition named {1} for metric definition {0}", new object[]
				{
					this.Metric.Definition.Name,
					valueDefinition.Name
				});
				return;
			}
			object obj;
			if (value == null)
			{
				obj = null;
			}
			else
			{
				global::System.Type type = value.GetType();
				if (valueDefinition.IsTrendable)
				{
					if (global::Gibraltar.Monitor.EventMetricDefinition.IsTrendableValueType(type))
					{
						obj = value;
					}
					else
					{
						obj = null;
					}
				}
				else
				{
					obj = value.ToString();
				}
			}
			this.Packet.Values[num] = obj;
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x0003AE64 File Offset: 0x00039064
		public void SetValue(int valueIndex, object value)
		{
			global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection values = this.Metric.Definition.Values;
			if (valueIndex < 0 || valueIndex > values.Count - 1)
			{
				global::System.Diagnostics.Trace.TraceWarning("Unable to add metric value to the current sample because there is no value definition at index {1} for metric definition {0}", new object[]
				{
					this.Metric.Definition.Name,
					valueIndex
				});
				return;
			}
			global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition = values[valueIndex];
			this.SetValue((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition, value);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x0003AEE0 File Offset: 0x000390E0
		internal double GetEffectiveValue(int valueIndex)
		{
			object obj = this.Values[valueIndex];
			double result;
			if (obj == null)
			{
				result = 0.0;
			}
			else if (obj is global::System.TimeSpan)
			{
				result = ((global::System.TimeSpan)obj).TotalMilliseconds;
			}
			else if (obj is global::System.DateTimeOffset || obj is global::System.DateTime)
			{
				result = 1.0;
			}
			else
			{
				result = global::System.Convert.ToDouble(obj, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			return result;
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x0003AF60 File Offset: 0x00039160
		public new global::Gibraltar.Monitor.EventMetric Metric
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetric)base.Metric;
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0003AF70 File Offset: 0x00039170
		internal new global::Gibraltar.Monitor.Internal.EventMetricSamplePacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.EventMetricSamplePacket)base.Packet;
			}
		}

		// Token: 0x1700072B RID: 1835
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x0003AF80 File Offset: 0x00039180
		public override double Value
		{
			get
			{
				global::Loupe.Extensibility.Data.IEventMetricValueDefinition defaultValue = this.Metric.Definition.DefaultValue;
				double result;
				if (defaultValue == null)
				{
					result = 1.0;
				}
				else if (defaultValue.IsTrendable)
				{
					int num = this.Metric.Definition.Values.IndexOf(defaultValue);
					if (this.Values[num] == null)
					{
						result = double.NaN;
					}
					else
					{
						result = this.GetEffectiveValue(num);
					}
				}
				else
				{
					result = double.NaN;
				}
				return result;
			}
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0003B010 File Offset: 0x00039210
		public double ComputeValue(global::Loupe.Extensibility.Data.IEventMetricSample baselineSample, global::Loupe.Extensibility.Data.IEventMetricValueDefinition trendValue)
		{
			global::System.Collections.Generic.List<global::Gibraltar.Monitor.EventMetricSample> list = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.EventMetricSample>();
			global::Gibraltar.Monitor.EventMetricSampleCollection samples = this.Metric.Samples;
			int num = (baselineSample == null) ? 0 : samples.IndexOf(baselineSample);
			int num2 = samples.IndexOf(this);
			for (int i = num; i <= num2; i++)
			{
				list.Add(samples[i]);
			}
			return this.Metric.CalculateSample(null, list, 0.0, 0, this.Timestamp, (global::Gibraltar.Monitor.EventMetricValueDefinition)trendValue);
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x0003B08C File Offset: 0x0003928C
		public object[] Values
		{
			get
			{
				return this.Packet.Values;
			}
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0003B09C File Offset: 0x0003929C
		public int CompareTo(global::Gibraltar.Monitor.EventMetricSample other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x060013FB RID: 5115 RVA: 0x0003B0A8 File Offset: 0x000392A8
		public bool Equals(global::Gibraltar.Monitor.EventMetricSample other)
		{
			return base.Equals(other);
		}
	}
}
