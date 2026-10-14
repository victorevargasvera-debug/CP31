using System;
using System.Collections;
using System.Collections.Generic;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000218 RID: 536
	internal class MetricPacketDictionary : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.Internal.MetricPacket>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.Internal.MetricPacket>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.Internal.MetricPacket>, global::System.Collections.IEnumerable
	{
		// Token: 0x1400007F RID: 127
		// (add) Token: 0x06001AD6 RID: 6870 RVA: 0x0005D894 File Offset: 0x0005BA94
		// (remove) Token: 0x06001AD7 RID: 6871 RVA: 0x0005D8D0 File Offset: 0x0005BAD0
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.Internal.MetricPacketDictionary, global::Gibraltar.Monitor.Internal.MetricPacket>> CollectionChanged;

		// Token: 0x06001AD8 RID: 6872 RVA: 0x0005D90C File Offset: 0x0005BB0C
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.Internal.MetricPacketDictionary, global::Gibraltar.Monitor.Internal.MetricPacket> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.Internal.MetricPacketDictionary, global::Gibraltar.Monitor.Internal.MetricPacket>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x06001AD9 RID: 6873 RVA: 0x0005D934 File Offset: 0x0005BB34
		public void Add(global::Gibraltar.Monitor.Internal.MetricPacket newMetricPacket)
		{
			if (newMetricPacket == null)
			{
				throw new global::System.ArgumentNullException("newMetricPacket", "A metric packet object must be provided to add it to the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(newMetricPacket.ID))
				{
					throw new global::System.ArgumentException("There already exists a metric packet object in the collection for the specified Id.", "newMetricPacket");
				}
				if (this.m_DictionaryByName.ContainsKey(newMetricPacket.Name))
				{
					throw new global::System.ArgumentException("There already exists a metric packet object in the collection with the specified name", "newMetricPacket");
				}
				this.m_Dictionary.Add(newMetricPacket.ID, newMetricPacket);
				this.m_DictionaryByName.Add(newMetricPacket.Name, newMetricPacket);
				this.m_List.Add(newMetricPacket);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.Internal.MetricPacketDictionary, global::Gibraltar.Monitor.Internal.MetricPacket>(this, newMetricPacket, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x06001ADA RID: 6874 RVA: 0x0005DA0C File Offset: 0x0005BC0C
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

		// Token: 0x06001ADB RID: 6875 RVA: 0x0005DA50 File Offset: 0x0005BC50
		public bool ContainsKey(string key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x0005DA94 File Offset: 0x0005BC94
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Monitor.Internal.MetricPacket value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x0005DADC File Offset: 0x0005BCDC
		public bool TryGetValue(string key, out global::Gibraltar.Monitor.Internal.MetricPacket value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x06001ADE RID: 6878 RVA: 0x0005DB24 File Offset: 0x0005BD24
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.Internal.MetricPacket> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.Internal.MetricPacket>.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x0005DB38 File Offset: 0x0005BD38
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x0005DB4C File Offset: 0x0005BD4C
		public int IndexOf(global::Gibraltar.Monitor.Internal.MetricPacket item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOf(item);
			}
			return result;
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x0005DB90 File Offset: 0x0005BD90
		public void Insert(int index, global::Gibraltar.Monitor.Internal.MetricPacket item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x0005DB98 File Offset: 0x0005BD98
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.Internal.MetricPacket victim;
			lock (@lock)
			{
				victim = this.m_List[index];
			}
			this.Remove(victim);
		}

		// Token: 0x170008E6 RID: 2278
		public global::Gibraltar.Monitor.Internal.MetricPacket this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Internal.MetricPacket result;
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

		// Token: 0x170008E7 RID: 2279
		public global::Gibraltar.Monitor.Internal.MetricPacket this[string key]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Internal.MetricPacket result;
				lock (@lock)
				{
					result = this.m_DictionaryByName[key];
				}
				return result;
			}
		}

		// Token: 0x170008E8 RID: 2280
		public global::Gibraltar.Monitor.Internal.MetricPacket this[global::System.Guid ID]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.Internal.MetricPacket result;
				lock (@lock)
				{
					result = this.m_Dictionary[ID];
				}
				return result;
			}
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x0005DCB8 File Offset: 0x0005BEB8
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
					this.m_DictionaryByName.Clear();
				}
			}
			if (count > 0)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.Internal.MetricPacketDictionary, global::Gibraltar.Monitor.Internal.MetricPacket>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
			}
		}

		// Token: 0x06001AE8 RID: 6888 RVA: 0x0005DD38 File Offset: 0x0005BF38
		public bool Contains(global::Gibraltar.Monitor.Internal.MetricPacket item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.Contains(item);
			}
			return result;
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0005DD7C File Offset: 0x0005BF7C
		public void CopyTo(global::Gibraltar.Monitor.Internal.MetricPacket[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x06001AEA RID: 6890 RVA: 0x0005DDC0 File Offset: 0x0005BFC0
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

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x06001AEB RID: 6891 RVA: 0x0005DE04 File Offset: 0x0005C004
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001AEC RID: 6892 RVA: 0x0005DE08 File Offset: 0x0005C008
		public bool Remove(global::Gibraltar.Monitor.Internal.MetricPacket victim)
		{
			bool result = false;
			if (victim == null)
			{
				throw new global::System.ArgumentNullException("victim", "A victim object must be provided to remove it from the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(victim.ID))
				{
					this.m_Dictionary.Remove(victim.ID);
					result = true;
				}
				if (this.m_DictionaryByName.ContainsKey(victim.Name))
				{
					this.m_DictionaryByName.Remove(victim.Name);
					result = true;
				}
				if (this.m_List.Contains(victim))
				{
					this.m_List.Remove(victim);
					result = true;
				}
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.Internal.MetricPacketDictionary, global::Gibraltar.Monitor.Internal.MetricPacket>(this, victim, global::Gibraltar.Monitor.CollectionAction.Removed));
			return result;
		}

		// Token: 0x040009C2 RID: 2498
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.Internal.MetricPacket> m_DictionaryByName = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Monitor.Internal.MetricPacket>();

		// Token: 0x040009C3 RID: 2499
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Internal.MetricPacket> m_Dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.Internal.MetricPacket>();

		// Token: 0x040009C4 RID: 2500
		private readonly global::System.Collections.Generic.List<global::Gibraltar.Monitor.Internal.MetricPacket> m_List = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.Internal.MetricPacket>();

		// Token: 0x040009C5 RID: 2501
		private readonly object m_Lock = new object();
	}
}
