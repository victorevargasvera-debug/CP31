using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000221 RID: 545
	internal class DataRecordsSynchronizer : global::Infragistics.Windows.DataPresenter.ListSynchronizer<object, global::Infragistics.Windows.DataPresenter.DataRecord>
	{
		// Token: 0x06002060 RID: 8288 RVA: 0x0008D1F4 File Offset: 0x0008B3F4
		internal DataRecordsSynchronizer(global::Infragistics.Windows.DataPresenter.RecordCollectionBase dataRecordsColl, global::System.Collections.Generic.IList<object> dataItems, global::Infragistics.Windows.DataPresenter.Disposable disposable) : base(dataItems, new global::Infragistics.CoreUtilities.TypedList<global::Infragistics.Windows.DataPresenter.DataRecord>(dataRecordsColl.SparseArray), disposable)
		{
			this._dataRecordsColl = dataRecordsColl;
			base.Initialize(new global::System.Func<object, global::Infragistics.Windows.DataPresenter.DataRecord>(this.CreateDataRecordCallback), new global::System.Action<global::Infragistics.Windows.DataPresenter.DataRecord>(this.InitDataRecordCallback), null, new global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord, object>(this.GetDataObjectFromDataRecord));
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0008D246 File Offset: 0x0008B446
		private global::Infragistics.Windows.DataPresenter.DataRecord CreateDataRecordCallback(object dataItem)
		{
			return global::Infragistics.Windows.DataPresenter.DataRecord.Create(this._dataRecordsColl, dataItem, false, -1);
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0008D256 File Offset: 0x0008B456
		private object GetDataObjectFromDataRecord(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			return dataRecord.DataItem;
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0008D25E File Offset: 0x0008B45E
		private void InitDataRecordCallback(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			dataRecord.FireInitializeRecord();
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0008D266 File Offset: 0x0008B466
		protected override void RaiseDestCollectionEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			this._dataRecordsColl.RaiseChangeEvents(true);
		}

		// Token: 0x04000DB1 RID: 3505
		internal readonly global::Infragistics.Windows.DataPresenter.RecordCollectionBase _dataRecordsColl;
	}
}
