using System;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x0200002B RID: 43
	[global::System.AttributeUsage(global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	[global::System.Serializable]
	public sealed class SampledMetricValueAttribute : global::System.Attribute
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x00009D00 File Offset: 0x00007F00
		public SampledMetricValueAttribute(string counterName, global::Gibraltar.Agent.Metrics.SamplingType samplingType, string unitCaption)
		{
			this.m_CounterName = (string.IsNullOrEmpty(counterName) ? counterName : counterName.Trim());
			this.m_SamplingType = samplingType;
			this.m_UnitCaption = (string.IsNullOrEmpty(unitCaption) ? unitCaption : unitCaption.Trim());
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002AA RID: 682 RVA: 0x00009D58 File Offset: 0x00007F58
		public string CounterName
		{
			get
			{
				return this.m_CounterName;
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00009D60 File Offset: 0x00007F60
		internal void SetCounterName(string counterName)
		{
			this.m_CounterName = (string.IsNullOrEmpty(counterName) ? counterName : counterName.Trim());
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002AC RID: 684 RVA: 0x00009D80 File Offset: 0x00007F80
		public global::Gibraltar.Agent.Metrics.SamplingType SamplingType
		{
			get
			{
				return this.m_SamplingType;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002AD RID: 685 RVA: 0x00009D88 File Offset: 0x00007F88
		public string UnitCaption
		{
			get
			{
				return this.m_UnitCaption;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00009D90 File Offset: 0x00007F90
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00009D98 File Offset: 0x00007F98
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

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00009DB8 File Offset: 0x00007FB8
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00009DC0 File Offset: 0x00007FC0
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

		// Token: 0x04000095 RID: 149
		private string m_CounterName;

		// Token: 0x04000096 RID: 150
		private readonly global::Gibraltar.Agent.Metrics.SamplingType m_SamplingType;

		// Token: 0x04000097 RID: 151
		private readonly string m_UnitCaption;

		// Token: 0x04000098 RID: 152
		private string m_Caption;

		// Token: 0x04000099 RID: 153
		private string m_Description;
	}
}
