using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200027C RID: 636
	public class DataValueChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DBC RID: 7612 RVA: 0x000811B5 File Offset: 0x0007F3B5
		internal DataValueChangedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> valueHistory)
		{
			this._record = record;
			this._field = field;
			this._cellValuePresenter = cellValuePresenter;
			this._valueHistory = valueHistory;
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x000811DA File Offset: 0x0007F3DA
		public global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return this._cellValuePresenter;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001DBE RID: 7614 RVA: 0x000811E2 File Offset: 0x0007F3E2
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x000811EA File Offset: 0x0007F3EA
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x000811F2 File Offset: 0x0007F3F2
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> ValueHistory
		{
			get
			{
				return this._valueHistory;
			}
		}

		// Token: 0x04000E9D RID: 3741
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000E9E RID: 3742
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000E9F RID: 3743
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter _cellValuePresenter;

		// Token: 0x04000EA0 RID: 3744
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> _valueHistory;
	}
}
