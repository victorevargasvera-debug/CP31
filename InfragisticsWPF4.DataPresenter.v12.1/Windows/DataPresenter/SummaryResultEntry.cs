using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001B2 RID: 434
	public class SummaryResultEntry : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x0006BB2C File Offset: 0x00069D2C
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x0006BB34 File Offset: 0x00069D34
		public global::Infragistics.Windows.DataPresenter.SummaryResult SummaryResult
		{
			get
			{
				return this._summaryResult;
			}
			set
			{
				if (this._summaryResult != value)
				{
					this._summaryResult = value;
					base.RaisePropertyChangedEvent("SummaryResult");
				}
			}
		}

		// Token: 0x040009B7 RID: 2487
		private global::Infragistics.Windows.DataPresenter.SummaryResult _summaryResult;
	}
}
