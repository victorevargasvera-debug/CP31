using System;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000027 RID: 39
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	[global::System.Serializable]
	public sealed class SampledMetricAttribute : global::System.Attribute
	{
		// Token: 0x06000259 RID: 601 RVA: 0x000084F0 File Offset: 0x000066F0
		public SampledMetricAttribute(string metricsSystem, string metricCategoryName)
		{
			this.m_Namespace = (string.IsNullOrEmpty(metricsSystem) ? metricsSystem : metricsSystem.Trim());
			this.m_CategoryName = (string.IsNullOrEmpty(metricCategoryName) ? metricCategoryName : metricCategoryName.Trim());
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00008544 File Offset: 0x00006744
		public string MetricsSystem
		{
			get
			{
				return this.m_Namespace;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000854C File Offset: 0x0000674C
		public string MetricCategoryName
		{
			get
			{
				return this.m_CategoryName;
			}
		}

		// Token: 0x04000089 RID: 137
		private readonly string m_Namespace;

		// Token: 0x0400008A RID: 138
		private readonly string m_CategoryName;
	}
}
