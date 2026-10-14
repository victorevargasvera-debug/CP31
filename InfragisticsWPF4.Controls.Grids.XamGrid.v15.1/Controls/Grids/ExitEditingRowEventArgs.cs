using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001AE RID: 430
	public class ExitEditingRowEventArgs : global::Infragistics.CancellableEventArgs
	{
		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0002A3A1 File Offset: 0x000285A1
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x0002A3A9 File Offset: 0x000285A9
		public global::Infragistics.Controls.Grids.Row Row { get; protected internal set; }

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0002A3B2 File Offset: 0x000285B2
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x0002A3BA File Offset: 0x000285BA
		public bool EditingCanceled { get; protected internal set; }

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0002A3C3 File Offset: 0x000285C3
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0002A3CB File Offset: 0x000285CB
		public global::System.Collections.Generic.Dictionary<string, object> NewCellValues { get; protected internal set; }

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0002A3D4 File Offset: 0x000285D4
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0002A3DC File Offset: 0x000285DC
		public global::System.Collections.Generic.Dictionary<string, object> OriginalCellValues { get; protected internal set; }
	}
}
