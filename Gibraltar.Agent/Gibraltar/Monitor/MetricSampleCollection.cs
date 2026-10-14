using System;
using System.Collections;
using System.Collections.Generic;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C1 RID: 449
	internal class MetricSampleCollection : global::Loupe.Extensibility.Data.IMetricSampleCollection, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetricSample>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetricSample>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.Collections.IEnumerable
	{
		// Token: 0x1400006E RID: 110
		// (add) Token: 0x060014EA RID: 5354 RVA: 0x0003DC24 File Offset: 0x0003BE24
		// (remove) Token: 0x060014EB RID: 5355 RVA: 0x0003DC60 File Offset: 0x0003BE60
		public event global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricSampleCollection, global::Loupe.Extensibility.Data.IMetricSample>> CollectionChanged;

		// Token: 0x060014EC RID: 5356 RVA: 0x0003DC9C File Offset: 0x0003BE9C
		internal MetricSampleCollection(global::Gibraltar.Monitor.Metric metric)
		{
			this.m_Metric = metric;
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060014ED RID: 5357 RVA: 0x0003DCC4 File Offset: 0x0003BEC4
		public global::Loupe.Extensibility.Data.IMetric Metric
		{
			get
			{
				return this.m_Metric;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060014EE RID: 5358 RVA: 0x0003DCCC File Offset: 0x0003BECC
		public global::Loupe.Extensibility.Data.IMetricSample First
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricSample result;
				lock (@lock)
				{
					result = this.m_List.Values[0];
				}
				return result;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x0003DD18 File Offset: 0x0003BF18
		public global::Loupe.Extensibility.Data.IMetricSample Last
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricSample result;
				lock (@lock)
				{
					result = this.m_List.Values[this.m_List.Count - 1];
				}
				return result;
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0003DD70 File Offset: 0x0003BF70
		protected virtual void OnCollectionChanged(global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricSampleCollection, global::Loupe.Extensibility.Data.IMetricSample> e)
		{
			global::System.EventHandler<global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricSampleCollection, global::Loupe.Extensibility.Data.IMetricSample>> collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0003DD98 File Offset: 0x0003BF98
		global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IMetricSample> global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricSample>.GetEnumerator()
		{
			return this.m_List.Values.GetEnumerator();
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0003DDAC File Offset: 0x0003BFAC
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_List.GetEnumerator();
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0003DDBC File Offset: 0x0003BFBC
		public int IndexOf(global::Loupe.Extensibility.Data.IMetricSample item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_List.IndexOfKey(item.Sequence);
			}
			return result;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0003DE08 File Offset: 0x0003C008
		public void Insert(int index, global::Loupe.Extensibility.Data.IMetricSample item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0003DE10 File Offset: 0x0003C010
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Loupe.Extensibility.Data.IMetricSample metricSample;
			bool flag;
			lock (@lock)
			{
				metricSample = this.m_List.Values[index];
				flag = this.RemoveItem(metricSample);
			}
			if (flag)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricSampleCollection, global::Loupe.Extensibility.Data.IMetricSample>(this, metricSample, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
		}

		// Token: 0x17000784 RID: 1924
		public global::Loupe.Extensibility.Data.IMetricSample this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricSample result;
				lock (@lock)
				{
					result = this.m_List.Values[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0003DEC8 File Offset: 0x0003C0C8
		public void Add(global::Loupe.Extensibility.Data.IMetricSample item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A new  metric sample item must be provided to add it to the collection.");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.Add(item.Sequence, item);
			}
			this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricSampleCollection, global::Loupe.Extensibility.Data.IMetricSample>(this, item, global::Gibraltar.Monitor.CollectionAction.Added));
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0003DF34 File Offset: 0x0003C134
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
				}
			}
			if (count > 0)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricSampleCollection, global::Loupe.Extensibility.Data.IMetricSample>(this, null, global::Gibraltar.Monitor.CollectionAction.Cleared));
			}
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0003DFA0 File Offset: 0x0003C1A0
		public bool Contains(global::Loupe.Extensibility.Data.IMetricSample item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.ContainsKey(item.Sequence);
			}
			return result;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x0003DFEC File Offset: 0x0003C1EC
		public bool ContainsKey(long key)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.ContainsKey(key);
			}
			return result;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0003E030 File Offset: 0x0003C230
		public void CopyTo(global::Loupe.Extensibility.Data.IMetricSample[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_List.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0003E078 File Offset: 0x0003C278
		public global::Loupe.Extensibility.Data.IMetricSample[] ToArray()
		{
			object @lock = this.m_Lock;
			global::Gibraltar.Monitor.MetricSample[] array;
			lock (@lock)
			{
				array = new global::Gibraltar.Monitor.MetricSample[this.Count];
				this.CopyTo(array, 0);
			}
			return array;
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x0003E0C4 File Offset: 0x0003C2C4
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

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0003E108 File Offset: 0x0003C308
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x0003E10C File Offset: 0x0003C30C
		public bool Remove(global::Loupe.Extensibility.Data.IMetricSample item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A metric sample item must be provided to remove it from the collection.");
			}
			bool flag = this.RemoveItem(item);
			if (flag)
			{
				this.OnCollectionChanged(new global::Gibraltar.Monitor.CollectionChangedEventArgs<global::Loupe.Extensibility.Data.IMetricSampleCollection, global::Loupe.Extensibility.Data.IMetricSample>(this, item, global::Gibraltar.Monitor.CollectionAction.Removed));
			}
			return flag;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0003E140 File Offset: 0x0003C340
		private bool RemoveItem(global::Loupe.Extensibility.Data.IMetricSample item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_List.Remove(item.Sequence);
			}
			return result;
		}

		// Token: 0x040006C3 RID: 1731
		private readonly global::System.Collections.Generic.SortedList<long, global::Loupe.Extensibility.Data.IMetricSample> m_List = new global::System.Collections.Generic.SortedList<long, global::Loupe.Extensibility.Data.IMetricSample>();

		// Token: 0x040006C4 RID: 1732
		private readonly global::Gibraltar.Monitor.Metric m_Metric;

		// Token: 0x040006C5 RID: 1733
		private readonly object m_Lock = new object();
	}
}
