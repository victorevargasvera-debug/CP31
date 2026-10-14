using System;

namespace CefSharp.Structs
{
	// Token: 0x020000AE RID: 174
	public struct Range
	{
		// Token: 0x170001AF RID: 431
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0000844B File Offset: 0x0000664B
		// (set) Token: 0x0600054E RID: 1358 RVA: 0x00008453 File Offset: 0x00006653
		public int From { get; private set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0000845C File Offset: 0x0000665C
		// (set) Token: 0x06000550 RID: 1360 RVA: 0x00008464 File Offset: 0x00006664
		public int To { get; private set; }

		// Token: 0x06000551 RID: 1361 RVA: 0x0000846D File Offset: 0x0000666D
		public Range(int from, int to)
		{
			this = default(global::CefSharp.Structs.Range);
			this.From = from;
			this.To = to;
		}
	}
}
