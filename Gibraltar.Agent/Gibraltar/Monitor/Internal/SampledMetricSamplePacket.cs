using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000221 RID: 545
	internal abstract class SampledMetricSamplePacket : global::Gibraltar.Monitor.Internal.MetricSamplePacket, global::Gibraltar.Serialization.IPacket, global::System.IComparable<global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket>
	{
		// Token: 0x06001B85 RID: 7045 RVA: 0x0005FC08 File Offset: 0x0005DE08
		protected SampledMetricSamplePacket(global::Gibraltar.Monitor.SampledMetric metric) : base(metric)
		{
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x0005FC14 File Offset: 0x0005DE14
		protected SampledMetricSamplePacket(global::Gibraltar.Monitor.SampledMetric metric, double rawValue) : base(metric)
		{
			this.RawValue = rawValue;
			this.RawTimestamp = global::System.DateTimeOffset.Now;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x0005FC30 File Offset: 0x0005DE30
		protected SampledMetricSamplePacket(global::Gibraltar.Monitor.SampledMetric metric, double rawValue, global::System.DateTimeOffset rawTimeStamp) : base(metric)
		{
			this.RawValue = rawValue;
			this.RawTimestamp = rawTimeStamp;
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0005FC48 File Offset: 0x0005DE48
		protected SampledMetricSamplePacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x0005FC54 File Offset: 0x0005DE54
		public int CompareTo(global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0005FC60 File Offset: 0x0005DE60
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket);
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0005FC70 File Offset: 0x0005DE70
		public bool Equals(global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket other)
		{
			return other != null && (this.RawTimestamp == other.RawTimestamp && this.RawValue == other.RawValue) && base.Equals(other);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0005FCBC File Offset: 0x0005DEBC
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ this.m_RawValue.GetHashCode() ^ this.m_RawTimestamp.GetHashCode();
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x0005FCE4 File Offset: 0x0005DEE4
		// (set) Token: 0x06001B8E RID: 7054 RVA: 0x0005FCEC File Offset: 0x0005DEEC
		public global::System.DateTimeOffset RawTimestamp
		{
			get
			{
				return this.m_RawTimestamp;
			}
			protected set
			{
				this.m_RawTimestamp = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x0005FCF8 File Offset: 0x0005DEF8
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0005FD00 File Offset: 0x0005DF00
		public double RawValue
		{
			get
			{
				return this.m_RawValue;
			}
			protected set
			{
				this.m_RawValue = value;
			}
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0005FD0C File Offset: 0x0005DF0C
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0005FD10 File Offset: 0x0005DF10
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"rawTimeStamp",
						global::Gibraltar.Serialization.FieldType.DateTimeOffset
					},
					{
						"rawValue",
						global::Gibraltar.Serialization.FieldType.Double
					}
				}
			};
		}

		// Token: 0x06001B93 RID: 7059 RVA: 0x0005FD5C File Offset: 0x0005DF5C
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("rawTimeStamp", this.m_RawTimestamp);
			packet.SetField("rawValue", this.m_RawValue);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0005FD8C File Offset: 0x0005DF8C
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("rawTimeStamp", out this.m_RawTimestamp);
				packet.GetField("rawValue", out this.m_RawValue);
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x040009E9 RID: 2537
		private global::System.DateTimeOffset m_RawTimestamp;

		// Token: 0x040009EA RID: 2538
		private double m_RawValue;

		// Token: 0x040009EB RID: 2539
		private const int SerializationVersion = 1;
	}
}
