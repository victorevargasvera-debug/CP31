using System;
using Gibraltar.Server.Client.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000123 RID: 291
	internal class HubConfigurationGetRequest : global::Gibraltar.Server.Client.WebChannelRequestBase
	{
		// Token: 0x06000BD8 RID: 3032 RVA: 0x0001DEF0 File Offset: 0x0001C0F0
		public HubConfigurationGetRequest() : base(true, false)
		{
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000BD9 RID: 3033 RVA: 0x0001DEFC File Offset: 0x0001C0FC
		// (set) Token: 0x06000BDA RID: 3034 RVA: 0x0001DF04 File Offset: 0x0001C104
		public global::Gibraltar.Server.Client.Data.HubConfigurationXml Configuration { get; private set; }

		// Token: 0x06000BDB RID: 3035 RVA: 0x0001DF10 File Offset: 0x0001C110
		protected override void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			byte[] rawData = connection.DownloadData("/Configuration.xml", new int?(-1));
			this.Configuration = global::Gibraltar.Server.Client.Data.DataConverter.ByteArrayToHubConfigurationXml(rawData);
		}
	}
}
