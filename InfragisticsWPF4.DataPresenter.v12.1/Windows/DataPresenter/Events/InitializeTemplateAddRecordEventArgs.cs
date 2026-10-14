using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200028C RID: 652
	public class InitializeTemplateAddRecordEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DF5 RID: 7669 RVA: 0x000814D0 File Offset: 0x0007F6D0
		public InitializeTemplateAddRecordEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x000814DF File Offset: 0x0007F6DF
		public global::Infragistics.Windows.DataPresenter.DataRecord TemplateAddRecord
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EBD RID: 3773
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
