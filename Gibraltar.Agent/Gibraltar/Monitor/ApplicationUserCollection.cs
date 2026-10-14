using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Monitor
{
	// Token: 0x0200017F RID: 383
	internal sealed class ApplicationUserCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.ApplicationUser>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.ApplicationUser>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.ApplicationUser>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000FF6 RID: 4086 RVA: 0x0002B8B8 File Offset: 0x00029AB8
		public ApplicationUserCollection()
		{
			this.m_SortNeeded = false;
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x0002B918 File Offset: 0x00029B18
		private void EnsureSorted()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_SortNeeded)
				{
					this.m_SortedApplicationUser.Sort();
					this.m_SortNeeded = false;
				}
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x0002B96C File Offset: 0x00029B6C
		public void Add(global::Gibraltar.Monitor.ApplicationUser item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A null ApplicationUser can not be added to the collection.");
			}
			if (string.IsNullOrEmpty(item.FullyQualifiedUserName))
			{
				throw new global::System.ArgumentNullException("item", "An ApplicationUser with a null username can not be added to the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_ApplicationUserByGuid.ContainsKey(item.Id))
				{
					throw new global::System.InvalidOperationException("The collection already contains the ApplicationUser item being added.");
				}
				if (string.IsNullOrEmpty(item.Key))
				{
					if (this.m_ApplicationUserByUserName.ContainsKey(item.FullyQualifiedUserName))
					{
						throw new global::System.InvalidOperationException("The collection already contains the ApplicationUser item being added.");
					}
					this.m_ApplicationUserByUserName.Add(item.FullyQualifiedUserName, item);
				}
				else
				{
					if (this.m_ApplicationUserByKey.ContainsKey(item.Key))
					{
						throw new global::System.InvalidOperationException("The collection already contains the ApplicationUser item being added.");
					}
					this.m_ApplicationUserByKey.Add(item.Key, item);
					this.m_ApplicationUserByUserName[item.FullyQualifiedUserName] = item;
				}
				this.m_ApplicationUserByGuid.Add(item.Id, item);
				this.m_SortedApplicationUser.Add(item);
				this.m_SortNeeded = true;
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x0002BAB4 File Offset: 0x00029CB4
		public void Clear()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_ApplicationUserByKey.Clear();
				this.m_ApplicationUserByUserName.Clear();
				this.m_ApplicationUserByGuid.Clear();
				this.m_SortedApplicationUser.Clear();
				this.m_SortNeeded = false;
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x0002BB20 File Offset: 0x00029D20
		public bool Contains(global::Gibraltar.Monitor.ApplicationUser item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A null ApplicationUser can not be queried in the collection.");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ApplicationUserByGuid.ContainsKey(item.Id);
			}
			return result;
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x0002BB88 File Offset: 0x00029D88
		public bool ContainsKey(global::System.Guid id)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ApplicationUserByGuid.ContainsKey(id);
			}
			return result;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x0002BBCC File Offset: 0x00029DCC
		public bool ContainsKey(string key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ApplicationUserByKey.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x0002BC10 File Offset: 0x00029E10
		public bool ContainsUserName(string userName)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ApplicationUserByUserName.ContainsKey(userName);
			}
			return result;
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x0002BC54 File Offset: 0x00029E54
		public void CopyTo(global::Gibraltar.Monitor.ApplicationUser[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("array", "Can not CopyTo a null array");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureSorted();
				((global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.ApplicationUser>)this.m_SortedApplicationUser).CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x0002BCB4 File Offset: 0x00029EB4
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_SortedApplicationUser.Count;
				}
				return count;
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001000 RID: 4096 RVA: 0x0002BCF8 File Offset: 0x00029EF8
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x0002BCFC File Offset: 0x00029EFC
		public bool Remove(global::Gibraltar.Monitor.ApplicationUser item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A null ApplicationUser can not be removed from the collection.");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				if (this.m_ApplicationUserByGuid.ContainsKey(item.Id))
				{
					this.m_SortedApplicationUser.Remove(item);
					this.m_ApplicationUserByGuid.Remove(item.Id);
					this.m_ApplicationUserByUserName.Remove(item.FullyQualifiedUserName);
					if (!string.IsNullOrEmpty(item.Key))
					{
						this.m_ApplicationUserByKey.Remove(item.Key);
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x0002BDC4 File Offset: 0x00029FC4
		public bool Remove(global::System.Guid id)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.ApplicationUser applicationUser;
				if (this.m_ApplicationUserByGuid.TryGetValue(id, out applicationUser))
				{
					this.m_SortedApplicationUser.Remove(applicationUser);
					this.m_ApplicationUserByGuid.Remove(id);
					this.m_ApplicationUserByUserName.Remove(applicationUser.FullyQualifiedUserName);
					if (!string.IsNullOrEmpty(applicationUser.Key))
					{
						this.m_ApplicationUserByKey.Remove(applicationUser.Key);
					}
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x0002BE68 File Offset: 0x0002A068
		public int IndexOf(global::Gibraltar.Monitor.ApplicationUser item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				this.EnsureSorted();
				result = this.m_SortedApplicationUser.IndexOf(item);
			}
			return result;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x0002BEB4 File Offset: 0x0002A0B4
		public void Insert(int index, global::Gibraltar.Monitor.ApplicationUser item)
		{
			throw new global::System.NotSupportedException("ApplicationUserCollection is sorted and does not support direct modification.");
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x0002BEC0 File Offset: 0x0002A0C0
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.EnsureSorted();
				global::Gibraltar.Monitor.ApplicationUser item = this.m_SortedApplicationUser[index];
				this.Remove(item);
			}
		}

		// Token: 0x170005A7 RID: 1447
		global::Gibraltar.Monitor.ApplicationUser global::System.Collections.Generic.IList<global::Gibraltar.Monitor.ApplicationUser>.this[int sortIndex]
		{
			get
			{
				return this[sortIndex];
			}
			set
			{
				throw new global::System.NotSupportedException("ApplicationUserCollection is sorted and does not support direct modification.");
			}
		}

		// Token: 0x170005A8 RID: 1448
		public global::Gibraltar.Monitor.ApplicationUser this[int sortIndex]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.ApplicationUser result;
				lock (@lock)
				{
					if (sortIndex < 0 || sortIndex >= this.m_SortedApplicationUser.Count)
					{
						throw new global::System.ArgumentOutOfRangeException("index", "Selected index is outside the range of the collection");
					}
					this.EnsureSorted();
					result = this.m_SortedApplicationUser[sortIndex];
				}
				return result;
			}
		}

		// Token: 0x170005A9 RID: 1449
		public global::Gibraltar.Monitor.ApplicationUser this[global::System.Guid id]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.ApplicationUser result;
				lock (@lock)
				{
					result = this.m_ApplicationUserByGuid[id];
				}
				return result;
			}
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0002BFE4 File Offset: 0x0002A1E4
		public bool TryGetValue(global::System.Guid id, out global::Gibraltar.Monitor.ApplicationUser applicationUser)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ApplicationUserByGuid.TryGetValue(id, out applicationUser);
			}
			return result;
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x0002C02C File Offset: 0x0002A22C
		public bool TryGetValue(string key, out global::Gibraltar.Monitor.ApplicationUser applicationUser)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new global::System.ArgumentNullException("key");
			}
			applicationUser = this.m_CachedApplicationUser;
			if (applicationUser != null && string.Equals(key, applicationUser.Key))
			{
				return true;
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				bool flag = this.m_ApplicationUserByKey.TryGetValue(key, out applicationUser);
				this.m_CachedApplicationUser = applicationUser;
				result = flag;
			}
			return result;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x0002C0B4 File Offset: 0x0002A2B4
		public bool TryFindUserName(string userName, out global::Gibraltar.Monitor.ApplicationUser applicationUser)
		{
			if (string.IsNullOrEmpty(userName))
			{
				throw new global::System.ArgumentNullException("userName");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ApplicationUserByUserName.TryGetValue(userName, out applicationUser);
			}
			return result;
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x0002C110 File Offset: 0x0002A310
		internal global::Gibraltar.Monitor.ApplicationUser TrySetValue(global::Gibraltar.Monitor.ApplicationUser user)
		{
			if (user == null)
			{
				throw new global::System.ArgumentNullException("user");
			}
			if (string.IsNullOrEmpty(user.FullyQualifiedUserName))
			{
				throw new global::System.InvalidOperationException("The provided user has no fully qualified user name");
			}
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.ApplicationUser result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.ApplicationUser applicationUser;
				if (!string.IsNullOrEmpty(user.Key) && this.m_ApplicationUserByKey.TryGetValue(user.Key, out applicationUser))
				{
					result = applicationUser;
				}
				else if (this.m_ApplicationUserByUserName.TryGetValue(user.FullyQualifiedUserName, out applicationUser))
				{
					result = applicationUser;
				}
				else
				{
					this.Add(user);
					result = user;
				}
			}
			return result;
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x0002C1CC File Offset: 0x0002A3CC
		public global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.ApplicationUser> GetEnumerator()
		{
			object @lock = this.m_Lock;
			global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.ApplicationUser> enumerator;
			lock (@lock)
			{
				this.EnsureSorted();
				enumerator = ((global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.ApplicationUser>)this.m_SortedApplicationUser).GetEnumerator();
			}
			return enumerator;
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x0002C218 File Offset: 0x0002A418
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x04000558 RID: 1368
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.ApplicationUser> m_ApplicationUserByGuid = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.ApplicationUser>();

		// Token: 0x04000559 RID: 1369
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.ApplicationUser> m_ApplicationUserByKey = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.ApplicationUser>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400055A RID: 1370
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.ApplicationUser> m_ApplicationUserByUserName = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.ApplicationUser>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400055B RID: 1371
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.ApplicationUser> m_SortedApplicationUser = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.ApplicationUser>();

		// Token: 0x0400055C RID: 1372
		private readonly object m_Lock = new object();

		// Token: 0x0400055D RID: 1373
		private bool m_SortNeeded;

		// Token: 0x0400055E RID: 1374
		private global::Gibraltar.Monitor.ApplicationUser m_CachedApplicationUser;
	}
}
