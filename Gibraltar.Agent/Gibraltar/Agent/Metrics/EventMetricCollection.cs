using System;
using System.Collections;
using System.Collections.Generic;
using Gibraltar.Monitor;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x0200001F RID: 31
	internal class EventMetricCollection
	{
		// Token: 0x060001A9 RID: 425 RVA: 0x00005D20 File Offset: 0x00003F20
		public EventMetricCollection(global::Gibraltar.Agent.Metrics.EventMetricDefinition metricDefinition)
		{
			this.m_MetricDefinition = metricDefinition;
			this.m_WrappedCollection = metricDefinition.WrappedDefinition.Metrics;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00005D58 File Offset: 0x00003F58
		public bool ContainsKey(global::System.Guid key)
		{
			return this.m_WrappedCollection.ContainsKey(key);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00005D68 File Offset: 0x00003F68
		public bool ContainsKey(string key)
		{
			return this.m_WrappedCollection.ContainsKey(key);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00005D78 File Offset: 0x00003F78
		public global::Gibraltar.Agent.Metrics.EventMetric Add(string instanceName)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Agent.Metrics.EventMetric result;
			lock (@lock)
			{
				result = new global::Gibraltar.Agent.Metrics.EventMetric(this.m_MetricDefinition, instanceName);
			}
			return result;
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00005DBC File Offset: 0x00003FBC
		public global::Gibraltar.Agent.Metrics.EventMetricDefinition Definition
		{
			get
			{
				return this.m_MetricDefinition;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005DC4 File Offset: 0x00003FC4
		public bool TryGetValue(global::System.Guid key, out global::Gibraltar.Agent.Metrics.EventMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.EventMetric eventMetric;
				bool flag = this.m_WrappedCollection.TryGetValue(key, out eventMetric);
				value = (flag ? this.Externalize(eventMetric) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00005E24 File Offset: 0x00004024
		public bool TryGetValue(string key, out global::Gibraltar.Agent.Metrics.EventMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.EventMetric eventMetric;
				bool flag = this.m_WrappedCollection.TryGetValue(key, out eventMetric);
				value = (flag ? this.Externalize(eventMetric) : null);
				result = flag;
			}
			return result;
		}

		// Token: 0x17000083 RID: 131
		public global::Gibraltar.Agent.Metrics.EventMetric this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Agent.Metrics.EventMetric result;
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

		// Token: 0x17000084 RID: 132
		public global::Gibraltar.Agent.Metrics.EventMetric this[global::System.Guid Id]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Agent.Metrics.EventMetric result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[Id]);
				}
				return result;
			}
		}

		// Token: 0x17000085 RID: 133
		public global::Gibraltar.Agent.Metrics.EventMetric this[string key]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Agent.Metrics.EventMetric result;
				lock (@lock)
				{
					result = this.Externalize(this.m_WrappedCollection[key]);
				}
				return result;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00005F74 File Offset: 0x00004174
		internal object Lock
		{
			get
			{
				return this.m_Lock;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00005F7C File Offset: 0x0000417C
		internal global::Gibraltar.Monitor.EventMetricCollection WrappedCollection
		{
			get
			{
				return this.m_WrappedCollection;
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00005F84 File Offset: 0x00004184
		internal global::Gibraltar.Agent.Metrics.EventMetric Externalize(global::Gibraltar.Monitor.EventMetric eventMetric)
		{
			if (eventMetric == null)
			{
				return null;
			}
			object @lock = this.m_Lock;
			global::Gibraltar.Agent.Metrics.EventMetric result;
			lock (@lock)
			{
				global::Gibraltar.Agent.Metrics.EventMetric eventMetric2;
				if (!this.m_Externalized.TryGetValue(eventMetric, out eventMetric2))
				{
					eventMetric2 = new global::Gibraltar.Agent.Metrics.EventMetric(this.m_MetricDefinition, eventMetric);
					this.m_Externalized[eventMetric] = eventMetric2;
				}
				result = eventMetric2;
			}
			return result;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00005FF8 File Offset: 0x000041F8
		internal void Internalize(global::Gibraltar.Agent.Metrics.EventMetric metric)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.EventMetric wrappedMetric = metric.WrappedMetric;
				this.m_Externalized[wrappedMetric] = metric;
			}
		}

		// Token: 0x04000064 RID: 100
		private readonly global::Gibraltar.Monitor.EventMetricCollection m_WrappedCollection;

		// Token: 0x04000065 RID: 101
		private readonly global::System.Collections.Generic.Dictionary<global::Gibraltar.Monitor.EventMetric, global::Gibraltar.Agent.Metrics.EventMetric> m_Externalized = new global::System.Collections.Generic.Dictionary<global::Gibraltar.Monitor.EventMetric, global::Gibraltar.Agent.Metrics.EventMetric>();

		// Token: 0x04000066 RID: 102
		private readonly global::Gibraltar.Agent.Metrics.EventMetricDefinition m_MetricDefinition;

		// Token: 0x04000067 RID: 103
		private readonly object m_Lock = new object();

		// Token: 0x02000485 RID: 1157
		private class Enumerator : global::System.Collections.Generic.IEnumerator<global::Gibraltar.Agent.Metrics.EventMetric>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x060032D7 RID: 13015 RVA: 0x000B9424 File Offset: 0x000B7624
			public Enumerator(global::Gibraltar.Agent.Metrics.EventMetricCollection collection, global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.EventMetric> enumerator)
			{
				this.m_Collection = collection;
				this.m_Enumerator = enumerator;
			}

			// Token: 0x060032D8 RID: 13016 RVA: 0x000B943C File Offset: 0x000B763C
			public void Dispose()
			{
				this.m_Enumerator.Dispose();
			}

			// Token: 0x060032D9 RID: 13017 RVA: 0x000B944C File Offset: 0x000B764C
			public bool MoveNext()
			{
				return this.m_Enumerator.MoveNext();
			}

			// Token: 0x060032DA RID: 13018 RVA: 0x000B945C File Offset: 0x000B765C
			public void Reset()
			{
				this.m_Enumerator.Reset();
			}

			// Token: 0x17000EA7 RID: 3751
			// (get) Token: 0x060032DB RID: 13019 RVA: 0x000B946C File Offset: 0x000B766C
			public global::Gibraltar.Agent.Metrics.EventMetric Current
			{
				get
				{
					return this.m_Collection.Externalize(this.m_Enumerator.Current);
				}
			}

			// Token: 0x17000EA8 RID: 3752
			// (get) Token: 0x060032DC RID: 13020 RVA: 0x000B9484 File Offset: 0x000B7684
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x040012DE RID: 4830
			private readonly global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.EventMetric> m_Enumerator;

			// Token: 0x040012DF RID: 4831
			private readonly global::Gibraltar.Agent.Metrics.EventMetricCollection m_Collection;
		}
	}
}
