using System;
using System.Windows;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x0200004C RID: 76
	public class FloatPaneAction : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x060003AB RID: 939 RVA: 0x00014D64 File Offset: 0x00012F64
		public FloatPaneAction(global::System.Windows.Point location, global::System.Windows.Size size)
		{
			this._location = location;
			this._size = size;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00014D7A File Offset: 0x00012F7A
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00014D82 File Offset: 0x00012F82
		public global::System.Windows.Point Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00014D8B File Offset: 0x00012F8B
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00014D93 File Offset: 0x00012F93
		public global::System.Windows.Size Size
		{
			get
			{
				return this._size;
			}
			set
			{
				this._size = value;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00014D9C File Offset: 0x00012F9C
		internal override int GetDragHashCode()
		{
			return 100;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00014DA0 File Offset: 0x00012FA0
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			return dragManager.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Floating);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00014DAA File Offset: 0x00012FAA
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			return action is global::Infragistics.Windows.DockManager.Dragging.FloatPaneAction;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00014DB8 File Offset: 0x00012FB8
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			if (isPreview && dragManager.DeferFloatingWindowPositioning)
			{
				global::System.Windows.Size size = this.Size;
				dragManager.CreateFloatingPreviewWindow(this.Location, size);
				return;
			}
			if (dragManager.WindowBeingDragged == null)
			{
				dragManager.CreateWindowBeingDragged(this.Location, this.Size);
			}
		}

		// Token: 0x040001F3 RID: 499
		private global::System.Windows.Size _size;

		// Token: 0x040001F4 RID: 500
		private global::System.Windows.Point _location;
	}
}
