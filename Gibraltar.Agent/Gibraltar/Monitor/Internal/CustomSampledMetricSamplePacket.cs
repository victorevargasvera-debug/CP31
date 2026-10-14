using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200020F RID: 527
	internal class CustomSampledMetricSamplePacket : global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>, global::System.IComparable<global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket>
	{
		// Token: 0x06001A46 RID: 6726 RVA: 0x0005C3A4 File Offset: 0x0005A5A4
		public CustomSampledMetricSamplePacket(global::Gibraltar.Monitor.CustomSampledMetric metric, double rawValue) : base(metric, rawValue)
		{
			this.m_BaseValue = 0.0;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0005C3C0 File Offset: 0x0005A5C0
		public CustomSampledMetricSamplePacket(global::Gibraltar.Monitor.CustomSampledMetric metric, double rawValue, global::System.DateTimeOffset rawTimeStamp) : base(metric, rawValue, rawTimeStamp)
		{
			this.m_BaseValue = 0.0;
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0005C3DC File Offset: 0x0005A5DC
		public CustomSampledMetricSamplePacket(global::Gibraltar.Monitor.CustomSampledMetric metric, double rawValue, double baseValue) : base(metric, rawValue)
		{
			this.m_BaseValue = baseValue;
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0005C3F0 File Offset: 0x0005A5F0
		public CustomSampledMetricSamplePacket(global::Gibraltar.Monitor.CustomSampledMetric metric, double rawValue, double baseValue, global::System.DateTimeOffset rawTimeStamp) : base(metric, rawValue, rawTimeStamp)
		{
			this.m_BaseValue = baseValue;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0005C404 File Offset: 0x0005A604
		public CustomSampledMetricSamplePacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x0005C410 File Offset: 0x0005A610
		// (set) Token: 0x06001A4C RID: 6732 RVA: 0x0005C418 File Offset: 0x0005A618
		public double BaseValue
		{
			get
			{
				return this.m_BaseValue;
			}
			protected set
			{
				this.m_BaseValue = value;
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0005C424 File Offset: 0x0005A624
		public int CompareTo(global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0005C430 File Offset: 0x0005A630
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0005C440 File Offset: 0x0005A640
		public bool Equals(global::Gibraltar.Monitor.Internal.CustomSampledMetricSamplePacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0005C44C File Offset: 0x0005A64C
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0005C454 File Offset: 0x0005A654
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0005C458 File Offset: 0x0005A658
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"baseValue",
						global::Gibraltar.Serialization.FieldType.Double
					}
				}
			};
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0005C494 File Offset: 0x0005A694
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("baseValue", this.m_BaseValue);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0005C4AC File Offset: 0x0005A6AC
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("baseValue", out this.m_BaseValue);
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0005C4E8 File Offset: 0x0005A6E8
		global::Gibraltar.Monitor.MetricSample global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>.GetDataObject(global::Gibraltar.Monitor.Metric optionalParent)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricSample((global::Gibraltar.Monitor.CustomSampledMetric)optionalParent, this);
		}

		// Token: 0x0400099A RID: 2458
		private double m_BaseValue;

		// Token: 0x0400099B RID: 2459
		private const int SerializationVersion = 1;
	}
}
