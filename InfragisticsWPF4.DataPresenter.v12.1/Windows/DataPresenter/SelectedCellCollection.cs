using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000354 RID: 852
	public sealed class SelectedCellCollection : global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase
	{
		// Token: 0x06002819 RID: 10265 RVA: 0x000AC4D0 File Offset: 0x000AA6D0
		internal SelectedCellCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x000AC4DC File Offset: 0x000AA6DC
		internal override void ResetItemSelectionStates()
		{
			foreach (global::Infragistics.Windows.DataPresenter.Cell cell in this)
			{
				cell.InternalSelect(false);
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000AC524 File Offset: 0x000AA724
		public override bool IsReadOnly
		{
			get
			{
				return base.DataPresenter == null || base.Owner != base.DataPresenter.SelectedItems || this != base.Owner.Cells;
			}
		}

		// Token: 0x0600281C RID: 10268 RVA: 0x000AC554 File Offset: 0x000AA754
		public void Add(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this.AddRange(new global::Infragistics.Windows.DataPresenter.Cell[]
			{
				cell
			});
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x000AC574 File Offset: 0x000AA774
		public void AddRange(global::Infragistics.Windows.DataPresenter.Cell[] cells)
		{
			if (cells.Length <= 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = cells[0].Record.FieldLayout;
			for (int i = 1; i < cells.Length; i++)
			{
				if (cells[i].Record.FieldLayout != fieldLayout)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_32"), "cells");
				}
			}
			if (fieldLayout == null || fieldLayout.DataPresenter != dataPresenter)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_33"), "cells");
			}
			if (base.Count > 0 && fieldLayout != this[0].Record.FieldLayout)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_32"), "cells");
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = ((global::Infragistics.Windows.Selection.ISelectionHost)base.DataPresenter).GetSelectionStrategyForItem(cells[0]);
			if (selectionStrategyForItem == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_20"));
			}
			if (!selectionStrategyForItem.IsMultiSelect)
			{
				if (!selectionStrategyForItem.IsSingleSelect)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_22"));
				}
				if (cells.Length + base.Count > 1)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_21"));
				}
			}
			if (!dataPresenter.ClearSelectedRecords())
			{
				return;
			}
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable();
			object value = new object();
			for (int i = 0; i < base.Count; i++)
			{
				hashtable[this[i]] = value;
			}
			for (int i = 0; i < cells.Length; i++)
			{
				hashtable[cells[i]] = value;
			}
			object[] array = new object[hashtable.Count];
			hashtable.Keys.CopyTo(array, 0);
			global::Infragistics.CoreUtilities.SortMerge(array, new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectionPositionSortComparer());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(base.DataPresenter);
			selectedItemHolder.Cells.InternalAddRange(array);
			selectedItemHolder.Fields.InternalSetList(dataPresenter.SelectedItems.Fields);
			dataPresenter.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Cell), selectedItemHolder);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x000AC748 File Offset: 0x000AA948
		public void Clear()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this.IsReadOnly)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_13"));
			}
			dataPresenter.ClearSelectedCells();
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000AC77B File Offset: 0x000AA97B
		public bool Contains(global::Infragistics.Windows.DataPresenter.Cell item)
		{
			return base.List.Contains(item);
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x000AC789 File Offset: 0x000AA989
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Cell[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x000AC798 File Offset: 0x000AA998
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.SelectedCellCollection.CellEnumerator(((global::System.Collections.IEnumerable)this).GetEnumerator());
		}

		// Token: 0x17000C1F RID: 3103
		public global::Infragistics.Windows.DataPresenter.Cell this[int index]
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Cell)base.List[index];
			}
		}

		// Token: 0x06002823 RID: 10275 RVA: 0x000AC7B8 File Offset: 0x000AA9B8
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Cell selectedCell)
		{
			return this.InternalAdd(selectedCell, true);
		}

		// Token: 0x06002824 RID: 10276 RVA: 0x000AC7C4 File Offset: 0x000AA9C4
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Cell selectedCell, bool validateAlreadyExists)
		{
			if (validateAlreadyExists)
			{
				int num = base.List.IndexOf(selectedCell);
				if (num >= 0)
				{
					return num;
				}
			}
			return base.InternalAdd(selectedCell);
		}

		// Token: 0x06002825 RID: 10277 RVA: 0x000AC7EE File Offset: 0x000AA9EE
		internal void InternalInsert(int index, global::Infragistics.Windows.DataPresenter.Cell selectedCell)
		{
			if (base.List.Contains(selectedCell))
			{
				return;
			}
			base.InternalInsert(index, selectedCell);
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000AC807 File Offset: 0x000AAA07
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.Cell record)
		{
			base.InternalRemove(record);
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000AC810 File Offset: 0x000AAA10
		internal void InternalSetList(global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells)
		{
			if (this == cells)
			{
				return;
			}
			base.InternalAddRange(cells, true);
		}

		// Token: 0x06002828 RID: 10280 RVA: 0x000AC81F File Offset: 0x000AAA1F
		internal void RemoveAt(int index)
		{
			base.InternalRemoveAt(index);
		}

		// Token: 0x06002829 RID: 10281 RVA: 0x000AC828 File Offset: 0x000AAA28
		internal void Remove(global::Infragistics.Windows.DataPresenter.Cell selectedCell)
		{
			this.InternalRemove(selectedCell);
		}

		// Token: 0x0600282A RID: 10282 RVA: 0x000AC834 File Offset: 0x000AAA34
		internal void RemoveCells(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			global::Infragistics.Windows.DataPresenter.CellCollection cellsIfAllocated = record.CellsIfAllocated;
			if (cellsIfAllocated != null)
			{
				int i = 0;
				int count = cellsIfAllocated.Count;
				while (i < count)
				{
					global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = cellsIfAllocated.GetCellIfAllocated(i);
					if (cellIfAllocated != null && cellIfAllocated.IsSelected)
					{
						this.Remove(cellIfAllocated);
					}
					i++;
				}
			}
		}

		// Token: 0x0600282B RID: 10283 RVA: 0x000AC878 File Offset: 0x000AAA78
		internal global::Infragistics.Windows.DataPresenter.Cell[] ToArray()
		{
			global::Infragistics.Windows.DataPresenter.Cell[] array = new global::Infragistics.Windows.DataPresenter.Cell[base.Count];
			if (array.Length > 0)
			{
				this.CopyTo(array, 0);
			}
			return array;
		}

		// Token: 0x02000355 RID: 853
		internal class CellEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600282C RID: 10284 RVA: 0x000AC8A0 File Offset: 0x000AAAA0
			internal CellEnumerator(global::System.Collections.IEnumerator enumerator)
			{
				this._enumerator = enumerator;
			}

			// Token: 0x17000C20 RID: 3104
			// (get) Token: 0x0600282D RID: 10285 RVA: 0x000AC8AF File Offset: 0x000AAAAF
			public global::Infragistics.Windows.DataPresenter.Cell Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Cell;
				}
			}

			// Token: 0x0600282E RID: 10286 RVA: 0x000AC8C1 File Offset: 0x000AAAC1
			public void Dispose()
			{
			}

			// Token: 0x17000C21 RID: 3105
			// (get) Token: 0x0600282F RID: 10287 RVA: 0x000AC8C3 File Offset: 0x000AAAC3
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x06002830 RID: 10288 RVA: 0x000AC8D0 File Offset: 0x000AAAD0
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x06002831 RID: 10289 RVA: 0x000AC8DD File Offset: 0x000AAADD
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x17000C22 RID: 3106
			// (get) Token: 0x06002832 RID: 10290 RVA: 0x000AC8EA File Offset: 0x000AAAEA
			global::Infragistics.Windows.DataPresenter.Cell global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell>.Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Cell;
				}
			}

			// Token: 0x040012EE RID: 4846
			private global::System.Collections.IEnumerator _enumerator;
		}
	}
}
