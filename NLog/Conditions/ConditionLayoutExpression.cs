using System;
using NLog.Layouts;

namespace NLog.Conditions
{
	// Token: 0x02000178 RID: 376
	internal sealed class ConditionLayoutExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x06001054 RID: 4180 RVA: 0x0002B32C File Offset: 0x0002952C
		public ConditionLayoutExpression(global::NLog.Layouts.Layout layout)
		{
			this.Layout = layout;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x0002B33B File Offset: 0x0002953B
		// (set) Token: 0x06001056 RID: 4182 RVA: 0x0002B343 File Offset: 0x00029543
		public global::NLog.Layouts.Layout Layout { get; private set; }

		// Token: 0x06001057 RID: 4183 RVA: 0x0002B34C File Offset: 0x0002954C
		public override string ToString()
		{
			return this.Layout.ToString();
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x0002B359 File Offset: 0x00029559
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			return this.Layout.Render(context);
		}
	}
}
