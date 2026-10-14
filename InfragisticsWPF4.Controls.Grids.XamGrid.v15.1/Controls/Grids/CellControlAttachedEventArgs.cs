using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000198 RID: 408
	public class CellControlAttachedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000B47 RID: 2887 RVA: 0x0002A0C7 File Offset: 0x000282C7
		// (set) Token: 0x06000B48 RID: 2888 RVA: 0x0002A0CF File Offset: 0x000282CF
		public global::Infragistics.Controls.Grids.Cell Cell { get; internal set; }

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000B49 RID: 2889 RVA: 0x0002A0D8 File Offset: 0x000282D8
		// (set) Token: 0x06000B4A RID: 2890 RVA: 0x0002A0E0 File Offset: 0x000282E0
		public bool IsDirty { get; set; }
	}
}
