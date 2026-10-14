using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000102 RID: 258
	public interface IFilterEvaluator
	{
		// Token: 0x060009AC RID: 2476
		bool? Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, ref object lhs, ref object rhs, global::Infragistics.Windows.Controls.ConditionEvaluationContext context);
	}
}
