using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000295 RID: 661
	public class RecordExpandedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E09 RID: 7689 RVA: 0x000815B0 File Offset: 0x0007F7B0
		internal RecordExpandedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x000815BF File Offset: 0x0007F7BF
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC7 RID: 3783
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
