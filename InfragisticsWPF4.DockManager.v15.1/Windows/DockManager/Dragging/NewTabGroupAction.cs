using System;
using System.Collections.Generic;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x02000049 RID: 73
	public class NewTabGroupAction : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x06000397 RID: 919 RVA: 0x00013F86 File Offset: 0x00012186
		public NewTabGroupAction(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(pane, "pane");
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(pane) is global::Infragistics.Windows.DockManager.TabGroupPane)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidNewTabGroupActionPane"));
			}
			this._pane = pane;
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00013FBD File Offset: 0x000121BD
		public global::Infragistics.Windows.DockManager.ContentPane Pane
		{
			get
			{
				return this._pane;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00013FC5 File Offset: 0x000121C5
		internal override int GetDragHashCode()
		{
			return this._pane.GetHashCode();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00013FD4 File Offset: 0x000121D4
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			if (!dragManager.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._pane)))
			{
				return false;
			}
			if (global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDockable(this._pane.PaneLocation))
			{
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dragManager.PanesBeingDragged)
				{
					if (!contentPane.AllowDockingInTabGroup)
					{
						return false;
					}
				}
				if (!this._pane.AllowDockingInTabGroup)
				{
					return false;
				}
				return true;
			}
			return true;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00014060 File Offset: 0x00012260
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			global::Infragistics.Windows.DockManager.Dragging.NewTabGroupAction newTabGroupAction = action as global::Infragistics.Windows.DockManager.Dragging.NewTabGroupAction;
			return newTabGroupAction != null && newTabGroupAction._pane == this._pane;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00014088 File Offset: 0x00012288
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			if (isPreview)
			{
				global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation location = (global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._pane) == global::Infragistics.Windows.DockManager.PaneLocation.Document) ? global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Top : global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.Bottom;
				dragManager.ShowDropPreview(this._pane, location, global::System.Windows.Size.Empty, this._pane.PaneLocation);
				return;
			}
			global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = this._pane.PlacementInfo.CurrentContainer;
			global::Infragistics.Windows.DockManager.SplitPane splitPane = currentContainer as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane == null)
			{
				return;
			}
			using (new global::Infragistics.Windows.DockManager.PaneToolWindow.SuspendReshowHelper(splitPane))
			{
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(dragManager.DockManager);
				global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = tabGroupPane;
				int index = splitPane.Panes.IndexOf(this._pane);
				using (global::Infragistics.Windows.Helpers.GroupTempValueReplacement groupTempValueReplacement = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.ContentPane>(dragManager.PanesBeingDragged))
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement, this._pane);
					foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dragManager.PanesBeingDragged)
					{
						global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer2 = contentPane.PlacementInfo.CurrentContainer;
						currentContainer2.RemoveContentPane(contentPane, global::Infragistics.Windows.DockManager.DockManagerUtilities.NeedsPlaceholder(currentContainer2.PaneLocation, contentPaneContainer.PaneLocation));
					}
					currentContainer.RemoveContentPane(this._pane, false);
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers = dragManager.GetDragPaneContainers();
					splitPane.Panes.Insert(index, tabGroupPane);
					foreach (global::Infragistics.Windows.DockManager.ContentPane pane in dragManager.PanesBeingDragged)
					{
						contentPaneContainer.InsertContentPane(null, pane);
					}
					contentPaneContainer.InsertContentPane(null, this._pane);
					global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers);
				}
			}
		}

		// Token: 0x040001EE RID: 494
		private global::Infragistics.Windows.DockManager.ContentPane _pane;
	}
}
