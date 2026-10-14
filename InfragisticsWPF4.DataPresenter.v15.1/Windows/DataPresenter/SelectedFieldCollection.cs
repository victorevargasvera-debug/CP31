using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200039C RID: 924
	public sealed class SelectedFieldCollection : global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase
	{
		// Token: 0x06002C1B RID: 11291 RVA: 0x000C15EC File Offset: 0x000BF7EC
		internal SelectedFieldCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x000C15F8 File Offset: 0x000BF7F8
		internal override void ResetItemSelectionStates()
		{
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
			{
				field.InternalSelect(false);
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000C1640 File Offset: 0x000BF840
		public override bool IsReadOnly
		{
			get
			{
				return base.DataPresenter == null || base.Owner != base.DataPresenter.SelectedItems || this != base.Owner.Fields;
			}
		}

		// Token: 0x06002C1E RID: 11294 RVA: 0x000C1670 File Offset: 0x000BF870
		public void Add(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.AddRange(new global::Infragistics.Windows.DataPresenter.Field[]
			{
				field
			});
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000C1690 File Offset: 0x000BF890
		public void AddRange(global::Infragistics.Windows.DataPresenter.Field[] fields)
		{
			if (fields.Length <= 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = fields[0].Owner;
			for (int i = 1; i < fields.Length; i++)
			{
				if (fields[i].Owner != owner)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_34"), "fields");
				}
			}
			if (owner == null || owner.DataPresenter != dataPresenter)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_35"), "fields");
			}
			if (base.Count > 0 && owner != this[0].Owner)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_34"), "fields");
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = ((global::Infragistics.Windows.Selection.ISelectionHost)base.DataPresenter).GetSelectionStrategyForItem(fields[0]);
			if (selectionStrategyForItem == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_36"));
			}
			if (!selectionStrategyForItem.IsMultiSelect)
			{
				if (!selectionStrategyForItem.IsSingleSelect)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_24"));
				}
				if (fields.Length + base.Count > 1)
				{
					throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_23"));
				}
			}
			global::System.Collections.Hashtable hashtable = new global::System.Collections.Hashtable();
			object value = new object();
			for (int i = 0; i < base.Count; i++)
			{
				hashtable[this[i]] = value;
			}
			for (int i = 0; i < fields.Length; i++)
			{
				hashtable[fields[i]] = value;
			}
			object[] array = new object[hashtable.Count];
			hashtable.Keys.CopyTo(array, 0);
			global::Infragistics.CoreUtilities.SortMerge(array, new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder.SelectionPositionSortComparer());
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItemHolder = new global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder(base.DataPresenter);
			selectedItemHolder.Fields.InternalAddRange(array);
			selectedItemHolder.Cells.InternalSetList(dataPresenter.SelectedItems.Cells);
			dataPresenter.SelectNewSelection(typeof(global::Infragistics.Windows.DataPresenter.Field), selectedItemHolder);
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000C184C File Offset: 0x000BFA4C
		public void Clear()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this.IsReadOnly)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_13"));
			}
			dataPresenter.ClearSelectedFields();
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000C187F File Offset: 0x000BFA7F
		public bool Contains(global::Infragistics.Windows.DataPresenter.Field item)
		{
			return base.List.Contains(item);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000C188D File Offset: 0x000BFA8D
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Field[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000C189C File Offset: 0x000BFA9C
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.FieldCollection.FieldEnumerator(((global::System.Collections.IEnumerable)this).GetEnumerator());
		}

		// Token: 0x17000D7C RID: 3452
		public global::Infragistics.Windows.DataPresenter.Field this[int index]
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.List[index];
			}
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000C18BC File Offset: 0x000BFABC
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Field selectedField)
		{
			return this.InternalAdd(selectedField, true);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000C18C8 File Offset: 0x000BFAC8
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Field selectedField, bool validateAlreadyExists)
		{
			if (validateAlreadyExists)
			{
				int num = base.List.IndexOf(selectedField);
				if (num >= 0)
				{
					return num;
				}
			}
			return base.InternalAdd(selectedField);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000C18F2 File Offset: 0x000BFAF2
		internal void InternalInsert(int index, global::Infragistics.Windows.DataPresenter.Field selectedField)
		{
			if (base.List.Contains(selectedField))
			{
				return;
			}
			base.InternalInsert(index, selectedField);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000C190B File Offset: 0x000BFB0B
		internal void InternalSetList(global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fields)
		{
			if (this == fields)
			{
				return;
			}
			base.InternalClear();
			base.InternalAddRange(fields);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000C191F File Offset: 0x000BFB1F
		internal void RemoveAt(int index)
		{
			base.InternalRemoveAt(index);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000C1928 File Offset: 0x000BFB28
		internal void Remove(global::Infragistics.Windows.DataPresenter.Field selectedField)
		{
			base.InternalRemove(selectedField);
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000C1934 File Offset: 0x000BFB34
		internal global::Infragistics.Windows.DataPresenter.Field[] ToArray()
		{
			global::Infragistics.Windows.DataPresenter.Field[] array = new global::Infragistics.Windows.DataPresenter.Field[base.Count];
			if (array.Length > 0)
			{
				this.CopyTo(array, 0);
			}
			return array;
		}
	}
}
