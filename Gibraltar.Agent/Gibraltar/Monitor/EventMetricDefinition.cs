using System;
using System.Reflection;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001BB RID: 443
	internal class EventMetricDefinition : global::Gibraltar.Monitor.MetricDefinition, global::Loupe.Extensibility.Data.IEventMetricDefinition, global::Loupe.Extensibility.Data.IMetricDefinition, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.IComparable<global::Loupe.Extensibility.Data.IEventMetricDefinition>, global::System.IEquatable<global::Loupe.Extensibility.Data.IEventMetricDefinition>
	{
		// Token: 0x0600143A RID: 5178 RVA: 0x0003BC44 File Offset: 0x00039E44
		public EventMetricDefinition(string metricTypeName, string categoryName, string counterName) : base(global::Gibraltar.Monitor.Log.Metrics, new global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket(metricTypeName, categoryName, counterName))
		{
			this.m_MetricValues = new global::Gibraltar.Monitor.EventMetricValueDefinitionCollection(this);
			this.Packet.MetricValues = this.m_MetricValues;
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0003BC78 File Offset: 0x00039E78
		public EventMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName) : base(definitions, new global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket(metricTypeName, categoryName, counterName))
		{
			this.m_MetricValues = new global::Gibraltar.Monitor.EventMetricValueDefinitionCollection(this);
			this.Packet.MetricValues = this.m_MetricValues;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0003BCA8 File Offset: 0x00039EA8
		internal EventMetricDefinition(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, global::Gibraltar.Monitor.Internal.MetricDefinitionPacket packet) : base(definitions, packet)
		{
			this.m_MetricValues = new global::Gibraltar.Monitor.EventMetricValueDefinitionCollection(this);
			this.Packet.MetricValues = this.m_MetricValues;
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0003BCD0 File Offset: 0x00039ED0
		public static global::Gibraltar.Monitor.EventMetricDefinition AddOrGet(global::Gibraltar.Monitor.MetricDefinitionCollection definitions, string metricTypeName, string categoryName, string counterName)
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
						throw new global::System.ArgumentException("A metric already exists with the provided type, category, and counter name but it is not compatible with being an event metric.  Please use a different counter name.", "counterName");
					}
				}
				else
				{
					metricDefinition = new global::Gibraltar.Monitor.EventMetricDefinition(definitions, metricTypeName, categoryName, counterName);
					definitions.Add(metricDefinition);
				}
			}
			return (global::Gibraltar.Monitor.EventMetricDefinition)metricDefinition;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0003BD60 File Offset: 0x00039F60
		public static global::Gibraltar.Monitor.EventMetricDefinition AddOrGet(string metricTypeName, string categoryName, string counterName)
		{
			return global::Gibraltar.Monitor.EventMetricDefinition.AddOrGet(global::Gibraltar.Monitor.Log.Metrics, metricTypeName, categoryName, counterName);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0003BD70 File Offset: 0x00039F70
		public global::Gibraltar.Monitor.EventMetricDefinition Register()
		{
			global::Gibraltar.Monitor.MetricDefinitionCollection metricDefinitionCollection = (global::Gibraltar.Monitor.MetricDefinitionCollection)base.Definitions;
			object @lock = metricDefinitionCollection.Lock;
			global::Gibraltar.Monitor.EventMetricDefinition eventMetricDefinition;
			lock (@lock)
			{
				global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
				if (!metricDefinitionCollection.TryGetValue(base.MetricTypeName, base.CategoryName, base.CounterName, out metricDefinition))
				{
					this.SetReadOnly();
					eventMetricDefinition = this;
					metricDefinitionCollection.Add(this);
				}
				else
				{
					eventMetricDefinition = (metricDefinition as global::Gibraltar.Monitor.EventMetricDefinition);
				}
			}
			if (eventMetricDefinition == null)
			{
				throw new global::System.ArgumentException(string.Format("There is already a metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not an event metric.", base.MetricTypeName, base.CategoryName, base.CounterName));
			}
			if (this != eventMetricDefinition)
			{
				global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection values = eventMetricDefinition.Values;
				foreach (global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition in this.Values)
				{
					global::Gibraltar.Monitor.EventMetricValueDefinition eventMetricValueDefinition2 = (global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition;
					global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition3;
					if (!values.TryGetValue(eventMetricValueDefinition2.Name, out eventMetricValueDefinition3))
					{
						throw new global::System.ArgumentException(string.Format("There is already an event metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not compatible; it does not define value column \"{3}\".", new object[]
						{
							base.MetricTypeName,
							base.CategoryName,
							base.CounterName,
							eventMetricValueDefinition2.Name
						}));
					}
					if (eventMetricValueDefinition2.SerializedType != ((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition3).SerializedType)
					{
						throw new global::System.ArgumentException(string.Format("There is already an event metric definition for the same metrics system ({0}), category name ({1}), and counter name ({2}), but it is not compatible; it defines value column \"{3}\" with type {4} rather than type {5}.", new object[]
						{
							base.MetricTypeName,
							base.CategoryName,
							base.CounterName,
							eventMetricValueDefinition2.Name,
							eventMetricValueDefinition3.Type.Name,
							eventMetricValueDefinition2.Type.Name
						}));
					}
				}
			}
			return eventMetricDefinition;
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x0003BF3C File Offset: 0x0003A13C
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x0003BF44 File Offset: 0x0003A144
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

		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x0003BF50 File Offset: 0x0003A150
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x0003BF58 File Offset: 0x0003A158
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

		// Token: 0x06001444 RID: 5188 RVA: 0x0003BF64 File Offset: 0x0003A164
		public int CompareTo(global::Loupe.Extensibility.Data.IEventMetricDefinition other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0003BF70 File Offset: 0x0003A170
		public bool Equals(global::Loupe.Extensibility.Data.IEventMetricDefinition other)
		{
			return base.Equals(other);
		}

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0003BF7C File Offset: 0x0003A17C
		public new global::Gibraltar.Monitor.EventMetricCollection Metrics
		{
			get
			{
				return (global::Gibraltar.Monitor.EventMetricCollection)base.Metrics;
			}
		}

		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x0003BF8C File Offset: 0x0003A18C
		public global::Loupe.Extensibility.Data.IEventMetricValueDefinitionCollection Values
		{
			get
			{
				return this.m_MetricValues;
			}
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0003BF94 File Offset: 0x0003A194
		public static bool IsTrendableValueType(global::System.Type type)
		{
			bool result = false;
			if (type == typeof(short) || type == typeof(ushort) || type == typeof(int) || type == typeof(uint) || type == typeof(long) || type == typeof(ulong) || type == typeof(decimal) || type == typeof(double) || type == typeof(float))
			{
				result = true;
			}
			else if (type == typeof(global::System.DateTimeOffset) || type == typeof(global::System.TimeSpan))
			{
				result = true;
			}
			return result;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0003C064 File Offset: 0x0003A264
		public static bool IsSupportedValueType(global::System.Type type)
		{
			bool result = true;
			if (type.IsArray || type.IsInterface)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x17000749 RID: 1865
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x0003C090 File Offset: 0x0003A290
		// (set) Token: 0x0600144B RID: 5195 RVA: 0x0003C0D0 File Offset: 0x0003A2D0
		public global::Loupe.Extensibility.Data.IEventMetricValueDefinition DefaultValue
		{
			get
			{
				if (!string.IsNullOrEmpty(this.Packet.DefaultValueName))
				{
					return this.Values[this.Packet.DefaultValueName];
				}
				return null;
			}
			set
			{
				this.Packet.DefaultValueName = ((value == null) ? null : this.Values[value.Name].Name);
			}
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x0600144C RID: 5196 RVA: 0x0003C110 File Offset: 0x0003A310
		// (set) Token: 0x0600144D RID: 5197 RVA: 0x0003C118 File Offset: 0x0003A318
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

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600144E RID: 5198 RVA: 0x0003C124 File Offset: 0x0003A324
		// (set) Token: 0x0600144F RID: 5199 RVA: 0x0003C12C File Offset: 0x0003A32C
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

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x0003C138 File Offset: 0x0003A338
		// (set) Token: 0x06001451 RID: 5201 RVA: 0x0003C140 File Offset: 0x0003A340
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

		// Token: 0x06001452 RID: 5202 RVA: 0x0003C14C File Offset: 0x0003A34C
		public override void SetReadOnly()
		{
			object @lock = base.Lock;
			lock (@lock)
			{
				base.SetReadOnly();
				this.m_MetricValues.SetAllIndex();
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0003C194 File Offset: 0x0003A394
		internal new global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket Packet
		{
			get
			{
				return (global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket)base.Packet;
			}
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x0003C1A4 File Offset: 0x0003A3A4
		protected override global::Gibraltar.Monitor.MetricCollection OnMetricDictionaryCreate()
		{
			return new global::Gibraltar.Monitor.EventMetricCollection(this);
		}

		// Token: 0x040006A6 RID: 1702
		private readonly global::Gibraltar.Monitor.EventMetricValueDefinitionCollection m_MetricValues;

		// Token: 0x040006A7 RID: 1703
		private bool m_Bound;

		// Token: 0x040006A8 RID: 1704
		private global::System.Type m_BoundType;

		// Token: 0x040006A9 RID: 1705
		private bool m_NameBound;

		// Token: 0x040006AA RID: 1706
		private string m_NameMemberName;

		// Token: 0x040006AB RID: 1707
		private global::System.Reflection.MemberTypes m_NameMemberType;
	}
}
