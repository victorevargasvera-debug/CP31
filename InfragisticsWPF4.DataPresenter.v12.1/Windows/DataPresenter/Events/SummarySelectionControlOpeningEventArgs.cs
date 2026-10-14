using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002AB RID: 683
	public class SummarySelectionControlOpeningEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E5C RID: 7772 RVA: 0x000819FA File Offset: 0x0007FBFA
		internal SummarySelectionControlOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl control)
		{
			this._field = field;
			this._control = control;
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06001E5D RID: 7773 RVA: 0x00081A10 File Offset: 0x0007FC10
		public global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl Control
		{
			get
			{
				return this._control;
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x00081A18 File Offset: 0x0007FC18
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x04000EFA RID: 3834
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000EFB RID: 3835
		private global::Infragistics.Windows.DataPresenter.SummaryCalculatorSelectionControl _control;
	}
}
