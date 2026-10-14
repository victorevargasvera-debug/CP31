using System;
using System.Globalization;
using System.Reflection;
using Gibraltar.Serialization;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000207 RID: 519
	internal class SessionClosePacket : global::Gibraltar.Monitor.Internal.GibraltarPacket, global::Gibraltar.Serialization.IPacket, global::System.IComparable<global::Gibraltar.Monitor.Internal.SessionClosePacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.SessionClosePacket>
	{
		// Token: 0x0600199C RID: 6556 RVA: 0x0005A2B0 File Offset: 0x000584B0
		public SessionClosePacket()
		{
			this.Id = global::System.Guid.NewGuid();
			this.EndingStatus = global::Loupe.Extensibility.Data.SessionStatus.Normal;
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x0005A2CC File Offset: 0x000584CC
		public SessionClosePacket(global::Loupe.Extensibility.Data.SessionStatus endingStatus)
		{
			this.Id = global::System.Guid.NewGuid();
			this.EndingStatus = endingStatus;
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0005A2E8 File Offset: 0x000584E8
		public SessionClosePacket(global::Gibraltar.Monitor.Session session)
		{
			this.m_Session = session;
			this.EndingStatus = global::Loupe.Extensibility.Data.SessionStatus.Normal;
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x0600199F RID: 6559 RVA: 0x0005A300 File Offset: 0x00058500
		// (set) Token: 0x060019A0 RID: 6560 RVA: 0x0005A308 File Offset: 0x00058508
		public global::System.Guid Id
		{
			get
			{
				return this.m_Id;
			}
			private set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x0005A314 File Offset: 0x00058514
		// (set) Token: 0x060019A2 RID: 6562 RVA: 0x0005A31C File Offset: 0x0005851C
		public global::Loupe.Extensibility.Data.SessionStatus EndingStatus
		{
			get
			{
				return this.m_EndingStatus;
			}
			set
			{
				this.m_EndingStatus = value;
			}
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0005A328 File Offset: 0x00058528
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, "Session Close: Status is {0}", new object[]
			{
				this.m_EndingStatus
			});
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0005A350 File Offset: 0x00058550
		public int CompareTo(global::Gibraltar.Monitor.Internal.SessionClosePacket other)
		{
			if (this.Id == other.Id)
			{
				return 0;
			}
			return base.Sequence.CompareTo(other.Sequence);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0005A390 File Offset: 0x00058590
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.SessionClosePacket);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0005A3A0 File Offset: 0x000585A0
		public bool Equals(global::Gibraltar.Monitor.Internal.SessionClosePacket other)
		{
			return other != null && (this.Id == other.Id && this.EndingStatus == other.EndingStatus) && base.Equals(other);
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x0005A3EC File Offset: 0x000585EC
		public override int GetHashCode()
		{
			return base.GetHashCode() ^ this.Id.GetHashCode() ^ this.EndingStatus.GetHashCode();
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0005A430 File Offset: 0x00058630
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			return null;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0005A434 File Offset: 0x00058634
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			return new global::Gibraltar.Serialization.PacketDefinition(global::System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.Name, 1, false)
			{
				Fields = 
				{
					{
						"Id",
						global::Gibraltar.Serialization.FieldType.Guid
					},
					{
						"Status",
						global::Gibraltar.Serialization.FieldType.Int32
					}
				}
			};
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0005A480 File Offset: 0x00058680
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			packet.SetField("Id", this.m_Id);
			packet.SetField("Status", (int)this.m_EndingStatus);
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x0005A4B0 File Offset: 0x000586B0
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			int version = definition.Version;
			if (version == 1)
			{
				packet.GetField("Id", out this.m_Id);
				int endingStatus;
				packet.GetField("Status", out endingStatus);
				this.m_EndingStatus = (global::Loupe.Extensibility.Data.SessionStatus)endingStatus;
			}
		}

		// Token: 0x04000955 RID: 2389
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x04000956 RID: 2390
		private global::System.Guid m_Id;

		// Token: 0x04000957 RID: 2391
		private global::Loupe.Extensibility.Data.SessionStatus m_EndingStatus;

		// Token: 0x04000958 RID: 2392
		private const int SerializationVersion = 1;
	}
}
