using System;

namespace CefSharp
{
	// Token: 0x02000095 RID: 149
	public class ResourceRequestHandlerFactoryItem
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x00006A3C File Offset: 0x00004C3C
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00006A44 File Offset: 0x00004C44
		public byte[] Data { get; private set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x00006A4D File Offset: 0x00004C4D
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00006A55 File Offset: 0x00004C55
		public string MimeType { get; private set; }

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00006A5E File Offset: 0x00004C5E
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00006A66 File Offset: 0x00004C66
		public bool OneTimeUse { get; private set; }

		// Token: 0x06000445 RID: 1093 RVA: 0x00006A6F File Offset: 0x00004C6F
		public ResourceRequestHandlerFactoryItem(byte[] data, string mimeType, bool oneTimeUse)
		{
			this.Data = data;
			this.MimeType = mimeType;
			this.OneTimeUse = oneTimeUse;
		}
	}
}
