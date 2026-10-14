using System;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200001E RID: 30
	public interface ICellValueSetter<TValue> : global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter
	{
		// Token: 0x060000A3 RID: 163
		bool CanSetValue(global::Infragistics.Windows.DataPresenter.Cell cell, TValue value);

		// Token: 0x060000A4 RID: 164
		void SetValue(global::Infragistics.Windows.DataPresenter.Cell cell, TValue value);

		// Token: 0x060000A5 RID: 165
		bool TrySetValue(global::Infragistics.Windows.DataPresenter.Cell cell, TValue value, out global::System.Exception ex);

		// Token: 0x060000A6 RID: 166
		bool AreValuesEqual(global::Infragistics.Windows.DataPresenter.Cell cell, TValue value);
	}
}
