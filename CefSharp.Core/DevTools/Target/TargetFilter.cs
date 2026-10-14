using System;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000112 RID: 274
	public class TargetFilter : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060008A1 RID: 2209 RVA: 0x0000B6C0 File Offset: 0x000098C0
		// (set) Token: 0x060008A2 RID: 2210 RVA: 0x0000B6C8 File Offset: 0x000098C8
		public string Type { get; set; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060008A3 RID: 2211 RVA: 0x0000B6D1 File Offset: 0x000098D1
		// (set) Token: 0x060008A4 RID: 2212 RVA: 0x0000B6D9 File Offset: 0x000098D9
		public bool Exclude { get; set; }
	}
}
