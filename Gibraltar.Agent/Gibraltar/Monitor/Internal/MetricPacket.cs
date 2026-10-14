using System;
using System.Globalization;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000217 RID: 535
	internal abstract class MetricPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>, global::System.IComparable<global::Gibraltar.Monitor.Internal.MetricPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.MetricPacket>, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x06001ABE RID: 6846 RVA: 0x0005D470 File Offset: 0x0005B670
		protected MetricPacket(global::Gibraltar.Monitor.Internal.MetricDefinitionPacket metricDefinitionPacket, string instanceName) : base(false)
		{
			if (metricDefinitionPacket == null)
			{
				throw new global::System.ArgumentNullException("metricDefinitionPacket");
			}
			this.DefinitionId = metricDefinitionPacket.ID;
			if (!string.IsNullOrEmpty(instanceName))
			{
				this.InstanceName = instanceName.Trim();
			}
			if (string.IsNullOrEmpty(this.InstanceName))
			{
				this.InstanceName = null;
			}
			this.DefinitionPacket = metricDefinitionPacket;
			this.Persisted = false;
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x0005D4E4 File Offset: 0x0005B6E4
		protected MetricPacket(global::Gibraltar.Monitor.Session session) : base(false)
		{
			if (session == null)
			{
				throw new global::System.ArgumentNullException("session");
			}
			this.m_Session = session;
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x06001AC0 RID: 6848 RVA: 0x0005D50C File Offset: 0x0005B70C
		// (set) Token: 0x06001AC1 RID: 6849 RVA: 0x0005D514 File Offset: 0x0005B714
		public global::System.Guid DefinitionId
		{
			get
			{
				return this.m_DefinitionId;
			}
			private set
			{
				this.m_DefinitionId = value;
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x06001AC2 RID: 6850 RVA: 0x0005D520 File Offset: 0x0005B720
		// (set) Token: 0x06001AC3 RID: 6851 RVA: 0x0005D528 File Offset: 0x0005B728
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			private set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06001AC4 RID: 6852 RVA: 0x0005D534 File Offset: 0x0005B734
		public virtual string Caption
		{
			get
			{
				string result;
				if (string.IsNullOrEmpty(this.InstanceName))
				{
					result = this.m_MetricDefinitionPacket.Caption;
				}
				else if (string.IsNullOrEmpty(this.m_MetricDefinitionPacket.Caption))
				{
					result = this.InstanceName;
				}
				else
				{
					result = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "{0} - {1}", new object[]
					{
						this.m_MetricDefinitionPacket.Caption,
						this.InstanceName
					});
				}
				return result;
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x0005D5B8 File Offset: 0x0005B7B8
		public virtual string Description
		{
			get
			{
				return this.m_MetricDefinitionPacket.Description;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06001AC6 RID: 6854 RVA: 0x0005D5C8 File Offset: 0x0005B7C8
		// (set) Token: 0x06001AC7 RID: 6855 RVA: 0x0005D5D0 File Offset: 0x0005B7D0
		public string InstanceName
		{
			get
			{
				return this.m_InstanceName;
			}
			private set
			{
				this.m_InstanceName = value;
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06001AC8 RID: 6856 RVA: 0x0005D5DC File Offset: 0x0005B7DC
		// (set) Token: 0x06001AC9 RID: 6857 RVA: 0x0005D5E4 File Offset: 0x0005B7E4
		public bool Persisted
		{
			get
			{
				return this.m_Persisted;
			}
			private set
			{
				this.m_Persisted = value;
			}
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0005D5F0 File Offset: 0x0005B7F0
		public int CompareTo(global::Gibraltar.Monitor.Internal.MetricPacket other)
		{
			if (base.ID == other.ID)
			{
				return 0;
			}
			return string.Compare(this.Name, other.Name, global::System.StringComparison.InvariantCulture);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0005D62C File Offset: 0x0005B82C
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.MetricPacket);
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0005D63C File Offset: 0x0005B83C
		public bool Equals(global::Gibraltar.Monitor.Internal.MetricPacket other)
		{
			return other != null && (this.InstanceName == other.InstanceName && this.DefinitionId == other.DefinitionId) && base.Equals(other);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0005D68C File Offset: 0x0005B88C
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			if (this.m_InstanceName != null)
			{
				num ^= this.m_InstanceName.GetHashCode();
			}
			return num ^ this.m_DefinitionId.GetHashCode();
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0005D6D4 File Offset: 0x0005B8D4
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0005D6DC File Offset: 0x0005B8DC
		internal global::Gibraltar.Monitor.Internal.MetricDefinitionPacket DefinitionPacket
		{
			get
			{
				return this.m_MetricDefinitionPacket;
			}
			private set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				if (value.ID != this.DefinitionId)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "The definition packet object provided is not the same as the definition of this metric packet based on comparing Id's");
				}
				this.m_MetricDefinitionPacket = value;
				this.Name = global::Gibraltar.Monitor.MetricDefinition.GetKey(this.m_MetricDefinitionPacket.MetricTypeName, this.m_MetricDefinitionPacket.CategoryName, this.m_MetricDefinitionPacket.CounterName, this.InstanceName);
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0005D760 File Offset: 0x0005B960
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

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0005D784 File Offset: 0x0005B984
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return new global::Gibraltar.Serialization.IPacket[]
			{
				this.m_MetricDefinitionPacket
			};
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0005D798 File Offset: 0x0005B998
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, true)
			{
				Fields = 
				{
					{
						"instanceName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"definitionId",
						global::Gibraltar.Serialization.FieldType.Guid
					}
				}
			};
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0005D7E4 File Offset: 0x0005B9E4
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("instanceName", this.m_InstanceName);
			packet.SetField("definitionId", this.m_DefinitionId);
			this.Persisted = true;
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0005D814 File Offset: 0x0005BA14
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("instanceName", out this.m_InstanceName);
				packet.GetField("definitionId", out this.m_DefinitionId);
				this.DefinitionPacket = ((global::Gibraltar.Monitor.MetricDefinition)this.m_Session.MetricDefinitions[this.DefinitionId]).Packet;
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0005D88C File Offset: 0x0005BA8C
		global::Gibraltar.Monitor.Metric global::Gibraltar.Monitor.Internal.IPacketObjectFactory<global::Gibraltar.Monitor.Metric, global::Gibraltar.Monitor.MetricDefinition>.GetDataObject(global::Gibraltar.Monitor.MetricDefinition optionalParent)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040009BB RID: 2491
		private global::System.Guid m_DefinitionId;

		// Token: 0x040009BC RID: 2492
		private string m_InstanceName;

		// Token: 0x040009BD RID: 2493
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x040009BE RID: 2494
		private global::Gibraltar.Monitor.Internal.MetricDefinitionPacket m_MetricDefinitionPacket;

		// Token: 0x040009BF RID: 2495
		private string m_Name;

		// Token: 0x040009C0 RID: 2496
		private bool m_Persisted;

		// Token: 0x040009C1 RID: 2497
		private const int SerializationVersion = 1;
	}
}
