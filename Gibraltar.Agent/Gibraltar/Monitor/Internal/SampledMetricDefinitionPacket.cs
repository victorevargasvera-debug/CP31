using System;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200021F RID: 543
	internal abstract class SampledMetricDefinitionPacket : global::Gibraltar.Monitor.Internal.MetricDefinitionPacket, global::Gibraltar.Serialization.IPacket, global::System.IComparable<global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket>
	{
		// Token: 0x06001B71 RID: 7025 RVA: 0x0005FA40 File Offset: 0x0005DC40
		protected SampledMetricDefinitionPacket(string metricTypeName, string categoryName, string counterName) : base(metricTypeName, categoryName, counterName, global::Loupe.Extensibility.Data.SampleType.Sampled)
		{
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x0005FA4C File Offset: 0x0005DC4C
		protected SampledMetricDefinitionPacket(string metricTypeName, string categoryName, string counterName, string unitCaption, string description) : base(metricTypeName, categoryName, counterName, global::Loupe.Extensibility.Data.SampleType.Sampled, description)
		{
			this.UnitCaption = unitCaption;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x0005FA64 File Offset: 0x0005DC64
		protected SampledMetricDefinitionPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x0005FA70 File Offset: 0x0005DC70
		public int CompareTo(global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0005FA7C File Offset: 0x0005DC7C
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0005FAA0 File Offset: 0x0005DCA0
		public string UnitCaption
		{
			get
			{
				if (string.IsNullOrEmpty(this.m_UnitCaption))
				{
					this.UnitCaption = this.OnUnitCaptionGenerate();
				}
				return this.m_UnitCaption;
			}
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.m_UnitCaption = value;
					return;
				}
				this.m_UnitCaption = value.Trim();
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x0005FAC4 File Offset: 0x0005DCC4
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket);
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x0005FAD4 File Offset: 0x0005DCD4
		public bool Equals(global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket other)
		{
			return other != null && this.UnitCaption == other.UnitCaption && base.Equals(other);
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x0005FB00 File Offset: 0x0005DD00
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			if (this.m_UnitCaption != null)
			{
				num ^= this.m_UnitCaption.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001B7A RID: 7034
		protected abstract string OnUnitCaptionGenerate();

		// Token: 0x06001B7B RID: 7035 RVA: 0x0005FB34 File Offset: 0x0005DD34
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0005FB38 File Offset: 0x0005DD38
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"unitCaption",
						global::Gibraltar.Serialization.FieldType.String
					}
				}
			};
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0005FB70 File Offset: 0x0005DD70
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("unitCaption", this.m_UnitCaption);
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0005FB84 File Offset: 0x0005DD84
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("unitCaption", out this.m_UnitCaption);
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x040009E7 RID: 2535
		private string m_UnitCaption;

		// Token: 0x040009E8 RID: 2536
		private const int SerializationVersion = 1;
	}
}
