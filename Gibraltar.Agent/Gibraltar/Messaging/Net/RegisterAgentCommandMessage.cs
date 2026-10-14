using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x0200024F RID: 591
	internal class RegisterAgentCommandMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001DA2 RID: 7586 RVA: 0x00068A0C File Offset: 0x00066C0C
		internal RegisterAgentCommandMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.RegisterAgentCommand;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00068A28 File Offset: 0x00066C28
		public RegisterAgentCommandMessage(global::System.Guid sessionId) : this()
		{
			this.m_SessionId = sessionId;
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06001DA4 RID: 7588 RVA: 0x00068A38 File Offset: 0x00066C38
		public global::System.Guid SessionId
		{
			get
			{
				return this.m_SessionId;
			}
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x00068A40 File Offset: 0x00066C40
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_SessionId);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x00068A50 File Offset: 0x00066C50
		protected override void OnRead(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_SessionId);
		}

		// Token: 0x04000B0A RID: 2826
		private global::System.Guid m_SessionId;
	}
}
