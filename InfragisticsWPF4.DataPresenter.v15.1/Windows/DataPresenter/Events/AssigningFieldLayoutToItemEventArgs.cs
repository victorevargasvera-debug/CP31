using System;
using System.Collections;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B0 RID: 688
	public class AssigningFieldLayoutToItemEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060021F6 RID: 8694 RVA: 0x00097374 File Offset: 0x00095574
		public AssigningFieldLayoutToItemEventArgs(object item, global::System.Collections.IEnumerable containingList, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isAddRecord)
		{
			this._containingList = containingList;
			this._item = item;
			this._fieldLayout = fieldLayout;
			this._isAddRecord = isAddRecord;
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x00097399 File Offset: 0x00095599
		internal AssigningFieldLayoutToItemEventArgs(object item, global::System.Collections.IEnumerable containingList, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isAddRecord, global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescProvider, int listIndex) : this(item, containingList, fieldLayout, isAddRecord)
		{
			this._dataPresenter = dataPresenter;
			this._parentCollection = parentCollection;
			this._propertyDescProvider = propertyDescProvider;
			this._listIndex = listIndex;
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060021F8 RID: 8696 RVA: 0x000973C6 File Offset: 0x000955C6
		public global::System.Collections.IEnumerable ContainingList
		{
			get
			{
				return this._containingList;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x000973CE File Offset: 0x000955CE
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x060021FA RID: 8698 RVA: 0x000973D8 File Offset: 0x000955D8
		// (set) Token: 0x060021FB RID: 8699 RVA: 0x000974F5 File Offset: 0x000956F5
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				if (this._fieldLayout == null && this._dataPresenter != null)
				{
					if (this._listIndex >= 0)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this._dataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
						if (dataPresenterExportControlBase != null && this._parentCollection != null)
						{
							global::Infragistics.Windows.DataPresenter.RecordManager associatedRecordManager = this._parentCollection.ParentRecordManager.AssociatedRecordManager;
							if (associatedRecordManager != null && this._listIndex < associatedRecordManager.Unsorted.Count)
							{
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = associatedRecordManager.Unsorted[this._listIndex];
								if (dataRecord != null)
								{
									object objectForRecordComparision = global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(this._item);
									bool flag = associatedRecordManager.DataItemComparer.Equals(objectForRecordComparision, dataRecord.DataItemForComparison);
									if (flag)
									{
										this._fieldLayout = dataPresenterExportControlBase.GetClonedFieldLayout(dataRecord.FieldLayout);
									}
								}
							}
						}
					}
					if (this._fieldLayout == null)
					{
						this._fieldLayout = this._dataPresenter.FieldLayouts.GetDefaultLayoutForItem(this._item, this._containingList, this._parentCollection, this._propertyDescProvider);
					}
					if (this._fieldLayout == null && this._isAddRecord && this._parentCollection != null)
					{
						this._fieldLayout = this._parentCollection.FieldLayout;
					}
				}
				return this._fieldLayout;
			}
			set
			{
				if (value != this._fieldLayout)
				{
					this._fieldLayout = value;
					this._isFieldLayoutExplicitlySet = (this._fieldLayout != null);
				}
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x060021FC RID: 8700 RVA: 0x00097519 File Offset: 0x00095719
		public bool IsAddRecord
		{
			get
			{
				return this._isAddRecord;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x060021FD RID: 8701 RVA: 0x00097524 File Offset: 0x00095724
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord ParentExpandableFieldRecord
		{
			get
			{
				for (global::Infragistics.Windows.DataPresenter.Record record = (this._parentCollection != null) ? this._parentCollection.ParentRecord : null; record != null; record = record.ParentRecord)
				{
					if (record is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)
					{
						return record as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
					}
				}
				return null;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x00097564 File Offset: 0x00095764
		internal bool IsFieldLayoutExplicitlySet
		{
			get
			{
				return this._isFieldLayoutExplicitlySet;
			}
		}

		// Token: 0x040010E2 RID: 4322
		private object _item;

		// Token: 0x040010E3 RID: 4323
		private global::System.Collections.IEnumerable _containingList;

		// Token: 0x040010E4 RID: 4324
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040010E5 RID: 4325
		private bool _isAddRecord;

		// Token: 0x040010E6 RID: 4326
		private int _listIndex;

		// Token: 0x040010E7 RID: 4327
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040010E8 RID: 4328
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _parentCollection;

		// Token: 0x040010E9 RID: 4329
		private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _propertyDescProvider;

		// Token: 0x040010EA RID: 4330
		private bool _isFieldLayoutExplicitlySet;
	}
}
