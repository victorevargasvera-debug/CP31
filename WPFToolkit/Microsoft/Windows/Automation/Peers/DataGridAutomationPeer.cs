using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.Windows.Controls;
using Microsoft.Windows.Controls.Primitives;

namespace Microsoft.Windows.Automation.Peers
{
	// Token: 0x02000071 RID: 113
	public sealed class DataGridAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.ITableProvider, global::System.Windows.Automation.Provider.IGridProvider
	{
		// Token: 0x060007E8 RID: 2024 RVA: 0x000230F4 File Offset: 0x000212F4
		public DataGridAutomationPeer(global::Microsoft.Windows.Controls.DataGrid owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00023116 File Offset: 0x00021316
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0002311C File Offset: 0x0002131C
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = this.GetItemPeers();
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter columnHeadersPresenter = this.OwningDataGrid.ColumnHeadersPresenter;
			if (columnHeadersPresenter != null && columnHeadersPresenter.IsVisible)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(columnHeadersPresenter);
				if (automationPeer != null)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(1);
					}
					list.Insert(0, automationPeer);
				}
			}
			return list;
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00023164 File Offset: 0x00021364
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00023178 File Offset: 0x00021378
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface <= global::System.Windows.Automation.Peers.PatternInterface.Scroll)
			{
				if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Selection)
				{
					if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Scroll)
					{
						goto IL_47;
					}
					global::System.Windows.Controls.ScrollViewer internalScrollHost = this.OwningDataGrid.InternalScrollHost;
					if (internalScrollHost == null)
					{
						goto IL_47;
					}
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(internalScrollHost);
					global::System.Windows.Automation.Provider.IScrollProvider scrollProvider = automationPeer as global::System.Windows.Automation.Provider.IScrollProvider;
					if (automationPeer != null && scrollProvider != null)
					{
						automationPeer.EventsSource = this;
						return scrollProvider;
					}
					goto IL_47;
				}
			}
			else if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Grid && patternInterface != global::System.Windows.Automation.Peers.PatternInterface.Table)
			{
				goto IL_47;
			}
			return this;
			IL_47:
			return base.GetPattern(patternInterface);
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x000231D3 File Offset: 0x000213D3
		int global::System.Windows.Automation.Provider.IGridProvider.ColumnCount
		{
			get
			{
				return this.OwningDataGrid.Columns.Count;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x000231E5 File Offset: 0x000213E5
		int global::System.Windows.Automation.Provider.IGridProvider.RowCount
		{
			get
			{
				return this.OwningDataGrid.Items.Count;
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x000231F8 File Offset: 0x000213F8
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column)
		{
			if (row >= 0 && row < this.OwningDataGrid.Items.Count && column >= 0 && column < this.OwningDataGrid.Columns.Count)
			{
				object item = this.OwningDataGrid.Items[row];
				global::Microsoft.Windows.Controls.DataGridColumn column2 = this.OwningDataGrid.Columns[column];
				this.OwningDataGrid.ScrollIntoView(item, column2);
				this.OwningDataGrid.UpdateLayout();
				global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = this.GetOrCreateItemPeer(item);
				if (orCreateItemPeer != null)
				{
					global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer orCreateCellItemPeer = orCreateItemPeer.GetOrCreateCellItemPeer(column2);
					if (orCreateCellItemPeer != null)
					{
						return base.ProviderFromPeer(orCreateCellItemPeer);
					}
				}
			}
			return null;
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00023294 File Offset: 0x00021494
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
			switch (this.OwningDataGrid.SelectionUnit)
			{
			case global::Microsoft.Windows.Controls.DataGridSelectionUnit.Cell:
				this.AddSelectedCells(list);
				break;
			case global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow:
				this.AddSelectedRows(list);
				break;
			case global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader:
				this.AddSelectedRows(list);
				this.AddSelectedCells(list);
				break;
			}
			return list.ToArray();
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000232ED File Offset: 0x000214ED
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return this.OwningDataGrid.SelectionMode == global::Microsoft.Windows.Controls.DataGridSelectionMode.Extended;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060007F2 RID: 2034 RVA: 0x000232FD File Offset: 0x000214FD
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00023300 File Offset: 0x00021500
		global::System.Windows.Automation.RowOrColumnMajor global::System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor
		{
			get
			{
				return global::System.Windows.Automation.RowOrColumnMajor.RowMajor;
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00023304 File Offset: 0x00021504
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders()
		{
			if ((this.OwningDataGrid.HeadersVisibility & global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Column) == global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Column)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
				global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter columnHeadersPresenter = this.OwningDataGrid.ColumnHeadersPresenter;
				for (int i = 0; i < this.OwningDataGrid.Columns.Count; i++)
				{
					global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = columnHeadersPresenter.ItemContainerGenerator.ContainerFromIndex(i) as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
					if (dataGridColumnHeader != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(dataGridColumnHeader);
						if (automationPeer != null)
						{
							list.Add(base.ProviderFromPeer(automationPeer));
						}
					}
				}
				if (list.Count > 0)
				{
					return list.ToArray();
				}
			}
			return null;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00023390 File Offset: 0x00021590
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetRowHeaders()
		{
			if ((this.OwningDataGrid.HeadersVisibility & global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Row) == global::Microsoft.Windows.Controls.DataGridHeadersVisibility.Row)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
				foreach (object item in ((global::System.Collections.IEnumerable)this.OwningDataGrid.Items))
				{
					global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = this.GetOrCreateItemPeer(item);
					global::System.Windows.Automation.Peers.AutomationPeer rowHeaderAutomationPeer = orCreateItemPeer.RowHeaderAutomationPeer;
					if (rowHeaderAutomationPeer != null)
					{
						list.Add(base.ProviderFromPeer(rowHeaderAutomationPeer));
					}
				}
				if (list.Count > 0)
				{
					return list.ToArray();
				}
			}
			return null;
		}

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00023430 File Offset: 0x00021630
		private global::Microsoft.Windows.Controls.DataGrid OwningDataGrid
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGrid)base.Owner;
			}
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00023440 File Offset: 0x00021640
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetItemPeers()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			global::System.Collections.Generic.Dictionary<object, global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer> dictionary = new global::System.Collections.Generic.Dictionary<object, global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer>(this._itemPeers);
			this._itemPeers.Clear();
			foreach (object obj in ((global::System.Collections.IEnumerable)this.OwningDataGrid.Items))
			{
				global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer dataGridItemAutomationPeer = null;
				bool flag = dictionary.TryGetValue(obj, out dataGridItemAutomationPeer);
				if (!flag || dataGridItemAutomationPeer == null)
				{
					dataGridItemAutomationPeer = new global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer(obj, this.OwningDataGrid);
				}
				list.Add(dataGridItemAutomationPeer);
				this._itemPeers.Add(obj, dataGridItemAutomationPeer);
			}
			return list;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000234EC File Offset: 0x000216EC
		internal global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer GetOrCreateItemPeer(object item)
		{
			global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer dataGridItemAutomationPeer = null;
			bool flag = this._itemPeers.TryGetValue(item, out dataGridItemAutomationPeer);
			if (!flag || dataGridItemAutomationPeer == null)
			{
				dataGridItemAutomationPeer = new global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer(item, this.OwningDataGrid);
				this._itemPeers.Add(item, dataGridItemAutomationPeer);
			}
			return dataGridItemAutomationPeer;
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0002352C File Offset: 0x0002172C
		private global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer GetCellItemPeer(global::Microsoft.Windows.Controls.DataGridCellInfo cellInfo)
		{
			if (cellInfo.IsValid)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = this.GetOrCreateItemPeer(cellInfo.Item);
				if (orCreateItemPeer != null)
				{
					return orCreateItemPeer.GetOrCreateCellItemPeer(cellInfo.Column);
				}
			}
			return null;
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00023564 File Offset: 0x00021764
		internal void RaiseAutomationCellSelectedEvent(global::Microsoft.Windows.Controls.SelectedCellsChangedEventArgs e)
		{
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected) && this.OwningDataGrid.SelectedCells.Count == 1 && e.AddedCells.Count == 1)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer cellItemPeer = this.GetCellItemPeer(e.AddedCells[0]);
				if (cellItemPeer != null)
				{
					cellItemPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected);
					return;
				}
			}
			else
			{
				if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection))
				{
					for (int i = 0; i < e.AddedCells.Count; i++)
					{
						global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer cellItemPeer2 = this.GetCellItemPeer(e.AddedCells[i]);
						if (cellItemPeer2 != null)
						{
							cellItemPeer2.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection);
						}
					}
				}
				if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
				{
					for (int i = 0; i < e.RemovedCells.Count; i++)
					{
						global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer cellItemPeer3 = this.GetCellItemPeer(e.RemovedCells[i]);
						if (cellItemPeer3 != null)
						{
							cellItemPeer3.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection);
						}
					}
				}
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00023630 File Offset: 0x00021830
		internal void RaiseAutomationRowInvokeEvents(global::Microsoft.Windows.Controls.DataGridRow row)
		{
			global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = this.GetOrCreateItemPeer(row.Item);
			if (orCreateItemPeer != null)
			{
				orCreateItemPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked);
			}
		}

		// Token: 0x060007FC RID: 2044 RVA: 0x00023654 File Offset: 0x00021854
		internal void RaiseAutomationCellInvokeEvents(global::Microsoft.Windows.Controls.DataGridColumn column, global::Microsoft.Windows.Controls.DataGridRow row)
		{
			global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = this.GetOrCreateItemPeer(row.Item);
			if (orCreateItemPeer != null)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer orCreateCellItemPeer = orCreateItemPeer.GetOrCreateCellItemPeer(column);
				if (orCreateCellItemPeer != null)
				{
					orCreateCellItemPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked);
				}
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x00023684 File Offset: 0x00021884
		internal void RaiseAutomationSelectionEvents(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			int count = this.OwningDataGrid.SelectedItems.Count;
			int count2 = e.AddedItems.Count;
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected) && count == 1 && count2 == 1)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = this.GetOrCreateItemPeer(this.OwningDataGrid.SelectedItem);
				if (orCreateItemPeer != null)
				{
					orCreateItemPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected);
					return;
				}
			}
			else
			{
				if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection))
				{
					for (int i = 0; i < e.AddedItems.Count; i++)
					{
						global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer2 = this.GetOrCreateItemPeer(e.AddedItems[i]);
						if (orCreateItemPeer2 != null)
						{
							orCreateItemPeer2.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection);
						}
					}
				}
				if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
				{
					for (int i = 0; i < e.RemovedItems.Count; i++)
					{
						global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer3 = this.GetOrCreateItemPeer(e.RemovedItems[i]);
						if (orCreateItemPeer3 != null)
						{
							orCreateItemPeer3.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection);
						}
					}
				}
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0002375C File Offset: 0x0002195C
		private void AddSelectedCells(global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> cellProviders)
		{
			if (cellProviders == null)
			{
				throw new global::System.ArgumentNullException("cellProviders");
			}
			if (this.OwningDataGrid.SelectedCells != null)
			{
				foreach (global::Microsoft.Windows.Controls.DataGridCellInfo dataGridCellInfo in this.OwningDataGrid.SelectedCells)
				{
					global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = this.GetOrCreateItemPeer(dataGridCellInfo.Item);
					if (orCreateItemPeer != null)
					{
						global::System.Windows.Automation.Provider.IRawElementProviderSimple rawElementProviderSimple = base.ProviderFromPeer(orCreateItemPeer.GetOrCreateCellItemPeer(dataGridCellInfo.Column));
						if (rawElementProviderSimple != null)
						{
							cellProviders.Add(rawElementProviderSimple);
						}
					}
				}
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x000237F4 File Offset: 0x000219F4
		private void AddSelectedRows(global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> itemProviders)
		{
			if (itemProviders == null)
			{
				throw new global::System.ArgumentNullException("itemProviders");
			}
			if (this.OwningDataGrid.SelectedItems != null)
			{
				foreach (object item in this.OwningDataGrid.SelectedItems)
				{
					global::System.Windows.Automation.Provider.IRawElementProviderSimple rawElementProviderSimple = base.ProviderFromPeer(this.GetOrCreateItemPeer(item));
					if (rawElementProviderSimple != null)
					{
						itemProviders.Add(rawElementProviderSimple);
					}
				}
			}
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0002387C File Offset: 0x00021A7C
		internal static global::System.Windows.Rect CalculateVisibleBoundingRect(global::System.Windows.UIElement uiElement)
		{
			global::System.Windows.Rect empty = global::System.Windows.Rect.Empty;
			empty = new global::System.Windows.Rect(uiElement.RenderSize);
			global::System.Windows.Media.Visual visual = global::System.Windows.Media.VisualTreeHelper.GetParent(uiElement) as global::System.Windows.Media.Visual;
			while (visual != null && empty != global::System.Windows.Rect.Empty && empty.Height != 0.0 && empty.Width != 0.0)
			{
				global::System.Windows.Media.Geometry clip = global::System.Windows.Media.VisualTreeHelper.GetClip(visual);
				if (clip != null)
				{
					global::System.Windows.Media.GeneralTransform inverse = uiElement.TransformToAncestor(visual).Inverse;
					if (inverse != null)
					{
						global::System.Windows.Rect rect = clip.Bounds;
						rect = inverse.TransformBounds(rect);
						empty.Intersect(rect);
					}
					else
					{
						empty = global::System.Windows.Rect.Empty;
					}
				}
				visual = (global::System.Windows.Media.VisualTreeHelper.GetParent(visual) as global::System.Windows.Media.Visual);
			}
			return empty;
		}

		// Token: 0x04000285 RID: 645
		private global::System.Collections.Generic.Dictionary<object, global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer> _itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer>();
	}
}
