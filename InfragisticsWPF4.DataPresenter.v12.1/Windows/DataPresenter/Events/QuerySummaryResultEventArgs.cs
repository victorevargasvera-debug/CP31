using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200028D RID: 653
	public class QuerySummaryResultEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DF7 RID: 7671 RVA: 0x000814E7 File Offset: 0x0007F6E7
		public QuerySummaryResultEventArgs(global::Infragistics.Windows.DataPresenter.SummaryResult summary)
		{
			this._summary = summary;
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x000814F6 File Offset: 0x0007F6F6
		public global::Infragistics.Windows.DataPresenter.SummaryResult Summary
		{
			get
			{
				return this._summary;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x000814FE File Offset: 0x0007F6FE
		internal object ProvidedValue
		{
			get
			{
				return this._providedValue;
			}
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x00081506 File Offset: 0x0007F706
		public void SetSummaryValue(object value)
		{
			this._providedValue = value;
		}

		// Token: 0x04000EBE RID: 3774
		private global::Infragistics.Windows.DataPresenter.SummaryResult _summary;

		// Token: 0x04000EBF RID: 3775
		private object _providedValue;
	}
}
