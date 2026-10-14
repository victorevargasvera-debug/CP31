using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Infragistics.Collections;

namespace Infragistics.Windows.DockManager
{
	// Token: 0x020000D3 RID: 211
	internal class UnpinnedTabAreaInfo : global::Infragistics.Windows.DockManager.IContentPaneContainer
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x00020504 File Offset: 0x0001E704
		internal UnpinnedTabAreaInfo(global::Infragistics.Windows.DockManager.XamDockManager dockManager)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(dockManager, "dockManager");
			this._dockManager = dockManager;
			this._panes = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DockManager.ContentPane>();
			this._panes.CollectionChanged += this.OnPanesChanged;
			this._readOnlyPanes = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.ContentPane>(this._panes);
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060006EB RID: 1771 RVA: 0x0002055C File Offset: 0x0001E75C
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.ContentPane> Panes
		{
			get
			{
				return this._readOnlyPanes;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006EC RID: 1772 RVA: 0x00020564 File Offset: 0x0001E764
		// (set) Token: 0x060006ED RID: 1773 RVA: 0x0002056C File Offset: 0x0001E76C
		public global::Infragistics.Windows.DockManager.UnpinnedTabArea TabArea
		{
			get
			{
				return this._tabArea;
			}
			set
			{
				if (value != this._tabArea)
				{
					using (global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateMoveReplacement<global::Infragistics.Windows.DockManager.ContentPane>(this._panes))
					{
						if (this._tabArea != null)
						{
							this._tabArea.ItemsSource = null;
							foreach (global::Infragistics.Windows.DockManager.ContentPane child in this._panes)
							{
								this._tabArea.RemoveLogicalChildInternal(child);
							}
							this._tabArea.ClearValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey);
						}
						else
						{
							foreach (global::Infragistics.Windows.DockManager.ContentPane child2 in this._panes)
							{
								this._dockManager.UnpinnedPaneHolder.RemoveLogicalChildInternal(child2);
							}
						}
						this._tabArea = value;
						if (this._tabArea != null)
						{
							this._tabArea.SetValue(global::Infragistics.Windows.DockManager.XamDockManager.PaneLocationPropertyKey, global::Infragistics.Windows.DockManager.DockManagerKnownBoxes.PaneLocationUnpinnedBox);
							foreach (global::Infragistics.Windows.DockManager.ContentPane child3 in this._panes)
							{
								this._tabArea.AddLogicalChildInternal(child3);
							}
							this._tabArea.ItemsSource = this.Panes;
						}
						else
						{
							foreach (global::Infragistics.Windows.DockManager.ContentPane child4 in this._panes)
							{
								this._dockManager.UnpinnedPaneHolder.AddLogicalChildInternal(child4);
							}
						}
					}
				}
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0002076C File Offset: 0x0001E96C
		internal void AddPane(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			int num = this._panes.Count - 1;
			while (num >= 0 && !pane.PlacementInfo.IsInSameDockedContainer(this._panes[num]))
			{
				num--;
			}
			if (num < 0)
			{
				num = this._panes.Count;
			}
			else
			{
				num++;
			}
			this._panes.Insert(num, pane);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x000207CD File Offset: 0x0001E9CD
		internal void RemovePane(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			this._panes.Remove(pane);
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x000207DC File Offset: 0x0001E9DC
		internal void SortPanes(global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo.SortOrderInfo> list)
		{
			if (this._sortingPanes)
			{
				return;
			}
			list.Sort();
			this._panes.BeginUpdate();
			this._sortingPanes = true;
			try
			{
				int num = global::System.Math.Max(0, this._panes.Count - list.Count);
				int i = num;
				int count = list.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DockManager.ContentPane pane = list[i].Pane;
					int num2 = this._panes.IndexOf(pane);
					if (num2 != i && num2 >= 0)
					{
						this._panes.Move(num2, i);
					}
					i++;
				}
			}
			finally
			{
				this._panes.EndUpdate();
				this._sortingPanes = false;
			}
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x00020890 File Offset: 0x0001EA90
		private void DirtyMeasure()
		{
			if (this._tabArea != null && this._tabArea.IsMeasureValid)
			{
				global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetParent(this._tabArea) as global::System.Windows.UIElement;
				if (uielement != null)
				{
					global::System.Windows.Controls.ItemsPresenter templateChild = global::Infragistics.Windows.Utilities.GetTemplateChild<global::System.Windows.Controls.ItemsPresenter>(this._tabArea);
					if (templateChild != null && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(templateChild) == 1)
					{
						for (global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetChild(templateChild, 0); dependencyObject != null; dependencyObject = global::System.Windows.Media.VisualTreeHelper.GetParent(dependencyObject))
						{
							global::System.Windows.UIElement uielement2 = dependencyObject as global::System.Windows.UIElement;
							if (uielement2 != null)
							{
								uielement2.InvalidateMeasure();
							}
							if (dependencyObject == uielement)
							{
								return;
							}
						}
					}
				}
			}
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x00020908 File Offset: 0x0001EB08
		private void OnPanesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				if (e.NewItems.Count != 1)
				{
					throw new global::System.InvalidOperationException();
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializeCurrentContainer(e.NewItems, this);
				global::Infragistics.Windows.DockManager.ContentPane contentPane = e.NewItems[0] as global::Infragistics.Windows.DockManager.ContentPane;
				if (this._tabArea != null)
				{
					this._tabArea.AddLogicalChildInternal(contentPane);
				}
				else
				{
					this._dockManager.UnpinnedPaneHolder.AddLogicalChildInternal(contentPane);
				}
				if (contentPane != null)
				{
					global::Infragistics.Windows.DockManager.DockManagerPanel dockPanel = this._dockManager.DockPanel;
					if (dockPanel != null)
					{
						dockPanel.AddUnpinnedPane(contentPane);
					}
				}
				this.DirtyMeasure();
				return;
			}
			else
			{
				if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
				{
					if (this._sortingPanes)
					{
						global::System.Collections.Specialized.NotifyCollectionChangedAction action = e.Action;
					}
					return;
				}
				if (e.OldItems.Count != 1)
				{
					throw new global::System.InvalidOperationException();
				}
				global::Infragistics.Windows.DockManager.ContentPane contentPane2 = e.OldItems[0] as global::Infragistics.Windows.DockManager.ContentPane;
				if (this._tabArea != null)
				{
					this._tabArea.RemoveLogicalChildInternal(contentPane2);
					this._dockManager.HideFlyout(contentPane2, false, false, true, false, false);
					global::Infragistics.Windows.DockManager.DockManagerPanel dockPanel2 = this._dockManager.DockPanel;
					if (dockPanel2 != null)
					{
						dockPanel2.RemoveUnpinnedPane(contentPane2);
					}
				}
				else
				{
					this._dockManager.UnpinnedPaneHolder.RemoveLogicalChildInternal(contentPane2);
				}
				global::Infragistics.Windows.DockManager.DockManagerUtilities.InitializeCurrentContainer(e.OldItems, null);
				this.DirtyMeasure();
				return;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x00020A3A File Offset: 0x0001EC3A
		global::Infragistics.Windows.DockManager.PaneLocation global::Infragistics.Windows.DockManager.IContentPaneContainer.PaneLocation
		{
			get
			{
				return global::Infragistics.Windows.DockManager.PaneLocation.Unpinned;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x00020A3D File Offset: 0x0001EC3D
		global::System.Windows.FrameworkElement global::Infragistics.Windows.DockManager.IContentPaneContainer.ContainerElement
		{
			get
			{
				return this._tabArea;
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x00020A45 File Offset: 0x0001EC45
		void global::Infragistics.Windows.DockManager.IContentPaneContainer.RemoveContentPane(global::Infragistics.Windows.DockManager.ContentPane pane, bool replaceWithPlaceholder)
		{
			this.RemovePane(pane);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x00020A4E File Offset: 0x0001EC4E
		void global::Infragistics.Windows.DockManager.IContentPaneContainer.InsertContentPane(int? newIndex, global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			this.AddPane(pane);
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x00020A57 File Offset: 0x0001EC57
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> global::Infragistics.Windows.DockManager.IContentPaneContainer.GetVisiblePanes()
		{
			return global::Infragistics.Windows.DockManager.DockManagerUtilities.CreateVisiblePaneList(this._panes);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x00020A64 File Offset: 0x0001EC64
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> global::Infragistics.Windows.DockManager.IContentPaneContainer.GetAllPanesForPaneAction(global::Infragistics.Windows.DockManager.ContentPane pane)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DockManager.ContentPane> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DockManager.ContentPane>();
			foreach (global::Infragistics.Windows.DockManager.ContentPane contentPane in this.Panes)
			{
				if (contentPane.Visibility == global::System.Windows.Visibility.Visible && contentPane.PlacementInfo.IsInSameDockedContainer(pane))
				{
					list.Add(contentPane);
				}
			}
			return list;
		}

		// Token: 0x040003AE RID: 942
		private global::Infragistics.Windows.DockManager.XamDockManager _dockManager;

		// Token: 0x040003AF RID: 943
		private global::Infragistics.Windows.DockManager.UnpinnedTabArea _tabArea;

		// Token: 0x040003B0 RID: 944
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.DockManager.ContentPane> _panes;

		// Token: 0x040003B1 RID: 945
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DockManager.ContentPane> _readOnlyPanes;

		// Token: 0x040003B2 RID: 946
		private bool _sortingPanes;

		// Token: 0x020000D4 RID: 212
		internal class SortOrderInfo : global::System.IComparable<global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo.SortOrderInfo>
		{
			// Token: 0x060006F9 RID: 1785 RVA: 0x00020AD0 File Offset: 0x0001ECD0
			internal SortOrderInfo(global::Infragistics.Windows.DockManager.ContentPane pane, int order)
			{
				this.Pane = pane;
				this.Order = order;
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x00020AE6 File Offset: 0x0001ECE6
			public int CompareTo(global::Infragistics.Windows.DockManager.UnpinnedTabAreaInfo.SortOrderInfo other)
			{
				if (other == null)
				{
					return 1;
				}
				if (this.Pane == other.Pane)
				{
					return 0;
				}
				return this.Order.CompareTo(other.Order);
			}

			// Token: 0x040003B3 RID: 947
			internal global::Infragistics.Windows.DockManager.ContentPane Pane;

			// Token: 0x040003B4 RID: 948
			internal int Order;
		}
	}
}
