using System;
using System.Diagnostics;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000021 RID: 33
	public sealed class EventMetricSample : global::System.IComparable<global::Gibraltar.Agent.Metrics.EventMetricSample>, global::System.IEquatable<global::Gibraltar.Agent.Metrics.EventMetricSample>
	{
		// Token: 0x060001F5 RID: 501 RVA: 0x00007558 File Offset: 0x00005758
		internal EventMetricSample(global::Gibraltar.Agent.Metrics.EventMetric metric, global::Gibraltar.Monitor.EventMetricSample metricSample)
		{
			this.m_Metric = metric;
			this.m_WrappedSample = metricSample;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00007570 File Offset: 0x00005770
		public void SetValue(string name, object value)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentNullException("name");
			}
			global::Gibraltar.Agent.Metrics.EventMetricValueDefinition valueDefinition;
			if (!this.Metric.Definition.ValueCollection.TryGetValue(name, out valueDefinition))
			{
				global::System.Diagnostics.Trace.TraceWarning("Unable to add metric value to the current sample because there is no value definition named {1} for metric definition {0}", new object[]
				{
					this.Metric.Definition.Key,
					name
				});
				return;
			}
			this.SetValue(valueDefinition, value);
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x000075E4 File Offset: 0x000057E4
		public void SetValue(global::Gibraltar.Agent.Metrics.EventMetricValueDefinition valueDefinition, object value)
		{
			if (valueDefinition == null)
			{
				throw new global::System.ArgumentNullException("valueDefinition");
			}
			this.m_WrappedSample.SetValue(valueDefinition.WrappedValueDefinition, value);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000760C File Offset: 0x0000580C
		public void SetValue(int valueIndex, object value)
		{
			global::Gibraltar.Agent.Metrics.EventMetricValueDefinitionCollection valueCollection = this.Metric.Definition.ValueCollection;
			if (valueIndex < 0 || valueIndex >= valueCollection.Count)
			{
				global::System.Diagnostics.Trace.TraceWarning("Unable to add metric value to the current sample because there is no value definition at index {1} for metric definition {0}", new object[]
				{
					this.Metric.Definition.Key,
					valueIndex
				});
				return;
			}
			global::Gibraltar.Agent.Metrics.EventMetricValueDefinition valueDefinition = valueCollection[valueIndex];
			this.SetValue(valueDefinition, value);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00007680 File Offset: 0x00005880
		public global::Gibraltar.Agent.Metrics.EventMetric Metric
		{
			get
			{
				return this.m_Metric;
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00007688 File Offset: 0x00005888
		public double GetValue()
		{
			return this.m_WrappedSample.Value;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00007698 File Offset: 0x00005898
		public object[] GetValues()
		{
			object[] values = this.m_WrappedSample.Values;
			if (values == null)
			{
				return new object[0];
			}
			object[] array = new object[values.Length];
			for (int i = 0; i < values.Length; i++)
			{
				array[i] = values[i];
			}
			return array;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000076E4 File Offset: 0x000058E4
		public int CompareTo(global::Gibraltar.Agent.Metrics.EventMetricSample other)
		{
			return this.WrappedSample.CompareTo(other.WrappedSample);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000076F8 File Offset: 0x000058F8
		public bool Equals(global::Gibraltar.Agent.Metrics.EventMetricSample other)
		{
			return this.WrappedSample.Equals(other.WrappedSample);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000770C File Offset: 0x0000590C
		public void Write()
		{
			this.m_WrappedSample.Write();
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000771C File Offset: 0x0000591C
		public override bool Equals(object obj)
		{
			global::Gibraltar.Agent.Metrics.EventMetricSample other = obj as global::Gibraltar.Agent.Metrics.EventMetricSample;
			return this.Equals(other);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000773C File Offset: 0x0000593C
		public override int GetHashCode()
		{
			return this.m_WrappedSample.GetHashCode();
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000774C File Offset: 0x0000594C
		internal global::Gibraltar.Monitor.EventMetricSample WrappedSample
		{
			get
			{
				return this.m_WrappedSample;
			}
		}

		// Token: 0x0400006F RID: 111
		private readonly global::Gibraltar.Agent.Metrics.EventMetric m_Metric;

		// Token: 0x04000070 RID: 112
		private readonly global::Gibraltar.Monitor.EventMetricSample m_WrappedSample;
	}
}
