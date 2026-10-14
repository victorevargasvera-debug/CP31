using System;
using System.Collections.Generic;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000095 RID: 149
	public abstract class UndeleteRecordsStrategy
	{
		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x0001E675 File Offset: 0x0001C875
		protected internal virtual bool RestoreDescendantActions
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000771 RID: 1905
		public abstract bool CanUndelete(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> oldRecords);

		// Token: 0x06000772 RID: 1906
		public abstract global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> Undelete(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> oldRecords);

		// Token: 0x06000773 RID: 1907 RVA: 0x0001E678 File Offset: 0x0001C878
		public virtual void ProcessUndeletedRecords(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> recordsCreated)
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001E67C File Offset: 0x0001C87C
		public virtual global::System.Collections.Generic.IDictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> ProvideDescendantMapping(global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo> descendants)
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo, object>();
			foreach (global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo recordInfo in descendants)
			{
				dictionary[recordInfo] = recordInfo.DataItem;
			}
			return dictionary;
		}

		// Token: 0x02000096 RID: 150
		public class RecordInfo : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>
		{
			// Token: 0x06000775 RID: 1909 RVA: 0x0001E6D4 File Offset: 0x0001C8D4
			private RecordInfo(global::Infragistics.Windows.DataPresenter.DataRecord record)
			{
				this._dataItem = record.DataItem;
				this._dataItemIndex = record.DataItemIndex;
			}

			// Token: 0x06000776 RID: 1910 RVA: 0x0001E6F4 File Offset: 0x0001C8F4
			public override int GetHashCode()
			{
				return this._dataItem.GetHashCode();
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x0001E701 File Offset: 0x0001C901
			public override bool Equals(object obj)
			{
				return this.Equals(obj as global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo);
			}

			// Token: 0x170001EE RID: 494
			// (get) Token: 0x06000778 RID: 1912 RVA: 0x0001E70F File Offset: 0x0001C90F
			internal global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> Children
			{
				get
				{
					return this._childRecords;
				}
			}

			// Token: 0x170001EF RID: 495
			// (get) Token: 0x06000779 RID: 1913 RVA: 0x0001E717 File Offset: 0x0001C917
			public object DataItem
			{
				get
				{
					return this._dataItem;
				}
			}

			// Token: 0x170001F0 RID: 496
			// (get) Token: 0x0600077A RID: 1914 RVA: 0x0001E71F File Offset: 0x0001C91F
			public int DataItemIndex
			{
				get
				{
					return this._dataItemIndex;
				}
			}

			// Token: 0x170001F1 RID: 497
			// (get) Token: 0x0600077B RID: 1915 RVA: 0x0001E727 File Offset: 0x0001C927
			internal object DataItemForComparison
			{
				get
				{
					return global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(this._dataItem);
				}
			}

			// Token: 0x170001F2 RID: 498
			// (get) Token: 0x0600077C RID: 1916 RVA: 0x0001E734 File Offset: 0x0001C934
			// (set) Token: 0x0600077D RID: 1917 RVA: 0x0001E73C File Offset: 0x0001C93C
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

			// Token: 0x0600077E RID: 1918 RVA: 0x0001E748 File Offset: 0x0001C948
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

			// Token: 0x0600077F RID: 1919 RVA: 0x0001E844 File Offset: 0x0001CA44
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

			// Token: 0x06000780 RID: 1920 RVA: 0x0001E874 File Offset: 0x0001CA74
			public bool Equals(global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo other)
			{
				return other != null && global::Infragistics.Windows.DataPresenter.ClipboardOperationInfo.IsSameDataItem(other._dataItem, this._dataItem, this._recordManager.DataItemComparer);
			}

			// Token: 0x04000247 RID: 583
			private object _dataItem;

			// Token: 0x04000248 RID: 584
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x04000249 RID: 585
			private int _dataItemIndex;

			// Token: 0x0400024A RID: 586
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy.RecordInfo>> _childRecords;
		}
	}
}
