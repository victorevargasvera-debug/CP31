using System;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200003C RID: 60
	public class XWPFHyperlink
	{
		// Token: 0x06000226 RID: 550 RVA: 0x000082A0 File Offset: 0x000064A0
		public XWPFHyperlink(string id, string url)
		{
			this.id = id;
			this.url = url;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000082B6 File Offset: 0x000064B6
		public string Id
		{
			get
			{
				return this.id;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000228 RID: 552 RVA: 0x000082BE File Offset: 0x000064BE
		public string URL
		{
			get
			{
				return this.url;
			}
		}

		// Token: 0x040001D9 RID: 473
		private string id;

		// Token: 0x040001DA RID: 474
		private string url;
	}
}
