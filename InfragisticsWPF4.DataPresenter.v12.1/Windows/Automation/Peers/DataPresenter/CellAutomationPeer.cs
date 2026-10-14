using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000011 RID: 17
	public class CellAutomationPeer : global::Infragistics.AutomationPeers.AutomationPeerProxy, global::System.Windows.Automation.Provider.ITableItemProvider, global::System.Windows.Automation.Provider.IGridItemProvider, global::System.Windows.Automation.Provider.IValueProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider, global::System.Windows.Automation.Provider.IScrollItemProvider
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00003722 File Offset: 0x00001922
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

		// Token: 0x06000069 RID: 105 RVA: 0x00003754 File Offset: 0x00001954
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003758 File Offset: 0x00001958
		protected override string GetClassNameCore()
		{
			return "Cell";
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000375F File Offset: 0x0000195F
		protected override string GetLocalizedControlTypeCore()
		{
			return "cell";
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003768 File Offset: 0x00001968
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				text = ((global::System.Windows.Automation.Provider.IValueProvider)this).Value;
			}
			return text;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000378C File Offset: 0x0000198C
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

		// Token: 0x0600006E RID: 110 RVA: 0x000037B0 File Offset: 0x000019B0
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = null;
			global::System.Windows.UIElement associatedCellValuePresenter = this._cell.AssociatedCellValuePresenter;
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

		// Token: 0x0600006F RID: 111 RVA: 0x00003800 File Offset: 0x00001A00
		protected override bool IsEnabledCore()
		{
			if (this._cell.Record == null || !this._cell.Record.IsEnabledResolved)
			{
				return false;
			}
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsEnabled();
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003840 File Offset: 0x00001A40
		protected override void SetFocusCore()
		{
			((global::System.Windows.Automation.Provider.IScrollItemProvider)this).ScrollIntoView();
			base.SetFocusCore();
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00003850 File Offset: 0x00001A50
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

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000038B4 File Offset: 0x00001AB4
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

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003904 File Offset: 0x00001B04
		internal bool IsHorizontalRowLayout
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer listControlPeer = this.ListControlPeer;
				return listControlPeer != null && listControlPeer.IsHorizontalRowLayout;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003923 File Offset: 0x00001B23
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer ListControlPeer
		{
			get
			{
				return this._recordListAutomationPeer;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000075 RID: 117 RVA: 0x0000392C File Offset: 0x00001B2C
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

		// Token: 0x06000076 RID: 118 RVA: 0x00003954 File Offset: 0x00001B54
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

		// Token: 0x06000077 RID: 119 RVA: 0x000039D4 File Offset: 0x00001BD4
		internal void RaiseValuePropertyChangedEvent(object oldValue, object newValue)
		{
			string valueAsText = this.GetValueAsText(oldValue);
			string valueAsText2 = this.GetValueAsText(newValue);
			if (valueAsText != valueAsText2)
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.ValueProperty, valueAsText, valueAsText2);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00003A07 File Offset: 0x00001C07
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableItemProvider.GetColumnHeaderItems()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return this.HeaderItems;
			}
			return null;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00003A19 File Offset: 0x00001C19
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableItemProvider.GetRowHeaderItems()
		{
			if (!this.IsHorizontalRowLayout)
			{
				return null;
			}
			return this.HeaderItems;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003A2B File Offset: 0x00001C2B
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
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003A42 File Offset: 0x00001C42
		int global::System.Windows.Automation.Provider.IGridItemProvider.ColumnSpan
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003A48 File Offset: 0x00001C48
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
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003A73 File Offset: 0x00001C73
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
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00003A8A File Offset: 0x00001C8A
		int global::System.Windows.Automation.Provider.IGridItemProvider.RowSpan
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00003A8D File Offset: 0x00001C8D
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return !this._cell.IsEditingAllowed;
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00003AA0 File Offset: 0x00001CA0
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
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00003B5C File Offset: 0x00001D5C
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				object value = this._cell.Value;
				return this.GetValueAsText(value);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003B7C File Offset: 0x00001D7C
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

		// Token: 0x06000083 RID: 131 RVA: 0x00003C18 File Offset: 0x00001E18
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
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00003C77 File Offset: 0x00001E77
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this._cell.IsSelected;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003C84 File Offset: 0x00001E84
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._cell.IsSelected = false;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00003CA0 File Offset: 0x00001EA0
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
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003CDC File Offset: 0x00001EDC
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

		// Token: 0x04000026 RID: 38
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x04000027 RID: 39
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;
	}
}
