using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.DockManager.Dragging;

namespace Infragistics.Windows.DockManager.Events
{
	// Token: 0x0200006F RID: 111
	public class PaneDragStartingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x060003D1 RID: 977 RVA: 0x0001503C File Offset: 0x0001323C
		public PaneDragStartingEventArgs(global::System.Windows.FrameworkElement rootPane)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(rootPane, "rootPane");
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> panesForDragElement = global::Infragistics.Windows.DockManager.Dragging.DragManager.GetPanesForDragElement(rootPane, out this._rootContainer);
			this._rootPane = rootPane;
			this._panes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane>(panesForDragElement);
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0001507A File Offset: 0x0001327A
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00015082 File Offset: 0x00013282
		public global::System.Windows.Input.Cursor InvalidDragActionCursor
		{
			get
			{
				return this._invalidDragActionCursor;
			}
			set
			{
				this._invalidDragActionCursor = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x0001508B File Offset: 0x0001328B
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> Panes
		{
			get
			{
				return this._panes;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00015093 File Offset: 0x00013293
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0001509B File Offset: 0x0001329B
		public bool RaisePaneDragOverForInvalidLocations
		{
			get
			{
				return this._raisePaneDragOverForInvalidLocations;
			}
			set
			{
				this._raisePaneDragOverForInvalidLocations = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x000150A4 File Offset: 0x000132A4
		public global::System.Windows.FrameworkElement RootPane
		{
			get
			{
				return this._rootPane;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x000150AC File Offset: 0x000132AC
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x000150B4 File Offset: 0x000132B4
		public global::System.Windows.Input.Cursor ValidDragActionCursor
		{
			get
			{
				return this._validDragActionCursor;
			}
			set
			{
				this._validDragActionCursor = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003DA RID: 986 RVA: 0x000150BD File Offset: 0x000132BD
		internal global::System.Windows.FrameworkElement RootContainerElement
		{
			get
			{
				return this._rootContainer;
			}
		}

		// Token: 0x0400027B RID: 635
		private global::System.Windows.FrameworkElement _rootPane;

		// Token: 0x0400027C RID: 636
		private global::System.Windows.FrameworkElement _rootContainer;

		// Token: 0x0400027D RID: 637
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DockManager.ContentPane> _panes;

		// Token: 0x0400027E RID: 638
		private bool _raisePaneDragOverForInvalidLocations;

		// Token: 0x0400027F RID: 639
		private global::System.Windows.Input.Cursor _invalidDragActionCursor;

		// Token: 0x04000280 RID: 640
		private global::System.Windows.Input.Cursor _validDragActionCursor;
	}
}
