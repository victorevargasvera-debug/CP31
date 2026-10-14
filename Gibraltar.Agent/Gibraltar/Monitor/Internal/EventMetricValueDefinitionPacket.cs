using System;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000213 RID: 531
	internal class EventMetricValueDefinitionPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.ICachedPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket>, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x06001A72 RID: 6770 RVA: 0x0005C84C File Offset: 0x0005AA4C
		public EventMetricValueDefinitionPacket(global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket definition, string name, global::System.Type type) : base(false)
		{
			this.m_EventDefinitionPacketId = definition.ID;
			this.m_Name = name;
			this.SetType(type);
			this.m_Caption = name;
		}

		// Token: 0x06001A73 RID: 6771 RVA: 0x0005C878 File Offset: 0x0005AA78
		public EventMetricValueDefinitionPacket(global::Gibraltar.Monitor.Internal.EventMetricDefinitionPacket definition, string name, global::System.Type type, string caption, string description) : base(false)
		{
			this.m_EventDefinitionPacketId = definition.ID;
			base.ID = global::System.Guid.NewGuid();
			this.m_Name = name;
			this.SetType(type);
			this.m_Caption = caption;
			this.m_Description = description;
		}

		// Token: 0x06001A74 RID: 6772 RVA: 0x0005C8C8 File Offset: 0x0005AAC8
		internal EventMetricValueDefinitionPacket(global::Gibraltar.Monitor.Session session) : base(false)
		{
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001A75 RID: 6773 RVA: 0x0005C8D4 File Offset: 0x0005AAD4
		// (set) Token: 0x06001A76 RID: 6774 RVA: 0x0005C8DC File Offset: 0x0005AADC
		public global::Loupe.Extensibility.Data.EventMetricValueTrend DefaultTrend
		{
			get
			{
				return this.m_DefaultTrend;
			}
			set
			{
				this.m_DefaultTrend = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06001A77 RID: 6775 RVA: 0x0005C8E8 File Offset: 0x0005AAE8
		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06001A78 RID: 6776 RVA: 0x0005C8F0 File Offset: 0x0005AAF0
		// (set) Token: 0x06001A79 RID: 6777 RVA: 0x0005C8F8 File Offset: 0x0005AAF8
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = ((value == null) ? this.Name : value.Trim());
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0005C918 File Offset: 0x0005AB18
		// (set) Token: 0x06001A7B RID: 6779 RVA: 0x0005C920 File Offset: 0x0005AB20
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = ((value == null) ? null : value.Trim());
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001A7C RID: 6780 RVA: 0x0005C93C File Offset: 0x0005AB3C
		// (set) Token: 0x06001A7D RID: 6781 RVA: 0x0005C944 File Offset: 0x0005AB44
		public global::System.Type Type { get; private set; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001A7E RID: 6782 RVA: 0x0005C950 File Offset: 0x0005AB50
		// (set) Token: 0x06001A7F RID: 6783 RVA: 0x0005C958 File Offset: 0x0005AB58
		public global::System.Type SerializedType { get; private set; }

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0005C964 File Offset: 0x0005AB64
		// (set) Token: 0x06001A81 RID: 6785 RVA: 0x0005C96C File Offset: 0x0005AB6C
		public string UnitCaption
		{
			get
			{
				return this.m_UnitCaption;
			}
			set
			{
				this.m_UnitCaption = ((value == null) ? null : value.Trim());
			}
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x0005C988 File Offset: 0x0005AB88
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0005C998 File Offset: 0x0005AB98
		public bool Equals(global::Gibraltar.Monitor.Internal.EventMetricValueDefinitionPacket other)
		{
			return other != null && (this.m_Name == other.m_Name && this.Type == other.Type && this.m_Caption == other.m_Caption && this.m_Description == other.m_Description && this.m_DefaultTrend == other.m_DefaultTrend && this.m_EventDefinitionPacketId == other.m_EventDefinitionPacketId && this.m_UnitCaption == other.m_UnitCaption) && base.Equals(other);
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0005CA4C File Offset: 0x0005AC4C
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			num ^= this.m_EventDefinitionPacketId.GetHashCode();
			if (this.m_Name != null)
			{
				num ^= this.m_Name.GetHashCode();
			}
			if (this.m_Caption != null)
			{
				num ^= this.m_Caption.GetHashCode();
			}
			if (this.m_Description != null)
			{
				num ^= this.m_Description.GetHashCode();
			}
			if (this.m_UnitCaption != null)
			{
				num ^= this.m_UnitCaption.GetHashCode();
			}
			if (this.Type != null)
			{
				num ^= this.Type.GetHashCode();
			}
			return num;
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x06001A85 RID: 6789 RVA: 0x0005CAF8 File Offset: 0x0005ACF8
		internal global::System.Guid DefinitionId
		{
			get
			{
				return this.m_EventDefinitionPacketId;
			}
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0005CB00 File Offset: 0x0005AD00
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x0005CB04 File Offset: 0x0005AD04
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"name",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"valueType",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"caption",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"description",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"defaultTrend",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"eventDefinitionPacketId",
						global::Gibraltar.Serialization.FieldType.Guid
					},
					{
						"unitCaption",
						global::Gibraltar.Serialization.FieldType.String
					}
				}
			};
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0005CBA4 File Offset: 0x0005ADA4
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("name", this.m_Name);
			packet.SetField("valueType", this.SerializedType.FullName);
			packet.SetField("caption", this.m_Caption);
			packet.SetField("description", this.m_Description);
			packet.SetField("defaultTrend", (int)this.m_DefaultTrend);
			packet.SetField("eventDefinitionPacketId", this.m_EventDefinitionPacketId);
			packet.SetField("unitCaption", this.m_UnitCaption);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0005CC3C File Offset: 0x0005AE3C
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("name", out this.m_Name);
				string typeName;
				packet.GetField("valueType", out typeName);
				this.SetType(global::System.Type.GetType(typeName));
				packet.GetField("caption", out this.m_Caption);
				packet.GetField("description", out this.m_Description);
				int defaultTrend;
				packet.GetField("defaultTrend", out defaultTrend);
				this.m_DefaultTrend = (global::Loupe.Extensibility.Data.EventMetricValueTrend)defaultTrend;
				packet.GetField("eventDefinitionPacketId", out this.m_EventDefinitionPacketId);
				packet.GetField("unitCaption", out this.m_UnitCaption);
				return;
			}
			throw new global::Gibraltar.GibraltarPacketVersionException(definition.Version);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0005CCEC File Offset: 0x0005AEEC
		private void SetType(global::System.Type originalType)
		{
			this.Type = originalType;
			this.SerializedType = (global::Gibraltar.Monitor.EventMetricDefinition.IsTrendableValueType(originalType) ? originalType : typeof(string));
		}

		// Token: 0x040009A1 RID: 2465
		private string m_Name;

		// Token: 0x040009A2 RID: 2466
		private string m_Caption;

		// Token: 0x040009A3 RID: 2467
		private string m_Description;

		// Token: 0x040009A4 RID: 2468
		private string m_UnitCaption;

		// Token: 0x040009A5 RID: 2469
		private global::Loupe.Extensibility.Data.EventMetricValueTrend m_DefaultTrend;

		// Token: 0x040009A6 RID: 2470
		private global::System.Guid m_EventDefinitionPacketId;

		// Token: 0x040009A9 RID: 2473
		private const int SerializationVersion = 1;
	}
}
