using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000249 RID: 585
	internal class SendSessionCommandMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001D75 RID: 7541 RVA: 0x00067FBC File Offset: 0x000661BC
		internal SendSessionCommandMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.SendSession;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001D76 RID: 7542 RVA: 0x00067FD8 File Offset: 0x000661D8
		public SendSessionCommandMessage(global::System.Guid sessionId, global::Gibraltar.Data.SessionCriteria criteria) : this()
		{
			this.SessionId = sessionId;
			this.Criteria = criteria;
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x00067FF0 File Offset: 0x000661F0
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x00067FF8 File Offset: 0x000661F8
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x00068004 File Offset: 0x00066204
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x0006800C File Offset: 0x0006620C
		public global::Gibraltar.Data.SessionCriteria Criteria
		{
			get
			{
				return this.m_Criteria;
			}
			set
			{
				this.m_Criteria = value;
			}
		}

		// Token: 0x06001D7B RID: 7547 RVA: 0x00068018 File Offset: 0x00066218
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_SessionId);
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, (int)this.m_Criteria);
		}

		// Token: 0x06001D7C RID: 7548 RVA: 0x00068034 File Offset: 0x00066234
		protected override void OnRead(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_SessionId);
			int criteria;
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out criteria);
			this.m_Criteria = (global::Gibraltar.Data.SessionCriteria)criteria;
		}

		// Token: 0x04000AED RID: 2797
		private global::System.Guid m_SessionId;

		// Token: 0x04000AEE RID: 2798
		private global::Gibraltar.Data.SessionCriteria m_Criteria;
	}
}
