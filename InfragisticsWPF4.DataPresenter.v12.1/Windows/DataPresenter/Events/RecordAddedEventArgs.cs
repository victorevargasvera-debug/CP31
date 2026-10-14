using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000290 RID: 656
	public class RecordAddedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DFF RID: 7679 RVA: 0x0008153D File Offset: 0x0007F73D
		internal RecordAddedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x0008154C File Offset: 0x0007F74C
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC2 RID: 3778
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
