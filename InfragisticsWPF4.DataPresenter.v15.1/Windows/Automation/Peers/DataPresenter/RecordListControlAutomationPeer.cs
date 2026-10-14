using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.DataPresenter.Internal;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000028 RID: 40
	public class RecordListControlAutomationPeer : global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider, global::System.Windows.Automation.Provider.ITableProvider, global::System.Windows.Automation.Provider.IGridProvider, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer
	{
		// Token: 0x0600013C RID: 316 RVA: 0x00005F38 File Offset: 0x00004138
		public RecordListControlAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordListControl control) : base(control)
		{
			this._listAutomationPeerHelper = new global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper(this, this);
			this._listAutomationPeerHelper.InitializeFieldLayout();
			global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.AddProxyPeerHost(this, control.DataPresenter);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00005F65 File Offset: 0x00004165
		protected override global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer CreateAutomationPeer(object item)
		{
			if (!(item is global::Infragistics.Windows.DataPresenter.Record))
			{
				throw new global::System.ArgumentException();
			}
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CreateRecordAutomationPeer((global::Infragistics.Windows.DataPresenter.Record)item, this, this);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00005F82 File Offset: 0x00004182
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			if (!this._listAutomationPeerHelper.HasRecordGroups && this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Table) != null)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.List;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005F9F File Offset: 0x0000419F
		protected override string GetClassNameCore()
		{
			return "RecordListControl";
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00005FB0 File Offset: 0x000041B0
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.AutomationPeers.AutomationPeerHelper.RemovePendingChildrenInvalidation(this);
			if (this.ProcessVisualTreeOnly)
			{
				return new global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer(base.Owner as global::Infragistics.Windows.DataPresenter.RecordListControl).GetChildren();
			}
			if (this._listAutomationPeerHelper.HasRecordGroups)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenCoreBase = base.GetChildrenCoreBase(true);
				global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> recordListGroups = this._listAutomationPeerHelper.GetRecordListGroups();
				if (recordListGroups != null)
				{
					global::System.Converter<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup, global::System.Windows.Automation.Peers.AutomationPeer> converter = (global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup group) => group.AutomationPeer;
					global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = recordListGroups.ConvertAll<global::System.Windows.Automation.Peers.AutomationPeer>(converter);
					if (childrenCoreBase != null)
					{
						list.AddRange(childrenCoreBase);
					}
					return list;
				}
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenCore = base.GetChildrenCore();
			if (this._listAutomationPeerHelper.ShouldIncludeHeaderPeer)
			{
				global::System.Windows.Automation.Peers.AutomationPeer headerPeer = this._listAutomationPeerHelper.HeaderPeer;
				if (headerPeer != null)
				{
					childrenCore.Insert(0, headerPeer);
				}
			}
			return childrenCore;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000606C File Offset: 0x0000426C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Scroll)
			{
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
				if (this.IsRootLevel && recordListControl.ScrollInfo != null && recordListControl.ScrollInfo.ScrollOwner != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(recordListControl.ScrollInfo.ScrollOwner);
					if (automationPeer != null && automationPeer is global::System.Windows.Automation.Provider.IScrollProvider)
					{
						automationPeer.EventsSource = this;
						return automationPeer;
					}
				}
				return null;
			}
			if (!this.ProcessVisualTreeOnly)
			{
				if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
				{
					global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl2 = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
					if (recordListControl2.ItemsSource is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection)
					{
						return null;
					}
					return this;
				}
				else if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Grid || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Table)
				{
					if (!this.CouldSupportGridPattern())
					{
						return null;
					}
					if (this._listAutomationPeerHelper.HasRecordGroups)
					{
						return null;
					}
					return this;
				}
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000142 RID: 322 RVA: 0x00006124 File Offset: 0x00004324
		private global::Infragistics.Windows.DataPresenter.RecordManager AssociatedRecordManager
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this.GetRecordCollection();
				if (recordCollection != null && recordCollection.ParentRecordManager != null && recordCollection.ParentRecordManager.ParentRecord == recordCollection.ParentRecord)
				{
					return recordCollection.ParentRecordManager;
				}
				return null;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000143 RID: 323 RVA: 0x00006160 File Offset: 0x00004360
		private bool IsHorizontalRowLayout
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = ((global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner).DataPresenter;
				if (dataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
					return currentViewInternal.HasLogicalOrientation && currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal;
				}
				return false;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000061A0 File Offset: 0x000043A0
		private bool IsRootLevel
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
				return recordListControl != null && recordListControl.DataPresenter != null && recordListControl.DataPresenter.RootRecordListControl == recordListControl;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000061D4 File Offset: 0x000043D4
		private bool ProcessVisualTreeOnly
		{
			get
			{
				return global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ProcessVisualTreeOnly;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000061DC File Offset: 0x000043DC
		private bool CouldSupportGridPattern()
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = null;
			if (recordListControl.ItemsSource is global::Infragistics.Windows.DataPresenter.DataRecordCollection)
			{
				recordCollectionBase = ((global::Infragistics.Windows.DataPresenter.DataRecordCollection)recordListControl.ItemsSource).ViewableRecords.RecordCollection;
			}
			else if (recordListControl.ItemsSource is global::Infragistics.Windows.DataPresenter.ViewableRecordCollection)
			{
				recordCollectionBase = ((global::Infragistics.Windows.DataPresenter.ViewableRecordCollection)recordListControl.ItemsSource).RecordCollection;
			}
			return recordCollectionBase != null && global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CouldSupportGridPattern(recordCollectionBase.RecordsType) && this._listAutomationPeerHelper.IsHomogenousCollection();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00006258 File Offset: 0x00004458
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> GetRecordList()
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
			return recordListControl.ItemsSource as global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000627C File Offset: 0x0000447C
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase GetRecordCollection()
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = recordListControl.ItemsSource as global::Infragistics.Windows.DataPresenter.RecordCollectionBase;
			if (recordCollectionBase == null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = recordListControl.ViewableRecords;
				if (viewableRecords != null)
				{
					recordCollectionBase = viewableRecords.RecordCollection;
				}
			}
			return recordCollectionBase;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000062B6 File Offset: 0x000044B6
		protected internal override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			if (this.ProcessVisualTreeOnly)
			{
				return;
			}
			this._listAutomationPeerHelper.ProcessListChange(e);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000062D4 File Offset: 0x000044D4
		protected internal override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			base.OnItemsSourceChanged(oldValue, newValue);
			this._listAutomationPeerHelper.SetHasRecordGroups(null);
			this._listAutomationPeerHelper.InitializeFieldLayout();
			base.InvalidatePeer();
			global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(this);
			base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000631C File Offset: 0x0000451C
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_CanSelectMultiple;
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006329 File Offset: 0x00004529
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			return this._listAutomationPeerHelper.ISelectionProvider_GetSelection();
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006336 File Offset: 0x00004536
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_IsSelectionRequired;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00006343 File Offset: 0x00004543
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetColumnHeaders();
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006350 File Offset: 0x00004550
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetRowHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetRowHeaders();
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000635D File Offset: 0x0000455D
		global::System.Windows.Automation.RowOrColumnMajor global::System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor
		{
			get
			{
				return this._listAutomationPeerHelper.ITableProvider_RowOrColumnMajor;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000636A File Offset: 0x0000456A
		int global::System.Windows.Automation.Provider.IGridProvider.ColumnCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_ColumnCount;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006377 File Offset: 0x00004577
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column)
		{
			return this._listAutomationPeerHelper.IGridProvider_GetItem(row, column);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000153 RID: 339 RVA: 0x00006386 File Offset: 0x00004586
		int global::System.Windows.Automation.Provider.IGridProvider.RowCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_RowCount;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00006393 File Offset: 0x00004593
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsHorizontalRowLayout
		{
			get
			{
				return this.IsHorizontalRowLayout;
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000639B File Offset: 0x0000459B
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CouldSupportGridPattern()
		{
			return this.CouldSupportGridPattern();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000063A3 File Offset: 0x000045A3
		global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CreateRecordAutomationPeer(record, this, this);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000063AD File Offset: 0x000045AD
		global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetHeaderPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this._listAutomationPeerHelper.GetHeaderPeer(record);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000063BB File Offset: 0x000045BB
		global::Infragistics.Windows.DataPresenter.RecordCollectionBase global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordCollection()
		{
			return this.GetRecordCollection();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000063C3 File Offset: 0x000045C3
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordList()
		{
			return this.GetRecordList();
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000063CB File Offset: 0x000045CB
		int global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetTableRowIndex(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetTableRowIndex(cell);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000063D9 File Offset: 0x000045D9
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetContainingGrid(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetContainingGrid(cell);
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600015C RID: 348 RVA: 0x000063E7 File Offset: 0x000045E7
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsRootLevel
		{
			get
			{
				return this.IsRootLevel;
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000063EF File Offset: 0x000045EF
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.ProviderFromPeer(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			return base.ProviderFromPeer(peer);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000063F8 File Offset: 0x000045F8
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetUnderlyingPeer(object item)
		{
			global::System.Windows.UIElement uielement = base.ContainerFromItem(item) as global::System.Windows.UIElement;
			global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer recordListItemContainer = uielement as global::Infragistics.Windows.DataPresenter.Internal.RecordListItemContainer;
			if (recordListItemContainer != null)
			{
				uielement = recordListItemContainer.RecordPresenter;
			}
			if (uielement == null)
			{
				return null;
			}
			return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(uielement);
		}

		// Token: 0x04000053 RID: 83
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper _listAutomationPeerHelper;
	}
}
