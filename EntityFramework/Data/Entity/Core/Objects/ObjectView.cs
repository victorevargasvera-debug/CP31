using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000426 RID: 1062
	internal class ObjectView<TElement> : global::System.ComponentModel.IBindingList, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.ComponentModel.ICancelAddNew, global::System.Data.Entity.Core.Objects.IObjectView
	{
		// Token: 0x060033A7 RID: 13223 RVA: 0x000A5EA9 File Offset: 0x000A40A9
		internal ObjectView(global::System.Data.Entity.Core.Objects.IObjectViewData<TElement> viewData, object eventDataSource)
		{
			this._viewData = viewData;
			this._listener = new global::System.Data.Entity.Core.Objects.ObjectViewListener(this, (global::System.Collections.IList)this._viewData.List, eventDataSource);
		}

		// Token: 0x060033A8 RID: 13224 RVA: 0x000A5EDC File Offset: 0x000A40DC
		private void EnsureWritableList()
		{
			if (((global::System.Collections.IList)this).IsReadOnly)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectView_WriteOperationNotAllowedOnReadOnlyBindingList);
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x000A5EF1 File Offset: 0x000A40F1
		private static bool IsElementTypeAbstract
		{
			get
			{
				return typeof(TElement).IsAbstract();
			}
		}

		// Token: 0x060033AA RID: 13226 RVA: 0x000A5F04 File Offset: 0x000A4104
		void global::System.ComponentModel.ICancelAddNew.CancelNew(int itemIndex)
		{
			if (this._addNewIndex >= 0 && itemIndex == this._addNewIndex)
			{
				TElement telement = this._viewData.List[this._addNewIndex];
				this._listener.UnregisterEntityEvents(telement);
				int addNewIndex = this._addNewIndex;
				this._addNewIndex = -1;
				try
				{
					this._suspendEvent = true;
					this._viewData.Remove(telement, true);
				}
				finally
				{
					this._suspendEvent = false;
				}
				this.OnListChanged(global::System.ComponentModel.ListChangedType.ItemDeleted, addNewIndex, -1);
			}
		}

		// Token: 0x060033AB RID: 13227 RVA: 0x000A5F94 File Offset: 0x000A4194
		void global::System.ComponentModel.ICancelAddNew.EndNew(int itemIndex)
		{
			if (this._addNewIndex >= 0 && itemIndex == this._addNewIndex)
			{
				this._viewData.CommitItemAt(this._addNewIndex);
				this._addNewIndex = -1;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		bool global::System.ComponentModel.IBindingList.AllowNew
		{
			get
			{
				return this._viewData.AllowNew && !global::System.Data.Entity.Core.Objects.ObjectView<TElement>.IsElementTypeAbstract;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x060033AD RID: 13229 RVA: 0x000A5FD9 File Offset: 0x000A41D9
		bool global::System.ComponentModel.IBindingList.AllowEdit
		{
			get
			{
				return this._viewData.AllowEdit;
			}
		}

		// Token: 0x060033AE RID: 13230 RVA: 0x000A5FE8 File Offset: 0x000A41E8
		object global::System.ComponentModel.IBindingList.AddNew()
		{
			this.EnsureWritableList();
			if (global::System.Data.Entity.Core.Objects.ObjectView<TElement>.IsElementTypeAbstract)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectView_AddNewOperationNotAllowedOnAbstractBindingList);
			}
			this._viewData.EnsureCanAddNew();
			((global::System.ComponentModel.ICancelAddNew)this).EndNew(this._addNewIndex);
			TElement telement = (TElement)((object)global::System.Activator.CreateInstance(typeof(TElement)));
			this._addNewIndex = this._viewData.Add(telement, true);
			this._listener.RegisterEntityEvents(telement);
			this.OnListChanged(global::System.ComponentModel.ListChangedType.ItemAdded, this._addNewIndex, -1);
			return telement;
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x000A6071 File Offset: 0x000A4271
		bool global::System.ComponentModel.IBindingList.AllowRemove
		{
			get
			{
				return this._viewData.AllowRemove;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x060033B0 RID: 13232 RVA: 0x000A607E File Offset: 0x000A427E
		bool global::System.ComponentModel.IBindingList.SupportsChangeNotification
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x000A6081 File Offset: 0x000A4281
		bool global::System.ComponentModel.IBindingList.SupportsSearching
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x000A6084 File Offset: 0x000A4284
		bool global::System.ComponentModel.IBindingList.SupportsSorting
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x060033B3 RID: 13235 RVA: 0x000A6087 File Offset: 0x000A4287
		bool global::System.ComponentModel.IBindingList.IsSorted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x000A608A File Offset: 0x000A428A
		global::System.ComponentModel.PropertyDescriptor global::System.ComponentModel.IBindingList.SortProperty
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000A6091 File Offset: 0x000A4291
		global::System.ComponentModel.ListSortDirection global::System.ComponentModel.IBindingList.SortDirection
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060033B6 RID: 13238 RVA: 0x000A6098 File Offset: 0x000A4298
		// (remove) Token: 0x060033B7 RID: 13239 RVA: 0x000A60B1 File Offset: 0x000A42B1
		public event global::System.ComponentModel.ListChangedEventHandler ListChanged
		{
			add
			{
				this.onListChanged = (global::System.ComponentModel.ListChangedEventHandler)global::System.Delegate.Combine(this.onListChanged, value);
			}
			remove
			{
				this.onListChanged = (global::System.ComponentModel.ListChangedEventHandler)global::System.Delegate.Remove(this.onListChanged, value);
			}
		}

		// Token: 0x060033B8 RID: 13240 RVA: 0x000A60CA File Offset: 0x000A42CA
		void global::System.ComponentModel.IBindingList.AddIndex(global::System.ComponentModel.PropertyDescriptor property)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060033B9 RID: 13241 RVA: 0x000A60D1 File Offset: 0x000A42D1
		void global::System.ComponentModel.IBindingList.ApplySort(global::System.ComponentModel.PropertyDescriptor property, global::System.ComponentModel.ListSortDirection direction)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060033BA RID: 13242 RVA: 0x000A60D8 File Offset: 0x000A42D8
		int global::System.ComponentModel.IBindingList.Find(global::System.ComponentModel.PropertyDescriptor property, object key)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x000A60DF File Offset: 0x000A42DF
		void global::System.ComponentModel.IBindingList.RemoveIndex(global::System.ComponentModel.PropertyDescriptor property)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x000A60E6 File Offset: 0x000A42E6
		void global::System.ComponentModel.IBindingList.RemoveSort()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170009F6 RID: 2550
		public TElement this[int index]
		{
			get
			{
				return this._viewData.List[index];
			}
			set
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectView_CannotReplacetheEntityorRow);
			}
		}

		// Token: 0x170009F7 RID: 2551
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this._viewData.List[index];
			}
			set
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ObjectView_CannotReplacetheEntityorRow);
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060033C1 RID: 13249 RVA: 0x000A6130 File Offset: 0x000A4330
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return !this._viewData.AllowNew && !this._viewData.AllowRemove;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060033C2 RID: 13250 RVA: 0x000A614F File Offset: 0x000A434F
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060033C3 RID: 13251 RVA: 0x000A6154 File Offset: 0x000A4354
		int global::System.Collections.IList.Add(object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			this.EnsureWritableList();
			if (!(value is TElement))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectView_IncompatibleArgument);
			}
			((global::System.ComponentModel.ICancelAddNew)this).EndNew(this._addNewIndex);
			int num = ((global::System.Collections.IList)this).IndexOf(value);
			if (num == -1)
			{
				num = this._viewData.Add((TElement)((object)value), false);
				if (!this._viewData.FiresEventOnAdd)
				{
					this._listener.RegisterEntityEvents(value);
					this.OnListChanged(global::System.ComponentModel.ListChangedType.ItemAdded, num, -1);
				}
			}
			return num;
		}

		// Token: 0x060033C4 RID: 13252 RVA: 0x000A61D4 File Offset: 0x000A43D4
		void global::System.Collections.IList.Clear()
		{
			this.EnsureWritableList();
			((global::System.ComponentModel.ICancelAddNew)this).EndNew(this._addNewIndex);
			if (this._viewData.FiresEventOnClear)
			{
				this._viewData.Clear();
				return;
			}
			try
			{
				this._suspendEvent = true;
				this._viewData.Clear();
			}
			finally
			{
				this._suspendEvent = false;
			}
			this.OnListChanged(global::System.ComponentModel.ListChangedType.Reset, -1, -1);
		}

		// Token: 0x060033C5 RID: 13253 RVA: 0x000A6244 File Offset: 0x000A4444
		bool global::System.Collections.IList.Contains(object value)
		{
			return value is TElement && this._viewData.List.Contains((TElement)((object)value));
		}

		// Token: 0x060033C6 RID: 13254 RVA: 0x000A6278 File Offset: 0x000A4478
		int global::System.Collections.IList.IndexOf(object value)
		{
			int result;
			if (value is TElement)
			{
				result = this._viewData.List.IndexOf((TElement)((object)value));
			}
			else
			{
				result = -1;
			}
			return result;
		}

		// Token: 0x060033C7 RID: 13255 RVA: 0x000A62A9 File Offset: 0x000A44A9
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ObjectView_IndexBasedInsertIsNotSupported);
		}

		// Token: 0x060033C8 RID: 13256 RVA: 0x000A62B8 File Offset: 0x000A44B8
		void global::System.Collections.IList.Remove(object value)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value");
			this.EnsureWritableList();
			if (!(value is TElement))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ObjectView_IncompatibleArgument);
			}
			((global::System.ComponentModel.ICancelAddNew)this).EndNew(this._addNewIndex);
			TElement telement = (TElement)((object)value);
			int newIndex = this._viewData.List.IndexOf(telement);
			if (this._viewData.Remove(telement, false) && !this._viewData.FiresEventOnRemove)
			{
				this._listener.UnregisterEntityEvents(telement);
				this.OnListChanged(global::System.ComponentModel.ListChangedType.ItemDeleted, newIndex, -1);
			}
		}

		// Token: 0x060033C9 RID: 13257 RVA: 0x000A6345 File Offset: 0x000A4545
		void global::System.Collections.IList.RemoveAt(int index)
		{
			((global::System.Collections.IList)this).Remove(((global::System.Collections.IList)this)[index]);
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060033CA RID: 13258 RVA: 0x000A6354 File Offset: 0x000A4554
		public int Count
		{
			get
			{
				return this._viewData.List.Count;
			}
		}

		// Token: 0x060033CB RID: 13259 RVA: 0x000A6366 File Offset: 0x000A4566
		public void CopyTo(global::System.Array array, int index)
		{
			((global::System.Collections.IList)this._viewData.List).CopyTo(array, index);
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x000A637F File Offset: 0x000A457F
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x000A6382 File Offset: 0x000A4582
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060033CE RID: 13262 RVA: 0x000A6385 File Offset: 0x000A4585
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._viewData.List.GetEnumerator();
		}

		// Token: 0x060033CF RID: 13263 RVA: 0x000A6398 File Offset: 0x000A4598
		private void OnListChanged(global::System.ComponentModel.ListChangedType listchangedType, int newIndex, int oldIndex)
		{
			global::System.ComponentModel.ListChangedEventArgs changeArgs = new global::System.ComponentModel.ListChangedEventArgs(listchangedType, newIndex, oldIndex);
			this.OnListChanged(changeArgs);
		}

		// Token: 0x060033D0 RID: 13264 RVA: 0x000A63B5 File Offset: 0x000A45B5
		private void OnListChanged(global::System.ComponentModel.ListChangedEventArgs changeArgs)
		{
			if (this.onListChanged != null && !this._suspendEvent)
			{
				this.onListChanged(this, changeArgs);
			}
		}

		// Token: 0x060033D1 RID: 13265 RVA: 0x000A63D4 File Offset: 0x000A45D4
		void global::System.Data.Entity.Core.Objects.IObjectView.EntityPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int num = ((global::System.Collections.IList)this).IndexOf((TElement)((object)sender));
			this.OnListChanged(global::System.ComponentModel.ListChangedType.ItemChanged, num, num);
		}

		// Token: 0x060033D2 RID: 13266 RVA: 0x000A63FC File Offset: 0x000A45FC
		void global::System.Data.Entity.Core.Objects.IObjectView.CollectionChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e)
		{
			TElement telement = default(TElement);
			if (this._addNewIndex >= 0)
			{
				telement = this[this._addNewIndex];
			}
			global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs = this._viewData.OnCollectionChanged(sender, e, this._listener);
			if (this._addNewIndex >= 0)
			{
				if (this._addNewIndex >= this.Count)
				{
					this._addNewIndex = ((global::System.Collections.IList)this).IndexOf(telement);
				}
				else
				{
					TElement telement2 = this[this._addNewIndex];
					if (!telement2.Equals(telement))
					{
						this._addNewIndex = ((global::System.Collections.IList)this).IndexOf(telement);
					}
				}
			}
			if (listChangedEventArgs != null)
			{
				this.OnListChanged(listChangedEventArgs);
			}
		}

		// Token: 0x040010BB RID: 4283
		private bool _suspendEvent;

		// Token: 0x040010BC RID: 4284
		private global::System.ComponentModel.ListChangedEventHandler onListChanged;

		// Token: 0x040010BD RID: 4285
		private readonly global::System.Data.Entity.Core.Objects.ObjectViewListener _listener;

		// Token: 0x040010BE RID: 4286
		private int _addNewIndex = -1;

		// Token: 0x040010BF RID: 4287
		private readonly global::System.Data.Entity.Core.Objects.IObjectViewData<TElement> _viewData;
	}
}
