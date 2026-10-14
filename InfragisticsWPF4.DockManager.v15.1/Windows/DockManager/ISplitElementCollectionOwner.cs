using System;
using System.Windows;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x02000024 RID: 36
	internal interface ISplitElementCollectionOwner
	{
		// Token: 0x060001C7 RID: 455
		void OnElementAdding(global::System.Windows.FrameworkElement newElement);

		// Token: 0x060001C8 RID: 456
		void OnElementAdded(global::System.Windows.FrameworkElement newElement);

		// Token: 0x060001C9 RID: 457
		void OnElementRemoved(global::System.Windows.FrameworkElement oldElement);

		// Token: 0x060001CA RID: 458
		global::Infragistics.Windows.DockManager.PaneSplitter CreateSplitter();

		// Token: 0x060001CB RID: 459
		void OnSplitterAdded(global::Infragistics.Windows.DockManager.PaneSplitter splitter);

		// Token: 0x060001CC RID: 460
		void OnSplitterRemoved(global::Infragistics.Windows.DockManager.PaneSplitter splitter);
	}
}
