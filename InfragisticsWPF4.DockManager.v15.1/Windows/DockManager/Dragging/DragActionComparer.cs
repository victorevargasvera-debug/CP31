using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x02000050 RID: 80
	internal class DragActionComparer : global::System.Collections.Generic.IEqualityComparer<global::Infragistics.Windows.DockManager.Dragging.PaneDragAction>
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x00014F61 File Offset: 0x00013161
		public bool Equals(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction x, global::Infragistics.Windows.DockManager.Dragging.PaneDragAction y)
		{
			if (x == null || y == null)
			{
				return x == y;
			}
			return !(x.GetType() != y.GetType()) && x.IsSameResult(y);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00014F8A File Offset: 0x0001318A
		public int GetHashCode(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction obj)
		{
			return obj.GetDragHashCode();
		}
	}
}
