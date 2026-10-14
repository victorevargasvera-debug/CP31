using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C2 RID: 450
	internal class ColumnLayoutStateChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x0002B467 File Offset: 0x00029667
		public ColumnLayoutStateChangedEventArgs(global::Infragistics.Controls.Grids.ColumnLayoutState state)
		{
			this.State = state;
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0002B476 File Offset: 0x00029676
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x0002B47E File Offset: 0x0002967E
		internal global::Infragistics.Controls.Grids.ColumnLayoutState State { get; private set; }
	}
}
