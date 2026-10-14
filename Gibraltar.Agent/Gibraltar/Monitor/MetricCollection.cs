using System;
using System.Collections;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001BF RID: 447
	internal class MetricCollection : global::Loupe.Extensibility.Data.IMetricCollection, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetric>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetric>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetric>, global::System.Collections.IEnumerable
	{
		// Token: 0x1400006D RID: 109
		// (add) Token: 0x060014BF RID: 5311 RVA: 0x0003D494 File Offset: 0x0003B694
		// (remove) Token: 0x060014C0 RID: 5312 RVA: 0x0003D4D0 File Offset: 0x0003B6D0
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricCollection, global::Loupe.Extensibility.Data.IMetric>> CollectionChanged;

		// Token: 0x060014C1 RID: 5313 RVA: 0x0003D50C File Offset: 0x0003B70C
		internal MetricCollection(global::Gibraltar.Monitor.MetricDefinition metricDefinition)
		{
			if (metricDefinition == null)
			{
				throw new global::System.ArgumentNullException("metricDefinition");
			}
			this.m_MetricDefinition = metricDefinition;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0003D570 File Offset: 0x0003B770
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricCollection, global::Loupe.Extensibility.Data.IMetric> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricCollection, global::Loupe.Extensibility.Data.IMetric>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x060014C3 RID: 5315 RVA: 0x0003D598 File Offset: 0x0003B798
		internal object Lock
		{
			get
			{
				return this.m_Lock;
			}
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0003D5A0 File Offset: 0x0003B7A0
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

		// Token: 0x060014C5 RID: 5317 RVA: 0x0003D5E4 File Offset: 0x0003B7E4
		public bool ContainsKey(string key)
		{
			string key2 = global::Gibraltar.Monitor.MetricDefinition.NormalizeKey(this.m_MetricDefinition, key);
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.ContainsKey(key2);
			}
			return result;
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x060014C6 RID: 5318 RVA: 0x0003D638 File Offset: 0x0003B838
		public global::Loupe.Extensibility.Data.IMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0003D640 File Offset: 0x0003B840
		public bool TryGetValue(global::System.Guid key, out global::Loupe.Extensibility.Data.IMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0003D688 File Offset: 0x0003B888
		public bool TryGetValue(string key, out global::Loupe.Extensibility.Data.IMetric value)
		{
			string key2 = global::Gibraltar.Monitor.MetricDefinition.NormalizeKey(this.m_MetricDefinition, key);
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.TryGetValue(key2, out value);
			}
			return result;
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0003D6DC File Offset: 0x0003B8DC
		global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IMetric> global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetric>.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0003D6F0 File Offset: 0x0003B8F0
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0003D704 File Offset: 0x0003B904
		public int IndexOf(global::Loupe.Extensibility.Data.IMetric item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOf(item);
			}
			return result;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0003D748 File Offset: 0x0003B948
		public void Insert(int index, global::Loupe.Extensibility.Data.IMetric item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060014CD RID: 5325 RVA: 0x0003D750 File Offset: 0x0003B950
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000776 RID: 1910
		public global::Loupe.Extensibility.Data.IMetric this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetric result;
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

		// Token: 0x17000777 RID: 1911
		public global::Loupe.Extensibility.Data.IMetric this[global::System.Guid Id]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetric result;
				lock (@lock)
				{
					result = this.m_Dictionary[Id];
				}
				return result;
			}
		}

		// Token: 0x17000778 RID: 1912
		public global::Loupe.Extensibility.Data.IMetric this[string key]
		{
			get
			{
				string key2 = global::Gibraltar.Monitor.MetricDefinition.NormalizeKey(this.m_MetricDefinition, key);
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetric result;
				lock (@lock)
				{
					result = this.m_DictionaryByName[key2];
				}
				return result;
			}
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x0003D83C File Offset: 0x0003BA3C
		public void Add(global::Loupe.Extensibility.Data.IMetric item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A metric item must be provided to add it to the collection.");
			}
			if (global::Gibraltar.Monitor.MetricDefinition.GetKey(item) != this.m_MetricDefinition.Name)
			{
				throw new global::System.ArgumentOutOfRangeException("item", "The provided metric item is not related to the metric definition that owns this metrics collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Id))
				{
					throw new global::System.ArgumentException("The specified metric item is already in the collection.", "item");
				}
				if (this.m_DictionaryByName.ContainsKey(item.Name))
				{
					throw new global::System.ArgumentException("A metric item for the same metric is already in the collection.", "item");
				}
				this.m_Dictionary.Add(item.Id, item);
				this.m_DictionaryByName.Add(item.Name, item);
				this.m_List.Add(item);
				((global::Gibraltar.Monitor.MetricDefinitionCollection)this.m_MetricDefinition.Definitions).AddMetric(item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricCollection, global::Loupe.Extensibility.Data.IMetric>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x0003D954 File Offset: 0x0003BB54
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x0003D95C File Offset: 0x0003BB5C
		public bool Contains(global::Loupe.Extensibility.Data.IMetric item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.Contains(item);
			}
			return result;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x0003D9A0 File Offset: 0x0003BBA0
		public void CopyTo(global::Loupe.Extensibility.Data.IMetric[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x0003D9E4 File Offset: 0x0003BBE4
		public global::Loupe.Extensibility.Data.IMetric[] ToArray()
		{
			object @lock = this.m_Lock;
			global::Loupe.Extensibility.Data.IMetric[] result;
			lock (@lock)
			{
				result = this.m_List.ToArray();
			}
			return result;
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x060014D7 RID: 5335 RVA: 0x0003DA28 File Offset: 0x0003BC28
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

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x060014D8 RID: 5336 RVA: 0x0003DA6C File Offset: 0x0003BC6C
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0003DA70 File Offset: 0x0003BC70
		public bool Remove(global::Loupe.Extensibility.Data.IMetric item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040006BB RID: 1723
		private readonly global::System.Collections.Generic.Dictionary<string, global::Loupe.Extensibility.Data.IMetric> m_DictionaryByName = new global::System.Collections.Generic.Dictionary<string, global::Loupe.Extensibility.Data.IMetric>();

		// Token: 0x040006BC RID: 1724
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.IMetric> m_Dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.IMetric>();

		// Token: 0x040006BD RID: 1725
		private readonly global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IMetric> m_List = new global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IMetric>();

		// Token: 0x040006BE RID: 1726
		private readonly object m_Lock = new object();

		// Token: 0x040006BF RID: 1727
		private readonly global::Gibraltar.Monitor.MetricDefinition m_MetricDefinition;
	}
}
