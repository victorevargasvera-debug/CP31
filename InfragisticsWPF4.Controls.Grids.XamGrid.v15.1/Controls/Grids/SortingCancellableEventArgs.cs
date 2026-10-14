using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000193 RID: 403
	public class SortingCancellableEventArgs : global::Infragistics.Controls.Grids.CancellableColumnEventArgs
	{
		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000B32 RID: 2866 RVA: 0x0002A017 File Offset: 0x00028217
		// (set) Token: 0x06000B33 RID: 2867 RVA: 0x0002A01F File Offset: 0x0002821F
		public global::Infragistics.Controls.Grids.SortDirection PreviousSortDirection { get; protected internal set; }

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0002A028 File Offset: 0x00028228
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0002A030 File Offset: 0x00028230
		public global::Infragistics.Controls.Grids.SortDirection NewSortDirection { get; protected internal set; }
	}
}
