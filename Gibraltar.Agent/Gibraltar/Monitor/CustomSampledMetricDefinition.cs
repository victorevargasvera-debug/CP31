using System;
using System.Reflection;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001AF RID: 431
	internal sealed class CustomSampledMetricDefinition : global::Gibraltar.Monitor.SampledMetricDefinition, global::System.IComparable<global::Gibraltar.Monitor.CustomSampledMetricDefinition>, global::System.IEquatable<global::Gibraltar.Monitor.CustomSampledMetricDefinition>
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x00039020 File Offset: 0x00037220
		public CustomSampledMetricDefinition(string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType) : base(global::Gibraltar.Monitor.Log.Metrics, new global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket(metricTypeName, categoryName, counterName, metricSampleType))
		{
			this.m_RequiresMultipleSamples = global::Gibraltar.Monitor.CustomSampledMetricDefinition.SampledMetricTypeRequiresMultipleSamples(metricSampleType);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x00039044 File Offset: 0x00037244
		public CustomSampledMetricDefinition(string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType, string unitCaption, string description) : base(global::Gibraltar.Monitor.Log.Metrics, new global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket(metricTypeName, categoryName, counterName, metricSampleType, unitCaption, description))
		{
			this.m_RequiresMultipleSamples = global::Gibraltar.Monitor.CustomSampledMetricDefinition.SampledMetricTypeRequiresMultipleSamples(metricSampleType);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x0003907C File Offset: 0x0003727C
		public CustomSampledMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType) : base(definitions, new global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket(metricTypeName, categoryName, counterName, metricSampleType))
		{
			this.m_RequiresMultipleSamples = global::Gibraltar.Monitor.CustomSampledMetricDefinition.SampledMetricTypeRequiresMultipleSamples(metricSampleType);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x000390A0 File Offset: 0x000372A0
		public CustomSampledMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType, string unitCaption, string description) : base(definitions, new global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket(metricTypeName, categoryName, counterName, metricSampleType, unitCaption, description))
		{
			this.m_RequiresMultipleSamples = global::Gibraltar.Monitor.CustomSampledMetricDefinition.SampledMetricTypeRequiresMultipleSamples(metricSampleType);
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000390D4 File Offset: 0x000372D4
		internal CustomSampledMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket packet) : base(definitions, packet)
		{
			this.m_RequiresMultipleSamples = global::Gibraltar.Monitor.CustomSampledMetricDefinition.SampledMetricTypeRequiresMultipleSamples(packet.MetricSampleType);
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000390F0 File Offset: 0x000372F0
		public static global::Gibraltar.Monitor.CustomSampledMetricDefinition AddOrGet(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType, string unitCaption, string description)
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
					metricDefinition = new global::Gibraltar.Monitor.CustomSampledMetricDefinition(definitions, metricTypeName, categoryName, counterName, metricSampleType, unitCaption, description);
				}
			}
			return (global::Gibraltar.Monitor.CustomSampledMetricDefinition)metricDefinition;
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x00039180 File Offset: 0x00037380
		public static global::Gibraltar.Monitor.CustomSampledMetricDefinition AddOrGet(string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType, string unitCaption, string description)
		{
			return global::Gibraltar.Monitor.CustomSampledMetricDefinition.AddOrGet(global::Gibraltar.Monitor.Log.Metrics, metricTypeName, categoryName, counterName, metricSampleType, unitCaption, description);
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001363 RID: 4963 RVA: 0x00039194 File Offset: 0x00037394
		public global::Gibraltar.Monitor.MetricSampleType MetricSampleType
		{
			get
			{
				return ((global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket)base.Packet).MetricSampleType;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001364 RID: 4964 RVA: 0x000391A8 File Offset: 0x000373A8
		public bool RequiresMultipleSamples
		{
			get
			{
				return this.m_RequiresMultipleSamples;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001365 RID: 4965 RVA: 0x000391B0 File Offset: 0x000373B0
		// (set) Token: 0x06001366 RID: 4966 RVA: 0x000391B8 File Offset: 0x000373B8
		public bool IsBound
		{
			get
			{
				return this.m_Bound;
			}
			set
			{
				this.m_Bound = value;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001367 RID: 4967 RVA: 0x000391C4 File Offset: 0x000373C4
		// (set) Token: 0x06001368 RID: 4968 RVA: 0x000391CC File Offset: 0x000373CC
		public global::System.Type BoundType
		{
			get
			{
				return this.m_BoundType;
			}
			set
			{
				this.m_BoundType = value;
			}
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000391D8 File Offset: 0x000373D8
		public int CompareTo(global::Gibraltar.Monitor.CustomSampledMetricDefinition other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000391E4 File Offset: 0x000373E4
		public bool Equals(global::Gibraltar.Monitor.CustomSampledMetricDefinition other)
		{
			return base.Equals(other);
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x000391F0 File Offset: 0x000373F0
		public new global::Gibraltar.Monitor.CustomSampledMetricDictionary Metrics
		{
			get
			{
				return (global::Gibraltar.Monitor.CustomSampledMetricDictionary)base.Metrics;
			}
		}

		// Token: 0x0600136C RID: 4972 RVA: 0x00039200 File Offset: 0x00037400
		public void WriteSample(string instanceName, double rawValue)
		{
			this.EnsureMetricExists(instanceName).WriteSample(rawValue);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x00039210 File Offset: 0x00037410
		public void WriteSample(string instanceName, double rawValue, global::System.DateTimeOffset rawTimeStamp)
		{
			this.EnsureMetricExists(instanceName).WriteSample(rawValue, rawTimeStamp);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00039220 File Offset: 0x00037420
		public void WriteSample(string instanceName, double rawValue, double baseValue)
		{
			this.EnsureMetricExists(instanceName).WriteSample(rawValue, baseValue);
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00039230 File Offset: 0x00037430
		public void WriteSample(string instanceName, double rawValue, double baseValue, global::System.DateTimeOffset rawTimeStamp)
		{
			this.EnsureMetricExists(instanceName).WriteSample(rawValue, baseValue, rawTimeStamp);
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x00039244 File Offset: 0x00037444
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x0003924C File Offset: 0x0003744C
		public bool NameBound
		{
			get
			{
				return this.m_NameBound;
			}
			set
			{
				this.m_NameBound = value;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x00039258 File Offset: 0x00037458
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x00039260 File Offset: 0x00037460
		public string NameMemberName
		{
			get
			{
				return this.m_NameMemberName;
			}
			set
			{
				this.m_NameMemberName = value;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x0003926C File Offset: 0x0003746C
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x00039274 File Offset: 0x00037474
		public global::System.Reflection.MemberTypes NameMemberType
		{
			get
			{
				return this.m_NameMemberType;
			}
			set
			{
				this.m_NameMemberType = value;
			}
		}

		// Token: 0x06001376 RID: 4982 RVA: 0x00039280 File Offset: 0x00037480
		protected override global::Gibraltar.Monitor.MetricCollection OnMetricDictionaryCreate()
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricDictionary(this);
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x00039288 File Offset: 0x00037488
		internal static bool SampledMetricTypeRequiresMultipleSamples(global::Gibraltar.Monitor.MetricSampleType metricSampleType)
		{
			return metricSampleType > global::Gibraltar.Monitor.MetricSampleType.RawFraction;
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x000392AC File Offset: 0x000374AC
		internal new global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket)base.Packet;
			}
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x000392BC File Offset: 0x000374BC
		private global::Gibraltar.Monitor.CustomSampledMetric EnsureMetricExists(string instanceName)
		{
			string key = global::Gibraltar.Monitor.MetricDefinition.GetKey(this, instanceName);
			object @lock = this.Metrics.Lock;
			global::Loupe.Extensibility.Data.IMetric metric;
			lock (@lock)
			{
				if (!this.Metrics.TryGetValue(key, out metric))
				{
					metric = new global::Gibraltar.Monitor.CustomSampledMetric(this, instanceName);
				}
			}
			return (global::Gibraltar.Monitor.CustomSampledMetric)metric;
		}

		// Token: 0x04000679 RID: 1657
		private readonly bool m_RequiresMultipleSamples;

		// Token: 0x0400067A RID: 1658
		private bool m_Bound;

		// Token: 0x0400067B RID: 1659
		private global::System.Type m_BoundType;

		// Token: 0x0400067C RID: 1660
		private bool m_NameBound;

		// Token: 0x0400067D RID: 1661
		private string m_NameMemberName;

		// Token: 0x0400067E RID: 1662
		private global::System.Reflection.MemberTypes m_NameMemberType;
	}
}
