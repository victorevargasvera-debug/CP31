using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002CE RID: 718
	public class InitializeRecordEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002277 RID: 8823 RVA: 0x00097BD5 File Offset: 0x00095DD5
		public InitializeRecordEventArgs(global::Infragistics.Windows.DataPresenter.Record record, bool reInitialize) : this(record, reInitialize, false)
		{
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00097BE0 File Offset: 0x00095DE0
		internal InitializeRecordEventArgs(global::Infragistics.Windows.DataPresenter.Record record, bool reInitialize, bool sortValueChanged)
		{
			this._record = record;
			this._reInitialize = reInitialize;
			this._sortValueChanged = sortValueChanged;
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x00097BFD File Offset: 0x00095DFD
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x00097C08 File Offset: 0x00095E08
		public bool IsPreparingForSort
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._record.FieldLayout;
				if (fieldLayout == null || !fieldLayout.HasSortedFields)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = this._record.ParentCollection.ParentRecordManager;
				return parentRecordManager != null && (parentRecordManager.IsInReset || parentRecordManager.IsInVerifySort);
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x00097C54 File Offset: 0x00095E54
		public bool ReInitialize
		{
			get
			{
				return this._reInitialize;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x00097C5C File Offset: 0x00095E5C
		public bool SortValueChanged
		{
			get
			{
				return this._sortValueChanged;
			}
		}

		// Token: 0x04001124 RID: 4388
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04001125 RID: 4389
		private bool _reInitialize;

		// Token: 0x04001126 RID: 4390
		private bool _sortValueChanged;
	}
}
