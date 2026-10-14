using System;
using System.Collections;
using System.Collections.Generic;
using Loupe.Extensibility;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x020001FB RID: 507
	internal class SessionSummaryCollection : global::Loupe.Extensibility.Data.ISessionSummaryCollection, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.ISessionSummary>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ISessionSummary>, global::System.Collections.IEnumerable
	{
		// Token: 0x06001916 RID: 6422 RVA: 0x0005883C File Offset: 0x00056A3C
		public SessionSummaryCollection(global::Loupe.Extensibility.IRepository repository)
		{
			this.m_Repository = repository;
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x0005886C File Offset: 0x00056A6C
		public SessionSummaryCollection(global::Loupe.Extensibility.IRepository repository, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ISessionSummary> sessions)
		{
			this.m_Repository = repository;
			this.m_List.AddRange(sessions);
			foreach (global::Loupe.Extensibility.Data.ISessionSummary sessionSummary in sessions)
			{
				this.m_Dictionary.Add(sessionSummary.Id, sessionSummary);
			}
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00058904 File Offset: 0x00056B04
		public global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.ISessionSummary> GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00058918 File Offset: 0x00056B18
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x0005892C File Offset: 0x00056B2C
		public void Add(global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			this.AddItem(item);
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00058938 File Offset: 0x00056B38
		private void AddItem(global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.Add(item);
				this.m_Dictionary.Add(item.Id, item);
			}
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x0005898C File Offset: 0x00056B8C
		public void Clear()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.Clear();
				this.m_Dictionary.Clear();
			}
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000589D8 File Offset: 0x00056BD8
		public bool Contains(global::System.Guid key)
		{
			throw new global::System.NotSupportedException("The Contains method has not been implemented.");
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000589E4 File Offset: 0x00056BE4
		public bool Contains(global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.ContainsKey(item.Id);
			}
			return result;
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00058A40 File Offset: 0x00056C40
		public void CopyTo(global::Loupe.Extensibility.Data.ISessionSummary[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00058A84 File Offset: 0x00056C84
		public bool Remove(global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			return this.RemoveItem(item);
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00058A90 File Offset: 0x00056C90
		private bool RemoveItem(global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			global::Loupe.Extensibility.Data.ISessionSummary sessionSummary;
			if (this.m_Dictionary.TryGetValue(item.Id, out sessionSummary))
			{
				this.m_Dictionary.Remove(item.Id);
				this.m_List.Remove(item);
				return true;
			}
			return false;
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x00058AEC File Offset: 0x00056CEC
		public int Count
		{
			get
			{
				return this.m_List.Count;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x00058AFC File Offset: 0x00056CFC
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00058B00 File Offset: 0x00056D00
		public global::Loupe.Extensibility.Data.ISessionSummary Find(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> match)
		{
			if (match == null)
			{
				throw new global::System.ArgumentNullException("match");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				foreach (global::Loupe.Extensibility.Data.ISessionSummary sessionSummary in this.m_List)
				{
					if (match(sessionSummary))
					{
						return sessionSummary;
					}
				}
			}
			return null;
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00058B9C File Offset: 0x00056D9C
		public global::Loupe.Extensibility.Data.ISessionSummaryCollection FindAll(global::System.Predicate<global::Loupe.Extensibility.Data.ISessionSummary> match)
		{
			if (match == null)
			{
				throw new global::System.ArgumentNullException("match");
			}
			global::Gibraltar.Monitor.Internal.SessionSummaryCollection sessionSummaryCollection = new global::Gibraltar.Monitor.Internal.SessionSummaryCollection(this.m_Repository);
			object @lock = this.m_Lock;
			lock (@lock)
			{
				foreach (global::Loupe.Extensibility.Data.ISessionSummary sessionSummary in this.m_List)
				{
					if (match(sessionSummary))
					{
						sessionSummaryCollection.Add(sessionSummary);
					}
				}
			}
			return sessionSummaryCollection;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00058C40 File Offset: 0x00056E40
		public bool Remove(global::System.Guid key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				bool flag = false;
				global::Loupe.Extensibility.Data.ISessionSummary item;
				if (this.m_Dictionary.TryGetValue(key, out item))
				{
					flag = true;
					this.m_Dictionary.Remove(key);
					this.m_List.Remove(item);
				}
				result = flag;
			}
			return result;
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00058CAC File Offset: 0x00056EAC
		public bool TryGetValue(global::System.Guid key, out global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00058CB4 File Offset: 0x00056EB4
		public int IndexOf(global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOf(item);
			}
			return result;
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00058CF8 File Offset: 0x00056EF8
		public void Insert(int index, global::Loupe.Extensibility.Data.ISessionSummary item)
		{
			throw new global::System.NotSupportedException("Inserting an item into the collection at a specific location is not supported.");
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00058D04 File Offset: 0x00056F04
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Loupe.Extensibility.Data.ISessionSummary item = this.m_List[index];
				this.Remove(item);
			}
		}

		// Token: 0x17000877 RID: 2167
		public global::Loupe.Extensibility.Data.ISessionSummary this[int index]
		{
			get
			{
				return this.m_List[index];
			}
			set
			{
				throw new global::System.NotSupportedException("Updated items by index is not supported.");
			}
		}

		// Token: 0x17000878 RID: 2168
		public global::Loupe.Extensibility.Data.ISessionSummary this[global::System.Guid key]
		{
			get
			{
				return this.m_Dictionary[key];
			}
		}

		// Token: 0x0400091E RID: 2334
		private readonly object m_Lock = new object();

		// Token: 0x0400091F RID: 2335
		private readonly global::Loupe.Extensibility.IRepository m_Repository;

		// Token: 0x04000920 RID: 2336
		private readonly global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.ISessionSummary> m_List = new global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.ISessionSummary>();

		// Token: 0x04000921 RID: 2337
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.ISessionSummary> m_Dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.ISessionSummary>();
	}
}
