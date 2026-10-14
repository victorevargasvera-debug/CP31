using System;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000022 RID: 34
	[global::System.AttributeUsage(global::System.AttributeTargets.Method | global::System.AttributeTargets.Property | global::System.AttributeTargets.Field, AllowMultiple = true, Inherited = false)]
	[global::System.Serializable]
	public sealed class EventMetricValueAttribute : global::System.Attribute
	{
		// Token: 0x06000202 RID: 514 RVA: 0x00007754 File Offset: 0x00005954
		public EventMetricValueAttribute(string name, global::Gibraltar.Agent.Metrics.SummaryFunction summaryFunction, string unitCaption)
		{
			this.m_Name = (string.IsNullOrEmpty(name) ? name : name.Trim());
			this.m_UnitCaption = (string.IsNullOrEmpty(unitCaption) ? unitCaption : unitCaption.Trim());
			this.m_SummaryFunction = summaryFunction;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000203 RID: 515 RVA: 0x000077AC File Offset: 0x000059AC
		public string Name
		{
			get
			{
				return this.m_Name;
			}
		}

		// Token: 0x06000204 RID: 516 RVA: 0x000077B4 File Offset: 0x000059B4
		internal void SetName(string name)
		{
			this.m_Name = (string.IsNullOrEmpty(name) ? name : name.Trim());
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000205 RID: 517 RVA: 0x000077D4 File Offset: 0x000059D4
		public string UnitCaption
		{
			get
			{
				return this.m_UnitCaption;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000077DC File Offset: 0x000059DC
		public global::Gibraltar.Agent.Metrics.SummaryFunction SummaryFunction
		{
			get
			{
				return this.m_SummaryFunction;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000077E4 File Offset: 0x000059E4
		internal void SetSummaryFunction(global::Gibraltar.Agent.Metrics.SummaryFunction summaryFunction)
		{
			this.m_SummaryFunction = summaryFunction;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000077F0 File Offset: 0x000059F0
		// (set) Token: 0x06000209 RID: 521 RVA: 0x000077F8 File Offset: 0x000059F8
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

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00007818 File Offset: 0x00005A18
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00007820 File Offset: 0x00005A20
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

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00007840 File Offset: 0x00005A40
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00007848 File Offset: 0x00005A48
		public bool IsDefaultValue
		{
			get
			{
				return this.m_DefaultValue;
			}
			set
			{
				this.m_DefaultValue = value;
			}
		}

		// Token: 0x04000071 RID: 113
		private string m_Name;

		// Token: 0x04000072 RID: 114
		private readonly string m_UnitCaption;

		// Token: 0x04000073 RID: 115
		private global::Gibraltar.Agent.Metrics.SummaryFunction m_SummaryFunction;

		// Token: 0x04000074 RID: 116
		private string m_Caption;

		// Token: 0x04000075 RID: 117
		private string m_Description;

		// Token: 0x04000076 RID: 118
		private bool m_DefaultValue;
	}
}
