using System;
using System.Collections;
using System.Collections.Generic;
using Gibraltar.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001A9 RID: 425
	internal class SessionFragmentCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.SessionFragment>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.SessionFragment>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.SessionFragment>, global::System.Collections.IEnumerable
	{
		// Token: 0x14000069 RID: 105
		// (add) Token: 0x060012B2 RID: 4786 RVA: 0x0003655C File Offset: 0x0003475C
		// (remove) Token: 0x060012B3 RID: 4787 RVA: 0x00036598 File Offset: 0x00034798
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment>> CollectionChanged;

		// Token: 0x060012B4 RID: 4788 RVA: 0x000365D4 File Offset: 0x000347D4
		internal SessionFragmentCollection(global::Gibraltar.Monitor.Session session)
		{
			if (session == null)
			{
				throw new global::System.ArgumentNullException("session");
			}
			this.m_Session = session;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x0003662C File Offset: 0x0003482C
		public global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.SessionFragment> GetEnumerator()
		{
			object @lock = this.m_Lock;
			global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.SessionFragment> enumerator;
			lock (@lock)
			{
				enumerator = this.m_SessionFilesList.Values.GetEnumerator();
			}
			return enumerator;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00036674 File Offset: 0x00034874
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x0003667C File Offset: 0x0003487C
		internal global::Gibraltar.Monitor.SessionFragment Add(global::Gibraltar.Data.GLFReader glfReader)
		{
			if (glfReader == null)
			{
				throw new global::System.ArgumentNullException("glfReader");
			}
			if (!glfReader.IsSessionStream)
			{
				throw new global::System.ArgumentException("The provided file is not a valid session file and can't be loaded.");
			}
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.SessionFragment sessionFragment;
			lock (@lock)
			{
				this.m_SessionFilesById.TryGetValue(glfReader.SessionHeader.FileId, out sessionFragment);
				if (sessionFragment == null)
				{
					sessionFragment = new global::Gibraltar.Monitor.SessionFragment(glfReader);
					this.AddItem(sessionFragment);
				}
				this.m_Session.IntegrateHeader(glfReader.SessionHeader);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment>(this, sessionFragment, global::Gibraltar.Monitor.CollectionAction.Added));
			return sessionFragment;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00036728 File Offset: 0x00034928
		public void Add(global::Gibraltar.Monitor.SessionFragment item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SessionFilesById.ContainsKey(item.Id))
				{
					throw new global::System.ArgumentException("There is already a session file with the provided ID.", "item");
				}
				this.AddItem(item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000367AC File Offset: 0x000349AC
		public void Clear()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_SessionFilesById.Clear();
				this.m_SessionFilesList.Clear();
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x00036808 File Offset: 0x00034A08
		public bool Contains(global::Gibraltar.Monitor.SessionFragment item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_SessionFilesById.ContainsKey(item.Id);
			}
			return result;
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x00036854 File Offset: 0x00034A54
		public bool Contains(global::System.Guid fileID)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_SessionFilesById.ContainsKey(fileID);
			}
			return result;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x00036898 File Offset: 0x00034A98
		public void CopyTo(global::Gibraltar.Monitor.SessionFragment[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_SessionFilesList.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000368E0 File Offset: 0x00034AE0
		public bool Remove(global::Gibraltar.Monitor.SessionFragment item)
		{
			bool flag = false;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SessionFilesList.Remove(item.StartDateTime))
				{
					flag = true;
				}
				if (this.m_SessionFilesById.Remove(item.Id))
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x00036960 File Offset: 0x00034B60
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_SessionFilesList.Count;
				}
				return count;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x060012BF RID: 4799 RVA: 0x000369A4 File Offset: 0x00034BA4
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000369A8 File Offset: 0x00034BA8
		public int IndexOf(global::Gibraltar.Monitor.SessionFragment item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_SessionFilesList.IndexOfValue(item);
			}
			return result;
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000369EC File Offset: 0x00034BEC
		public int IndexOf(global::System.Guid ID)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.IndexOf(this.m_SessionFilesById[ID]);
			}
			return result;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x00036A38 File Offset: 0x00034C38
		public void Insert(int index, global::Gibraltar.Monitor.SessionFragment item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x00036A40 File Offset: 0x00034C40
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x170006A3 RID: 1699
		public global::Gibraltar.Monitor.SessionFragment this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.SessionFragment result;
				lock (@lock)
				{
					result = this.m_SessionFilesList.Values[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x170006A4 RID: 1700
		public global::Gibraltar.Monitor.SessionFragment this[global::System.Guid ID]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.SessionFragment result;
				lock (@lock)
				{
					result = this.m_SessionFilesById[ID];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00036AE8 File Offset: 0x00034CE8
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.SessionFragment value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_SessionFilesById.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060012C9 RID: 4809 RVA: 0x00036B30 File Offset: 0x00034D30
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.SessionFragmentCollection, global::Gibraltar.Monitor.SessionFragment>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00036B58 File Offset: 0x00034D58
		private void AddItem(global::Gibraltar.Monitor.SessionFragment item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_SessionFilesById.Add(item.Id, item);
				this.m_SessionFilesList.Add(item.StartDateTime, item);
				if (!item.Loaded)
				{
					item.Loaded = true;
					this.m_Session.AddPacketStream(item.Reader);
				}
			}
		}

		// Token: 0x0400064F RID: 1615
		private readonly global::Gibraltar.Monitor.Session m_Session;

		// Token: 0x04000650 RID: 1616
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFragment> m_SessionFilesById = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFragment>();

		// Token: 0x04000651 RID: 1617
		private readonly global::System.Collections.Generic.SortedList<global::System.DateTimeOffset, global::Gibraltar.Monitor.SessionFragment> m_SessionFilesList = new global::System.Collections.Generic.SortedList<global::System.DateTimeOffset, global::Gibraltar.Monitor.SessionFragment>();

		// Token: 0x04000652 RID: 1618
		private readonly object m_Lock = new object();
	}
}
