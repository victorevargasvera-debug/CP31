using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001B5 RID: 437
	public class GroupByCollectionChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06000BBD RID: 3005 RVA: 0x0002A4C7 File Offset: 0x000286C7
		// (set) Token: 0x06000BBE RID: 3006 RVA: 0x0002A4CF File Offset: 0x000286CF
		public global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Column> PreviousGroupedColumns { get; protected internal set; }

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000BBF RID: 3007 RVA: 0x0002A4D8 File Offset: 0x000286D8
		// (set) Token: 0x06000BC0 RID: 3008 RVA: 0x0002A4E0 File Offset: 0x000286E0
		public global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Column> NewGroupedColumns { get; protected internal set; }
	}
}
