using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001CC RID: 460
	internal sealed class PerfCounterCollection : global::System.Collections.Generic.IList<global::Gibraltar.Monitor.PerfCounterMetric>, global::System.Collections.Generic.ICollection<global::Gibraltar.Monitor.PerfCounterMetric>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.PerfCounterMetric>, global::System.Collections.IEnumerable, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x14000070 RID: 112
		// (add) Token: 0x060015D4 RID: 5588 RVA: 0x000418B4 File Offset: 0x0003FAB4
		// (remove) Token: 0x060015D5 RID: 5589 RVA: 0x000418F0 File Offset: 0x0003FAF0
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.PerfCounterCollection, global::Gibraltar.Monitor.PerfCounterMetric>> CollectionChanged;

		// Token: 0x060015D6 RID: 5590 RVA: 0x0004192C File Offset: 0x0003FB2C
		public PerfCounterCollection(string caption, string description)
		{
			this.m_CounterMetricDictionary = new global::System.Collections.Generic.SortedDictionary<string, global::Gibraltar.Monitor.PerfCounterMetric>();
			this.m_CounterMetricList = new global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.PerfCounterMetric, global::Gibraltar.Monitor.PerfCounterMetric>();
			this.m_Caption = caption;
			this.m_Description = description;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00041964 File Offset: 0x0003FB64
		private void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.PerfCounterCollection, global::Gibraltar.Monitor.PerfCounterMetric> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.PerfCounterCollection, global::Gibraltar.Monitor.PerfCounterMetric>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0004198C File Offset: 0x0003FB8C
		public void Add(global::System.Diagnostics.PerformanceCounter newPerformanceCounter)
		{
			if (newPerformanceCounter == null)
			{
				throw new global::System.ArgumentNullException("newPerformanceCounter", "A performance counter object must be provided to add it to the collection.");
			}
			string key = global::Gibraltar.Monitor.PerfCounterMetric.GetKey(newPerformanceCounter);
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_CounterMetricDictionary.ContainsKey(key))
				{
					throw new global::System.ArgumentException("The specified performance counter is already in the collection.", "newPerformanceCounter");
				}
				global::Gibraltar.Monitor.PerfCounterMetric item = global::Gibraltar.Monitor.PerfCounterMetric.AddOrGet(newPerformanceCounter);
				this.Add(item);
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00041A10 File Offset: 0x0003FC10
		public void Add(string categoryName, string counterName)
		{
			this.Add(categoryName, counterName, string.Empty);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00041A20 File Offset: 0x0003FC20
		public void Add(string categoryName, string counterName, string instanceName)
		{
			if (string.IsNullOrEmpty(categoryName))
			{
				throw new global::System.ArgumentNullException("categoryName");
			}
			if (string.IsNullOrEmpty(counterName))
			{
				throw new global::System.ArgumentNullException("counterName");
			}
			global::Gibraltar.Monitor.PerfCounterMetric item = global::Gibraltar.Monitor.PerfCounterMetric.AddOrGet(categoryName, counterName, instanceName);
			this.Add(item);
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00041A70 File Offset: 0x0003FC70
		public void Add(string categoryName, string counterName, global::Gibraltar.Monitor.PerfCounterInstanceAlias alias)
		{
			if (string.IsNullOrEmpty(categoryName))
			{
				throw new global::System.ArgumentNullException("categoryName");
			}
			if (string.IsNullOrEmpty(counterName))
			{
				throw new global::System.ArgumentNullException("counterName");
			}
			global::Gibraltar.Monitor.PerfCounterMetric item = global::Gibraltar.Monitor.PerfCounterMetric.AddOrGet(categoryName, counterName, alias);
			this.Add(item);
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x00041AC0 File Offset: 0x0003FCC0
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x00041AC8 File Offset: 0x0003FCC8
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = value.Trim();
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x00041AD8 File Offset: 0x0003FCD8
		// (set) Token: 0x060015DF RID: 5599 RVA: 0x00041AE0 File Offset: 0x0003FCE0
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value.Trim();
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00041AF0 File Offset: 0x0003FCF0
		public bool ContainsKey(string categoryName, string counterName)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_CounterMetricDictionary.ContainsKey(global::Gibraltar.Monitor.PerfCounterMetric.GetKey(categoryName, counterName, string.Empty));
			}
			return result;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00041B40 File Offset: 0x0003FD40
		public bool ContainsKey(string categoryName, string counterName, string instanceName)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_CounterMetricDictionary.ContainsKey(global::Gibraltar.Monitor.PerfCounterMetric.GetKey(categoryName, counterName, instanceName));
			}
			return result;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00041B8C File Offset: 0x0003FD8C
		public void WriteSamples()
		{
			global::System.Collections.Generic.List<global::Gibraltar.Monitor.MetricSample> list = new global::System.Collections.Generic.List<global::Gibraltar.Monitor.MetricSample>(this.Count);
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.PerfCounterMetric[] array;
			lock (@lock)
			{
				array = new global::Gibraltar.Monitor.PerfCounterMetric[this.Count];
				this.CopyTo(array, 0);
			}
			foreach (global::Gibraltar.Monitor.PerfCounterMetric perfCounterMetric in array)
			{
				try
				{
					global::System.Diagnostics.PerformanceCounter performanceCounter = perfCounterMetric.GetPerformanceCounter();
					global::Gibraltar.Monitor.PerfCounterMetricSample item = new global::Gibraltar.Monitor.PerfCounterMetricSample(perfCounterMetric, new global::Gibraltar.Monitor.Internal.PerfCounterMetricSamplePacket(performanceCounter, perfCounterMetric));
					list.Add(item);
					perfCounterMetric.PollingState = global::Gibraltar.Monitor.PerfCounterPollingState.Active;
				}
				catch (global::System.Exception ex)
				{
					if (perfCounterMetric != null && perfCounterMetric.PollingState != global::Gibraltar.Monitor.PerfCounterPollingState.Error)
					{
						perfCounterMetric.PollingState = global::Gibraltar.Monitor.PerfCounterPollingState.Error;
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Gibraltar.Agent", "Performance counter error", "The performance counter {0} threw an exception ({1}) while being polled, and will be excluded from metrics until it can be successfully polled again.\r\nException message: {2}", new object[]
							{
								perfCounterMetric.Name,
								ex.GetType().Name,
								ex.Message
							});
						}
					}
				}
			}
			global::Gibraltar.Monitor.Log.Write(list);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00041CBC File Offset: 0x0003FEBC
		public bool TryGetValue(string categoryName, string counterName, out global::Gibraltar.Monitor.PerfCounterMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_CounterMetricDictionary.TryGetValue(global::Gibraltar.Monitor.PerfCounterMetric.GetKey(categoryName, counterName, string.Empty), out value);
			}
			return result;
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00041D0C File Offset: 0x0003FF0C
		public bool TryGetValue(string categoryName, string counterName, string instanceName, out global::Gibraltar.Monitor.PerfCounterMetric value)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_CounterMetricDictionary.TryGetValue(global::Gibraltar.Monitor.PerfCounterMetric.GetKey(categoryName, counterName, instanceName), out value);
			}
			return result;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00041D5C File Offset: 0x0003FF5C
		global::System.Collections.Generic.IEnumerator<global::Gibraltar.Monitor.PerfCounterMetric> global::System.Collections.Generic.IEnumerable<global::Gibraltar.Monitor.PerfCounterMetric>.GetEnumerator()
		{
			return this.m_CounterMetricDictionary.Values.GetEnumerator();
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00041D74 File Offset: 0x0003FF74
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_CounterMetricDictionary.GetEnumerator();
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00041D88 File Offset: 0x0003FF88
		public int IndexOf(global::Gibraltar.Monitor.PerfCounterMetric item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_CounterMetricList.IndexOfValue(item);
			}
			return result;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00041DCC File Offset: 0x0003FFCC
		public void Insert(int index, global::Gibraltar.Monitor.PerfCounterMetric item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00041DD4 File Offset: 0x0003FFD4
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.PerfCounterMetric item;
			lock (@lock)
			{
				item = this.m_CounterMetricList.Values[index];
			}
			this.Remove(item);
		}

		// Token: 0x170007CA RID: 1994
		public global::Gibraltar.Monitor.PerfCounterMetric this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Gibraltar.Monitor.PerfCounterMetric result;
				lock (@lock)
				{
					result = this.m_CounterMetricList.Values[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00041E78 File Offset: 0x00040078
		public void Add(global::Gibraltar.Monitor.PerfCounterMetric item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "An existing performance counter metric item must be provided to add it to the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_CounterMetricDictionary.ContainsKey(item.Name))
				{
					throw new global::System.ArgumentException("The specified performance counter metric item is already in the collection.", "item");
				}
				this.m_CounterMetricDictionary.Add(item.Name, item);
				this.m_CounterMetricList.Add(item, item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.PerfCounterCollection, global::Gibraltar.Monitor.PerfCounterMetric>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x00041F20 File Offset: 0x00040120
		public void Clear()
		{
			object @lock = this.m_Lock;
			int count;
			lock (@lock)
			{
				count = this.m_CounterMetricList.Count;
				if (count > 0)
				{
					this.m_CounterMetricList.Clear();
				}
			}
			if (count > 0)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.PerfCounterCollection, global::Gibraltar.Monitor.PerfCounterMetric>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00041F8C File Offset: 0x0004018C
		public bool Contains(global::Gibraltar.Monitor.PerfCounterMetric item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_CounterMetricList.ContainsValue(item);
			}
			return result;
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00041FD0 File Offset: 0x000401D0
		public void CopyTo(global::Gibraltar.Monitor.PerfCounterMetric[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_CounterMetricList.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x00042018 File Offset: 0x00040218
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_CounterMetricList.Count;
				}
				return count;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x060015F1 RID: 5617 RVA: 0x0004205C File Offset: 0x0004025C
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00042060 File Offset: 0x00040260
		public bool Remove(global::Gibraltar.Monitor.PerfCounterMetric item)
		{
			bool flag = false;
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A performance counter metric item must be provided to remove it from the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_CounterMetricDictionary.ContainsKey(item.Name))
				{
					this.m_CounterMetricList.Remove(item);
					flag = true;
				}
				if (this.m_CounterMetricList.ContainsKey(item))
				{
					this.m_CounterMetricList.Remove(item);
					flag = true;
				}
			}
			if (flag)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Gibraltar.Monitor.PerfCounterCollection, global::Gibraltar.Monitor.PerfCounterMetric>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x0400070C RID: 1804
		private string m_Caption;

		// Token: 0x0400070D RID: 1805
		private string m_Description;

		// Token: 0x0400070E RID: 1806
		private readonly global::System.Collections.Generic.SortedDictionary<string, global::Gibraltar.Monitor.PerfCounterMetric> m_CounterMetricDictionary;

		// Token: 0x0400070F RID: 1807
		private readonly global::System.Collections.Generic.SortedList<global::Gibraltar.Monitor.PerfCounterMetric, global::Gibraltar.Monitor.PerfCounterMetric> m_CounterMetricList;

		// Token: 0x04000710 RID: 1808
		private readonly object m_Lock = new object();
	}
}
