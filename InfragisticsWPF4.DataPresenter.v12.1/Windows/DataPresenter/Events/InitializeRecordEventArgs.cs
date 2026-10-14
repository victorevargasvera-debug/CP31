using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200028B RID: 651
	public class InitializeRecordEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x00081444 File Offset: 0x0007F644
		public InitializeRecordEventArgs(global::Infragistics.Windows.DataPresenter.Record record, bool reInitialize) : this(record, reInitialize, false)
		{
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x0008144F File Offset: 0x0007F64F
		internal InitializeRecordEventArgs(global::Infragistics.Windows.DataPresenter.Record record, bool reInitialize, bool sortValueChanged)
		{
			this._record = record;
			this._reInitialize = reInitialize;
			this._sortValueChanged = sortValueChanged;
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0008146C File Offset: 0x0007F66C
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06001DF2 RID: 7666 RVA: 0x00081474 File Offset: 0x0007F674
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

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x000814C0 File Offset: 0x0007F6C0
		public bool ReInitialize
		{
			get
			{
				return this._reInitialize;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x000814C8 File Offset: 0x0007F6C8
		public bool SortValueChanged
		{
			get
			{
				return this._sortValueChanged;
			}
		}

		// Token: 0x04000EBA RID: 3770
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000EBB RID: 3771
		private bool _reInitialize;

		// Token: 0x04000EBC RID: 3772
		private bool _sortValueChanged;
	}
}
