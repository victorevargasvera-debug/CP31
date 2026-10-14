using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Data;
using Microsoft.Windows.Controls;

namespace Microsoft.Windows.Automation.Peers
{
	// Token: 0x0200001D RID: 29
	public sealed class DataGridItemAutomationPeer : global::System.Windows.Automation.Peers.AutomationPeer, global::System.Windows.Automation.Provider.IInvokeProvider, global::System.Windows.Automation.Provider.IScrollItemProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x060001BA RID: 442 RVA: 0x0000744C File Offset: 0x0000564C
		public DataGridItemAutomationPeer(object item, global::Microsoft.Windows.Controls.DataGrid dataGrid)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (dataGrid == null)
			{
				throw new global::System.ArgumentNullException("dataGrid");
			}
			this._item = item;
			this._dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(dataGrid);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00007499 File Offset: 0x00005699
		protected override string GetAcceleratorKeyCore()
		{
			if (this.OwningRowPeer == null)
			{
				return string.Empty;
			}
			return this.OwningRowPeer.GetAcceleratorKey();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000074B4 File Offset: 0x000056B4
		protected override string GetAccessKeyCore()
		{
			if (this.OwningRowPeer == null)
			{
				return string.Empty;
			}
			return this.OwningRowPeer.GetAccessKey();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000074CF File Offset: 0x000056CF
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.DataItem;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000074D3 File Offset: 0x000056D3
		protected override string GetAutomationIdCore()
		{
			if (this.OwningRowPeer == null)
			{
				return string.Empty;
			}
			return this.OwningRowPeer.GetAutomationId();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000074F0 File Offset: 0x000056F0
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			if (this.OwningRowPeer == null)
			{
				return default(global::System.Windows.Rect);
			}
			return this.OwningRowPeer.GetBoundingRectangle();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000751C File Offset: 0x0000571C
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer owningRowPeer = this.OwningRowPeer;
			if (owningRowPeer != null)
			{
				owningRowPeer.ResetChildrenCache();
				return owningRowPeer.GetChildren();
			}
			return this.GetCellItemPeers();
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00007546 File Offset: 0x00005746
		protected override string GetClassNameCore()
		{
			if (this.OwningRowPeer == null)
			{
				return string.Empty;
			}
			return this.OwningRowPeer.GetClassName();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00007561 File Offset: 0x00005761
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			if (this.OwningRowPeer == null)
			{
				return new global::System.Windows.Point(double.NaN, double.NaN);
			}
			return this.OwningRowPeer.GetClickablePoint();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000758E File Offset: 0x0000578E
		protected override string GetHelpTextCore()
		{
			if (this.OwningRowPeer == null)
			{
				return string.Empty;
			}
			return this.OwningRowPeer.GetHelpText();
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000075A9 File Offset: 0x000057A9
		protected override string GetItemStatusCore()
		{
			if (this.OwningRowPeer == null)
			{
				return string.Empty;
			}
			return this.OwningRowPeer.GetItemStatus();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000075C4 File Offset: 0x000057C4
		protected override string GetItemTypeCore()
		{
			if (this.OwningRowPeer == null)
			{
				return string.Empty;
			}
			return this.OwningRowPeer.GetItemType();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000075DF File Offset: 0x000057DF
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			if (this.OwningRowPeer == null)
			{
				return null;
			}
			return this.OwningRowPeer.GetLabeledBy();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x000075F6 File Offset: 0x000057F6
		protected override string GetLocalizedControlTypeCore()
		{
			if (this.OwningRowPeer == null)
			{
				return base.GetLocalizedControlTypeCore();
			}
			return this.OwningRowPeer.GetLocalizedControlType();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00007612 File Offset: 0x00005812
		protected override string GetNameCore()
		{
			return this._item.ToString();
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000761F File Offset: 0x0000581F
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			if (this.OwningRowPeer == null)
			{
				return global::System.Windows.Automation.Peers.AutomationOrientation.None;
			}
			return this.OwningRowPeer.GetOrientation();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00007638 File Offset: 0x00005838
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			switch (patternInterface)
			{
			case global::System.Windows.Automation.Peers.PatternInterface.Invoke:
				if (!this.OwningDataGrid.IsReadOnly)
				{
					return this;
				}
				goto IL_36;
			case global::System.Windows.Automation.Peers.PatternInterface.Selection:
				break;
			default:
				if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.ScrollItem)
				{
					if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
					{
						goto IL_36;
					}
					if (this.IsRowSelectionUnit)
					{
						return this;
					}
					goto IL_36;
				}
				break;
			}
			return this;
			IL_36:
			return null;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000767C File Offset: 0x0000587C
		protected override bool HasKeyboardFocusCore()
		{
			return this.OwningRowPeer != null && this.OwningRowPeer.HasKeyboardFocus();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00007693 File Offset: 0x00005893
		protected override bool IsContentElementCore()
		{
			return this.OwningRowPeer == null || this.OwningRowPeer.IsContentElement();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000076AA File Offset: 0x000058AA
		protected override bool IsControlElementCore()
		{
			return this.OwningRowPeer == null || this.OwningRowPeer.IsControlElement();
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000076C1 File Offset: 0x000058C1
		protected override bool IsEnabledCore()
		{
			return this.OwningRowPeer == null || this.OwningRowPeer.IsEnabled();
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000076D8 File Offset: 0x000058D8
		protected override bool IsKeyboardFocusableCore()
		{
			return this.OwningRowPeer != null && this.OwningRowPeer.IsKeyboardFocusable();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000076EF File Offset: 0x000058EF
		protected override bool IsOffscreenCore()
		{
			return this.OwningRowPeer == null || this.OwningRowPeer.IsOffscreen();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00007706 File Offset: 0x00005906
		protected override bool IsPasswordCore()
		{
			return this.OwningRowPeer != null && this.OwningRowPeer.IsPassword();
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000771D File Offset: 0x0000591D
		protected override bool IsRequiredForFormCore()
		{
			return this.OwningRowPeer != null && this.OwningRowPeer.IsRequiredForForm();
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00007734 File Offset: 0x00005934
		protected override void SetFocusCore()
		{
			if (this.OwningRowPeer != null && this.OwningRowPeer.Owner.Focusable)
			{
				this.OwningRowPeer.SetFocus();
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000775C File Offset: 0x0000595C
		void global::System.Windows.Automation.Provider.IInvokeProvider.Invoke()
		{
			this.EnsureEnabled();
			if (this.OwningRowPeer == null)
			{
				this.OwningDataGrid.ScrollIntoView(this._item);
			}
			bool flag = false;
			if (this.OwningRow != null)
			{
				global::System.ComponentModel.IEditableCollectionView items = this.OwningDataGrid.Items;
				if (items.CurrentEditItem == this._item)
				{
					flag = this.OwningDataGrid.CommitEdit();
				}
				else if (this.OwningDataGrid.Columns.Count > 0)
				{
					global::Microsoft.Windows.Controls.DataGridCell dataGridCell = this.OwningDataGrid.TryFindCell(this._item, this.OwningDataGrid.Columns[0]);
					if (dataGridCell != null)
					{
						this.OwningDataGrid.UnselectAll();
						dataGridCell.Focus();
						flag = this.OwningDataGrid.BeginEdit();
					}
				}
			}
			if (!flag && !this.IsNewItemPlaceholder)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_AutomationInvokeFailed));
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000782C File Offset: 0x00005A2C
		void global::System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView()
		{
			this.OwningDataGrid.ScrollIntoView(this._item);
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000783F File Offset: 0x00005A3F
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this.OwningDataGrid.SelectedItems.Contains(this._item);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00007857 File Offset: 0x00005A57
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				return base.ProviderFromPeer(this._dataGridAutomationPeer);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00007868 File Offset: 0x00005A68
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			if (!this.IsRowSelectionUnit)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGridRow_CannotSelectRowWhenCells));
			}
			if (this.OwningDataGrid.SelectedItems.Contains(this._item))
			{
				return;
			}
			this.EnsureEnabled();
			if (this.OwningDataGrid.SelectionMode == global::Microsoft.Windows.Controls.DataGridSelectionMode.Single && this.OwningDataGrid.SelectedItems.Count > 0)
			{
				throw new global::System.InvalidOperationException();
			}
			if (this.OwningDataGrid.Items.Contains(this._item))
			{
				this.OwningDataGrid.SelectedItems.Add(this._item);
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007904 File Offset: 0x00005B04
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!this.IsRowSelectionUnit)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGridRow_CannotSelectRowWhenCells));
			}
			this.EnsureEnabled();
			if (this.OwningDataGrid.SelectedItems.Contains(this._item))
			{
				this.OwningDataGrid.SelectedItems.Remove(this._item);
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000795D File Offset: 0x00005B5D
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			if (!this.IsRowSelectionUnit)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGridRow_CannotSelectRowWhenCells));
			}
			this.EnsureEnabled();
			this.OwningDataGrid.SelectedItem = this._item;
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000798E File Offset: 0x00005B8E
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return this.OwningDataGrid.SelectionMode == global::Microsoft.Windows.Controls.DataGridSelectionMode.Extended;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000799E File Offset: 0x00005B9E
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000079A4 File Offset: 0x00005BA4
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Microsoft.Windows.Controls.DataGrid owningDataGrid = this.OwningDataGrid;
			if (owningDataGrid == null)
			{
				return null;
			}
			int num = owningDataGrid.Items.IndexOf(this._item);
			if (num > -1 && owningDataGrid.SelectedCellsInternal.Intersects(num))
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
				for (int i = 0; i < this.OwningDataGrid.Columns.Count; i++)
				{
					if (owningDataGrid.SelectedCellsInternal.Contains(num, i))
					{
						global::Microsoft.Windows.Controls.DataGridColumn column = owningDataGrid.ColumnFromDisplayIndex(i);
						global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer orCreateCellItemPeer = this.GetOrCreateCellItemPeer(column);
						if (orCreateCellItemPeer != null)
						{
							list.Add(base.ProviderFromPeer(orCreateCellItemPeer));
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

		// Token: 0x060001DE RID: 478 RVA: 0x00007A48 File Offset: 0x00005C48
		internal global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetCellItemPeers()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			global::System.Collections.Generic.Dictionary<global::Microsoft.Windows.Controls.DataGridColumn, global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer> dictionary = new global::System.Collections.Generic.Dictionary<global::Microsoft.Windows.Controls.DataGridColumn, global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer>(this._itemPeers);
			this._itemPeers.Clear();
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this.OwningDataGrid.Columns)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer dataGridCellItemAutomationPeer = null;
				bool flag = dictionary.TryGetValue(dataGridColumn, out dataGridCellItemAutomationPeer);
				if (!flag || dataGridCellItemAutomationPeer == null)
				{
					dataGridCellItemAutomationPeer = new global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer(this._item, dataGridColumn);
				}
				list.Add(dataGridCellItemAutomationPeer);
				this._itemPeers.Add(dataGridColumn, dataGridCellItemAutomationPeer);
			}
			return list;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007AEC File Offset: 0x00005CEC
		internal global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer GetOrCreateCellItemPeer(global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer dataGridCellItemAutomationPeer = null;
			bool flag = this._itemPeers.TryGetValue(column, out dataGridCellItemAutomationPeer);
			if (!flag || dataGridCellItemAutomationPeer == null)
			{
				dataGridCellItemAutomationPeer = new global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer(this._item, column);
				this._itemPeers.Add(column, dataGridCellItemAutomationPeer);
			}
			return dataGridCellItemAutomationPeer;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00007B2B File Offset: 0x00005D2B
		internal global::System.Windows.Automation.Peers.AutomationPeer RowHeaderAutomationPeer
		{
			get
			{
				if (this.OwningRowPeer == null)
				{
					return null;
				}
				return this.OwningRowPeer.RowHeaderAutomationPeer;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007B42 File Offset: 0x00005D42
		private void EnsureEnabled()
		{
			if (!this._dataGridAutomationPeer.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00007B57 File Offset: 0x00005D57
		private bool IsRowSelectionUnit
		{
			get
			{
				return this.OwningDataGrid != null && (this.OwningDataGrid.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow || this.OwningDataGrid.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00007B81 File Offset: 0x00005D81
		private bool IsNewItemPlaceholder
		{
			get
			{
				return this._item == global::System.Windows.Data.CollectionView.NewItemPlaceholder || this._item == global::Microsoft.Windows.Controls.DataGrid.NewItemPlaceholder;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00007BA0 File Offset: 0x00005DA0
		private global::Microsoft.Windows.Controls.DataGrid OwningDataGrid
		{
			get
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = this._dataGridAutomationPeer as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				return (global::Microsoft.Windows.Controls.DataGrid)dataGridAutomationPeer.Owner;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x00007BC4 File Offset: 0x00005DC4
		private global::Microsoft.Windows.Controls.DataGridRow OwningRow
		{
			get
			{
				return this.OwningDataGrid.ItemContainerGenerator.ContainerFromItem(this._item) as global::Microsoft.Windows.Controls.DataGridRow;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00007BE4 File Offset: 0x00005DE4
		internal global::Microsoft.Windows.Automation.Peers.DataGridRowAutomationPeer OwningRowPeer
		{
			get
			{
				global::Microsoft.Windows.Automation.Peers.DataGridRowAutomationPeer result = null;
				global::Microsoft.Windows.Controls.DataGridRow owningRow = this.OwningRow;
				if (owningRow != null)
				{
					result = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(owningRow) as global::Microsoft.Windows.Automation.Peers.DataGridRowAutomationPeer);
				}
				return result;
			}
		}

		// Token: 0x04000078 RID: 120
		private object _item;

		// Token: 0x04000079 RID: 121
		private global::System.Windows.Automation.Peers.AutomationPeer _dataGridAutomationPeer;

		// Token: 0x0400007A RID: 122
		private global::System.Collections.Generic.Dictionary<global::Microsoft.Windows.Controls.DataGridColumn, global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer> _itemPeers = new global::System.Collections.Generic.Dictionary<global::Microsoft.Windows.Controls.DataGridColumn, global::Microsoft.Windows.Automation.Peers.DataGridCellItemAutomationPeer>();
	}
}
