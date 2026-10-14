using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000029 RID: 41
	public class RecordAutomationPeer : global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider, global::System.Windows.Automation.Provider.IScrollItemProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x06000160 RID: 352 RVA: 0x0000642E File Offset: 0x0000462E
		public RecordAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer) : base(record, listAutomationPeer)
		{
			this._record = record;
			this._recordListAutomationPeer = recordListAutomationPeer;
			record.InitializeAutomationPeer(this);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006454 File Offset: 0x00004654
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			global::Infragistics.Windows.DataPresenter.RecordType recordType = this._record.RecordType;
			if (recordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord || recordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.DataItem;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.ListItem;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000647C File Offset: 0x0000467C
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			if (this._childRecordsPeer == null)
			{
				return base.GetBoundingRectangleCore();
			}
			global::System.Windows.Rect boundingRectangleCore = base.GetBoundingRectangleCore();
			global::System.Windows.Rect boundingRectangle = this._childRecordsPeer.GetBoundingRectangle();
			if (boundingRectangleCore.Equals(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.EmptyRect))
			{
				return boundingRectangle;
			}
			if (boundingRectangle.Equals(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup.EmptyRect))
			{
				return boundingRectangleCore;
			}
			return global::System.Windows.Rect.Union(boundingRectangleCore, boundingRectangle);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000064F4 File Offset: 0x000046F4
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.AutomationPeers.AutomationPeerHelper.RemovePendingChildrenInvalidation(this);
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = base.GetChildrenCore();
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && !(dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord))
			{
				if (list != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = dataRecord.AssociatedRecordPresenter;
					if (associatedRecordPresenter != null)
					{
						global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer frameworkElementAutomationPeer = this.GetUnderlyingPeer() as global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer;
						if (frameworkElementAutomationPeer == null || !(frameworkElementAutomationPeer.Owner is global::Infragistics.Windows.DataPresenter.RecordPresenter))
						{
							global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordPresenterAutomationPeer recordPresenterAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(associatedRecordPresenter) as global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordPresenterAutomationPeer;
							if (recordPresenterAutomationPeer != null)
							{
								global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> actualChildren = recordPresenterAutomationPeer.GetActualChildren();
								if (actualChildren != null)
								{
									list.AddRange(actualChildren);
								}
							}
						}
					}
					list.RemoveAll((global::System.Windows.Automation.Peers.AutomationPeer peer) => peer is global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer && ((global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer)peer).Owner is global::Infragistics.Windows.DataPresenter.CellValuePresenter);
				}
				else
				{
					list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
				}
				this.VerifyCellPeers(false);
				global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer> cellPeers = this.CellPeers;
				foreach (global::Infragistics.Windows.DataPresenter.Cell key in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>)dataRecord.Cells))
				{
					global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer item;
					if (cellPeers.TryGetValue(key, out item))
					{
						list.Add(item);
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.Record record = this._record;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
			bool flag = dataPresenter != null && dataPresenter.IsFlatView && record.HasChildren;
			if (flag)
			{
				if (this._childRecordsPeer == null)
				{
					global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer = this._recordListAutomationPeer as global::Infragistics.Windows.Automation.Peers.IListAutomationPeer;
					if (listAutomationPeer != null && listAutomationPeer.Owner is global::Infragistics.Windows.DataPresenter.RecordListControl)
					{
						this._childRecordsPeer = new global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer(listAutomationPeer.Owner as global::Infragistics.Windows.DataPresenter.RecordListControl, record.ChildRecordsInternal.ViewableRecords, false);
					}
				}
				if (this._childRecordsPeer != null)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
					}
					list.Add(this._childRecordsPeer);
				}
			}
			else
			{
				this._childRecordsPeer = null;
			}
			return list;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000066AC File Offset: 0x000048AC
		protected override string GetClassNameCore()
		{
			return "Record";
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000066B4 File Offset: 0x000048B4
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text))
			{
				switch (this._record.RecordType)
				{
				case global::Infragistics.Windows.DataPresenter.RecordType.DataRecord:
				{
					object dataItem = ((global::Infragistics.Windows.DataPresenter.DataRecord)this._record).DataItem;
					if (dataItem != null)
					{
						text = dataItem.ToString();
					}
					break;
				}
				case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
				case global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout:
					if (this._record is global::Infragistics.Windows.DataPresenter.GroupByRecord)
					{
						text = ((global::Infragistics.Windows.DataPresenter.GroupByRecord)this._record).Description;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord:
					if (this._record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)
					{
						text = ((global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)this._record).Field.Name;
					}
					break;
				}
			}
			return text;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00006764 File Offset: 0x00004964
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ScrollItem)
			{
				return this;
			}
			if (patternInterface != global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return null;
			}
			if (this._record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)
			{
				return null;
			}
			return this;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000678C File Offset: 0x0000498C
		protected override bool IsOffscreenCore()
		{
			return this.GetBoundingRectangleCore().Equals(default(global::System.Windows.Rect));
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000168 RID: 360 RVA: 0x000067B0 File Offset: 0x000049B0
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer> CellPeers
		{
			get
			{
				if (this._cellPeers == null)
				{
					this._cellPeers = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer>();
				}
				return this._cellPeers;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000169 RID: 361 RVA: 0x000067CB File Offset: 0x000049CB
		internal global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000067D3 File Offset: 0x000049D3
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer RecordListAutomationPeer
		{
			get
			{
				return this._recordListAutomationPeer;
			}
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000067DB File Offset: 0x000049DB
		internal void ClearChildRecordsPeer()
		{
			this._childRecordsPeer = null;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000067E4 File Offset: 0x000049E4
		internal virtual global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer CreateCellAutomationPeer(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer(cell, this.RecordListAutomationPeer);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000067F4 File Offset: 0x000049F4
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer GetCellPeer(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this.VerifyCellPeers(true);
			global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer result;
			if (this.CellPeers.TryGetValue(cell, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000681C File Offset: 0x00004A1C
		private void VerifyCellPeers(bool forceGetChildrenAfterCellPeerAddition)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord.Cells != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._record.FieldLayout;
				int version = fieldLayout.Fields.Version;
				if (this._fieldCollectionVersion != version)
				{
					this._fieldCollectionVersion = version;
					global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer> cellPeers = this._cellPeers;
					this._cellPeers = null;
					global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer> cellPeers2 = this.CellPeers;
					bool flag = false;
					foreach (global::Infragistics.Windows.DataPresenter.Cell cell in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Cell>)dataRecord.Cells))
					{
						if (cell.Field.IsVisibleInCellArea)
						{
							global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer value;
							if (cellPeers == null || !cellPeers.TryGetValue(cell, out value))
							{
								flag = true;
								value = this.CreateCellAutomationPeer(cell);
							}
							cellPeers2.Add(cell, value);
						}
					}
					bool flag2 = flag || (cellPeers != null && cellPeers.Count != cellPeers2.Count);
					if (forceGetChildrenAfterCellPeerAddition && flag2)
					{
						base.ResetChildrenCache();
					}
				}
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000692C File Offset: 0x00004B2C
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState == global::System.Windows.Automation.ExpandCollapseState.LeafNode)
			{
				throw new global::System.InvalidOperationException();
			}
			this._record.IsExpanded = false;
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00006957 File Offset: 0x00004B57
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState == global::System.Windows.Automation.ExpandCollapseState.LeafNode)
			{
				throw new global::System.InvalidOperationException();
			}
			this._record.IsExpanded = true;
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00006982 File Offset: 0x00004B82
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (!this._record.HasVisibleChildren)
				{
					return global::System.Windows.Automation.ExpandCollapseState.LeafNode;
				}
				if (this._record.IsExpanded)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Expanded;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x000069A4 File Offset: 0x00004BA4
		void global::System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView()
		{
			global::Infragistics.Windows.DataPresenter.Record parentRecord = this._record.ParentRecord;
			if (parentRecord != null)
			{
				parentRecord.IsExpanded = true;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._record.DataPresenter;
			global::Infragistics.Windows.DataPresenter.IViewPanel viewPanel = (dataPresenter != null) ? (dataPresenter.CurrentPanel as global::Infragistics.Windows.DataPresenter.IViewPanel) : null;
			if (!viewPanel.EnsureRecordIsVisible(this._record))
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_3", new object[]
				{
					this._record.GetType().Name
				}));
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00006A28 File Offset: 0x00004C28
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::System.Windows.Automation.Provider.ISelectionProvider selectionProvider = base.ListAutomationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Selection) as global::System.Windows.Automation.Provider.ISelectionProvider;
			if (selectionProvider != null && !selectionProvider.CanSelectMultiple && selectionProvider.GetSelection() != null)
			{
				throw new global::System.InvalidOperationException();
			}
			this._record.IsSelected = true;
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00006A7A File Offset: 0x00004C7A
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this._record.IsSelected;
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00006A87 File Offset: 0x00004C87
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._record.IsSelected = false;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00006AA4 File Offset: 0x00004CA4
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._record.DataPresenter;
			if (dataPresenter != null)
			{
				dataPresenter.InternalSelectItem(this._record, true, true);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00006ADD File Offset: 0x00004CDD
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				return base.ProviderFromPeer(base.ListAutomationPeer as global::System.Windows.Automation.Peers.AutomationPeer);
			}
		}

		// Token: 0x04000055 RID: 85
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000056 RID: 86
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x04000057 RID: 87
		private int _fieldCollectionVersion = -1;

		// Token: 0x04000058 RID: 88
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer> _cellPeers;

		// Token: 0x04000059 RID: 89
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer _childRecordsPeer;
	}
}
