using System;
using System.Windows;

namespace AcpUI.DragDrop
{
	// Token: 0x02000063 RID: 99
	public interface IDragSourceAdvisor
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600052B RID: 1323
		// (set) Token: 0x0600052C RID: 1324
		global::System.Windows.UIElement SourceUI { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600052D RID: 1325
		global::System.Windows.DragDropEffects SupportedEffects { get; }

		// Token: 0x0600052E RID: 1326
		global::System.Windows.DataObject GetDataObject(global::System.Windows.UIElement draggedElement);

		// Token: 0x0600052F RID: 1327
		void FinishDrag(global::System.Windows.UIElement draggedElement, global::System.Windows.DragDropEffects finalEffects);

		// Token: 0x06000530 RID: 1328
		bool IsDraggable(global::System.Windows.UIElement dragElement);
	}
}
