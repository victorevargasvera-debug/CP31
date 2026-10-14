using System;

namespace Gibraltar.Monitor.Internal
{
	// Token: 0x02000220 RID: 544
	internal abstract class SampledMetricPacket : global::Gibraltar.Monitor.Internal.MetricPacket, global::System.IComparable<global::Gibraltar.Monitor.Internal.SampledMetricPacket>, global::System.IEquatable<global::Gibraltar.Monitor.Internal.SampledMetricPacket>
	{
		// Token: 0x06001B7F RID: 7039 RVA: 0x0005FBC0 File Offset: 0x0005DDC0
		protected SampledMetricPacket(global::Gibraltar.Monitor.Internal.SampledMetricDefinitionPacket metricDefinitionPacket, string instanceName) : base(metricDefinitionPacket, instanceName)
		{
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0005FBCC File Offset: 0x0005DDCC
		protected SampledMetricPacket(global::Gibraltar.Monitor.Session session) : base(session)
		{
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x0005FBD8 File Offset: 0x0005DDD8
		public int CompareTo(global::Gibraltar.Monitor.Internal.SampledMetricPacket other)
		{
			return base.CompareTo(other);
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0005FBE4 File Offset: 0x0005DDE4
		public override bool Equals(object other)
		{
			return this.Equals(other as global::Gibraltar.Monitor.Internal.SampledMetricPacket);
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0005FBF4 File Offset: 0x0005DDF4
		public bool Equals(global::Gibraltar.Monitor.Internal.SampledMetricPacket other)
		{
			return base.Equals(other);
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0005FC00 File Offset: 0x0005DE00
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}
