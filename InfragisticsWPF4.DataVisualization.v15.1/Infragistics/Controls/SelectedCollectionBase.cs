using System;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics.Controls
{
	// Token: 0x02000052 RID: 82
	public abstract class SelectedCollectionBase<T> : global::Infragistics.Collections.CollectionBase<T> where T : global::Infragistics.ISelectableObject
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x000110EC File Offset: 0x0000F2EC
		public void AddRange(global::Infragistics.Controls.SelectedCollectionBase<T> items)
		{
			if (items.Count == 0)
			{
				return;
			}
			global::Infragistics.Controls.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			foreach (T item in items)
			{
				this.InternalAddItemSilently(base.Count, item);
			}
			this.OnSelectionChanged(selectedCollectionBase, this);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001115C File Offset: 0x0000F35C
		protected internal virtual void SelectItem(T item, bool shiftKey)
		{
			if (shiftKey)
			{
				if (this.ShiftSelectedItems.Count == 0 && this.PivotItem == null)
				{
					this.PivotItem = item;
					if (item.IsSelected)
					{
						this.InternalRemoveItemSilently(this.IndexOf(item));
					}
					this.ShiftSelectedItems.Add(item);
				}
				else if (!item.IsSelected)
				{
					this.ShiftSelectedItems.Add(item);
				}
				else
				{
					this.Items.Remove(item);
				}
			}
			else
			{
				this.ShiftSelectedItems.Clear();
				this.PivotItem = default(T);
			}
			this.InternalAddItemSilently(base.Count, item);
		}

		// Token: 0x06000441 RID: 1089
		protected abstract void OnSelectionChanged(global::Infragistics.Controls.SelectedCollectionBase<T> oldCollection, global::Infragistics.Controls.SelectedCollectionBase<T> newCollection);

		// Token: 0x06000442 RID: 1090
		protected abstract global::Infragistics.Controls.SelectedCollectionBase<T> CreateNewInstance();

		// Token: 0x06000443 RID: 1091 RVA: 0x0001120B File Offset: 0x0000F40B
		internal void InternalAddItemSilently(int index, T item)
		{
			item.SetSelected(true);
			base.AddItem(index, item);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00011224 File Offset: 0x0000F424
		internal bool InternalRemoveItemSilently(int index)
		{
			T item = this.Items[index];
			if (this.ShiftSelectedItems.Contains(item))
			{
				this.ShiftSelectedItems.Remove(item);
			}
			item.SetSelected(false);
			return base.RemoveItem(index);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00011270 File Offset: 0x0000F470
		internal void InternalReplaceItemSilently(int index, T item)
		{
			T t = this.Items[index];
			t.SetSelected(false);
			item.SetSelected(true);
			base.ReplaceItem(index, item);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x000112B0 File Offset: 0x0000F4B0
		internal void InternalResetItemsSilently()
		{
			foreach (T t in this.Items)
			{
				t.SetSelected(false);
			}
			this.ShiftSelectedItems.Clear();
			this.PivotItem = default(T);
			base.ResetItems();
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00011324 File Offset: 0x0000F524
		internal void InternalAddRangeSilently(global::Infragistics.Controls.SelectedCollectionBase<T> items)
		{
			foreach (T item in items)
			{
				this.InternalAddItemSilently(base.Count, item);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x00011374 File Offset: 0x0000F574
		protected internal global::System.Collections.ObjectModel.Collection<T> ShiftSelectedItems
		{
			get
			{
				global::System.Collections.ObjectModel.Collection<T> result;
				if ((result = this._shiftSelectedItems) == null)
				{
					result = (this._shiftSelectedItems = new global::System.Collections.ObjectModel.Collection<T>());
				}
				return result;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00011399 File Offset: 0x0000F599
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000113A1 File Offset: 0x0000F5A1
		protected internal T PivotItem { get; set; }

		// Token: 0x0600044B RID: 1099 RVA: 0x000113AC File Offset: 0x0000F5AC
		protected override void AddItem(int index, T item)
		{
			if (!item.IsSelected)
			{
				global::Infragistics.Controls.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
				selectedCollectionBase.InternalAddRangeSilently(this);
				this.InternalAddItemSilently(index, item);
				this.OnSelectionChanged(selectedCollectionBase, this);
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000113E8 File Offset: 0x0000F5E8
		protected override void InsertItem(int index, T item)
		{
			if (!item.IsSelected)
			{
				global::Infragistics.Controls.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
				selectedCollectionBase.InternalAddRangeSilently(this);
				this.InternalAddItemSilently(index, item);
				this.OnSelectionChanged(selectedCollectionBase, this);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00011424 File Offset: 0x0000F624
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.Controls.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			bool result = this.InternalRemoveItemSilently(index);
			this.OnSelectionChanged(selectedCollectionBase, this);
			return result;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00011450 File Offset: 0x0000F650
		protected override void ReplaceItem(int index, T newItem)
		{
			global::Infragistics.Controls.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			this.InternalReplaceItemSilently(index, newItem);
			this.OnSelectionChanged(selectedCollectionBase, this);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x0001147C File Offset: 0x0000F67C
		protected override void ResetItems()
		{
			global::Infragistics.Controls.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			this.InternalResetItemsSilently();
			this.OnSelectionChanged(selectedCollectionBase, this);
		}

		// Token: 0x0400019D RID: 413
		private global::System.Collections.ObjectModel.Collection<T> _shiftSelectedItems;
	}
}
