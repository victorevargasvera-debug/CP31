using System;
using System.Collections;
using System.Collections.Generic;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Metrics.Internal
{
	// Token: 0x02000031 RID: 49
	internal sealed class SampledMetricCollection
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x0000A4A8 File Offset: 0x000086A8
		internal SampledMetricCollection(global::Gibraltar.Agent.Metrics.SampledMetricDefinition metricDefinition)
		{
			this.m_MetricDefinition = metricDefinition;
			this.m_WrappedCollection = metricDefinition.WrappedDefinition.Metrics;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000A4E0 File Offset: 0x000086E0
		public bool ContainsKey(global::System.Guid key)
		{
			return this.m_WrappedCollection.ContainsKey(key);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000A4F0 File Offset: 0x000086F0
		public bool ContainsKey(string key)
		{
			return this.m_WrappedCollection.ContainsKey(key);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000A500 File Offset: 0x00008700
		public global::Gibraltar.Agent.Metrics.SampledMetric Add(string instanceName)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Agent.Metrics.SampledMetric result;
			lock (@lock)
			{
				result = new global::Gibraltar.Agent.Metrics.SampledMetric(this.m_MetricDefinition, instanceName);
			}
			return result;
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x0000A544 File Offset: 0x00008744
		public global::Gibraltar.Agent.Metrics.SampledMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000A54C File Offset: 0x0000874C
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Agent.Metrics.SampledMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.CustomSampledMetric eventMetric;
				bool flag = this.m_WrappedCollection.TryGetValue(key, out eventMetric);
				value = (flag ? this.Externalize(eventMetric) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000A5AC File Offset: 0x000087AC
		public bool TryGetValue(string key, out global::Gibraltar.Agent.Metrics.SampledMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.CustomSampledMetric eventMetric;
				bool flag = this.m_WrappedCollection.TryGetValue(key, out eventMetric);
				value = (flag ? this.Externalize(eventMetric) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x17000100 RID: 256
		public global::Gibraltar.Agent.Metrics.SampledMetric this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Agent.Metrics.SampledMetric result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[index]);
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException("Setting an object by index is not supported.");
			}
		}

		// Token: 0x17000101 RID: 257
		public global::Gibraltar.Agent.Metrics.SampledMetric this[global::System.Guid Id]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Agent.Metrics.SampledMetric result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[Id]);
				}
				return result;
			}
		}

		// Token: 0x17000102 RID: 258
		public global::Gibraltar.Agent.Metrics.SampledMetric this[string key]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Agent.Metrics.SampledMetric result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[key]);
				}
				return result;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060002EC RID: 748 RVA: 0x0000A6FC File Offset: 0x000088FC
		internal object Lock
		{
			get
			{
				return this.m_Lock;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000A704 File Offset: 0x00008904
		internal global::Gibraltar.Monitor.CustomSampledMetricDictionary WrappedCollection
		{
			get
			{
				return this.m_WrappedCollection;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000A70C File Offset: 0x0000890C
		internal global::Gibraltar.Agent.Metrics.SampledMetric Externalize(global::Gibraltar.Monitor.CustomSampledMetric eventMetric)
		{
			if (eventMetric == null)
			{
				return null;
			}
			object @lock = this.m_Lock;
			global::Gibraltar.Agent.Metrics.SampledMetric result;
			lock (@lock)
			{
				global::Gibraltar.Agent.Metrics.SampledMetric sampledMetric;
				if (!this.m_Externalized.TryGetValue(eventMetric, out sampledMetric))
				{
					sampledMetric = new global::Gibraltar.Agent.Metrics.SampledMetric(this.m_MetricDefinition, eventMetric);
					this.m_Externalized[eventMetric] = sampledMetric;
				}
				result = sampledMetric;
			}
			return result;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000A780 File Offset: 0x00008980
		internal void Internalize(global::Gibraltar.Agent.Metrics.SampledMetric metric)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.CustomSampledMetric wrappedMetric = metric.WrappedMetric;
				this.m_Externalized[wrappedMetric] = metric;
			}
		}

		// Token: 0x040000AB RID: 171
		private readonly global::Gibraltar.Monitor.CustomSampledMetricDictionary m_WrappedCollection;

		// Token: 0x040000AC RID: 172
		private readonly global::System.Collections.Generic.Dictionary<global::Gibraltar.Monitor.CustomSampledMetric, global::Gibraltar.Agent.Metrics.SampledMetric> m_Externalized = new global::System.Collections.Generic.Dictionary<global::Gibraltar.Monitor.CustomSampledMetric, global::Gibraltar.Agent.Metrics.SampledMetric>();

		// Token: 0x040000AD RID: 173
		private readonly global::Gibraltar.Agent.Metrics.SampledMetricDefinition m_MetricDefinition;

		// Token: 0x040000AE RID: 174
		private readonly object m_Lock = new object();

		// Token: 0x02000488 RID: 1160
		private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Gibraltar.Agent.Metrics.SampledMetric>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060032E9 RID: 13033 RVA: 0x000B955C File Offset: 0x000B775C
			public Enumerator(global::Gibraltar.Agent.Metrics.Internal.SampledMetricCollection collection, global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.CustomSampledMetric> enumerator)
			{
				this.m_Collection = collection;
				this.m_Enumerator = enumerator;
			}

			// Token: 0x060032EA RID: 13034 RVA: 0x000B9574 File Offset: 0x000B7774
			public void Dispose()
			{
				this.m_Enumerator.Dispose();
			}

			// Token: 0x060032EB RID: 13035 RVA: 0x000B9584 File Offset: 0x000B7784
			public bool MoveNext()
			{
				return this.m_Enumerator.MoveNext();
			}

			// Token: 0x060032EC RID: 13036 RVA: 0x000B9594 File Offset: 0x000B7794
			public void Reset()
			{
				this.m_Enumerator.Reset();
			}

			// Token: 0x17000EAD RID: 3757
			// (get) Token: 0x060032ED RID: 13037 RVA: 0x000B95A4 File Offset: 0x000B77A4
			public global::Gibraltar.Agent.Metrics.SampledMetric Current
			{
				get
				{
					return this.m_Collection.Externalize(this.m_Enumerator.Current);
				}
			}

			// Token: 0x17000EAE RID: 3758
			// (get) Token: 0x060032EE RID: 13038 RVA: 0x000B95BC File Offset: 0x000B77BC
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x040012E4 RID: 4836
			private readonly global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.CustomSampledMetric> m_Enumerator;

			// Token: 0x040012E5 RID: 4837
			private readonly global::Gibraltar.Agent.Metrics.Internal.SampledMetricCollection m_Collection;
		}
	}
}
