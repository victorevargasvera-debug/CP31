using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002CF RID: 719
	public class InitializeTemplateAddRecordEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600227D RID: 8829 RVA: 0x00097C64 File Offset: 0x00095E64
		public InitializeTemplateAddRecordEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x00097C73 File Offset: 0x00095E73
		public global::Infragistics.Windows.DataPresenter.DataRecord TemplateAddRecord
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001127 RID: 4391
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
