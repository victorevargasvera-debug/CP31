using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Grids;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000006 RID: 6
	public class CellsPanelAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x06000031 RID: 49 RVA: 0x00002884 File Offset: 0x00000A84
		public CellsPanelAutomationPeer(global::Infragistics.Controls.Grids.Primitives.CellsPanel owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			if (this.Row != null)
			{
				this.Row.PropertyChanged += this.Row_PropertyChanged;
			}
			if (this.Grid != null)
			{
				this.Grid.SelectionSettings.PropertyChanged += this.SelectionSettings_PropertyChanged;
			}
			this.OldCanSelectMultiple = this.CanSelectMultiple;
			if (this.ExpandableRow != null)
			{
				this.ExpandableRow.PropertyChanged += this.ExpandableRow_PropertyChanged;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002914 File Offset: 0x00000B14
		private global::Infragistics.Controls.Grids.XamGrid Grid
		{
			get
			{
				if (this.OwningCellsPanel.Row != null)
				{
					return this.OwningCellsPanel.Row.ColumnLayout.Grid;
				}
				return null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000293A File Offset: 0x00000B3A
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002942 File Offset: 0x00000B42
		private bool OldCanSelectMultiple { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000035 RID: 53 RVA: 0x0000294B File Offset: 0x00000B4B
		private global::Infragistics.Controls.Grids.Primitives.CellsPanel OwningCellsPanel
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Primitives.CellsPanel)base.Owner;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002958 File Offset: 0x00000B58
		private global::Infragistics.Controls.Grids.Row Row
		{
			get
			{
				return this.OwningCellsPanel.Row as global::Infragistics.Controls.Grids.Row;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000037 RID: 55 RVA: 0x0000296A File Offset: 0x00000B6A
		private global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase ExpandableRow
		{
			get
			{
				return this.OwningCellsPanel.Row as global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000297C File Offset: 0x00000B7C
		internal void RaiseCanSelectMultiplePropertyChangedEvent(bool oldValue, bool newValue)
		{
			if (oldValue != newValue && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionPatternIdentifiers.CanSelectMultipleProperty, oldValue, newValue);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000029A4 File Offset: 0x00000BA4
		internal void RaiseExpandCollapseStatePropertyChangedEvent(bool oldValue, bool newValue)
		{
			if (oldValue != newValue && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged) && this.ExpandableRow != null)
			{
				global::System.Windows.Automation.ExpandCollapseState expandCollapseState = global::System.Windows.Automation.ExpandCollapseState.Collapsed;
				if (oldValue)
				{
					expandCollapseState = global::System.Windows.Automation.ExpandCollapseState.Expanded;
				}
				global::System.Windows.Automation.ExpandCollapseState expandCollapseState2 = global::System.Windows.Automation.ExpandCollapseState.Collapsed;
				if (newValue)
				{
					expandCollapseState2 = global::System.Windows.Automation.ExpandCollapseState.Expanded;
				}
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, expandCollapseState, expandCollapseState2);
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000029EB File Offset: 0x00000BEB
		internal void RaiseIsSelectedPropertyChanged(bool isSelected)
		{
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, !isSelected, isSelected);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A10 File Offset: 0x00000C10
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Pane;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002A14 File Offset: 0x00000C14
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = this.OwningCellsPanel.VisibleCells;
			if (visibleCells.Count <= 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(visibleCells.Count);
			for (int i = 0; i < visibleCells.Count; i++)
			{
				global::System.Windows.UIElement control = visibleCells[i].Control;
				if (control != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(control) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(control);
					if (automationPeer != null)
					{
						list.Add(automationPeer);
					}
				}
			}
			return list;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002A84 File Offset: 0x00000C84
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002A98 File Offset: 0x00000C98
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore) && this.OwningCellsPanel.Row != null)
			{
				return this.OwningCellsPanel.Row.Index.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			}
			return nameCore;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002AE0 File Offset: 0x00000CE0
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse && this.ExpandableRow != null && this.ExpandableRow.HasChildren)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002B14 File Offset: 0x00000D14
		private void ExpandableRow_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			string a;
			if ((a = propertyName) != null)
			{
				if (!(a == "IsExpanded"))
				{
					return;
				}
				this.RaiseExpandCollapseStatePropertyChangedEvent(!this.ExpandableRow.IsExpanded, this.ExpandableRow.IsExpanded);
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002B5C File Offset: 0x00000D5C
		private void Row_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.Row == null)
			{
				return;
			}
			string propertyName = e.PropertyName;
			string a;
			if ((a = propertyName) != null)
			{
				if (!(a == "IsSelected"))
				{
					return;
				}
				this.RaiseIsSelectedPropertyChanged(this.Row.IsSelected);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002BA0 File Offset: 0x00000DA0
		private void SelectionSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			string a;
			if ((a = propertyName) != null)
			{
				if (!(a == "CellSelection"))
				{
					return;
				}
				this.RaiseCanSelectMultiplePropertyChangedEvent(this.OldCanSelectMultiple, this.CanSelectMultiple);
				this.OldCanSelectMultiple = this.CanSelectMultiple;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002BE5 File Offset: 0x00000DE5
		public bool CanSelectMultiple
		{
			get
			{
				return this.OwningCellsPanel.Owner != null && this.OwningCellsPanel.Owner.Grid.SelectionSettings.CellSelection == global::Infragistics.Controls.Grids.SelectionType.Multiple;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002C14 File Offset: 0x00000E14
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetSelection()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
			if (this.OwningCellsPanel.VisibleCells.Count > 0)
			{
				for (int i = 0; i < this.OwningCellsPanel.VisibleCells.Count; i++)
				{
					global::Infragistics.Controls.Grids.Primitives.CellControlBase control = this.OwningCellsPanel.VisibleCells[i].Control;
					if (control.Cell.IsSelected)
					{
						global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(control) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(control);
						list.Add(base.ProviderFromPeer(peer));
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002C9D File Offset: 0x00000E9D
		public bool IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002CA0 File Offset: 0x00000EA0
		public void AddToSelection()
		{
			if (this.OwningCellsPanel == null)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Infragistics.Controls.Grids.Row row = this.OwningCellsPanel.Row as global::Infragistics.Controls.Grids.Row;
			if (row == null)
			{
				throw new global::System.InvalidOperationException();
			}
			if (this.Grid.SelectionSettings.RowSelection == global::Infragistics.Controls.Grids.SelectionType.Single)
			{
				this.Grid.SelectionSettings.SelectedRows.Clear();
			}
			if (this.Grid.SelectionSettings.RowSelection != global::Infragistics.Controls.Grids.SelectionType.None)
			{
				this.Grid.SelectionSettings.SelectedRows.Add(row);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002D28 File Offset: 0x00000F28
		public bool IsSelected
		{
			get
			{
				global::Infragistics.Controls.Grids.Row row = this.OwningCellsPanel.Row as global::Infragistics.Controls.Grids.Row;
				return row != null && row.IsSelected;
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002D54 File Offset: 0x00000F54
		public void RemoveFromSelection()
		{
			if (this.OwningCellsPanel == null)
			{
				throw new global::System.InvalidOperationException();
			}
			global::Infragistics.Controls.Grids.Row row = this.OwningCellsPanel.Row as global::Infragistics.Controls.Grids.Row;
			if (row == null)
			{
				throw new global::System.InvalidOperationException();
			}
			row.IsSelected = false;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002D90 File Offset: 0x00000F90
		public void Select()
		{
			global::Infragistics.Controls.Grids.Row row = this.OwningCellsPanel.Row as global::Infragistics.Controls.Grids.Row;
			if (row == null)
			{
				throw new global::System.InvalidOperationException();
			}
			row.IsSelected = true;
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002DC0 File Offset: 0x00000FC0
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple SelectionContainer
		{
			get
			{
				if (this.Grid != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this.Grid) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this.Grid);
					return base.ProviderFromPeer(peer);
				}
				return base.ProviderFromPeer(this);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002DFF File Offset: 0x00000FFF
		public void Collapse()
		{
			this.ExpandableRow.IsExpanded = false;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002E0D File Offset: 0x0000100D
		public void Expand()
		{
			this.ExpandableRow.IsExpanded = true;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002E1B File Offset: 0x0000101B
		public global::System.Windows.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				if (this.ExpandableRow != null && this.ExpandableRow.IsExpanded)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Expanded;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
			}
		}
	}
}
