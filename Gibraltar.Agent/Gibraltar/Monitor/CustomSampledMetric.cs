using System;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001B2 RID: 434
	internal sealed class CustomSampledMetric : global::Gibraltar.Monitor.SampledMetric, global::System.IComparable<global::Gibraltar.Monitor.CustomSampledMetric>, global::System.IEquatable<global::Gibraltar.Monitor.CustomSampledMetric>
	{
		// Token: 0x0600138F RID: 5007 RVA: 0x00039C4C File Offset: 0x00037E4C
		public CustomSampledMetric(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName, string instanceName) : this((global::Gibraltar.Monitor.CustomSampledMetricDefinition)definitions[global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName)], instanceName)
		{
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x00039C6C File Offset: 0x00037E6C
		public CustomSampledMetric(global::Gibraltar.Monitor.CustomSampledMetricDefinition definition, string instanceName) : this(definition, new global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket(definition.Packet, instanceName))
		{
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x00039C84 File Offset: 0x00037E84
		internal CustomSampledMetric(global::Gibraltar.Monitor.CustomSampledMetricDefinition definition, global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket packet) : base(definition, packet)
		{
			this.m_Samples = (global::Gibraltar.Monitor.CustomSampledMetricSampleCollection)base.Samples;
			this.m_MetricDefinition = definition;
			this.m_Packet = packet;
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00039CB0 File Offset: 0x00037EB0
		public static global::Gibraltar.Monitor.CustomSampledMetric AddOrGet(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType, string instanceName)
		{
			if (definitions == null)
			{
				throw new global::System.ArgumentNullException("definitions");
			}
			string key = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName);
			object @lock = definitions.Lock;
			global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
			lock (@lock)
			{
				if (definitions.TryGetValue(key, out metricDefinition))
				{
					if (!(metricDefinition is global::Gibraltar.Monitor.CustomSampledMetricDefinition))
					{
						throw new global::System.ArgumentException("A metric already exists with the provided type, category, and counter name but it is not compatible with being a custom sampled metric.  Please use a different counter name.", "counterName");
					}
				}
				else
				{
					metricDefinition = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(definitions, metricTypeName, categoryName, counterName, metricSampleType);
				}
			}
			string key2 = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName, instanceName);
			@lock = ((global::Gibraltar.Monitor.MetricCollection)metricDefinition.Metrics).Lock;
			global::Loupe.Extensibility.Data.IMetric metric;
			lock (@lock)
			{
				if (!metricDefinition.Metrics.TryGetValue(key2, out metric))
				{
					metric = new global::Gibraltar.Monitor.CustomSampledMetric((global::Gibraltar.Monitor.CustomSampledMetricDefinition)metricDefinition, instanceName);
				}
			}
			return (global::Gibraltar.Monitor.CustomSampledMetric)metric;
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00039D98 File Offset: 0x00037F98
		public static global::Gibraltar.Monitor.CustomSampledMetric AddOrGet(string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType, string instanceName)
		{
			return global::Gibraltar.Monitor.CustomSampledMetric.AddOrGet(global::Gibraltar.Monitor.Log.Metrics, metricTypeName, categoryName, counterName, metricSampleType, instanceName);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00039DAC File Offset: 0x00037FAC
		public global::Gibraltar.Monitor.CustomSampledMetricSample CreateSample(double rawValue)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricSample(this, new global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket(this, rawValue));
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00039DBC File Offset: 0x00037FBC
		public global::Gibraltar.Monitor.CustomSampledMetricSample CreateSample(double rawValue, global::System.DateTimeOffset rawTimeStamp)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricSample(this, new global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket(this, rawValue, rawTimeStamp));
		}

		// Token: 0x06001396 RID: 5014 RVA: 0x00039DCC File Offset: 0x00037FCC
		public global::Gibraltar.Monitor.CustomSampledMetricSample CreateSample(double rawValue, double baseValue)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricSample(this, new global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket(this, rawValue, baseValue));
		}

		// Token: 0x06001397 RID: 5015 RVA: 0x00039DDC File Offset: 0x00037FDC
		public global::Gibraltar.Monitor.CustomSampledMetricSample CreateSample(double rawValue, double baseValue, global::System.DateTimeOffset rawTimeStamp)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricSample(this, new global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket(this, rawValue, baseValue, rawTimeStamp));
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x00039DF0 File Offset: 0x00037FF0
		public void WriteSample(double rawValue)
		{
			this.CreateSample(rawValue).Write();
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x00039E00 File Offset: 0x00038000
		public void WriteSample(double rawValue, global::System.DateTimeOffset rawTimeStamp)
		{
			this.CreateSample(rawValue, rawTimeStamp).Write();
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x00039E10 File Offset: 0x00038010
		public void WriteSample(double rawValue, double baseValue)
		{
			this.CreateSample(rawValue, baseValue).Write();
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x00039E20 File Offset: 0x00038020
		public void WriteSample(double rawValue, double baseValue, global::System.DateTimeOffset rawTimeStamp)
		{
			this.CreateSample(rawValue, baseValue, rawTimeStamp).Write();
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x00039E30 File Offset: 0x00038030
		public int CompareTo(global::Gibraltar.Monitor.CustomSampledMetric other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x00039E3C File Offset: 0x0003803C
		public bool Equals(global::Gibraltar.Monitor.CustomSampledMetric other)
		{
			return base.Equals(other);
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00039E48 File Offset: 0x00038048
		public new global::Gibraltar.Monitor.CustomSampledMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00039E50 File Offset: 0x00038050
		internal new global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00039E58 File Offset: 0x00038058
		public new global::Gibraltar.Monitor.CustomSampledMetricSampleCollection Samples
		{
			get
			{
				return this.m_Samples;
			}
		}

		// Token: 0x060013A1 RID: 5025 RVA: 0x00039E60 File Offset: 0x00038060
		internal override global::Gibraltar.Monitor.MetricSample OnMetricSampleRead(global::Gibraltar.Monitor.Internal.MetricSamplePacket packet)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricSample(this, (global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket)packet);
		}

		// Token: 0x060013A2 RID: 5026 RVA: 0x00039E70 File Offset: 0x00038070
		protected override global::Gibraltar.Monitor.MetricSampleCollection OnSampleCollectionCreate()
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricSampleCollection(this);
		}

		// Token: 0x04000681 RID: 1665
		private readonly global::Gibraltar.Monitor.CustomSampledMetricSampleCollection m_Samples;

		// Token: 0x04000682 RID: 1666
		private readonly global::Gibraltar.Monitor.CustomSampledMetricDefinition m_MetricDefinition;

		// Token: 0x04000683 RID: 1667
		private readonly global::Gibraltar.Monitor.Internal.CustomSampledMetricPacket m_Packet;
	}
}
