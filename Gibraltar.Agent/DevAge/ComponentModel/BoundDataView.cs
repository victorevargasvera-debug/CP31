using System;
using System.Collections;
using System.ComponentModel;
using System.Data;

namespace DevAge.ComponentModel
{
	// Token: 0x020002EB RID: 747
	internal class BoundDataView : global::DevAge.ComponentModel.IBoundList
	{
		// Token: 0x060023F6 RID: 9206 RVA: 0x0007D6D8 File Offset: 0x0007B8D8
		public BoundDataView(global::System.Data.DataView dataView)
		{
			this.mDataView = dataView;
			this.mDataView.ListChanged += this.mDataView_ListChanged;
		}

		// Token: 0x1400009C RID: 156
		// (add) Token: 0x060023F7 RID: 9207 RVA: 0x0007D72C File Offset: 0x0007B92C
		// (remove) Token: 0x060023F8 RID: 9208 RVA: 0x0007D748 File Offset: 0x0007B948
		public event global::System.ComponentModel.ListChangedEventHandler ListChanged;

		// Token: 0x060023F9 RID: 9209 RVA: 0x0007D764 File Offset: 0x0007B964
		protected virtual void OnListChanged(global::System.ComponentModel.ListChangedEventArgs e)
		{
			if (this.ListChanged != null)
			{
				this.ListChanged(this, e);
			}
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0007D780 File Offset: 0x0007B980
		private void mDataView_ListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			this.OnListChanged(e);
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0007D78C File Offset: 0x0007B98C
		public virtual int BeginAddNew()
		{
			if (this.mEditingRow != null)
			{
				throw new global::DevAge.DevAgeApplicationException("There is already a row in editing state, call EndEdit first");
			}
			this.mEditingRow = this.mDataView.AddNew();
			this.mEditingRow.BeginEdit();
			global::System.Collections.IList list = this.mDataView;
			return list.IndexOf(this.mEditingRow);
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0007D7E4 File Offset: 0x0007B9E4
		public virtual void BeginEdit(int index)
		{
			if (this.mEditingRow != null)
			{
				throw new global::DevAge.DevAgeApplicationException("There is already a row in editing state, call EndEdit first");
			}
			this.mEditingRow = this.mDataView[index];
			this.mEditingRow.BeginEdit();
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x0007D81C File Offset: 0x0007BA1C
		public virtual void EndEdit(bool cancel)
		{
			if (this.mEditingRow == null)
			{
				return;
			}
			if (cancel)
			{
				this.mEditingRow.CancelEdit();
			}
			else
			{
				this.mEditingRow.EndEdit();
			}
			this.mEditingRow = null;
			if (cancel)
			{
				this.OnListChanged(new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.Reset, -1));
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x0007D874 File Offset: 0x0007BA74
		public virtual object EditedObject
		{
			get
			{
				return this.mEditingRow;
			}
		}

		// Token: 0x060023FF RID: 9215 RVA: 0x0007D87C File Offset: 0x0007BA7C
		public virtual int IndexOf(object item)
		{
			global::System.Collections.IList list = this.mDataView;
			return list.IndexOf(item);
		}

		// Token: 0x06002400 RID: 9216 RVA: 0x0007D89C File Offset: 0x0007BA9C
		public virtual void RemoveAt(int index)
		{
			this.mDataView[index].Delete();
		}

		// Token: 0x17000B58 RID: 2904
		public virtual object this[int index]
		{
			get
			{
				return this.mDataView[index];
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x0007D8C0 File Offset: 0x0007BAC0
		public virtual int Count
		{
			get
			{
				return this.mDataView.Count;
			}
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x0007D8D0 File Offset: 0x0007BAD0
		public virtual global::System.ComponentModel.PropertyDescriptorCollection GetItemProperties()
		{
			if (this.mDataView == null)
			{
				return new global::System.ComponentModel.PropertyDescriptorCollection(null);
			}
			return ((global::System.ComponentModel.ITypedList)this.mDataView).GetItemProperties(null);
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x0007D8F0 File Offset: 0x0007BAF0
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

		// Token: 0x06002405 RID: 9221 RVA: 0x0007D968 File Offset: 0x0007BB68
		public virtual object GetItemValue(int index, global::System.ComponentModel.PropertyDescriptor property)
		{
			return property.GetValue(this.mDataView[index]);
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0007D97C File Offset: 0x0007BB7C
		public virtual void SetEditValue(global::System.ComponentModel.PropertyDescriptor property, object value)
		{
			if (this.mEditingRow == null)
			{
				throw new global::DevAge.DevAgeApplicationException("There isn't a row in editing state, call BeginAddNew or BeginEdit first");
			}
			property.SetValue(this.mEditingRow, value);
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
		public virtual void ApplySort(global::System.ComponentModel.ListSortDescriptionCollection sorts)
		{
			global::System.ComponentModel.IBindingListView bindingListView = this.mDataView;
			if (sorts != null && sorts.Count > 0)
			{
				bindingListView.ApplySort(sorts);
				return;
			}
			bindingListView.RemoveSort();
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x06002408 RID: 9224 RVA: 0x0007D9DC File Offset: 0x0007BBDC
		// (set) Token: 0x06002409 RID: 9225 RVA: 0x0007D9F8 File Offset: 0x0007BBF8
		public virtual bool AllowEdit
		{
			get
			{
				return this.mDataView.AllowEdit && this.mAllowEdit;
			}
			set
			{
				this.mAllowEdit = value;
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x0600240A RID: 9226 RVA: 0x0007DA04 File Offset: 0x0007BC04
		// (set) Token: 0x0600240B RID: 9227 RVA: 0x0007DA20 File Offset: 0x0007BC20
		public virtual bool AllowNew
		{
			get
			{
				return this.mDataView.AllowNew && this.mAllowNew;
			}
			set
			{
				this.mAllowNew = value;
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x0007DA2C File Offset: 0x0007BC2C
		// (set) Token: 0x0600240D RID: 9229 RVA: 0x0007DA48 File Offset: 0x0007BC48
		public virtual bool AllowDelete
		{
			get
			{
				return this.mDataView.AllowDelete && this.mAllowDelete;
			}
			set
			{
				this.mAllowDelete = value;
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x0600240E RID: 9230 RVA: 0x0007DA54 File Offset: 0x0007BC54
		// (set) Token: 0x0600240F RID: 9231 RVA: 0x0007DA5C File Offset: 0x0007BC5C
		public virtual bool AllowSort
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

		// Token: 0x04000CB1 RID: 3249
		public global::System.Data.DataView mDataView;

		// Token: 0x04000CB3 RID: 3251
		private global::System.Data.DataRowView mEditingRow;

		// Token: 0x04000CB4 RID: 3252
		private bool mAllowEdit = true;

		// Token: 0x04000CB5 RID: 3253
		private bool mAllowNew = true;

		// Token: 0x04000CB6 RID: 3254
		private bool mAllowDelete = true;

		// Token: 0x04000CB7 RID: 3255
		private bool mAllowSort = true;
	}
}
