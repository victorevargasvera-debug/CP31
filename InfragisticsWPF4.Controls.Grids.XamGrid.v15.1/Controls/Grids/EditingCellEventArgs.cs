using System;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001A8 RID: 424
	public class EditingCellEventArgs : global::System.EventArgs
	{
		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0002A2D8 File Offset: 0x000284D8
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0002A2E0 File Offset: 0x000284E0
		public global::Infragistics.Controls.Grids.Cell Cell { get; protected internal set; }

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0002A2E9 File Offset: 0x000284E9
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0002A2F1 File Offset: 0x000284F1
		public global::System.Windows.FrameworkElement Editor { get; protected internal set; }
	}
}
