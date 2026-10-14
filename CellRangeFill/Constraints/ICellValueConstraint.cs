using System;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill.Constraints
{
	// Token: 0x0200002D RID: 45
	public interface ICellValueConstraint
	{
		// Token: 0x06000108 RID: 264
		bool IsValid(global::Infragistics.Windows.DataPresenter.Cell cell, out string message);

		// Token: 0x06000109 RID: 265
		bool IsValid(object value, out string message);
	}
}
