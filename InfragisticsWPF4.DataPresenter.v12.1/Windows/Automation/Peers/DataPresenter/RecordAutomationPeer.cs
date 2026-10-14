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
		// Token: 0x06000151 RID: 337 RVA: 0x0000627E File Offset: 0x0000447E
		public RecordAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer) : base(record, listAutomationPeer)
		{
			this._record = record;
			this._recordListAutomationPeer = recordListAutomationPeer;
			record.InitializeAutomationPeer(this);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000062A4 File Offset: 0x000044A4
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			global::Infragistics.Windows.DataPresenter.RecordType recordType = this._record.RecordType;
			if (recordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord || recordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.DataItem;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.ListItem;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000062CC File Offset: 0x000044CC
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

		// Token: 0x06000154 RID: 340 RVA: 0x00006344 File Offset: 0x00004544
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

		// Token: 0x06000155 RID: 341 RVA: 0x000064FC File Offset: 0x000046FC
		protected override string GetClassNameCore()
		{
			return "Record";
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006504 File Offset: 0x00004704
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

		// Token: 0x06000157 RID: 343 RVA: 0x000065B4 File Offset: 0x000047B4
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

		// Token: 0x06000158 RID: 344 RVA: 0x000065DC File Offset: 0x000047DC
		protected override bool IsOffscreenCore()
		{
			return this.GetBoundingRectangleCore().Equals(default(global::System.Windows.Rect));
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00006600 File Offset: 0x00004800
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

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000661B File Offset: 0x0000481B
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer RecordListAutomationPeer
		{
			get
			{
				return this._recordListAutomationPeer;
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00006623 File Offset: 0x00004823
		internal void ClearChildRecordsPeer()
		{
			this._childRecordsPeer = null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000662C File Offset: 0x0000482C
		internal virtual global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer CreateCellAutomationPeer(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer(cell, this.RecordListAutomationPeer);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000663C File Offset: 0x0000483C
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

		// Token: 0x0600015E RID: 350 RVA: 0x00006664 File Offset: 0x00004864
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

		// Token: 0x0600015F RID: 351 RVA: 0x00006774 File Offset: 0x00004974
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

		// Token: 0x06000160 RID: 352 RVA: 0x0000679F File Offset: 0x0000499F
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

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000161 RID: 353 RVA: 0x000067CA File Offset: 0x000049CA
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

		// Token: 0x06000162 RID: 354 RVA: 0x000067EC File Offset: 0x000049EC
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

		// Token: 0x06000163 RID: 355 RVA: 0x00006870 File Offset: 0x00004A70
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

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000164 RID: 356 RVA: 0x000068C2 File Offset: 0x00004AC2
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this._record.IsSelected;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000068CF File Offset: 0x00004ACF
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this._record.IsSelected = false;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000068EC File Offset: 0x00004AEC
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

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00006925 File Offset: 0x00004B25
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				return base.ProviderFromPeer(base.ListAutomationPeer as global::System.Windows.Automation.Peers.AutomationPeer);
			}
		}

		// Token: 0x04000046 RID: 70
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000047 RID: 71
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x04000048 RID: 72
		private int _fieldCollectionVersion = -1;

		// Token: 0x04000049 RID: 73
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Cell, global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer> _cellPeers;

		// Token: 0x0400004A RID: 74
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.ViewableRecordCollectionAutomationPeer _childRecordsPeer;
	}
}
