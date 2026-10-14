using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Threading;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000024 RID: 36
	internal class ListAutomationPeerHelper
	{
		// Token: 0x06000109 RID: 265 RVA: 0x00004CC4 File Offset: 0x00002EC4
		internal ListAutomationPeerHelper(global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer)
		{
			if (recordListAutomationPeer == null)
			{
				throw new global::System.ArgumentNullException("recordListAutomationPeer");
			}
			if (listAutomationPeer == null)
			{
				throw new global::System.ArgumentNullException("listAutomationPeer");
			}
			this._recordListAutomationPeer = recordListAutomationPeer;
			this._listAutomationPeer = listAutomationPeer;
			this._recordCount = this._recordListAutomationPeer.GetRecordList().Count;
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00004D34 File Offset: 0x00002F34
		internal int FieldCount
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer = this.HeaderPeer;
				if (headerPeer == null)
				{
					return 0;
				}
				return headerPeer.GetHeaderItemCount();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004D54 File Offset: 0x00002F54
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple[] FieldHeaders
		{
			get
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer headerPeer = this.HeaderPeer;
				if (headerPeer == null)
				{
					return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
				}
				return headerPeer.GetHeaderItems();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004D78 File Offset: 0x00002F78
		private global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				if (this._fieldLayout == null)
				{
					this.InitializeFieldLayout();
				}
				return this._fieldLayout;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004D90 File Offset: 0x00002F90
		internal bool HasRecordGroups
		{
			get
			{
				if (this._hasRecordGroups == null)
				{
					this._hasRecordGroups = new bool?(!this.IsHomogenousCollection());
					this._isGroupsDirty = true;
				}
				return this._hasRecordGroups == true;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00004DE0 File Offset: 0x00002FE0
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer HeaderPeer
		{
			get
			{
				if (this._headerPeer == null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
					if (fieldLayout != null && this.ShouldIncludeHeaderPeer)
					{
						this._headerPeer = new global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer(fieldLayout, this._recordListAutomationPeer, this._listAutomationPeer);
					}
				}
				return this._headerPeer;
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00004E28 File Offset: 0x00003028
		internal bool IsHomogenousCollection()
		{
			if (!this._isHomogenousCollectionDirty)
			{
				return this._isHomogenousCollection;
			}
			this._isHomogenousCollectionDirty = false;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> recordList = this._recordListAutomationPeer.GetRecordList();
			if (recordList == null)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = recordList as global::Infragistics.Windows.DataPresenter.ViewableRecordCollection;
			if (viewableRecordCollection != null)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = viewableRecordCollection.RecordCollection;
				if (recordCollection != null)
				{
					switch (recordCollection.RecordsType)
					{
					case global::Infragistics.Windows.DataPresenter.RecordType.DataRecord:
						this._isHomogenousCollection = false;
						if (viewableRecordCollection.HasSummaryRecord)
						{
							this._hasMultipleFieldLayoutTracker = null;
						}
						else
						{
							this._isHomogenousCollection = !viewableRecordCollection.RecordManager.HasMultipleFieldLayouts;
							if (this._isHomogenousCollection)
							{
								this._hasMultipleFieldLayoutTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(viewableRecordCollection.RecordManager, "HasMultipleFieldLayouts", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnHasMultipleFieldLayoutsChanged));
							}
						}
						return this._isHomogenousCollection;
					case global::Infragistics.Windows.DataPresenter.RecordType.GroupByField:
						this._isHomogenousCollection = (!viewableRecordCollection.HasHeaderRecord && !viewableRecordCollection.HasFilterRecord);
						return this._isHomogenousCollection;
					}
				}
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout recordCollectionFieldLayout = this.GetRecordCollectionFieldLayout();
			if (recordList.Count > 0)
			{
				bool flag = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CouldSupportGridPattern(recordList[0].RecordType);
				foreach (global::Infragistics.Windows.DataPresenter.Record record in recordList)
				{
					if (record.FieldLayout != recordCollectionFieldLayout || flag != global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CouldSupportGridPattern(record.RecordType))
					{
						this._isHomogenousCollection = false;
						return this._isHomogenousCollection;
					}
				}
			}
			this._isHomogenousCollection = true;
			return this._isHomogenousCollection;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000110 RID: 272 RVA: 0x00004FA8 File Offset: 0x000031A8
		private int RecordCount
		{
			get
			{
				return this._recordListAutomationPeer.GetRecordList().Count;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00004FBC File Offset: 0x000031BC
		internal bool ShouldIncludeHeaderPeer
		{
			get
			{
				if (this.HasRecordGroups)
				{
					return false;
				}
				if (this._recordListAutomationPeer.CouldSupportGridPattern())
				{
					return true;
				}
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this._recordListAutomationPeer.GetRecordCollection();
				if (recordCollection != null)
				{
					global::Infragistics.Windows.DataPresenter.Record parentRecord = recordCollection.ParentRecord;
					if ((recordCollection.IsTopLevel || (parentRecord != null && parentRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)) && recordCollection.RecordsType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByField && recordCollection.FieldLayout != null && recordCollection.FieldLayout.HeaderPlacementInGroupByResolved == global::Infragistics.Windows.DataPresenter.HeaderPlacementInGroupBy.OnTopOnly)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00005030 File Offset: 0x00003230
		internal static bool CouldSupportGridPattern(global::Infragistics.Windows.DataPresenter.RecordType collectionRecordType)
		{
			switch (collectionRecordType)
			{
			case global::Infragistics.Windows.DataPresenter.RecordType.DataRecord:
			case global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord:
			case global::Infragistics.Windows.DataPresenter.RecordType.HeaderRecord:
				return true;
			}
			return false;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00005066 File Offset: 0x00003266
		internal static global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer CreateRecordAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer(record, recordListAutomationPeer, listAutomationPeer);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00005080 File Offset: 0x00003280
		internal static global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer GetOrCreateRecordAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer, global::System.Windows.Automation.Peers.AutomationPeer parent)
		{
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer recordAutomationPeer = record.AutomationPeer;
			if (recordAutomationPeer == null || (recordAutomationPeer.GetParent() ?? parent) != parent)
			{
				recordAutomationPeer = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CreateRecordAutomationPeer(record, recordListAutomationPeer, listAutomationPeer);
			}
			return recordAutomationPeer;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000050B0 File Offset: 0x000032B0
		internal static void RaiseAutomationSelectionEvents(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder oldSelection, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection)
		{
			if (newSelection.HasCells && newSelection.Cells.Count == 1 && (!oldSelection.HasCells || oldSelection.Cells.Count > 1 || oldSelection.Cells[0] != newSelection.Cells[0]))
			{
				if (!newSelection.Cells[0].RaiseAutomationSelectedChange(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected))
				{
					global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.RaiseListSelectionInvalidated(newSelection.Cells[0]);
				}
				return;
			}
			if (newSelection.HasRecords && newSelection.Records.Count == 1 && (!oldSelection.HasRecords || oldSelection.Records.Count > 1 || oldSelection.Records[0] != newSelection.Records[0]))
			{
				if (!newSelection.Records[0].RaiseAutomationSelectedChange(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected))
				{
					global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.RaiseListSelectionInvalidated(newSelection.Records[0]);
				}
				return;
			}
			global::Infragistics.Windows.DataPresenter.Record[] array;
			global::Infragistics.Windows.DataPresenter.Cell[] array2;
			if (oldSelection.HasRecords && !newSelection.HasRecords)
			{
				array = oldSelection.Records.ToArray();
				array2 = (newSelection.HasCells ? newSelection.Cells.ToArray() : null);
			}
			else if (!oldSelection.HasRecords && newSelection.HasRecords)
			{
				array = newSelection.Records.ToArray();
				array2 = (oldSelection.HasCells ? oldSelection.Cells.ToArray() : null);
			}
			else if (oldSelection.HasCells && !newSelection.HasCells)
			{
				array2 = oldSelection.Cells.ToArray();
				array = (newSelection.HasRecords ? newSelection.Records.ToArray() : null);
			}
			else if (!oldSelection.HasCells && newSelection.HasCells)
			{
				array2 = newSelection.Cells.ToArray();
				array = null;
			}
			else
			{
				array = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.GetDiffList<global::Infragistics.Windows.DataPresenter.Record>(oldSelection.Records, newSelection.Records).ToArray();
				array2 = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.GetDiffList<global::Infragistics.Windows.DataPresenter.Cell>(oldSelection.Cells, newSelection.Cells).ToArray();
			}
			global::Infragistics.Windows.Selection.ISelectableItem[] array3;
			if (array == null || array.Length == 0)
			{
				array3 = array2;
			}
			else if (array2 == null || array2.Length == 0)
			{
				array3 = array;
			}
			else
			{
				array3 = new global::Infragistics.Windows.Selection.ISelectableItem[array2.Length + array.Length];
				array.CopyTo(array3, 0);
				array2.CopyTo(array3, array.Length);
			}
			global::Infragistics.CoreUtilities.SortMerge(array3, global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer.Default);
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem>> dictionary = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SplitItems(array3, null);
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem>> keyValuePair in dictionary)
			{
				if (keyValuePair.Value.Count < 20)
				{
					bool flag = false;
					foreach (global::Infragistics.Windows.Selection.ISelectableItem selectableItem in keyValuePair.Value)
					{
						if (selectableItem is global::Infragistics.Windows.DataPresenter.Record)
						{
							global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)selectableItem;
							if (!record.RaiseAutomationSelectedChange(record.IsSelected ? global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection : global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
							{
								flag = true;
								break;
							}
						}
						else if (selectableItem is global::Infragistics.Windows.DataPresenter.Cell)
						{
							global::Infragistics.Windows.DataPresenter.Cell cell = (global::Infragistics.Windows.DataPresenter.Cell)selectableItem;
							if (!cell.RaiseAutomationSelectedChange(cell.IsSelected ? global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection : global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						continue;
					}
				}
				global::Infragistics.Windows.DataPresenter.RecordListControl lastRecordList = keyValuePair.Key.LastRecordList;
				if (lastRecordList == null && keyValuePair.Key.ParentRecordManager != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = keyValuePair.Key.ParentRecordManager.ViewableRecords;
					if (viewableRecords != null)
					{
						lastRecordList = viewableRecords.LastRecordList;
					}
				}
				if (lastRecordList != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(lastRecordList);
					if (automationPeer != null)
					{
						automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionPatternOnInvalidated);
					}
				}
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00005438 File Offset: 0x00003638
		private static void RaiseListSelectionInvalidated(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record != null)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.RaiseListSelectionInvalidated(record.ParentRecordList);
			}
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00005448 File Offset: 0x00003648
		private static void RaiseListSelectionInvalidated(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (cell.Record != null)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.RaiseListSelectionInvalidated(cell.Record);
			}
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00005460 File Offset: 0x00003660
		private static void RaiseListSelectionInvalidated(global::Infragistics.Windows.DataPresenter.RecordListControl listControl)
		{
			if (listControl != null)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(listControl);
				if (automationPeer != null)
				{
					automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionPatternOnInvalidated);
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00005484 File Offset: 0x00003684
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> CreateGroups()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> groups = this._groups;
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> recordList = this._recordListAutomationPeer.GetRecordList();
			global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup>();
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup = null;
			if (recordList == null)
			{
				return null;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Record record in recordList)
			{
				bool flag = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.CouldSupportGridPattern(record.RecordType);
				if (recordListGroup == null || recordListGroup.FieldLayout != record.FieldLayout || recordListGroup.SupportsGridPattern != flag)
				{
					recordListGroup = new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup(this._recordListAutomationPeer, this._listAutomationPeer, record.FieldLayout, flag);
					list.Add(recordListGroup);
				}
				recordListGroup.AddRecord(record);
			}
			foreach (global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup2 in list)
			{
				recordListGroup2.InitializeNotifyRecordCount();
			}
			if (groups != null)
			{
				foreach (global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup3 in list)
				{
					for (int i = 0; i < groups.Count; i++)
					{
						global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup4 = groups[i];
						if (recordListGroup4 != null && recordListGroup4.IsSameGroup(recordListGroup3))
						{
							groups[i] = null;
							recordListGroup3.InitializeFrom(recordListGroup4);
							break;
						}
					}
				}
			}
			return list;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000055FC File Offset: 0x000037FC
		internal global::System.Windows.Automation.Peers.AutomationPeer GetContainingGrid(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (!this.HasRecordGroups)
			{
				return this._recordListAutomationPeer as global::System.Windows.Automation.Peers.AutomationPeer;
			}
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup = this.GetRecordListGroup(cell.Record);
			if (recordListGroup == null)
			{
				return null;
			}
			return recordListGroup.AutomationPeer;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00005638 File Offset: 0x00003838
		private static global::System.Collections.Generic.List<T> GetDiffList<T>(global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase oldItems, global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase newItems) where T : class, global::Infragistics.Windows.Selection.ISelectableItem
		{
			global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>();
			int i = 0;
			int count = newItems.Count;
			while (i < count)
			{
				list.Add(newItems.GetItem(i) as T);
				i++;
			}
			int j = 0;
			int count2 = oldItems.Count;
			while (j < count2)
			{
				T item = oldItems.GetItem(j) as T;
				if (item.IsSelected)
				{
					list.Remove(item);
				}
				else
				{
					list.Add(item);
				}
				j++;
			}
			return list;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x000056C0 File Offset: 0x000038C0
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer GetHeaderPeer(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (!this.HasRecordGroups)
			{
				return this.HeaderPeer;
			}
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup = this.GetRecordListGroup(record);
			if (recordListGroup == null)
			{
				return null;
			}
			return recordListGroup.AutomationPeer.HeaderPeer;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000056F4 File Offset: 0x000038F4
		private global::Infragistics.Windows.DataPresenter.FieldLayout GetRecordCollectionFieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this._recordListAutomationPeer.GetRecordCollection();
			return recordCollection.FieldLayout;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005714 File Offset: 0x00003914
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup GetRecordListGroup(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> recordListGroups = this.GetRecordListGroups();
			if (recordListGroups != null && record != null)
			{
				int visibleIndex = record.VisibleIndex;
				int i = 0;
				int num = recordListGroups.Count - 1;
				while (i < num)
				{
					int num2 = i + (num - i) / 2;
					global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup = recordListGroups[num2];
					int num3 = recordListGroup.CompareTo(visibleIndex);
					if (num3 == 0)
					{
						return recordListGroup;
					}
					if (num3 < 0)
					{
						i = num2 + 1;
					}
					else
					{
						num = num2 - 1;
					}
				}
				if (recordListGroups.Count == 1)
				{
					return recordListGroups[0];
				}
			}
			return null;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000578D File Offset: 0x0000398D
		internal global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> GetRecordListGroups()
		{
			if (this._isGroupsDirty)
			{
				this._isGroupsDirty = false;
				if (this.HasRecordGroups)
				{
					this._groups = this.CreateGroups();
				}
				else
				{
					this._groups = null;
				}
			}
			return this._groups;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x000057C4 File Offset: 0x000039C4
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem> GetSelectedItems()
		{
			if (this._fieldLayout == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
			if (dataPresenter != null && (dataPresenter.SelectedItems.HasRecords || dataPresenter.SelectedItems.HasCells))
			{
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> recordList = this._recordListAutomationPeer.GetRecordList();
				if (recordList != null && recordList.Count > 0)
				{
					global::Infragistics.Windows.Selection.ISelectableItem[] array = dataPresenter.SelectedItems.HasRecords ? ((global::Infragistics.Windows.Selection.ISelectableItem[])dataPresenter.SelectedItems.Records.ToArray()) : ((global::Infragistics.Windows.Selection.ISelectableItem[])dataPresenter.SelectedItems.Cells.ToArray());
					global::Infragistics.CoreUtilities.SortMerge(array, global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer.Default);
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this._recordListAutomationPeer.GetRecordCollection();
					global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem>> dictionary = global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SplitItems(array, recordCollection);
					global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem> result;
					if (dictionary.TryGetValue(recordCollection, out result))
					{
						return result;
					}
				}
			}
			return null;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000588C File Offset: 0x00003A8C
		internal int GetTableRowIndex(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (this.HasRecordGroups)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup = this.GetRecordListGroup(cell.Record);
				if (recordListGroup == null)
				{
					return 0;
				}
				return recordListGroup.IndexOf(cell.Record);
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Record record = cell.Record;
				if (record != null)
				{
					return this._recordListAutomationPeer.GetRecordList().IndexOf(record);
				}
				return 0;
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x000058E0 File Offset: 0x00003AE0
		internal void InitializeFieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = null;
			if (this.ShouldIncludeHeaderPeer)
			{
				fieldLayout2 = this.GetRecordCollectionFieldLayout();
			}
			if (fieldLayout != fieldLayout2)
			{
				if (this._headerPeer != null)
				{
					this._headerPeer.Deactivate();
					this._headerPeer = null;
				}
				this._fieldLayout = fieldLayout2;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000592C File Offset: 0x00003B2C
		internal void ProcessListChange(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this.InitializeFieldLayout();
			}
			this._isHomogenousCollectionDirty = true;
			bool hasRecordGroups = this.HasRecordGroups;
			if (hasRecordGroups)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> recordListGroups = this.GetRecordListGroups();
				switch (e.Action)
				{
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
					foreach (object obj in e.OldItems)
					{
						global::Infragistics.Windows.DataPresenter.Record record = obj as global::Infragistics.Windows.DataPresenter.Record;
						int i = 0;
						int count = recordListGroups.Count;
						while (i < count)
						{
							int num = recordListGroups[i].IndexOf(record);
							if (num >= 0)
							{
								recordListGroups[i].RemoveAt(num);
								break;
							}
							i++;
						}
					}
					break;
				}
			}
			this.SetHasRecordGroups(null);
			if (this.HasRecordGroups)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> recordListGroups2 = this.GetRecordListGroups();
				if (recordListGroups2 == null)
				{
					goto IL_194;
				}
				using (global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup>.Enumerator enumerator2 = recordListGroups2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup recordListGroup = enumerator2.Current;
						recordListGroup.RaiseRecordCountChange();
					}
					goto IL_194;
				}
			}
			if (!hasRecordGroups)
			{
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> recordList = this._recordListAutomationPeer.GetRecordList();
				if (recordList != null && this._recordCount != recordList.Count)
				{
					global::System.Windows.Automation.AutomationProperty property = this._recordListAutomationPeer.IsHorizontalRowLayout ? global::System.Windows.Automation.GridPatternIdentifiers.ColumnCountProperty : global::System.Windows.Automation.GridPatternIdentifiers.RowCountProperty;
					((global::System.Windows.Automation.Peers.AutomationPeer)this._recordListAutomationPeer).RaisePropertyChangedEvent(property, this._recordCount, recordList.Count);
					this._recordCount = recordList.Count;
				}
			}
			IL_194:
			if (hasRecordGroups != this.HasRecordGroups)
			{
				((global::System.Windows.Automation.Peers.AutomationPeer)this._recordListAutomationPeer).RaisePropertyChangedEvent(global::System.Windows.Automation.AutomationElementIdentifiers.IsGridPatternAvailableProperty, !hasRecordGroups, !this.HasRecordGroups);
			}
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this._recordListAutomationPeer as global::System.Windows.Automation.Peers.AutomationPeer;
			automationPeer.InvalidatePeer();
			global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(automationPeer);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00005B3C File Offset: 0x00003D3C
		internal void SetHasRecordGroups(bool? value)
		{
			this._hasRecordGroups = value;
			this._isGroupsDirty = true;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00005B4C File Offset: 0x00003D4C
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem>> SplitItems(global::Infragistics.Windows.Selection.ISelectableItem[] items, global::Infragistics.Windows.DataPresenter.RecordCollectionBase targetParentCollection)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem>> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.RecordCollectionBase, global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem>>();
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = null;
			global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem> list = null;
			foreach (global::Infragistics.Windows.Selection.ISelectableItem selectableItem in items)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase2 = (selectableItem is global::Infragistics.Windows.DataPresenter.Record) ? ((global::Infragistics.Windows.DataPresenter.Record)selectableItem).ParentCollection : ((global::Infragistics.Windows.DataPresenter.Cell)selectableItem).Record.ParentCollection;
				if (recordCollectionBase2 != null && (targetParentCollection == null || targetParentCollection == recordCollectionBase2))
				{
					if (recordCollectionBase2 != recordCollectionBase)
					{
						recordCollectionBase = recordCollectionBase2;
						list = new global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem>();
						dictionary.Add(recordCollectionBase, list);
					}
					list.Add(selectableItem);
				}
			}
			return dictionary;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00005BDC File Offset: 0x00003DDC
		private void OnHasMultipleFieldLayoutsChanged()
		{
			if (!this._isHomogenousCollectionDirty)
			{
				global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					this.ProcessListChange(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}), new object[0]);
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00005C18 File Offset: 0x00003E18
		internal bool ISelectionProvider_CanSelectMultiple
		{
			get
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem> selectedItems = this.GetSelectedItems();
				if (selectedItems != null && selectedItems.Count > 0)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._fieldLayout.DataPresenter;
					global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = ((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).GetSelectionStrategyForItem(selectedItems[0]);
					if (selectionStrategyForItem != null)
					{
						return selectionStrategyForItem.IsMultiSelect;
					}
				}
				return true;
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005C60 File Offset: 0x00003E60
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple[] ISelectionProvider_GetSelection()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.Selection.ISelectableItem> selectedItems = this.GetSelectedItems();
			if (selectedItems != null && selectedItems.Count > 0)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>(selectedItems.Count);
				foreach (global::Infragistics.Windows.Selection.ISelectableItem selectableItem in selectedItems)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = null;
					if (selectableItem is global::Infragistics.Windows.DataPresenter.Record)
					{
						automationPeer = ((global::Infragistics.Windows.DataPresenter.Record)selectableItem).AutomationPeer;
					}
					else if (selectableItem is global::Infragistics.Windows.DataPresenter.Cell)
					{
						automationPeer = ((global::Infragistics.Windows.DataPresenter.Cell)selectableItem).AutomationPeer;
					}
					if (automationPeer != null)
					{
						list.Add(this._recordListAutomationPeer.ProviderFromPeer(automationPeer));
					}
				}
				return list.ToArray();
			}
			return null;
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00005D14 File Offset: 0x00003F14
		internal bool ISelectionProvider_IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005D17 File Offset: 0x00003F17
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple[] ITableProvider_GetColumnHeaders()
		{
			if (!this._recordListAutomationPeer.IsHorizontalRowLayout)
			{
				return this.FieldHeaders;
			}
			return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005D33 File Offset: 0x00003F33
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple[] ITableProvider_GetRowHeaders()
		{
			if (!this._recordListAutomationPeer.IsHorizontalRowLayout)
			{
				return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
			}
			return this.FieldHeaders;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00005D4F File Offset: 0x00003F4F
		internal global::System.Windows.Automation.RowOrColumnMajor ITableProvider_RowOrColumnMajor
		{
			get
			{
				if (!this._recordListAutomationPeer.IsHorizontalRowLayout)
				{
					return global::System.Windows.Automation.RowOrColumnMajor.RowMajor;
				}
				return global::System.Windows.Automation.RowOrColumnMajor.ColumnMajor;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00005D61 File Offset: 0x00003F61
		internal int IGridProvider_ColumnCount
		{
			get
			{
				if (!this._recordListAutomationPeer.IsHorizontalRowLayout)
				{
					return this.FieldCount;
				}
				return this.RecordCount;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00005D80 File Offset: 0x00003F80
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple IGridProvider_GetItem(int row, int column)
		{
			if (row > this.IGridProvider_RowCount || row < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("row");
			}
			if (column > this.IGridProvider_ColumnCount || column < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("column");
			}
			if (this._recordListAutomationPeer.IsHorizontalRowLayout)
			{
				int num = column;
				column = row;
				row = num;
			}
			global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> recordList = this._recordListAutomationPeer.GetRecordList();
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = recordList[row] as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord == null || dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord)
			{
				return null;
			}
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer automationPeer = dataRecord.AutomationPeer;
			if (automationPeer == null)
			{
				((global::System.Windows.Automation.Peers.AutomationPeer)this._recordListAutomationPeer).GetChildren();
				automationPeer = dataRecord.AutomationPeer;
			}
			if (automationPeer != null)
			{
				global::Infragistics.Windows.DataPresenter.Field fieldAtIndex = this.HeaderPeer.GetFieldAtIndex(column);
				global::Infragistics.Windows.Automation.Peers.DataPresenter.CellAutomationPeer cellPeer = automationPeer.GetCellPeer(dataRecord.Cells[fieldAtIndex]);
				global::System.Windows.Automation.Provider.IRawElementProviderSimple result = null;
				if (cellPeer != null)
				{
					result = this._recordListAutomationPeer.ProviderFromPeer(cellPeer);
				}
				return result;
			}
			return null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00005E5A File Offset: 0x0000405A
		internal int IGridProvider_RowCount
		{
			get
			{
				if (!this._recordListAutomationPeer.IsHorizontalRowLayout)
				{
					return this.RecordCount;
				}
				return this.FieldCount;
			}
		}

		// Token: 0x04000047 RID: 71
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000048 RID: 72
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x04000049 RID: 73
		private global::Infragistics.Windows.Automation.Peers.IListAutomationPeer _listAutomationPeer;

		// Token: 0x0400004A RID: 74
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer _headerPeer;

		// Token: 0x0400004B RID: 75
		private bool? _hasRecordGroups = null;

		// Token: 0x0400004C RID: 76
		private bool _isGroupsDirty = true;

		// Token: 0x0400004D RID: 77
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> _groups;

		// Token: 0x0400004E RID: 78
		private int _recordCount;

		// Token: 0x0400004F RID: 79
		private bool _isHomogenousCollection;

		// Token: 0x04000050 RID: 80
		private bool _isHomogenousCollectionDirty = true;

		// Token: 0x04000051 RID: 81
		private global::Infragistics.Windows.Internal.PropertyValueTracker _hasMultipleFieldLayoutTracker;

		// Token: 0x02000025 RID: 37
		private class SelectedItemComparer : global::System.Collections.IComparer
		{
			// Token: 0x06000132 RID: 306 RVA: 0x00005E82 File Offset: 0x00004082
			private SelectedItemComparer()
			{
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00005E8A File Offset: 0x0000408A
			internal static global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer Default
			{
				get
				{
					return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer._default;
				}
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00005E94 File Offset: 0x00004094
			int global::System.Collections.IComparer.Compare(object x, object y)
			{
				global::Infragistics.Windows.DataPresenter.Record record;
				if (x is global::Infragistics.Windows.DataPresenter.Cell)
				{
					record = ((global::Infragistics.Windows.DataPresenter.Cell)x).Record;
				}
				else
				{
					record = (x as global::Infragistics.Windows.DataPresenter.Record);
				}
				global::Infragistics.Windows.DataPresenter.Record record2;
				if (y is global::Infragistics.Windows.DataPresenter.Cell)
				{
					record2 = ((global::Infragistics.Windows.DataPresenter.Cell)y).Record;
				}
				else
				{
					record2 = (y as global::Infragistics.Windows.DataPresenter.Record);
				}
				if (record.ParentCollection != record2.ParentCollection)
				{
					return record.ParentCollection.GetHashCode().CompareTo(record2.ParentCollection.GetHashCode());
				}
				return 0;
			}

			// Token: 0x04000052 RID: 82
			private static readonly global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer _default = new global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer();
		}
	}
}
