using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000427 RID: 1063
	internal sealed class ObjectViewEntityCollectionData<TViewElement, TItemElement> : global::System.Data.Entity.Core.Objects.IObjectViewData<TViewElement> where TViewElement : TItemElement where TItemElement : class
	{
		// Token: 0x060033D3 RID: 13267 RVA: 0x000A64A4 File Offset: 0x000A46A4
		internal ObjectViewEntityCollectionData(global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TItemElement> entityCollection)
		{
			this._entityCollection = entityCollection;
			this._canEditItems = true;
			this._bindingList = new global::System.Collections.Generic.List<TViewElement>(entityCollection.Count);
			foreach (TItemElement titemElement in entityCollection)
			{
				TViewElement item = (TViewElement)((object)titemElement);
				this._bindingList.Add(item);
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060033D4 RID: 13268 RVA: 0x000A6520 File Offset: 0x000A4720
		public global::System.Collections.Generic.IList<TViewElement> List
		{
			get
			{
				return this._bindingList;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x000A6528 File Offset: 0x000A4728
		public bool AllowNew
		{
			get
			{
				return !this._entityCollection.IsReadOnly;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x000A6538 File Offset: 0x000A4738
		public bool AllowEdit
		{
			get
			{
				return this._canEditItems;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060033D7 RID: 13271 RVA: 0x000A6540 File Offset: 0x000A4740
		public bool AllowRemove
		{
			get
			{
				return !this._entityCollection.IsReadOnly;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x000A6550 File Offset: 0x000A4750
		public bool FiresEventOnAdd
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060033D9 RID: 13273 RVA: 0x000A6553 File Offset: 0x000A4753
		public bool FiresEventOnRemove
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x000A6556 File Offset: 0x000A4756
		public bool FiresEventOnClear
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060033DB RID: 13275 RVA: 0x000A6559 File Offset: 0x000A4759
		public void EnsureCanAddNew()
		{
		}

		// Token: 0x060033DC RID: 13276 RVA: 0x000A655B File Offset: 0x000A475B
		public int Add(TViewElement item, bool isAddNew)
		{
			if (isAddNew)
			{
				this._bindingList.Add(item);
			}
			else
			{
				this._entityCollection.Add((TItemElement)((object)item));
			}
			return this._bindingList.Count - 1;
		}

		// Token: 0x060033DD RID: 13277 RVA: 0x000A6594 File Offset: 0x000A4794
		public void CommitItemAt(int index)
		{
			TViewElement tviewElement = this._bindingList[index];
			try
			{
				this._itemCommitPending = true;
				this._entityCollection.Add((TItemElement)((object)tviewElement));
			}
			finally
			{
				this._itemCommitPending = false;
			}
		}

		// Token: 0x060033DE RID: 13278 RVA: 0x000A65E8 File Offset: 0x000A47E8
		public void Clear()
		{
			if (0 < this._bindingList.Count)
			{
				global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
				foreach (TViewElement tviewElement in this._bindingList)
				{
					object item = tviewElement;
					list.Add(item);
				}
				this._entityCollection.BulkDeleteAll(list);
			}
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x000A6660 File Offset: 0x000A4860
		public bool Remove(TViewElement item, bool isCancelNew)
		{
			bool result;
			if (isCancelNew)
			{
				result = this._bindingList.Remove(item);
			}
			else
			{
				result = this._entityCollection.RemoveInternal((TItemElement)((object)item));
			}
			return result;
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x000A6698 File Offset: 0x000A4898
		public global::System.ComponentModel.ListChangedEventArgs OnCollectionChanged(object sender, global::System.ComponentModel.CollectionChangeEventArgs e, global::System.Data.Entity.Core.Objects.ObjectViewListener listener)
		{
			global::System.ComponentModel.ListChangedEventArgs result = null;
			switch (e.Action)
			{
			case global::System.ComponentModel.CollectionChangeAction.Add:
				if (e.Element is TViewElement && !this._itemCommitPending)
				{
					TViewElement tviewElement = (TViewElement)((object)e.Element);
					this._bindingList.Add(tviewElement);
					listener.RegisterEntityEvents(tviewElement);
					result = new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemAdded, this._bindingList.Count - 1, -1);
				}
				break;
			case global::System.ComponentModel.CollectionChangeAction.Remove:
				if (e.Element is TViewElement)
				{
					TViewElement tviewElement2 = (TViewElement)((object)e.Element);
					int num = this._bindingList.IndexOf(tviewElement2);
					if (num != -1)
					{
						this._bindingList.Remove(tviewElement2);
						listener.UnregisterEntityEvents(tviewElement2);
						result = new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.ItemDeleted, num, -1);
					}
				}
				break;
			case global::System.ComponentModel.CollectionChangeAction.Refresh:
				foreach (TViewElement tviewElement3 in this._bindingList)
				{
					listener.UnregisterEntityEvents(tviewElement3);
				}
				this._bindingList.Clear();
				foreach (object obj in this._entityCollection.GetInternalEnumerable())
				{
					TViewElement tviewElement4 = (TViewElement)((object)obj);
					this._bindingList.Add(tviewElement4);
					listener.RegisterEntityEvents(tviewElement4);
				}
				result = new global::System.ComponentModel.ListChangedEventArgs(global::System.ComponentModel.ListChangedType.Reset, -1, -1);
				break;
			}
			return result;
		}

		// Token: 0x040010C0 RID: 4288
		private readonly global::System.Collections.Generic.List<TViewElement> _bindingList;

		// Token: 0x040010C1 RID: 4289
		private readonly global::System.Data.Entity.Core.Objects.DataClasses.EntityCollection<TItemElement> _entityCollection;

		// Token: 0x040010C2 RID: 4290
		private readonly bool _canEditItems;

		// Token: 0x040010C3 RID: 4291
		private bool _itemCommitPending;
	}
}
