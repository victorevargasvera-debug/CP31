using System;
using System.Diagnostics;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C2 RID: 450
	[global::System.Diagnostics.DebuggerDisplay("{Sequence}: {Timestamp} Value={Value}")]
	internal class MetricValue : global::Loupe.Extensibility.Data.IMetricValue, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricValue>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricValue>
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x0003E18C File Offset: 0x0003C38C
		public MetricValue(global::Gibraltar.Monitor.MetricValueCollection metricValueCollection, global::System.DateTimeOffset timeStamp, double value)
		{
			this.m_MetricValueCollection = metricValueCollection;
			this.m_TimeStamp = timeStamp;
			this.m_Value = value;
			this.m_Sequence = metricValueCollection.GetSampleSequence();
			this.m_MetricValueCollection.Add(this);
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x0003E1C4 File Offset: 0x0003C3C4
		public global::Loupe.Extensibility.Data.IMetricValueCollection ValueCollection
		{
			get
			{
				return this.m_MetricValueCollection;
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0003E1CC File Offset: 0x0003C3CC
		public virtual global::System.DateTimeOffset Timestamp
		{
			get
			{
				return this.m_TimeStamp;
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0003E1D4 File Offset: 0x0003C3D4
		public global::System.DateTime LocalTimestamp
		{
			get
			{
				return this.Timestamp.DateTime;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0003E1F4 File Offset: 0x0003C3F4
		public double Value
		{
			get
			{
				return this.m_Value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0003E1FC File Offset: 0x0003C3FC
		public double PercentageValue
		{
			get
			{
				return this.m_Value * 100.0;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0003E210 File Offset: 0x0003C410
		public long Sequence
		{
			get
			{
				return this.m_Sequence;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0003E218 File Offset: 0x0003C418
		public int CompareTo(global::Loupe.Extensibility.Data.IMetricValue other)
		{
			return this.m_Sequence.CompareTo(other.Sequence);
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0003E240 File Offset: 0x0003C440
		public bool Equals(global::Loupe.Extensibility.Data.IMetricValue other)
		{
			return other != null && this.Value == other.Value && this.Sequence == other.Sequence;
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0003E26C File Offset: 0x0003C46C
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.MetricValue other = obj as global::Gibraltar.Monitor.MetricValue;
			return this.Equals(other);
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0003E28C File Offset: 0x0003C48C
		public override int GetHashCode()
		{
			return (int)(this.m_Sequence >> 32) ^ (int)this.m_Sequence ^ this.m_Value.GetHashCode();
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0003E2C0 File Offset: 0x0003C4C0
		public static bool operator ==(global::Gibraltar.Monitor.MetricValue left, global::Gibraltar.Monitor.MetricValue right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0003E2D4 File Offset: 0x0003C4D4
		public static bool operator !=(global::Gibraltar.Monitor.MetricValue left, global::Gibraltar.Monitor.MetricValue right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0003E2EC File Offset: 0x0003C4EC
		public static bool operator <(global::Gibraltar.Monitor.MetricValue left, global::Gibraltar.Monitor.MetricValue right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0003E2F8 File Offset: 0x0003C4F8
		public static bool operator >(global::Gibraltar.Monitor.MetricValue left, global::Gibraltar.Monitor.MetricValue right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x040006C7 RID: 1735
		private readonly long m_Sequence;

		// Token: 0x040006C8 RID: 1736
		private readonly global::Gibraltar.Monitor.MetricValueCollection m_MetricValueCollection;

		// Token: 0x040006C9 RID: 1737
		private readonly double m_Value;

		// Token: 0x040006CA RID: 1738
		private readonly global::System.DateTimeOffset m_TimeStamp;
	}
}
