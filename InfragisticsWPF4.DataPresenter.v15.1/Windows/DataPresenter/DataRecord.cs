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
using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000165 RID: 357
	public class DataRecord : global::Infragistics.Windows.DataPresenter.Record, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060015AD RID: 5549 RVA: 0x0005FEB4 File Offset: 0x0005E0B4
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
			if (parentRecordManager != null)
			{
				parentRecordManager.OnDataRecordCreated(dataRecord2);
			}
			return dataRecord2;
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x000600AC File Offset: 0x0005E2AC
		internal static void CreateTemplateDataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, out global::Infragistics.Windows.DataPresenter.DataRecord createdTemplateRecord)
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase templateDataRecords = fieldLayout.DataPresenter.FieldLayouts.TemplateDataRecords;
			createdTemplateRecord = new global::Infragistics.Windows.DataPresenter.TemplateDataRecord(fieldLayout, templateDataRecords);
			createdTemplateRecord._cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter;
			templateDataRecords.AddRecord(createdTemplateRecord);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x000600E3 File Offset: 0x0005E2E3
		private DataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider provider, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, object listObject, bool isAddRecord, global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker sortGroupVersionTracker) : base(layout, parentCollection)
		{
			this._underlyingDataVersion = base.ParentCollection.ParentRecordManager.UnderlyingDataVersion;
			this._propertyDescriptorProvider = provider;
			this._isAddRecord = isAddRecord;
			this._sortGroupVersionTracker = sortGroupVersionTracker;
			this.SetDataItemHelper(listObject);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x00060122 File Offset: 0x0005E322
		internal DataRecord(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection) : this(layout, null, parentCollection, null, false, null)
		{
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00060130 File Offset: 0x0005E330
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x060015B2 RID: 5554 RVA: 0x00060189 File Offset: 0x0005E389
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return this.GetChildRcdCollection(false);
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00060192 File Offset: 0x0005E392
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return this.ChildRecords;
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x0006019C File Offset: 0x0005E39C
		internal override void CloneAssociatedRecordSettings(global::Infragistics.Windows.DataPresenter.Record associatedRecord, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			base.CloneAssociatedRecordSettings(associatedRecord, options);
			global::Infragistics.Windows.DataPresenter.DataRecord associatedDr = associatedRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
			this.CloneAssociatedCellSettings(associatedDr);
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x000601BF File Offset: 0x0005E3BF
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.DataRecordPresenter();
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000601C8 File Offset: 0x0005E3C8
		internal override void EnsureFiltersEvaluated()
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState)
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = base.ParentCollection;
				if (parentCollection != null)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = parentCollection.ViewableRecords;
					if (viewableRecords != null && viewableRecords.EnsureFiltersEvaluated() && (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) != 0)
					{
						this.ApplyFiltersHelper();
					}
				}
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x0006020B File Offset: 0x0005E40B
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			return base.ParentCollection.ParentRecordManager.GetAssociatedRecordInternal(this);
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x060015B8 RID: 5560 RVA: 0x00060220 File Offset: 0x0005E420
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

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x060015B9 RID: 5561 RVA: 0x00060279 File Offset: 0x0005E479
		internal override bool HasChildrenInternal
		{
			get
			{
				return this.HasExpandableFieldRecords;
			}
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060015BA RID: 5562 RVA: 0x00060281 File Offset: 0x0005E481
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x060015BB RID: 5563 RVA: 0x00060298 File Offset: 0x0005E498
		public override bool IsDataRecord
		{
			get
			{
				return !this.IsAddRecordTemplate;
			}
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x060015BC RID: 5564 RVA: 0x000602A3 File Offset: 0x0005E4A3
		internal override bool IsIndexValid
		{
			get
			{
				return this.IsAddRecordTemplate || base.IsIndexValid;
			}
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060015BD RID: 5565 RVA: 0x000602B5 File Offset: 0x0005E4B5
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

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060015BE RID: 5566 RVA: 0x000602D6 File Offset: 0x0005E4D6
		protected internal override bool IsSelectable
		{
			get
			{
				return !this.IsAddRecordTemplate && base.IsSelectable;
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x000602E8 File Offset: 0x0005E4E8
		public override bool IsSpecialRecord
		{
			get
			{
				return this._isAddRecord;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x060015C0 RID: 5568 RVA: 0x000602F0 File Offset: 0x0005E4F0
		internal override bool IsStillValid
		{
			get
			{
				return !this._isDeleted && base.IsStillValid;
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00060302 File Offset: 0x0005E502
		internal override void OnAssociatedRecordPresenterChanged()
		{
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x060015C2 RID: 5570 RVA: 0x00060304 File Offset: 0x0005E504
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.DataRecord;
			}
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00060308 File Offset: 0x0005E508
		internal override bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null || !field.IsValid)
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x060015C4 RID: 5572 RVA: 0x00060444 File Offset: 0x0005E644
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

		// Token: 0x060015C5 RID: 5573 RVA: 0x000604B4 File Offset: 0x0005E6B4
		internal override void SortChildren()
		{
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000604B8 File Offset: 0x0005E6B8
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

		// Token: 0x060015C7 RID: 5575 RVA: 0x00060570 File Offset: 0x0005E770
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

		// Token: 0x060015C8 RID: 5576 RVA: 0x00060608 File Offset: 0x0005E808
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x000606BC File Offset: 0x0005E8BC
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

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x060015CA RID: 5578 RVA: 0x000606F0 File Offset: 0x0005E8F0
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x0006070C File Offset: 0x0005E90C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection ChildRecords
		{
			get
			{
				return this.GetChildRcdCollection(true);
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00060718 File Offset: 0x0005E918
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x000607A8 File Offset: 0x0005E9A8
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060015CE RID: 5582 RVA: 0x00060824 File Offset: 0x0005EA24
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x0006084B File Offset: 0x0005EA4B
		public bool HasDataError
		{
			get
			{
				return !global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(this.DataError);
			}
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x0006085B File Offset: 0x0005EA5B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasExpandableFieldRecords
		{
			get
			{
				return (this._expandableFieldRecords != null && this._expandableFieldRecords.Count > 0) || base.FieldLayout.Fields.ExpandableFieldsCount > 0;
			}
		}

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00060888 File Offset: 0x0005EA88
		public bool IsAddRecord
		{
			get
			{
				return this._isAddRecord;
			}
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00060890 File Offset: 0x0005EA90
		public bool IsCellAllocated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this._cells != null && this._cells.IsCellAllocated(field);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000608A8 File Offset: 0x0005EAA8
		public bool IsCellAllocated(int index)
		{
			return this._cells != null && this._cells.IsCellAllocated(index);
		}

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x060015D4 RID: 5588 RVA: 0x000608C0 File Offset: 0x0005EAC0
		public bool IsDataChanged
		{
			get
			{
				if (this._isDataChanged)
				{
					return true;
				}
				if (this._isInUpdate)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Cell activeCell = base.DataPresenter.ActiveCell;
				return activeCell != null && activeCell.Record == this && activeCell.IsDataChanged;
			}
		}

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x00060901 File Offset: 0x0005EB01
		public bool IsDeleted
		{
			get
			{
				return this._isDeleted;
			}
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060015D6 RID: 5590 RVA: 0x00060909 File Offset: 0x0005EB09
		public bool? IsFilteredOut
		{
			get
			{
				return base.InternalIsFilteredOutNullable_Verify;
			}
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x00060911 File Offset: 0x0005EB11
		internal global::Infragistics.Windows.DataPresenter.CellCollection CellsIfAllocated
		{
			get
			{
				return this._cells;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00060919 File Offset: 0x0005EB19
		internal global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection ChildRecordsIfAllocated
		{
			get
			{
				return this._expandableFieldRecords;
			}
		}

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x00060921 File Offset: 0x0005EB21
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x060015DA RID: 5594 RVA: 0x00060953 File Offset: 0x0005EB53
		internal object DataItemInternal
		{
			get
			{
				return this._dataItem;
			}
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0006095C File Offset: 0x0005EB5C
		internal bool HasAtLeastOneCellWithDataChanged
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.CellCollection cellsIfAllocated = this.CellsIfAllocated;
				if (cellsIfAllocated == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.FieldCollection fields = base.FieldLayout.Fields;
				int num = (fields != null) ? fields.Count : 0;
				for (int i = 0; i < num; i++)
				{
					global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = cellsIfAllocated.GetCellIfAllocated(fields[i]);
					if (cellIfAllocated != null && cellIfAllocated.IsDataChanged)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x060015DC RID: 5596 RVA: 0x000609B9 File Offset: 0x0005EBB9
		internal bool HasSelectedCells
		{
			get
			{
				return this._cells != null && this._cells.HasSelectedCells;
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (set) Token: 0x060015DD RID: 5597 RVA: 0x000609D0 File Offset: 0x0005EBD0
		internal global::Infragistics.Windows.DataPresenter.Field IgnoreChangeNotificationsForField
		{
			set
			{
				this._ignoreChangeNotificationsForField = value;
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x060015DE RID: 5598 RVA: 0x000609D9 File Offset: 0x0005EBD9
		internal bool IsAddRecordTemplate
		{
			get
			{
				return this._isAddRecord && this._dataItem == null;
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x000609F0 File Offset: 0x0005EBF0
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

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x060015E0 RID: 5600 RVA: 0x00060A1C File Offset: 0x0005EC1C
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

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x00060A44 File Offset: 0x0005EC44
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

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x060015E2 RID: 5602 RVA: 0x00060A70 File Offset: 0x0005EC70
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x00060A98 File Offset: 0x0005EC98
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

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x060015E4 RID: 5604 RVA: 0x00060AC1 File Offset: 0x0005ECC1
		internal global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider PropertyDescriptorProvider
		{
			get
			{
				return this._propertyDescriptorProvider;
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00060ACC File Offset: 0x0005ECCC
		internal string RecordSelectorNumber
		{
			get
			{
				if (this._dataItem == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.FieldLayout;
				if (fieldLayout == null)
				{
					return null;
				}
				int num = -1;
				switch (fieldLayout.RecordSelectorNumberTypeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.DataItemIndex:
					num = this.DataItemIndex;
					break;
				case global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.RecordIndex:
					num = base.Index;
					break;
				case global::Infragistics.Windows.DataPresenter.RecordSelectorNumberType.VisibleIndex:
					num = base.VisibleIndex;
					if (num > 0)
					{
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = base.ParentCollection.ViewableRecords;
						num -= viewableRecords.CountOfSpecialRecordsOnTop;
					}
					break;
				}
				if (num < 0)
				{
					return null;
				}
				string text = (num + fieldLayout.RecordSelectorNumberStartResolved).ToString();
				global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = base.ParentDataRecord;
				if (parentDataRecord != null && fieldLayout.RecordSelectorNumberFormatResolved == global::Infragistics.Windows.DataPresenter.RecordSelectorNumberFormat.IncludeParentRecordNumber)
				{
					string recordSelectorNumber = parentDataRecord.RecordSelectorNumber;
					if (recordSelectorNumber != null)
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
						stringBuilder.Append(recordSelectorNumber);
						if (fieldLayout.DataPresenter != null)
						{
							stringBuilder.Append(fieldLayout.DataPresenter.RecordNumberSeparator);
						}
						else
						{
							stringBuilder.Append(".");
						}
						stringBuilder.Append(text);
						return stringBuilder.ToString();
					}
				}
				return text;
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060015E6 RID: 5606 RVA: 0x00060BCB File Offset: 0x0005EDCB
		internal int SortIndex
		{
			get
			{
				return base.ParentCollection.ParentRecordManager.Sorted.IndexOf(this);
			}
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00060BE4 File Offset: 0x0005EDE4
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

		// Token: 0x060015E8 RID: 5608 RVA: 0x00060C30 File Offset: 0x0005EE30
		public global::Infragistics.Windows.DataPresenter.Cell GetCellIfAllocated(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._cells == null)
			{
				return null;
			}
			return this._cells.GetCellIfAllocated(field);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00060C48 File Offset: 0x0005EE48
		public string GetCellText(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.ConvertCellValue(this, field);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00060C51 File Offset: 0x0005EE51
		public object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return this.GetCellValue(field, false);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00060C5C File Offset: 0x0005EE5C
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

		// Token: 0x060015EC RID: 5612 RVA: 0x00060CAC File Offset: 0x0005EEAC
		private object GetCellValueHelper(global::Infragistics.Windows.DataPresenter.Field field)
		{
			object result;
			try
			{
				if (field is global::Infragistics.Windows.DataPresenter.PlaceholderField)
				{
					result = null;
				}
				else if (this.IsAddRecordTemplate)
				{
					result = base.ParentCollection.ParentRecordManager.GetAddRecordCellData(field);
				}
				else if (field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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

		// Token: 0x060015ED RID: 5613 RVA: 0x00060DFC File Offset: 0x0005EFFC
		public virtual object GetCellValue(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.CellValueType cellValueType)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("Field");
			}
			if (field.Owner != base.FieldLayout)
			{
				bool flag = true;
				if (field.Owner != null && field.Owner.IsTreeView)
				{
					global::Infragistics.Windows.DataPresenter.Field mappedFieldInTree = field.GetMappedFieldInTree(base.FieldLayout);
					if (mappedFieldInTree != null && mappedFieldInTree.Owner == base.FieldLayout)
					{
						field = mappedFieldInTree;
						flag = false;
					}
				}
				if (flag)
				{
					throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_28"));
				}
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

		// Token: 0x060015EE RID: 5614 RVA: 0x00060ED8 File Offset: 0x0005F0D8
		public object GetCellDataError(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field.SupportDataErrorInfoResolved)
			{
				if (field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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

		// Token: 0x060015EF RID: 5615 RVA: 0x00060F34 File Offset: 0x0005F134
		public bool GetCellHasDataError(global::Infragistics.Windows.DataPresenter.Field field)
		{
			object cellDataError = this.GetCellDataError(field);
			return !global::Infragistics.Windows.DataPresenter.GridUtilities.IsNullOrEmpty(cellDataError);
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00060F54 File Offset: 0x0005F154
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

		// Token: 0x060015F1 RID: 5617 RVA: 0x00060F9C File Offset: 0x0005F19C
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

		// Token: 0x060015F2 RID: 5618 RVA: 0x00060FD4 File Offset: 0x0005F1D4
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

		// Token: 0x060015F3 RID: 5619 RVA: 0x00061003 File Offset: 0x0005F203
		public void RefreshCellValue(global::Infragistics.Windows.DataPresenter.Field field)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(field, "field");
			if (field.Owner == null || field.Owner != base.FieldLayout)
			{
				return;
			}
			this.RefreshCellValue(field, false, false);
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x00061030 File Offset: 0x0005F230
		public void RefreshFilters()
		{
			this.ApplyFiltersHelper();
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00061038 File Offset: 0x0005F238
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

		// Token: 0x060015F6 RID: 5622 RVA: 0x000610F8 File Offset: 0x0005F2F8
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

		// Token: 0x060015F7 RID: 5623 RVA: 0x00061140 File Offset: 0x0005F340
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

		// Token: 0x060015F8 RID: 5624 RVA: 0x00061175 File Offset: 0x0005F375
		public void SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value)
		{
			this.SetCellValue(field, value, false);
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x00061181 File Offset: 0x0005F381
		public bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter)
		{
			return this.SetCellValue(field, value, useConverter, false);
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x0006118D File Offset: 0x0005F38D
		public bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, bool addToUndo)
		{
			return this.SetCellValue(field, value, useConverter, addToUndo, false, global::Infragistics.Windows.DataPresenter.DataRecord.UndoValueMissing, false);
		}

		// Token: 0x060015FB RID: 5627 RVA: 0x000611A4 File Offset: 0x0005F3A4
		internal bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, bool addToUndo, bool suppressErrorDialog, object undoValue, bool isCommittingEdit)
		{
			return this.SetCellValue(field, value, useConverter, addToUndo, suppressErrorDialog, undoValue, isCommittingEdit, false);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x000611C4 File Offset: 0x0005F3C4
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

		// Token: 0x060015FD RID: 5629 RVA: 0x0006122B File Offset: 0x0005F42B
		internal bool SetCellValue(global::Infragistics.Windows.DataPresenter.Field field, object value, bool useConverter, out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo)
		{
			return this.SetCellValue(field, value, useConverter, out errorInfo, false);
		}

		// Token: 0x060015FE RID: 5630 RVA: 0x0006123C File Offset: 0x0005F43C
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
			if (field is global::Infragistics.Windows.DataPresenter.PlaceholderField)
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentException_39"));
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
					if (field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
					{
						if (cell == null)
						{
							cell = this.Cells[field];
						}
						bool isActive = cell.IsActive;
						((global::Infragistics.Windows.DataPresenter.UnboundCell)cell).ValueInternal = obj;
						if (isActive && !dontSetDataChanged)
						{
							cell.InternalSetDataChanged(true);
						}
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
								this.InternalSetDataChanged(true, false);
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
					base.FireInitializeRecord(true, field.IsSortOrGroupBy);
				}
				this.DataValueChangedHelper(field);
			}
			return result;
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x000615A8 File Offset: 0x0005F7A8
		public bool Update()
		{
			this._isInUpdate = true;
			bool result = false;
			try
			{
				global::Infragistics.Windows.DataPresenter.DataErrorInfo dataErrorInfo;
				result = this.Update(out dataErrorInfo);
				if (dataErrorInfo != null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
					if (dataPresenter != null)
					{
						dataPresenter.RaiseDataError(dataErrorInfo);
					}
				}
			}
			finally
			{
				this._isInUpdate = false;
			}
			return result;
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x000615F8 File Offset: 0x0005F7F8
		internal virtual bool Update(out global::Infragistics.Windows.DataPresenter.DataErrorInfo errorInfo)
		{
			errorInfo = null;
			if (!this.IsDataChanged)
			{
				return true;
			}
			if (!this._isDataChangedNotThruCellEdit && !this.HasAtLeastOneCellWithDataChanged)
			{
				this.CancelEdit();
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

		// Token: 0x06001601 RID: 5633 RVA: 0x00061680 File Offset: 0x0005F880
		internal void ApplyFiltersHelper()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = base.RecordManager;
			this.ApplyFiltersHelper((recordManager != null) ? recordManager.RecordFiltersResolved : null, true);
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x000616A8 File Offset: 0x0005F8A8
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
					global::Infragistics.Windows.DataPresenter.Record.FilterState newState = (flag == null) ? ((global::Infragistics.Windows.DataPresenter.Record.FilterState)0) : (flag.Value ? global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn : global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut);
					base.InternalSetFilterState(newState, raiseNotifications);
					return;
				}
				this._cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter;
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00061718 File Offset: 0x0005F918
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

		// Token: 0x06001604 RID: 5636 RVA: 0x00061764 File Offset: 0x0005F964
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
					int num2 = list2.IndexOf(dataItem);
					if (num2 >= 0)
					{
						list2.RemoveAt(num2);
					}
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
			this.InternalSetDataChanged(false, false);
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

		// Token: 0x06001605 RID: 5637 RVA: 0x00061958 File Offset: 0x0005FB58
		internal void CloneAssociatedCellSettings(global::Infragistics.Windows.DataPresenter.DataRecord associatedDr)
		{
			if (associatedDr != null && associatedDr._cells != null)
			{
				this.Cells.CloneAssociatedCellSettings(associatedDr.Cells);
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00061978 File Offset: 0x0005FB78
		internal void CoerceNullEditValue(global::Infragistics.Windows.DataPresenter.Field field, ref object editedValue)
		{
			if (editedValue == null || global::System.DBNull.Value == editedValue)
			{
				global::System.ComponentModel.PropertyDescriptor propertyDescriptor = field.IsPlaceholderForTreeView ? null : this.GetPropertyDescriptor(field);
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

		// Token: 0x06001607 RID: 5639 RVA: 0x000619D8 File Offset: 0x0005FBD8
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
				foreach (global::Infragistics.Windows.DataPresenter.Field field in base.FieldLayout.Fields)
				{
					if (field.IsEnabled != field.IsEnabledInAddRecord)
					{
						global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = this.GetCellIfAllocated(field);
						global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
						if (cellIfAllocated != null)
						{
							cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromCell(cellIfAllocated);
						}
						else
						{
							cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this, field);
						}
						if (cellValuePresenter != null)
						{
							cellValuePresenter.CoerceValue(global::System.Windows.UIElement.IsEnabledProperty);
						}
					}
				}
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
				if (base.ParentCollection.SparseArray != base.ParentCollection.ViewableRecords.RecordCollectionSparseArray)
				{
					base.DirtyScrollCount();
				}
				base.RaisePropertyChangedEvent("IsAddRecord");
				base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
				base.RaisePropertyChangedEvent("IsSpecialRecord");
			}
			this.InternalSetDataChanged(false, false);
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

		// Token: 0x06001608 RID: 5640 RVA: 0x00061C0C File Offset: 0x0005FE0C
		internal virtual global::Infragistics.Windows.DataPresenter.CellCollection CreateCellCollection()
		{
			return new global::Infragistics.Windows.DataPresenter.CellCollection(this);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00061C14 File Offset: 0x0005FE14
		internal void DeleteHelper()
		{
			if (base.ParentCollection == null)
			{
				return;
			}
			base.ParentCollection.ParentRecordManager.DeleteRecord(this);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00061C30 File Offset: 0x0005FE30
		internal virtual global::Infragistics.Windows.DataPresenter.CellClickAction GetCellClickActionResolved(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return field.CellClickActionResolved;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00061C38 File Offset: 0x0005FE38
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

		// Token: 0x0600160C RID: 5644 RVA: 0x00061C64 File Offset: 0x0005FE64
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

		// Token: 0x0600160D RID: 5645 RVA: 0x00061C90 File Offset: 0x0005FE90
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

		// Token: 0x0600160E RID: 5646 RVA: 0x00061CCC File Offset: 0x0005FECC
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

		// Token: 0x0600160F RID: 5647 RVA: 0x00061DAE File Offset: 0x0005FFAE
		internal static object GetObjectForRecordComparision(object listObject)
		{
			return global::Infragistics.Windows.Internal.DataBindingUtilities.GetObjectForComparison(listObject);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00061DB8 File Offset: 0x0005FFB8
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

		// Token: 0x06001611 RID: 5649 RVA: 0x00061DE2 File Offset: 0x0005FFE2
		internal void InitializeDataItem(object dataItem, int dataItemIndex)
		{
			this._dataItemIndex = dataItemIndex;
			this.SetDataItemHelper(dataItem);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x00061DF4 File Offset: 0x0005FFF4
		internal void InternalSetDataChanged(bool value, bool calledFromCellEditValueChanged = false)
		{
			if (this._isDataChangedSinceLastCommitAttempt != value)
			{
				this._isDataChangedSinceLastCommitAttempt = value;
			}
			if (this._isDataChanged != value)
			{
				this._isDataChanged = value;
				if (this._isDataChanged)
				{
					if (!this._isDataChangedNotThruCellEdit)
					{
						this._isDataChangedNotThruCellEdit = !calledFromCellEditValueChanged;
					}
				}
				else
				{
					this._isDataChangedNotThruCellEdit = false;
				}
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

		// Token: 0x06001613 RID: 5651 RVA: 0x00061E89 File Offset: 0x00060089
		internal void InternalSetIsDeleted()
		{
			this._isDeleted = true;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x00061E94 File Offset: 0x00060094
		internal bool IsCellEnabled(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.Cell cell, bool calledFromIsEnabledCore = false)
		{
			if (!base.IsEnabledResolved)
			{
				return false;
			}
			bool flag = this.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord;
			if (flag)
			{
				switch (field.FilterOperandUITypeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.None:
				case global::Infragistics.Windows.DataPresenter.FilterOperandUIType.Disabled:
					return false;
				}
			}
			if (cell == null)
			{
				cell = this.GetCellIfAllocated(field);
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter;
			if (field.HasCellBindings)
			{
				cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this, field);
			}
			else
			{
				cellValuePresenter = ((cell != null) ? cell.AssociatedCellValuePresenterInternal : null);
			}
			if (cellValuePresenter != null)
			{
				if (!calledFromIsEnabledCore && cellValuePresenter.Visibility != global::System.Windows.Visibility.Visible)
				{
					return false;
				}
				if (!calledFromIsEnabledCore && !cellValuePresenter.IsEnabled)
				{
					return false;
				}
			}
			if (cell != null && cell.IsEnabled != null)
			{
				return cell.IsEnabled.Value;
			}
			if (cellValuePresenter == null && !calledFromIsEnabledCore && field.HasCellBindings && !field.CellBindings.IsCvpEnabled(this))
			{
				return false;
			}
			if (flag)
			{
				return true;
			}
			if (!this._isAddRecord)
			{
				return field.IsEnabled;
			}
			return field.IsEnabledInAddRecord;
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00061F78 File Offset: 0x00060178
		internal bool IsCellTabStop(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.Cell cell = null)
		{
			if (!base.IsEnabledResolved)
			{
				return false;
			}
			if (cell == null)
			{
				cell = this.GetCellIfAllocated(field);
			}
			if (!this.IsCellEnabled(field, cell, false))
			{
				return false;
			}
			global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter = null;
			if (cell != null)
			{
				if (cell.IsTabStop != null)
				{
					return cell.IsTabStop.Value;
				}
				if (field.HasCellBindings)
				{
					cellValuePresenter = cell.AssociatedCellValuePresenterInternal;
				}
			}
			else if (field.HasCellBindings)
			{
				cellValuePresenter = global::Infragistics.Windows.DataPresenter.CellValuePresenter.FromRecordAndField(this, field);
			}
			if (field.HasCellBindings)
			{
				if (cellValuePresenter != null)
				{
					if (!cellValuePresenter.IsTabStop)
					{
						return false;
					}
				}
				else if (!field.CellBindings.IsCvpTabStop(this))
				{
					return false;
				}
			}
			if (this.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord)
			{
				return true;
			}
			if (!this._isAddRecord)
			{
				return field.IsTabStop;
			}
			return field.IsTabStopInAddRecord;
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00062032 File Offset: 0x00060232
		// (set) Token: 0x06001617 RID: 5655 RVA: 0x0006203A File Offset: 0x0006023A
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

		// Token: 0x06001618 RID: 5656 RVA: 0x00062043 File Offset: 0x00060243
		internal bool IsDataItemEqual(object dataItem, global::System.Collections.Generic.IEqualityComparer<object> comparer)
		{
			return comparer.Equals(this.DataItemForComparison, global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(dataItem));
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x00062057 File Offset: 0x00060257
		internal bool IsFirstDisplayedCell(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return cell != null && this._cells != null && cell.Record == this && cell.Field == this.FirstDisplayedField;
		}

		// Token: 0x0600161A RID: 5658 RVA: 0x0006207D File Offset: 0x0006027D
		internal bool IsLastDisplayedCell(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			return cell != null && this._cells != null && cell.Record == this && cell.Field == this.LastDisplayedField;
		}

		// Token: 0x0600161B RID: 5659 RVA: 0x000620A3 File Offset: 0x000602A3
		internal bool OnEditValueChanged(bool addToUndo, bool calledFromCellEditValueChanged = false)
		{
			return this.OnEditValueChanged(addToUndo, 0, calledFromCellEditValueChanged);
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000620B0 File Offset: 0x000602B0
		internal bool OnEditValueChanged(bool addToUndo, int recordOnTopOffset, bool calledFromCellEditValueChanged = false)
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
					this.InternalSetDataChanged(true, calledFromCellEditValueChanged);
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

		// Token: 0x0600161D RID: 5661 RVA: 0x00062230 File Offset: 0x00060430
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

		// Token: 0x0600161E RID: 5662 RVA: 0x0006226C File Offset: 0x0006046C
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

		// Token: 0x0600161F RID: 5663 RVA: 0x00062314 File Offset: 0x00060514
		internal void RefreshCellValue(string propertyDescriptorName, bool raiseInitializeRecord, bool isRecordPresenterDeactivated)
		{
			global::Infragistics.Windows.DataPresenter.Field fieldForPropertyDescriptor = this.GetFieldForPropertyDescriptor(propertyDescriptorName);
			if (fieldForPropertyDescriptor == null)
			{
				return;
			}
			this.RefreshCellValue(fieldForPropertyDescriptor, raiseInitializeRecord, isRecordPresenterDeactivated);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00062338 File Offset: 0x00060538
		internal void RefreshCellValue(global::Infragistics.Windows.DataPresenter.Field field, bool raiseInitializeRecord, bool isRecordPresenterDeactivated)
		{
			if (base.FieldLayout == null)
			{
				return;
			}
			if (field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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
				base.FireInitializeRecord(true, field.IsSortOrGroupBy);
			}
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x000623E0 File Offset: 0x000605E0
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
				if (field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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

		// Token: 0x06001622 RID: 5666 RVA: 0x0006247A File Offset: 0x0006067A
		internal void RefreshCellValues(bool excludeUnboundFields, bool raiseInitializeRecord)
		{
			this.RefreshCellValues(excludeUnboundFields, raiseInitializeRecord, true);
		}

		// Token: 0x06001623 RID: 5667 RVA: 0x00062488 File Offset: 0x00060688
		internal void RefreshCellValues(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> fields, bool raiseInitializeRecord)
		{
			bool flag = false;
			global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = base.AssociatedRecordPresenter;
			bool isRecordPresenterDeactivated = associatedRecordPresenter != null && associatedRecordPresenter.IsDeactivated;
			foreach (global::Infragistics.Windows.DataPresenter.Field field in fields)
			{
				flag = (flag || field.IsSortOrGroupBy);
				this.RefreshCellValue(field, false, isRecordPresenterDeactivated);
			}
			if (raiseInitializeRecord)
			{
				base.FireInitializeRecord(true, flag);
			}
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x00062508 File Offset: 0x00060708
		internal void RefreshCellValues(bool excludeUnboundFields, bool raiseInitializeRecord, bool reinitializeExpandableFields)
		{
			this.RefreshCellValues(excludeUnboundFields, raiseInitializeRecord, reinitializeExpandableFields, false);
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x00062514 File Offset: 0x00060714
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
						if (field.BindingType != global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding)
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
						flag3 = (flag3 || field.IsSortOrGroupBy);
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
					goto IL_1E5;
				}
			}
			this.OnEnumerableCellDataChanged();
			IL_1E5:
			this.RefreshDataErrorInfo(null, false);
			base.ClearSizeToContentManager(null);
			if (raiseInitializeRecord)
			{
				base.FireInitializeRecord(true, flag3);
			}
		}

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001626 RID: 5670 RVA: 0x00062740 File Offset: 0x00060940
		internal bool WasBeginEditCalled
		{
			get
			{
				return this._beginEditCalled;
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00062748 File Offset: 0x00060948
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

		// Token: 0x06001628 RID: 5672 RVA: 0x00062788 File Offset: 0x00060988
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

		// Token: 0x06001629 RID: 5673 RVA: 0x000627E8 File Offset: 0x000609E8
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
				if (this._dataItem is global::System.Data.DataRowView)
				{
					flag2 = true;
				}
				else if (!alwaysCreateIfEnumerable)
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

		// Token: 0x0600162A RID: 5674 RVA: 0x00062965 File Offset: 0x00060B65
		private global::System.ComponentModel.IDataErrorInfo GetDataErrorInfo()
		{
			return this.DataItem as global::System.ComponentModel.IDataErrorInfo;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00062974 File Offset: 0x00060B74
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

		// Token: 0x0600162C RID: 5676 RVA: 0x000629A8 File Offset: 0x00060BA8
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
			else if (this._dataItem != null && base.AssociatedRecordPresenter != null)
			{
				base.RaisePropertyChangedEvent("DataItem");
			}
			this._dataItemForComparison = global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(dataItem);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00062ACC File Offset: 0x00060CCC
		internal void RefreshDataErrorInfo(global::Infragistics.Windows.DataPresenter.Field field, bool excludeUnboundFields)
		{
			this.RefreshDataErrorInfo(field, excludeUnboundFields, null);
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00062AEC File Offset: 0x00060CEC
		internal void RefreshDataErrorInfo(global::Infragistics.Windows.DataPresenter.Field field, bool excludeUnboundFields, bool? raiseRecordError)
		{
			if (field != null && (!excludeUnboundFields || field.BindingType == global::Infragistics.Windows.DataPresenter.BindingType.UseNameBinding))
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

		// Token: 0x0600162F RID: 5679 RVA: 0x00062BE8 File Offset: 0x00060DE8
		internal void RefreshDataItem()
		{
			this._underlyingDataVersion--;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00062BF8 File Offset: 0x00060DF8
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

		// Token: 0x06001631 RID: 5681 RVA: 0x00062C94 File Offset: 0x00060E94
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

		// Token: 0x040008B8 RID: 2232
		private global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider _propertyDescriptorProvider;

		// Token: 0x040008B9 RID: 2233
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection _expandableFieldRecords;

		// Token: 0x040008BA RID: 2234
		private global::Infragistics.Windows.DataPresenter.CellCollection _cells;

		// Token: 0x040008BB RID: 2235
		private object _dataItem;

		// Token: 0x040008BC RID: 2236
		private object _dataItemForComparison;

		// Token: 0x040008BD RID: 2237
		private int _underlyingDataVersion;

		// Token: 0x040008BE RID: 2238
		private int _dataItemIndex;

		// Token: 0x040008BF RID: 2239
		private bool _isAddRecord;

		// Token: 0x040008C0 RID: 2240
		private bool _isDataChanged;

		// Token: 0x040008C1 RID: 2241
		private bool _isDataChangedNotThruCellEdit;

		// Token: 0x040008C2 RID: 2242
		private bool _isDataChangedSinceLastCommitAttempt;

		// Token: 0x040008C3 RID: 2243
		private bool _isDeleted;

		// Token: 0x040008C4 RID: 2244
		private bool _beginEditCalled;

		// Token: 0x040008C5 RID: 2245
		private bool _isInUpdate;

		// Token: 0x040008C6 RID: 2246
		private bool _isHookedToDataItemPropertyChangedEvent;

		// Token: 0x040008C7 RID: 2247
		private global::Infragistics.Windows.DataPresenter.Field _ignoreChangeNotificationsForField;

		// Token: 0x040008C8 RID: 2248
		private global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker _sortGroupVersionTracker;

		// Token: 0x040008C9 RID: 2249
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo[] _trackingInfos;

		// Token: 0x040008CA RID: 2250
		internal static object UndoValueMissing = new object();
	}
}
