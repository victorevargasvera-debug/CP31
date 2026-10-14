using System;
using Gibraltar.Server.Client.Data;
using Gibraltar.Server.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200017B RID: 379
	internal class SessionHeaderUploadRequest : global::Gibraltar.Server.Client.WebChannelRequestBase
	{
		// Token: 0x06000FB0 RID: 4016 RVA: 0x0002AC24 File Offset: 0x00028E24
		public SessionHeaderUploadRequest(global::Gibraltar.Server.Client.Data.SessionXml sessionHeader, global::System.Guid clientId) : base(true, false)
		{
			this.ClientId = clientId;
			this.SessionHeader = sessionHeader;
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06000FB1 RID: 4017 RVA: 0x0002AC3C File Offset: 0x00028E3C
		// (set) Token: 0x06000FB2 RID: 4018 RVA: 0x0002AC44 File Offset: 0x00028E44
		public global::System.Guid ClientId { get; private set; }

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x0002AC50 File Offset: 0x00028E50
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0002AC58 File Offset: 0x00028E58
		public global::Gibraltar.Server.Client.Data.SessionXml SessionHeader { get; private set; }

		// Token: 0x06000FB5 RID: 4021 RVA: 0x0002AC64 File Offset: 0x00028E64
		protected override void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			string relativeUrl = string.Format("Hosts/{0}/Sessions/{1}/session.xml", this.ClientId, this.SessionHeader.id);
			byte[] data = global::Gibraltar.Server.Data.DataConverter.SessionXmlToByteArray(this.SessionHeader);
			connection.UploadData(relativeUrl, "POST", "text/xml", data, null, new int?(-1));
		}
	}
}
