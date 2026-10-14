using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200020D RID: 525
	internal class CustomSampledMetricDefinitionPacket : global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>, global::System.IComparable<global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket>
	{
		// Token: 0x06001A2F RID: 6703 RVA: 0x0005C19C File Offset: 0x0005A39C
		public CustomSampledMetricDefinitionPacket(string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType) : base(metricTypeName, categoryName, counterName)
		{
			this.m_MetricSampleType = metricSampleType;
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0005C1B0 File Offset: 0x0005A3B0
		public CustomSampledMetricDefinitionPacket(string metricTypeName, string categoryName, string counterName, global::Gibraltar.Monitor.MetricSampleType metricSampleType, string unitCaption, string description) : base(metricTypeName, categoryName, counterName, unitCaption, description)
		{
			this.m_MetricSampleType = metricSampleType;
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0005C1C8 File Offset: 0x0005A3C8
		public CustomSampledMetricDefinitionPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0005C1D4 File Offset: 0x0005A3D4
		public int CompareTo(global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0005C1E0 File Offset: 0x0005A3E0
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0005C1F0 File Offset: 0x0005A3F0
		public bool Equals(global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0005C1FC File Offset: 0x0005A3FC
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06001A36 RID: 6710 RVA: 0x0005C204 File Offset: 0x0005A404
		// (set) Token: 0x06001A37 RID: 6711 RVA: 0x0005C20C File Offset: 0x0005A40C
		public global::Gibraltar.Monitor.MetricSampleType MetricSampleType
		{
			get
			{
				return this.m_MetricSampleType;
			}
			protected set
			{
				this.m_MetricSampleType = value;
			}
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0005C218 File Offset: 0x0005A418
		public static string SampledMetricTypeCaption(global::Gibraltar.Monitor.MetricSampleType metricSampleType)
		{
			string result;
			switch (metricSampleType)
			{
			case global::Gibraltar.Monitor.MetricSampleType.RawCount:
				result = "Count of Items";
				break;
			case global::Gibraltar.Monitor.MetricSampleType.RawFraction:
				result = "Percentage";
				break;
			case global::Gibraltar.Monitor.MetricSampleType.IncrementalCount:
				result = "Count of Items";
				break;
			case global::Gibraltar.Monitor.MetricSampleType.IncrementalFraction:
				result = "Percentage";
				break;
			case global::Gibraltar.Monitor.MetricSampleType.TotalCount:
				result = "Count of Items";
				break;
			case global::Gibraltar.Monitor.MetricSampleType.TotalFraction:
				result = "Percentage";
				break;
			default:
				throw new global::System.ArgumentOutOfRangeException("metricSampleType");
			}
			return result;
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0005C29C File Offset: 0x0005A49C
		protected override string OnUnitCaptionGenerate()
		{
			return global::Gibraltar.Monitor.Internal.CustomSampledMetricDefinitionPacket.SampledMetricTypeCaption(this.MetricSampleType);
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0005C2AC File Offset: 0x0005A4AC
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0005C2B0 File Offset: 0x0005A4B0
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"metricSampleType",
						global::Gibraltar.Serialization.FieldType.Int32
					}
				}
			};
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0005C2E8 File Offset: 0x0005A4E8
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("metricSampleType", (int)this.m_MetricSampleType);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0005C300 File Offset: 0x0005A500
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				int metricSampleType;
				packet.GetField("metricSampleType", out metricSampleType);
				this.m_MetricSampleType = (global::Gibraltar.Monitor.MetricSampleType)metricSampleType;
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x0005C340 File Offset: 0x0005A540
		global::Gibraltar.Monitor.MetricDefinition global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricDefinition, global::Gibraltar.Monitor.MetricDefinitionCollection>.GetDataObject(global::Gibraltar.Monitor.MetricDefinitionCollection optionalParent)
		{
			return new global::Gibraltar.Monitor.CustomSampledMetricDefinition(optionalParent, this);
		}

		// Token: 0x04000998 RID: 2456
		private global::Gibraltar.Monitor.MetricSampleType m_MetricSampleType;

		// Token: 0x04000999 RID: 2457
		private const int SerializationVersion = 1;
	}
}
