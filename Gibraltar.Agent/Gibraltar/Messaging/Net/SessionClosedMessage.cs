using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000251 RID: 593
	internal class SessionClosedMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001DAD RID: 7597 RVA: 0x00068ADC File Offset: 0x00066CDC
		internal SessionClosedMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.SessionClosed;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00068AF8 File Offset: 0x00066CF8
		public SessionClosedMessage(global::System.Guid sessionId) : this()
		{
			this.SessionId = sessionId;
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x00068B08 File Offset: 0x00066D08
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x00068B10 File Offset: 0x00066D10
		public global::System.Guid SessionId
		{
			get
			{
				return this.m_SessionId;
			}
			private set
			{
				this.m_SessionId = value;
			}
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x00068B1C File Offset: 0x00066D1C
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_SessionId);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x00068B2C File Offset: 0x00066D2C
		protected override void OnRead(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_SessionId);
		}

		// Token: 0x04000B0D RID: 2829
		private global::System.Guid m_SessionId;
	}
}
