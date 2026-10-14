using System;
using Gibraltar.Serialization;

namespace Gibraltar.Messaging
{
	// Token: 0x02000232 RID: 562
	internal class CommandPacket : global::Gibraltar.Messaging.IMessengerPacket, global::Gibraltar.Serialization.IPacket
	{
		// Token: 0x06001C35 RID: 7221 RVA: 0x00063298 File Offset: 0x00061498
		public CommandPacket(global::Gibraltar.Messaging.MessagingCommand command)
		{
			this.Command = command;
			this.State = null;
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x000632B0 File Offset: 0x000614B0
		public CommandPacket(global::Gibraltar.Messaging.MessagingCommand command, object state)
		{
			this.Command = command;
			this.State = state;
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06001C37 RID: 7223 RVA: 0x000632C8 File Offset: 0x000614C8
		// (set) Token: 0x06001C38 RID: 7224 RVA: 0x000632D0 File Offset: 0x000614D0
		public global::Gibraltar.Messaging.MessagingCommand Command { get; private set; }

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06001C39 RID: 7225 RVA: 0x000632DC File Offset: 0x000614DC
		// (set) Token: 0x06001C3A RID: 7226 RVA: 0x000632E4 File Offset: 0x000614E4
		public object State { get; private set; }

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x06001C3B RID: 7227 RVA: 0x000632F0 File Offset: 0x000614F0
		// (set) Token: 0x06001C3C RID: 7228 RVA: 0x000632F8 File Offset: 0x000614F8
		public global::System.DateTimeOffset Timestamp { get; set; }

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00063304 File Offset: 0x00061504
		// (set) Token: 0x06001C3E RID: 7230 RVA: 0x0006330C File Offset: 0x0006150C
		public long Sequence { get; set; }

		// Token: 0x06001C3F RID: 7231 RVA: 0x00063318 File Offset: 0x00061518
		global::Gibraltar.Serialization.IPacket[] global::Gibraltar.Serialization.IPacket.GetRequiredPackets()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00063320 File Offset: 0x00061520
		global::Gibraltar.Serialization.PacketDefinition global::Gibraltar.Serialization.IPacket.GetPacketDefinition()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00063328 File Offset: 0x00061528
		void global::Gibraltar.Serialization.IPacket.WriteFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00063330 File Offset: 0x00061530
		void global::Gibraltar.Serialization.IPacket.ReadFields(global::Gibraltar.Serialization.PacketDefinition definition, global::Gibraltar.Serialization.SerializedPacket packet)
		{
			throw new global::System.NotSupportedException();
		}
	}
}
