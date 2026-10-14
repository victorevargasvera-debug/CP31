using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Xml;
using Infragistics.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000149 RID: 329
	public class DataRecord : global::Infragistics.Windows.DataPresenter.Record, global::System.Windows.IWeakEventListener
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x0004E614 File Offset: 0x0004C814
		internal static global::Infragistics.Windows.DataPresenter.DataRecord Create(global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, object listObject, bool isAddRecord, int listIndex)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = parentCollection.ParentRecordManager;
			global::System.Collections.IEnumerable dataSource = parentRecordManager.DataSource;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = parentCollection.DataPresenter;
			if (dataPresenter == null || dataSource == null)
			{
				return null;
			}
			dataPresenter.VerifyAccess();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
			global::Infragistics.Windows.DataPresenter.FieldLayoutCollection fieldLayouts = dataPresenter.FieldLayouts;
			bool flag = false;
			if (!isAddRecord && parentCollection.ParentDataRecord == null && listObject is global::System.Collections.IEnumerable && !(listObject is string) && !(listObject is global::System.Xml.XmlNode))
			{
				flag = true;
			}
			if (flag)
			{
				listObject = new global::Infragistics.Windows.Helpers.EnumerableObjectWrapper(listObject as global::System.Collections.IEnumerable);
			}
			object obj = listObject;
			if (obj == null && isAddRecord && parentRecordManager != null && !parentRecordManager.CanGetPropertiesFromDataSourceWithoutItems && parentRecordManager.Unsorted.Count > 0)
			{
				obj = parentRecordManager.Unsorted[0].DataItem;
			}
			global::Infragistics.Windows.Internal.PropertyDescriptorProvider propertyDescriptorProvider = fieldLayouts.GetPropertyDescriptorProvider(obj, dataSource);
			if (propertyDescriptorProvider == null)
			{
				return null;
			}
			if (fieldLayouts.Count == 0)
			{
				fieldLayout = fieldLayouts.GetDefaultLayoutForItem(listObject, dataSource, parentCollection, propertyDescriptorProvider);
				if (fieldLayout == null && isAddRecord)
				{
					fieldLayout = parentCollection.FieldLayout;
				}
			}
			global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs assigningFieldLayoutToItemEventArgs = new global::Infragistics.Windows.DataPresenter.Events.AssigningFieldLayoutToItemEventArgs(listObject, dataSource, fieldLayout, isAddRecord, dataPresenter, parentCollection, propertyDescriptorProvider, listIndex);
			dataPresenter.RaiseAssigningFieldLayoutToItem(assigningFieldLayoutToItemEventArgs);
			fieldLayout = assigningFieldLayoutToItemEventArgs.FieldLayout;
			if (fieldLayout == null)
			{
				return null;
			}
			if (!fieldLayout.AreFieldsInitialized)
			{
				fieldLayout.InitializeFields(listObject, dataSource, parentCollection, propertyDescriptorProvider);
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider layoutPropertyDescriptorProvider = fieldLayout.GetProvider(propertyDescriptorProvider);
			if (layoutPropertyDescriptorProvider == null && isAddRecord && parentCollection.SparseArray.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = parentCollection.SparseArray.GetItem(0, true) as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					layoutPropertyDescriptorProvider = dataRecord._propertyDescriptorProvider;
				}
			}
			if (layoutPropertyDescriptorProvider == null)
			{
				return null;
			}
			if (assigningFieldLayoutToItemEventArgs.IsFieldLayoutExplicitlySet && !fieldLayout.IsProviderCached(propertyDescriptorProvider) && !assigningFieldLayoutToItemEventArgs.FieldLayout.IsListObjectCompatible(listObject, dataSource, true, propertyDescriptorProvider))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_27"), "FieldLayout");
			}
			fieldLayout.OnDataRecordLoaded();
			global::Infragistics.Windows.Internal.XmlNodePropertyDescriptorProvider xmlNodePropertyDescriptorProvider = layoutPropertyDescriptorProvider.Provider as global::Infragistics.Windows.Internal.XmlNodePropertyDescriptorProvider;
			if (xmlNodePropertyDescriptorProvider != null)
			{
				global::System.Xml.XmlNode xmlNode = listObject as global::System.Xml.XmlNode;
				if (xmlNode != null)
				{
					xmlNodePropertyDescriptorProvider.MergePropertiesFromNode(xmlNode);
				}
			}
			global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker sortGroupVersionTracker = parentRecordManager.TrackSortGroupVersionNumberChanges(fieldLayout);
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = new global::Infragistics.Windows.DataPresenter.DataRecord(fieldLayout, layoutPropertyDescriptorProvider, parentCollection, listObject, isAddRecord, sortGroupVersionTracker);
			if (isAddRecord)
			{
				dataPresenter.RaiseInitializeTemplateAddRecord(dataRecord2);
			}
			return dataRecord2;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x0004E800 File Offset: 0x0004CA00
		internal static void CreateTemplateDataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, out global::Infragistics.Windows.DataPresenter.DataRecord createdTemplateRecord)
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase templateDataRecords = fieldLayout.DataPresenter.FieldLayouts.TemplateDataRecords;
			createdTemplateRecord = new global::Infragistics.Windows.DataPresenter.TemplateDataRecord(fieldLayout, templateDataRecords);
			createdTemplateRecord._cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter;
			templateDataRecords.AddRecord(createdTemplateRecord);
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0004E837 File Offset: 0x0004CA37
		private DataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider provider, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, object listObject, bool isAddRecord, global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker sortGroupVersionTracker) : base(layout, parentCollection)
		{
			this._underlyingDataVersion = base.ParentCollection.ParentRecordManager.UnderlyingDataVersion;
			this._propertyDescriptorProvider = provider;
			this._isAddRecord = isAddRecord;
			this._sortGroupVersionTracker = sortGroupVersionTracker;
			this.SetDataItemHelper(listObject);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0004E876 File Offset: 0x0004CA76
		internal DataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : this(layout, null, parentCollection, null, false, null)
		{
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x0004E884 File Offset: 0x0004CA84
		internal override bool CanDelete
		{
			get
			{
				if (this.IsAddRecord)
				{
					return this._dataItem != null;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				if (fieldLayout == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = null;
				if (base.ParentCollection != null)
				{
					recordManager = base.ParentCollection.ParentRecordManager;
				}
				return recordManager != null && fieldLayout.AllowDeleteResolved && recordManager.DataSourceAllowsDelete;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0004E8DD File Offset: 0x0004CADD
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return this.GetChildRcdCollection(false);
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x0004E8E6 File Offset: 0x0004CAE6
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return this.ChildRecords;
			}
		}

		// Token: 0x06001242 RID: 4674 RVA: 0x0004E8F0 File Offset: 0x0004CAF0
		internal override void CloneAssociatedRecordSettings(global::Infragistics.Windows.DataPresenter.Record associatedRecord, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			base.CloneAssociatedRecordSettings(associatedRecord, options);
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = associatedRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord._cells != null)
			{
				this.Cells.CloneAssociatedCellSettings(dataRecord.Cells);
			}
		}

		// Token: 0x06001243 RID: 4675 RVA: 0x0004E928 File Offset: 0x0004CB28
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.DataRecordPresenter();
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x0004E930 File Offset: 0x0004CB30
		internal override void EnsureFiltersEvaluated()
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = base.ParentCollection;
				if (parentCollection != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = parentCollection.ViewableRecords;
					if (viewableRecords != null && viewableRecords.EnsureFiltersEvaluated() && (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) != 0)
					{
						this.ApplyFiltersHelper();
					}
				}
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x0004E973 File Offset: 0x0004CB73
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			return base.ParentCollection.ParentRecordManager.GetAssociatedRecordInternal(this);
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001246 RID: 4678 RVA: 0x0004E988 File Offset: 0x0004CB88
		public override bool HasChildren
		{
			get
			{
				if (!this.HasExpandableFieldRecords)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection expandableFieldRecordCollection = this.ChildRecordsIfNeeded as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection;
				if (expandableFieldRecordCollection == null)
				{
					return false;
				}
				for (int i = 0; i < expandableFieldRecordCollection.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = expandableFieldRecordCollection[i];
					if (!expandableFieldRecord.Field.IsExpandableByDefault || expandableFieldRecord.HasChildrenInternal)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x0004E9E1 File Offset: 0x0004CBE1
		internal override bool HasChildrenInternal
		{
			get
			{
				return this.HasExpandableFieldRecords;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001248 RID: 4680 RVA: 0x0004E9E9 File Offset: 0x0004CBE9
		internal override bool HasChildData
		{
			get
			{
				if (this.IsExpanded)
				{
					return base.HasChildData;
				}
				return this.HasExpandableFieldRecords;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x0004EA00 File Offset: 0x0004CC00
		public override bool IsDataRecord
		{
			get
			{
				return !this.IsAddRecordTemplate;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600124A RID: 4682 RVA: 0x0004EA0B File Offset: 0x0004CC0B
		internal override bool IsIndexValid
		{
			get
			{
				return this.IsAddRecordTemplate || base.IsIndexValid;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x0004EA1D File Offset: 0x0004CC1D
		internal override bool IsOnTopWhenFixed
		{
			get
			{
				if (this.IsAddRecord)
				{
					return base.ParentCollection.ViewableRecords.IsAddRecordOnTop;
				}
				return base.IsOnTopWhenFixed;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x0004EA3E File Offset: 0x0004CC3E
		protected internal override bool IsSelectable
		{
			get
			{
				return !this.IsAddRecordTemplate && base.IsSelectable;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x0004EA50 File Offset: 0x0004CC50
		public override bool IsSpecialRecord
		{
			get
			{
				return this._isAddRecord;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x0600124E RID: 4686 RVA: 0x0004EA58 File Offset: 0x0004CC58
		internal override bool IsStillValid
		{
			get
			{
				return !this._isDeleted && base.IsStillValid;
			}
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0004EA6A File Offset: 0x0004CC6A
		internal override void OnAssociatedRecordPresenterChanged()
		{
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x0004EA6C File Offset: 0x0004CC6C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.DataRecord;
			}
		}

		// Token: 0x06001251 RID: 4689 RVA: 0x0004EA70 File Offset: 0x0004CC70
		internal override bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null || field.Index < 0)
			{
				return false;
			}
			if (this.IsAddRecord)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout owner = field.Owner;
			if (owner == null || !owner.IsEmptyCellCollapsingSupportedByView)
			{
				return false;
			}
			if (!this.ShouldCollapseEmptyCellsResolved)
			{
				return false;
			}
			if (!field.CollapseWhenEmptyResolved)
			{
				return false;
			}
			bool result = false;
			object cellValue = this.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
			if (cellValue == null || cellValue is global::System.DBNull)
			{
				result = true;
			}
			else
			{
				global::System.Type type = cellValue.GetType();
				global::System.Type type2 = global::System.Nullable.GetUnderlyingType(type) ?? type;
				if (!(type != type2))
				{
					if (type2 == typeof(double) || type2 == typeof(float))
					{
						double num = (double)global::Infragistics.CoreUtilities.ConvertDataValue(cellValue, typeof(double), null, null);
						result = (num == 0.0 || double.IsNaN(num));
					}
					else if (global::Infragistics.Windows.Utilities.IsNumericType(type2))
					{
						result = object.Equals(0m, global::Infragistics.CoreUtilities.ConvertDataValue(cellValue, typeof(decimal), null, null));
					}
					else
					{
						string text = cellValue as string;
						if (text == null)
						{
							text = cellValue.ToString();
						}
						if (text != null)
						{
							result = (text.Trim().Length == 0);
						}
					}
				}
			}
			return result;
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x0004EBAC File Offset: 0x0004CDAC
		public override bool ShouldCollapseEmptyCellsResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				if (fieldLayout == null)
				{
					return false;
				}
				if (!fieldLayout.IsEmptyCellCollapsingSupportedByView)
				{
					return false;
				}
				if (this.IsSpecialRecord)
				{
					return false;
				}
				bool result = false;
				if (base.ShouldCollapseEmptyCells != null)
				{
					result = base.ShouldCollapseEmptyCells.Value;
				}
				else if (fieldLayout.DataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = fieldLayout.DataPresenter.CurrentViewInternal;
					if (currentViewInternal != null)
					{
						result = currentViewInternal.DefaultShouldCollapseEmptyCells;
					}
				}
				return result;
			}
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0004EC1C File Offset: 0x0004CE1C
		internal override void SortChildren()
		{
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x0004EC20 File Offset: 0x0004CE20
		internal override bool ToggleContainingCardCollapsedState(bool addToUndo)
		{
			if (base.DataPresenter == null)
			{
				return false;
			}
			if (base.IsContainingCardCollapsed != null)
			{
				base.IsContainingCardCollapsed = !base.IsContainingCardCollapsed;
			}
			else if (base.FieldLayout != null && base.FieldLayout.DataPresenter != null && base.FieldLayout.DataPresenter.CurrentViewInternal != null)
			{
				base.IsContainingCardCollapsed = new bool?(!base.FieldLayout.DataPresenter.CurrentViewInternal.DefaultShouldCollapseCards);
			}
			else
			{
				base.IsContainingCardCollapsed = null;
			}
			return true;
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x0004ECD8 File Offset: 0x0004CED8
		internal override bool ToggleContainingCardEmptyCellsCollapsedState(bool addToUndo)
		{
			if (base.DataPresenter == null)
			{
				return false;
			}
			if (base.ShouldCollapseEmptyCells != null)
			{
				base.ShouldCollapseEmptyCells = null;
			}
			else if (base.FieldLayout != null && base.FieldLayout.DataPresenter != null && base.FieldLayout.DataPresenter.CurrentViewInternal != null)
			{
				base.ShouldCollapseEmptyCells = new bool?(!base.FieldLayout.DataPresenter.CurrentViewInternal.DefaultShouldCollapseEmptyCells);
			}
			else
			{
				base.ShouldCollapseEmptyCells = null;
			}
			return true;
		}

		// Token: 0x06001256 RID: 4694 RVA: 0x0004ED70 File Offset: 0x0004CF70
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("DataRecord- ");
			stringBuilder.Append(this.DataItemIndex.ToString());
			if (this._isDeleted)
			{
				stringBuilder.Append(" --- Deleted --- ");
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Field field = null;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				if (fieldLayout != null)
				{
					field = fieldLayout.PrimaryField;
				}
				if (field != null)
				{
					stringBuilder.Append(" ");
					stringBuilder.Append(field.Name);
					stringBuilder.Append(": ");
					object cellValue = this.GetCellValue(field, true);
					if (cellValue == null)
					{
						stringBuilder.Append("[null]");
					}
					else
					{
						stringBuilder.Append(cellValue.ToString());
					}
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x0004EE24 File Offset: 0x0004D024
		internal override global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				if (this._expandableFieldRecords == null)
				{
					global::Infragistics.Windows.DataPresenter.FieldCollection fields = base.FieldLayout.Fields;
					int expandableFieldsCount = fields.ExpandableFieldsCount;
					if (expandableFieldsCount < 1)
					{
						return null;
					}
				}
				return base.ViewableChildRecords;
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0004EE58 File Offset: 0x0004D058
		public global::Infragistics.Windows.DataPresenter.CellCollection Cells
		{
			get
			{
				if (this._cells == null)
				{
					this._cells = this.CreateCellCollection();
				}
				return this._cells;
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x0004EE74 File Offset: 0x0004D074
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection ChildRecords
		{
			get
			{
				return this.GetChildRcdCollection(true);
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600125A RID: 4698 RVA: 0x0004EE80 File Offset: 0x0004D080
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public object DataItem
		{
			get
			{
				if ((this._dataItem == null || this._underlyingDataVersion != base.ParentCollection.ParentRecordManager.UnderlyingDataVersion) && !this._isAddRecord && !this._isDeleted)
				{
					global::System.Collections.IList list = base.ParentCollection.ParentRecordManager.List;
					if (list != null)
					{
						int dataItemIndex = this.DataItemIndex;
						this._underlyingDataVersion = base.ParentCollection.ParentRecordManager.UnderlyingDataVersion;
						if (dataItemIndex >= 0 && dataItemIndex < list.Count)
						{
							this.SetDataItemHelper(list[dataItemIndex]);
						}
					}
				}
				return this._dataItem;
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x0004EF10 File Offset: 0x0004D110
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public int DataItemIndex
		{
			get
			{
				if (this._isDeleted)
				{
					return -1;
				}
				if (this.IsAddRecord && this._dataItem == null)
				{
					return -1;
				}
				global::Infragistics.Windows.DataPresenter.DataRecordCollection unsortedInternalVerify = base.ParentCollection.ParentRecordManager.UnsortedInternalVerify;
				if (this._dataItemIndex < 0 || this._dataItemIndex >= unsortedInternalVerify.Count || this != unsortedInternalVerify.SparseArray.GetItem(this._dataItemIndex, false))
				{
					this._dataItemIndex = unsortedInternalVerify.IndexOf(this);
				}
				return this._dataItemIndex;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x0600125C RID: 4700 RVA: 0x0004EF8C File Offset: 0x0004D18C
		public object DataError
		{
			get
			{
				if (this.IsRecordDataErrorInfoSupported)
				{
					global::System.ComponentModel.IDataErrorInfo dataErrorInfo = this.GetDataErrorInfo();
					if (dataErrorInfo != null)
					{
						return dataErrorInfo.Error;
					}
				}
				return null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0004EFB3 File Offset: 0x0004D1B3
		public bool HasDataError
		{
			get
			{
				return !global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(this.DataError);
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x0600125E RID: 4702 RVA: 0x0004EFC3 File Offset: 0x0004D1C3
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasExpandableFieldRecords
		{
			get
			{
				return (this._expandableFieldRecords != null && this._expandableFieldRecords.Count > 0) || base.FieldLayout.Fields.ExpandableFieldsCount > 0;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x0004EFF0 File Offset: 0x0004D1F0
		public bool IsAddRecord
		{
			get
			{
				return this._isAddRecord;
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0004EFF8 File Offset: 0x0004D1F8
		public bool IsCellAllocated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._cells != null && this._cells.IsCellAllocated(field);
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0004F010 File Offset: 0x0004D210
		public bool IsCellAllocated(int index)
		{
			return this._cells != null && this._cells.IsCellAllocated(index);
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06001262 RID: 4706 RVA: 0x0004F028 File Offset: 0x0004D228
		public bool IsDataChanged
		{
			get
			{
				if (this._isDataChanged)
				{
					return true;
				}
				global::Infragistics.Windows.DataPresenter.Cell activeCell = base.DataPresenter.ActiveCell;
				return activeCell != null && activeCell.Record == this && activeCell.IsDataChanged;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06001263 RID: 4707 RVA: 0x0004F05F File Offset: 0x0004D25F
		public bool IsDeleted
		{
			get
			{
				return this._isDeleted;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0004F067 File Offset: 0x0004D267
		public bool? IsFilteredOut
		{
			get
			{
				return base.InternalIsFilteredOutNullable_Verify;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x0004F06F File Offset: 0x0004D26F
		internal global::Infragistics.Windows.DataPresenter.CellCollection CellsIfAllocated
		{
			get
			{
				return this._cells;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0004F077 File Offset: 0x0004D277
		internal global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection ChildRecordsIfAllocated
		{
			get
			{
				return this._expandableFieldRecords;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0004F07F File Offset: 0x0004D27F
		internal object DataItemForComparison
		{
			get
			{
				if (this._dataItem == null)
				{
					return null;
				}
				if (this._dataItemForComparison != null)
				{
					return this._dataItemForComparison;
				}
				this._dataItemForComparison = global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(this._dataItem);
				return this._dataItemForComparison;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0004F0B1 File Offset: 0x0004D2B1
		internal object DataItemInternal
		{
			get
			{
				return this._dataItem;
			}
		}

		// Token: 0x1700046D RID: 1133
		// (set) Token: 0x06001269 RID: 4713 RVA: 0x0004F0B9 File Offset: 0x0004D2B9
		internal global::Infragistics.Windows.DataPresenter.Field IgnoreChangeNotificationsForField
		{
			set
			{
				this._ignoreChangeNotificationsForField = value;
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0004F0C2 File Offset: 0x0004D2C2
		internal bool IsAddRecordTemplate
		{
			get
			{
				return this._isAddRecord && this._dataItem == null;
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x0004F0D8 File Offset: 0x0004D2D8
		internal bool IsRecordDataErrorInfoSupported
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				if (fieldLayout != null)
				{
					global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo supportDataErrorInfoResolved = fieldLayout.SupportDataErrorInfoResolved;
					if (global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.RecordsOnly == supportDataErrorInfoResolved || global::Infragistics.Windows.DataPresenter.SupportDataErrorInfo.RecordsAndCells == supportDataErrorInfoResolved)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0004F104 File Offset: 0x0004D304
		internal global::Infragistics.Windows.DataPresenter.Cell FirstDisplayedCell
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field firstDisplayedField = this.FirstDisplayedField;
				if (firstDisplayedField == null)
				{
					return null;
				}
				return this.Cells[firstDisplayedField];
			}
		}

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x0004F12C File Offset: 0x0004D32C
		internal global::Infragistics.Windows.DataPresenter.Field FirstDisplayedField
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = base.FieldLayout.StyleGenerator;
				if (styleGenerator == null)
				{
					return null;
				}
				return styleGenerator.GridFieldMap.GetFirstField();
			}
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0004F158 File Offset: 0x0004D358
		internal global::Infragistics.Windows.DataPresenter.Cell LastDisplayedCell
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Field lastDisplayedField = this.LastDisplayedField;
				if (lastDisplayedField == null)
				{
					return null;
				}
				return this.Cells[lastDisplayedField];
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0004F180 File Offset: 0x0004D380
		internal global::Infragistics.Windows.DataPresenter.Field LastDisplayedField
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = base.FieldLayout.StyleGenerator;
				if (styleGenerator == null)
				{
					return null;
				}
				return styleGenerator.GridFieldMap.GetLastField();
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x0004F1A9 File Offset: 0x0004D3A9
		internal global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider PropertyDescriptorProvider
		{
			get
			{
				return this._propertyDescriptorProvider;
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0004F1B1 File Offset: 0x0004D3B1
		internal int SortIndex
		{
			get
			{
				return base.ParentCollection.ParentRecordManager.Sorted.IndexOf(this);
			}
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0004F1CC File Offset: 0x0004D3CC
		public bool CancelUpdate()
		{
			if (!this.IsDataChanged)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs recordUpdateCancelingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCancelingEventArgs(this);
			base.DataPresenter.RaiseRecordUpdateCanceling(recordUpdateCancelingEventArgs);
			if (recordUpdateCancelingEventArgs.Cancel)
			{
				return false;
			}
			this.CancelEdit();
			base.DataPresenter.RaiseRecordUpdateCanceled(new global::Infragistics.Windows.DataPresenter.Events.RecordUpdateCanceledEventArgs(this));
			return true;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0004F218 File Offset: 0x0004D418
		public global::Infragistics.Windows.DataPresenter.Cell GetCellIfAllocated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cells == null)
			{
				return null;
			}
			return this._cells.GetCellIfAllocated(field);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0004F230 File Offset: 0x0004D430
		public string GetCellText(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.ConvertCellValue(this, field);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0004F239 File Offset: 0x0004D439
		public object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.GetCellValue(field, false);
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0004F244 File Offset: 0x0004D444
		public virtual object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, bool useConverter)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("Field");
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
			if (field.Owner != fieldLayout)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_28"));
			}
			object cellValueHelper = this.GetCellValueHelper(field);
			if (useConverter)
			{
				return field.ConvertValue(cellValueHelper, this);
			}
			return cellValueHelper;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0004F294 File Offset: 0x0004D494
		private object GetCellValueHelper(global::Infragistics.Windows.DataPresenter.Field field)
		{
			object result;
			try
			{
				if (this.IsAddRecordTemplate)
				{
					result = base.ParentCollection.ParentRecordManager.GetAddRecordCellData(field);
				}
				else if (field.IsUnbound)
				{
					result = ((global::Infragistics.Windows.DataPresenter.UnboundCell)this.Cells[field]).ValueInternal;
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = this.PropertyDescriptorProvider;
					global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor = null;
					if (propertyDescriptorProvider != null)
					{
						fieldDescriptor = propertyDescriptorProvider.GetFieldDescriptor(field);
					}
					if (fieldDescriptor != null)
					{
						result = fieldDescriptor.PropertyDescriptor.GetValue(this.DataItem);
					}
					else
					{
						result = null;
					}
				}
			}
			catch (global::System.Exception ex)
			{
				base.DataPresenter.RaiseDataError(this, field, ex, global::Infragistics.Windows.DataPresenter.DataErrorOperation.CellValueGet, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DataError_GetCellValue"), true);
				if (global::System.Diagnostics.Debugger.IsAttached && global::System.Diagnostics.Debugger.IsLogging())
				{
					string errorMsg;
					if (this.DataItem == null)
					{
						errorMsg = string.Format("GetCellValue failed because DataItem was null, can not bind to a list that contains null items, item index: {0}{1}", base.Index, global::System.Environment.NewLine);
					}
					else
					{
						errorMsg = string.Format("GetCellValue failed, exception type: {0}, exception msg: {1}, item index: {2}, DataItem: {3}{4}", new object[]
						{
							ex.GetType(),
							ex.Message,
							base.Index,
							this.DataItem,
							global::System.Environment.NewLine
						});
					}
					global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(errorMsg);
				}
				result = null;
			}
			return result;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0004F3D4 File Offset: 0x0004D5D4
		public virtual object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValueType cellValueType)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("Field");
			}
			if (field.Owner != base.FieldLayout)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_28"));
			}
			switch (cellValueType)
			{
			case global::Infragistics.Windows.DataPresenter.CellValueType.Raw:
				return this.GetCellValue(field, false);
			case global::Infragistics.Windows.DataPresenter.CellValueType.Converted:
				return this.GetCellValue(field, true);
			case global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType:
			{
				global::System.Type editAsTypeResolvedUnderlying = field.EditAsTypeResolvedUnderlying;
				object cellValue = this.GetCellValue(field, true);
				if (editAsTypeResolvedUnderlying == field.DataTypeUnderlying)
				{
					return cellValue;
				}
				return global::Infragistics.CoreUtilities.ConvertDataValue(cellValue, editAsTypeResolvedUnderlying, field.ConverterCultureResolved, null);
			}
			default:
				throw new global::System.ArgumentOutOfRangeException("cellValueType");
			}
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0004F470 File Offset: 0x0004D670
		public object GetCellDataError(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field.SupportDataErrorInfoResolved)
			{
				if (!field.IsUnbound)
				{
					global::System.ComponentModel.IDataErrorInfo dataErrorInfo = this.GetDataErrorInfo();
					if (dataErrorInfo != null)
					{
						return dataErrorInfo[field.Name];
					}
				}
				else if (this.IsDataRecord)
				{
					global::Infragistics.Windows.DataPresenter.UnboundCell unboundCell = this.Cells[field] as global::Infragistics.Windows.DataPresenter.UnboundCell;
					if (unboundCell != null)
					{
						return unboundCell.DataErrorInternal;
					}
				}
			}
			return null;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0004F4CC File Offset: 0x0004D6CC
		public bool GetCellHasDataError(global::Infragistics.Windows.DataPresenter.Field field)
		{
			object cellDataError = this.GetCellDataError(field);
			return !global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(cellDataError);
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0004F4EC File Offset: 0x0004D6EC
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> GetDataValueHistory(string fieldName)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				throw new global::System.ArgumentNullException("fieldName");
			}
			if (base.FieldLayout == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.FieldLayout.Fields[fieldName];
			if (field != null)
			{
				return this.GetDataValueHistory(field);
			}
			return null;
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0004F534 File Offset: 0x0004D734
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo> GetDataValueHistory(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("field");
			}
			global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
			if (cellIfAllocated != null && field.DataValueChangedNotificationsActiveResolved)
			{
				return cellIfAllocated.DataValueInfoHistoryCache;
			}
			return null;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0004F56C File Offset: 0x0004D76C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public object GetExportValue(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.CellTextConverterInfo cachedConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
			if (cachedConverter != null && cachedConverter.ShouldExportText)
			{
				return cachedConverter.ConvertCellValue(this);
			}
			return this.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0004F59B File Offset: 0x0004D79B
		public void RefreshCellValue(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field, "field");
			if (field.Owner == null || field.Owner != base.FieldLayout)
			{
				return;
			}
			this.RefreshCellValue(field, false, false);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0004F5C8 File Offset: 0x0004D7C8
		public void RefreshFilters()
		{
			this.ApplyFiltersHelper();
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0004F5D0 File Offset: 0x0004D7D0
		public void ResetDataValueHistory(bool recursive)
		{
			if (base.FieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = base.FieldLayout.Fields;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
			{
				this.ResetDataValueHistory(field);
			}
			if (recursive && this.ChildRecords != null)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection childRecords = this.ChildRecords;
				foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord in childRecords)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfAllocated = expandableFieldRecord.ChildRecordManagerIfAllocated;
					if (childRecordManagerIfAllocated != null)
					{
						childRecordManagerIfAllocated.ResetDataValueHistory(recursive);
					}
				}
			}
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0004F690 File Offset: 0x0004D890
		public void ResetDataValueHistory(string fieldName)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				throw new global::System.ArgumentNullException("fieldName");
			}
			if (base.FieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Field field = base.FieldLayout.Fields[fieldName];
			if (field != null)
			{
				this.ResetDataValueHistory(field);
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0004F6D8 File Offset: 0x0004D8D8
		public void ResetDataValueHistory(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("field");
			}
			global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
			if (cellIfAllocated != null)
			{
				cellIfAllocated.ClearDataValueChangedHistory(!field.DataValueChangedNotificationsActiveResolved);
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0004F70D File Offset: 0x0004D90D
		public void SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value)
		{
			this.SetCellValue(field, value, false);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0004F719 File Offset: 0x0004D919
		public bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter)
		{
			return this.SetCellValue(field, value, useConverter, false);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0004F725 File Offset: 0x0004D925
		public bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, bool addToUndo)
		{
			return this.SetCellValue(field, value, useConverter, addToUndo, false, global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing, false);
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0004F73C File Offset: 0x0004D93C
		internal bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, bool addToUndo, bool suppressErrorDialog, object undoValue, bool isCommittingEdit)
		{
			return this.SetCellValue(field, value, useConverter, addToUndo, suppressErrorDialog, undoValue, isCommittingEdit, false);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0004F75C File Offset: 0x0004D95C
		internal bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, bool addToUndo, bool suppressErrorDialog, object undoValue, bool isCommittingEdit, bool dontSetDataChanged)
		{
			if (addToUndo)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				if (dataPresenter != null && dataPresenter.IsUndoEnabled)
				{
					global::Infragistics.Windows.DataPresenter.SingleCellValueAction action = new global::Infragistics.Windows.DataPresenter.SingleCellValueAction(value, useConverter, this, field, undoValue, isCommittingEdit);
					return dataPresenter.History.PerformAction(action, null);
				}
			}
			global::Infragistics.Windows.DataPresenter.DataErrorInfo dataErrorInfo;
			bool result = this.SetCellValue(field, value, useConverter, out dataErrorInfo, dontSetDataChanged);
			if (dataErrorInfo != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter2 = base.DataPresenter;
				if (dataPresenter2 != null)
				{
					dataPresenter2.RaiseDataError(dataErrorInfo, suppressErrorDialog);
				}
			}
			return result;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0004F7C3 File Offset: 0x0004D9C3
		internal bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo)
		{
			return this.SetCellValue(field, value, useConverter, out errorInfo, false);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0004F7D4 File Offset: 0x0004D9D4
		internal virtual bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo, bool dontSetDataChanged)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("Field");
			}
			if (field.Owner != base.FieldLayout)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_28"));
			}
			errorInfo = null;
			object obj;
			if (useConverter && field.Converter != null)
			{
				obj = field.Converter.ConvertBack(value, field.DataType, field.GetConverterParameterResolved(this), field.ConverterCultureResolved);
			}
			else
			{
				obj = global::Infragistics.CoreUtilities.ConvertDataValue(value, field.DataType, field.ConverterCultureResolved, null);
			}
			object cellValue = this.GetCellValue(field, false);
			if (object.Equals(obj, cellValue))
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = this.GetCellIfAllocated(field);
			object oldValue = cellValue;
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = field.Owner.DataPresenter;
			bool result;
			try
			{
				if (this.DataItem != null)
				{
					global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs cellUpdatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.CellUpdatingEventArgs(this, field);
					dataPresenter.RaiseCellUpdating(cellUpdatingEventArgs);
					if (cellUpdatingEventArgs.Cancel)
					{
						return false;
					}
				}
				this.IgnoreChangeNotificationsForField = field;
				if (this.IsAddRecordTemplate)
				{
					base.ParentCollection.ParentRecordManager.SetAddRecordCellData(field, obj);
				}
				else
				{
					if (!dataPresenter.SuspendInitializeRecordFor(this))
					{
						flag = true;
					}
					if (field.IsUnbound)
					{
						if (cell == null)
						{
							cell = this.Cells[field];
						}
						((global::Infragistics.Windows.DataPresenter.UnboundCell)cell).ValueInternal = obj;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor = this.PropertyDescriptorProvider.GetFieldDescriptor(field);
						if (fieldDescriptor == null)
						{
							return false;
						}
						this.BeginEdit();
						global::System.ComponentModel.PropertyDescriptor propertyDescriptor = fieldDescriptor.PropertyDescriptor;
						if (propertyDescriptor is global::Infragistics.Windows.Internal.ValuePropertyDescriptor)
						{
							global::System.Collections.IList list = base.ParentCollection.ParentRecordManager.List;
							if (list == null || list.IsReadOnly)
							{
								if (list != null && list.IsReadOnly)
								{
									errorInfo = new global::Infragistics.Windows.DataPresenter.DataErrorInfo(this, field, null, global::Infragistics.Windows.DataPresenter.DataErrorOperation.CellValueSet, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ValueProperty_ListIsReadOnly"));
								}
								return false;
							}
							int dataItemIndex = this.DataItemIndex;
							if (dataItemIndex < 0 || dataItemIndex >= list.Count)
							{
								errorInfo = new global::Infragistics.Windows.DataPresenter.DataErrorInfo(this, field, null, global::Infragistics.Windows.DataPresenter.DataErrorOperation.CellValueSet, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ValueProperty_InvalidIndex"));
								return false;
							}
							list[dataItemIndex] = obj;
							this.RefreshDataItem();
						}
						else
						{
							propertyDescriptor.SetValue(this.DataItem, obj);
						}
						if (!dontSetDataChanged)
						{
							if (cell != null)
							{
								cell.InternalSetDataChanged(true);
							}
							else
							{
								this.InternalSetDataChanged(true);
							}
						}
					}
				}
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
				if (recordManager != null)
				{
					recordManager.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.CellDataChange, this, field);
				}
				if (cell != null)
				{
					cell.RaiseAutomationValueChanged(oldValue, cell.ConvertedValue);
					if (!cell.IsUnbound)
					{
						cell.RaiseValueChangedNotifications();
					}
				}
				global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this, field);
				if (cellValuePresenter != null)
				{
					cellValuePresenter.SetValueInternal(this.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType), false);
				}
				this.RefreshDataErrorInfo(field, false, new bool?(true));
				if (this.DataItem != null)
				{
					dataPresenter.RaiseCellUpdated(new global::Infragistics.Windows.DataPresenter.Events.CellUpdatedEventArgs(this, field));
				}
				result = true;
			}
			catch (global::System.Exception exception)
			{
				this.IgnoreChangeNotificationsForField = null;
				if (flag)
				{
					dataPresenter.ResumeInitializeRecordFor(this);
					flag = false;
				}
				errorInfo = new global::Infragistics.Windows.DataPresenter.DataErrorInfo(this, field, exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation.CellValueSet, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DataError_UpdateCellValue"));
				result = false;
			}
			finally
			{
				this.IgnoreChangeNotificationsForField = null;
				if (flag)
				{
					dataPresenter.ResumeInitializeRecordFor(this);
					base.FireInitializeRecord(true, field.SortStatus != global::Infragistics.Windows.Controls.SortStatus.NotSorted);
				}
			}
			return result;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0004FB0C File Offset: 0x0004DD0C
		public bool Update()
		{
			global::Infragistics.Windows.DataPresenter.DataErrorInfo dataErrorInfo;
			bool result = this.Update(out dataErrorInfo);
			if (dataErrorInfo != null)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				if (dataPresenter != null)
				{
					dataPresenter.RaiseDataError(dataErrorInfo);
				}
			}
			return result;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0004FB38 File Offset: 0x0004DD38
		internal virtual bool Update(out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo)
		{
			errorInfo = null;
			if (!this.IsDataChanged)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs recordUpdatingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordUpdatingEventArgs(this);
			base.DataPresenter.RaiseRecordUpdating(recordUpdatingEventArgs);
			switch (recordUpdatingEventArgs.Action)
			{
			case global::Infragistics.Windows.DataPresenter.RecordUpdatingAction.CancelUpdateRetainChanges:
				return false;
			case global::Infragistics.Windows.DataPresenter.RecordUpdatingAction.CancelUpdateDiscardChanges:
				this.CancelUpdate();
				return false;
			default:
			{
				bool flag = this.CommitChanges(out errorInfo);
				if (flag)
				{
					base.DataPresenter.RaiseRecordUpdated(new global::Infragistics.Windows.DataPresenter.Events.RecordUpdatedEventArgs(this));
				}
				return flag;
			}
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0004FBA8 File Offset: 0x0004DDA8
		internal void ApplyFiltersHelper()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
			this.ApplyFiltersHelper((recordManager != null) ? recordManager.RecordFiltersResolved : null, true);
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0004FBD0 File Offset: 0x0004DDD0
		internal void ApplyFiltersHelper(global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection filters, bool raiseNotifications)
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState && !this.IsAddRecord)
			{
				if (this.IsAddRecordTemplate)
				{
					return;
				}
				if (this.IsDataRecord)
				{
					bool? flag = (filters != null) ? filters.MeetsCriteria(this) : null;
					global::Infragistics.Windows.DataPresenter.Record.FilterState newState = (flag == null) ? (~(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn | global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended)) : (flag.Value ? global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn : global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut);
					base.InternalSetFilterState(newState, raiseNotifications);
					return;
				}
				this._cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter;
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0004FC40 File Offset: 0x0004DE40
		internal void BeginEdit()
		{
			object dataItem = this.DataItem;
			if (dataItem != null)
			{
				global::Infragistics.Windows.EditableCollectionViewProxy editableCollectionView = base.ParentCollection.ParentRecordManager.EditableCollectionView;
				if (editableCollectionView != null)
				{
					editableCollectionView.EditItem(dataItem);
				}
				else
				{
					global::System.ComponentModel.IEditableObject editableObject = dataItem as global::System.ComponentModel.IEditableObject;
					if (editableObject != null)
					{
						editableObject.BeginEdit();
					}
				}
			}
			this._beginEditCalled = true;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0004FC8C File Offset: 0x0004DE8C
		internal void CancelEdit()
		{
			bool isActive = base.IsActive;
			if (isActive)
			{
				global::Infragistics.Windows.DataPresenter.Cell activeCell = base.DataPresenter.ActiveCell;
				if (activeCell != null && activeCell.IsInEditMode)
				{
					activeCell.EndEditMode(false, true);
				}
			}
			object dataItem = this._dataItem;
			bool flag = this._isAddRecord && this._dataItem != null;
			global::System.ComponentModel.IEditableObject editableObject = this.DataItem as global::System.ComponentModel.IEditableObject;
			int dataItemIndex = this.DataItemIndex;
			if (flag)
			{
				this.SetDataItemHelper(null);
			}
			global::Infragistics.Windows.EditableCollectionViewProxy editableCollectionView = base.ParentCollection.ParentRecordManager.EditableCollectionView;
			if (editableCollectionView != null)
			{
				if (editableCollectionView.IsAddingNew && editableCollectionView.CurrentAddItem == dataItem)
				{
					editableCollectionView.CancelNew();
				}
				else if (editableCollectionView.CanCancelEdit && editableCollectionView.IsEditingItem && editableCollectionView.CurrentEditItem == dataItem)
				{
					editableCollectionView.CancelEdit();
				}
			}
			else
			{
				bool flag2 = false;
				if (flag)
				{
					global::System.Collections.IList list = base.ParentCollection.ParentRecordManager.List;
					global::System.ComponentModel.ICancelAddNew cancelAddNew = list as global::System.ComponentModel.ICancelAddNew;
					if (cancelAddNew != null)
					{
						int num = dataItemIndex;
						if (num >= 0 && num < list.Count)
						{
							cancelAddNew.CancelNew(num);
							flag2 = true;
						}
					}
				}
				if (!flag2 && editableObject != null && this._beginEditCalled)
				{
					editableObject.CancelEdit();
				}
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
			if (flag && dataItem != null && (editableObject == null || base.ParentCollection.SparseArray.Contains(this)))
			{
				global::System.Collections.IList list2 = base.ParentCollection.ParentRecordManager.List;
				if (list2 != null)
				{
					list2.Remove(dataItem);
					if (recordManager != null)
					{
						recordManager.OnDataItemRemoved(this, dataItem);
					}
				}
			}
			if (flag && recordManager != null)
			{
				recordManager.PrepareForNewCurrentAddRecord();
			}
			this._beginEditCalled = false;
			this.InternalSetDataChanged(false);
			this.RefreshCellValues(false, false, false);
			if (flag)
			{
				base.DirtyScrollCount();
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				if (flag && isActive && recordManager != null && (dataPresenter.ActiveRecordInternal == null || dataPresenter.ActiveRecordInternal == this))
				{
					global::Infragistics.Windows.DataPresenter.DataRecord currentAddRecordInternal = recordManager.CurrentAddRecordInternal;
					if (currentAddRecordInternal != null)
					{
						currentAddRecordInternal.IsActive = true;
					}
				}
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0004FE70 File Offset: 0x0004E070
		internal void CoerceNullEditValue(global::Infragistics.Windows.DataPresenter.Field field, ref object editedValue)
		{
			if (editedValue == null || global::System.DBNull.Value == editedValue)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = this.GetPropertyDescriptor(field);
				object obj;
				if (propertyDescriptor != null && global::Infragistics.Windows.Internal.DataBindingUtilities.GetDataSourceNullValue(propertyDescriptor, out obj))
				{
					editedValue = obj;
					return;
				}
				if (global::System.DBNull.Value == editedValue)
				{
					bool flag = field.DataType != field.DataTypeUnderlying;
					if (flag)
					{
						editedValue = null;
					}
				}
			}
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0004FEC4 File Offset: 0x0004E0C4
		internal bool CommitChanges(out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo)
		{
			errorInfo = null;
			try
			{
				if (!base.ParentCollection.ParentRecordManager.CommitRecord(this))
				{
					return false;
				}
			}
			catch (global::System.Exception exception)
			{
				errorInfo = new global::Infragistics.Windows.DataPresenter.DataErrorInfo(this, null, exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation.RecordUpdate, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DataError_UpdateRecord"));
				return false;
			}
			this._beginEditCalled = false;
			bool flag = this._isAddRecord && this._dataItem != null;
			if (flag)
			{
				this._isAddRecord = false;
				base.ParentCollection.ParentRecordManager.PrepareForNewCurrentAddRecord();
				if (this.HasExpandableFieldRecords)
				{
					foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord in this.ChildRecords)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
						if (childRecordManagerIfNeeded != null && childRecordManagerIfNeeded.DataSource == null)
						{
							childRecordManagerIfNeeded.DataSource = (this.GetCellValue(expandableFieldRecord.Field, true) as global::System.Collections.IEnumerable);
						}
					}
				}
				base.ParentCollection.ViewableRecords.RecordCollectionSparseArray.NotifyItemScrollCountChanged(this);
				base.DirtyScrollCount();
				base.RaisePropertyChangedEvent("IsAddRecord");
				base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
				base.RaisePropertyChangedEvent("IsSpecialRecord");
			}
			this.InternalSetDataChanged(false);
			base.ParentCollection.ParentRecordManager.SetCurrentItemFromActiveRecord();
			if (this._isAddRecord && this._dataItem == null)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			if (dataPresenter != null)
			{
				dataPresenter.ProcessRecordWithPendingFilterHelper(this);
				if (flag)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(dataPresenter, this, "IsAddRecord", null);
				}
			}
			return true;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x00050058 File Offset: 0x0004E258
		internal virtual global::Infragistics.Windows.DataPresenter.CellCollection CreateCellCollection()
		{
			return new global::Infragistics.Windows.DataPresenter.CellCollection(this);
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x00050060 File Offset: 0x0004E260
		internal void DeleteHelper()
		{
			if (base.ParentCollection == null)
			{
				return;
			}
			base.ParentCollection.ParentRecordManager.DeleteRecord(this);
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0005007C File Offset: 0x0004E27C
		internal virtual global::Infragistics.Windows.DataPresenter.CellClickAction GetCellClickActionResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field.CellClickActionResolved;
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00050084 File Offset: 0x0004E284
		internal virtual global::System.Type GetEditAsTypeResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
			if (cellIfAllocated != null)
			{
				return cellIfAllocated.EditAsTypeResolved;
			}
			return field.EditAsTypeResolved;
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x000500B0 File Offset: 0x0004E2B0
		internal virtual global::System.Type GetEditorTypeResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
			if (cellIfAllocated != null)
			{
				return cellIfAllocated.EditorTypeResolved;
			}
			return field.EditorTypeResolved;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x000500DC File Offset: 0x0004E2DC
		internal global::Infragistics.Windows.DataPresenter.Field GetFieldForPropertyDescriptor(string propertyDescriptorName)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(fieldLayout);
			if (fields == null)
			{
				return null;
			}
			int num = fields.IndexOf(propertyDescriptorName);
			if (num >= 0)
			{
				return fields[num];
			}
			return global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider.GetUnboundFieldWithPropertyDescriptor(this, propertyDescriptorName);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00050118 File Offset: 0x0004E318
		internal virtual bool GetIsEditingAllowed(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return false;
			}
			if (!field.AllowEditResolved)
			{
				return false;
			}
			global::System.Type editorTypeResolved = this.GetEditorTypeResolved(field);
			if (null == editorTypeResolved)
			{
				return false;
			}
			if (!base.IsEnabledResolved)
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = this.PropertyDescriptorProvider;
			if (propertyDescriptorProvider != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor = propertyDescriptorProvider.GetFieldDescriptor(field);
				if (fieldDescriptor != null)
				{
					global::System.ComponentModel.PropertyDescriptor propertyDescriptor = fieldDescriptor.PropertyDescriptor;
					if (propertyDescriptor != null)
					{
						if (propertyDescriptor is global::Infragistics.Windows.Internal.ValuePropertyDescriptor)
						{
							global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = base.ParentCollection.ParentRecordManager;
							if (this.IsAddRecordTemplate || this.IsAddRecord)
							{
								if (!parentRecordManager.DataSourceAllowsAddNew)
								{
									return false;
								}
							}
							else if (!parentRecordManager.DataSourceAllowsEdit)
							{
								return false;
							}
						}
						else if (propertyDescriptor.IsReadOnly)
						{
							return false;
						}
					}
					global::System.Data.DataColumn dataColumn = fieldDescriptor.DataColumn;
					if (dataColumn != null && dataColumn.Expression != null && dataColumn.Expression.Length > 0)
					{
						return false;
					}
				}
			}
			return this.IsAddRecord || base.ParentCollection.ParentRecordManager.DataSourceAllowsEdit;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x000501FA File Offset: 0x0004E3FA
		internal static object GetObjectForRecordComparision(object listObject)
		{
			return global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(listObject);
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00050204 File Offset: 0x0004E404
		internal global::System.ComponentModel.PropertyDescriptor GetPropertyDescriptor(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = this.PropertyDescriptorProvider;
			if (propertyDescriptorProvider != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor = propertyDescriptorProvider.GetFieldDescriptor(field);
				if (fieldDescriptor != null)
				{
					return fieldDescriptor.PropertyDescriptor;
				}
			}
			return null;
		}

		// Token: 0x0600129B RID: 4763 RVA: 0x0005022E File Offset: 0x0004E42E
		internal void InitializeDataItem(object dataItem, int dataItemIndex)
		{
			this._dataItemIndex = dataItemIndex;
			this.SetDataItemHelper(dataItem);
		}

		// Token: 0x0600129C RID: 4764 RVA: 0x00050240 File Offset: 0x0004E440
		internal void InternalSetDataChanged(bool value)
		{
			if (this._isDataChangedSinceLastCommitAttempt != value)
			{
				this._isDataChangedSinceLastCommitAttempt = value;
			}
			if (this._isDataChanged != value)
			{
				this._isDataChanged = value;
				if (!value && this._cells != null)
				{
					int count = this._cells.Count;
					for (int i = 0; i < count; i++)
					{
						global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this._cells.GetCellIfAllocated(i);
						if (cellIfAllocated != null)
						{
							cellIfAllocated.InternalSetDataChanged(false);
						}
					}
				}
				base.RaisePropertyChangedEvent("IsDataChanged");
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000502B2 File Offset: 0x0004E4B2
		internal void InternalSetIsDeleted()
		{
			this._isDeleted = true;
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000502BB File Offset: 0x0004E4BB
		// (set) Token: 0x0600129F RID: 4767 RVA: 0x000502C3 File Offset: 0x0004E4C3
		internal bool IsDataChangedSinceLastCommitAttempt
		{
			get
			{
				return this._isDataChangedSinceLastCommitAttempt;
			}
			set
			{
				this._isDataChangedSinceLastCommitAttempt = value;
			}
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x000502CC File Offset: 0x0004E4CC
		internal bool IsDataItemEqual(object dataItem)
		{
			return this.DataItemForComparison == global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(dataItem);
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x000502DC File Offset: 0x0004E4DC
		internal bool IsFirstDisplayedCell(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return cell != null && this._cells != null && cell.Record == this && cell.Field == this.FirstDisplayedField;
		}

		// Token: 0x060012A2 RID: 4770 RVA: 0x00050302 File Offset: 0x0004E502
		internal bool IsLastDisplayedCell(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return cell != null && this._cells != null && cell.Record == this && cell.Field == this.LastDisplayedField;
		}

		// Token: 0x060012A3 RID: 4771 RVA: 0x00050328 File Offset: 0x0004E528
		internal bool OnEditValueChanged(bool addToUndo)
		{
			return this.OnEditValueChanged(addToUndo, 0);
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00050334 File Offset: 0x0004E534
		internal bool OnEditValueChanged(bool addToUndo, int recordOnTopOffset)
		{
			if (!this._isDataChanged)
			{
				if (!global::Infragistics.Windows.DataPresenter.GridUtilities.Antirecursion.Enter(this, "OnEditValueChanged", true))
				{
					return false;
				}
				try
				{
					bool flag = false;
					if (this.IsAddRecord && this._dataItem == null)
					{
						global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs recordAddingEventArgs = new global::Infragistics.Windows.DataPresenter.Events.RecordAddingEventArgs(this);
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
						dataPresenter.RaiseRecordAdding(recordAddingEventArgs);
						if (recordAddingEventArgs.Cancel)
						{
							global::Infragistics.Windows.DataPresenter.Cell activeCell = dataPresenter.ActiveCell;
							if (activeCell != null && activeCell.Record == this && activeCell.IsInEditMode)
							{
								activeCell.EndEditMode(false, true);
							}
							return false;
						}
						global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = base.ParentCollection.ParentRecordManager;
						bool flag2 = dataPresenter.SuspendInitializeRecordFor(this);
						try
						{
							this.SetDataItemHelper(parentRecordManager.AddNew(recordOnTopOffset));
							parentRecordManager.InitializeAddRecordCellValuesFromCache(this);
							if (addToUndo && dataPresenter.IsUndoEnabled)
							{
								dataPresenter.History.AddUndoActionInternal(new global::Infragistics.Windows.DataPresenter.DeleteRecordsAction(dataPresenter, new global::Infragistics.Windows.DataPresenter.Record[]
								{
									this
								}, false));
							}
							this.RefreshCellValues(true, false);
							this._underlyingDataVersion = parentRecordManager.UnderlyingDataVersion;
						}
						finally
						{
							if (!flag2)
							{
								dataPresenter.ResumeInitializeRecordFor(this);
								base.FireInitializeRecord(false, false);
							}
						}
						flag = true;
					}
					this.InternalSetDataChanged(true);
					if (flag)
					{
						base.DirtyScrollCount();
						base.DataPresenter.RaiseRecordAdded(new global::Infragistics.Windows.DataPresenter.Events.RecordAddedEventArgs(this));
					}
				}
				finally
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.Antirecursion.Exit(this, "OnEditValueChanged");
				}
				return true;
			}
			return true;
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x000504B4 File Offset: 0x0004E6B4
		internal void OnIsNestedDataDisplayEnabledChanged()
		{
			if (this.IsExpanded && !base.DataPresenter.IsNestedDataDisplayEnabled)
			{
				this.IsExpanded = false;
			}
			base.DirtyScrollCount();
			base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
			base.RaisePropertyChangedEvent("IsExpanded");
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x000504F0 File Offset: 0x0004E6F0
		internal void ProcessPendingChanges(bool discardChanges, bool recursive)
		{
			if (this._beginEditCalled || (this._isAddRecord && this._dataItem != null))
			{
				if (discardChanges)
				{
					this.CancelUpdate();
				}
				else
				{
					this.Update();
				}
			}
			if (!recursive || !this.HasExpandableFieldRecords)
			{
				return;
			}
			foreach (object obj in this.ChildRecords.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)obj;
				global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = expandableFieldRecord.ChildRecordManagerIfNeeded;
				if (childRecordManagerIfNeeded != null)
				{
					childRecordManagerIfNeeded.UpdateRecordsWithPendingChanges(discardChanges, true);
				}
			}
		}

		// Token: 0x060012A7 RID: 4775 RVA: 0x00050598 File Offset: 0x0004E798
		internal void RefreshCellValue(string propertyDescriptorName, bool raiseInitializeRecord, bool isRecordPresenterDeactivated)
		{
			global::Infragistics.Windows.DataPresenter.Field fieldForPropertyDescriptor = this.GetFieldForPropertyDescriptor(propertyDescriptorName);
			if (fieldForPropertyDescriptor == null)
			{
				return;
			}
			this.RefreshCellValue(fieldForPropertyDescriptor, raiseInitializeRecord, isRecordPresenterDeactivated);
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x000505BC File Offset: 0x0004E7BC
		internal void RefreshCellValue(global::Infragistics.Windows.DataPresenter.Field field, bool raiseInitializeRecord, bool isRecordPresenterDeactivated)
		{
			if (base.FieldLayout == null)
			{
				return;
			}
			if (field.IsUnbound)
			{
				global::Infragistics.Windows.DataPresenter.UnboundCell unboundCell = this.GetCellIfAllocated(field) as global::Infragistics.Windows.DataPresenter.UnboundCell;
				if (unboundCell != null)
				{
					unboundCell.RefreshCellValue();
				}
			}
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
			if (recordManager != null)
			{
				recordManager.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.CellDataChange, this, field);
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this, field);
			object obj = null;
			if (cellValuePresenter != null)
			{
				obj = this.GetCellValue(field, global::Infragistics.Windows.DataPresenter.CellValueType.EditAsType);
				if (isRecordPresenterDeactivated)
				{
					cellValuePresenter.MarkValueDirty();
				}
				else
				{
					cellValuePresenter.SetValueInternal(obj, false);
				}
			}
			if (field != this._ignoreChangeNotificationsForField)
			{
				this.RefreshCellValueHelper(field, obj);
				this.RefreshDataErrorInfo(field, false, new bool?(true));
			}
			if (raiseInitializeRecord)
			{
				base.FireInitializeRecord(true, field.SortStatus != global::Infragistics.Windows.Controls.SortStatus.NotSorted);
			}
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x00050668 File Offset: 0x0004E868
		internal void RefreshCellValueHelper(global::Infragistics.Windows.DataPresenter.Field field, object cellValue)
		{
			if (field.IsExpandableByDefault && field.IsExpandableResolved)
			{
				if (this.ChildRecordsIfAllocated == null)
				{
					this.OnEnumerableCellDataChanged();
					return;
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection childRecords = this.ChildRecords;
				int num = childRecords.IndexOf(field);
				if (num >= 0)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = childRecords[num];
					global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfAllocated = expandableFieldRecord.ChildRecordManagerIfAllocated;
					if (childRecordManagerIfAllocated != null)
					{
						if (cellValue == null)
						{
							cellValue = this.GetCellValue(expandableFieldRecord.Field, true);
						}
						childRecordManagerIfAllocated.DataSource = (cellValue as global::System.Collections.IEnumerable);
						return;
					}
					expandableFieldRecord.OnDataChanged();
					return;
				}
			}
			else
			{
				if (!field.IsUnbound)
				{
					global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
					if (cellIfAllocated != null)
					{
						cellIfAllocated.RaiseValueChangedNotifications();
					}
				}
				this.DataValueChangedHelper(field);
			}
		}

		// Token: 0x060012AA RID: 4778 RVA: 0x00050702 File Offset: 0x0004E902
		internal void RefreshCellValues(bool excludeUnboundFields, bool raiseInitializeRecord)
		{
			this.RefreshCellValues(excludeUnboundFields, raiseInitializeRecord, true);
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x00050710 File Offset: 0x0004E910
		internal void RefreshCellValues(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> fields, bool raiseInitializeRecord)
		{
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = base.AssociatedRecordPresenter;
			bool isRecordPresenterDeactivated = associatedRecordPresenter != null && associatedRecordPresenter.IsDeactivated;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
			{
				flag = (flag || field.SortStatus != global::Infragistics.Windows.Controls.SortStatus.NotSorted);
				this.RefreshCellValue(field, false, isRecordPresenterDeactivated);
			}
			if (raiseInitializeRecord)
			{
				base.FireInitializeRecord(true, flag);
			}
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00050798 File Offset: 0x0004E998
		internal void RefreshCellValues(bool excludeUnboundFields, bool raiseInitializeRecord, bool reinitializeExpandableFields)
		{
			this.RefreshCellValues(excludeUnboundFields, raiseInitializeRecord, reinitializeExpandableFields, false);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x000507A4 File Offset: 0x0004E9A4
		internal void RefreshCellValues(bool excludeUnboundFields, bool raiseInitializeRecord, bool reinitializeExpandableFields, bool fromDataSourceReset)
		{
			global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = base.AssociatedRecordPresenter;
			bool isRecordPresenterDeactivated = associatedRecordPresenter != null && associatedRecordPresenter.IsDeactivated;
			bool flag = associatedRecordPresenter != null;
			bool flag2 = false;
			bool flag3 = false;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			bool flag4 = dataPresenter != null && this != dataPresenter._recordWhoseChangesAreBeingDiscarded;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in base.FieldLayout.Fields)
			{
				if (field.VisibilityResolved != global::System.Windows.Visibility.Collapsed)
				{
					if (field.IsExpandableResolved)
					{
						if (field.IsExpandableByDefault)
						{
							flag2 = true;
						}
					}
					else
					{
						if (field is global::Infragistics.Windows.DataPresenter.UnboundField)
						{
							if (fromDataSourceReset || excludeUnboundFields)
							{
								global::Infragistics.Windows.DataPresenter.UnboundCell unboundCell = this.GetCellIfAllocated(field) as global::Infragistics.Windows.DataPresenter.UnboundCell;
								if (unboundCell != null)
								{
									unboundCell.RefreshBindings();
									global::Infragistics.Windows.DataPresenter.CellValuePresenter.SyncValueWithCellValue(this, field, isRecordPresenterDeactivated);
								}
							}
							if (excludeUnboundFields)
							{
								continue;
							}
						}
						if (field != this._ignoreChangeNotificationsForField)
						{
							global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
							if (cellIfAllocated != null)
							{
								cellIfAllocated.RaiseValueChangedNotifications();
							}
						}
						if (flag)
						{
							global::Infragistics.Windows.DataPresenter.CellValuePresenter.SyncValueWithCellValue(this, field, isRecordPresenterDeactivated);
						}
						if (flag4)
						{
							this.DataValueChangedHelper(field);
						}
						flag3 = (flag3 || field.SortStatus != global::Infragistics.Windows.Controls.SortStatus.NotSorted);
					}
				}
			}
			if (flag2 && reinitializeExpandableFields && this.ChildRecordsIfAllocated != null && base.DataPresenter.IsNestedDataDisplayEnabled)
			{
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord> enumerator2 = this.ChildRecords.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = enumerator2.Current;
						global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfAllocated = expandableFieldRecord.ChildRecordManagerIfAllocated;
						if (childRecordManagerIfAllocated != null)
						{
							switch (expandableFieldRecord.Field.NonSpecificNotificationBehaviorResolved)
							{
							case global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.BypassIfEnumerable:
								continue;
							case global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.BypassIfBindingList:
								if (childRecordManagerIfAllocated.BindingList != null)
								{
									continue;
								}
								break;
							case global::Infragistics.Windows.DataPresenter.NonSpecificNotificationBehavior.BypassIfObservable:
								if (childRecordManagerIfAllocated.IsObservable)
								{
									continue;
								}
								break;
							}
							childRecordManagerIfAllocated.DataSource = (this.GetCellValue(expandableFieldRecord.Field, true) as global::System.Collections.IEnumerable);
						}
						else
						{
							expandableFieldRecord.OnDataChanged();
						}
					}
					goto IL_1EE;
				}
			}
			this.OnEnumerableCellDataChanged();
			IL_1EE:
			this.RefreshDataErrorInfo(null, false);
			base.ClearSizeToContentManager(null);
			if (raiseInitializeRecord)
			{
				base.FireInitializeRecord(true, flag3);
			}
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000509D8 File Offset: 0x0004EBD8
		internal bool WasBeginEditCalled
		{
			get
			{
				return this._beginEditCalled;
			}
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000509E0 File Offset: 0x0004EBE0
		private void ClearChildDataCache(bool unwireEvents)
		{
			if (this._trackingInfos == null)
			{
				return;
			}
			if (unwireEvents)
			{
				foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo childDataTrackingInfo in this._trackingInfos)
				{
					childDataTrackingInfo.Unwire(this);
				}
			}
			this._trackingInfos = null;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00050A20 File Offset: 0x0004EC20
		private void DataValueChangedHelper(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (!field.DataValueChangedNotificationsActiveResolved)
			{
				return;
			}
			if (field.DataValueChangedScopeResolved == global::Infragistics.Windows.DataPresenter.DataValueChangedScope.OnlyRecordsInView && base.AssociatedRecordPresenter == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = this.Cells[field];
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
			cell.AddDataValueChangedHistoryEntryForCurrentValue();
			if (dataPresenter != null)
			{
				global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs args = new global::Infragistics.Windows.DataPresenter.Events.DataValueChangedEventArgs(this, field, cell.AssociatedCellValuePresenter, cell.DataValueInfoHistoryCache);
				dataPresenter.RaiseDataValueChanged(args);
			}
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x00050A80 File Offset: 0x0004EC80
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection GetChildRcdCollection(bool alwaysCreateIfEnumerable)
		{
			if (this._expandableFieldRecords == null)
			{
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = base.FieldLayout.Fields;
				int expandableFieldsCount = fields.ExpandableFieldsCount;
				if (expandableFieldsCount < 1 && !alwaysCreateIfEnumerable)
				{
					return null;
				}
				bool flag = false;
				bool flag2 = alwaysCreateIfEnumerable;
				if (!alwaysCreateIfEnumerable && !(this._dataItem is global::System.Data.DataRowVersion))
				{
					if (this._trackingInfos != null)
					{
						if (this._trackingInfos.Length == expandableFieldsCount)
						{
							return null;
						}
						this.ClearChildDataCache(true);
					}
					if (this._trackingInfos == null)
					{
						this._trackingInfos = new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo[expandableFieldsCount];
						int num = 0;
						int count = base.FieldLayout.Fields.Count;
						for (int i = 0; i < count; i++)
						{
							if (fields[i].IsExpandableResolved)
							{
								global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo childDataTrackingInfo = new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo(this.GetCellValue(fields[i], true) as global::System.Collections.IEnumerable);
								if (childDataTrackingInfo._childData != null)
								{
									flag = true;
									flag2 = (childDataTrackingInfo.Initialize(base.DataPresenter, alwaysCreateIfEnumerable) || flag2);
								}
								this._trackingInfos[num] = childDataTrackingInfo;
								num++;
								if (num == expandableFieldsCount)
								{
									break;
								}
							}
						}
					}
				}
				if (flag2)
				{
					this._expandableFieldRecords = new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection(this, base.ParentCollection.ParentRecordManager, base.FieldLayout);
					this.ClearChildDataCache(!flag);
				}
				else if (flag)
				{
					foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo childDataTrackingInfo2 in this._trackingInfos)
					{
						childDataTrackingInfo2.Wire(this);
					}
				}
				if (this._expandableFieldRecords != null)
				{
					this._expandableFieldRecords.VerifyChildren();
				}
			}
			return this._expandableFieldRecords;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x00050BF9 File Offset: 0x0004EDF9
		private global::System.ComponentModel.IDataErrorInfo GetDataErrorInfo()
		{
			return this.DataItem as global::System.ComponentModel.IDataErrorInfo;
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x00050C08 File Offset: 0x0004EE08
		internal void OnEnumerableCellDataChanged()
		{
			if (this._trackingInfos != null)
			{
				this.ClearChildDataCache(true);
				if (this.IsExpanded)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = this.ViewableChildRecordsIfNeeded;
					if (viewableChildRecordsIfNeeded != null)
					{
						base.DirtyScrollCount();
					}
				}
			}
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x00050C3C File Offset: 0x0004EE3C
		internal void SetDataItemHelper(object dataItem)
		{
			if (this._dataItem is global::Infragistics.Windows.Helpers.EnumerableObjectWrapper)
			{
				if (((global::Infragistics.Windows.Helpers.EnumerableObjectWrapper)this._dataItem).Items == dataItem)
				{
					return;
				}
				if (dataItem is global::System.Collections.IEnumerable && !(dataItem is string))
				{
					dataItem = new global::Infragistics.Windows.Helpers.EnumerableObjectWrapper(dataItem as global::System.Collections.IEnumerable);
				}
			}
			if (this._dataItem != dataItem)
			{
				bool flag = this._dataItem != null;
				if (flag && this._isHookedToDataItemPropertyChangedEvent)
				{
					this._isHookedToDataItemPropertyChangedEvent = false;
					global::System.ComponentModel.PropertyChangedEventManager.RemoveListener((global::System.ComponentModel.INotifyPropertyChanged)this._dataItem, this, string.Empty);
				}
				this._dataItem = dataItem;
				this.VerifyDataItemNotifyChangeStatus();
				if (flag)
				{
					this.RefreshCellValues(false, false);
					base.RaisePropertyChangedEvent("DataItem");
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
					if (recordManager != null)
					{
						recordManager.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.RecordDataChange, this, null);
					}
					if (base.IsActive)
					{
						this._dataItemForComparison = global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(dataItem);
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
						if (dataPresenter != null)
						{
							dataPresenter.ActiveDataItem = dataItem;
						}
						return;
					}
				}
				else if (this.IsAddRecord)
				{
					base.RaisePropertyChangedEvent("DataItem");
				}
			}
			this._dataItemForComparison = global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(dataItem);
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x00050D44 File Offset: 0x0004EF44
		internal void RefreshDataErrorInfo(global::Infragistics.Windows.DataPresenter.Field field, bool excludeUnboundFields)
		{
			this.RefreshDataErrorInfo(field, excludeUnboundFields, null);
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x00050D64 File Offset: 0x0004EF64
		internal void RefreshDataErrorInfo(global::Infragistics.Windows.DataPresenter.Field field, bool excludeUnboundFields, bool? raiseRecordError)
		{
			if (field != null && (!excludeUnboundFields || !field.IsUnbound))
			{
				global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
				if (cellIfAllocated != null)
				{
					cellIfAllocated.RaiseDataErrorNotifications();
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this, field);
					if (cellValuePresenter != null)
					{
						cellValuePresenter.UpdateDataError();
					}
				}
			}
			if (raiseRecordError ?? (null == field))
			{
				if (base.HasListeners && this.IsRecordDataErrorInfoSupported)
				{
					base.RaisePropertyChangedEvent("DataError");
					base.RaisePropertyChangedEvent("HasDataError");
				}
				global::Infragistics.Windows.DataPresenter.DataRecordPresenter dataRecordPresenter = base.AssociatedRecordPresenter as global::Infragistics.Windows.DataPresenter.DataRecordPresenter;
				if (dataRecordPresenter != null)
				{
					if (this.IsRecordDataErrorInfoSupported)
					{
						dataRecordPresenter.UpdateDataError();
					}
					if (field == null)
					{
						global::Infragistics.Windows.DataPresenter.FieldCollection fields = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFields(base.FieldLayout);
						if (fields != null)
						{
							foreach (global::Infragistics.Windows.DataPresenter.Field field2 in fields)
							{
								if (field2 != null)
								{
									this.RefreshDataErrorInfo(field2, excludeUnboundFields);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060012B7 RID: 4791 RVA: 0x00050E60 File Offset: 0x0004F060
		internal void RefreshDataItem()
		{
			this._underlyingDataVersion--;
		}

		// Token: 0x060012B8 RID: 4792 RVA: 0x00050E70 File Offset: 0x0004F070
		private void VerifyDataItemNotifyChangeStatus()
		{
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
			global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = this._dataItem as global::System.ComponentModel.INotifyPropertyChanged;
			if (notifyPropertyChanged != null && fieldLayout != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = fieldLayout.Fields;
				if (fields.Count > fields.UnboundFieldsCount || global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider.HasUnboundFieldWithPropertyDescriptor(this))
				{
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = base.ParentCollection;
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (parentCollection == null) ? null : parentCollection.ParentRecordManager;
					if (recordManager != null && !recordManager.DataSourceRaisesCellValueChangeEvents)
					{
						flag = true;
					}
				}
			}
			if (flag == this._isHookedToDataItemPropertyChangedEvent)
			{
				return;
			}
			this._isHookedToDataItemPropertyChangedEvent = flag;
			if (flag)
			{
				global::System.ComponentModel.PropertyChangedEventManager.AddListener(notifyPropertyChanged, this, string.Empty);
				return;
			}
			global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(notifyPropertyChanged, this, string.Empty);
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x00050F0C File Offset: 0x0004F10C
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = base.ParentCollection;
					if (parentCollection != null)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager parentRecordManager = parentCollection.ParentRecordManager;
						if (parentRecordManager != null)
						{
							parentRecordManager.OnCellValueChangeNotification(this, propertyChangedEventArgs);
						}
					}
					return true;
				}
			}
			if (managerType == typeof(global::System.Collections.Specialized.CollectionChangedEventManager) || managerType == typeof(global::Infragistics.Windows.Helpers.BindingListChangedEventManager))
			{
				this.OnEnumerableCellDataChanged();
				return true;
			}
			return false;
		}

		// Token: 0x04000708 RID: 1800
		private global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider _propertyDescriptorProvider;

		// Token: 0x04000709 RID: 1801
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection _expandableFieldRecords;

		// Token: 0x0400070A RID: 1802
		private global::Infragistics.Windows.DataPresenter.CellCollection _cells;

		// Token: 0x0400070B RID: 1803
		private object _dataItem;

		// Token: 0x0400070C RID: 1804
		private object _dataItemForComparison;

		// Token: 0x0400070D RID: 1805
		private int _underlyingDataVersion;

		// Token: 0x0400070E RID: 1806
		private int _dataItemIndex;

		// Token: 0x0400070F RID: 1807
		private bool _isAddRecord;

		// Token: 0x04000710 RID: 1808
		private bool _isDataChanged;

		// Token: 0x04000711 RID: 1809
		private bool _isDataChangedSinceLastCommitAttempt;

		// Token: 0x04000712 RID: 1810
		private bool _isDeleted;

		// Token: 0x04000713 RID: 1811
		private bool _beginEditCalled;

		// Token: 0x04000714 RID: 1812
		private bool _isHookedToDataItemPropertyChangedEvent;

		// Token: 0x04000715 RID: 1813
		private global::Infragistics.Windows.DataPresenter.Field _ignoreChangeNotificationsForField;

		// Token: 0x04000716 RID: 1814
		private global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker _sortGroupVersionTracker;

		// Token: 0x04000717 RID: 1815
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo[] _trackingInfos;

		// Token: 0x04000718 RID: 1816
		internal static object UndoValueMissing = new object();
	}
}
