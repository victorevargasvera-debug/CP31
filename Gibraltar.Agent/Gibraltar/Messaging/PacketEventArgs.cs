using System;

namespace Gibraltar.Messaging
{
	// Token: 0x0200023E RID: 574
	internal class PacketEventArgs : global::System.EventArgs
	{
		// Token: 0x06001CEC RID: 7404 RVA: 0x00066010 File Offset: 0x00064210
		internal PacketEventArgs(global::Gibraltar.Messaging.IMessengerPacket packet)
		{
			this.m_Packet = packet;
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x00066020 File Offset: 0x00064220
		internal global::Gibraltar.Messaging.IMessengerPacket Packet
		{
			get
			{
				return this.m_Packet;
			}
		}

		// Token: 0x04000AB6 RID: 2742
		private readonly global::Gibraltar.Messaging.IMessengerPacket m_Packet;
	}
}
