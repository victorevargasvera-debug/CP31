using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000399 RID: 921
	public sealed class SelectedRecordCollection : global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase
	{
		// Token: 0x06002BEE RID: 11246 RVA: 0x000C0D1E File Offset: 0x000BEF1E
		internal SelectedRecordCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x06002BEF RID: 11247 RVA: 0x000C0D28 File Offset: 0x000BEF28
		internal override void ResetItemSelectionStates()
		{
			foreach (global::Infragistics.Windows.DataPresenter.Record record in this)
			{
				record.InternalSelect(false);
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002BF0 RID: 11248 RVA: 0x000C0D70 File Offset: 0x000BEF70
		public override bool IsReadOnly
		{
			get
			{
				return base.DataPresenter == null || base.Owner != base.DataPresenter.SelectedItems || this != base.Owner.Records;
			}
		}

		// Token: 0x06002BF1 RID: 11249 RVA: 0x000C0DA0 File Offset: 0x000BEFA0
		public void Add(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this.AddRange(new global::Infragistics.Windows.DataPresenter.Record[]
			{
				record
			});
		}

		// Token: 0x06002BF2 RID: 11250 RVA: 0x000C0DBF File Offset: 0x000BEFBF
		public void AddRange(global::Infragistics.Windows.DataPresenter.Record[] records)
		{
			this.AddRange(records, true, true);
		}

		// Token: 0x06002BF3 RID: 11251 RVA: 0x000C0DCC File Offset: 0x000BEFCC
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

		// Token: 0x06002BF4 RID: 11252 RVA: 0x000C1054 File Offset: 0x000BF254
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

		// Token: 0x06002BF5 RID: 11253 RVA: 0x000C10A4 File Offset: 0x000BF2A4
		public bool Contains(global::Infragistics.Windows.DataPresenter.Record item)
		{
			return base.List.Contains(item);
		}

		// Token: 0x06002BF6 RID: 11254 RVA: 0x000C10B2 File Offset: 0x000BF2B2
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Record[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		// Token: 0x06002BF7 RID: 11255 RVA: 0x000C10C1 File Offset: 0x000BF2C1
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordCollectionBase.RecordEnumerator(((global::System.Collections.IEnumerable)this).GetEnumerator());
		}

		// Token: 0x17000D75 RID: 3445
		public global::Infragistics.Windows.DataPresenter.Record this[int index]
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Record)base.List[index];
			}
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x000C10E1 File Offset: 0x000BF2E1
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Record selectedRecord)
		{
			return this.InternalAdd(selectedRecord, true);
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x000C10EC File Offset: 0x000BF2EC
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

		// Token: 0x06002BFB RID: 11259 RVA: 0x000C1116 File Offset: 0x000BF316
		internal void InternalInsert(int index, global::Infragistics.Windows.DataPresenter.Record selectedRecord)
		{
			if (base.List.Contains(selectedRecord))
			{
				return;
			}
			base.InternalInsert(index, selectedRecord);
		}

		// Token: 0x06002BFC RID: 11260 RVA: 0x000C112F File Offset: 0x000BF32F
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.Record record)
		{
			base.InternalRemove(record);
		}

		// Token: 0x06002BFD RID: 11261 RVA: 0x000C1138 File Offset: 0x000BF338
		internal void InternalSetList(global::Infragistics.Windows.DataPresenter.SelectedRecordCollection records)
		{
			if (this == records)
			{
				return;
			}
			base.InternalAddRange(records, true);
		}

		// Token: 0x06002BFE RID: 11262 RVA: 0x000C1147 File Offset: 0x000BF347
		internal void RemoveAt(int index)
		{
			base.InternalRemoveAt(index);
		}

		// Token: 0x06002BFF RID: 11263 RVA: 0x000C1150 File Offset: 0x000BF350
		internal void Remove(global::Infragistics.Windows.DataPresenter.Record selectedRecord)
		{
			this.InternalRemove(selectedRecord);
		}

		// Token: 0x06002C00 RID: 11264 RVA: 0x000C115C File Offset: 0x000BF35C
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
