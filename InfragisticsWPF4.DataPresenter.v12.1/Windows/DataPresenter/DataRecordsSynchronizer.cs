using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001EE RID: 494
	internal class DataRecordsSynchronizer : global::Infragistics.Windows.DataPresenter.ListSynchronizer<object, global::Infragistics.Windows.DataPresenter.DataRecord>
	{
		// Token: 0x06001BE6 RID: 7142 RVA: 0x00076EA8 File Offset: 0x000750A8
		internal DataRecordsSynchronizer(global::Infragistics.Windows.DataPresenter.RecordCollectionBase dataRecordsColl, global::System.Collections.Generic.IList<object> dataItems) : base(dataItems, new global::Infragistics.CoreUtilities.TypedList<global::Infragistics.Windows.DataPresenter.DataRecord>(dataRecordsColl.SparseArray))
		{
			this._dataRecordsColl = dataRecordsColl;
			base.Initialize(new global::System.Func<object, global::Infragistics.Windows.DataPresenter.DataRecord>(this.CreateDataRecordCallback), new global::System.Action<global::Infragistics.Windows.DataPresenter.DataRecord>(this.InitDataRecordCallback), new global::System.Func<global::Infragistics.Windows.DataPresenter.DataRecord, object>(this.GetDataObjectFromDataRecord));
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00076EF8 File Offset: 0x000750F8
		private global::Infragistics.Windows.DataPresenter.DataRecord CreateDataRecordCallback(object dataItem)
		{
			return global::Infragistics.Windows.DataPresenter.DataRecord.Create(this._dataRecordsColl, dataItem, false, -1);
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00076F08 File Offset: 0x00075108
		private object GetDataObjectFromDataRecord(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			return dataRecord.DataItem;
		}

		// Token: 0x06001BE9 RID: 7145 RVA: 0x00076F10 File Offset: 0x00075110
		private void InitDataRecordCallback(global::Infragistics.Windows.DataPresenter.DataRecord dataRecord)
		{
			dataRecord.FireInitializeRecord();
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x00076F18 File Offset: 0x00075118
		protected override void RaiseDestCollectionEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			this._dataRecordsColl.RaiseChangeEvents(true);
		}

		// Token: 0x04000B96 RID: 2966
		internal readonly global::Infragistics.Windows.DataPresenter.RecordCollectionBase _dataRecordsColl;
	}
}
