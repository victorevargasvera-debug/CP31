using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002EC RID: 748
	public class SummaryResultChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022DF RID: 8927 RVA: 0x00098151 File Offset: 0x00096351
		public SummaryResultChangedEventArgs(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._summaryResult = summaryResult;
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x00098160 File Offset: 0x00096360
		public global::Infragistics.Windows.DataPresenter.SummaryResult SummaryResult
		{
			get
			{
				return this._summaryResult;
			}
		}

		// Token: 0x04001161 RID: 4449
		private global::Infragistics.Windows.DataPresenter.SummaryResult _summaryResult;
	}
}
