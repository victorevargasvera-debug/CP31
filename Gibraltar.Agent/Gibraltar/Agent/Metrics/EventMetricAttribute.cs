using System;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x0200001A RID: 26
	[global::System.AttributeUsage(global::System.AttributeTargets.Class | global::System.AttributeTargets.Struct | global::System.AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	[global::System.Serializable]
	public sealed class EventMetricAttribute : global::System.Attribute
	{
		// Token: 0x0600019C RID: 412 RVA: 0x00005C00 File Offset: 0x00003E00
		public EventMetricAttribute(string metricsSystem, string metricCategoryName, string counterName)
		{
			this.m_Namespace = (string.IsNullOrEmpty(metricsSystem) ? metricsSystem : metricsSystem.Trim());
			this.m_CategoryName = (string.IsNullOrEmpty(metricCategoryName) ? metricCategoryName : metricCategoryName.Trim());
			this.m_CounterName = (string.IsNullOrEmpty(counterName) ? counterName : counterName.Trim());
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00005C70 File Offset: 0x00003E70
		public string MetricsSystem
		{
			get
			{
				return this.m_Namespace;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00005C78 File Offset: 0x00003E78
		public string MetricCategoryName
		{
			get
			{
				return this.m_CategoryName;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00005C80 File Offset: 0x00003E80
		public string CounterName
		{
			get
			{
				return this.m_CounterName;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00005C88 File Offset: 0x00003E88
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00005C90 File Offset: 0x00003E90
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = (string.IsNullOrEmpty(value) ? value : value.Trim());
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00005CB0 File Offset: 0x00003EB0
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = (string.IsNullOrEmpty(value) ? value : value.Trim());
			}
		}

		// Token: 0x0400005E RID: 94
		private readonly string m_Namespace;

		// Token: 0x0400005F RID: 95
		private readonly string m_CategoryName;

		// Token: 0x04000060 RID: 96
		private readonly string m_CounterName;

		// Token: 0x04000061 RID: 97
		private string m_Caption;

		// Token: 0x04000062 RID: 98
		private string m_Description;
	}
}
