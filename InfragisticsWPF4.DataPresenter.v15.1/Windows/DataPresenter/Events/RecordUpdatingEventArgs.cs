using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E7 RID: 743
	public class RecordUpdatingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022CA RID: 8906 RVA: 0x0009802D File Offset: 0x0009622D
		internal RecordUpdatingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x060022CB RID: 8907 RVA: 0x0009803C File Offset: 0x0009623C
		// (set) Token: 0x060022CC RID: 8908 RVA: 0x00098044 File Offset: 0x00096244
		public global::Infragistics.Windows.DataPresenter.RecordUpdatingAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x060022CD RID: 8909 RVA: 0x0009804D File Offset: 0x0009624D
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001155 RID: 4437
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04001156 RID: 4438
		private global::Infragistics.Windows.DataPresenter.RecordUpdatingAction _action;
	}
}
