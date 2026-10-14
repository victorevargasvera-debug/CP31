using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DockManager.Dragging
{
	// Token: 0x0200004B RID: 75
	public class NewRootPaneAction : global::Infragistics.Windows.DockManager.Dragging.PaneDragAction
	{
		// Token: 0x060003A4 RID: 932 RVA: 0x00014720 File Offset: 0x00012920
		public NewRootPaneAction(global::System.Windows.Controls.Dock side, global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation location)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfInvalidEnum(side, "side");
			this._side = side;
			this._location = location;
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x00014746 File Offset: 0x00012946
		public global::System.Windows.Controls.Dock Side
		{
			get
			{
				return this._side;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x0001474E File Offset: 0x0001294E
		public global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation Location
		{
			get
			{
				return this._location;
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00014756 File Offset: 0x00012956
		internal override int GetDragHashCode()
		{
			return this._side.GetHashCode();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00014768 File Offset: 0x00012968
		internal override bool IsActionAllowed(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager)
		{
			if (this._location == global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.DocumentContentHost)
			{
				return dragManager.IsDropLocationAllowed(global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Document);
			}
			global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations location = (global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations)0;
			switch (this._side)
			{
			case global::System.Windows.Controls.Dock.Left:
				location = global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Left;
				break;
			case global::System.Windows.Controls.Dock.Top:
				location = global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Top;
				break;
			case global::System.Windows.Controls.Dock.Right:
				location = global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Right;
				break;
			case global::System.Windows.Controls.Dock.Bottom:
				location = global::Infragistics.Windows.DockManager.Dragging.AllowedDropLocations.Bottom;
				break;
			}
			return dragManager.IsDropLocationAllowed(location);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000147C0 File Offset: 0x000129C0
		internal override bool IsSameResult(global::Infragistics.Windows.DockManager.Dragging.PaneDragAction action)
		{
			global::Infragistics.Windows.DockManager.Dragging.NewRootPaneAction newRootPaneAction = action as global::Infragistics.Windows.DockManager.Dragging.NewRootPaneAction;
			return newRootPaneAction != null && newRootPaneAction._location == this._location && newRootPaneAction._side == this._side;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000147F8 File Offset: 0x000129F8
		internal override void PerformAction(global::Infragistics.Windows.DockManager.Dragging.DragManager dragManager, bool isPreview)
		{
			global::System.Windows.Controls.Orientation orientation = (this.Side == global::System.Windows.Controls.Dock.Left || this.Side == global::System.Windows.Controls.Dock.Right) ? global::System.Windows.Controls.Orientation.Vertical : global::System.Windows.Controls.Orientation.Horizontal;
			if (this._location == global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.DocumentContentHost)
			{
				global::Infragistics.Windows.DockManager.DocumentContentHost documentContentHost = dragManager.DockManager.DocumentContentHost;
				if (isPreview)
				{
					global::System.Windows.Rect rect;
					if (orientation != documentContentHost.RootSplitterOrientation)
					{
						rect = global::Infragistics.Windows.DockManager.SplitPane.PredictDropNewSplit(this.Side, documentContentHost.Panel);
					}
					else
					{
						global::System.Windows.Size relativeSize = (global::System.Windows.Size)global::Infragistics.Windows.DockManager.SplitPane.RelativeSizeProperty.DefaultMetadata.DefaultValue;
						int paneIndex = (this.Side == global::System.Windows.Controls.Dock.Left || this.Side == global::System.Windows.Controls.Dock.Top) ? 0 : documentContentHost.Panes.Count;
						rect = documentContentHost.Panel.SplitPane.PredictDrop(relativeSize, paneIndex);
					}
					global::System.Windows.Controls.Dock dock = (this._side == global::System.Windows.Controls.Dock.Left || this._side == global::System.Windows.Controls.Dock.Right) ? global::System.Windows.Controls.Dock.Left : global::System.Windows.Controls.Dock.Top;
					double offset = (dock == global::System.Windows.Controls.Dock.Left) ? rect.X : rect.Y;
					dragManager.ShowDropPreview(documentContentHost.Panel, dock, rect.Size, offset, global::Infragistics.Windows.DockManager.PaneLocation.Document);
					return;
				}
				using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.ContentPane>(dragManager.PanesBeingDragged))
				{
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.IContentPaneContainer> dragPaneContainers = dragManager.GetDragPaneContainers();
					foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in dragManager.PanesBeingDragged)
					{
						global::Infragistics.Windows.DockManager.IContentPaneContainer currentContainer = contentPane.PlacementInfo.CurrentContainer;
						currentContainer.RemoveContentPane(contentPane, global::Infragistics.Windows.DockManager.DockManagerUtilities.NeedsPlaceholder(contentPane.PaneLocation, global::Infragistics.Windows.DockManager.PaneLocation.Document));
					}
					if (orientation != documentContentHost.RootSplitterOrientation)
					{
						global::Infragistics.Windows.DockManager.SplitPane splitPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(dragManager.DockManager);
						splitPane.SplitterOrientation = documentContentHost.RootSplitterOrientation;
						global::Infragistics.Windows.DockManager.SplitPane[] array = new global::Infragistics.Windows.DockManager.SplitPane[documentContentHost.Panes.Count];
						documentContentHost.Panes.CopyTo(array, 0);
						using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.SplitPane>(array))
						{
							documentContentHost.RootSplitterOrientation = orientation;
							documentContentHost.Panes.Add(splitPane);
							foreach (global::Infragistics.Windows.DockManager.SplitPane item in array)
							{
								documentContentHost.Panes.Remove(item);
								splitPane.Panes.Add(item);
							}
						}
					}
					global::Infragistics.Windows.DockManager.SplitPane splitPane2 = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateSplitPane(dragManager.DockManager);
					global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateTabGroup(dragManager.DockManager);
					int index = (this.Side == global::System.Windows.Controls.Dock.Left || this.Side == global::System.Windows.Controls.Dock.Top) ? 0 : documentContentHost.Panes.Count;
					splitPane2.Panes.Add(tabGroupPane);
					documentContentHost.Panes.Insert(index, splitPane2);
					global::Infragistics.Windows.DockManager.IContentPaneContainer contentPaneContainer = tabGroupPane;
					foreach (global::Infragistics.Windows.DockManager.ContentPane pane in dragManager.PanesBeingDragged)
					{
						contentPaneContainer.InsertContentPane(null, pane);
					}
					global::Infragistics.Windows.DockManager.DockManagerUtilities.RemoveContainersIfNeeded(dragPaneContainers);
					return;
				}
			}
			global::Infragistics.Windows.DockManager.DockManagerPanel dockPanel = dragManager.DockManager.DockPanel;
			bool flag = this.Location == global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.OuterDockManagerEdge;
			global::System.Windows.Size size = flag ? new global::System.Windows.Size(dockPanel.ActualWidth, dockPanel.ActualHeight) : dockPanel.LastContentRect.Size;
			double val = (this._side == global::System.Windows.Controls.Dock.Left || this._side == global::System.Windows.Controls.Dock.Right) ? (size.Width / 2.0) : (size.Height / 2.0);
			global::System.Windows.Size currentDragPaneSize = dragManager.CurrentDragPaneSize;
			double num = global::System.Math.Min(val, (this._side == global::System.Windows.Controls.Dock.Left || this._side == global::System.Windows.Controls.Dock.Right) ? currentDragPaneSize.Width : currentDragPaneSize.Height);
			num = global::System.Math.Max(60.0, num);
			if (isPreview)
			{
				global::System.Windows.Size size2;
				if (this._side == global::System.Windows.Controls.Dock.Left || this._side == global::System.Windows.Controls.Dock.Right)
				{
					size2 = new global::System.Windows.Size(num, double.NaN);
				}
				else
				{
					size2 = new global::System.Windows.Size(double.NaN, num);
				}
				global::Infragistics.Windows.DockManager.PaneLocation dockedLocation = global::Infragistics.Windows.DockManager.DockManagerUtilities.GetDockedLocation(this.Side);
				if (this._location == global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation.OuterDockManagerEdge)
				{
					dragManager.ShowDropPreview(dockPanel, this.Side, size2, 0.0, dockedLocation);
					return;
				}
				double num2 = 0.0;
				double num3 = 0.0;
				global::System.Windows.HorizontalAlignment horzAlign = global::System.Windows.HorizontalAlignment.Stretch;
				global::System.Windows.VerticalAlignment vertAlign = global::System.Windows.VerticalAlignment.Stretch;
				if (dragManager.DockManager.LayoutMode == global::Infragistics.Windows.DockManager.DockedPaneLayoutMode.FillContainer)
				{
					size2 = dockPanel.LastContentRect.Size;
				}
				else
				{
					global::System.Windows.Rect lastContentRect = dockPanel.LastContentRect;
					switch (this._side)
					{
					case global::System.Windows.Controls.Dock.Left:
						horzAlign = global::System.Windows.HorizontalAlignment.Left;
						num2 = lastContentRect.X;
						break;
					case global::System.Windows.Controls.Dock.Top:
						vertAlign = global::System.Windows.VerticalAlignment.Top;
						num3 = lastContentRect.Y;
						break;
					case global::System.Windows.Controls.Dock.Right:
						horzAlign = global::System.Windows.HorizontalAlignment.Right;
						num2 -= dockPanel.ActualWidth - lastContentRect.Right;
						break;
					case global::System.Windows.Controls.Dock.Bottom:
						vertAlign = global::System.Windows.VerticalAlignment.Bottom;
						num3 -= dockPanel.ActualHeight - lastContentRect.Bottom;
						break;
					}
					if (this._side == global::System.Windows.Controls.Dock.Left || this._side == global::System.Windows.Controls.Dock.Right)
					{
						vertAlign = global::System.Windows.VerticalAlignment.Top;
						num3 = lastContentRect.Y;
						size2.Height = lastContentRect.Height;
					}
					else
					{
						horzAlign = global::System.Windows.HorizontalAlignment.Left;
						num2 = lastContentRect.X;
						size2.Width = lastContentRect.Width;
					}
				}
				dragManager.ShowDropPreview(dockPanel, global::Infragistics.Windows.DockManager.Dragging.DropPreviewTabLocation.None, size2, horzAlign, vertAlign, num2, num3, dockedLocation);
				return;
			}
			else
			{
				dragManager.MoveToNewRootSplitPane(this.Side, flag, num);
			}
		}

		// Token: 0x040001F1 RID: 497
		private global::System.Windows.Controls.Dock _side;

		// Token: 0x040001F2 RID: 498
		private global::Infragistics.Windows.DockManager.Dragging.RootSplitPaneLocation _location;
	}
}
