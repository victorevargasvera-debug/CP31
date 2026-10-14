using System;
using System.Windows;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x0200004E RID: 78
	public class MoveInGroupAction : global::Infragistics.Windows.DockManager.Dragging.AddToGroupActionBase
	{
		// Token: 0x060003BB RID: 955 RVA: 0x00014EDC File Offset: 0x000130DC
		public MoveInGroupAction(global::System.Windows.FrameworkElement group, int index) : base(group, index)
		{
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00014EE8 File Offset: 0x000130E8
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			if (!isPreview && dragManager.PanesBeingDragged.Count == 1)
			{
				global::Infragistics.Windows.DockManager.ContentPane value = dragManager.PanesBeingDragged[0];
				global::Infragistics.Windows.DockManager.IPaneContainer paneContainer = base.Group as global::Infragistics.Windows.DockManager.IPaneContainer;
				if (paneContainer != null && paneContainer.Panes.IndexOf(value) == base.Index)
				{
					return;
				}
			}
			base.PerformAction(dragManager, isPreview);
		}
	}
}
