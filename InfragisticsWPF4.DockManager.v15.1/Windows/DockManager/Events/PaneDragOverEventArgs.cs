using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DockManager.Dragging;

namespace Infragistics.Windows.DockManager.Events
{
	// Token: 0x02000071 RID: 113
	public class PaneDragOverEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060003DD RID: 989 RVA: 0x000150E7 File Offset: 0x000132E7
		public PaneDragOverEventArgs(global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> panes, global::Infragistics.Windows.DockManager.Dragging.PaneDragAction dragAction)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(panes, "panes");
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(dragAction, "dragAction");
			this._panes = panes;
			this._dragAction = dragAction;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0001511A File Offset: 0x0001331A
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00015122 File Offset: 0x00013322
		public bool IsValidDragAction
		{
			get
			{
				return this._isValidDragAction;
			}
			set
			{
				this._isValidDragAction = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0001512B File Offset: 0x0001332B
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x00015133 File Offset: 0x00013333
		public global::System.Windows.Input.Cursor Cursor
		{
			get
			{
				return this._cursor;
			}
			set
			{
				this._cursor = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060003E2 RID: 994 RVA: 0x0001513C File Offset: 0x0001333C
		public global::Infragistics.Windows.DockManager.Dragging.PaneDragAction DragAction
		{
			get
			{
				return this._dragAction;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00015144 File Offset: 0x00013344
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x04000282 RID: 642
		private bool _isValidDragAction = true;

		// Token: 0x04000283 RID: 643
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> _panes;

		// Token: 0x04000284 RID: 644
		private global::System.Windows.Input.Cursor _cursor;

		// Token: 0x04000285 RID: 645
		private global::Infragistics.Windows.DockManager.Dragging.PaneDragAction _dragAction;
	}
}
