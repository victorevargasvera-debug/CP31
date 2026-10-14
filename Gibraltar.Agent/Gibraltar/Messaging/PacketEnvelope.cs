using System;
using System.Threading;

namespace Gibraltar.Messaging
{
	// Token: 0x0200023B RID: 571
	internal class PacketEnvelope
	{
		// Token: 0x06001CC1 RID: 7361 RVA: 0x00064FD0 File Offset: 0x000631D0
		public PacketEnvelope(global::Gibraltar.Messaging.IMessengerPacket packet, bool writeThrough)
		{
			this.m_Packet = packet;
			this.m_WriteThrough = writeThrough;
			if (packet is global::Gibraltar.Messaging.CommandPacket)
			{
				this.m_IsCommand = true;
			}
			else
			{
				this.m_IsCommand = false;
			}
			global::Gibraltar.Messaging.ICachedMessengerPacket cachedMessengerPacket = packet as global::Gibraltar.Messaging.ICachedMessengerPacket;
			if (cachedMessengerPacket != null)
			{
				this.m_IsHeader = cachedMessengerPacket.IsHeader;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x0006502C File Offset: 0x0006322C
		public bool IsCommand
		{
			get
			{
				return this.m_IsCommand;
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x00065034 File Offset: 0x00063234
		public bool IsHeader
		{
			get
			{
				return this.m_IsHeader;
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x0006503C File Offset: 0x0006323C
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x00065044 File Offset: 0x00063244
		public bool IsCommitted
		{
			get
			{
				return this.m_Committed;
			}
			set
			{
				lock (this)
				{
					if (value && !this.m_Committed)
					{
						this.m_Committed = true;
					}
					global::System.Threading.Monitor.PulseAll(this);
				}
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x06001CC6 RID: 7366 RVA: 0x00065094 File Offset: 0x00063294
		// (set) Token: 0x06001CC7 RID: 7367 RVA: 0x0006509C File Offset: 0x0006329C
		public bool IsPending
		{
			get
			{
				return this.m_Pending;
			}
			set
			{
				lock (this)
				{
					if (value != this.m_Pending)
					{
						this.m_Pending = value;
					}
					global::System.Threading.Monitor.PulseAll(this);
				}
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x06001CC8 RID: 7368 RVA: 0x000650E8 File Offset: 0x000632E8
		public global::Gibraltar.Messaging.IMessengerPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x000650F0 File Offset: 0x000632F0
		public bool WriteThrough
		{
			get
			{
				return this.m_WriteThrough;
			}
		}

		// Token: 0x04000A95 RID: 2709
		private readonly global::Gibraltar.Messaging.IMessengerPacket m_Packet;

		// Token: 0x04000A96 RID: 2710
		private readonly bool m_IsCommand;

		// Token: 0x04000A97 RID: 2711
		private readonly bool m_IsHeader;

		// Token: 0x04000A98 RID: 2712
		private readonly bool m_WriteThrough;

		// Token: 0x04000A99 RID: 2713
		private bool m_Committed;

		// Token: 0x04000A9A RID: 2714
		private bool m_Pending;
	}
}
