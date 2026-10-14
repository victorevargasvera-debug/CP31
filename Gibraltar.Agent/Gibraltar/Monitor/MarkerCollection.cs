using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Monitor
{
	// Token: 0x0200019C RID: 412
	internal class MarkerCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.Marker>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.Marker>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.Marker>, global::System.Collections.IEnumerable
	{
		// Token: 0x14000067 RID: 103
		// (add) Token: 0x060011F6 RID: 4598 RVA: 0x000337F4 File Offset: 0x000319F4
		// (remove) Token: 0x060011F7 RID: 4599 RVA: 0x00033830 File Offset: 0x00031A30
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.MarkerCollection, global::Gibraltar.Monitor.Marker>> CollectionChanged;

		// Token: 0x060011F8 RID: 4600 RVA: 0x0003386C File Offset: 0x00031A6C
		public MarkerCollection(global::Gibraltar.Monitor.Analysis analysis)
		{
			this.m_Analysis = analysis;
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0003389C File Offset: 0x00031A9C
		public global::Gibraltar.Monitor.Marker Add()
		{
			global::Gibraltar.Monitor.Marker marker = new global::Gibraltar.Monitor.Marker(this.m_Analysis);
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Dictionary.Add(marker.Id, marker);
				this.m_List.Add(marker, marker);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.MarkerCollection, global::Gibraltar.Monitor.Marker>(this, marker, global::Gibraltar.Monitor.CollectionAction.Added));
			return marker;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0003390C File Offset: 0x00031B0C
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.MarkerCollection, global::Gibraltar.Monitor.Marker> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.MarkerCollection, global::Gibraltar.Monitor.Marker>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x00033934 File Offset: 0x00031B34
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

		// Token: 0x060011FC RID: 4604 RVA: 0x00033978 File Offset: 0x00031B78
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.Marker value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x000339C0 File Offset: 0x00031BC0
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.Marker> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.Marker>.GetEnumerator()
		{
			return this.m_List.Values.GetEnumerator();
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x000339D4 File Offset: 0x00031BD4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x000339E4 File Offset: 0x00031BE4
		public int IndexOf(global::Gibraltar.Monitor.Marker item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOfKey(item);
			}
			return result;
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00033A28 File Offset: 0x00031C28
		public void Insert(int index, global::Gibraltar.Monitor.Marker item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00033A30 File Offset: 0x00031C30
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.Marker item;
			lock (@lock)
			{
				item = this.m_List.Values[index];
			}
			this.Remove(item);
		}

		// Token: 0x1700064D RID: 1613
		public global::Gibraltar.Monitor.Marker this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Marker result;
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

		// Token: 0x1700064E RID: 1614
		public global::Gibraltar.Monitor.Marker this[global::System.Guid id]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Marker result;
				lock (@lock)
				{
					result = this.m_Dictionary[id];
				}
				return result;
			}
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x00033B18 File Offset: 0x00031D18
		public void Add(global::Gibraltar.Monitor.Marker item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A marker item must be provided to add it to the collection.");
			}
			if (item.Analysis != this.m_Analysis)
			{
				throw new global::System.ArgumentException("The marker item was created for a different analysis and can't be associated with this collection.", "item");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Id))
				{
					throw new global::System.ArgumentException("There already exists a marker item in the collection for the specified id.", "item");
				}
				this.m_Dictionary.Add(item.Id, item);
				this.m_List.Add(item, item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.MarkerCollection, global::Gibraltar.Monitor.Marker>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x00033BE0 File Offset: 0x00031DE0
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
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.MarkerCollection, global::Gibraltar.Monitor.Marker>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
			}
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x00033C54 File Offset: 0x00031E54
		public bool Contains(global::Gibraltar.Monitor.Marker item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.ContainsKey(item);
			}
			return result;
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x00033C98 File Offset: 0x00031E98
		public void CopyTo(global::Gibraltar.Monitor.Marker[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00033CE0 File Offset: 0x00031EE0
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

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00033D24 File Offset: 0x00031F24
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00033D28 File Offset: 0x00031F28
		public bool Remove(global::Gibraltar.Monitor.Marker item)
		{
			bool flag = false;
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A marker item must be provided to remove it from the collection.");
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
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.MarkerCollection, global::Gibraltar.Monitor.Marker>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x04000610 RID: 1552
		private readonly global::Gibraltar.Monitor.Analysis m_Analysis;

		// Token: 0x04000611 RID: 1553
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Marker> m_Dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Marker>();

		// Token: 0x04000612 RID: 1554
		private readonly global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.Marker, global::Gibraltar.Monitor.Marker> m_List = new global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.Marker, global::Gibraltar.Monitor.Marker>();

		// Token: 0x04000613 RID: 1555
		private readonly object m_Lock = new object();
	}
}
