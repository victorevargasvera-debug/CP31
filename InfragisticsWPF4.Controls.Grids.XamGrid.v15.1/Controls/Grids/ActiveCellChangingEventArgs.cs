using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000196 RID: 406
	public class ActiveCellChangingEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000B3D RID: 2877 RVA: 0x0002A073 File Offset: 0x00028273
		// (set) Token: 0x06000B3E RID: 2878 RVA: 0x0002A07B File Offset: 0x0002827B
		public global::Infragistics.Controls.Grids.CellBase PreviousActiveCell { get; protected internal set; }

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000B3F RID: 2879 RVA: 0x0002A084 File Offset: 0x00028284
		// (set) Token: 0x06000B40 RID: 2880 RVA: 0x0002A08C File Offset: 0x0002828C
		public global::Infragistics.Controls.Grids.CellBase NewActiveCell { get; protected internal set; }
	}
}
