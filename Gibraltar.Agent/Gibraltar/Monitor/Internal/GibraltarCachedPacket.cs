using System;
using System.Reflection;
using Gibraltar.Messaging;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000200 RID: 512
	internal abstract class GibraltarCachedPacket : global::Gibraltar.Messaging.ICachedMessengerPacket, global::Gibraltar.Serialization.ICachedPacket, global::Gibraltar.Serialization.IPacket, global::Gibraltar.Messaging.IMessengerPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.GibraltarCachedPacket>
	{
		// Token: 0x06001964 RID: 6500 RVA: 0x00059660 File Offset: 0x00057860
		protected GibraltarCachedPacket(global::System.Guid packetID, bool isHeader)
		{
			this.ID = packetID;
			this.m_IsHeader = isHeader;
		}

		// Token: 0x06001965 RID: 6501 RVA: 0x00059678 File Offset: 0x00057878
		protected GibraltarCachedPacket(bool isHeader)
		{
			this.ID = global::System.Guid.NewGuid();
			this.m_IsHeader = isHeader;
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00059694 File Offset: 0x00057894
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x0005969C File Offset: 0x0005789C
		public long Sequence
		{
			get
			{
				return this.m_Sequence;
			}
			set
			{
				this.m_Sequence = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x000596A8 File Offset: 0x000578A8
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x000596B0 File Offset: 0x000578B0
		public global::System.DateTimeOffset Timestamp
		{
			get
			{
				return this.m_TimeStamp;
			}
			set
			{
				this.m_TimeStamp = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x000596BC File Offset: 0x000578BC
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x000596C4 File Offset: 0x000578C4
		public global::System.Guid ID
		{
			get
			{
				return this.m_ID;
			}
			set
			{
				this.m_ID = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x000596D0 File Offset: 0x000578D0
		public bool IsHeader
		{
			get
			{
				return this.m_IsHeader;
			}
		}

		// Token: 0x0600196D RID: 6509 RVA: 0x000596D8 File Offset: 0x000578D8
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.GibraltarCachedPacket);
		}

		// Token: 0x0600196E RID: 6510 RVA: 0x000596E8 File Offset: 0x000578E8
		public bool Equals(global::Gibraltar.Monitor.Internal.GibraltarCachedPacket other)
		{
			return other != null && (this.Sequence == other.Sequence && this.Timestamp == other.Timestamp) && this.ID == other.ID;
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x0005973C File Offset: 0x0005793C
		public override int GetHashCode()
		{
			return (int)(this.m_Sequence >> 32) ^ (int)this.m_Sequence ^ this.m_TimeStamp.GetHashCode() ^ this.m_ID.GetHashCode();
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00059774 File Offset: 0x00057974
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00059778 File Offset: 0x00057978
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"Sequence",
						global::Gibraltar.Serialization.FieldType.Int64
					},
					{
						"TimeStamp",
						global::Gibraltar.Serialization.FieldType.DateTimeOffset
					},
					{
						"ID",
						global::Gibraltar.Serialization.FieldType.Guid
					},
					{
						"IsHeader",
						global::Gibraltar.Serialization.FieldType.Bool
					}
				}
			};
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x000597E8 File Offset: 0x000579E8
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("Sequence", this.m_Sequence);
			packet.SetField("TimeStamp", this.m_TimeStamp);
			packet.SetField("ID", this.m_ID);
			packet.SetField("IsHeader", this.m_IsHeader);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00059854 File Offset: 0x00057A54
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("Sequence", out this.m_Sequence);
				packet.GetField("TimeStamp", out this.m_TimeStamp);
				packet.GetField("ID", out this.m_ID);
				packet.GetField("IsHeader", out this.m_IsHeader);
			}
		}

		// Token: 0x04000935 RID: 2357
		private long m_Sequence;

		// Token: 0x04000936 RID: 2358
		private global::System.DateTimeOffset m_TimeStamp;

		// Token: 0x04000937 RID: 2359
		private global::System.Guid m_ID;

		// Token: 0x04000938 RID: 2360
		private bool m_IsHeader;

		// Token: 0x04000939 RID: 2361
		private const int Version = 1;
	}
}
