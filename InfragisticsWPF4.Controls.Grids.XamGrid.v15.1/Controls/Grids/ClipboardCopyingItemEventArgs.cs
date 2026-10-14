using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001BD RID: 445
	public class ClipboardCopyingItemEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000BFD RID: 3069 RVA: 0x0002AA49 File Offset: 0x00028C49
		// (set) Token: 0x06000BFE RID: 3070 RVA: 0x0002AA51 File Offset: 0x00028C51
		public global::Infragistics.Controls.Grids.CellBase Cell { get; protected internal set; }

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0002AA5A File Offset: 0x00028C5A
		// (set) Token: 0x06000C00 RID: 3072 RVA: 0x0002AA62 File Offset: 0x00028C62
		public string ClipboardValue { get; set; }
	}
}
