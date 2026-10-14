using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E4 RID: 740
	public class RecordUpdateCanceledEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022C4 RID: 8900 RVA: 0x00097FE8 File Offset: 0x000961E8
		internal RecordUpdateCanceledEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00097FF7 File Offset: 0x000961F7
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001152 RID: 4434
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
