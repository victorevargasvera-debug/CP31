using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000069 RID: 105
	internal abstract class DataRecordAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x060005FD RID: 1533 RVA: 0x0001694F File Offset: 0x00014B4F
		internal DataRecordAction(global::Infragistics.Windows.DataPresenter.DataRecord record) : base(record.DataPresenter)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(record);
			this._record = record;
			this._recordDataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(record);
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005FE RID: 1534 RVA: 0x00016976 File Offset: 0x00014B76
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005FF RID: 1535 RVA: 0x0001697E File Offset: 0x00014B7E
		protected object OriginalDataItem
		{
			get
			{
				return this._recordDataItem;
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x00016986 File Offset: 0x00014B86
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			descendantInfo.AddRecord(this.Record);
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00016995 File Offset: 0x00014B95
		protected internal override bool CanPerform(object context)
		{
			return !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(this._record) && (!global::Infragistics.Windows.UndoManager.IsUndoRedoContext(context) || global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(this._recordDataItem, global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._record), base.DataPresenter.DataItemEqualityComparerResolved));
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x000169D4 File Offset: 0x00014BD4
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			global::Infragistics.Windows.DataPresenter.Record record = this._record;
			if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.ProcessRecordUndeleted(oldDataTimeToRecords, ref this._recordDataItem, ref record))
			{
				this._record = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00016A04 File Offset: 0x00014C04
		protected void InitializeOriginalDataItem()
		{
			this._recordDataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._record);
		}

		// Token: 0x040001C6 RID: 454
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040001C7 RID: 455
		private object _recordDataItem;
	}
}
