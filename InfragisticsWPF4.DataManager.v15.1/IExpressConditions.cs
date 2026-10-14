using System;
using System.Linq.Expressions;

namespace Infragistics
{
	// Token: 0x0200002E RID: 46
	public interface IExpressConditions
	{
		// Token: 0x06000234 RID: 564
		global::System.Linq.Expressions.Expression GetCurrentExpression(global::Infragistics.FilterContext context);

		// Token: 0x06000235 RID: 565
		global::System.Linq.Expressions.Expression GetCurrentExpression();
	}
}
