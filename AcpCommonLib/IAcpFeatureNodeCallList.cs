using System;

namespace AcpCommonLib
{
	// Token: 0x02000027 RID: 39
	public interface IAcpFeatureNodeCallList
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000191 RID: 401
		// (set) Token: 0x06000192 RID: 402
		int HotlistParentRecsetId { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000193 RID: 403
		// (set) Token: 0x06000194 RID: 404
		int HotlistParentSectionId { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000195 RID: 405
		// (set) Token: 0x06000196 RID: 406
		int HotlistRecsetId { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000197 RID: 407
		// (set) Token: 0x06000198 RID: 408
		int HotlistSectionId { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000199 RID: 409
		// (set) Token: 0x0600019A RID: 410
		int CalllistContactAliasSectionId { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600019B RID: 411
		// (set) Token: 0x0600019C RID: 412
		string CalllistContactAlias { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600019D RID: 413
		// (set) Token: 0x0600019E RID: 414
		string HotlistContactAlias { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600019F RID: 415
		// (set) Token: 0x060001A0 RID: 416
		string HotlistContactCallId { get; set; }
	}
}
