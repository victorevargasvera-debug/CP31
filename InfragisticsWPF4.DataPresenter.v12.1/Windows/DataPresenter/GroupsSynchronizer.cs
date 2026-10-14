using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Data;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001ED RID: 493
	internal class GroupsSynchronizer : global::Infragistics.Windows.DataPresenter.ListSynchronizer<object, global::Infragistics.Windows.DataPresenter.GroupByRecord>
	{
		// Token: 0x06001BE1 RID: 7137 RVA: 0x00076DA8 File Offset: 0x00074FA8
		internal GroupsSynchronizer(global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByRecordsColl, global::System.Collections.Generic.IList<object> groups) : base(groups, new global::Infragistics.CoreUtilities.TypedList<global::Infragistics.Windows.DataPresenter.GroupByRecord>(groupByRecordsColl.SparseArray))
		{
			this._groupByRecordsColl = groupByRecordsColl;
			this._groupByField = this._groupByRecordsColl.GroupByField;
			base.Initialize(new global::System.Func<object, global::Infragistics.Windows.DataPresenter.GroupByRecord>(this.CreateGroupByRecordCallback), new global::System.Action<global::Infragistics.Windows.DataPresenter.GroupByRecord>(this.InitGroupByRecordCallback), new global::System.Func<global::Infragistics.Windows.DataPresenter.GroupByRecord, object>(this.GetGroupObjectFromGroupByRecord));
		}

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00076E0C File Offset: 0x0007500C
		private global::Infragistics.Windows.DataPresenter.GroupByRecord CreateGroupByRecordCallback(object groupObj)
		{
			global::Infragistics.Windows.DataPresenter.GroupInfo groupInfo = groupObj as global::Infragistics.Windows.DataPresenter.GroupInfo;
			if (groupInfo == null)
			{
				global::System.Windows.Data.CollectionViewGroup collectionViewGroup = groupObj as global::System.Windows.Data.CollectionViewGroup;
				if (collectionViewGroup != null)
				{
					groupInfo = new global::Infragistics.Windows.DataPresenter.GroupInfo
					{
						Value = collectionViewGroup.Name,
						ChildDataRecordCount = collectionViewGroup.ItemCount,
						ChildGroupCount = (collectionViewGroup.IsBottomLevel ? 0 : collectionViewGroup.Items.Count),
						Tag = collectionViewGroup
					};
				}
			}
			return new global::Infragistics.Windows.DataPresenter.GroupByRecord(this._groupByRecordsColl.GroupByField, this._groupByRecordsColl, groupInfo);
		}

		// Token: 0x06001BE3 RID: 7139 RVA: 0x00076E87 File Offset: 0x00075087
		private object GetGroupObjectFromGroupByRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord)
		{
			return groupByRecord.Value;
		}

		// Token: 0x06001BE4 RID: 7140 RVA: 0x00076E8F File Offset: 0x0007508F
		private void InitGroupByRecordCallback(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord)
		{
			groupByRecord.FireInitializeRecord();
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00076E97 File Offset: 0x00075097
		protected override void RaiseDestCollectionEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			this._groupByRecordsColl.RaiseChangeEvents(true);
		}

		// Token: 0x04000B94 RID: 2964
		internal readonly global::Infragistics.Windows.DataPresenter.RecordCollectionBase _groupByRecordsColl;

		// Token: 0x04000B95 RID: 2965
		internal readonly global::Infragistics.Windows.DataPresenter.Field _groupByField;
	}
}
