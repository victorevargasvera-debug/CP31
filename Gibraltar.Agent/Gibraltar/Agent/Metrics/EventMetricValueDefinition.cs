using System;
using System.Reflection;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Agent.Metrics
{
	// Token: 0x02000023 RID: 35
	public sealed class EventMetricValueDefinition : global::System.IEquatable<global::Gibraltar.Agent.Metrics.EventMetricValueDefinition>
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00007854 File Offset: 0x00005A54
		internal EventMetricValueDefinition(global::Gibraltar.Agent.Metrics.EventMetricDefinition definition, global::Gibraltar.Monitor.EventMetricValueDefinition valueDefinition)
		{
			this.m_Definition = definition;
			this.m_WrappedValueDefinition = valueDefinition;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600020F RID: 527 RVA: 0x0000786C File Offset: 0x00005A6C
		// (set) Token: 0x06000210 RID: 528 RVA: 0x0000787C File Offset: 0x00005A7C
		public global::Gibraltar.Agent.Metrics.SummaryFunction SummaryFunction
		{
			get
			{
				return (global::Gibraltar.Agent.Metrics.SummaryFunction)this.m_WrappedValueDefinition.DefaultTrend;
			}
			internal set
			{
				this.m_WrappedValueDefinition.DefaultTrend = (global::Loupe.Extensibility.Data.EventMetricValueTrend)value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000211 RID: 529 RVA: 0x0000788C File Offset: 0x00005A8C
		public global::Gibraltar.Agent.Metrics.EventMetricDefinition Definition
		{
			get
			{
				return this.m_Definition;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00007894 File Offset: 0x00005A94
		public string Name
		{
			get
			{
				return this.m_WrappedValueDefinition.Name;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000213 RID: 531 RVA: 0x000078A4 File Offset: 0x00005AA4
		// (set) Token: 0x06000214 RID: 532 RVA: 0x000078B4 File Offset: 0x00005AB4
		public string Caption
		{
			get
			{
				return this.m_WrappedValueDefinition.Caption;
			}
			internal set
			{
				this.m_WrappedValueDefinition.Caption = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000215 RID: 533 RVA: 0x000078C4 File Offset: 0x00005AC4
		// (set) Token: 0x06000216 RID: 534 RVA: 0x000078D4 File Offset: 0x00005AD4
		public string Description
		{
			get
			{
				return this.m_WrappedValueDefinition.Description;
			}
			internal set
			{
				this.m_WrappedValueDefinition.Description = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000217 RID: 535 RVA: 0x000078E4 File Offset: 0x00005AE4
		public global::System.Type Type
		{
			get
			{
				return this.m_WrappedValueDefinition.Type;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000078F4 File Offset: 0x00005AF4
		public global::System.Type SerializedType
		{
			get
			{
				return this.m_WrappedValueDefinition.SerializedType;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00007904 File Offset: 0x00005B04
		public bool IsNumeric
		{
			get
			{
				return this.m_WrappedValueDefinition.IsTrendable;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00007914 File Offset: 0x00005B14
		// (set) Token: 0x0600021B RID: 539 RVA: 0x00007924 File Offset: 0x00005B24
		public string UnitCaption
		{
			get
			{
				return this.m_WrappedValueDefinition.UnitCaption;
			}
			internal set
			{
				this.m_WrappedValueDefinition.UnitCaption = value;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00007934 File Offset: 0x00005B34
		public bool Equals(global::Gibraltar.Agent.Metrics.EventMetricValueDefinition other)
		{
			return other != null && this.WrappedValueDefinition.Equals(other.WrappedValueDefinition);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00007950 File Offset: 0x00005B50
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00007960 File Offset: 0x00005B60
		internal bool Bound
		{
			get
			{
				return this.m_WrappedValueDefinition.Bound;
			}
			set
			{
				this.m_WrappedValueDefinition.Bound = value;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00007970 File Offset: 0x00005B70
		// (set) Token: 0x06000220 RID: 544 RVA: 0x00007980 File Offset: 0x00005B80
		internal global::System.Reflection.MemberTypes MemberType
		{
			get
			{
				return this.m_WrappedValueDefinition.MemberType;
			}
			set
			{
				this.m_WrappedValueDefinition.MemberType = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00007990 File Offset: 0x00005B90
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000079A0 File Offset: 0x00005BA0
		internal string MemberName
		{
			get
			{
				return this.m_WrappedValueDefinition.MemberName;
			}
			set
			{
				this.m_WrappedValueDefinition.MemberName = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000079B0 File Offset: 0x00005BB0
		internal global::Gibraltar.Monitor.EventMetricValueDefinition WrappedValueDefinition
		{
			get
			{
				return this.m_WrappedValueDefinition;
			}
		}

		// Token: 0x04000077 RID: 119
		private readonly global::Gibraltar.Agent.Metrics.EventMetricDefinition m_Definition;

		// Token: 0x04000078 RID: 120
		private readonly global::Gibraltar.Monitor.EventMetricValueDefinition m_WrappedValueDefinition;
	}
}
