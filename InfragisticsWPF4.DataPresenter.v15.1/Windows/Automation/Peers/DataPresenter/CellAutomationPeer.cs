using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000010 RID: 16
	public class CellAutomationPeer : global::Infragistics.AutomationPeers.AutomationPeerProxy, global::System.Windows.Automation.Provider.ITableItemProvider, global::System.Windows.Automation.Provider.IGridItemProvider, global::System.Windows.Automation.Provider.IValueProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider, global::System.Windows.Automation.Provider.IScrollItemProvider
	{
		// Token: 0x06000067 RID: 103 RVA: 0x0000325E File Offset: 0x0000145E
		public CellAutomationPeer(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer)
		{
			if (cell == null)
			{
				throw new global::System.ArgumentNullException("cell");
			}
			this._cell = cell;
			if (recordListAutomationPeer == null)
			{
				throw new global::System.ArgumentNullException("recordListAutomationPeer");
			}
			this._recordListAutomationPeer = recordListAutomationPeer;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003290 File Offset: 0x00001490
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003294 File Offset: 0x00001494
		protected override string GetClassNameCore()
		{
			return "Cell";
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000329B File Offset: 0x0000149B
		protected override string GetLocalizedControlTypeCore()
		{
			return "cell";
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000032A4 File Offset: 0x000014A4
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				if (global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer._NameSource == global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeerNameSource.DataItemAndFieldIndex)
				{
					text = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("CellAutomationPeerName", new object[]
					{
						this._cell.Record.DataItem,
						this._cell.Field.Index
					});
				}
				else
				{
					text = ((global::System.Windows.Automation.Provider.IValueProvider)this).Value;
				}
			}
			return text;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003310 File Offset: 0x00001510
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.TableItem)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.GridItem || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ScrollItem || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003334 File Offset: 0x00001534
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = null;
			global::System.Windows.UIElement associatedCellValuePresenter = this._cell.GetAssociatedCellValuePresenter(false);
			if (associatedCellValuePresenter != null)
			{
				automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(associatedCellValuePresenter);
				if (automationPeer == null)
				{
					if (associatedCellValuePresenter is global::System.Windows.FrameworkElement)
					{
						automationPeer = new global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer((global::System.Windows.FrameworkElement)associatedCellValuePresenter);
					}
					else
					{
						automationPeer = new global::System.Windows.Automation.Peers.UIElementAutomationPeer(associatedCellValuePresenter);
					}
				}
			}
			if (automationPeer != null)
			{
				automationPeer.EventsSource = this;
			}
			return automationPeer;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003388 File Offset: 0x00001588
		protected override bool IsEnabledCore()
		{
			if (this._cell.Record == null || !this._cell.Record.IsEnabledResolved)
			{
				return false;
			}
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsEnabled();
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000033C8 File Offset: 0x000015C8
		protected override void SetFocusCore()
		{
			((global::System.Windows.Automation.Provider.IScrollItemProvider)this).ScrollIntoView();
			base.SetFocusCore();
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000033D8 File Offset: 0x000015D8
		private int FieldIndex
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer recordAutomationPeer = (this._cell.Record != null) ? this._cell.Record.AutomationPeer : null;
				global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerAutomationPeer = (recordAutomationPeer != null) ? recordAutomationPeer.RecordListAutomationPeer.GetHeaderPeer(this._cell.Record) : null;
				if (headerAutomationPeer == null)
				{
					return -1;
				}
				return headerAutomationPeer.GetFieldIndex(this._cell.Field);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000343C File Offset: 0x0000163C
		private global::System.Windows.Automation.Provider.IRawElementProviderSimple[] HeaderItems
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer listControlPeer = this.ListControlPeer;
				if (listControlPeer != null)
				{
					global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer = listControlPeer.GetHeaderPeer(this._cell.Record);
					if (headerPeer != null)
					{
						global::Infragistics.Windows.Automation.Peers.DataPresenter.LabelAutomationPeer headerItem = headerPeer.GetHeaderItem(this._cell);
						if (headerItem != null)
						{
							return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[]
							{
								base.ProviderFromPeer(headerItem)
							};
						}
					}
				}
				return null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000072 RID: 114 RVA: 0x0000348C File Offset: 0x0000168C
		internal bool IsHorizontalRowLayout
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer listControlPeer = this.ListControlPeer;
				return listControlPeer != null && listControlPeer.IsHorizontalRowLayout;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000034AB File Offset: 0x000016AB
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer ListControlPeer
		{
			get
			{
				return this._recordListAutomationPeer;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000034B3 File Offset: 0x000016B3
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000034BA File Offset: 0x000016BA
		public static global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeerNameSource NameSource
		{
			get
			{
				return global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer._NameSource;
			}
			set
			{
				if (value != global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer._NameSource)
				{
					global::Infragistics.CoreUtilities.ValidateEnum(typeof(global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeerNameSource), value);
					global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer._NameSource = value;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000034E0 File Offset: 0x000016E0
		private int RecordIndex
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer listControlPeer = this.ListControlPeer;
				if (listControlPeer == null)
				{
					return 0;
				}
				return listControlPeer.GetTableRowIndex(this._cell);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00003508 File Offset: 0x00001708
		private string GetValueAsText(object value)
		{
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this._cell.AssociatedCellValuePresenter;
			string result;
			bool flag;
			if (associatedCellValuePresenter != null && associatedCellValuePresenter.Editor != null)
			{
				global::System.Exception ex;
				flag = associatedCellValuePresenter.Editor.ConvertValueToText(value, out result, out ex);
			}
			else
			{
				try
				{
					global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(this._cell.Field);
					result = cachedConverter.ConvertCellValue(value);
					flag = true;
				}
				catch (global::System.Exception ex2)
				{
					result = string.Empty;
					global::System.Exception ex = ex2;
					flag = false;
				}
			}
			if (!flag)
			{
				return string.Empty;
			}
			return result;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003588 File Offset: 0x00001788
		internal void RaiseValuePropertyChangedEvent(object oldValue, object newValue)
		{
			string valueAsText = this.GetValueAsText(oldValue);
			string valueAsText2 = this.GetValueAsText(newValue);
			if (valueAsText != valueAsText2)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.ValueProperty, valueAsText, valueAsText2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000035BB File Offset: 0x000017BB
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableItemProvider.GetColumnHeaderItems()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return this.HeaderItems;
			}
			return null;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000035CD File Offset: 0x000017CD
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableItemProvider.GetRowHeaderItems()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return null;
			}
			return this.HeaderItems;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000035DF File Offset: 0x000017DF
		int global::System.Windows.Automation.Provider.IGridItemProvider.Column
		{
			get
			{
				if (!this.IsHorizontalRowLayout)
				{
					return this.FieldIndex;
				}
				return this.RecordIndex;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007C RID: 124 RVA: 0x000035F6 File Offset: 0x000017F6
		int global::System.Windows.Automation.Provider.IGridItemProvider.ColumnSpan
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007D RID: 125 RVA: 0x000035FC File Offset: 0x000017FC
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridItemProvider.ContainingGrid
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer listControlPeer = this.ListControlPeer;
				if (listControlPeer == null)
				{
					return null;
				}
				return base.ProviderFromPeer(listControlPeer.GetContainingGrid(this._cell));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003627 File Offset: 0x00001827
		int global::System.Windows.Automation.Provider.IGridItemProvider.Row
		{
			get
			{
				if (!this.IsHorizontalRowLayout)
				{
					return this.RecordIndex;
				}
				return this.FieldIndex;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000363E File Offset: 0x0000183E
		int global::System.Windows.Automation.Provider.IGridItemProvider.RowSpan
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00003641 File Offset: 0x00001841
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return !this._cell.IsEditingAllowed;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00003654 File Offset: 0x00001854
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._cell.IsActive = true;
			if (!this._cell.IsActive)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_1"));
			}
			((global::System.Windows.Automation.Provider.IScrollItemProvider)this).ScrollIntoView();
			global::Infragistics.Windows.DataPresenter.CellValuePresenter associatedCellValuePresenter = this._cell.AssociatedCellValuePresenter;
			if (associatedCellValuePresenter == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_2"));
			}
			if (!associatedCellValuePresenter.StartEditMode())
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_2"));
			}
			try
			{
				associatedCellValuePresenter.Editor.Text = value;
			}
			catch (global::System.Exception ex)
			{
				if (ex is global::System.ArgumentException)
				{
					throw;
				}
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_1"), ex);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003710 File Offset: 0x00001910
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				object value = this._cell.Value;
				return this.GetValueAsText(value);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003730 File Offset: 0x00001930
		void global::System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView()
		{
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.Record record = this._cell.Record;
			if (record != null)
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = record.ParentRecord;
				if (parentRecord != null)
				{
					parentRecord.IsExpanded = true;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
				global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = (dataPresenter != null) ? (dataPresenter.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel) : null;
				flag = viewPanel.EnsureRecordIsVisible(record);
				if (flag)
				{
					dataPresenter.UpdateLayout();
					dataPresenter.BringCellIntoView(this._cell);
					flag = true;
				}
			}
			if (!flag)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_3", new object[]
				{
					this._cell.GetType().Name
				}));
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000037CC File Offset: 0x000019CC
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer = this.ListControlPeer as global::Infragistics.Windows.Automation.Peers.IListAutomationPeer;
			global::System.Windows.Automation.Provider.ISelectionProvider selectionProvider = (listAutomationPeer != null) ? (listAutomationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Selection) as global::System.Windows.Automation.Provider.ISelectionProvider) : null;
			if (selectionProvider != null && !selectionProvider.CanSelectMultiple && selectionProvider.GetSelection() != null)
			{
				throw new global::System.InvalidOperationException();
			}
			this._cell.IsSelected = true;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000085 RID: 133 RVA: 0x0000382B File Offset: 0x00001A2B
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this._cell.IsSelected;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003838 File Offset: 0x00001A38
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._cell.IsSelected = false;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00003854 File Offset: 0x00001A54
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._cell.DataPresenter;
			if (dataPresenter != null)
			{
				dataPresenter.InternalSelectItem(this._cell, true, true);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003890 File Offset: 0x00001A90
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.ListControlPeer as global::System.Windows.Automation.Peers.AutomationPeer;
				if (automationPeer == null)
				{
					return null;
				}
				return base.ProviderFromPeer(automationPeer);
			}
		}

		// Token: 0x0400002A RID: 42
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x0400002B RID: 43
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x0400002C RID: 44
		private static global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeerNameSource _NameSource;
	}
}
