using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002EE RID: 750
	public class SummarySelectionControlOpeningEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x060022E4 RID: 8932 RVA: 0x0009818E File Offset: 0x0009638E
		internal SummarySelectionControlOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl control)
		{
			this._field = field;
			this._control = control;
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x000981A4 File Offset: 0x000963A4
		public global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl Control
		{
			get
			{
				return this._control;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060022E6 RID: 8934 RVA: 0x000981AC File Offset: 0x000963AC
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x04001164 RID: 4452
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001165 RID: 4453
		private global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl _control;
	}
}
