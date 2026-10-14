using System;

namespace Gibraltar
{
	// Token: 0x020000B8 RID: 184
	internal class PrivateTaskErrorEventArgs : global::System.EventArgs
	{
		// Token: 0x060007C8 RID: 1992 RVA: 0x0000F734 File Offset: 0x0000D934
		public PrivateTaskErrorEventArgs(object state, global::System.Exception ex)
		{
			this.State = state;
			this.Exception = ex;
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060007C9 RID: 1993 RVA: 0x0000F74C File Offset: 0x0000D94C
		// (set) Token: 0x060007CA RID: 1994 RVA: 0x0000F754 File Offset: 0x0000D954
		public object State { get; private set; }

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x0000F760 File Offset: 0x0000D960
		// (set) Token: 0x060007CC RID: 1996 RVA: 0x0000F768 File Offset: 0x0000D968
		public global::System.Exception Exception { get; private set; }
	}
}
