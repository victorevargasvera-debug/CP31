using System;
using System.IO;
using Gibraltar.Data;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x02000250 RID: 592
	internal class RegisterAnalystCommandMessage : global::Gibraltar.Messaging.Net.NetworkMessage
	{
		// Token: 0x06001DA7 RID: 7591 RVA: 0x00068A60 File Offset: 0x00066C60
		internal RegisterAnalystCommandMessage()
		{
			base.TypeCode = global::Gibraltar.Messaging.Net.NetworkMessageTypeCode.RegisterAnalystCommand;
			base.Version = new global::System.Version(1, 0);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00068A7C File Offset: 0x00066C7C
		public RegisterAnalystCommandMessage(global::System.Guid repositoryId, string userName) : this()
		{
			this.m_RepositoryId = repositoryId;
			this.m_UserName = userName;
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x00068A94 File Offset: 0x00066C94
		public string UserName
		{
			get
			{
				return this.m_UserName;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06001DAA RID: 7594 RVA: 0x00068A9C File Offset: 0x00066C9C
		public global::System.Guid RepositoryId
		{
			get
			{
				return this.m_RepositoryId;
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00068AA4 File Offset: 0x00066CA4
		protected override void OnWrite(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_RepositoryId);
			global::Gibraltar.Data.BinarySerializer.SerializeValue(stream, this.m_UserName);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x00068AC0 File Offset: 0x00066CC0
		protected override void OnRead(global::System.IO.Stream stream)
		{
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_RepositoryId);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(stream, out this.m_UserName);
		}

		// Token: 0x04000B0B RID: 2827
		private string m_UserName;

		// Token: 0x04000B0C RID: 2828
		private global::System.Guid m_RepositoryId;
	}
}
