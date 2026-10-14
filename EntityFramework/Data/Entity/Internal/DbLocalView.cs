using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000F7 RID: 247
	internal class DbLocalView<TEntity> : global::System.Collections.ObjectModel.ObservableCollection<TEntity>, global::System.Collections.Generic.ICollection<TEntity>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IEnumerable, global::System.Collections.IList, global::System.Collections.ICollection where TEntity : class
	{
		// Token: 0x0600123A RID: 4666 RVA: 0x0002EB46 File Offset: 0x0002CD46
		public DbLocalView()
		{
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x0002EB4E File Offset: 0x0002CD4E
		public DbLocalView(global::System.Collections.Generic.IEnumerable<TEntity> collection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<TEntity>>(collection, "collection");
			collection.Each(new global::System.Action<TEntity>(this.Add));
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0002EB78 File Offset: 0x0002CD78
		internal DbLocalView(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			this._internalContext = internalContext;
			try
			{
				this._inStateManagerChanged = true;
				foreach (TEntity item in this._internalContext.GetLocalEntities<TEntity>())
				{
					base.Add(item);
				}
			}
			finally
			{
				this._inStateManagerChanged = false;
			}
			this._internalContext.RegisterObjectStateManagerChangedEvent(new global::System.ComponentModel.CollectionChangeEventHandler(this.StateManagerChangedHandler));
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x0600123D RID: 4669 RVA: 0x0002EC0C File Offset: 0x0002CE0C
		internal global::System.Data.Entity.Internal.ObservableBackedBindingList<TEntity> BindingList
		{
			get
			{
				global::System.Data.Entity.Internal.ObservableBackedBindingList<TEntity> result;
				if ((result = this._bindingList) == null)
				{
					result = (this._bindingList = new global::System.Data.Entity.Internal.ObservableBackedBindingList<TEntity>(this));
				}
				return result;
			}
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0002EC34 File Offset: 0x0002CE34
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (!this._inStateManagerChanged && this._internalContext != null)
			{
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
				{
					foreach (object obj in e.OldItems)
					{
						TEntity entity = (TEntity)((object)obj);
						this._internalContext.Set<TEntity>().Remove(entity);
					}
				}
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
				{
					foreach (object obj2 in e.NewItems)
					{
						TEntity tentity = (TEntity)((object)obj2);
						if (!this._internalContext.EntityInContextAndNotDeleted(tentity))
						{
							this._internalContext.Set<TEntity>().Add(tentity);
						}
					}
				}
			}
			base.OnCollectionChanged(e);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0002ED40 File Offset: 0x0002CF40
		private void StateManagerChangedHandler(object sender, global::System.ComponentModel.CollectionChangeEventArgs e)
		{
			try
			{
				this._inStateManagerChanged = true;
				TEntity tentity = e.Element as TEntity;
				if (tentity != null)
				{
					if (e.Action == global::System.ComponentModel.CollectionChangeAction.Remove && this.Contains(tentity))
					{
						this.Remove(tentity);
					}
					else if (e.Action == global::System.ComponentModel.CollectionChangeAction.Add && !this.Contains(tentity))
					{
						base.Add(tentity);
					}
				}
			}
			finally
			{
				this._inStateManagerChanged = false;
			}
		}

		// Token: 0x06001240 RID: 4672 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		protected override void ClearItems()
		{
			new global::System.Collections.Generic.List<TEntity>(this).Each((TEntity t) => this.Remove(t));
		}

		// Token: 0x06001241 RID: 4673 RVA: 0x0002EDD5 File Offset: 0x0002CFD5
		protected override void InsertItem(int index, TEntity item)
		{
			if (!this.Contains(item))
			{
				base.InsertItem(index, item);
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0002EDE8 File Offset: 0x0002CFE8
		public new virtual bool Contains(TEntity item)
		{
			global::System.Collections.Generic.IEqualityComparer<TEntity> @default = global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default;
			foreach (TEntity x in base.Items)
			{
				if (@default.Equals(x, item))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0002EE48 File Offset: 0x0002D048
		public new virtual bool Remove(TEntity item)
		{
			global::System.Collections.Generic.IEqualityComparer<TEntity> @default = global::System.Data.Entity.Infrastructure.ObjectReferenceEqualityComparer.Default;
			int num = 0;
			while (num < base.Count && !@default.Equals(base.Items[num], item))
			{
				num++;
			}
			if (num == base.Count)
			{
				return false;
			}
			this.RemoveItem(num);
			return true;
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0002EE94 File Offset: 0x0002D094
		bool global::System.Collections.Generic.ICollection<!0>.Contains(TEntity item)
		{
			return this.Contains(item);
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0002EE9D File Offset: 0x0002D09D
		bool global::System.Collections.Generic.ICollection<!0>.Remove(TEntity item)
		{
			return this.Remove(item);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0002EEA6 File Offset: 0x0002D0A6
		bool global::System.Collections.IList.Contains(object value)
		{
			return global::System.Data.Entity.Internal.DbLocalView<TEntity>.IsCompatibleObject(value) && this.Contains((TEntity)((object)value));
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0002EEBE File Offset: 0x0002D0BE
		void global::System.Collections.IList.Remove(object value)
		{
			if (global::System.Data.Entity.Internal.DbLocalView<TEntity>.IsCompatibleObject(value))
			{
				this.Remove((TEntity)((object)value));
			}
		}

		// Token: 0x06001248 RID: 4680 RVA: 0x0002EED5 File Offset: 0x0002D0D5
		private static bool IsCompatibleObject(object value)
		{
			return value is TEntity || value == null;
		}

		// Token: 0x0400090F RID: 2319
		private readonly global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x04000910 RID: 2320
		private bool _inStateManagerChanged;

		// Token: 0x04000911 RID: 2321
		private global::System.Data.Entity.Internal.ObservableBackedBindingList<TEntity> _bindingList;
	}
}
