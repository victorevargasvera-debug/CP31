using System;
using Gibraltar.Server.Client.Data;
using Gibraltar.Server.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000177 RID: 375
	internal class RequestedSessionsGetRequest : global::Gibraltar.Server.Client.WebChannelRequestBase
	{
		// Token: 0x06000F99 RID: 3993 RVA: 0x0002AA8C File Offset: 0x00028C8C
		public RequestedSessionsGetRequest(global::System.Guid clientId) : base(true, false)
		{
			this.ClientId = clientId;
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06000F9A RID: 3994 RVA: 0x0002AAA0 File Offset: 0x00028CA0
		// (set) Token: 0x06000F9B RID: 3995 RVA: 0x0002AAA8 File Offset: 0x00028CA8
		public global::System.Guid ClientId { get; private set; }

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06000F9C RID: 3996 RVA: 0x0002AAB4 File Offset: 0x00028CB4
		// (set) Token: 0x06000F9D RID: 3997 RVA: 0x0002AABC File Offset: 0x00028CBC
		public global::Gibraltar.Server.Client.Data.SessionsListXml RequestedSessions { get; private set; }

		// Token: 0x06000F9E RID: 3998 RVA: 0x0002AAC8 File Offset: 0x00028CC8
		protected override void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			byte[] rawData = connection.DownloadData(string.Format("/Hosts/{0}/RequestedSessions.xml", this.ClientId), new int?(-1));
			this.RequestedSessions = global::Gibraltar.Server.Data.DataConverter.ByteArrayToSessionsListXml(rawData);
		}
	}
}
