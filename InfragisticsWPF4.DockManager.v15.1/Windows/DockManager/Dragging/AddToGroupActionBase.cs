using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x02000047 RID: 71
	public abstract class AddToGroupActionBase : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x0600038D RID: 909 RVA: 0x000139E6 File Offset: 0x00011BE6
		protected AddToGroupActionBase(global::System.Windows.FrameworkElement group, int index)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(group, "group");
			if (!(group is global::Infragistics.Windows.DockManager.IContentPaneContainer))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DockManager.XamDockManager.GetString("LE_InvalidAddToGroupElement"), "group");
			}
			this._group = group;
			this._index = index;
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00013A24 File Offset: 0x00011C24
		public global::System.Windows.FrameworkElement Group
		{
			get
			{
				return this._group;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00013A2C File Offset: 0x00011C2C
		public int Index
		{
			get
			{
				return this._index;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00013A34 File Offset: 0x00011C34
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00013A3C File Offset: 0x00011C3C
		internal global::Infragistics.Windows.DockManager.TabItemDragBehavior TabItemDragBehavior
		{
			get
			{
				return this._tabItemDragBehavior;
			}
			set
			{
				this._tabItemDragBehavior = value;
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00013A45 File Offset: 0x00011C45
		internal override int GetDragHashCode()
		{
			return this._group.GetHashCode();
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00013A54 File Offset: 0x00011C54
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			if (!dragManager.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._group)))
			{
				return false;
			}
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = this._group as global::Infragistics.Windows.DockManager.TabGroupPane;
			if (tabGroupPane != null && global::Infragistics.Windows.DockManager.DockManagerUtilities.IsDockable(global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(tabGroupPane)))
			{
				global::System.Windows.Controls.ItemCollection items = tabGroupPane.Items;
				foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dragManager.PanesBeingDragged)
				{
					if (!contentPane.AllowDockingInTabGroup && global::Infragistics.Windows.DockManager.DockManagerUtilities.IndexOf(items, contentPane, true) < 0)
					{
						return false;
					}
				}
				foreach (object obj in ((global::System.Collections.IEnumerable)tabGroupPane.Items))
				{
					global::Infragistics.Windows.DockManager.ContentPane contentPane2 = obj as global::Infragistics.Windows.DockManager.ContentPane;
					if (contentPane2 == null && obj is global::Infragistics.Windows.DockManager.ContentPanePlaceholder)
					{
						contentPane2 = ((global::Infragistics.Windows.DockManager.ContentPanePlaceholder)obj).Pane;
					}
					if (contentPane2 != null && !contentPane2.AllowDockingInTabGroup && dragManager.PanesBeingDragged.IndexOf(contentPane2) < 0)
					{
						return false;
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00013B84 File Offset: 0x00011D84
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			global::Infragistics.Windows.DockManager.Dragging.AddToGroupActionBase addToGroupActionBase = action as global::Infragistics.Windows.DockManager.Dragging.AddToGroupActionBase;
			return addToGroupActionBase != null && addToGroupActionBase._group == this._group && addToGroupActionBase._index == this._index;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00013BBC File Offset: 0x00011DBC
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			global::Infragistics.Windows.DockManager.PaneLocation paneLocation = global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(this._group);
			if (this._group is global::Infragistics.Windows.DockManager.TabGroupPane)
			{
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = (global::Infragistics.Windows.DockManager.TabGroupPane)this._group;
				if (isPreview)
				{
					bool flag = true;
					if (this._tabItemDragBehavior == global::Infragistics.Windows.DockManager.TabItemDragBehavior.DisplayInsertionBar)
					{
						flag = !dragManager.ShowTabItemPreview(tabGroupPane, this.Index);
					}
					if (flag)
					{
						global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation previewLocation = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetPreviewLocation(tabGroupPane.TabStripPlacement);
						dragManager.ShowDropPreview(tabGroupPane, previewLocation, global::System.Windows.Size.Empty, global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(tabGroupPane));
						return;
					}
				}
				else
				{
					object selectedItem = tabGroupPane.SelectedItem;
					int val = this.Index;
					global::Infragistics.Windows.DockManager.DockManagerUtilities.AdjustIndexForMove(tabGroupPane.Items, dragManager.PanesBeingDragged, ref val);
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers = dragManager.GetDragPaneContainers();
					using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.ContentPane>(dragManager.PanesBeingDragged))
					{
						foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dragManager.PanesBeingDragged)
						{
							global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = contentPane.PlacementInfo.CurrentContainer;
							currentContainer.RemoveContentPane(contentPane, global::Infragistics.Windows.DockManager.DockManagerUtilities.NeedsPlaceholder(currentContainer.PaneLocation, paneLocation));
						}
						global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = this._group as global::Infragistics.Windows.DockManager.IContentPaneContainer;
						val = global::System.Math.Min(val, tabGroupPane.Items.Count);
						foreach (global::Infragistics.Windows.DockManager.ContentPane pane in dragManager.PanesBeingDragged)
						{
							contentPaneContainer.InsertContentPane(new int?(val++), pane);
						}
						global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers);
					}
					int num = (selectedItem == null) ? -1 : tabGroupPane.Items.IndexOf(selectedItem);
					if (num >= 0)
					{
						tabGroupPane.SelectedIndex = num;
						return;
					}
				}
			}
			else if (this._group is global::Infragistics.Windows.DockManager.SplitPane)
			{
				global::Infragistics.Windows.DockManager.SplitPane splitPane = (global::Infragistics.Windows.DockManager.SplitPane)this._group;
				if (isPreview)
				{
					global::System.Windows.Controls.Dock side = (splitPane.SplitterOrientation == global::System.Windows.Controls.Orientation.Vertical) ? global::System.Windows.Controls.Dock.Left : global::System.Windows.Controls.Dock.Top;
					global::System.Windows.Size relativeSize = (global::System.Windows.Size)global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty.DefaultMetadata.DefaultValue;
					if (paneLocation != global::Infragistics.Windows.DockManager.PaneLocation.Document)
					{
						relativeSize = dragManager.GetMoveToSplitPaneRelativeSize(this._group);
					}
					global::System.Windows.Rect rect = splitPane.PredictDrop(relativeSize, this.Index);
					double offset = (splitPane.SplitterOrientation == global::System.Windows.Controls.Orientation.Vertical) ? rect.X : rect.Y;
					dragManager.ShowDropPreview(splitPane, side, rect.Size, offset, global::Infragistics.Windows.DockManager.XamDockManager.GetPaneLocation(splitPane));
					return;
				}
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers2 = dragManager.GetDragPaneContainers();
				if (paneLocation == global::Infragistics.Windows.DockManager.PaneLocation.Document)
				{
					int num2 = this.Index;
					using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.ContentPane>(dragManager.PanesBeingDragged))
					{
						foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane2 in dragManager.PanesBeingDragged)
						{
							global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer2 = contentPane2.PlacementInfo.CurrentContainer;
							currentContainer2.RemoveContentPane(contentPane2, global::Infragistics.Windows.DockManager.DockManagerUtilities.NeedsPlaceholder(currentContainer2.PaneLocation, paneLocation));
						}
						global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(dragManager.DockManager);
						global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer2 = tabGroupPane2;
						num2 = global::System.Math.Min(num2, splitPane.Panes.Count);
						splitPane.Panes.Insert(num2, tabGroupPane2);
						foreach (global::Infragistics.Windows.DockManager.ContentPane pane2 in dragManager.PanesBeingDragged)
						{
							contentPaneContainer2.InsertContentPane(null, pane2);
						}
						goto IL_360;
					}
				}
				int index = this.Index;
				global::Infragistics.Windows.DockManager.DockManagerUtilities.AdjustIndexForMove(splitPane.Panes, dragManager.PanesBeingDragged, ref index);
				dragManager.MoveToSplitPane(splitPane, index);
				IL_360:
				global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers2);
			}
		}

		// Token: 0x040001EB RID: 491
		private global::System.Windows.FrameworkElement _group;

		// Token: 0x040001EC RID: 492
		private int _index;

		// Token: 0x040001ED RID: 493
		private global::Infragistics.Windows.DockManager.TabItemDragBehavior _tabItemDragBehavior;
	}
}
