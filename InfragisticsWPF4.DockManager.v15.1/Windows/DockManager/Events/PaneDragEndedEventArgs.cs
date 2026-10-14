using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Windows.DockManager.Events
{
	// Token: 0x02000070 RID: 112
	public class PaneDragEndedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060003DB RID: 987 RVA: 0x000150C5 File Offset: 0x000132C5
		public PaneDragEndedEventArgs(global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> panes)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(panes, "panes");
			this._panes = panes;
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003DC RID: 988 RVA: 0x000150DF File Offset: 0x000132DF
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x04000281 RID: 641
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> _panes;
	}
}
