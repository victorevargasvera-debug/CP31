using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001C3 RID: 451
	internal class ChildColumnLayoutStateChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000C1F RID: 3103 RVA: 0x0002B487 File Offset: 0x00029687
		public ChildColumnLayoutStateChangedEventArgs(global::Infragistics.Controls.Grids.ColumnLayout childColumnLayout, global::Infragistics.Controls.Grids.ChildColumnLayoutState state)
		{
			this.ChildColumnLayout = childColumnLayout;
			this.State = state;
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0002B49D File Offset: 0x0002969D
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0002B4A5 File Offset: 0x000296A5
		internal global::Infragistics.Controls.Grids.ChildColumnLayoutState State { get; private set; }

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0002B4AE File Offset: 0x000296AE
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0002B4B6 File Offset: 0x000296B6
		internal global::Infragistics.Controls.Grids.ColumnLayout ChildColumnLayout { get; private set; }
	}
}
