using System;
using NLog.Conditions;
using NLog.Config;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000064 RID: 100
	[global::NLog.Config.NLogConfigurationItem]
	public class FilteringRule
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x000147D5 File Offset: 0x000129D5
		public FilteringRule() : this(null, null)
		{
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000147DF File Offset: 0x000129DF
		public FilteringRule(global::NLog.Conditions.ConditionExpression whenExistsExpression, global::NLog.Conditions.ConditionExpression filterToApply)
		{
			this.Exists = whenExistsExpression;
			this.Filter = filterToApply;
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x000147F5 File Offset: 0x000129F5
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x000147FD File Offset: 0x000129FD
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Conditions.ConditionExpression Exists { get; set; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00014806 File Offset: 0x00012A06
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x0001480E File Offset: 0x00012A0E
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Conditions.ConditionExpression Filter { get; set; }
	}
}
