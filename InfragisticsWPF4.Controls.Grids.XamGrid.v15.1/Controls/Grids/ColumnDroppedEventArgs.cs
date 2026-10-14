using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001A4 RID: 420
	public class ColumnDroppedEventArgs : global::Infragistics.Controls.Grids.ColumnEventArgs
	{
		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x0002A263 File Offset: 0x00028463
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x0002A26B File Offset: 0x0002846B
		public int PreviousIndex { get; protected internal set; }

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0002A274 File Offset: 0x00028474
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x0002A27C File Offset: 0x0002847C
		public int NewIndex { get; protected internal set; }

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0002A285 File Offset: 0x00028485
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x0002A28D File Offset: 0x0002848D
		public global::Infragistics.Controls.Grids.DropOperationType DropType { get; protected internal set; }
	}
}
