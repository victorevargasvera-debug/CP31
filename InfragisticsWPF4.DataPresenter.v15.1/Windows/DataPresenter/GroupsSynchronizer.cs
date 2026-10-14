using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows.Data;
using System.Windows.Threading;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000220 RID: 544
	internal class GroupsSynchronizer : global::Infragistics.Windows.DataPresenter.ListSynchronizer<object, global::Infragistics.Windows.DataPresenter.GroupByRecord>
	{
		// Token: 0x06002055 RID: 8277 RVA: 0x0008CDBC File Offset: 0x0008AFBC
		internal GroupsSynchronizer(global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer collectionViewSynchronizer, global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByRecordsColl, global::System.Collections.Generic.IList<object> groups, global::Infragistics.Windows.DataPresenter.Disposable disposable) : base(groups, new global::Infragistics.CoreUtilities.TypedList<global::Infragistics.Windows.DataPresenter.GroupByRecord>(groupByRecordsColl.SparseArray), disposable)
		{
			this._collectionViewSynchronizer = collectionViewSynchronizer;
			this._groupByRecordsColl = groupByRecordsColl;
			this._groupByField = this._groupByRecordsColl.GroupByField;
			base.Initialize(new global::System.Func<object, global::Infragistics.Windows.DataPresenter.GroupByRecord>(this.CreateGroupByRecordCallback), new global::System.Action<global::Infragistics.Windows.DataPresenter.GroupByRecord>(this.InitGroupByRecordCallback), new global::System.Action<global::Infragistics.Windows.DataPresenter.GroupByRecord>(this.DisposeGroupByRecord), new global::System.Func<global::Infragistics.Windows.DataPresenter.GroupByRecord, object>(this.GetGroupObjectFromGroupByRecord));
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0008CE34 File Offset: 0x0008B034
		private global::Infragistics.Windows.DataPresenter.GroupByRecord CreateGroupByRecordCallback(object groupObj)
		{
			global::Infragistics.Windows.DataPresenter.GroupInfo groupInfo = groupObj as global::Infragistics.Windows.DataPresenter.GroupInfo;
			if (groupInfo == null)
			{
				global::System.Windows.Data.CollectionViewGroup collectionViewGroup = groupObj as global::System.Windows.Data.CollectionViewGroup;
				if (collectionViewGroup != null)
				{
					groupInfo = new global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo(collectionViewGroup);
				}
			}
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = new global::Infragistics.Windows.DataPresenter.GroupByRecord(this._groupByRecordsColl.GroupByField, this._groupByRecordsColl, groupInfo);
			if (groupInfo != null)
			{
				groupInfo.GroupByRecord = groupByRecord;
			}
			return groupByRecord;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0008CE7F File Offset: 0x0008B07F
		private object GetGroupObjectFromGroupByRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord)
		{
			return groupByRecord.CommonValueInternal;
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0008CE87 File Offset: 0x0008B087
		private void InitGroupByRecordCallback(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord)
		{
			groupByRecord.FireInitializeRecord();
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0008CE90 File Offset: 0x0008B090
		private void DisposeGroupByRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord)
		{
			global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo collectionViewGroupInfo = groupByRecord.CommonValueInternal as global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo;
			if (collectionViewGroupInfo != null)
			{
				collectionViewGroupInfo.Dispose();
			}
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0008CEB2 File Offset: 0x0008B0B2
		protected override void RaiseDestCollectionEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			this._groupByRecordsColl.RaiseChangeEvents(true);
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0008CEC0 File Offset: 0x0008B0C0
		protected override void OnSource_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if ((this._disposable == null || !this._disposable.IsDisposed) && (global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset == e.Action || (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add && this._source.Count == 0)) && this._collectionViewSynchronizer != null && !this._collectionViewSynchronizer.EnsureGroupDescriptionsSynchronized())
			{
				return;
			}
			base.OnSource_CollectionChanged(sender, e);
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0008CF74 File Offset: 0x0008B174
		internal override void Synchronize()
		{
			bool flag = this._groupByRecordsColl.ParentRecordManager.GroupsInternal == this._groupByRecordsColl;
			if (flag)
			{
				bool flag2 = this._expandedGroupNameTree == null || this._groupbyVersion != this._groupByField.Owner.GroupByVersion;
				if (flag2)
				{
					this._groupbyVersion = this._groupByField.Owner.GroupByVersion;
					this._expandedGroupNameTree = new global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable>();
				}
				int countOfGroupByFields = this._groupByField.Owner.SortedFields.CountOfGroupByFields;
				int nestingLevel = 0;
				global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable> expandedGroupNameTree = this._expandedGroupNameTree;
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByRecordsColl = this._groupByRecordsColl;
				this.SnapshoGroupbyExpansionState(countOfGroupByFields, nestingLevel, expandedGroupNameTree, groupByRecordsColl);
			}
			base.Synchronize();
			if (flag)
			{
				global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					if (this._expandedGroupNameTree != null && this._expandedGroupNameTree.Count > 0)
					{
						int countOfGroupByFields2 = this._groupByField.Owner.SortedFields.CountOfGroupByFields;
						int nestingLevel2 = 0;
						global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable> expandedGroupNameTree2 = this._expandedGroupNameTree;
						global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByRecordsColl2 = this._groupByRecordsColl;
						this.ProcessGroupbyExpansionStateSnapshot(countOfGroupByFields2, nestingLevel2, expandedGroupNameTree2, groupByRecordsColl2);
					}
				}), new object[0]);
			}
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0008D050 File Offset: 0x0008B250
		private void ProcessGroupbyExpansionStateSnapshot(int groupbyDepth, int nestingLevel, global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable> dictionary, global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByCollection)
		{
			if (dictionary == null || groupByCollection == null)
			{
				return;
			}
			int num = dictionary.Count;
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)groupByCollection))
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = (global::Infragistics.Windows.DataPresenter.GroupByRecord)record;
				if (groupByRecord != null && !groupByRecord.IsExpanded)
				{
					global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo collectionViewGroupInfo = groupByRecord.CommonValueInternal as global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo;
					if (collectionViewGroupInfo != null)
					{
						object name = collectionViewGroupInfo.CollectionViewGroup.Name;
						if (dictionary.ContainsKey(name))
						{
							groupByRecord.IsExpanded = true;
							num--;
							if (nestingLevel < groupbyDepth - 1)
							{
								global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable> dictionary2 = dictionary[name] as global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable>;
								this.ProcessGroupbyExpansionStateSnapshot(groupbyDepth, nestingLevel + 1, dictionary2, groupByRecord.ChildRecordsInternal);
							}
							if (num == 0)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0008D110 File Offset: 0x0008B310
		private void SnapshoGroupbyExpansionState(int groupbyDepth, int nestingLevel, global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable> dictionary, global::Infragistics.Windows.DataPresenter.RecordCollectionBase groupByCollection)
		{
			if (dictionary == null || groupByCollection == null)
			{
				return;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)groupByCollection))
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = (global::Infragistics.Windows.DataPresenter.GroupByRecord)record;
				if (groupByRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo collectionViewGroupInfo = groupByRecord.CommonValueInternal as global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo;
					if (collectionViewGroupInfo != null)
					{
						object name = collectionViewGroupInfo.CollectionViewGroup.Name;
						bool flag = dictionary.ContainsKey(name);
						if (groupByRecord.IsExpanded)
						{
							global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = null;
							global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable> dictionary2 = null;
							if (nestingLevel < groupbyDepth - 1)
							{
								recordCollectionBase = groupByRecord.ChildRecordsInternal;
								if (flag)
								{
									dictionary2 = (dictionary[name] as global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable>);
								}
								else
								{
									dictionary2 = new global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable>();
								}
							}
							dictionary[name] = dictionary2;
							if (recordCollectionBase != null)
							{
								this.SnapshoGroupbyExpansionState(groupbyDepth, nestingLevel + 1, dictionary2, recordCollectionBase);
							}
						}
						else if (flag)
						{
							dictionary.Remove(name);
						}
					}
				}
			}
		}

		// Token: 0x04000DAC RID: 3500
		internal readonly global::Infragistics.Windows.DataPresenter.RecordCollectionBase _groupByRecordsColl;

		// Token: 0x04000DAD RID: 3501
		internal readonly global::Infragistics.Windows.DataPresenter.Field _groupByField;

		// Token: 0x04000DAE RID: 3502
		internal readonly global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer _collectionViewSynchronizer;

		// Token: 0x04000DAF RID: 3503
		private int _groupbyVersion;

		// Token: 0x04000DB0 RID: 3504
		private global::System.Collections.Generic.Dictionary<object, global::System.Collections.IEnumerable> _expandedGroupNameTree;
	}
}
