using System;
using System.Collections;
using System.Collections.Generic;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Metrics.Internal
{
	// Token: 0x02000030 RID: 48
	internal sealed class MetricDefinitionCollection : global::System.Collections.Generic.IList<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.Collections.Generic.ICollection<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.Collections.IEnumerable
	{
		// Token: 0x060002BF RID: 703 RVA: 0x00009E10 File Offset: 0x00008010
		internal MetricDefinitionCollection(global::Gibraltar.Monitor.MetricDefinitionCollection definitionCollection)
		{
			this.m_WrappedCollection = definitionCollection;
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060002C0 RID: 704 RVA: 0x00009E2C File Offset: 0x0000802C
		// (remove) Token: 0x060002C1 RID: 705 RVA: 0x00009E68 File Offset: 0x00008068
		internal event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection, global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>> CollectionChanged;

		// Token: 0x060002C2 RID: 706 RVA: 0x00009EA4 File Offset: 0x000080A4
		private void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection, global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection, global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00009ECC File Offset: 0x000080CC
		internal global::Gibraltar.Monitor.MetricDefinitionCollection WrappedCollection
		{
			get
			{
				return this.m_WrappedCollection;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00009ED4 File Offset: 0x000080D4
		internal void SyncWrappedObject(global::Gibraltar.Monitor.MetricDefinitionCollection summary)
		{
			if (summary != this.m_WrappedCollection)
			{
				this.m_WrappedCollection = summary;
			}
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00009EEC File Offset: 0x000080EC
		internal global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition Externalize(global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition)
		{
			if (metricDefinition == null)
			{
				return null;
			}
			object @lock = this.Lock;
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition result;
			lock (@lock)
			{
				global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition2;
				if (!this.m_Externalized.TryGetValue(metricDefinition, out metricDefinition2))
				{
					global::Gibraltar.Monitor.EventMetricDefinition eventMetricDefinition = metricDefinition as global::Gibraltar.Monitor.EventMetricDefinition;
					global::Gibraltar.Monitor.CustomSampledMetricDefinition customSampledMetricDefinition = metricDefinition as global::Gibraltar.Monitor.CustomSampledMetricDefinition;
					if (eventMetricDefinition != null)
					{
						metricDefinition2 = new global::Gibraltar.Agent.Metrics.EventMetricDefinition(eventMetricDefinition);
					}
					else
					{
						if (!(customSampledMetricDefinition != null))
						{
							throw new global::System.NotSupportedException(string.Format("Unable to wrap metric definition type: {0}", metricDefinition.GetType().Name));
						}
						metricDefinition2 = new global::Gibraltar.Agent.Metrics.SampledMetricDefinition(customSampledMetricDefinition);
					}
					this.m_Externalized[metricDefinition] = metricDefinition2;
				}
				result = metricDefinition2;
			}
			return result;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00009FA8 File Offset: 0x000081A8
		internal void Internalize(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition metricDefinition)
		{
			object @lock = this.Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.MetricDefinition wrappedDefinition = metricDefinition.WrappedDefinition;
				this.m_Externalized[wrappedDefinition] = metricDefinition;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00009FF4 File Offset: 0x000081F4
		internal object Lock
		{
			get
			{
				return this.m_WrappedCollection.Lock;
			}
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000A004 File Offset: 0x00008204
		public bool ContainsKey(global::System.Guid id)
		{
			return this.m_WrappedCollection.ContainsKey(id);
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000A014 File Offset: 0x00008214
		public bool ContainsKey(string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentNullException("name");
			}
			return this.m_WrappedCollection.ContainsKey(name.Trim());
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000A040 File Offset: 0x00008240
		public bool ContainsKey(string metricsSystem, string categoryName, string counterName)
		{
			return this.m_WrappedCollection.ContainsKey(metricsSystem, categoryName, counterName);
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000A050 File Offset: 0x00008250
		public bool ContainsMetricKey(global::System.Guid id)
		{
			return this.m_WrappedCollection.ContainsMetricKey(id);
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000A060 File Offset: 0x00008260
		public bool TryGetValue(global::System.Guid id, out global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition value)
		{
			object @lock = this.Lock;
			bool result;
			lock (@lock)
			{
				global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
				bool flag = this.m_WrappedCollection.TryGetValue(id, out metricDefinition);
				value = (flag ? this.Externalize(metricDefinition) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000A0C0 File Offset: 0x000082C0
		public bool TryGetValue(string name, out global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				throw new global::System.ArgumentNullException("name");
			}
			object @lock = this.Lock;
			bool result;
			lock (@lock)
			{
				global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
				bool flag = this.m_WrappedCollection.TryGetValue(name.Trim(), out metricDefinition);
				value = (flag ? this.Externalize(metricDefinition) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000A138 File Offset: 0x00008338
		public bool TryGetValue(string metricsSystem, string categoryName, string counterName, out global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition value)
		{
			object @lock = this.Lock;
			bool result;
			lock (@lock)
			{
				global::Loupe.Extensibility.Data.IMetricDefinition metricDefinition;
				bool flag = this.m_WrappedCollection.TryGetValue(metricsSystem, categoryName, counterName, out metricDefinition);
				value = (flag ? this.Externalize(metricDefinition) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000A198 File Offset: 0x00008398
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>.GetEnumerator()
		{
			global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricDefinition> wrappedCollection = this.m_WrappedCollection;
			return new global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection.Enumerator(this, wrappedCollection.GetEnumerator());
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000A1BC File Offset: 0x000083BC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricDefinition> wrappedCollection = this.m_WrappedCollection;
			return new global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection.Enumerator(this, wrappedCollection.GetEnumerator());
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000A1E0 File Offset: 0x000083E0
		public int IndexOf(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition item)
		{
			return this.m_WrappedCollection.IndexOf(item.WrappedDefinition);
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000A1F4 File Offset: 0x000083F4
		public void Insert(int index, global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition item)
		{
			throw new global::System.NotSupportedException("Setting an object by index is not supported");
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000A200 File Offset: 0x00008400
		public void RemoveAt(int index)
		{
			throw new global::System.NotSupportedException("Removing an object by index is not supported");
		}

		// Token: 0x170000F9 RID: 249
		public global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition this[int index]
		{
			get
			{
				object @lock = this.Lock;
				global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[index]);
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException("Setting an object by index is not supported");
			}
		}

		// Token: 0x170000FA RID: 250
		public global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition this[global::System.Guid id]
		{
			get
			{
				object @lock = this.Lock;
				global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[id]);
				}
				return result;
			}
		}

		// Token: 0x170000FB RID: 251
		public global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition this[string key]
		{
			get
			{
				object @lock = this.Lock;
				global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[key.Trim()]);
				}
				return result;
			}
		}

		// Token: 0x170000FC RID: 252
		public global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition this[string metricsSystem, string categoryName, string counterName]
		{
			get
			{
				object @lock = this.Lock;
				global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[metricsSystem, categoryName, counterName]);
				}
				return result;
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000A34C File Offset: 0x0000854C
		public void Add(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			object @lock = this.Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.MetricDefinition wrappedDefinition = item.WrappedDefinition;
				this.m_Externalized[wrappedDefinition] = item;
				this.m_WrappedCollection.Add(wrappedDefinition);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection, global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000A3C4 File Offset: 0x000085C4
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000A3CC File Offset: 0x000085CC
		public bool Contains(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition item)
		{
			return this.m_WrappedCollection.Contains(item.WrappedDefinition);
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000A3E0 File Offset: 0x000085E0
		public void CopyTo(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition[] array, int arrayIndex)
		{
			int num = array.Length - arrayIndex;
			if (num <= 0)
			{
				return;
			}
			global::Loupe.Extensibility.Data.IMetricDefinition[] array2 = this.m_WrappedCollection.ToArray();
			if (num > array2.Length)
			{
				num = array2.Length;
			}
			for (int i = 0; i < num; i++)
			{
				array[arrayIndex + i] = this.Externalize(array2[i]);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0000A440 File Offset: 0x00008640
		public global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition[] ToArray()
		{
			global::Loupe.Extensibility.Data.IMetricDefinition[] array = this.m_WrappedCollection.ToArray();
			int num = array.Length;
			global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition[] array2 = new global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = this.Externalize(array[i]);
			}
			return array2;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0000A48C File Offset: 0x0000868C
		public int Count
		{
			get
			{
				return this.m_WrappedCollection.Count;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060002DF RID: 735 RVA: 0x0000A49C File Offset: 0x0000869C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000A4A0 File Offset: 0x000086A0
		public bool Remove(global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040000A8 RID: 168
		private global::Gibraltar.Monitor.MetricDefinitionCollection m_WrappedCollection;

		// Token: 0x040000A9 RID: 169
		private readonly global::System.Collections.Generic.Dictionary<global::Loupe.Extensibility.Data.IMetricDefinition, global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition> m_Externalized = new global::System.Collections.Generic.Dictionary<global::Loupe.Extensibility.Data.IMetricDefinition, global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>();

		// Token: 0x02000487 RID: 1159
		private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060032E3 RID: 13027 RVA: 0x000B94F4 File Offset: 0x000B76F4
			public Enumerator(global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection collection, global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IMetricDefinition> enumerator)
			{
				this.m_Collection = collection;
				this.m_Enumerator = enumerator;
			}

			// Token: 0x060032E4 RID: 13028 RVA: 0x000B950C File Offset: 0x000B770C
			public void Dispose()
			{
				this.m_Enumerator.Dispose();
			}

			// Token: 0x060032E5 RID: 13029 RVA: 0x000B951C File Offset: 0x000B771C
			public bool MoveNext()
			{
				return this.m_Enumerator.MoveNext();
			}

			// Token: 0x060032E6 RID: 13030 RVA: 0x000B952C File Offset: 0x000B772C
			public void Reset()
			{
				this.m_Enumerator.Reset();
			}

			// Token: 0x17000EAB RID: 3755
			// (get) Token: 0x060032E7 RID: 13031 RVA: 0x000B953C File Offset: 0x000B773C
			public global::Gibraltar.Agent.Metrics.Internal.IMetricDefinition Current
			{
				get
				{
					return this.m_Collection.Externalize(this.m_Enumerator.Current);
				}
			}

			// Token: 0x17000EAC RID: 3756
			// (get) Token: 0x060032E8 RID: 13032 RVA: 0x000B9554 File Offset: 0x000B7754
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x040012E2 RID: 4834
			private readonly global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IMetricDefinition> m_Enumerator;

			// Token: 0x040012E3 RID: 4835
			private readonly global::Gibraltar.Agent.Metrics.Internal.MetricDefinitionCollection m_Collection;
		}
	}
}
