using System;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x0200020B RID: 523
	internal class ThreadInfoPacket : global::Gibraltar.Monitor.Internal.GibraltarCachedPacket, global::Gibraltar.Serialization.IPacket, global::System.IEquatable<global::Gibraltar.Monitor.Internal.ThreadInfoPacket>, global::Loupe.Extensibility.Data.IThreadInfo
	{
		// Token: 0x06001A15 RID: 6677 RVA: 0x0005BBEC File Offset: 0x00059DEC
		public ThreadInfoPacket() : base(false)
		{
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x0005BBF8 File Offset: 0x00059DF8
		// (set) Token: 0x06001A17 RID: 6679 RVA: 0x0005BC00 File Offset: 0x00059E00
		public int ThreadIndex
		{
			get
			{
				return this.m_ThreadIndex;
			}
			set
			{
				this.m_ThreadIndex = value;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x0005BC0C File Offset: 0x00059E0C
		// (set) Token: 0x06001A19 RID: 6681 RVA: 0x0005BC14 File Offset: 0x00059E14
		public int ThreadId
		{
			get
			{
				return this.m_ThreadId;
			}
			set
			{
				this.m_ThreadId = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06001A1A RID: 6682 RVA: 0x0005BC20 File Offset: 0x00059E20
		// (set) Token: 0x06001A1B RID: 6683 RVA: 0x0005BC28 File Offset: 0x00059E28
		public string ThreadName
		{
			get
			{
				return this.m_ThreadName;
			}
			set
			{
				this.m_ThreadName = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06001A1C RID: 6684 RVA: 0x0005BC34 File Offset: 0x00059E34
		// (set) Token: 0x06001A1D RID: 6685 RVA: 0x0005BC3C File Offset: 0x00059E3C
		public int DomainId
		{
			get
			{
				return this.m_DomainId;
			}
			set
			{
				this.m_DomainId = value;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x0005BC48 File Offset: 0x00059E48
		// (set) Token: 0x06001A1F RID: 6687 RVA: 0x0005BC50 File Offset: 0x00059E50
		public string DomainName
		{
			get
			{
				return this.m_DomainName;
			}
			set
			{
				this.m_DomainName = value;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x06001A20 RID: 6688 RVA: 0x0005BC5C File Offset: 0x00059E5C
		// (set) Token: 0x06001A21 RID: 6689 RVA: 0x0005BC64 File Offset: 0x00059E64
		public bool IsBackground
		{
			get
			{
				return this.m_IsBackground;
			}
			set
			{
				this.m_IsBackground = value;
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x0005BC70 File Offset: 0x00059E70
		// (set) Token: 0x06001A23 RID: 6691 RVA: 0x0005BC78 File Offset: 0x00059E78
		public bool IsThreadPoolThread
		{
			get
			{
				return this.m_IsThreadPoolThread;
			}
			set
			{
				this.m_IsThreadPoolThread = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001A24 RID: 6692 RVA: 0x0005BC84 File Offset: 0x00059E84
		global::Loupe.Extensibility.Data.ISession global::Loupe.Extensibility.Data.IThreadInfo.Session
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0005BC88 File Offset: 0x00059E88
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.ThreadInfoPacket);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0005BC98 File Offset: 0x00059E98
		public bool Equals(global::Gibraltar.Monitor.Internal.ThreadInfoPacket other)
		{
			return other != null && (this.ThreadIndex == other.ThreadIndex && this.ThreadId == other.ThreadId && this.ThreadName == other.ThreadName && this.DomainId == other.DomainId && this.DomainName == other.DomainName && this.IsBackground == other.IsBackground && this.IsThreadPoolThread == other.IsThreadPoolThread) && base.Equals(other);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0005BD3C File Offset: 0x00059F3C
		public override int GetHashCode()
		{
			int num = base.GetHashCode();
			num ^= (this.m_ThreadId ^ this.m_DomainId);
			num ^= this.m_ThreadIndex << 16;
			if (this.m_ThreadName != null)
			{
				num ^= this.m_ThreadName.GetHashCode();
			}
			if (this.m_DomainName != null)
			{
				num ^= this.m_DomainName.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0005BDA4 File Offset: 0x00059FA4
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0005BDA8 File Offset: 0x00059FA8
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"ThreadIndex",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"ThreadId",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"ThreadName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"DomainId",
						global::Gibraltar.Serialization.FieldType.Int32
					},
					{
						"DomainName",
						global::Gibraltar.Serialization.FieldType.String
					},
					{
						"IsBackground",
						global::Gibraltar.Serialization.FieldType.Bool
					},
					{
						"IsThreadPoolThread",
						global::Gibraltar.Serialization.FieldType.Bool
					}
				}
			};
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0005BE48 File Offset: 0x0005A048
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("ThreadIndex", this.m_ThreadIndex);
			packet.SetField("ThreadId", this.m_ThreadId);
			packet.SetField("ThreadName", this.m_ThreadName);
			packet.SetField("DomainId", this.m_DomainId);
			packet.SetField("DomainName", this.m_DomainName);
			packet.SetField("IsBackground", this.m_IsBackground);
			packet.SetField("IsThreadPoolThread", this.m_IsThreadPoolThread);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0005BEEC File Offset: 0x0005A0EC
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("ThreadId", out this.m_ThreadId);
				if (definition.Fields.ContainsKey("ThreadIndex"))
				{
					packet.GetField("ThreadIndex", out this.m_ThreadIndex);
					if (this.m_ThreadIndex == 0)
					{
						this.m_ThreadIndex = this.m_ThreadId;
					}
				}
				else
				{
					this.m_ThreadIndex = this.m_ThreadId;
				}
				packet.GetField("ThreadName", out this.m_ThreadName);
				packet.GetField("DomainId", out this.m_DomainId);
				packet.GetField("DomainName", out this.m_DomainName);
				packet.GetField("IsBackground", out this.m_IsBackground);
				packet.GetField("IsThreadPoolThread", out this.m_IsThreadPoolThread);
			}
		}

		// Token: 0x0400098A RID: 2442
		private int m_ThreadIndex;

		// Token: 0x0400098B RID: 2443
		private int m_ThreadId;

		// Token: 0x0400098C RID: 2444
		private string m_ThreadName;

		// Token: 0x0400098D RID: 2445
		private int m_DomainId;

		// Token: 0x0400098E RID: 2446
		private string m_DomainName;

		// Token: 0x0400098F RID: 2447
		private bool m_IsBackground;

		// Token: 0x04000990 RID: 2448
		private bool m_IsThreadPoolThread;

		// Token: 0x04000991 RID: 2449
		private const int SerializationVersion = 1;
	}
}
