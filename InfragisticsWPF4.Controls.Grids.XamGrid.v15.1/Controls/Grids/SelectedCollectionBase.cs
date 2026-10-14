using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000128 RID: 296
	public abstract class SelectedCollectionBase<T> : global::Infragistics.Collections.CollectionBase<T> where T : global::Infragistics.ISelectableObject
	{
		// Token: 0x060009BC RID: 2492 RVA: 0x00025DB8 File Offset: 0x00023FB8
		public void AddRange(global::Infragistics.Controls.Grids.SelectedCollectionBase<T> items)
		{
			global::Infragistics.Controls.Grids.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			foreach (T item in items)
			{
				if (!item.IsSelected)
				{
					this.InternalAddItemSilently(base.Count, item, false);
				}
			}
			if (this.Grid != null)
			{
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00025E40 File Offset: 0x00024040
		protected internal virtual void SelectItem(T item, bool shiftKey)
		{
			if (shiftKey)
			{
				if (this.ShiftSelectedItems.Count == 0 && this.PivotItem == null)
				{
					this.PivotItem = item;
					if (item.IsSelected)
					{
						int num = this.IndexOf(item);
						if (num != -1)
						{
							this.InternalRemoveItemSilently(num);
						}
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
					this._nonShiftSelectedItems.Add(item);
				}
			}
			else
			{
				foreach (T item2 in this.ShiftSelectedItems)
				{
					this._nonShiftSelectedItems.Add(item2);
				}
				this.ShiftSelectedItems.Clear();
				this.PivotItem = default(T);
			}
			this.InternalAddItemSilently(base.Count, item, shiftKey);
		}

		// Token: 0x060009BE RID: 2494
		protected abstract void OnSelectionChanged(global::Infragistics.Controls.Grids.SelectedCollectionBase<T> oldCollection, global::Infragistics.Controls.Grids.SelectedCollectionBase<T> newCollection);

		// Token: 0x060009BF RID: 2495
		protected abstract global::Infragistics.Controls.Grids.SelectedCollectionBase<T> CreateNewInstance();

		// Token: 0x060009C0 RID: 2496 RVA: 0x00025F50 File Offset: 0x00024150
		internal void InternalAddItemSilently(int index, T item)
		{
			if (this.Grid != null)
			{
				item.SetSelected(true);
			}
			base.AddItem(index, item);
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00025F70 File Offset: 0x00024170
		internal bool InternalRemoveItemSilently(int index)
		{
			T item = this.Items[index];
			if (this.ShiftSelectedItems.Contains(item))
			{
				this.ShiftSelectedItems.Remove(item);
			}
			if (this._nonShiftSelectedItems.Contains(item))
			{
				this._nonShiftSelectedItems.Remove(item);
			}
			if (this.Grid != null)
			{
				item.SetSelected(false);
			}
			return base.RemoveItem(index);
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x00025FE0 File Offset: 0x000241E0
		internal void InternalReplaceItemSilently(int index, T item)
		{
			if (this.Grid != null)
			{
				T t = this.Items[index];
				t.SetSelected(false);
				item.SetSelected(true);
			}
			base.ReplaceItem(index, item);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00026028 File Offset: 0x00024228
		internal void InternalResetItemsSilently()
		{
			if (this.Grid != null)
			{
				foreach (T t in this.Items)
				{
					t.SetSelected(false);
				}
			}
			this.ShiftSelectedItems.Clear();
			this._nonShiftSelectedItems.Clear();
			this.PivotItem = default(T);
			base.ResetItems();
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000260B0 File Offset: 0x000242B0
		internal void InternalAddRangeSilently(global::Infragistics.Controls.Grids.SelectedCollectionBase<T> items)
		{
			foreach (T item in items)
			{
				this.InternalAddItemSilently(base.Count, item, false);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00026100 File Offset: 0x00024300
		internal void InternalAddItemSilently(int index, T item, bool isShiftSelected)
		{
			this.InternalAddItemSilently(index, item);
			if (!isShiftSelected)
			{
				this._nonShiftSelectedItems.Add(item);
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x0002611C File Offset: 0x0002431C
		internal void UnselectShiftSelectedItems()
		{
			int count = base.Count;
			int count2 = this.ShiftSelectedItems.Count;
			int num = count - count2;
			if (num < count2)
			{
				global::System.Collections.Generic.List<T> list = new global::System.Collections.Generic.List<T>(this._nonShiftSelectedItems);
				this.InternalResetItemsSilently();
				using (global::System.Collections.Generic.List<T>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						T item = enumerator.Current;
						this.InternalAddItemSilently(base.Count, item, false);
					}
					return;
				}
			}
			for (int i = count2 - 1; i >= 0; i--)
			{
				int index = this.IndexOf(this.ShiftSelectedItems[i]);
				this.InternalRemoveItemSilently(index);
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x000261D4 File Offset: 0x000243D4
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x000261DC File Offset: 0x000243DC
		public global::Infragistics.Controls.Grids.XamGrid Grid { get; protected internal set; }

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x000261E5 File Offset: 0x000243E5
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

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060009CA RID: 2506 RVA: 0x00026200 File Offset: 0x00024400
		// (set) Token: 0x060009CB RID: 2507 RVA: 0x00026208 File Offset: 0x00024408
		protected internal T PivotItem { get; set; }

		// Token: 0x060009CC RID: 2508 RVA: 0x00026214 File Offset: 0x00024414
		protected override void AddItem(int index, T item)
		{
			if (!item.IsSelected)
			{
				global::Infragistics.Controls.Grids.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
				selectedCollectionBase.InternalAddRangeSilently(this);
				this.InternalAddItemSilently(index, item, false);
				if (this.Grid != null)
				{
					this.OnSelectionChanged(selectedCollectionBase, this);
					this.Grid.InvalidateScrollPanel(false);
				}
			}
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x00026264 File Offset: 0x00024464
		protected override void InsertItem(int index, T item)
		{
			if (!item.IsSelected)
			{
				global::Infragistics.Controls.Grids.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
				selectedCollectionBase.InternalAddRangeSilently(this);
				this.InternalAddItemSilently(index, item, false);
				if (this.Grid != null)
				{
					this.OnSelectionChanged(selectedCollectionBase, this);
					this.Grid.InvalidateScrollPanel(false);
				}
			}
		}

		// Token: 0x060009CE RID: 2510 RVA: 0x000262B4 File Offset: 0x000244B4
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.Controls.Grids.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			bool result = this.InternalRemoveItemSilently(index);
			if (this.Grid != null)
			{
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Grid.InvalidateScrollPanel(false);
			}
			return result;
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x000262F4 File Offset: 0x000244F4
		protected override void ReplaceItem(int index, T newItem)
		{
			global::Infragistics.Controls.Grids.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			this.InternalReplaceItemSilently(index, newItem);
			if (this.Grid != null)
			{
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00026334 File Offset: 0x00024534
		protected override void ResetItems()
		{
			global::Infragistics.Controls.Grids.SelectedCollectionBase<T> selectedCollectionBase = this.CreateNewInstance();
			selectedCollectionBase.InternalAddRangeSilently(this);
			this.InternalResetItemsSilently();
			if (this.Grid != null)
			{
				this.OnSelectionChanged(selectedCollectionBase, this);
				this.Grid.InvalidateScrollPanel(false);
			}
		}

		// Token: 0x04000266 RID: 614
		private global::System.Collections.ObjectModel.Collection<T> _shiftSelectedItems;

		// Token: 0x04000267 RID: 615
		private global::System.Collections.ObjectModel.Collection<T> _nonShiftSelectedItems = new global::System.Collections.ObjectModel.Collection<T>();
	}
}
