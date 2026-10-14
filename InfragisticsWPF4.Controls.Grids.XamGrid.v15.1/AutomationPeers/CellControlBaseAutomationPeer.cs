using System;
using System.ComponentModel;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Grids;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000005 RID: 5
	public class CellControlBaseAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00002602 File Offset: 0x00000802
		public CellControlBaseAutomationPeer(global::Infragistics.Controls.Grids.Primitives.CellControlBase owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			if (this.OwningCell != null)
			{
				this.OwningCell.PropertyChanged += this.OwningCell_PropertyChanged;
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002638 File Offset: 0x00000838
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.DataItem;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000263C File Offset: 0x0000083C
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002650 File Offset: 0x00000850
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text) && this.OwningCellControl.Cell != null)
			{
				text = this.OwningCellControl.Cell.Column.HeaderText;
			}
			if (string.IsNullOrEmpty(text) && this.OwningCellControl.Cell != null)
			{
				text = this.OwningCellControl.Cell.Column.Key;
			}
			return text;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000026BB File Offset: 0x000008BB
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000026D1 File Offset: 0x000008D1
		private global::Infragistics.Controls.Grids.XamGrid Grid
		{
			get
			{
				if (this.Panel != null)
				{
					return this.Panel.Row.ColumnLayout.Grid;
				}
				return null;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000026F2 File Offset: 0x000008F2
		private global::Infragistics.Controls.Grids.Cell OwningCell
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.Primitives.CellControlBase)base.Owner).Cell as global::Infragistics.Controls.Grids.Cell;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002709 File Offset: 0x00000909
		private global::Infragistics.Controls.Grids.Primitives.CellControlBase OwningCellControl
		{
			get
			{
				return (global::Infragistics.Controls.Grids.Primitives.CellControlBase)base.Owner;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002716 File Offset: 0x00000916
		private global::Infragistics.Controls.Grids.Primitives.CellsPanel Panel
		{
			get
			{
				return this.OwningCellControl.Parent as global::Infragistics.Controls.Grids.Primitives.CellsPanel;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002728 File Offset: 0x00000928
		internal void RaiseIsSelectedPropertyChanged(bool isSelected)
		{
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, !isSelected, isSelected);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000274D File Offset: 0x0000094D
		private void OwningCell_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.RaiseIsSelectedPropertyChanged(this.IsSelected);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000275B File Offset: 0x0000095B
		public void SetValue(string value)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0000275D File Offset: 0x0000095D
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002760 File Offset: 0x00000960
		public string Value
		{
			get
			{
				if (this.OwningCellControl.Cell != null && this.OwningCellControl.Cell.Value != null)
				{
					return this.OwningCellControl.Cell.Value.ToString();
				}
				return string.Empty;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000279C File Offset: 0x0000099C
		public void AddToSelection()
		{
			if (this.OwningCellControl.Cell != null)
			{
				this.Grid.SelectionSettings.SelectedCells.Add((global::Infragistics.Controls.Grids.Cell)this.OwningCellControl.Cell);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000027D0 File Offset: 0x000009D0
		public void RemoveFromSelection()
		{
			if (this.OwningCellControl.Cell != null)
			{
				this.Grid.SelectionSettings.SelectedCells.Remove((global::Infragistics.Controls.Grids.Cell)this.OwningCellControl.Cell);
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002805 File Offset: 0x00000A05
		public void Select()
		{
			if (this.OwningCellControl.Cell != null)
			{
				this.OwningCellControl.Cell.IsSelected = true;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002825 File Offset: 0x00000A25
		public bool IsSelected
		{
			get
			{
				return this.OwningCellControl.Cell != null && this.OwningCellControl.Cell.IsSelected;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00002848 File Offset: 0x00000A48
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple SelectionContainer
		{
			get
			{
				if (this.Panel != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this.Panel) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this.Panel);
					return base.ProviderFromPeer(peer);
				}
				return null;
			}
		}
	}
}
