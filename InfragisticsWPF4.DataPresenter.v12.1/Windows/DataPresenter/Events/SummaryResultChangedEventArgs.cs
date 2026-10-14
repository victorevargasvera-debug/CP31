using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A9 RID: 681
	public class SummaryResultChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E57 RID: 7767 RVA: 0x000819BD File Offset: 0x0007FBBD
		public SummaryResultChangedEventArgs(global::Infragistics.Windows.DataPresenter.SummaryResult summaryResult)
		{
			this._summaryResult = summaryResult;
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x000819CC File Offset: 0x0007FBCC
		public global::Infragistics.Windows.DataPresenter.SummaryResult SummaryResult
		{
			get
			{
				return this._summaryResult;
			}
		}

		// Token: 0x04000EF7 RID: 3831
		private global::Infragistics.Windows.DataPresenter.SummaryResult _summaryResult;
	}
}
