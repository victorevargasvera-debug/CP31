using System;

namespace Gibraltar.Messaging
{
	// Token: 0x0200022B RID: 555
	internal class LogMessageNotifyEventArgs : global::System.EventArgs
	{
		// Token: 0x06001BEB RID: 7147 RVA: 0x00061F40 File Offset: 0x00060140
		internal LogMessageNotifyEventArgs(global::Gibraltar.Messaging.IMessengerPacket packet)
		{
			this.Packet = packet;
		}

		// Token: 0x04000A15 RID: 2581
		internal readonly global::Gibraltar.Messaging.IMessengerPacket Packet;
	}
}
