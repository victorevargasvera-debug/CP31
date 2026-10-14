using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001AF RID: 431
	public class CancellablePageChangingEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000BA3 RID: 2979 RVA: 0x0002A3ED File Offset: 0x000285ED
		// (set) Token: 0x06000BA4 RID: 2980 RVA: 0x0002A3F5 File Offset: 0x000285F5
		public int NextPageIndex { get; protected internal set; }

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0002A3FE File Offset: 0x000285FE
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x0002A406 File Offset: 0x00028606
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout { get; set; }

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0002A40F File Offset: 0x0002860F
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x0002A417 File Offset: 0x00028617
		public int Level { get; protected internal set; }

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0002A420 File Offset: 0x00028620
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x0002A428 File Offset: 0x00028628
		public global::Infragistics.Controls.Grids.RowCollection Rows { get; protected internal set; }
	}
}
