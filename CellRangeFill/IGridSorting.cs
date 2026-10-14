using System;
using Infragistics.Windows.DataPresenter;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200001F RID: 31
	public interface IGridSorting
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A7 RID: 167
		global::Infragistics.Windows.DataPresenter.DataPresenterBase Grid { get; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A8 RID: 168
		bool IsEnabled { get; }

		// Token: 0x060000A9 RID: 169
		void Enable(bool refresh);

		// Token: 0x060000AA RID: 170
		void Disable();
	}
}
