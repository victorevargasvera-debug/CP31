using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevAge.ComponentModel
{
	// Token: 0x0200030C RID: 780
	internal abstract class BoundListBase<T> : global::DevAge.ComponentModel.IBoundList
	{
		// Token: 0x0600253D RID: 9533 RVA: 0x00082460 File Offset: 0x00080660
		public int BeginAddNew()
		{
			if (this.mEditItem != null)
			{
				throw new global::DevAge.DevAgeApplicationException("There is already a row in editing state, call EndEdit first");
			}
			this.mEditItem = this.OnAddNew();
			this.mEditIndex = this.Count - 1;
			this.mAdding = true;
			this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemAdded, this.mEditIndex));
			return this.mEditIndex;
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000824C8 File Offset: 0x000806C8
		public void BeginEdit(int index)
		{
			if (this.mEditItem != null)
			{
				throw new global::DevAge.DevAgeApplicationException("There is already a row in editing state, call EndEdit first");
			}
			this.mEditItem = (T)((object)this[index]);
			this.mEditIndex = index;
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00082500 File Offset: 0x00080700
		public void EndEdit(bool cancel)
		{
			if (this.mEditItem == null)
			{
				return;
			}
			if (cancel)
			{
				if (this.mAdding)
				{
					this.RemoveAt(this.mEditIndex);
					goto IL_E4;
				}
				using (global::System.Collections.Generic.Dictionary<global::System.ComponentModel.PropertyDescriptor, object>.Enumerator enumerator = this.mPreviousValues.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::System.Collections.Generic.KeyValuePair<global::System.ComponentModel.PropertyDescriptor, object> keyValuePair = enumerator.Current;
						keyValuePair.Key.SetValue(this.mEditItem, keyValuePair.Value);
					}
					goto IL_E4;
				}
			}
			if (this.mAdding)
			{
				this.mAddedItems.Add(this.mEditItem);
			}
			else if (!this.mEditedItems.Contains(this.mEditItem) && !this.mAddedItems.Contains(this.mEditItem))
			{
				this.mEditedItems.Add(this.mEditItem);
			}
			IL_E4:
			this.mEditItem = default(T);
			this.mAdding = false;
			this.mEditIndex = -1;
			this.mPreviousValues.Clear();
			this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.Reset, -1));
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06002540 RID: 9536 RVA: 0x00082634 File Offset: 0x00080834
		public object EditedObject
		{
			get
			{
				return this.mEditItem;
			}
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x00082644 File Offset: 0x00080844
		public void RemoveAt(int index)
		{
			T item = (T)((object)this[index]);
			this.OnRemoveAt(index);
			if (this.mAddedItems.Contains(item))
			{
				this.mAddedItems.Remove(item);
			}
			else
			{
				if (this.mEditedItems.Contains(item))
				{
					this.mEditedItems.Remove(item);
				}
				this.mRemovedItems.Add(item);
			}
			this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemDeleted, index));
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000826C4 File Offset: 0x000808C4
		public global::System.ComponentModel.PropertyDescriptorCollection GetItemProperties()
		{
			return global::System.ComponentModel.TypeDescriptor.GetProperties(typeof(T));
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000826D8 File Offset: 0x000808D8
		public object GetItemValue(int index, global::System.ComponentModel.PropertyDescriptor property)
		{
			return property.GetValue(this[index]);
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000826E8 File Offset: 0x000808E8
		public void SetEditValue(global::System.ComponentModel.PropertyDescriptor property, object value)
		{
			if (this.mEditItem == null)
			{
				throw new global::DevAge.DevAgeApplicationException("There isn't a row in editing state, call BeginAddNew or BeginEdit first");
			}
			if (!this.mPreviousValues.ContainsKey(property))
			{
				this.mPreviousValues.Add(property, property.GetValue(this.mEditItem));
			}
			property.SetValue(this.mEditItem, value);
			this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemChanged, this.mEditIndex, property));
		}

		// Token: 0x17000B97 RID: 2967
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x00082768 File Offset: 0x00080968
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x00082770 File Offset: 0x00080970
		public bool AllowEdit
		{
			get
			{
				return this.mAllowEdit;
			}
			set
			{
				this.mAllowEdit = value;
			}
		}

		// Token: 0x17000B98 RID: 2968
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x0008277C File Offset: 0x0008097C
		// (set) Token: 0x06002548 RID: 9544 RVA: 0x00082784 File Offset: 0x00080984
		public bool AllowNew
		{
			get
			{
				return this.mAllowNew;
			}
			set
			{
				this.mAllowNew = value;
			}
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00082790 File Offset: 0x00080990
		// (set) Token: 0x0600254A RID: 9546 RVA: 0x00082798 File Offset: 0x00080998
		public bool AllowDelete
		{
			get
			{
				return this.mAllowDelete;
			}
			set
			{
				this.mAllowDelete = value;
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x0600254B RID: 9547 RVA: 0x000827A4 File Offset: 0x000809A4
		// (set) Token: 0x0600254C RID: 9548 RVA: 0x000827AC File Offset: 0x000809AC
		public bool AllowSort
		{
			get
			{
				return this.mAllowSort;
			}
			set
			{
				this.mAllowSort = value;
			}
		}

		// Token: 0x17000B9B RID: 2971
		// (get) Token: 0x0600254D RID: 9549 RVA: 0x000827B8 File Offset: 0x000809B8
		public global::System.Collections.Generic.List<T> AddedItems
		{
			get
			{
				return this.mAddedItems;
			}
		}

		// Token: 0x17000B9C RID: 2972
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x000827C0 File Offset: 0x000809C0
		public global::System.Collections.Generic.List<T> RemovedItems
		{
			get
			{
				return this.mRemovedItems;
			}
		}

		// Token: 0x17000B9D RID: 2973
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x000827C8 File Offset: 0x000809C8
		public global::System.Collections.Generic.List<T> EditedItems
		{
			get
			{
				return this.mEditedItems;
			}
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000827D0 File Offset: 0x000809D0
		public global::System.ComponentModel.PropertyDescriptor GetItemProperty(string name, global::System.StringComparison comparison)
		{
			foreach (object obj in this.GetItemProperties())
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = (global::System.ComponentModel.PropertyDescriptor)obj;
				if (propertyDescriptor.Name.Equals(name, comparison))
				{
					return propertyDescriptor;
				}
			}
			return null;
		}

		// Token: 0x1400009D RID: 157
		// (add) Token: 0x06002551 RID: 9553 RVA: 0x00082848 File Offset: 0x00080A48
		// (remove) Token: 0x06002552 RID: 9554 RVA: 0x00082864 File Offset: 0x00080A64
		public event global::System.ComponentModel.ListChangedEventHandler ListChanged;

		// Token: 0x06002553 RID: 9555 RVA: 0x00082880 File Offset: 0x00080A80
		protected virtual void OnListChanged(global::System.ComponentModel.ListChangedEventArgs e)
		{
			if (this.ListChanged != null)
			{
				this.ListChanged(this, e);
			}
		}

		// Token: 0x06002554 RID: 9556
		protected abstract T OnAddNew();

		// Token: 0x06002555 RID: 9557
		public abstract int IndexOf(object item);

		// Token: 0x06002556 RID: 9558
		protected abstract void OnRemoveAt(int index);

		// Token: 0x17000B9E RID: 2974
		public abstract object this[int index]
		{
			get;
		}

		// Token: 0x17000B9F RID: 2975
		// (get) Token: 0x06002558 RID: 9560
		public abstract int Count { get; }

		// Token: 0x06002559 RID: 9561
		public abstract void ApplySort(global::System.ComponentModel.ListSortDescriptionCollection sorts);

		// Token: 0x04000CFC RID: 3324
		private int mEditIndex;

		// Token: 0x04000CFD RID: 3325
		private T mEditItem;

		// Token: 0x04000CFE RID: 3326
		private bool mAdding;

		// Token: 0x04000CFF RID: 3327
		private global::System.Collections.Generic.Dictionary<global::System.ComponentModel.PropertyDescriptor, object> mPreviousValues = new global::System.Collections.Generic.Dictionary<global::System.ComponentModel.PropertyDescriptor, object>();

		// Token: 0x04000D00 RID: 3328
		private bool mAllowEdit;

		// Token: 0x04000D01 RID: 3329
		private bool mAllowNew;

		// Token: 0x04000D02 RID: 3330
		private bool mAllowDelete;

		// Token: 0x04000D03 RID: 3331
		private bool mAllowSort;

		// Token: 0x04000D04 RID: 3332
		private global::System.Collections.Generic.List<T> mAddedItems = new global::System.Collections.Generic.List<T>();

		// Token: 0x04000D05 RID: 3333
		private global::System.Collections.Generic.List<T> mRemovedItems = new global::System.Collections.Generic.List<T>();

		// Token: 0x04000D06 RID: 3334
		private global::System.Collections.Generic.List<T> mEditedItems = new global::System.Collections.Generic.List<T>();
	}
}
