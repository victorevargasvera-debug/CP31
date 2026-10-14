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
		// Token: 0x0600012D RID: 301 RVA: 0x00005D90 File Offset: 0x00003F90
		public RecordListControlAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordListControl control) : base(control)
		{
			this._listAutomationPeerHelper = new global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper(this, this);
			this._listAutomationPeerHelper.InitializeFieldLayout();
			global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.AddProxyPeerHost(this, control.DataPresenter);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005DBD File Offset: 0x00003FBD
		protected override global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer CreateAutomationPeer(object item)
		{
			if (!(item is global::Infragistics.Windows.DataPresenter.Record))
			{
				throw new global::System.ArgumentException();
			}
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CreateRecordAutomationPeer((global::Infragistics.Windows.DataPresenter.Record)item, this, this);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00005DDA File Offset: 0x00003FDA
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			if (!this._listAutomationPeerHelper.HasRecordGroups && this.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Table) != null)
			{
				return global::System.Windows.Automation.Peers.AutomationControlType.DataGrid;
			}
			return global::System.Windows.Automation.Peers.AutomationControlType.List;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00005DF7 File Offset: 0x00003FF7
		protected override string GetClassNameCore()
		{
			return "RecordListControl";
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00005E08 File Offset: 0x00004008
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
			if (this.CouldSupportGridPattern())
			{
				global::System.Windows.Automation.Peers.AutomationPeer headerPeer = this._listAutomationPeerHelper.HeaderPeer;
				if (headerPeer != null)
				{
					childrenCore.Insert(0, headerPeer);
				}
			}
			return childrenCore;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00005EBC File Offset: 0x000040BC
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

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00005F74 File Offset: 0x00004174
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

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000134 RID: 308 RVA: 0x00005FB0 File Offset: 0x000041B0
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

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000135 RID: 309 RVA: 0x00005FF0 File Offset: 0x000041F0
		private bool IsRootLevel
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
				return recordListControl != null && recordListControl.DataPresenter != null && recordListControl.DataPresenter.RootRecordListControl == recordListControl;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000136 RID: 310 RVA: 0x00006024 File Offset: 0x00004224
		private bool ProcessVisualTreeOnly
		{
			get
			{
				return global::Infragistics.Windows.Automation.Peers.DataPresenter.DataPresenterBaseAutomationPeer.ProcessVisualTreeOnly;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000602C File Offset: 0x0000422C
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

		// Token: 0x06000138 RID: 312 RVA: 0x000060A8 File Offset: 0x000042A8
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> GetRecordList()
		{
			global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = (global::Infragistics.Windows.DataPresenter.RecordListControl)base.Owner;
			return recordListControl.ItemsSource as global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record>;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000060CC File Offset: 0x000042CC
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

		// Token: 0x0600013A RID: 314 RVA: 0x00006106 File Offset: 0x00004306
		protected internal override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			if (this.ProcessVisualTreeOnly)
			{
				return;
			}
			this._listAutomationPeerHelper.ProcessListChange(e);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00006124 File Offset: 0x00004324
		protected internal override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			base.OnItemsSourceChanged(oldValue, newValue);
			this._listAutomationPeerHelper.SetHasRecordGroups(null);
			this._listAutomationPeerHelper.InitializeFieldLayout();
			base.InvalidatePeer();
			global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(this);
			base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000616C File Offset: 0x0000436C
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_CanSelectMultiple;
			}
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00006179 File Offset: 0x00004379
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			return this._listAutomationPeerHelper.ISelectionProvider_GetSelection();
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600013E RID: 318 RVA: 0x00006186 File Offset: 0x00004386
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return this._listAutomationPeerHelper.ISelectionProvider_IsSelectionRequired;
			}
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00006193 File Offset: 0x00004393
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetColumnHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetColumnHeaders();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x000061A0 File Offset: 0x000043A0
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ITableProvider.GetRowHeaders()
		{
			return this._listAutomationPeerHelper.ITableProvider_GetRowHeaders();
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000141 RID: 321 RVA: 0x000061AD File Offset: 0x000043AD
		global::System.Windows.Automation.RowOrColumnMajor global::System.Windows.Automation.Provider.ITableProvider.RowOrColumnMajor
		{
			get
			{
				return this._listAutomationPeerHelper.ITableProvider_RowOrColumnMajor;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000061BA File Offset: 0x000043BA
		int global::System.Windows.Automation.Provider.IGridProvider.ColumnCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_ColumnCount;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000061C7 File Offset: 0x000043C7
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.IGridProvider.GetItem(int row, int column)
		{
			return this._listAutomationPeerHelper.IGridProvider_GetItem(row, column);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000144 RID: 324 RVA: 0x000061D6 File Offset: 0x000043D6
		int global::System.Windows.Automation.Provider.IGridProvider.RowCount
		{
			get
			{
				return this._listAutomationPeerHelper.IGridProvider_RowCount;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000061E3 File Offset: 0x000043E3
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsHorizontalRowLayout
		{
			get
			{
				return this.IsHorizontalRowLayout;
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000061EB File Offset: 0x000043EB
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CouldSupportGridPattern()
		{
			return this.CouldSupportGridPattern();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000061F3 File Offset: 0x000043F3
		global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.CreateAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CreateRecordAutomationPeer(record, this, this);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000061FD File Offset: 0x000043FD
		global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetHeaderPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return this._listAutomationPeerHelper.GetHeaderPeer(record);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000620B File Offset: 0x0000440B
		global::Infragistics.Windows.DataPresenter.RecordCollectionBase global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordCollection()
		{
			return this.GetRecordCollection();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006213 File Offset: 0x00004413
		global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetRecordList()
		{
			return this.GetRecordList();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000621B File Offset: 0x0000441B
		int global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetTableRowIndex(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetTableRowIndex(cell);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006229 File Offset: 0x00004429
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.GetContainingGrid(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return this._listAutomationPeerHelper.GetContainingGrid(cell);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00006237 File Offset: 0x00004437
		bool global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.IsRootLevel
		{
			get
			{
				return this.IsRootLevel;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000623F File Offset: 0x0000443F
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer.ProviderFromPeer(global::System.Windows.Automation.Peers.AutomationPeer peer)
		{
			return base.ProviderFromPeer(peer);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006248 File Offset: 0x00004448
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

		// Token: 0x04000044 RID: 68
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper _listAutomationPeerHelper;
	}
}
