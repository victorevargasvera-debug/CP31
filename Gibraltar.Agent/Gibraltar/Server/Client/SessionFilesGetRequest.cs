using System;
using Gibraltar.Server.Client.Data;
using Gibraltar.Server.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000178 RID: 376
	internal class SessionFilesGetRequest : global::Gibraltar.Server.Client.WebChannelRequestBase
	{
		// Token: 0x06000F9F RID: 3999 RVA: 0x0002AB08 File Offset: 0x00028D08
		public SessionFilesGetRequest(global::System.Guid sessionId) : base(true, true)
		{
			this.SessionId = sessionId;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0002AB1C File Offset: 0x00028D1C
		public SessionFilesGetRequest(global::System.Guid clientId, global::System.Guid sessionId) : base(true, false)
		{
			this.ClientId = new global::System.Guid?(clientId);
			this.SessionId = sessionId;
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x0002AB3C File Offset: 0x00028D3C
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x0002AB44 File Offset: 0x00028D44
		public global::System.Guid? ClientId { get; private set; }

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x0002AB50 File Offset: 0x00028D50
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x0002AB58 File Offset: 0x00028D58
		public global::System.Guid SessionId { get; set; }

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06000FA5 RID: 4005 RVA: 0x0002AB64 File Offset: 0x00028D64
		// (set) Token: 0x06000FA6 RID: 4006 RVA: 0x0002AB6C File Offset: 0x00028D6C
		public global::Gibraltar.Server.Client.Data.SessionFilesListXml Files { get; private set; }

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0002AB78 File Offset: 0x00028D78
		protected override void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			string relativeUrl;
			if (this.ClientId != null)
			{
				relativeUrl = string.Format("Hosts/{0}/{1}", this.ClientId, this.GenerateResourceUri());
			}
			else
			{
				relativeUrl = string.Format("{0}", this.GenerateResourceUri());
			}
			byte[] rawData = connection.DownloadData(relativeUrl, new int?(-1));
			this.Files = global::Gibraltar.Server.Data.DataConverter.ByteArrayToSessionFilesListXml(rawData);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0002ABE8 File Offset: 0x00028DE8
		private string GenerateResourceUri()
		{
			return string.Format("Sessions/{0}/Files.xml", this.SessionId);
		}
	}
}
