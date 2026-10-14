using System;
using System.Collections;
using System.Windows;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200026D RID: 621
	public class AssigningFieldLayoutToItemEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001D72 RID: 7538 RVA: 0x00080C22 File Offset: 0x0007EE22
		public AssigningFieldLayoutToItemEventArgs(object item, global::System.Collections.IEnumerable containingList, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isAddRecord)
		{
			this._containingList = containingList;
			this._item = item;
			this._fieldLayout = fieldLayout;
			this._isAddRecord = isAddRecord;
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00080C47 File Offset: 0x0007EE47
		internal AssigningFieldLayoutToItemEventArgs(object item, global::System.Collections.IEnumerable containingList, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, bool isAddRecord, global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescProvider, int listIndex) : this(item, containingList, fieldLayout, isAddRecord)
		{
			this._dataPresenter = dataPresenter;
			this._parentCollection = parentCollection;
			this._propertyDescProvider = propertyDescProvider;
			this._listIndex = listIndex;
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x00080C74 File Offset: 0x0007EE74
		public global::System.Collections.IEnumerable ContainingList
		{
			get
			{
				return this._containingList;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00080C7C File Offset: 0x0007EE7C
		public object Item
		{
			get
			{
				return this._item;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x00080C84 File Offset: 0x0007EE84
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00080D98 File Offset: 0x0007EF98
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
									bool flag = objectForRecordComparision == dataRecord.DataItemForComparison;
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

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x00080DBC File Offset: 0x0007EFBC
		public bool IsAddRecord
		{
			get
			{
				return this._isAddRecord;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x00080DC4 File Offset: 0x0007EFC4
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

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x00080E04 File Offset: 0x0007F004
		internal bool IsFieldLayoutExplicitlySet
		{
			get
			{
				return this._isFieldLayoutExplicitlySet;
			}
		}

		// Token: 0x04000E7B RID: 3707
		private object _item;

		// Token: 0x04000E7C RID: 3708
		private global::System.Collections.IEnumerable _containingList;

		// Token: 0x04000E7D RID: 3709
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000E7E RID: 3710
		private bool _isAddRecord;

		// Token: 0x04000E7F RID: 3711
		private int _listIndex;

		// Token: 0x04000E80 RID: 3712
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04000E81 RID: 3713
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _parentCollection;

		// Token: 0x04000E82 RID: 3714
		private global::Infragistics.Windows.Internal.PropertyDescriptorProvider _propertyDescProvider;

		// Token: 0x04000E83 RID: 3715
		private bool _isFieldLayoutExplicitlySet;
	}
}
