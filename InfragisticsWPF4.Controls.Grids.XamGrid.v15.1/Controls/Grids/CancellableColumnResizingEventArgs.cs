using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001B2 RID: 434
	public class CancellableColumnResizingEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0002A46B File Offset: 0x0002866B
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0002A473 File Offset: 0x00028673
		public global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column> Columns { get; internal set; }

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0002A47C File Offset: 0x0002867C
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0002A484 File Offset: 0x00028684
		public double Width { get; protected internal set; }
	}
}
