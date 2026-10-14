using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D3 RID: 723
	public class RecordAddedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002287 RID: 8839 RVA: 0x00097CD1 File Offset: 0x00095ED1
		internal RecordAddedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06002288 RID: 8840 RVA: 0x00097CE0 File Offset: 0x00095EE0
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400112C RID: 4396
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
