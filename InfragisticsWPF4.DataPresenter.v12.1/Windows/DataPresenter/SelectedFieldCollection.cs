using System;
using System.Collections;
using System.Collections.Generic;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000356 RID: 854
	public sealed class SelectedFieldCollection : global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase
	{
		// Token: 0x06002833 RID: 10291 RVA: 0x000AC8FC File Offset: 0x000AAAFC
		internal SelectedFieldCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter) : base(dataPresenter)
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000AC908 File Offset: 0x000AAB08
		internal override void ResetItemSelectionStates()
		{
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this)
			{
				field.InternalSelect(false);
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000AC950 File Offset: 0x000AAB50
		public override bool IsReadOnly
		{
			get
			{
				return base.DataPresenter == null || base.Owner != base.DataPresenter.SelectedItems || this != base.Owner.Fields;
			}
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x000AC980 File Offset: 0x000AAB80
		public void Add(global::Infragistics.Windows.DataPresenter.Field field)
		{
			this.AddRange(new global::Infragistics.Windows.DataPresenter.Field[]
			{
				field
			});
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x000AC9A0 File Offset: 0x000AABA0
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

		// Token: 0x06002838 RID: 10296 RVA: 0x000ACB5C File Offset: 0x000AAD5C
		public void Clear()
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (this.IsReadOnly)
			{
				throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_13"));
			}
			dataPresenter.ClearSelectedFields();
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x000ACB8F File Offset: 0x000AAD8F
		public bool Contains(global::Infragistics.Windows.DataPresenter.Field item)
		{
			return base.List.Contains(item);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000ACB9D File Offset: 0x000AAD9D
		public void CopyTo(global::Infragistics.Windows.DataPresenter.Field[] array, int index)
		{
			base.List.CopyTo(array, index);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000ACBAC File Offset: 0x000AADAC
		public global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Field> GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.FieldCollection.FieldEnumerator(((global::System.Collections.IEnumerable)this).GetEnumerator());
		}

		// Token: 0x17000C24 RID: 3108
		public global::Infragistics.Windows.DataPresenter.Field this[int index]
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.Field)base.List[index];
			}
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000ACBCC File Offset: 0x000AADCC
		internal int InternalAdd(global::Infragistics.Windows.DataPresenter.Field selectedField)
		{
			return this.InternalAdd(selectedField, true);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x000ACBD8 File Offset: 0x000AADD8
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

		// Token: 0x0600283F RID: 10303 RVA: 0x000ACC02 File Offset: 0x000AAE02
		internal void InternalInsert(int index, global::Infragistics.Windows.DataPresenter.Field selectedField)
		{
			if (base.List.Contains(selectedField))
			{
				return;
			}
			base.InternalInsert(index, selectedField);
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000ACC1B File Offset: 0x000AAE1B
		internal void InternalSetList(global::Infragistics.Windows.DataPresenter.SelectedFieldCollection fields)
		{
			if (this == fields)
			{
				return;
			}
			base.InternalClear();
			base.InternalAddRange(fields);
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000ACC2F File Offset: 0x000AAE2F
		internal void RemoveAt(int index)
		{
			base.InternalRemoveAt(index);
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x000ACC38 File Offset: 0x000AAE38
		internal void Remove(global::Infragistics.Windows.DataPresenter.Field selectedField)
		{
			base.InternalRemove(selectedField);
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000ACC44 File Offset: 0x000AAE44
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
