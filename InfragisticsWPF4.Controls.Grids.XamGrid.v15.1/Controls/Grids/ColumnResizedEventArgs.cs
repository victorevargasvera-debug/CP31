using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001B3 RID: 435
	public class ColumnResizedEventArgs : global::System.EventArgs
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06000BB7 RID: 2999 RVA: 0x0002A495 File Offset: 0x00028695
		// (set) Token: 0x06000BB8 RID: 3000 RVA: 0x0002A49D File Offset: 0x0002869D
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> Columns { get; internal set; }
	}
}
