using System;
using System.Collections.Generic;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000212 RID: 530
	internal class EventMetricSamplePacket : global::Gibraltar.Monitor.Internal.MetricSamplePacket, global::Gibraltar.Serialization.IDynamicPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>, global::System.IComparable<global::Gibraltar.Monitor.Internal.EventMetricSamplePacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.EventMetricSamplePacket>
	{
		// Token: 0x06001A63 RID: 6755 RVA: 0x0005C5F0 File Offset: 0x0005A7F0
		public EventMetricSamplePacket(global::Gibraltar.Monitor.EventMetric metric) : base(metric)
		{
			this.Values = new object[metric.Definition.Values.Count];
			this.m_ValueDefinitions = (global::Gibraltar.Monitor.EventMetricValueDefinitionCollection)metric.Definition.Values;
			this.DynamicTypeName = metric.Definition.Name;
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0005C64C File Offset: 0x0005A84C
		public EventMetricSamplePacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0005C658 File Offset: 0x0005A858
		public int CompareTo(global::Gibraltar.Monitor.Internal.EventMetricSamplePacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0005C664 File Offset: 0x0005A864
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.EventMetricSamplePacket);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0005C674 File Offset: 0x0005A874
		public bool Equals(global::Gibraltar.Monitor.Internal.EventMetricSamplePacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0005C680 File Offset: 0x0005A880
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06001A69 RID: 6761 RVA: 0x0005C688 File Offset: 0x0005A888
		// (set) Token: 0x06001A6A RID: 6762 RVA: 0x0005C690 File Offset: 0x0005A890
		public object[] Values { get; private set; }

		// Token: 0x06001A6B RID: 6763 RVA: 0x0005C69C File Offset: 0x0005A89C
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0005C6A0 File Offset: 0x0005A8A0
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			global::Gibraltar.Serialization.PacketDefinition packetDefinition = new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false);
			foreach (global::Loupe.Extensibility.Data.IEventMetricValueDefinition eventMetricValueDefinition in ((global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IEventMetricValueDefinition>)this.m_ValueDefinitions))
			{
				((global::Gibraltar.Monitor.EventMetricValueDefinition)eventMetricValueDefinition).AddField(packetDefinition);
			}
			return packetDefinition;
		}

		// Token: 0x06001A6D RID: 6765 RVA: 0x0005C714 File Offset: 0x0005A914
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			for (int i = 0; i < definition.Fields.Count; i++)
			{
				global::Gibraltar.Serialization.FieldDefinition fieldDefinition = definition.Fields[i];
				packet.SetField(fieldDefinition.Name, this.Values[i]);
			}
		}

		// Token: 0x06001A6E RID: 6766 RVA: 0x0005C760 File Offset: 0x0005A960
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version != 1)
			{
				throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
			}
			this.Values = new object[definition.Fields.Count];
			for (int i = 0; i < definition.Fields.Count; i++)
			{
				global::Gibraltar.Serialization.FieldDefinition fieldDefinition = definition.Fields[i];
				object obj;
				packet.GetField(fieldDefinition.Name, out obj);
				this.Values[i] = obj;
			}
			global::Loupe.Extensibility.Data.IMetric metric;
			if (!base.Session.MetricDefinitions.TryGetMetricValue(base.MetricId, out metric))
			{
				throw new global::System.ArgumentException("Unable to read event metric sample because the associated metric couldn't be found.");
			}
			this.m_ValueDefinitions = (global::Gibraltar.Monitor.EventMetricValueDefinitionCollection)((global::Gibraltar.Monitor.EventMetric)metric).Definition.Values;
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x0005C828 File Offset: 0x0005AA28
		// (set) Token: 0x06001A70 RID: 6768 RVA: 0x0005C830 File Offset: 0x0005AA30
		public string DynamicTypeName { get; set; }

		// Token: 0x06001A71 RID: 6769 RVA: 0x0005C83C File Offset: 0x0005AA3C
		global::Gibraltar.Monitor.MetricSample global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>.GetDataObject(global::Gibraltar.Monitor.Metric optionalParent)
		{
			return new global::Gibraltar.Monitor.EventMetricSample((global::Gibraltar.Monitor.EventMetric)optionalParent, this);
		}

		// Token: 0x0400099D RID: 2461
		private global::Gibraltar.Monitor.EventMetricValueDefinitionCollection m_ValueDefinitions;

		// Token: 0x0400099F RID: 2463
		private const int SerializationVersion = 1;
	}
}
