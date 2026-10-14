using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls.Primitives;
using Infragistics.Controls.Grids;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000007 RID: 7
	public class XamGridAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IScrollProvider, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.ITableProvider, global::System.Windows.Automation.Provider.IGridProvider
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00002E35 File Offset: 0x00001035
		public XamGridAutomationPeer(global::Infragistics.Controls.Grids.XamGrid owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			this.OwningGrid.SelectionSettings.PropertyChanged += this.SelectionSettings_PropertyChanged;
			this.OldCanSelectMultiple = this.CanSelectMultiple;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002E74 File Offset: 0x00001074
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002E78 File Offset: 0x00001078
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			if (this.OwningGrid.Panel == null)
			{
				return null;
			}
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.RowBase> visibleRows = this.OwningGrid.Panel.VisibleRows;
			if (visibleRows.Count <= 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(visibleRows.Count);
			for (int i = 0; i < visibleRows.Count; i++)
			{
				global::System.Windows.UIElement control = visibleRows[i].Control;
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

		// Token: 0x06000051 RID: 81 RVA: 0x00002EFC File Offset: 0x000010FC
		protected override string GetClassNameCore()
		{
			return this.OwningGrid.GetType().Name;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002F10 File Offset: 0x00001110
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore))
			{
				return this.OwningGrid.Name;
			}
			return nameCore;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F39 File Offset: 0x00001139
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Scroll)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Grid)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Table)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002F5B File Offset: 0x0000115B
		private double HorizontalMaximum
		{
			get
			{
				return this.HorizontalScrollBar.Maximum;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002F68 File Offset: 0x00001168
		private double HorizontalMinimum
		{
			get
			{
				return this.HorizontalScrollBar.Minimum;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002F78 File Offset: 0x00001178
		private global::System.Windows.Controls.Primitives.ScrollBar HorizontalScrollBar
		{
			get
			{
				global::Infragistics.IProvideScrollInfo owningGrid = this.OwningGrid;
				if (owningGrid != null)
				{
					return owningGrid.HorizontalScrollBar;
				}
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002F97 File Offset: 0x00001197
		private double HorizontalValue
		{
			get
			{
				return this.HorizontalScrollBar.Value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002FA4 File Offset: 0x000011A4
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002FAC File Offset: 0x000011AC
		private bool OldCanSelectMultiple { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002FB5 File Offset: 0x000011B5
		private global::Infragistics.Controls.Grids.XamGrid OwningGrid
		{
			get
			{
				return (global::Infragistics.Controls.Grids.XamGrid)base.Owner;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002FC2 File Offset: 0x000011C2
		private double VerticalMaximum
		{
			get
			{
				return this.VerticalScrollBar.Maximum;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002FCF File Offset: 0x000011CF
		private double VerticalMinimum
		{
			get
			{
				return this.VerticalScrollBar.Minimum;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002FDC File Offset: 0x000011DC
		private global::System.Windows.Controls.Primitives.ScrollBar VerticalScrollBar
		{
			get
			{
				global::Infragistics.IProvideScrollInfo owningGrid = this.OwningGrid;
				if (owningGrid != null)
				{
					return owningGrid.VerticalScrollBar;
				}
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002FFB File Offset: 0x000011FB
		private double VerticalValue
		{
			get
			{
				return this.VerticalScrollBar.Value;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003008 File Offset: 0x00001208
		internal void RaiseCanSelectMultiplePropertyChangedEvent(bool oldValue, bool newValue)
		{
			if (oldValue != newValue && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionPatternIdentifiers.CanSelectMultipleProperty, oldValue, newValue);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003030 File Offset: 0x00001230
		private void SelectionSettings_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			string a;
			if ((a = propertyName) != null)
			{
				if (!(a == "RowSelection"))
				{
					return;
				}
				this.RaiseCanSelectMultiplePropertyChangedEvent(this.OldCanSelectMultiple, this.CanSelectMultiple);
				this.OldCanSelectMultiple = this.CanSelectMultiple;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003078 File Offset: 0x00001278
		public void Scroll(global::System.Windows.Automation.ScrollAmount horizontalAmount, global::System.Windows.Automation.ScrollAmount verticalAmount)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if ((horizontalAmount != global::System.Windows.Automation.ScrollAmount.NoAmount && !this.HorizontallyScrollable) || (verticalAmount != global::System.Windows.Automation.ScrollAmount.NoAmount && !this.VerticallyScrollable))
			{
				throw new global::System.InvalidOperationException("Cannot scroll because the XamGrid is not scrollable.");
			}
			switch (horizontalAmount)
			{
			case global::System.Windows.Automation.ScrollAmount.LargeDecrement:
				this.HorizontalScrollBar.Value -= this.HorizontalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallDecrement:
				this.HorizontalScrollBar.Value -= this.HorizontalScrollBar.SmallChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.LargeIncrement:
				this.HorizontalScrollBar.Value += this.HorizontalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallIncrement:
				this.HorizontalScrollBar.Value += this.HorizontalScrollBar.SmallChange;
				break;
			}
			switch (verticalAmount)
			{
			case global::System.Windows.Automation.ScrollAmount.LargeDecrement:
				this.VerticalScrollBar.Value -= this.VerticalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallDecrement:
				this.VerticalScrollBar.Value -= this.VerticalScrollBar.SmallChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.LargeIncrement:
				this.VerticalScrollBar.Value += this.VerticalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallIncrement:
				this.VerticalScrollBar.Value += this.VerticalScrollBar.SmallChange;
				break;
			}
			this.OwningGrid.RowsManager.InvalidateRows();
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000031F6 File Offset: 0x000013F6
		public bool HorizontallyScrollable
		{
			get
			{
				return this.HorizontalScrollBar != null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003204 File Offset: 0x00001404
		public bool VerticallyScrollable
		{
			get
			{
				return this.VerticalScrollBar != null;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003214 File Offset: 0x00001414
		public void SetScrollPercent(double horizontalPercent, double verticalPercent)
		{
			if ((horizontalPercent != -1.0 && !this.HorizontallyScrollable) || (verticalPercent != -1.0 && !this.VerticallyScrollable))
			{
				throw new global::System.InvalidOperationException("Cannot scroll because the GridViewScrollViewer is not scrollable.");
			}
			if (horizontalPercent != -1.0 && (horizontalPercent < 0.0 || horizontalPercent > 100.0))
			{
				throw new global::System.ArgumentOutOfRangeException("horizontalPercent", "The horizontal perecentage must be between 0.0 and 100.0.");
			}
			if (verticalPercent != -1.0 && (verticalPercent < 0.0 || verticalPercent > 100.0))
			{
				throw new global::System.ArgumentOutOfRangeException("verticalPercent", "The vertical perecentage must be between 0.0 and 100.0.");
			}
			if (horizontalPercent != -1.0 && this.HorizontalScrollBar != null)
			{
				this.HorizontalScrollBar.Value = 0.0;
				this.OwningGrid.RowsManager.InvalidateRows();
				double smallChange = this.HorizontalScrollBar.SmallChange;
				this.HorizontalScrollBar.SmallChange = (this.HorizontalMaximum - this.HorizontalMinimum) * horizontalPercent * 0.01;
				this.Scroll(global::System.Windows.Automation.ScrollAmount.SmallIncrement, global::System.Windows.Automation.ScrollAmount.NoAmount);
				this.HorizontalScrollBar.SmallChange = smallChange;
			}
			if (verticalPercent != -1.0 && this.VerticalScrollBar != null)
			{
				this.VerticalScrollBar.Value = 0.0;
				this.OwningGrid.RowsManager.InvalidateRows();
				double smallChange2 = this.VerticalScrollBar.SmallChange;
				this.VerticalScrollBar.SmallChange = (this.VerticalMaximum - this.VerticalMinimum) * verticalPercent * 0.01;
				this.Scroll(global::System.Windows.Automation.ScrollAmount.NoAmount, global::System.Windows.Automation.ScrollAmount.SmallIncrement);
				this.VerticalScrollBar.SmallChange = smallChange2;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000065 RID: 101 RVA: 0x000033B4 File Offset: 0x000015B4
		public double HorizontalScrollPercent
		{
			get
			{
				if (this.HorizontallyScrollable)
				{
					return (this.HorizontalValue - this.HorizontalMinimum) / (this.HorizontalMaximum - this.HorizontalMinimum) * 100.0;
				}
				return -1.0;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000033ED File Offset: 0x000015ED
		public double HorizontalViewSize
		{
			get
			{
				if (this.HorizontalScrollBar != null)
				{
					return this.HorizontalMaximum - this.HorizontalMinimum;
				}
				return 0.0;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000067 RID: 103 RVA: 0x0000340E File Offset: 0x0000160E
		public double VerticalScrollPercent
		{
			get
			{
				if (this.VerticallyScrollable)
				{
					return (this.VerticalValue - this.VerticalMinimum) / (this.VerticalMaximum - this.VerticalMinimum) * 100.0;
				}
				return -1.0;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00003447 File Offset: 0x00001647
		public double VerticalViewSize
		{
			get
			{
				if (this.VerticalScrollBar != null)
				{
					return this.VerticalMaximum - this.VerticalMinimum;
				}
				return 0.0;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00003468 File Offset: 0x00001668
		public bool CanSelectMultiple
		{
			get
			{
				return this.OwningGrid.SelectionSettings.RowSelection == global::Infragistics.Controls.Grids.SelectionType.Multiple || this.OwningGrid.SelectionSettings.CellSelection == global::Infragistics.Controls.Grids.SelectionType.Multiple;
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003494 File Offset: 0x00001694
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetSelection()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
			if (this.OwningGrid.SelectionSettings.SelectedRows.Count > 0)
			{
				for (int i = 0; i < this.OwningGrid.SelectionSettings.SelectedRows.Count; i++)
				{
					global::System.Windows.UIElement control = this.OwningGrid.SelectionSettings.SelectedRows[i].Control;
					global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(control) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(control);
					list.Add(base.ProviderFromPeer(peer));
				}
			}
			else
			{
				for (int j = 0; j < this.OwningGrid.SelectionSettings.SelectedCells.Count; j++)
				{
					global::System.Windows.UIElement control2 = this.OwningGrid.SelectionSettings.SelectedCells[j].Control;
					global::System.Windows.Automation.Peers.AutomationPeer peer2 = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(control2) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(control2);
					list.Add(base.ProviderFromPeer(peer2));
				}
			}
			return list.ToArray();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00003585 File Offset: 0x00001785
		public bool IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003588 File Offset: 0x00001788
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple GetItem(int row, int column)
		{
			int rowCount = ((global::System.Windows.Automation.Provider.IGridProvider)this).RowCount;
			int columnCount = ((global::System.Windows.Automation.Provider.IGridProvider)this).ColumnCount;
			if (row < 0 || row >= rowCount)
			{
				throw new global::System.ArgumentOutOfRangeException("row");
			}
			if (column < 0 || column >= columnCount)
			{
				throw new global::System.ArgumentOutOfRangeException("column");
			}
			global::System.Windows.UIElement control = this.OwningGrid.Rows[row].Cells[column].Control;
			global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(control) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(control);
			return base.ProviderFromPeer(peer);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003607 File Offset: 0x00001807
		public int ColumnCount
		{
			get
			{
				return this.OwningGrid.Columns.Count;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003619 File Offset: 0x00001819
		public int RowCount
		{
			get
			{
				return this.OwningGrid.Rows.Count;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000362C File Offset: 0x0000182C
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetColumnHeaders()
		{
			if (this.OwningGrid.HeaderVisibility == global::System.Windows.Visibility.Visible)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
				for (int i = 0; i < this.OwningGrid.RowsManager.HeaderRow.VisibleCells.Count; i++)
				{
					global::System.Windows.UIElement control = this.OwningGrid.RowsManager.HeaderRow.VisibleCells[i].Control;
					if (control != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(control) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(control);
						list.Add(base.ProviderFromPeer(peer));
					}
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000036BC File Offset: 0x000018BC
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetRowHeaders()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
			return list.ToArray();
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000036D5 File Offset: 0x000018D5
		public global::System.Windows.Automation.RowOrColumnMajor RowOrColumnMajor
		{
			get
			{
				return global::System.Windows.Automation.RowOrColumnMajor.RowMajor;
			}
		}
	}
}
