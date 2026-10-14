using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Monitor
{
	// Token: 0x02000199 RID: 409
	internal class LogMessageGroupCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.LogMessageGroup>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.LogMessageGroup>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessageGroup>, global::System.Collections.IEnumerable
	{
		// Token: 0x14000066 RID: 102
		// (add) Token: 0x060011BF RID: 4543 RVA: 0x00032E6C File Offset: 0x0003106C
		// (remove) Token: 0x060011C0 RID: 4544 RVA: 0x00032EA8 File Offset: 0x000310A8
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageGroupCollection, global::Gibraltar.Monitor.LogMessageGroup>> CollectionChanged;

		// Token: 0x060011C1 RID: 4545 RVA: 0x00032EE4 File Offset: 0x000310E4
		internal LogMessageGroupCollection()
		{
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00032F14 File Offset: 0x00031114
		internal LogMessageGroupCollection(global::Gibraltar.Monitor.LogMessageGroup parent)
		{
			this.Parent = parent;
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x00032F4C File Offset: 0x0003114C
		// (set) Token: 0x060011C4 RID: 4548 RVA: 0x00032F54 File Offset: 0x00031154
		public global::Gibraltar.Monitor.LogMessageGroup Parent { get; private set; }

		// Token: 0x060011C5 RID: 4549 RVA: 0x00032F60 File Offset: 0x00031160
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageGroupCollection, global::Gibraltar.Monitor.LogMessageGroup> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageGroupCollection, global::Gibraltar.Monitor.LogMessageGroup>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00032F88 File Offset: 0x00031188
		public bool ContainsKey(string key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00032FCC File Offset: 0x000311CC
		public bool TryGetValue(string key, out global::Gibraltar.Monitor.LogMessageGroup value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00033014 File Offset: 0x00031214
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.LogMessageGroup> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.LogMessageGroup>.GetEnumerator()
		{
			return this.m_List.Values.GetEnumerator();
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00033028 File Offset: 0x00031228
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00033038 File Offset: 0x00031238
		public int IndexOf(global::Gibraltar.Monitor.LogMessageGroup item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOfKey(item);
			}
			return result;
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x0003307C File Offset: 0x0003127C
		public void Insert(int index, global::Gibraltar.Monitor.LogMessageGroup item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00033084 File Offset: 0x00031284
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.LogMessageGroup item;
			lock (@lock)
			{
				item = this.m_List.Values[index];
			}
			this.Remove(item);
		}

		// Token: 0x1700063F RID: 1599
		public global::Gibraltar.Monitor.LogMessageGroup this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.LogMessageGroup result;
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

		// Token: 0x060011CF RID: 4559 RVA: 0x00033128 File Offset: 0x00031328
		public void Add(global::Gibraltar.Monitor.LogMessageGroup item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A new logMessageGroup item must be provided to add it to the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Dictionary.Add(item.Name, item);
				this.m_List.Add(item, item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageGroupCollection, global::Gibraltar.Monitor.LogMessageGroup>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x000331A4 File Offset: 0x000313A4
		public global::Gibraltar.Monitor.LogMessageGroup Add(string groupName, global::Gibraltar.Monitor.LogMessage message)
		{
			if (message == null)
			{
				throw new global::System.ArgumentNullException("message");
			}
			global::Gibraltar.Monitor.LogMessageGroup logMessageGroup = new global::Gibraltar.Monitor.LogMessageGroup(groupName, this.Parent, message);
			this.Add(logMessageGroup);
			return logMessageGroup;
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x000331E4 File Offset: 0x000313E4
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
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageGroupCollection, global::Gibraltar.Monitor.LogMessageGroup>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
			}
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00033258 File Offset: 0x00031458
		public bool Contains(global::Gibraltar.Monitor.LogMessageGroup item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.ContainsKey(item);
			}
			return result;
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x0003329C File Offset: 0x0003149C
		public void CopyTo(global::Gibraltar.Monitor.LogMessageGroup[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x000332E4 File Offset: 0x000314E4
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

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00033328 File Offset: 0x00031528
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060011D6 RID: 4566 RVA: 0x0003332C File Offset: 0x0003152C
		public bool Remove(global::Gibraltar.Monitor.LogMessageGroup item)
		{
			bool flag = false;
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A logMessageGroup item must be provided to remove it from the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Name))
				{
					this.m_Dictionary.Remove(item.Name);
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
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.LogMessageGroupCollection, global::Gibraltar.Monitor.LogMessageGroup>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x04000600 RID: 1536
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.LogMessageGroup> m_Dictionary = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.LogMessageGroup>(global::System.StringComparer.InvariantCultureIgnoreCase);

		// Token: 0x04000601 RID: 1537
		private readonly global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.LogMessageGroup, global::Gibraltar.Monitor.LogMessageGroup> m_List = new global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.LogMessageGroup, global::Gibraltar.Monitor.LogMessageGroup>();

		// Token: 0x04000602 RID: 1538
		private readonly object m_Lock = new object();
	}
}
