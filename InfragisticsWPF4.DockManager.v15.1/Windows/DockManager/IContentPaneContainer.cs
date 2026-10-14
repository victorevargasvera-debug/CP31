using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000033 RID: 51
	internal interface IContentPaneContainer
	{
		// Token: 0x060002B0 RID: 688
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> GetAllPanesForPaneAction(global::Infragistics.Windows.DockManager.ContentPane pane);

		// Token: 0x060002B1 RID: 689
		void RemoveContentPane(global::Infragistics.Windows.DockManager.ContentPane pane, bool replaceWithPlaceholder);

		// Token: 0x060002B2 RID: 690
		void InsertContentPane(int? index, global::Infragistics.Windows.DockManager.ContentPane pane);

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002B3 RID: 691
		global::Infragistics.Windows.DockManager.PaneLocation PaneLocation { get; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002B4 RID: 692
		global::System.Windows.FrameworkElement ContainerElement { get; }

		// Token: 0x060002B5 RID: 693
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> GetVisiblePanes();
	}
}
