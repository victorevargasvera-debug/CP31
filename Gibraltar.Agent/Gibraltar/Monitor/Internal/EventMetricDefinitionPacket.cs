using System;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000214 RID: 532
	internal sealed class EventMetricDefinitionPacket : global::Gibraltar.Monitor.Internal.MetricDefinitionPacket, global::Gibraltar.Serialization.ICachedPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>, global::System.IComparable<global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket>
	{
		// Token: 0x06001A8B RID: 6795 RVA: 0x0005CD18 File Offset: 0x0005AF18
		public EventMetricDefinitionPacket(string metricTypeName, string categoryName, string counterName) : base(metricTypeName, categoryName, counterName, global::Loupe.Extensibility.Data.SampleType.Event)
		{
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x0005CD24 File Offset: 0x0005AF24
		public EventMetricDefinitionPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x0005CD30 File Offset: 0x0005AF30
		// (set) Token: 0x06001A8E RID: 6798 RVA: 0x0005CD38 File Offset: 0x0005AF38
		public string DefaultValueName
		{
			get
			{
				return this.m_DefaultValueName;
			}
			set
			{
				this.m_DefaultValueName = value;
			}
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0005CD44 File Offset: 0x0005AF44
		public int CompareTo(global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0005CD50 File Offset: 0x0005AF50
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket);
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x0005CD60 File Offset: 0x0005AF60
		public bool Equals(global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0005CD6C File Offset: 0x0005AF6C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001A93 RID: 6803 RVA: 0x0005CD74 File Offset: 0x0005AF74
		// (set) Token: 0x06001A94 RID: 6804 RVA: 0x0005CD7C File Offset: 0x0005AF7C
		internal global::Gibraltar.Monitor.EventMetricValueDefinitionCollection MetricValues { get; set; }

		// Token: 0x06001A95 RID: 6805 RVA: 0x0005CD88 File Offset: 0x0005AF88
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0005CD8C File Offset: 0x0005AF8C
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"DefaultValueName",
						global::Gibraltar.Serialization.FieldType.String
					}
				}
			};
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0005CDC4 File Offset: 0x0005AFC4
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("DefaultValueName", this.m_DefaultValueName);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0005CDD8 File Offset: 0x0005AFD8
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("DefaultValueName", out this.m_DefaultValueName);
			}
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0005CE08 File Offset: 0x0005B008
		global::Gibraltar.Monitor.MetricDefinition global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>.GetDataObject(global::Gibraltar.Monitor.MetricDefinitionCollection optionalParent)
		{
			global::Gibraltar.Monitor.EventMetricDefinition eventMetricDefinition = new global::Gibraltar.Monitor.EventMetricDefinition(optionalParent, this);
			optionalParent.Add(eventMetricDefinition);
			return eventMetricDefinition;
		}

		// Token: 0x040009AA RID: 2474
		private string m_DefaultValueName;

		// Token: 0x040009AC RID: 2476
		private const int SerializationVersion = 1;
	}
}
