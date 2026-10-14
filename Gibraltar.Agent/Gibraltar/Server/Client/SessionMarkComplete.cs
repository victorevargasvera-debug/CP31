using System;
using Gibraltar.Server.Client.Data;
using Gibraltar.Server.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200017C RID: 380
	internal class SessionMarkComplete : global::Gibraltar.Server.Client.WebChannelRequestBase
	{
		// Token: 0x06000FB6 RID: 4022 RVA: 0x0002ACBC File Offset: 0x00028EBC
		public SessionMarkComplete(global::System.Guid sessionId, global::System.Guid clientId) : base(true, false)
		{
			this.SessionId = sessionId;
			this.ClientId = clientId;
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000FB7 RID: 4023 RVA: 0x0002ACD4 File Offset: 0x00028ED4
		// (set) Token: 0x06000FB8 RID: 4024 RVA: 0x0002ACDC File Offset: 0x00028EDC
		public global::System.Guid ClientId { get; private set; }

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000FB9 RID: 4025 RVA: 0x0002ACE8 File Offset: 0x00028EE8
		// (set) Token: 0x06000FBA RID: 4026 RVA: 0x0002ACF0 File Offset: 0x00028EF0
		public global::System.Guid SessionId { get; private set; }

		// Token: 0x06000FBB RID: 4027 RVA: 0x0002ACFC File Offset: 0x00028EFC
		protected override void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			string relativeUrl = string.Format("Hosts/{0}/Sessions/{1}/session.xml", this.ClientId, this.SessionId);
			byte[] data = global::Gibraltar.Server.Data.DataConverter.SessionXmlToByteArray(new global::Gibraltar.Server.Client.Data.SessionXml
			{
				id = this.SessionId.ToString(),
				isComplete = true,
				isCompleteSpecified = true
			});
			connection.UploadData(relativeUrl, "POST", "text/xml", data, null, new int?(-1));
		}
	}
}
