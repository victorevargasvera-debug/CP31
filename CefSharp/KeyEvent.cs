using System;

namespace CefSharp
{
	// Token: 0x02000099 RID: 153
	public struct KeyEvent
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00006B91 File Offset: 0x00004D91
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00006B99 File Offset: 0x00004D99
		public global::CefSharp.KeyEventType Type { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00006BA2 File Offset: 0x00004DA2
		// (set) Token: 0x06000460 RID: 1120 RVA: 0x00006BAA File Offset: 0x00004DAA
		public global::CefSharp.CefEventFlags Modifiers { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00006BB3 File Offset: 0x00004DB3
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00006BBB File Offset: 0x00004DBB
		public int WindowsKeyCode { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x00006BC4 File Offset: 0x00004DC4
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x00006BCC File Offset: 0x00004DCC
		public int NativeKeyCode { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00006BD5 File Offset: 0x00004DD5
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x00006BDD File Offset: 0x00004DDD
		public bool IsSystemKey { get; set; }

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00006BE6 File Offset: 0x00004DE6
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00006BEE File Offset: 0x00004DEE
		public bool FocusOnEditableField { get; set; }
	}
}
