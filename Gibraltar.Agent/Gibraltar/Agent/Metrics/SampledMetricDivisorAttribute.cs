using System;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x0200002C RID: 44
	[global::System.AttributeUsage(global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	[global::System.Serializable]
	public sealed class SampledMetricDivisorAttribute : global::System.Attribute
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x00009DE0 File Offset: 0x00007FE0
		public SampledMetricDivisorAttribute(string counterName)
		{
			this.m_CounterName = (string.IsNullOrEmpty(counterName) ? counterName : counterName.Trim());
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00009E08 File Offset: 0x00008008
		public string CounterName
		{
			get
			{
				return this.m_CounterName;
			}
		}

		// Token: 0x0400009A RID: 154
		private readonly string m_CounterName;
	}
}
