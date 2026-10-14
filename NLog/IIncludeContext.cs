using System;

namespace NLog
{
	// Token: 0x02000004 RID: 4
	internal interface IIncludeContext
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000012 RID: 18
		// (set) Token: 0x06000013 RID: 19
		bool IncludeMdc { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000014 RID: 20
		// (set) Token: 0x06000015 RID: 21
		bool IncludeNdc { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000016 RID: 22
		// (set) Token: 0x06000017 RID: 23
		bool IncludeAllProperties { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24
		// (set) Token: 0x06000019 RID: 25
		bool IncludeMdlc { get; set; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600001A RID: 26
		// (set) Token: 0x0600001B RID: 27
		bool IncludeNdlc { get; set; }
	}
}
