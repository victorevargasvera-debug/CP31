using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000353 RID: 851
	public sealed class SelectedRecordCollection : global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase
	{
		// Token: 0x06002806 RID: 10246 RVA: 0x000AC06A File Offset: 0x000AA26A
		internal SelectedRecordCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x06002807 RID: 10247 RVA: 0x000AC074 File Offset: 0x000AA274
		internal override void ResetItemSelectionStates()
		{
			foreach (global::Infragistics.Windows.DataPresenter.Record record in this)
			{
				record.InternalSelect(false);
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x06002808 RID: 10248 RVA: 0x000AC0BC File Offset: 0x000AA2BC
		public override bool IsReadOnly
		{
			get
			{
				return base.DataPresenter == null || base.Owner != base.DataPresenter.SelectedItems || this != base.Owner.Records;
			}
		}

		// Token: 0x06002809 RID: 10249 RVA: 0x000AC0EC File Offset: 0x000AA2EC
		public void Add(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.AddRange(new global::Infragistics.Windows.DataPresenter.Record[]
			{
				record
			});
		}

		// Token: 0x0600280A RID: 10250 RVA: 0x000AC10B File Offset: 0x000AA30B
		public void AddRange(global::Infragistics.Windows.DataPresenter.Record[] records)
		{
			this.AddRange(records, true, true);
		}

		// Token: 0x0600280B RID: 10251 RVA: 0x000AC118 File Offset: 0x000AA318
		public void AddRange(global::Infragistics.Windows.DataPresenter.Record[] records, bool ensureRecordsOrdered, bool fireSelectionChangeEvent)
		{
			if (records.Length <= 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = records[0].FieldLayout;
			for (int i = 1; i < records.Length; i++)
			{
				if (records[i].FieldLayout != fieldLayout)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_30"), "records");
				}
			}
			if (fieldLayout == null || fieldLayout.DataPresenter != dataPresenter)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_31"), "records");
			}
			if (base.Count > 0 && fieldLayout != this[0].FieldLayout)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_30"), "records");
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = ((global::Infragistics.Windows.Selection.ISelectionHost)base.DataPresenter).GetSelectionStrategyForItem(records[0]);
			if (selectionStrategyForItem == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_17"));
			}
			if (!selectionStrategyForItem.IsMultiSelect)
			{
				if (!selectionStrategyForItem.IsSingleSelect)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_19"));
				}
				if (records.Length + base.Count > 1)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_18"));
				}
			}
			if (!dataPresenter.ClearSelectedCells())
			{
				return;
			}
			bool flag = ensureRecordsOrdered || 0 != base.Count;
			if (flag && base.Count == 0)
			{
				flag = false;
				int i = 1;
				while (!flag && i < records.Length)
				{
					flag = (0 < global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectionPositionSortComparer.CompareRecord(records[i - 1], records[i]));
					i++;
				}
			}
			object[] array;
			if (flag)
			{
				global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable();
				object value = new object();
				for (int i = 0; i < base.Count; i++)
				{
					hashtable[this[i]] = value;
				}
				for (int i = 0; i < records.Length; i++)
				{
					hashtable[records[i]] = value;
				}
				array = new object[hashtable.Count];
				hashtable.Keys.CopyTo(array, 0);
				global::Infragistics.CoreUtilities.SortMerge(array, new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectionPositionSortComparer());
			}
			else
			{
				array = records;
			}
			int count = base.Count;
			if (!fireSelectionChangeEvent)
			{
				base.InternalClear();
				base.InternalAddRange(array);
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = this.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
						record.InternalSelect(true);
					}
					goto IL_250;
				}
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(base.DataPresenter);
			selectedItemHolder.Records.InternalAddRange(array);
			selectedItemHolder.Fields.InternalSetList(dataPresenter.SelectedItems.Fields);
			dataPresenter.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Record), selectedItemHolder);
			IL_250:
			if (base.Count == count)
			{
				return;
			}
			base.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, records));
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x000AC3A0 File Offset: 0x000AA5A0
		public void Clear()
		{
			if (base.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this.IsReadOnly)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_13"));
			}
			dataPresenter.ClearSelectedRecords();
			if (base.Count == 0)
			{
				base.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x0600280D RID: 10253 RVA: 0x000AC3F0 File Offset: 0x000AA5F0
		public bool Contains(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return base.List.Contains(item);
		}

		// Token: 0x0600280E RID: 10254 RVA: 0x000AC3FE File Offset: 0x000AA5FE
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		// Token: 0x0600280F RID: 10255 RVA: 0x000AC40D File Offset: 0x000AA60D
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumerator(((global::System.Collections.IEnumerable)this).GetEnumerator());
		}

		// Token: 0x17000C1D RID: 3101
		public global::Infragistics.Windows.DataPresenter.Record this[int index]
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Record)base.List[index];
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x000AC42D File Offset: 0x000AA62D
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Record selectedRecord)
		{
			return this.InternalAdd(selectedRecord, true);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000AC438 File Offset: 0x000AA638
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Record selectedRecord, bool validateAlreadyExists)
		{
			if (validateAlreadyExists)
			{
				int num = base.List.IndexOf(selectedRecord);
				if (num >= 0)
				{
					return num;
				}
			}
			return base.InternalAdd(selectedRecord);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000AC462 File Offset: 0x000AA662
		internal void InternalInsert(int index, global::Infragistics.Windows.DataPresenter.Record selectedRecord)
		{
			if (base.List.Contains(selectedRecord))
			{
				return;
			}
			base.InternalInsert(index, selectedRecord);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000AC47B File Offset: 0x000AA67B
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.Record record)
		{
			base.InternalRemove(record);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000AC484 File Offset: 0x000AA684
		internal void InternalSetList(global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records)
		{
			if (this == records)
			{
				return;
			}
			base.InternalAddRange(records, true);
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x000AC493 File Offset: 0x000AA693
		internal void RemoveAt(int index)
		{
			base.InternalRemoveAt(index);
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x000AC49C File Offset: 0x000AA69C
		internal void Remove(global::Infragistics.Windows.DataPresenter.Record selectedRecord)
		{
			this.InternalRemove(selectedRecord);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000AC4A8 File Offset: 0x000AA6A8
		internal global::Infragistics.Windows.DataPresenter.Record[] ToArray()
		{
			global::Infragistics.Windows.DataPresenter.Record[] array = new global::Infragistics.Windows.DataPresenter.Record[base.Count];
			if (array.Length > 0)
			{
				this.CopyTo(array, 0);
			}
			return array;
		}
	}
}
