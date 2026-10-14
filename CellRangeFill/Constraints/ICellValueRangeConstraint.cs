using System;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x0200002F RID: 47
	public interface ICellValueRangeConstraint<TValue> : global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint<TValue>, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000110 RID: 272
		TValue MinValue { get; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000111 RID: 273
		TValue MaxValue { get; }
	}
}
