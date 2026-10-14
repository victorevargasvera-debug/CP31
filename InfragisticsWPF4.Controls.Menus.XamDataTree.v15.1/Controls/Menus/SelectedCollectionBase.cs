using System;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Menus
{
	// Token: 0x02000035 RID: 53
	public abstract class SelectedCollectionBase<T> : global::Infragistics.Collections.CollectionBase<T> where T : global::Infragistics.ISelectableObject
	{
		// Token: 0x0600021C RID: 540 RVA: 0x00009BA0 File Offset: 0x00007DA0
		public void AddRange(global::Infragistics.Controls.Menus.SelectedCollectionBase<T> items)
		{
			global::Infragistics.Controls.Menus.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			foreach (T item in items)
			{
				if (!item.IsSelected)
				{
					this.InternalAddItemSilently(base.Count, item);
				}
			}
			if (this.Tree != null)
			{
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Tree.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00009C28 File Offset: 0x00007E28
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

		// Token: 0x0600021E RID: 542
		protected abstract void OnSelectionChanged(global::Infragistics.Controls.Menus.SelectedCollectionBase<T> oldCollection, global::Infragistics.Controls.Menus.SelectedCollectionBase<T> newCollection);

		// Token: 0x0600021F RID: 543
		protected abstract global::Infragistics.Controls.Menus.SelectedCollectionBase<T> CreateNewInstance();

		// Token: 0x06000220 RID: 544 RVA: 0x00009CD7 File Offset: 0x00007ED7
		internal void InternalAddItemSilently(int index, T item)
		{
			if (this.Tree != null)
			{
				item.SetSelected(true);
			}
			base.AddItem(index, item);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00009CF8 File Offset: 0x00007EF8
		internal bool InternalRemoveItemSilently(int index)
		{
			T item = this.Items[index];
			if (this.ShiftSelectedItems.Contains(item))
			{
				this.ShiftSelectedItems.Remove(item);
			}
			if (this.Tree != null)
			{
				item.SetSelected(false);
			}
			return base.RemoveItem(index);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00009D4C File Offset: 0x00007F4C
		internal void InternalReplaceItemSilently(int index, T item)
		{
			if (this.Tree != null)
			{
				T t = this.Items[index];
				t.SetSelected(false);
				item.SetSelected(true);
			}
			base.ReplaceItem(index, item);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00009D94 File Offset: 0x00007F94
		internal void InternalResetItemsSilently()
		{
			if (this.Tree != null)
			{
				foreach (T t in this.Items)
				{
					t.SetSelected(false);
				}
			}
			this.ShiftSelectedItems.Clear();
			this.PivotItem = default(T);
			base.ResetItems();
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00009E10 File Offset: 0x00008010
		internal void InternalAddRangeSilently(global::Infragistics.Controls.Menus.SelectedCollectionBase<T> items)
		{
			foreach (T item in items)
			{
				this.InternalAddItemSilently(base.Count, item);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00009E60 File Offset: 0x00008060
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00009E68 File Offset: 0x00008068
		public global::Infragistics.Controls.Menus.XamDataTree Tree { get; protected internal set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00009E71 File Offset: 0x00008071
		protected internal global::System.Collections.ObjectModel.Collection<T> ShiftSelectedItems
		{
			get
			{
				if (this._shiftSelectedItems == null)
				{
					this._shiftSelectedItems = new global::System.Collections.ObjectModel.Collection<T>();
				}
				return this._shiftSelectedItems;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00009E8C File Offset: 0x0000808C
		// (set) Token: 0x06000229 RID: 553 RVA: 0x00009E94 File Offset: 0x00008094
		protected internal T PivotItem { get; set; }

		// Token: 0x0600022A RID: 554 RVA: 0x00009EA0 File Offset: 0x000080A0
		protected override void AddItem(int index, T item)
		{
			if (!item.IsSelected)
			{
				global::Infragistics.Controls.Menus.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
				selectedCollectionBase.InternalAddRangeSilently(this);
				this.InternalAddItemSilently(index, item);
				if (this.Tree != null)
				{
					this.OnSelectionChanged(selectedCollectionBase, this);
					this.Tree.InvalidateScrollPanel(false);
					this.Tree.UpdateSelectedItems();
					this.Tree.SetSelectedDataItemsInternal();
				}
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00009F04 File Offset: 0x00008104
		protected override void InsertItem(int index, T item)
		{
			if (!item.IsSelected)
			{
				global::Infragistics.Controls.Menus.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
				selectedCollectionBase.InternalAddRangeSilently(this);
				this.InternalAddItemSilently(index, item);
				if (this.Tree != null)
				{
					this.OnSelectionChanged(selectedCollectionBase, this);
					this.Tree.InvalidateScrollPanel(false);
					this.Tree.UpdateSelectedItems();
					this.Tree.SetSelectedDataItemsInternal();
				}
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00009F68 File Offset: 0x00008168
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.Controls.Menus.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			bool result = this.InternalRemoveItemSilently(index);
			if (this.Tree != null)
			{
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Tree.InvalidateScrollPanel(false);
				this.Tree.UpdateSelectedItems();
				this.Tree.SetSelectedDataItemsInternal();
			}
			return result;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00009FC0 File Offset: 0x000081C0
		protected override void ReplaceItem(int index, T newItem)
		{
			global::Infragistics.Controls.Menus.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			this.InternalReplaceItemSilently(index, newItem);
			if (this.Tree != null)
			{
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Tree.InvalidateScrollPanel(false);
				this.Tree.UpdateSelectedItems();
				this.Tree.SetSelectedDataItemsInternal();
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000A018 File Offset: 0x00008218
		protected override void ResetItems()
		{
			global::Infragistics.Controls.Menus.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			this.InternalResetItemsSilently();
			if (this.Tree != null)
			{
				this.Tree.UpdateSelectedItems();
				this.Tree.SetSelectedDataItemsInternal();
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Tree.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x040000AD RID: 173
		private global::System.Collections.ObjectModel.Collection<T> _shiftSelectedItems;
	}
}
