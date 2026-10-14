using System;
using System.Diagnostics;
using Gibraltar.Monitor.Internal;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001C0 RID: 448
	[global::System.Diagnostics.DebuggerDisplay("{Sequence}: {Timestamp} Value={Value}")]
	internal abstract class MetricSample : global::Loupe.Extensibility.Data.IMetricSample, global::System.IComparable<global::Loupe.Extensibility.Data.IMetricSample>, global::System.IEquatable<global::Loupe.Extensibility.Data.IMetricSample>
	{
		// Token: 0x060014DA RID: 5338 RVA: 0x0003DA78 File Offset: 0x0003BC78
		internal MetricSample(global::Gibraltar.Monitor.Metric metric, global::Gibraltar.Monitor.Internal.MetricSamplePacket samplePacket)
		{
			if (metric == null)
			{
				throw new global::System.ArgumentNullException("metric");
			}
			if (samplePacket == null)
			{
				throw new global::System.ArgumentNullException("samplePacket");
			}
			this.m_Metric = metric;
			this.m_MetricSamplePacket = samplePacket;
			if (this.m_MetricSamplePacket.MetricPacket == null)
			{
				this.m_MetricSamplePacket.MetricPacket = this.m_Metric.Packet;
			}
			if (!((global::Gibraltar.Monitor.MetricDefinition)metric.Definition).IsLive)
			{
				metric.Samples.Add(this);
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x060014DB RID: 5339 RVA: 0x0003DB0C File Offset: 0x0003BD0C
		public virtual global::System.Guid Id
		{
			get
			{
				return this.m_MetricSamplePacket.ID;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060014DC RID: 5340 RVA: 0x0003DB1C File Offset: 0x0003BD1C
		public virtual global::Loupe.Extensibility.Data.IMetric Metric
		{
			get
			{
				return this.m_Metric;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060014DD RID: 5341 RVA: 0x0003DB24 File Offset: 0x0003BD24
		public virtual long Sequence
		{
			get
			{
				return this.m_MetricSamplePacket.Sequence;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060014DE RID: 5342 RVA: 0x0003DB34 File Offset: 0x0003BD34
		public virtual global::System.DateTimeOffset Timestamp
		{
			get
			{
				return this.m_MetricSamplePacket.Timestamp;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060014DF RID: 5343
		public abstract double Value { get; }

		// Token: 0x060014E0 RID: 5344 RVA: 0x0003DB44 File Offset: 0x0003BD44
		public void Write()
		{
			if (!this.m_MetricSamplePacket.Persisted)
			{
				global::Gibraltar.Monitor.Log.Write(this);
			}
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x0003DB5C File Offset: 0x0003BD5C
		public int CompareTo(global::Loupe.Extensibility.Data.IMetricSample other)
		{
			return this.m_MetricSamplePacket.Sequence.CompareTo(other.Sequence);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x0003DB88 File Offset: 0x0003BD88
		public bool Equals(global::Loupe.Extensibility.Data.IMetricSample other)
		{
			return other != null && this.m_MetricSamplePacket.Equals(((global::Gibraltar.Monitor.MetricSample)other).Packet);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x0003DBA8 File Offset: 0x0003BDA8
		public override bool Equals(object obj)
		{
			global::Gibraltar.Monitor.MetricSample other = obj as global::Gibraltar.Monitor.MetricSample;
			return this.Equals(other);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x0003DBC8 File Offset: 0x0003BDC8
		public override int GetHashCode()
		{
			return this.m_MetricSamplePacket.GetHashCode();
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x0003DBD8 File Offset: 0x0003BDD8
		public static bool operator ==(global::Gibraltar.Monitor.MetricSample left, global::Gibraltar.Monitor.MetricSample right)
		{
			if (left == null)
			{
				return right == null;
			}
			return left.Equals(right);
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x0003DBEC File Offset: 0x0003BDEC
		public static bool operator !=(global::Gibraltar.Monitor.MetricSample left, global::Gibraltar.Monitor.MetricSample right)
		{
			if (left == null)
			{
				return right != null;
			}
			return !left.Equals(right);
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0003DC04 File Offset: 0x0003BE04
		public static bool operator <(global::Gibraltar.Monitor.MetricSample left, global::Gibraltar.Monitor.MetricSample right)
		{
			return left.CompareTo(right) < 0;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0003DC10 File Offset: 0x0003BE10
		public static bool operator >(global::Gibraltar.Monitor.MetricSample left, global::Gibraltar.Monitor.MetricSample right)
		{
			return left.CompareTo(right) > 0;
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060014E9 RID: 5353 RVA: 0x0003DC1C File Offset: 0x0003BE1C
		internal virtual global::Gibraltar.Monitor.Internal.MetricSamplePacket Packet
		{
			get
			{
				return this.m_MetricSamplePacket;
			}
		}

		// Token: 0x040006C1 RID: 1729
		private readonly global::Gibraltar.Monitor.Metric m_Metric;

		// Token: 0x040006C2 RID: 1730
		private readonly global::Gibraltar.Monitor.Internal.MetricSamplePacket m_MetricSamplePacket;
	}
}
