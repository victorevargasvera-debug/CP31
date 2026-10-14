using System;
using System.Collections;
using System.Collections.Generic;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001BE RID: 446
	internal sealed class MetricDefinitionCollection : global::Loupe.Extensibility.Data.IMetricDefinitionCollection, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x1400006C RID: 108
		// (add) Token: 0x0600149C RID: 5276 RVA: 0x0003CC74 File Offset: 0x0003AE74
		// (remove) Token: 0x0600149D RID: 5277 RVA: 0x0003CCB0 File Offset: 0x0003AEB0
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricDefinitionCollection, global::Loupe.Extensibility.Data.IMetricDefinition>> CollectionChanged;

		// Token: 0x0600149E RID: 5278 RVA: 0x0003CCEC File Offset: 0x0003AEEC
		private void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricDefinitionCollection, global::Loupe.Extensibility.Data.IMetricDefinition> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricDefinitionCollection, global::Loupe.Extensibility.Data.IMetricDefinition>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0003CD14 File Offset: 0x0003AF14
		internal void AddMetric(global::Loupe.Extensibility.Data.IMetric newMetric)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_MetricById.Add(newMetric.Id, newMetric);
			}
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0003CD5C File Offset: 0x0003AF5C
		internal void RemoveMetric(global::Loupe.Extensibility.Data.IMetric victimMetric)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_MetricById.Remove(victimMetric.Id);
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0003CDA4 File Offset: 0x0003AFA4
		public object Lock
		{
			get
			{
				return this.m_Lock;
			}
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0003CDAC File Offset: 0x0003AFAC
		internal global::Gibraltar.Monitor.MetricDefinition Add(global::Gibraltar.Monitor.Internal.MetricDefinitionPacket newDefinitionPacket)
		{
			if (newDefinitionPacket == null)
			{
				throw new global::System.ArgumentNullException("newDefinitionPacket", "A metric packet object must be provided to add it to the collection.");
			}
			global::Gibraltar.Monitor.MetricDefinition metricDefinition = new global::Gibraltar.Monitor.MetricDefinition(this, newDefinitionPacket);
			this.Add(metricDefinition);
			return metricDefinition;
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0003CDE4 File Offset: 0x0003AFE4
		public global::Loupe.Extensibility.Data.IMetric Metric(global::System.Guid metricId)
		{
			object @lock = this.m_Lock;
			global::Loupe.Extensibility.Data.IMetric result;
			lock (@lock)
			{
				result = this.m_MetricById[metricId];
			}
			return result;
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0003CE28 File Offset: 0x0003B028
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

		// Token: 0x060014A5 RID: 5285 RVA: 0x0003CE6C File Offset: 0x0003B06C
		public bool ContainsKey(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentNullException("name");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.ContainsKey(name.Trim());
			}
			return result;
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0003CECC File Offset: 0x0003B0CC
		public bool ContainsKey(string metricTypeName, string categoryName, string counterName)
		{
			string key = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName);
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0003CF1C File Offset: 0x0003B11C
		public bool ContainsMetricKey(global::System.Guid key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_MetricById.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0003CF60 File Offset: 0x0003B160
		public bool TryGetValue(global::System.Guid key, out global::Loupe.Extensibility.Data.IMetricDefinition value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_Dictionary.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060014A9 RID: 5289 RVA: 0x0003CFA8 File Offset: 0x0003B1A8
		public bool TryGetValue(string name, out global::Loupe.Extensibility.Data.IMetricDefinition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentNullException("name");
			}
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.TryGetValue(name.Trim(), out value);
			}
			return result;
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0003D008 File Offset: 0x0003B208
		public bool TryGetValue(string metricTypeName, string categoryName, string counterName, out global::Loupe.Extensibility.Data.IMetricDefinition value)
		{
			string key = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName);
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_DictionaryByName.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0003D058 File Offset: 0x0003B258
		public bool TryGetMetricValue(global::System.Guid key, out global::Loupe.Extensibility.Data.IMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_MetricById.TryGetValue(key, out value);
			}
			return result;
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0003D0A0 File Offset: 0x0003B2A0
		global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IMetricDefinition> global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricDefinition>.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0003D0B4 File Offset: 0x0003B2B4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0003D0C8 File Offset: 0x0003B2C8
		public int IndexOf(global::Loupe.Extensibility.Data.IMetricDefinition item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOf(item);
			}
			return result;
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0003D10C File Offset: 0x0003B30C
		public void Insert(int index, global::Loupe.Extensibility.Data.IMetricDefinition item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0003D114 File Offset: 0x0003B314
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700076E RID: 1902
		public global::Loupe.Extensibility.Data.IMetricDefinition this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricDefinition result;
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

		// Token: 0x1700076F RID: 1903
		public global::Loupe.Extensibility.Data.IMetricDefinition this[global::System.Guid ID]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricDefinition result;
				lock (@lock)
				{
					result = this.m_Dictionary[ID];
				}
				return result;
			}
		}

		// Token: 0x17000770 RID: 1904
		public global::Loupe.Extensibility.Data.IMetricDefinition this[string name]
		{
			get
			{
				if (string.IsNullOrEmpty(name))
				{
					throw new global::System.ArgumentNullException("name");
				}
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricDefinition result;
				lock (@lock)
				{
					result = this.m_DictionaryByName[name.Trim()];
				}
				return result;
			}
		}

		// Token: 0x17000771 RID: 1905
		public global::Loupe.Extensibility.Data.IMetricDefinition this[string metricTypeName, string categoryName, string counterName]
		{
			get
			{
				string key = global::Gibraltar.Monitor.MetricDefinition.GetKey(metricTypeName, categoryName, counterName);
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricDefinition result;
				lock (@lock)
				{
					result = this.m_DictionaryByName[key];
				}
				return result;
			}
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0003D25C File Offset: 0x0003B45C
		public void Add(global::Loupe.Extensibility.Data.IMetricDefinition item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_Dictionary.ContainsKey(item.Id))
				{
					throw new global::System.ArgumentException("The specified metric definition item is already in the collection.", "item");
				}
				if (this.m_DictionaryByName.ContainsKey(item.Name))
				{
					throw new global::System.ArgumentException("A metric definition item for the same metric is already in the collection.", "item");
				}
				this.m_Dictionary.Add(item.Id, item);
				this.m_DictionaryByName.Add(item.Name, item);
				this.m_List.Add(item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricDefinitionCollection, global::Loupe.Extensibility.Data.IMetricDefinition>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0003D330 File Offset: 0x0003B530
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0003D338 File Offset: 0x0003B538
		public bool Contains(global::Loupe.Extensibility.Data.IMetricDefinition item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.Contains(item);
			}
			return result;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0003D37C File Offset: 0x0003B57C
		public void CopyTo(global::Loupe.Extensibility.Data.IMetricDefinition[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0003D3C0 File Offset: 0x0003B5C0
		public global::Loupe.Extensibility.Data.IMetricDefinition[] ToArray()
		{
			object @lock = this.m_Lock;
			global::Loupe.Extensibility.Data.IMetricDefinition[] result;
			lock (@lock)
			{
				result = this.m_List.ToArray();
			}
			return result;
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x060014BB RID: 5307 RVA: 0x0003D404 File Offset: 0x0003B604
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

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x060014BC RID: 5308 RVA: 0x0003D448 File Offset: 0x0003B648
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0003D44C File Offset: 0x0003B64C
		public bool Remove(global::Loupe.Extensibility.Data.IMetricDefinition item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040006B5 RID: 1717
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.IMetric> m_MetricById = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.IMetric>();

		// Token: 0x040006B6 RID: 1718
		private readonly global::System.Collections.Generic.Dictionary<string, global::Loupe.Extensibility.Data.IMetricDefinition> m_DictionaryByName = new global::System.Collections.Generic.Dictionary<string, global::Loupe.Extensibility.Data.IMetricDefinition>();

		// Token: 0x040006B7 RID: 1719
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.IMetricDefinition> m_Dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Loupe.Extensibility.Data.IMetricDefinition>();

		// Token: 0x040006B8 RID: 1720
		private readonly global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IMetricDefinition> m_List = new global::System.Collections.Generic.List<global::Loupe.Extensibility.Data.IMetricDefinition>();

		// Token: 0x040006B9 RID: 1721
		private readonly object m_Lock = new object();
	}
}
