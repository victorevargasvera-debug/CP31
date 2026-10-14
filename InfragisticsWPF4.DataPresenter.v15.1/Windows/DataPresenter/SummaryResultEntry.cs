using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D5 RID: 469
	public class SummaryResultEntry : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0007E8F4 File Offset: 0x0007CAF4
		// (set) Token: 0x06001C03 RID: 7171 RVA: 0x0007E8FC File Offset: 0x0007CAFC
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

		// Token: 0x04000B85 RID: 2949
		private global::Infragistics.Windows.DataPresenter.SummaryResult _summaryResult;
	}
}
