using System;
using System.Globalization;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000219 RID: 537
	internal abstract class MetricSamplePacket : global::Gibraltar.Monitor.Internal.GibraltarPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>, global::System.IComparable<global::Gibraltar.Monitor.Internal.MetricSamplePacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.MetricSamplePacket>, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x06001AEE RID: 6894 RVA: 0x0005DF10 File Offset: 0x0005C110
		protected MetricSamplePacket(global::Gibraltar.Monitor.Metric metric)
		{
			if (metric == null)
			{
				throw new global::System.ArgumentNullException("metric");
			}
			this.ID = global::System.Guid.NewGuid();
			this.m_MetricPacket = metric.Packet;
			this.Persisted = false;
		}

		// Token: 0x06001AEF RID: 6895 RVA: 0x0005DF50 File Offset: 0x0005C150
		protected MetricSamplePacket(global::Gibraltar.Monitor.Session session)
		{
			if (session == null)
			{
				throw new global::System.ArgumentNullException("session");
			}
			this.m_Session = session;
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0005DF78 File Offset: 0x0005C178
		// (set) Token: 0x06001AF1 RID: 6897 RVA: 0x0005DF80 File Offset: 0x0005C180
		public global::System.Guid ID
		{
			get
			{
				return this.m_ID;
			}
			private set
			{
				this.m_ID = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001AF2 RID: 6898 RVA: 0x0005DF8C File Offset: 0x0005C18C
		public virtual string Caption
		{
			get
			{
				return this.m_MetricPacket.Caption;
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001AF3 RID: 6899 RVA: 0x0005DF9C File Offset: 0x0005C19C
		public virtual string Description
		{
			get
			{
				return this.m_MetricPacket.Description;
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001AF4 RID: 6900 RVA: 0x0005DFAC File Offset: 0x0005C1AC
		// (set) Token: 0x06001AF5 RID: 6901 RVA: 0x0005DFB4 File Offset: 0x0005C1B4
		internal global::System.Guid MetricId
		{
			get
			{
				return this.m_MetricId;
			}
			private set
			{
				this.m_MetricId = value;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06001AF6 RID: 6902 RVA: 0x0005DFC0 File Offset: 0x0005C1C0
		// (set) Token: 0x06001AF7 RID: 6903 RVA: 0x0005DFC8 File Offset: 0x0005C1C8
		public global::Gibraltar.Monitor.Internal.MetricPacket MetricPacket
		{
			get
			{
				return this.m_MetricPacket;
			}
			internal set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				if (this.MetricId != global::System.Guid.Empty && value.ID != this.MetricId)
				{
					throw new global::System.ArgumentException("The provided metric packet doesn't have the same ID as the metric packet ID already stored. This indicates the data would be inconsistent.");
				}
				this.m_MetricPacket = value;
				if (this.MetricId == global::System.Guid.Empty)
				{
					this.MetricId = this.m_MetricPacket.ID;
				}
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06001AF8 RID: 6904 RVA: 0x0005E050 File Offset: 0x0005C250
		// (set) Token: 0x06001AF9 RID: 6905 RVA: 0x0005E058 File Offset: 0x0005C258
		public bool Persisted { get; private set; }

		// Token: 0x06001AFA RID: 6906 RVA: 0x0005E064 File Offset: 0x0005C264
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0} {1}: {2}", new object[]
			{
				base.Timestamp.DateTime.ToShortDateString(),
				base.Timestamp.DateTime.ToShortTimeString(),
				this.Caption
			});
		}

		// Token: 0x06001AFB RID: 6907 RVA: 0x0005E0C8 File Offset: 0x0005C2C8
		public int CompareTo(global::Gibraltar.Monitor.Internal.MetricSamplePacket other)
		{
			if (this.ID == other.ID)
			{
				return 0;
			}
			return base.Sequence.CompareTo(other.Sequence);
		}

		// Token: 0x06001AFC RID: 6908 RVA: 0x0005E108 File Offset: 0x0005C308
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.MetricSamplePacket);
		}

		// Token: 0x06001AFD RID: 6909 RVA: 0x0005E118 File Offset: 0x0005C318
		public bool Equals(global::Gibraltar.Monitor.Internal.MetricSamplePacket other)
		{
			return other != null && (this.ID == other.ID && ((this.m_MetricPacket == null && other.MetricPacket == null) || (this.m_MetricPacket != null && other.MetricPacket != null && this.m_MetricPacket.ID == other.MetricPacket.ID))) && base.Equals(other);
		}

		// Token: 0x06001AFE RID: 6910 RVA: 0x0005E19C File Offset: 0x0005C39C
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			num ^= this.m_ID.GetHashCode();
			if (this.m_MetricPacket != null)
			{
				num ^= this.m_MetricPacket.GetHashCode();
			}
			return num;
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0005E1E4 File Offset: 0x0005C3E4
		protected global::Gibraltar.Monitor.Session Session
		{
			get
			{
				if (this.m_Session == null)
				{
					throw new global::System.InvalidOperationException("There is no session object available, it is only valid during rehydration.");
				}
				return this.m_Session;
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0005E208 File Offset: 0x0005C408
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return new global::Gibraltar.Serialization.IPacket[]
			{
				this.m_MetricPacket
			};
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x0005E21C File Offset: 0x0005C41C
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, true)
			{
				Fields = 
				{
					{
						"Id",
						global::Gibraltar.Serialization.FieldType.Guid
					},
					{
						"metricPacketId",
						global::Gibraltar.Serialization.FieldType.Guid
					}
				}
			};
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0005E268 File Offset: 0x0005C468
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("Id", this.m_ID);
			packet.SetField("metricPacketId", this.m_MetricPacket.ID);
			this.Persisted = true;
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0005E2B4 File Offset: 0x0005C4B4
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("Id", out this.m_ID);
				packet.GetField("metricPacketId", out this.m_MetricId);
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0005E304 File Offset: 0x0005C504
		global::Gibraltar.Monitor.MetricSample global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.MetricSample, global::Gibraltar.Monitor.Metric>.GetDataObject(global::Gibraltar.Monitor.Metric optionalParent)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040009C7 RID: 2503
		private global::Gibraltar.Monitor.Internal.MetricPacket m_MetricPacket;

		// Token: 0x040009C8 RID: 2504
		private global::System.Guid m_ID;

		// Token: 0x040009C9 RID: 2505
		private global::System.Guid m_MetricId;

		// Token: 0x040009CA RID: 2506
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x040009CC RID: 2508
		private const int SerializationVersion = 1;
	}
}
