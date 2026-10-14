using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000064 RID: 100
	internal abstract class DataRecordAction : global::Infragistics.Windows.DataPresenter.DataPresenterAction
	{
		// Token: 0x06000582 RID: 1410 RVA: 0x00014587 File Offset: 0x00012787
		internal DataRecordAction(global::Infragistics.Windows.DataPresenter.DataRecord record) : base(record.DataPresenter)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(record);
			this._record = record;
			this._recordDataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(record);
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000145AE File Offset: 0x000127AE
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x000145B6 File Offset: 0x000127B6
		protected object OriginalDataItem
		{
			get
			{
				return this._recordDataItem;
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x000145BE File Offset: 0x000127BE
		protected internal override void AddUndeleteDescendantInfo(global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
		{
			descendantInfo.AddRecord(this.Record);
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x000145CD File Offset: 0x000127CD
		protected internal override bool CanPerform(object context)
		{
			return !global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsDeleted(this._record) && (!global::Infragistics.Windows.UndoManager.IsUndoRedoContext(context) || global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(this._recordDataItem, global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._record)));
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x00014604 File Offset: 0x00012804
		protected internal override void OnRecordsUndeleted(global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.DataRecord> oldDataTimeToRecords)
		{
			global::Infragistics.Windows.DataPresenter.Record record = this._record;
			if (global::Infragistics.Windows.DataPresenter.DataPresenterAction.ProcessRecordUndeleted(oldDataTimeToRecords, ref this._recordDataItem, ref record))
			{
				this._record = (global::Infragistics.Windows.DataPresenter.DataRecord)record;
			}
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x00014634 File Offset: 0x00012834
		protected void InitializeOriginalDataItem()
		{
			this._recordDataItem = global::Infragistics.Windows.DataPresenter.DataPresenterAction.GetRecordDataItem(this._record);
		}

		// Token: 0x0400018E RID: 398
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x0400018F RID: 399
		private object _recordDataItem;
	}
}
