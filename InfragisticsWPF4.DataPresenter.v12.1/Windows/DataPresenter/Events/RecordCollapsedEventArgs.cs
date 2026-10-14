using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000292 RID: 658
	public class RecordCollapsedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E03 RID: 7683 RVA: 0x0008156B File Offset: 0x0007F76B
		internal RecordCollapsedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x06001E04 RID: 7684 RVA: 0x0008157A File Offset: 0x0007F77A
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC4 RID: 3780
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
