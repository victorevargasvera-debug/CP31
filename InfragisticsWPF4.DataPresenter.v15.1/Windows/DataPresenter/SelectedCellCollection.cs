using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200039A RID: 922
	public sealed class SelectedCellCollection : global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase
	{
		// Token: 0x06002C01 RID: 11265 RVA: 0x000C1184 File Offset: 0x000BF384
		internal SelectedCellCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x06002C02 RID: 11266 RVA: 0x000C1190 File Offset: 0x000BF390
		internal override void ResetItemSelectionStates()
		{
			foreach (global::Infragistics.Windows.DataPresenter.Cell cell in this)
			{
				cell.InternalSelect(false);
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002C03 RID: 11267 RVA: 0x000C11D8 File Offset: 0x000BF3D8
		public override bool IsReadOnly
		{
			get
			{
				return base.DataPresenter == null || base.Owner != base.DataPresenter.SelectedItems || this != base.Owner.Cells;
			}
		}

		// Token: 0x06002C04 RID: 11268 RVA: 0x000C1208 File Offset: 0x000BF408
		public void Add(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this.AddRange(new global::Infragistics.Windows.DataPresenter.Cell[]
			{
				cell
			});
		}

		// Token: 0x06002C05 RID: 11269 RVA: 0x000C1228 File Offset: 0x000BF428
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
				if (base.DataPresenter.IsTreeView)
				{
					if (cells[i].DataPresenter != base.DataPresenter)
					{
						throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_33"), "cells");
					}
				}
				else if (cells[i].Record.FieldLayout != fieldLayout)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_32"), "cells");
				}
			}
			if (fieldLayout == null || fieldLayout.DataPresenter != dataPresenter)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_33"), "cells");
			}
			if (base.Count > 0 && fieldLayout != this[0].Record.FieldLayout && !base.DataPresenter.IsTreeView)
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

		// Token: 0x06002C06 RID: 11270 RVA: 0x000C1438 File Offset: 0x000BF638
		public void Clear()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this.IsReadOnly)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_13"));
			}
			dataPresenter.ClearSelectedCells();
		}

		// Token: 0x06002C07 RID: 11271 RVA: 0x000C146B File Offset: 0x000BF66B
		public bool Contains(global::Infragistics.Windows.DataPresenter.Cell item)
		{
			return base.List.Contains(item);
		}

		// Token: 0x06002C08 RID: 11272 RVA: 0x000C1479 File Offset: 0x000BF679
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Cell[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		// Token: 0x06002C09 RID: 11273 RVA: 0x000C1488 File Offset: 0x000BF688
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.SelectedCellCollection.CellEnumerator(((global::System.Collections.IEnumerable)this).GetEnumerator());
		}

		// Token: 0x17000D77 RID: 3447
		public global::Infragistics.Windows.DataPresenter.Cell this[int index]
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Cell)base.List[index];
			}
		}

		// Token: 0x06002C0B RID: 11275 RVA: 0x000C14A8 File Offset: 0x000BF6A8
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Cell selectedCell)
		{
			return this.InternalAdd(selectedCell, true);
		}

		// Token: 0x06002C0C RID: 11276 RVA: 0x000C14B4 File Offset: 0x000BF6B4
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

		// Token: 0x06002C0D RID: 11277 RVA: 0x000C14DE File Offset: 0x000BF6DE
		internal void InternalInsert(int index, global::Infragistics.Windows.DataPresenter.Cell selectedCell)
		{
			if (base.List.Contains(selectedCell))
			{
				return;
			}
			base.InternalInsert(index, selectedCell);
		}

		// Token: 0x06002C0E RID: 11278 RVA: 0x000C14F7 File Offset: 0x000BF6F7
		internal void InternalRemove(global::Infragistics.Windows.DataPresenter.Cell record)
		{
			base.InternalRemove(record);
		}

		// Token: 0x06002C0F RID: 11279 RVA: 0x000C1500 File Offset: 0x000BF700
		internal void InternalSetList(global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells)
		{
			if (this == cells)
			{
				return;
			}
			base.InternalAddRange(cells, true);
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000C150F File Offset: 0x000BF70F
		internal void RemoveAt(int index)
		{
			base.InternalRemoveAt(index);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000C1518 File Offset: 0x000BF718
		internal void Remove(global::Infragistics.Windows.DataPresenter.Cell selectedCell)
		{
			this.InternalRemove(selectedCell);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000C1524 File Offset: 0x000BF724
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

		// Token: 0x06002C13 RID: 11283 RVA: 0x000C1568 File Offset: 0x000BF768
		internal global::Infragistics.Windows.DataPresenter.Cell[] ToArray()
		{
			global::Infragistics.Windows.DataPresenter.Cell[] array = new global::Infragistics.Windows.DataPresenter.Cell[base.Count];
			if (array.Length > 0)
			{
				this.CopyTo(array, 0);
			}
			return array;
		}

		// Token: 0x0200039B RID: 923
		internal class CellEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06002C14 RID: 11284 RVA: 0x000C1590 File Offset: 0x000BF790
			internal CellEnumerator(global::System.Collections.IEnumerator enumerator)
			{
				this._enumerator = enumerator;
			}

			// Token: 0x17000D78 RID: 3448
			// (get) Token: 0x06002C15 RID: 11285 RVA: 0x000C159F File Offset: 0x000BF79F
			public global::Infragistics.Windows.DataPresenter.Cell Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Cell;
				}
			}

			// Token: 0x06002C16 RID: 11286 RVA: 0x000C15B1 File Offset: 0x000BF7B1
			public void Dispose()
			{
			}

			// Token: 0x17000D79 RID: 3449
			// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000C15B3 File Offset: 0x000BF7B3
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this._enumerator.Current;
				}
			}

			// Token: 0x06002C18 RID: 11288 RVA: 0x000C15C0 File Offset: 0x000BF7C0
			public bool MoveNext()
			{
				return this._enumerator.MoveNext();
			}

			// Token: 0x06002C19 RID: 11289 RVA: 0x000C15CD File Offset: 0x000BF7CD
			public void Reset()
			{
				this._enumerator.Reset();
			}

			// Token: 0x17000D7A RID: 3450
			// (get) Token: 0x06002C1A RID: 11290 RVA: 0x000C15DA File Offset: 0x000BF7DA
			global::Infragistics.Windows.DataPresenter.Cell global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Cell>.Current
			{
				get
				{
					return this._enumerator.Current as global::Infragistics.Windows.DataPresenter.Cell;
				}
			}

			// Token: 0x04001517 RID: 5399
			private global::System.Collections.IEnumerator _enumerator;
		}
	}
}
