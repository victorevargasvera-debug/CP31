using System;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x02000045 RID: 69
	public abstract class PaneDragAction
	{
		// Token: 0x06000380 RID: 896
		internal abstract void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview);

		// Token: 0x06000381 RID: 897 RVA: 0x000137BA File Offset: 0x000119BA
		internal virtual int GetDragHashCode()
		{
			return this.GetHashCode();
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000137C2 File Offset: 0x000119C2
		internal virtual bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			return this.Equals(action);
		}

		// Token: 0x06000383 RID: 899
		internal abstract bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager);
	}
}
