using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x0200004A RID: 74
	public class NewSplitPaneAction : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x0600039D RID: 925 RVA: 0x00014288 File Offset: 0x00012488
		public NewSplitPaneAction(global::System.Windows.FrameworkElement pane, global::System.Windows.Controls.Dock side)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(pane, "pane");
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfInvalidEnum(side, "side");
			if (!(pane is global::Infragistics.Windows.DockManager.TabGroupPane) && !(pane is global::Infragistics.Windows.DockManager.ContentPane))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidNewSplitPaneElement"), "pane");
			}
			this._pane = pane;
			this._side = side;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600039E RID: 926 RVA: 0x000142E9 File Offset: 0x000124E9
		public global::System.Windows.FrameworkElement Pane
		{
			get
			{
				return this._pane;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600039F RID: 927 RVA: 0x000142F1 File Offset: 0x000124F1
		public global::System.Windows.Controls.Dock Side
		{
			get
			{
				return this._side;
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x000142F9 File Offset: 0x000124F9
		internal override int GetDragHashCode()
		{
			return this._pane.GetHashCode();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00014306 File Offset: 0x00012506
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			return dragManager.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._pane));
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0001431C File Offset: 0x0001251C
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			global::Infragistics.Windows.DockManager.Dragging.NewSplitPaneAction newSplitPaneAction = action as global::Infragistics.Windows.DockManager.Dragging.NewSplitPaneAction;
			return newSplitPaneAction != null && newSplitPaneAction._pane == this._pane && newSplitPaneAction._side == this._side;
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00014354 File Offset: 0x00012554
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._pane);
			if (isPreview)
			{
				global::System.Windows.Rect rect = global::Infragistics.Windows.DockManager.SplitPane.PredictDropNewSplit(this.Side, this._pane);
				global::System.Windows.Controls.Dock dock = (this._side == global::System.Windows.Controls.Dock.Left || this._side == global::System.Windows.Controls.Dock.Right) ? global::System.Windows.Controls.Dock.Left : global::System.Windows.Controls.Dock.Top;
				double offset = (dock == global::System.Windows.Controls.Dock.Left) ? rect.X : rect.Y;
				dragManager.ShowDropPreview(this._pane, dock, rect.Size, offset, paneLocation);
				return;
			}
			global::System.Windows.Controls.Orientation splitterOrientation = (this.Side == global::System.Windows.Controls.Dock.Left || this.Side == global::System.Windows.Controls.Dock.Right) ? global::System.Windows.Controls.Orientation.Vertical : global::System.Windows.Controls.Orientation.Horizontal;
			if (global::Infragistics.Windows.DockManager.PaneLocation.Document == paneLocation)
			{
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = (this._pane as global::Infragistics.Windows.DockManager.TabGroupPane) ?? (global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(this._pane) as global::Infragistics.Windows.DockManager.TabGroupPane);
				global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(tabGroupPane) as global::Infragistics.Windows.DockManager.SplitPane;
				if (splitPane == null)
				{
					return;
				}
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(dragManager.DockManager);
				using (global::Infragistics.Windows.Helpers.GroupTempValueReplacement groupTempValueReplacement = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.ContentPane>(dragManager.PanesBeingDragged))
				{
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement, tabGroupPane2, splitPane);
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers = dragManager.GetDragPaneContainers();
					foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dragManager.PanesBeingDragged)
					{
						global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = contentPane.PlacementInfo.CurrentContainer;
						currentContainer.RemoveContentPane(contentPane, global::Infragistics.Windows.DockManager.DockManagerUtilities.NeedsPlaceholder(currentContainer.PaneLocation, paneLocation));
					}
					int index = splitPane.Panes.IndexOf(tabGroupPane);
					global::Infragistics.Windows.DockManager.SplitPane splitPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(dragManager.DockManager);
					splitPane2.SplitterOrientation = splitterOrientation;
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement, tabGroupPane);
					splitPane.Panes.Remove(tabGroupPane);
					splitPane.Panes.Insert(index, splitPane2);
					splitPane2.Panes.Add(tabGroupPane);
					global::Infragistics.Windows.DockManager.SplitPane.SetRelativeSize(splitPane2, global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(tabGroupPane));
					int index2 = (this.Side == global::System.Windows.Controls.Dock.Left || this.Side == global::System.Windows.Controls.Dock.Top) ? 0 : 1;
					splitPane2.Panes.Insert(index2, tabGroupPane2);
					global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = tabGroupPane2;
					foreach (global::Infragistics.Windows.DockManager.ContentPane pane in dragManager.PanesBeingDragged)
					{
						contentPaneContainer.InsertContentPane(null, pane);
					}
					global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers);
					return;
				}
			}
			global::Infragistics.Windows.DockManager.SplitPane splitPane3 = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetParentPane(this._pane) as global::Infragistics.Windows.DockManager.SplitPane;
			if (splitPane3 == null)
			{
				return;
			}
			using (new global::Infragistics.Windows.DockManager.PaneToolWindow.SuspendReshowHelper(this._pane))
			{
				using (global::Infragistics.Windows.Helpers.GroupTempValueReplacement groupTempValueReplacement2 = new global::Infragistics.Windows.Helpers.GroupTempValueReplacement())
				{
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers2 = dragManager.GetDragPaneContainers();
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement2, this._pane);
					int index3 = splitPane3.Panes.IndexOf(this._pane);
					global::Infragistics.Windows.DockManager.SplitPane splitPane4 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(dragManager.DockManager);
					splitPane4.SplitterOrientation = splitterOrientation;
					global::Infragistics.Windows.DockManager.SplitPane.SetRelativeSize(splitPane4, global::Infragistics.Windows.DockManager.SplitPane.GetRelativeSize(this._pane));
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AddMoveReplacement(groupTempValueReplacement2, splitPane4, splitPane3);
					splitPane3.Panes.RemoveAt(index3);
					splitPane3.Panes.Insert(index3, splitPane4);
					splitPane4.Panes.Add(this._pane);
					this._pane.ClearValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty);
					int index4 = (this.Side == global::System.Windows.Controls.Dock.Left || this.Side == global::System.Windows.Controls.Dock.Top) ? 0 : 1;
					global::System.Windows.FrameworkElement frameworkElement = dragManager.MoveToSplitPane(splitPane4, index4);
					if (frameworkElement != null)
					{
						frameworkElement.ClearValue(global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty);
					}
					global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers2);
				}
			}
		}

		// Token: 0x040001EF RID: 495
		private global::System.Windows.FrameworkElement _pane;

		// Token: 0x040001F0 RID: 496
		private global::System.Windows.Controls.Dock _side;
	}
}
