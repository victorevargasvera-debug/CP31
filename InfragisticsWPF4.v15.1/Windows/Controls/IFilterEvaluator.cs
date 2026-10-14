using System;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000120 RID: 288
	public interface IFilterEvaluator
	{
		// Token: 0x06000AAB RID: 2731
		bool? Evaluate(global::Infragistics.Windows.Controls.ComparisonOperator comparisonOperator, ref object lhs, ref object rhs, global::Infragistics.Windows.Controls.ConditionEvaluationContext context);
	}
}
