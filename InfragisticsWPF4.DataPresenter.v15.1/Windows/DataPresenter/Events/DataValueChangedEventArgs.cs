using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002BF RID: 703
	public class DataValueChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002240 RID: 8768 RVA: 0x00097915 File Offset: 0x00095B15
		internal DataValueChangedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> valueHistory)
		{
			this._record = record;
			this._field = field;
			this._cellValuePresenter = cellValuePresenter;
			this._valueHistory = valueHistory;
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06002241 RID: 8769 RVA: 0x0009793A File Offset: 0x00095B3A
		public global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return this._cellValuePresenter;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x00097942 File Offset: 0x00095B42
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06002243 RID: 8771 RVA: 0x0009794A File Offset: 0x00095B4A
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x00097952 File Offset: 0x00095B52
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> ValueHistory
		{
			get
			{
				return this._valueHistory;
			}
		}

		// Token: 0x04001104 RID: 4356
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04001105 RID: 4357
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001106 RID: 4358
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter _cellValuePresenter;

		// Token: 0x04001107 RID: 4359
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> _valueHistory;
	}
}
