using System;
using System.Collections;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001AC RID: 428
	internal sealed class ThreadInfoCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.ThreadInfo>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.ThreadInfo>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.ThreadInfo>, global::System.Collections.IEnumerable
	{
		// Token: 0x06001325 RID: 4901 RVA: 0x00038014 File Offset: 0x00036214
		public ThreadInfoCollection()
		{
			this.m_SortNeeded = false;
			this.m_MaxThreadIndex = 0;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x00038068 File Offset: 0x00036268
		private void EnsureSorted()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SortNeeded)
				{
					this.m_SortedThreadInfo.Sort();
					this.m_SortNeeded = false;
				}
			}
		}

		// Token: 0x06001327 RID: 4903 RVA: 0x000380BC File Offset: 0x000362BC
		public void Add(global::Gibraltar.Monitor.ThreadInfo item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A null ThreadInfo can not be added to the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_ThreadInfoByGuid.ContainsKey(item.Id))
				{
					throw new global::System.InvalidOperationException("The collection already contains the ThreadInfo item being added.");
				}
				int threadIndex = item.ThreadIndex;
				if (this.m_ThreadInfoByIndex.ContainsKey(threadIndex) && !global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.ThreadInfo threadInfo = this.m_ThreadInfoByIndex[threadIndex];
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Gibraltar.Session.ThreadInfo", "ThreadInfo index collision", "Two ThreadInfo objects with different Guid IDs have the same ThreadIndex in the same session.\r\nThreadIndex = {0}\r\nOld Guid ID = {1}\r\nNew Guid ID = {2}\r\nOld thread: {3}\r\nNew thread: {4}\r\n", new object[]
					{
						threadIndex,
						threadInfo.Id,
						item.Id,
						threadInfo.Description,
						item.Description
					});
				}
				if (threadIndex > this.m_MaxThreadIndex)
				{
					this.m_MaxThreadIndex = threadIndex;
				}
				this.m_ThreadInfoByIndex[threadIndex] = item;
				this.m_ThreadInfoByGuid.Add(item.Id, item);
				this.m_SortedThreadInfo.Add(item);
				this.m_SortNeeded = true;
			}
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x000381F8 File Offset: 0x000363F8
		public void Clear()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_ThreadInfoByIndex.Clear();
				this.m_ThreadInfoByGuid.Clear();
				this.m_SortedThreadInfo.Clear();
				this.m_MaxThreadIndex = 0;
				this.m_SortNeeded = false;
			}
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x00038260 File Offset: 0x00036460
		public bool Contains(global::Gibraltar.Monitor.ThreadInfo item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A null ThreadInfo can not be queried in the collection.");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ThreadInfoByGuid.ContainsKey(item.Id);
			}
			return result;
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x000382C8 File Offset: 0x000364C8
		public bool ContainsKey(global::System.Guid id)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ThreadInfoByGuid.ContainsKey(id);
			}
			return result;
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0003830C File Offset: 0x0003650C
		public bool ContainsKey(int threadIndex)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ThreadInfoByIndex.ContainsKey(threadIndex);
			}
			return result;
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x00038350 File Offset: 0x00036550
		public void CopyTo(global::Gibraltar.Monitor.ThreadInfo[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("array", "Can not CopyTo a null array");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureSorted();
				((global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.ThreadInfo>)this.m_SortedThreadInfo).CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000383B0 File Offset: 0x000365B0
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_SortedThreadInfo.Count;
				}
				return count;
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x000383F4 File Offset: 0x000365F4
		public int MaxThreadIndex
		{
			get
			{
				object @lock = this.m_Lock;
				int maxThreadIndex;
				lock (@lock)
				{
					maxThreadIndex = this.m_MaxThreadIndex;
				}
				return maxThreadIndex;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00038434 File Offset: 0x00036634
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00038438 File Offset: 0x00036638
		public bool Remove(global::Gibraltar.Monitor.ThreadInfo item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A null ThreadInfo can not be removed from the collection.");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				if (this.m_ThreadInfoByGuid.ContainsKey(item.Id))
				{
					this.m_SortedThreadInfo.Remove(item);
					this.m_ThreadInfoByGuid.Remove(item.Id);
					this.m_ThreadInfoByIndex.Remove(item.ThreadIndex);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x000384DC File Offset: 0x000366DC
		public bool RemoveKey(global::System.Guid id)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.ThreadInfo threadInfo;
				if (this.m_ThreadInfoByGuid.TryGetValue(id, out threadInfo))
				{
					this.m_SortedThreadInfo.Remove(threadInfo);
					this.m_ThreadInfoByGuid.Remove(id);
					this.m_ThreadInfoByIndex.Remove(threadInfo.ThreadIndex);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0003855C File Offset: 0x0003675C
		public bool RemoveKey(int threadIndex)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.ThreadInfo threadInfo;
				if (this.m_ThreadInfoByIndex.TryGetValue(threadIndex, out threadInfo))
				{
					this.m_SortedThreadInfo.Remove(threadInfo);
					this.m_ThreadInfoByGuid.Remove(threadInfo.Id);
					this.m_ThreadInfoByIndex.Remove(threadIndex);
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x000385DC File Offset: 0x000367DC
		public int IndexOf(global::Gibraltar.Monitor.ThreadInfo item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				this.EnsureSorted();
				result = this.m_SortedThreadInfo.IndexOf(item);
			}
			return result;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00038628 File Offset: 0x00036828
		public void Insert(int index, global::Gibraltar.Monitor.ThreadInfo item)
		{
			throw new global::System.NotSupportedException("ThreadInfoCollection is sorted and does not support direct modification.");
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00038634 File Offset: 0x00036834
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureSorted();
				global::Gibraltar.Monitor.ThreadInfo item = this.m_SortedThreadInfo[index];
				this.Remove(item);
			}
		}

		// Token: 0x170006EB RID: 1771
		global::Gibraltar.Monitor.ThreadInfo global::System.Collections.Generic.IList<global::Gibraltar.Monitor.ThreadInfo>.this[int sortIndex]
		{
			get
			{
				return this[sortIndex];
			}
			set
			{
				throw new global::System.NotSupportedException("ThreadInfoCollection is sorted and does not support direct modification.");
			}
		}

		// Token: 0x170006EC RID: 1772
		public global::Gibraltar.Monitor.ThreadInfo this[int sortIndex]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.ThreadInfo result;
				lock (@lock)
				{
					if (sortIndex < 0 || sortIndex >= this.m_SortedThreadInfo.Count)
					{
						throw new global::System.ArgumentOutOfRangeException("index", "Selected index is outside the range of the collection");
					}
					this.EnsureSorted();
					result = this.m_SortedThreadInfo[sortIndex];
				}
				return result;
			}
		}

		// Token: 0x170006ED RID: 1773
		public global::Gibraltar.Monitor.ThreadInfo this[global::System.Guid id]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.ThreadInfo result;
				lock (@lock)
				{
					result = this.m_ThreadInfoByGuid[id];
				}
				return result;
			}
		}

		// Token: 0x0600133A RID: 4922 RVA: 0x00038758 File Offset: 0x00036958
		public bool TryGetValue(global::System.Guid id, out global::Gibraltar.Monitor.ThreadInfo threadInfo)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ThreadInfoByGuid.TryGetValue(id, out threadInfo);
			}
			return result;
		}

		// Token: 0x0600133B RID: 4923 RVA: 0x000387A0 File Offset: 0x000369A0
		public bool TryGetValue(int threadIndex, out global::Gibraltar.Monitor.ThreadInfo threadInfo)
		{
			threadInfo = this.m_CachedThreadInfo;
			if (threadInfo != null && threadInfo.ThreadIndex == threadIndex)
			{
				return true;
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				bool flag = this.m_ThreadInfoByIndex.TryGetValue(threadIndex, out threadInfo);
				this.m_CachedThreadInfo = threadInfo;
				result = flag;
			}
			return result;
		}

		// Token: 0x0600133C RID: 4924 RVA: 0x0003880C File Offset: 0x00036A0C
		public bool TryFindThreadId(int threadId, out global::Gibraltar.Monitor.ThreadInfo threadInfo)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				this.EnsureSorted();
				foreach (global::Gibraltar.Monitor.ThreadInfo threadInfo2 in this.m_SortedThreadInfo)
				{
					if (threadInfo2.ThreadId == threadId)
					{
						threadInfo = threadInfo2;
						return true;
					}
				}
				threadInfo = null;
				result = false;
			}
			return result;
		}

		// Token: 0x0600133D RID: 4925 RVA: 0x000388A8 File Offset: 0x00036AA8
		public global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.ThreadInfo> GetEnumerator()
		{
			object @lock = this.m_Lock;
			global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.ThreadInfo> enumerator;
			lock (@lock)
			{
				this.EnsureSorted();
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.ThreadInfo>)this.m_SortedThreadInfo).GetEnumerator();
			}
			return enumerator;
		}

		// Token: 0x0600133E RID: 4926 RVA: 0x000388F4 File Offset: 0x00036AF4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x000388FC File Offset: 0x00036AFC
		public void UniquifyThreadNames()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				foreach (global::Gibraltar.Monitor.ThreadInfo threadInfo in this)
				{
					threadInfo.ThreadInstance = 0;
				}
				global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.ThreadInfo> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.ThreadInfo>(this.m_SortedThreadInfo.Count * 2);
				for (int i = 1; i <= this.m_MaxThreadIndex; i++)
				{
					global::Gibraltar.Monitor.ThreadInfo threadInfo2;
					if (this.m_ThreadInfoByIndex.TryGetValue(i, out threadInfo2))
					{
						string caption = threadInfo2.Caption;
						global::Gibraltar.Monitor.ThreadInfo threadInfo3;
						if (dictionary.TryGetValue(caption, out threadInfo3))
						{
							int num = threadInfo3.ThreadInstance;
							if (num <= 0)
							{
								num = 1;
								threadInfo3.ThreadInstance = num;
							}
							num++;
							threadInfo2.ThreadInstance = num;
						}
						dictionary[caption] = threadInfo2;
					}
				}
			}
		}

		// Token: 0x0400065F RID: 1631
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.ThreadInfo> m_ThreadInfoByGuid = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.ThreadInfo>();

		// Token: 0x04000660 RID: 1632
		private readonly global::System.Collections.Generic.Dictionary<int, global::Gibraltar.Monitor.ThreadInfo> m_ThreadInfoByIndex = new global::System.Collections.Generic.Dictionary<int, global::Gibraltar.Monitor.ThreadInfo>();

		// Token: 0x04000661 RID: 1633
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.ThreadInfo> m_SortedThreadInfo = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.ThreadInfo>();

		// Token: 0x04000662 RID: 1634
		private readonly object m_Lock = new object();

		// Token: 0x04000663 RID: 1635
		private bool m_SortNeeded;

		// Token: 0x04000664 RID: 1636
		private int m_MaxThreadIndex;

		// Token: 0x04000665 RID: 1637
		private global::Gibraltar.Monitor.ThreadInfo m_CachedThreadInfo;
	}
}
