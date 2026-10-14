using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Monitor
{
	// Token: 0x02000187 RID: 391
	internal class CommentCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.Comment>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.Comment>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.Comment>, global::System.Collections.IEnumerable
	{
		// Token: 0x14000060 RID: 96
		// (add) Token: 0x0600105A RID: 4186 RVA: 0x0002D434 File Offset: 0x0002B634
		// (remove) Token: 0x0600105B RID: 4187 RVA: 0x0002D470 File Offset: 0x0002B670
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.CommentCollection, global::Gibraltar.Monitor.Comment>> CollectionChanged;

		// Token: 0x0600105C RID: 4188 RVA: 0x0002D4AC File Offset: 0x0002B6AC
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.CommentCollection, global::Gibraltar.Monitor.Comment> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.CommentCollection, global::Gibraltar.Monitor.Comment>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x0002D4D4 File Offset: 0x0002B6D4
		public bool ContainsKey(global::System.Guid key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0002D518 File Offset: 0x0002B718
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.Comment value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0002D560 File Offset: 0x0002B760
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.Comment> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.Comment>.GetEnumerator()
		{
			return this.m_List.Values.GetEnumerator();
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0002D574 File Offset: 0x0002B774
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x0002D584 File Offset: 0x0002B784
		public int IndexOf(global::Gibraltar.Monitor.Comment item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOfKey(item);
			}
			return result;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x0002D5C8 File Offset: 0x0002B7C8
		public void Insert(int index, global::Gibraltar.Monitor.Comment item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0002D5D0 File Offset: 0x0002B7D0
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.Comment item;
			lock (@lock)
			{
				item = this.m_List.Values[index];
			}
			this.Remove(item);
		}

		// Token: 0x170005C6 RID: 1478
		public global::Gibraltar.Monitor.Comment this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Comment result;
				lock (@lock)
				{
					result = this.m_List.Values[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x0002D674 File Offset: 0x0002B874
		public void Add(global::Gibraltar.Monitor.Comment item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A new comment item must be provided to add it to the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Dictionary.Add(item.Id, item);
				this.m_List.Add(item, item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.CommentCollection, global::Gibraltar.Monitor.Comment>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x0002D6F4 File Offset: 0x0002B8F4
		public void Clear()
		{
			object @lock = this.m_Lock;
			int count;
			lock (@lock)
			{
				count = this.m_List.Count;
				if (count > 0)
				{
					this.m_List.Clear();
					this.m_Dictionary.Clear();
				}
			}
			if (count > 0)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.CommentCollection, global::Gibraltar.Monitor.Comment>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
			}
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x0002D768 File Offset: 0x0002B968
		public bool Contains(global::Gibraltar.Monitor.Comment item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.ContainsKey(item);
			}
			return result;
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x0002D7AC File Offset: 0x0002B9AC
		public void CopyTo(global::Gibraltar.Monitor.Comment[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x0002D7F4 File Offset: 0x0002B9F4
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_List.Count;
				}
				return count;
			}
		}

		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600106B RID: 4203 RVA: 0x0002D838 File Offset: 0x0002BA38
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x0002D83C File Offset: 0x0002BA3C
		public bool Remove(global::Gibraltar.Monitor.Comment item)
		{
			bool flag = false;
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A comment item must be provided to remove it from the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Id))
				{
					this.m_Dictionary.Remove(item.Id);
					flag = true;
				}
				if (this.m_List.ContainsKey(item))
				{
					this.m_List.Remove(item);
					flag = true;
				}
			}
			if (flag)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.CommentCollection, global::Gibraltar.Monitor.Comment>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x0400057D RID: 1405
		private readonly global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.Comment, global::Gibraltar.Monitor.Comment> m_List = new global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.Comment, global::Gibraltar.Monitor.Comment>();

		// Token: 0x0400057E RID: 1406
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Comment> m_Dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Comment>();

		// Token: 0x0400057F RID: 1407
		private readonly object m_Lock = new object();
	}
}
