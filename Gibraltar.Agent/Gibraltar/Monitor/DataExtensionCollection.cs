using System;
using System.Collections;
using System.Collections.Generic;
using Gibraltar.Monitor.Internal;

namespace Gibraltar.Monitor
{
	// Token: 0x02000189 RID: 393
	internal class DataExtensionCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.DataExtension>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.DataExtension>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.DataExtension>, global::System.Collections.IEnumerable
	{
		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06001076 RID: 4214 RVA: 0x0002DA04 File Offset: 0x0002BC04
		// (remove) Token: 0x06001077 RID: 4215 RVA: 0x0002DA40 File Offset: 0x0002BC40
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.DataExtensionCollection, global::Gibraltar.Monitor.DataExtension>> CollectionChanged;

		// Token: 0x06001078 RID: 4216 RVA: 0x0002DA7C File Offset: 0x0002BC7C
		public DataExtensionCollection(global::Gibraltar.Monitor.Analysis analysis)
		{
			this.m_Analysis = analysis;
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x0002DAAC File Offset: 0x0002BCAC
		internal global::Gibraltar.Monitor.DataExtension Add(global::Gibraltar.Monitor.Internal.IDataObject owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner", "A data object must be provided to own the new data extension object.");
			}
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.DataExtension dataExtension;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(owner.Id))
				{
					throw new global::System.ArgumentException("There already exists a data extension object in the collection for the specified owner.", "owner");
				}
				dataExtension = new global::Gibraltar.Monitor.DataExtension(this.m_Analysis, owner);
				this.m_Dictionary.Add(dataExtension.Id, dataExtension);
				this.m_List.Add(dataExtension);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.DataExtensionCollection, global::Gibraltar.Monitor.DataExtension>(this, dataExtension, global::Gibraltar.Monitor.CollectionAction.Added));
			return dataExtension;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0002DB58 File Offset: 0x0002BD58
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.DataExtensionCollection, global::Gibraltar.Monitor.DataExtension> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.DataExtensionCollection, global::Gibraltar.Monitor.DataExtension>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0002DB80 File Offset: 0x0002BD80
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

		// Token: 0x0600107C RID: 4220 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.DataExtension value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x0002DC0C File Offset: 0x0002BE0C
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.DataExtension> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.DataExtension>.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002DC20 File Offset: 0x0002BE20
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0002DC34 File Offset: 0x0002BE34
		public int IndexOf(global::Gibraltar.Monitor.DataExtension item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOf(item);
			}
			return result;
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x0002DC78 File Offset: 0x0002BE78
		public void Insert(int index, global::Gibraltar.Monitor.DataExtension item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0002DC80 File Offset: 0x0002BE80
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.DataExtension item;
			lock (@lock)
			{
				item = this.m_List[index];
			}
			this.Remove(item);
		}

		// Token: 0x170005CE RID: 1486
		public global::Gibraltar.Monitor.DataExtension this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.DataExtension result;
				lock (@lock)
				{
					result = this.m_List[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x0002DD18 File Offset: 0x0002BF18
		public void Add(global::Gibraltar.Monitor.DataExtension item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (item.Analysis != this.m_Analysis)
			{
				throw new global::System.ArgumentException("The data extension item was created for a different analysis and can't be associated with this collection.", "item");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Id))
				{
					throw new global::System.ArgumentException("There already exists a data extension item in the collection for the specified owner.", "item");
				}
				this.m_Dictionary.Add(item.Id, item);
				this.m_List.Add(item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.DataExtensionCollection, global::Gibraltar.Monitor.DataExtension>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
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
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.DataExtensionCollection, global::Gibraltar.Monitor.DataExtension>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
			}
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x0002DE48 File Offset: 0x0002C048
		public bool Contains(global::Gibraltar.Monitor.DataExtension item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.Contains(item);
			}
			return result;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0002DE8C File Offset: 0x0002C08C
		public void CopyTo(global::Gibraltar.Monitor.DataExtension[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001088 RID: 4232 RVA: 0x0002DED0 File Offset: 0x0002C0D0
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

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x0002DF14 File Offset: 0x0002C114
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x0002DF18 File Offset: 0x0002C118
		public bool Remove(global::Gibraltar.Monitor.DataExtension item)
		{
			bool flag = false;
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A data extension item must be provided to remove it from the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Id))
				{
					this.m_Dictionary.Remove(item.Id);
					flag = true;
				}
				if (this.m_List.Contains(item))
				{
					this.m_List.Remove(item);
					flag = true;
				}
			}
			if (flag)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.DataExtensionCollection, global::Gibraltar.Monitor.DataExtension>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x04000585 RID: 1413
		private readonly global::Gibraltar.Monitor.Analysis m_Analysis;

		// Token: 0x04000586 RID: 1414
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.DataExtension> m_Dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.DataExtension>();

		// Token: 0x04000587 RID: 1415
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.DataExtension> m_List = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.DataExtension>();

		// Token: 0x04000588 RID: 1416
		private readonly object m_Lock = new object();
	}
}
