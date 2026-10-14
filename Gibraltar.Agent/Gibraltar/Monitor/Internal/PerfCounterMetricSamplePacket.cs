using System;
using System.Diagnostics;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200021E RID: 542
	internal class PerfCounterMetricSamplePacket : global::Gibraltar.Monitor.Internal.SampledMetricSamplePacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>, global::System.IComparable<global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket>
	{
		// Token: 0x06001B64 RID: 7012 RVA: 0x0005F75C File Offset: 0x0005D95C
		public PerfCounterMetricSamplePacket(global::System.Diagnostics.PerformanceCounter counter, global::Gibraltar.Monitor.PerfCounterMetric metric) : base(metric)
		{
			this.m_Sample = counter.NextSample();
			base.RawValue = (double)this.m_Sample.RawValue;
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0005F794 File Offset: 0x0005D994
		public PerfCounterMetricSamplePacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0005F7A0 File Offset: 0x0005D9A0
		public static implicit operator global::System.Diagnostics.CounterSample(global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket r)
		{
			return r.CounterSample;
		}

		// Token: 0x06001B67 RID: 7015 RVA: 0x0005F7A8 File Offset: 0x0005D9A8
		public int CompareTo(global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001B68 RID: 7016 RVA: 0x0005F7B4 File Offset: 0x0005D9B4
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket);
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0005F7C4 File Offset: 0x0005D9C4
		public bool Equals(global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket other)
		{
			return other != null && this.m_Sample == other.m_Sample && base.Equals(other);
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0005F7F0 File Offset: 0x0005D9F0
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ this.m_Sample.GetHashCode();
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0005F80C File Offset: 0x0005DA0C
		public global::System.Diagnostics.CounterSample CounterSample
		{
			get
			{
				return this.m_Sample;
			}
		}

		// Token: 0x06001B6C RID: 7020 RVA: 0x0005F814 File Offset: 0x0005DA14
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x0005F818 File Offset: 0x0005DA18
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"baseValue",
						global::Gibraltar.Serialization.FieldType.Int64
					},
					{
						"counterTimeStamp",
						global::Gibraltar.Serialization.FieldType.Int64
					},
					{
						"counterFrequency",
						global::Gibraltar.Serialization.FieldType.Int64
					},
					{
						"systemFrequency",
						global::Gibraltar.Serialization.FieldType.Int64
					},
					{
						"timeStamp",
						global::Gibraltar.Serialization.FieldType.Int64
					},
					{
						"timeStamp100nSec",
						global::Gibraltar.Serialization.FieldType.Int64
					},
					{
						"counterType",
						global::Gibraltar.Serialization.FieldType.Int32
					}
				}
			};
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x0005F8B8 File Offset: 0x0005DAB8
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("baseValue", this.m_Sample.BaseValue);
			packet.SetField("counterTimeStamp", this.m_Sample.CounterTimeStamp);
			packet.SetField("counterFrequency", this.m_Sample.CounterFrequency);
			packet.SetField("systemFrequency", this.m_Sample.SystemFrequency);
			packet.SetField("timeStamp", this.m_Sample.TimeStamp);
			packet.SetField("timeStamp100nSec", this.m_Sample.TimeStamp100nSec);
			packet.SetField("counterType", (int)this.m_Sample.CounterType);
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x0005F988 File Offset: 0x0005DB88
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				long baseValue;
				packet.GetField("baseValue", out baseValue);
				long counterTimeStamp;
				packet.GetField("counterTimeStamp", out counterTimeStamp);
				long counterFrequency;
				packet.GetField("counterFrequency", out counterFrequency);
				long systemFrequency;
				packet.GetField("systemFrequency", out systemFrequency);
				long timeStamp;
				packet.GetField("timeStamp", out timeStamp);
				long timeStamp100nSec;
				packet.GetField("timeStamp100nSec", out timeStamp100nSec);
				int num;
				packet.GetField("counterType", out num);
				global::System.Diagnostics.PerformanceCounterType counterType = (global::System.Diagnostics.PerformanceCounterType)num;
				this.m_Sample = new global::System.Diagnostics.CounterSample((long)base.RawValue, baseValue, counterFrequency, systemFrequency, timeStamp, timeStamp100nSec, counterType, counterTimeStamp);
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x0005FA30 File Offset: 0x0005DC30
		global::Gibraltar.Monitor.MetricSample global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>.GetDataObject(global::Gibraltar.Monitor.Metric optionalParent)
		{
			return new global::Gibraltar.Monitor.PerfCounterMetricSample((global::Gibraltar.Monitor.PerfCounterMetric)optionalParent, this);
		}

		// Token: 0x040009E5 RID: 2533
		private global::System.Diagnostics.CounterSample m_Sample;

		// Token: 0x040009E6 RID: 2534
		private const int SerializationVersion = 1;
	}
}
