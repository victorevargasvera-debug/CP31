using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.AutomationPeers;
using Infragistics.Windows.DataPresenter;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000024 RID: 36
	internal class ListAutomationPeerHelper
	{
		// Token: 0x060000FE RID: 254 RVA: 0x00004CBC File Offset: 0x00002EBC
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

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00004D2C File Offset: 0x00002F2C
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

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00004D4C File Offset: 0x00002F4C
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

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00004D70 File Offset: 0x00002F70
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00004D88 File Offset: 0x00002F88
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

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00004DD8 File Offset: 0x00002FD8
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer HeaderPeer
		{
			get
			{
				if (this._headerPeer == null)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
					if (this._recordListAutomationPeer.CouldSupportGridPattern() && fieldLayout != null)
					{
						this._headerPeer = new global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer(fieldLayout, this._recordListAutomationPeer, this._listAutomationPeer);
					}
				}
				return this._headerPeer;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00004E24 File Offset: 0x00003024
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

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00004EEC File Offset: 0x000030EC
		private int RecordCount
		{
			get
			{
				return this._recordListAutomationPeer.GetRecordList().Count;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00004F00 File Offset: 0x00003100
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

		// Token: 0x06000107 RID: 263 RVA: 0x00004F36 File Offset: 0x00003136
		internal static global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer CreateRecordAutomationPeer(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer recordListAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer listAutomationPeer)
		{
			if (record == null)
			{
				throw new global::System.ArgumentNullException("record");
			}
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer(record, recordListAutomationPeer, listAutomationPeer);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00004F50 File Offset: 0x00003150
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

		// Token: 0x06000109 RID: 265 RVA: 0x000052D8 File Offset: 0x000034D8
		private static void RaiseListSelectionInvalidated(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record != null)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.RaiseListSelectionInvalidated(record.ParentRecordList);
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000052E8 File Offset: 0x000034E8
		private static void RaiseListSelectionInvalidated(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (cell.Record != null)
			{
				global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.RaiseListSelectionInvalidated(cell.Record);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00005300 File Offset: 0x00003500
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

		// Token: 0x0600010C RID: 268 RVA: 0x00005324 File Offset: 0x00003524
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

		// Token: 0x0600010D RID: 269 RVA: 0x0000549C File Offset: 0x0000369C
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

		// Token: 0x0600010E RID: 270 RVA: 0x000054D8 File Offset: 0x000036D8
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

		// Token: 0x0600010F RID: 271 RVA: 0x00005560 File Offset: 0x00003760
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

		// Token: 0x06000110 RID: 272 RVA: 0x00005594 File Offset: 0x00003794
		private global::Infragistics.Windows.DataPresenter.FieldLayout GetRecordCollectionFieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollection = this._recordListAutomationPeer.GetRecordCollection();
			return recordCollection.FieldLayout;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000055B4 File Offset: 0x000037B4
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

		// Token: 0x06000112 RID: 274 RVA: 0x0000562D File Offset: 0x0000382D
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

		// Token: 0x06000113 RID: 275 RVA: 0x00005664 File Offset: 0x00003864
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

		// Token: 0x06000114 RID: 276 RVA: 0x0000572C File Offset: 0x0000392C
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

		// Token: 0x06000115 RID: 277 RVA: 0x00005780 File Offset: 0x00003980
		internal void InitializeFieldLayout()
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = null;
			if (this._recordListAutomationPeer.CouldSupportGridPattern())
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

		// Token: 0x06000116 RID: 278 RVA: 0x000057D0 File Offset: 0x000039D0
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

		// Token: 0x06000117 RID: 279 RVA: 0x000059E0 File Offset: 0x00003BE0
		internal void SetHasRecordGroups(bool? value)
		{
			this._hasRecordGroups = value;
			this._isGroupsDirty = true;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000059F0 File Offset: 0x00003BF0
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00005A70 File Offset: 0x00003C70
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

		// Token: 0x0600011A RID: 282 RVA: 0x00005AB8 File Offset: 0x00003CB8
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00005B6C File Offset: 0x00003D6C
		internal bool ISelectionProvider_IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005B6F File Offset: 0x00003D6F
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple[] ITableProvider_GetColumnHeaders()
		{
			if (!this._recordListAutomationPeer.IsHorizontalRowLayout)
			{
				return this.FieldHeaders;
			}
			return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005B8B File Offset: 0x00003D8B
		internal global::System.Windows.Automation.Provider.IRawElementProviderSimple[] ITableProvider_GetRowHeaders()
		{
			if (!this._recordListAutomationPeer.IsHorizontalRowLayout)
			{
				return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
			}
			return this.FieldHeaders;
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011E RID: 286 RVA: 0x00005BA7 File Offset: 0x00003DA7
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600011F RID: 287 RVA: 0x00005BB9 File Offset: 0x00003DB9
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

		// Token: 0x06000120 RID: 288 RVA: 0x00005BD8 File Offset: 0x00003DD8
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000121 RID: 289 RVA: 0x00005CB2 File Offset: 0x00003EB2
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

		// Token: 0x04000039 RID: 57
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400003A RID: 58
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.IRecordListAutomationPeer _recordListAutomationPeer;

		// Token: 0x0400003B RID: 59
		private global::Infragistics.Windows.Automation.Peers.IListAutomationPeer _listAutomationPeer;

		// Token: 0x0400003C RID: 60
		private global::Infragistics.Windows.Automation.Peers.DataPresenter.HeaderAutomationPeer _headerPeer;

		// Token: 0x0400003D RID: 61
		private bool? _hasRecordGroups = null;

		// Token: 0x0400003E RID: 62
		private bool _isGroupsDirty = true;

		// Token: 0x0400003F RID: 63
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordListGroup> _groups;

		// Token: 0x04000040 RID: 64
		private int _recordCount;

		// Token: 0x04000041 RID: 65
		private bool _isHomogenousCollection;

		// Token: 0x04000042 RID: 66
		private bool _isHomogenousCollectionDirty = true;

		// Token: 0x02000025 RID: 37
		private class SelectedItemComparer : global::System.Collections.IComparer
		{
			// Token: 0x06000123 RID: 291 RVA: 0x00005CDA File Offset: 0x00003EDA
			private SelectedItemComparer()
			{
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000124 RID: 292 RVA: 0x00005CE2 File Offset: 0x00003EE2
			internal static global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer Default
			{
				get
				{
					return global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer._default;
				}
			}

			// Token: 0x06000125 RID: 293 RVA: 0x00005CEC File Offset: 0x00003EEC
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

			// Token: 0x04000043 RID: 67
			private static readonly global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer _default = new global::Infragistics.Windows.Automation.Peers.DataPresenter.ListAutomationPeerHelper.SelectedItemComparer();
		}
	}
}
