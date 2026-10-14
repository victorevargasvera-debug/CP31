using System;
using System.Collections.Generic;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008F RID: 143
	public abstract class UndeleteRecordsStrategy
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x060006EA RID: 1770 RVA: 0x0001B995 File Offset: 0x00019B95
		protected internal virtual bool RestoreDescendantActions
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060006EB RID: 1771
		public abstract bool CanUndelete(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> oldRecords);

		// Token: 0x060006EC RID: 1772
		public abstract global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> Undelete(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> oldRecords);

		// Token: 0x060006ED RID: 1773 RVA: 0x0001B998 File Offset: 0x00019B98
		public virtual void ProcessUndeletedRecords(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> recordsCreated)
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001B99C File Offset: 0x00019B9C
		public virtual global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> ProvideDescendantMapping(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> descendants)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object>();
			foreach (global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo in descendants)
			{
				dictionary[recordInfo] = recordInfo.DataItem;
			}
			return dictionary;
		}

		// Token: 0x02000090 RID: 144
		public class RecordInfo : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>
		{
			// Token: 0x060006EF RID: 1775 RVA: 0x0001B9F4 File Offset: 0x00019BF4
			private RecordInfo(global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				this._dataItem = record.DataItem;
				this._dataItemIndex = record.DataItemIndex;
			}

			// Token: 0x060006F0 RID: 1776 RVA: 0x0001BA14 File Offset: 0x00019C14
			public override int GetHashCode()
			{
				return this._dataItem.GetHashCode();
			}

			// Token: 0x060006F1 RID: 1777 RVA: 0x0001BA21 File Offset: 0x00019C21
			public override bool Equals(object obj)
			{
				return this.Equals(obj as global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo);
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0001BA2F File Offset: 0x00019C2F
			internal global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> Children
			{
				get
				{
					return this._childRecords;
				}
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0001BA37 File Offset: 0x00019C37
			public object DataItem
			{
				get
				{
					return this._dataItem;
				}
			}

			// Token: 0x170001CC RID: 460
			// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0001BA3F File Offset: 0x00019C3F
			public int DataItemIndex
			{
				get
				{
					return this._dataItemIndex;
				}
			}

			// Token: 0x170001CD RID: 461
			// (get) Token: 0x060006F5 RID: 1781 RVA: 0x0001BA47 File Offset: 0x00019C47
			internal object DataItemForComparison
			{
				get
				{
					return global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(this._dataItem);
				}
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x060006F6 RID: 1782 RVA: 0x0001BA54 File Offset: 0x00019C54
			// (set) Token: 0x060006F7 RID: 1783 RVA: 0x0001BA5C File Offset: 0x00019C5C
			public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
			{
				get
				{
					return this._recordManager;
				}
				internal set
				{
					this._recordManager = value;
				}
			}

			// Token: 0x060006F8 RID: 1784 RVA: 0x0001BA68 File Offset: 0x00019C68
			internal void AddChildren(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.DescendantRecordInfo descendantInfo)
			{
				global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Field> expandableFields = descendantInfo.GetExpandableFields(record.FieldLayout);
				if (expandableFields == null || expandableFields.Count == 0)
				{
					return;
				}
				foreach (global::Infragistics.Windows.DataPresenter.Field field in expandableFields)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord record2 = record.ChildRecords[field];
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.Record> children = descendantInfo.GetChildren(record2);
					if (children != null && children.Count != 0)
					{
						if (this._childRecords == null)
						{
							this._childRecords = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>>();
						}
						global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>(children.Count);
						int i = 0;
						int count = children.Count;
						while (i < count)
						{
							global::Infragistics.Windows.DataPresenter.DataRecord record3 = children[i] as global::Infragistics.Windows.DataPresenter.DataRecord;
							global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo = global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo.Create(record3);
							if (recordInfo != null)
							{
								list.Add(recordInfo);
								recordInfo.AddChildren(record3, descendantInfo);
							}
							i++;
						}
						this._childRecords[field] = list;
					}
				}
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x0001BB64 File Offset: 0x00019D64
			internal static global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo Create(global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				if (record == null)
				{
					return null;
				}
				if (!record.IsDataRecord)
				{
					return null;
				}
				return new global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo(record)
				{
					RecordManager = record.RecordManager
				};
			}

			// Token: 0x060006FA RID: 1786 RVA: 0x0001BB94 File Offset: 0x00019D94
			public bool Equals(global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo other)
			{
				return other != null && global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(other._dataItem, this._dataItem);
			}

			// Token: 0x04000203 RID: 515
			private object _dataItem;

			// Token: 0x04000204 RID: 516
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x04000205 RID: 517
			private int _dataItemIndex;

			// Token: 0x04000206 RID: 518
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> _childRecords;
		}
	}
}
