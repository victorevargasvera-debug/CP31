using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x0200024C RID: 588
	internal class LiveViewStopCommandMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001D86 RID: 7558 RVA: 0x00068364 File Offset: 0x00066564
		internal LiveViewStopCommandMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.LiveViewStopCommand;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001D87 RID: 7559 RVA: 0x00068380 File Offset: 0x00066580
		public LiveViewStopCommandMessage(global::System.Guid channelId, global::System.Guid sessionId) : this()
		{
			this.ChannelId = channelId;
			this.SessionId = sessionId;
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x00068398 File Offset: 0x00066598
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x000683A0 File Offset: 0x000665A0
		public global::System.Guid ChannelId
		{
			get
			{
				return this.m_ChannelId;
			}
			set
			{
				this.m_ChannelId = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001D8A RID: 7562 RVA: 0x000683AC File Offset: 0x000665AC
		// (set) Token: 0x06001D8B RID: 7563 RVA: 0x000683B4 File Offset: 0x000665B4
		public global::System.Guid SessionId
		{
			get
			{
				return this.m_SessionId;
			}
			set
			{
				this.m_SessionId = value;
			}
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x000683C0 File Offset: 0x000665C0
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_ChannelId);
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_SessionId);
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x000683DC File Offset: 0x000665DC
		protected override void OnRead(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_ChannelId);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_SessionId);
		}

		// Token: 0x04000B00 RID: 2816
		private global::System.Guid m_ChannelId;

		// Token: 0x04000B01 RID: 2817
		private global::System.Guid m_SessionId;
	}
}
