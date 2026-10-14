using System;
using System.Collections.Generic;

namespace Infragistics.Collections
{
	// Token: 0x02000003 RID: 3
	public class BindableItemCollection<T> : global::Infragistics.Collections.CollectionBase<T> where T : global::Infragistics.IBindableItem
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000233B File Offset: 0x0000053B
		public BindableItemCollection(global::Infragistics.IProvideDataItems<T> owner)
		{
			this._owner = owner;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000234C File Offset: 0x0000054C
		protected override int GetCount()
		{
			int result = 0;
			if (this._owner != null)
			{
				result = this._owner.DataCount;
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002370 File Offset: 0x00000570
		protected override T GetItem(int index)
		{
			if (index > -1 && index < base.Count)
			{
				T t = base.GetItem(index);
				if (t == null && this._owner != null)
				{
					t = this._owner.GetDataItem(index);
					if (t != null)
					{
						t.IsDataBound = true;
					}
					this.AddBoundItem(index, t);
				}
				return t;
			}
			return default(T);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023D8 File Offset: 0x000005D8
		protected void AddBoundItem(int index, T item)
		{
			this.AddItemSilently(index, item);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023E2 File Offset: 0x000005E2
		protected override void AddItem(int index, T item)
		{
			this._owner.AddItem(item);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000023F0 File Offset: 0x000005F0
		protected override void InsertItem(int index, T item)
		{
			this._owner.InsertItem(index, item);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000023FF File Offset: 0x000005FF
		protected override bool RemoveItem(int index)
		{
			return this._owner.RemoveItem(this.GetItem(index));
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002413 File Offset: 0x00000613
		public T CreateItem()
		{
			return this._owner.CreateItem();
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002420 File Offset: 0x00000620
		public T CreateItem(object data)
		{
			return this._owner.CreateItem(data);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000242E File Offset: 0x0000062E
		protected internal virtual void RemoveRange(global::System.Collections.Generic.IList<T> itemsToRemove)
		{
			this._owner.RemoveRange(itemsToRemove);
		}

		// Token: 0x04000003 RID: 3
		private global::Infragistics.IProvideDataItems<T> _owner;
	}
}
