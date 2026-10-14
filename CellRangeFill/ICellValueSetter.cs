using System;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000017 RID: 23
	public interface ICellValueSetter
	{
		// Token: 0x06000081 RID: 129
		bool IsEditable(global::Infragistics.Windows.DataPresenter.Cell cell);

		// Token: 0x06000082 RID: 130
		bool CanSetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value);

		// Token: 0x06000083 RID: 131
		void SetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool forceValidation);

		// Token: 0x06000084 RID: 132
		bool TrySetValue(global::Infragistics.Windows.DataPresenter.Cell cell, object value, bool supressNotification, bool commit, bool forceValidation, out global::System.Exception ex);

		// Token: 0x06000085 RID: 133
		bool AreValuesEqual(global::Infragistics.Windows.DataPresenter.Cell cell, object value);
	}
}
