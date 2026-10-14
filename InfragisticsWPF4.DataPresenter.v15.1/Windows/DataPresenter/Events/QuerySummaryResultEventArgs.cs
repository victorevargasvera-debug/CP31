using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D0 RID: 720
	public class QuerySummaryResultEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600227F RID: 8831 RVA: 0x00097C7B File Offset: 0x00095E7B
		public QuerySummaryResultEventArgs(global::Infragistics.Windows.DataPresenter.SummaryResult summary)
		{
			this._summary = summary;
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06002280 RID: 8832 RVA: 0x00097C8A File Offset: 0x00095E8A
		public global::Infragistics.Windows.DataPresenter.SummaryResult Summary
		{
			get
			{
				return this._summary;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x00097C92 File Offset: 0x00095E92
		internal object ProvidedValue
		{
			get
			{
				return this._providedValue;
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00097C9A File Offset: 0x00095E9A
		public void SetSummaryValue(object value)
		{
			this._providedValue = value;
		}

		// Token: 0x04001128 RID: 4392
		private global::Infragistics.Windows.DataPresenter.SummaryResult _summary;

		// Token: 0x04001129 RID: 4393
		private object _providedValue;
	}
}
