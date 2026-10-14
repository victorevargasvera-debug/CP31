using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C3 RID: 451
	internal class MetricValueCollection : global::Loupe.Extensibility.Data.IMetricValueCollection, global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetricValue>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IMetricValue>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricValue>, global::System.Collections.IEnumerable, global::System.Collections.IList, global::System.Collections.ICollection, global::Gibraltar.Monitor.Internal.IDisplayable
	{
		// Token: 0x06001511 RID: 5393 RVA: 0x0003E304 File Offset: 0x0003C504
		public MetricValueCollection(global::Gibraltar.Monitor.Metric metric, global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, string unitCaption)
		{
			this.m_Caption = metric.Caption;
			this.m_Description = metric.Description;
			this.m_Interval = interval;
			this.m_Intervals = intervals;
			this.m_UnitCaption = unitCaption;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0003E360 File Offset: 0x0003C560
		public MetricValueCollection(global::Gibraltar.Monitor.EventMetricValueDefinition trendValue, global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, string unitCaption)
		{
			this.m_Caption = trendValue.Caption;
			this.m_Description = trendValue.Description;
			this.m_Interval = interval;
			this.m_Intervals = intervals;
			this.m_UnitCaption = unitCaption;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0003E3BC File Offset: 0x0003C5BC
		public MetricValueCollection(string caption, string description, global::Loupe.Extensibility.Data.MetricSampleInterval interval, int intervals, string unitCaption)
		{
			this.m_Caption = caption;
			this.m_Description = description;
			this.m_Interval = interval;
			this.m_Intervals = intervals;
			this.m_UnitCaption = unitCaption;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0003E410 File Offset: 0x0003C610
		public MetricValueCollection(string caption, string description, global::System.TimeSpan interval, string unitCaption)
		{
			this.m_Caption = caption;
			this.m_Description = description;
			this.m_Interval = global::Loupe.Extensibility.Data.MetricSampleInterval.Millisecond;
			this.m_Intervals = (int)interval.TotalMilliseconds;
			this.m_UnitCaption = unitCaption;
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0003E468 File Offset: 0x0003C668
		// (set) Token: 0x06001516 RID: 5398 RVA: 0x0003E470 File Offset: 0x0003C670
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = value;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0003E47C File Offset: 0x0003C67C
		// (set) Token: 0x06001518 RID: 5400 RVA: 0x0003E484 File Offset: 0x0003C684
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0003E490 File Offset: 0x0003C690
		public global::Loupe.Extensibility.Data.MetricSampleInterval Interval
		{
			get
			{
				return this.m_Interval;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0003E498 File Offset: 0x0003C698
		public int Intervals
		{
			get
			{
				return this.m_Intervals;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0003E4A0 File Offset: 0x0003C6A0
		public global::System.DateTimeOffset StartDateTime
		{
			get
			{
				return this[0].Timestamp;
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0003E4B0 File Offset: 0x0003C6B0
		public global::System.DateTimeOffset EndDateTime
		{
			get
			{
				return this[this.Count - 1].Timestamp;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x0003E4C8 File Offset: 0x0003C6C8
		public double MinValue
		{
			get
			{
				return this.m_MinValueMetricValue.Value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x0003E4D8 File Offset: 0x0003C6D8
		public global::Loupe.Extensibility.Data.IMetricValue MinValueMetricValue
		{
			get
			{
				return this.m_MinValueMetricValue;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
		public double MaxValue
		{
			get
			{
				return this.m_MaxValueMetricValue.Value;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0003E4F4 File Offset: 0x0003C6F4
		public global::Loupe.Extensibility.Data.IMetricValue MaxValueMetricValue
		{
			get
			{
				return this.m_MaxValueMetricValue;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0003E500 File Offset: 0x0003C700
		public double AverageValue
		{
			get
			{
				object @lock = this.m_Lock;
				double averageValue;
				lock (@lock)
				{
					averageValue = this.m_AverageValue;
				}
				return averageValue;
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0003E540 File Offset: 0x0003C740
		public double PercentileValue
		{
			get
			{
				object @lock = this.m_Lock;
				double percentileValue;
				lock (@lock)
				{
					if (!this.m_StatsCurrent)
					{
						this.CalculateValues();
					}
					percentileValue = this.m_PercentileValue;
				}
				return percentileValue;
			}
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x0003E590 File Offset: 0x0003C790
		public string UnitCaption
		{
			get
			{
				return this.m_UnitCaption;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0003E598 File Offset: 0x0003C798
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.m_ValueList.Values.GetEnumerator();
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0003E5AC File Offset: 0x0003C7AC
		global::System.Collections.Generic.IEnumerator<global::Loupe.Extensibility.Data.IMetricValue> global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricValue>.GetEnumerator()
		{
			return this.m_ValueList.Values.GetEnumerator();
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0003E5C0 File Offset: 0x0003C7C0
		public int IndexOf(global::Loupe.Extensibility.Data.IMetricValue item)
		{
			object @lock = this.m_Lock;
			int result;
			lock (@lock)
			{
				result = this.m_ValueList.IndexOfKey(item);
			}
			return result;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0003E604 File Offset: 0x0003C804
		public void Insert(int index, global::Loupe.Extensibility.Data.IMetricValue item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0003E60C File Offset: 0x0003C80C
		public void RemoveAt(int index)
		{
			object @lock = this.m_Lock;
			global::Loupe.Extensibility.Data.IMetricValue item;
			lock (@lock)
			{
				item = this.m_ValueList.Values[index];
			}
			this.Remove(item);
		}

		// Token: 0x1700079A RID: 1946
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return ((global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IMetricValue>)this)[index];
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700079B RID: 1947
		public global::Loupe.Extensibility.Data.IMetricValue this[int index]
		{
			get
			{
				object @lock = this.m_Lock;
				global::Loupe.Extensibility.Data.IMetricValue result;
				lock (@lock)
				{
					result = this.m_ValueList.Values[index];
				}
				return result;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x0003E6C4 File Offset: 0x0003C8C4
		public void Add(global::Loupe.Extensibility.Data.IMetricValue item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "No metric value item was provided to add to the collection");
			}
			if (item.ValueCollection != this)
			{
				throw new global::System.ArgumentException("The provided metric value item was not created for this metric value set.", "item");
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_ValueList.Add(item, item);
				global::Gibraltar.Monitor.MetricValue metricValue = (global::Gibraltar.Monitor.MetricValue)item;
				if (this.m_MinValueMetricValue == null)
				{
					this.m_MinValueMetricValue = metricValue;
				}
				else if (this.m_MinValueMetricValue.Value > metricValue.Value)
				{
					this.m_MinValueMetricValue = metricValue;
				}
				if (this.m_MaxValueMetricValue == null)
				{
					this.m_MaxValueMetricValue = metricValue;
				}
				else if (this.m_MaxValueMetricValue.Value < metricValue.Value)
				{
					this.m_MaxValueMetricValue = metricValue;
				}
				this.m_AverageValue = (metricValue.Value - this.m_AverageValue) / (double)this.m_ValueList.Count + this.m_AverageValue;
				this.m_StatsCurrent = false;
			}
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x0003E7F4 File Offset: 0x0003C9F4
		public int Add(object value)
		{
			this.Add((global::Loupe.Extensibility.Data.IMetricValue)value);
			return this.IndexOf((global::Loupe.Extensibility.Data.IMetricValue)value);
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0003E810 File Offset: 0x0003CA10
		public bool Contains(object value)
		{
			return this.Contains((global::Loupe.Extensibility.Data.IMetricValue)value);
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0003E820 File Offset: 0x0003CA20
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x0003E828 File Offset: 0x0003CA28
		public int IndexOf(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x0003E830 File Offset: 0x0003CA30
		public void Insert(int index, object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x0003E838 File Offset: 0x0003CA38
		public bool Contains(global::Loupe.Extensibility.Data.IMetricValue item)
		{
			object @lock = this.m_Lock;
			bool result;
			lock (@lock)
			{
				result = this.m_ValueList.ContainsKey(item);
			}
			return result;
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0003E87C File Offset: 0x0003CA7C
		public void CopyTo(global::Loupe.Extensibility.Data.IMetricValue[] array, int arrayIndex)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_ValueList.Values.CopyTo(array, arrayIndex);
			}
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x0003E8C4 File Offset: 0x0003CAC4
		public void CopyTo(global::System.Array array, int index)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_ValueList.Values.CopyTo((global::Loupe.Extensibility.Data.IMetricValue[])array, index);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0003E914 File Offset: 0x0003CB14
		public int Count
		{
			get
			{
				object @lock = this.m_Lock;
				int count;
				lock (@lock)
				{
					count = this.m_ValueList.Count;
				}
				return count;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x0003E958 File Offset: 0x0003CB58
		public object SyncRoot
		{
			get
			{
				return this.m_Lock;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0003E960 File Offset: 0x0003CB60
		public bool IsSynchronized
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x0003E964 File Offset: 0x0003CB64
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0003E968 File Offset: 0x0003CB68
		public bool IsFixedSize
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600153B RID: 5435 RVA: 0x0003E96C File Offset: 0x0003CB6C
		public bool Remove(global::Loupe.Extensibility.Data.IMetricValue item)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600153C RID: 5436 RVA: 0x0003E974 File Offset: 0x0003CB74
		public void Remove(object value)
		{
			this.Remove((global::Loupe.Extensibility.Data.IMetricValue)value);
		}

		// Token: 0x0600153D RID: 5437 RVA: 0x0003E984 File Offset: 0x0003CB84
		internal long GetSampleSequence()
		{
			return global::System.Threading.Interlocked.Increment(ref this.m_SampleSequence);
		}

		// Token: 0x0600153E RID: 5438 RVA: 0x0003E994 File Offset: 0x0003CB94
		private void CalculateValues()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				int num = 0;
				double[] array = new double[this.Count];
				foreach (global::Loupe.Extensibility.Data.IMetricValue metricValue in ((global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IMetricValue>)this))
				{
					array[num] = metricValue.Value;
					num++;
				}
				int num2 = global::System.Convert.ToInt32(0.95 * (double)num);
				if (num > 0)
				{
					global::System.Array.Sort<double>(array);
				}
				if (num2 > 0)
				{
					this.m_PercentileValue = array[num2 - 1];
				}
				else if (num == 1)
				{
					this.m_PercentileValue = array[0];
				}
				else
				{
					this.m_PercentileValue = 0.0;
				}
				this.m_StatsCurrent = true;
			}
		}

		// Token: 0x040006CB RID: 1739
		private readonly global::System.Collections.Generic.SortedList<global::Loupe.Extensibility.Data.IMetricValue, global::Loupe.Extensibility.Data.IMetricValue> m_ValueList = new global::System.Collections.Generic.SortedList<global::Loupe.Extensibility.Data.IMetricValue, global::Loupe.Extensibility.Data.IMetricValue>();

		// Token: 0x040006CC RID: 1740
		private readonly object m_Lock = new object();

		// Token: 0x040006CD RID: 1741
		private readonly string m_UnitCaption;

		// Token: 0x040006CE RID: 1742
		private readonly global::Loupe.Extensibility.Data.MetricSampleInterval m_Interval;

		// Token: 0x040006CF RID: 1743
		private readonly int m_Intervals;

		// Token: 0x040006D0 RID: 1744
		private string m_Caption;

		// Token: 0x040006D1 RID: 1745
		private string m_Description;

		// Token: 0x040006D2 RID: 1746
		private volatile global::Gibraltar.Monitor.MetricValue m_MinValueMetricValue;

		// Token: 0x040006D3 RID: 1747
		private volatile global::Gibraltar.Monitor.MetricValue m_MaxValueMetricValue;

		// Token: 0x040006D4 RID: 1748
		private double m_AverageValue;

		// Token: 0x040006D5 RID: 1749
		private double m_PercentileValue;

		// Token: 0x040006D6 RID: 1750
		private bool m_StatsCurrent;

		// Token: 0x040006D7 RID: 1751
		private long m_SampleSequence;
	}
}
