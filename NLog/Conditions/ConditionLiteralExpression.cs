using System;
using System.Globalization;

namespace NLog.Conditions
{
	// Token: 0x0200017A RID: 378
	internal sealed class ConditionLiteralExpression : global::NLog.Conditions.ConditionExpression
	{
		// Token: 0x0600105C RID: 4188 RVA: 0x0002B37E File Offset: 0x0002957E
		public ConditionLiteralExpression(object literalValue)
		{
			this.LiteralValue = literalValue;
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x0600105D RID: 4189 RVA: 0x0002B38D File Offset: 0x0002958D
		// (set) Token: 0x0600105E RID: 4190 RVA: 0x0002B395 File Offset: 0x00029595
		public object LiteralValue { get; private set; }

		// Token: 0x0600105F RID: 4191 RVA: 0x0002B39E File Offset: 0x0002959E
		public override string ToString()
		{
			if (this.LiteralValue == null)
			{
				return "null";
			}
			return global::System.Convert.ToString(this.LiteralValue, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x0002B3BE File Offset: 0x000295BE
		protected override object EvaluateNode(global::NLog.LogEventInfo context)
		{
			return this.LiteralValue;
		}
	}
}
