using System;
using System.Reflection;
using Gibraltar.Serialization;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000208 RID: 520
	internal class SessionFragmentPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.SessionFragmentPacket>
	{
		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x0005A4F4 File Offset: 0x000586F4
		// (set) Token: 0x060019AD RID: 6573 RVA: 0x0005A4FC File Offset: 0x000586FC
		public global::System.DateTimeOffset FileStartDateTime
		{
			get
			{
				return this.m_FileStartDateTime;
			}
			set
			{
				this.m_FileStartDateTime = value;
				if (base.Timestamp == global::System.DateTimeOffset.MinValue)
				{
					base.Timestamp = value;
				}
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x0005A524 File Offset: 0x00058724
		// (set) Token: 0x060019AF RID: 6575 RVA: 0x0005A52C File Offset: 0x0005872C
		public global::System.DateTimeOffset FileEndDateTime
		{
			get
			{
				return this.m_FileEndDateTime;
			}
			set
			{
				this.m_FileEndDateTime = value;
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x0005A538 File Offset: 0x00058738
		// (set) Token: 0x060019B1 RID: 6577 RVA: 0x0005A540 File Offset: 0x00058740
		public bool IsLastFile
		{
			get
			{
				return this.m_IsLastFile;
			}
			set
			{
				this.m_IsLastFile = value;
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x0005A54C File Offset: 0x0005874C
		public SessionFragmentPacket(global::System.Guid m_FileID) : base(m_FileID, true)
		{
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x0005A558 File Offset: 0x00058758
		internal SessionFragmentPacket() : base(false)
		{
		}

		// Token: 0x060019B4 RID: 6580 RVA: 0x0005A564 File Offset: 0x00058764
		public override bool Equals(object other)
		{
			return base.Equals(other as global::Gibraltar.Monitor.Internal.SessionSummaryPacket);
		}

		// Token: 0x060019B5 RID: 6581 RVA: 0x0005A574 File Offset: 0x00058774
		public bool Equals(global::Gibraltar.Monitor.Internal.SessionFragmentPacket other)
		{
			return other != null && (this.FileStartDateTime == other.FileStartDateTime && this.FileEndDateTime == other.FileEndDateTime && this.IsLastFile == other.IsLastFile) && base.Equals(other);
		}

		// Token: 0x060019B6 RID: 6582 RVA: 0x0005A5D4 File Offset: 0x000587D4
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ this.m_FileStartDateTime.GetHashCode() ^ this.m_FileEndDateTime.GetHashCode();
		}

		// Token: 0x060019B7 RID: 6583 RVA: 0x0005A600 File Offset: 0x00058800
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x060019B8 RID: 6584 RVA: 0x0005A604 File Offset: 0x00058804
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"FileStartDateTime",
						global::Gibraltar.Serialization.FieldType.DateTimeOffset
					},
					{
						"FileEndDateTime",
						global::Gibraltar.Serialization.FieldType.DateTimeOffset
					},
					{
						"IsLastFile",
						global::Gibraltar.Serialization.FieldType.Bool
					}
				}
			};
		}

		// Token: 0x060019B9 RID: 6585 RVA: 0x0005A660 File Offset: 0x00058860
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("FileStartDateTime", this.m_FileStartDateTime);
			packet.SetField("FileEndDateTime", this.m_FileEndDateTime);
			packet.SetField("IsLastFile", this.m_IsLastFile);
		}

		// Token: 0x060019BA RID: 6586 RVA: 0x0005A6B4 File Offset: 0x000588B4
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("FileStartDateTime", out this.m_FileStartDateTime);
				packet.GetField("FileEndDateTime", out this.m_FileEndDateTime);
				packet.GetField("IsLastFile", out this.m_IsLastFile);
			}
		}

		// Token: 0x04000959 RID: 2393
		private global::System.DateTimeOffset m_FileStartDateTime;

		// Token: 0x0400095A RID: 2394
		private global::System.DateTimeOffset m_FileEndDateTime;

		// Token: 0x0400095B RID: 2395
		private bool m_IsLastFile;

		// Token: 0x0400095C RID: 2396
		private const int SerializationVersion = 1;
	}
}
