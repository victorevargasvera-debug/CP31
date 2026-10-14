using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001BA RID: 442
	public class CancellableFilteringEventArgs : global::Infragistics.Controls.Grids.CancellableColumnEventArgs
	{
		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x0002A693 File Offset: 0x00028893
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x0002A69B File Offset: 0x0002889B
		public global::Infragistics.Controls.Grids.RowFiltersCollection RowFiltersCollection { get; protected internal set; }

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x0002A6A4 File Offset: 0x000288A4
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0002A6AC File Offset: 0x000288AC
		public object FilterValue { get; protected internal set; }

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x0002A6B5 File Offset: 0x000288B5
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x0002A6BD File Offset: 0x000288BD
		public global::Infragistics.Controls.Grids.FilterOperand FilteringOperand { get; protected internal set; }
	}
}
