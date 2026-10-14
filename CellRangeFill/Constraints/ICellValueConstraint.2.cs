using System;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x02000030 RID: 48
	public interface ICellValueConstraint<TValue> : global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint
	{
		// Token: 0x06000112 RID: 274
		bool IsValid(TValue value, out string message);
	}
}
