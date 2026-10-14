using System;
using System.Windows;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x0200004D RID: 77
	public class AddToDocumentHostAction : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x00014DFF File Offset: 0x00012FFF
		public AddToDocumentHostAction(global::Infragistics.Windows.DockManager.TabGroupPane group, int itemIndex)
		{
			this._group = group;
			this._itemIndex = itemIndex;
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00014E15 File Offset: 0x00013015
		public global::Infragistics.Windows.DockManager.TabGroupPane Group
		{
			get
			{
				return this._group;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00014E1D File Offset: 0x0001301D
		public int ItemIndex
		{
			get
			{
				return this._itemIndex;
			}
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00014E25 File Offset: 0x00013025
		internal override int GetDragHashCode()
		{
			if (this._group == null)
			{
				return 101;
			}
			return this._group.GetHashCode();
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00014E3D File Offset: 0x0001303D
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			return dragManager.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Document);
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00014E48 File Offset: 0x00013048
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			global::Infragistics.Windows.DockManager.Dragging.AddToDocumentHostAction addToDocumentHostAction = action as global::Infragistics.Windows.DockManager.Dragging.AddToDocumentHostAction;
			return addToDocumentHostAction != null && addToDocumentHostAction._group == this._group;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00014E70 File Offset: 0x00013070
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			if (isPreview)
			{
				dragManager.ShowDropPreview(dragManager.DockManager.DocumentContentHost, global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.None, global::System.Windows.Size.Empty, global::Infragistics.Windows.DockManager.PaneLocation.Document);
				return;
			}
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dragManager.PanesBeingDragged)
			{
				contentPane.ChangeToDocument();
			}
		}

		// Token: 0x040001F5 RID: 501
		private global::Infragistics.Windows.DockManager.TabGroupPane _group;

		// Token: 0x040001F6 RID: 502
		private int _itemIndex;
	}
}
