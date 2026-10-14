using System;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x0200004F RID: 79
	internal class InvalidDropLocation : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x060003BD RID: 957 RVA: 0x00014F3F File Offset: 0x0001313F
		private InvalidDropLocation()
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00014F47 File Offset: 0x00013147
		internal override int GetDragHashCode()
		{
			return 1;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00014F4A File Offset: 0x0001314A
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			return action == this;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00014F50 File Offset: 0x00013150
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00014F52 File Offset: 0x00013152
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			return false;
		}

		// Token: 0x040001F7 RID: 503
		internal static readonly global::Infragistics.Windows.DockManager.Dragging.InvalidDropLocation Instance = new global::Infragistics.Windows.DockManager.Dragging.InvalidDropLocation();
	}
}
