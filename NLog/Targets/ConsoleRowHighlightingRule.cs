using System;
using System.ComponentModel;
using NLog.Conditions;
using NLog.Config;

namespace NLog.Targets
{
	// Token: 0x0200002B RID: 43
	[global::NLog.Config.NLogConfigurationItem]
	public class ConsoleRowHighlightingRule
	{
		// Token: 0x060004C1 RID: 1217 RVA: 0x00009E38 File Offset: 0x00008038
		public ConsoleRowHighlightingRule() : this(null, global::NLog.Targets.ConsoleOutputColor.NoChange, global::NLog.Targets.ConsoleOutputColor.NoChange)
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00009E45 File Offset: 0x00008045
		public ConsoleRowHighlightingRule(global::NLog.Conditions.ConditionExpression condition, global::NLog.Targets.ConsoleOutputColor foregroundColor, global::NLog.Targets.ConsoleOutputColor backgroundColor)
		{
			this.Condition = condition;
			this.ForegroundColor = foregroundColor;
			this.BackgroundColor = backgroundColor;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00009E62 File Offset: 0x00008062
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00009E69 File Offset: 0x00008069
		public static global::NLog.Targets.ConsoleRowHighlightingRule Default { get; private set; } = new global::NLog.Targets.ConsoleRowHighlightingRule(null, global::NLog.Targets.ConsoleOutputColor.NoChange, global::NLog.Targets.ConsoleOutputColor.NoChange);

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00009E71 File Offset: 0x00008071
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00009E79 File Offset: 0x00008079
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Conditions.ConditionExpression Condition { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00009E82 File Offset: 0x00008082
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00009E8A File Offset: 0x0000808A
		[global::System.ComponentModel.DefaultValue("NoChange")]
		public global::NLog.Targets.ConsoleOutputColor ForegroundColor { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00009E93 File Offset: 0x00008093
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00009E9B File Offset: 0x0000809B
		[global::System.ComponentModel.DefaultValue("NoChange")]
		public global::NLog.Targets.ConsoleOutputColor BackgroundColor { get; set; }

		// Token: 0x060004CB RID: 1227 RVA: 0x00009EA4 File Offset: 0x000080A4
		public bool CheckCondition(global::NLog.LogEventInfo logEvent)
		{
			return this.Condition == null || true.Equals(this.Condition.Evaluate(logEvent));
		}
	}
}
