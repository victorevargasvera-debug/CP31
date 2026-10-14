using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Threading;
using System.Xml;
using Infragistics.Collections;
using Infragistics.Windows.DataPresenter.Calculations;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000317 RID: 791
	public class RecordManager : global::Infragistics.PropertyChangeNotifier, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x000A29B0 File Offset: 0x000A0BB0
		internal RecordManager(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter, global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord parentRecord, global::Infragistics.Windows.DataPresenter.Field field)
		{
			this._dataPresenter = dataPresenter;
			this._field = field;
			if (parentRecord != null)
			{
				this._parentRecord = parentRecord;
				this._nestingDepth = parentRecord.RecordManagerNestingDepth + 1;
			}
			this._sortedRecords = new global::Infragistics.Windows.DataPresenter.DataRecordCollection(this._parentRecord, this, this._fieldLayout, false);
			this._unsortedRecords = new global::Infragistics.Windows.DataPresenter.DataRecordCollection(this._parentRecord, this, this._fieldLayout, true);
			this._asyncChangeList = new global::System.Collections.ArrayList();
			if (field == null || field.IsExpandableByDefault)
			{
				this.PostDelayedReset();
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x060025D9 RID: 9689 RVA: 0x000A2A4B File Offset: 0x000A0C4B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase Current
		{
			get
			{
				if (this.HasGroups)
				{
					return this.Groups;
				}
				return this.Sorted;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060025DA RID: 9690 RVA: 0x000A2A64 File Offset: 0x000A0C64
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataRecord CurrentAddRecord
		{
			get
			{
				if (this.AddNewRecordLocation == global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default)
				{
					return null;
				}
				if (this._currentAddRecord == null && this.DataSource != null)
				{
					this._currentAddRecord = global::Infragistics.Windows.DataPresenter.DataRecord.Create(this._sortedRecords, null, true, -1);
				}
				return this._currentAddRecord;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060025DB RID: 9691 RVA: 0x000A2AA7 File Offset: 0x000A0CA7
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x060025DC RID: 9692 RVA: 0x000A2AAF File Offset: 0x000A0CAF
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool DataSourceAllowsAddNew
		{
			get
			{
				return this.AllowsAddNewCore && this.DoesTypeSupportEditInList();
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x060025DD RID: 9693 RVA: 0x000A2AC4 File Offset: 0x000A0CC4
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool DataSourceAllowsDelete
		{
			get
			{
				if (this._editableCollectionView != null)
				{
					return this._editableCollectionView.CanRemove;
				}
				global::System.ComponentModel.IBindingList bindingList = this.BindingList;
				if (bindingList != null)
				{
					return bindingList.AllowRemove;
				}
				return this._list != null && !this._list.IsReadOnly && !this._list.IsFixedSize;
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x060025DE RID: 9694 RVA: 0x000A2B20 File Offset: 0x000A0D20
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool DataSourceAllowsEdit
		{
			get
			{
				global::System.ComponentModel.IBindingList bindingList = this.BindingList;
				if (bindingList != null)
				{
					return bindingList.AllowEdit;
				}
				return this.DoesTypeSupportEditInList();
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x060025DF RID: 9695 RVA: 0x000A2B44 File Offset: 0x000A0D44
		public global::System.ComponentModel.ICollectionView FilteredInDataItems
		{
			get
			{
				if (this._filteredInDataItems == null)
				{
					this._filteredInDataItems = new global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection(this);
				}
				return this._filteredInDataItems;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060025E0 RID: 9696 RVA: 0x000A2B60 File Offset: 0x000A0D60
		internal global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection FilteredInDataItemsIfAllocated
		{
			get
			{
				return this._filteredInDataItems;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x060025E1 RID: 9697 RVA: 0x000A2B68 File Offset: 0x000A0D68
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.GroupByRecordCollection Groups
		{
			get
			{
				this.VerifyRootDataSource();
				if (this._groups == null)
				{
					this._groups = new global::Infragistics.Windows.DataPresenter.GroupByRecordCollection(this.ParentRecord, this, this._fieldLayout);
				}
				else if (this._fieldLayout != null && this._fieldLayout != this._groups.FieldLayout)
				{
					this._groups.InitializeFieldLayout(this._fieldLayout);
				}
				return this._groups;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x060025E2 RID: 9698 RVA: 0x000A2BCF File Offset: 0x000A0DCF
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasGroups
		{
			get
			{
				return this._groups != null && this._groups.Count > 0;
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060025E3 RID: 9699 RVA: 0x000A2BE9 File Offset: 0x000A0DE9
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x000A2BF1 File Offset: 0x000A0DF1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasMultipleFieldLayouts
		{
			get
			{
				return this._hasMultipleFieldLayouts;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060025E5 RID: 9701 RVA: 0x000A2BF9 File Offset: 0x000A0DF9
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsSorted
		{
			get
			{
				return this._isSorted;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060025E6 RID: 9702 RVA: 0x000A2C01 File Offset: 0x000A0E01
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord ParentRecord
		{
			get
			{
				return this._parentRecord;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000A2C09 File Offset: 0x000A0E09
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataRecord ParentDataRecord
		{
			get
			{
				if (this._parentRecord != null)
				{
					return this._parentRecord.ParentDataRecord;
				}
				return null;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x060025E8 RID: 9704 RVA: 0x000A2C20 File Offset: 0x000A0E20
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.RecordFilterCollection RecordFilters
		{
			get
			{
				if (this._recordFilters == null)
				{
					this._recordFilters = new global::Infragistics.Windows.DataPresenter.RecordFilterCollection(this);
				}
				return this._recordFilters;
			}
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x000A2C3C File Offset: 0x000A0E3C
		internal global::Infragistics.Windows.DataPresenter.RecordFilterCollection RecordFiltersIfAllocated
		{
			get
			{
				return this._recordFilters;
			}
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000A2C44 File Offset: 0x000A0E44
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRecordFilters()
		{
			return this._recordFilters != null && this._recordFilters.ShouldSerialize();
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000A2C5B File Offset: 0x000A0E5B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRecordFilters()
		{
			if (this._recordFilters != null)
			{
				this._recordFilters.Clear();
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x000A2C70 File Offset: 0x000A0E70
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataRecordCollection Sorted
		{
			get
			{
				this.VerifyRootDataSource();
				return this._sortedRecords;
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x000A2C7E File Offset: 0x000A0E7E
		public global::System.Collections.IEnumerable SourceItems
		{
			get
			{
				return this._sourceItems;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x000A2C86 File Offset: 0x000A0E86
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> Unsorted
		{
			get
			{
				return this.UnsortedInternalVerify;
			}
		}

		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x000A2C90 File Offset: 0x000A0E90
		internal global::Infragistics.Windows.DataPresenter.RecordManager AssociatedRecordManager
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this._dataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
				if (dataPresenterExportControlBase == null)
				{
					return null;
				}
				if (dataPresenterExportControlBase.ReportVersion != this._reportVersion)
				{
					this._reportVersion = dataPresenterExportControlBase.ReportVersion;
					this._associatedRecordManager = null;
				}
				if (this._associatedRecordManager == null)
				{
					if (this._parentRecord == null)
					{
						this._associatedRecordManager = dataPresenterExportControlBase.SourceDataPresenter.RecordManager;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = this._parentRecord.GetAssociatedRecord() as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
						if (expandableFieldRecord == null)
						{
							return null;
						}
						this._associatedRecordManager = expandableFieldRecord.ChildRecordManagerIfNeeded;
					}
				}
				return this._associatedRecordManager;
			}
		}

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x000A2D1A File Offset: 0x000A0F1A
		// (set) Token: 0x060025F1 RID: 9713 RVA: 0x000A2D22 File Offset: 0x000A0F22
		internal int FieldAutoSizeVersion
		{
			get
			{
				return this._fieldAutoSizeVersion;
			}
			set
			{
				this._fieldAutoSizeVersion = value;
			}
		}

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x060025F2 RID: 9714 RVA: 0x000A2D2B File Offset: 0x000A0F2B
		internal global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation BeginUpdateInfo
		{
			get
			{
				return this._beginUpdateInfo;
			}
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x060025F3 RID: 9715 RVA: 0x000A2D33 File Offset: 0x000A0F33
		internal global::System.ComponentModel.IBindingList BindingList
		{
			get
			{
				return this._bindingList;
			}
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x060025F4 RID: 9716 RVA: 0x000A2D3B File Offset: 0x000A0F3B
		internal bool CanGetPropertiesFromDataSourceWithoutItems
		{
			get
			{
				return this._canGetPropertiesFromDataSourceWithoutItems;
			}
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x000A2D43 File Offset: 0x000A0F43
		internal global::Infragistics.Windows.DataPresenter.DataRecord CurrentAddRecordInternal
		{
			get
			{
				return this._currentAddRecord;
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x060025F6 RID: 9718 RVA: 0x000A2D4B File Offset: 0x000A0F4B
		internal global::Infragistics.Windows.DataPresenter.RecordCollectionBase CurrentInternal
		{
			get
			{
				if (this.HasGroups)
				{
					return this._groups;
				}
				return this._sortedRecords;
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060025F7 RID: 9719 RVA: 0x000A2D62 File Offset: 0x000A0F62
		// (set) Token: 0x060025F8 RID: 9720 RVA: 0x000A2D6A File Offset: 0x000A0F6A
		internal global::System.Collections.IEnumerable DataSource
		{
			get
			{
				return this._sourceItems;
			}
			set
			{
				if (value != this._sourceItems || global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(value) != this._underlyingSourceItems)
				{
					this.SetDataSource(value, !this._hasSourceBeenSetAtLeastOnce);
				}
			}
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000A2D94 File Offset: 0x000A0F94
		private void SetDataSource(global::System.Collections.IEnumerable currentValue, bool postReset)
		{
			global::System.Collections.IEnumerable sourceItems = this._sourceItems;
			if (sourceItems == null && currentValue != null && this._parentRecord != null)
			{
				this._isInitializingDataSource = true;
			}
			if (this._collectionView != null && this._parentRecord == null)
			{
				this.UnwireCollectionViewEvents();
			}
			this.ClearAddRecordOnDataSourceChange();
			this._firstResetProcessed = false;
			this._sourceItems = currentValue;
			if (this._sourceItems is global::System.ComponentModel.IListSource)
			{
				this._sourceItems = ((global::System.ComponentModel.IListSource)this._sourceItems).GetList();
			}
			this._underlyingSourceItems = global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(currentValue);
			this._hasSourceBeenSetAtLeastOnce = true;
			if (currentValue is global::System.ComponentModel.ICollectionViewFactory)
			{
				this._collectionView = global::System.Windows.Data.CollectionViewSource.GetDefaultView(currentValue);
			}
			else
			{
				this._collectionView = (currentValue as global::System.ComponentModel.ICollectionView);
			}
			if (this._collectionView != null && this._parentRecord == null)
			{
				this.WireCollectionViewEvents();
			}
			this.VerifyListSourceToUse();
			if (this.ViewableRecords != null)
			{
				this.ViewableRecords.DirtySpecialRecords(false);
			}
			if (postReset)
			{
				this.PostDelayedReset();
			}
			else
			{
				this.OnSourceCollectionReset();
			}
			if (sourceItems != null && sourceItems != this._sourceItems && this._parentRecord == null)
			{
				((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this._dataPresenter).OverallScrollPosition = 0;
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x000A2EA1 File Offset: 0x000A10A1
		internal bool DataSourceRaisesCellValueChangeEvents
		{
			get
			{
				return this._dataSourceRaisesCellValueChangeEvents;
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x000A2EA9 File Offset: 0x000A10A9
		internal global::Infragistics.Windows.EditableCollectionViewProxy EditableCollectionView
		{
			get
			{
				return this._editableCollectionView;
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x000A2EB1 File Offset: 0x000A10B1
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x060025FD RID: 9725 RVA: 0x000A2EB9 File Offset: 0x000A10B9
		internal global::Infragistics.Windows.DataPresenter.FilterEvaluationMode FilterEvaluationModeResolved
		{
			get
			{
				if (this._fieldLayout == null)
				{
					return global::Infragistics.Windows.DataPresenter.FilterEvaluationMode.Auto;
				}
				return this._fieldLayout.FilterEvaluationModeResolved;
			}
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x000A2ED0 File Offset: 0x000A10D0
		internal static global::Infragistics.Windows.EditableCollectionViewProxy GetEditableCollectionViewProxy(object source, global::Infragistics.Windows.EditableCollectionViewProxy existingProxy)
		{
			global::System.Windows.Data.CollectionView collectionView = source as global::System.Windows.Data.CollectionView;
			if (collectionView == null)
			{
				return null;
			}
			if (global::Infragistics.Windows.EditableCollectionViewProxy.IEditableCollectionViewType == null)
			{
				return null;
			}
			if (!global::Infragistics.Windows.EditableCollectionViewProxy.IEditableCollectionViewType.IsAssignableFrom(source.GetType()))
			{
				return null;
			}
			if (existingProxy != null && existingProxy.View == collectionView)
			{
				return existingProxy;
			}
			return new global::Infragistics.Windows.EditableCollectionViewProxy(collectionView);
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x000A2F20 File Offset: 0x000A1120
		internal global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode GroupByEvaluationModeResolved
		{
			get
			{
				if (this._fieldLayout == null)
				{
					return global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.Auto;
				}
				return this._fieldLayout.GroupByEvaluationModeResolvedDefault;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002600 RID: 9728 RVA: 0x000A2F37 File Offset: 0x000A1137
		internal global::Infragistics.Windows.DataPresenter.GroupByRecordCollection GroupsInternal
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x000A2F40 File Offset: 0x000A1140
		internal bool IsAddRecordOnTop
		{
			get
			{
				switch (this.AddNewRecordLocation)
				{
				case global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTop:
				case global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTopFixed:
					return true;
				default:
					return false;
				}
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002602 RID: 9730 RVA: 0x000A2F6C File Offset: 0x000A116C
		internal bool IsInActiveRecordChain
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record activeRecord = this.DataPresenter.ActiveRecord;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
				if (activeRecord == null)
				{
					dataRecord = null;
				}
				else
				{
					dataRecord = ((activeRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord) ? (activeRecord as global::Infragistics.Windows.DataPresenter.DataRecord) : activeRecord.ParentDataRecord);
				}
				while (dataRecord != null)
				{
					if (this == dataRecord.RecordManager)
					{
						return true;
					}
					dataRecord = dataRecord.ParentDataRecord;
				}
				return false;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000A2FBB File Offset: 0x000A11BB
		internal bool IsInReset
		{
			get
			{
				return this._isInReset;
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002604 RID: 9732 RVA: 0x000A2FC3 File Offset: 0x000A11C3
		internal bool IsCurrentAddRecordAllocated
		{
			get
			{
				return this._currentAddRecord != null;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002605 RID: 9733 RVA: 0x000A2FD1 File Offset: 0x000A11D1
		internal bool IsCollectionView
		{
			get
			{
				return this._collectionView != null;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x000A2FDF File Offset: 0x000A11DF
		// (set) Token: 0x06002607 RID: 9735 RVA: 0x000A2FE7 File Offset: 0x000A11E7
		internal bool IsInVerifySort { get; private set; }

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x000A2FF0 File Offset: 0x000A11F0
		internal bool IsObservable
		{
			get
			{
				return this._notifyCollectionChangedHooked != null || this._bindingList != null;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x000A3008 File Offset: 0x000A1208
		internal bool IsRootManager
		{
			get
			{
				return null == this._parentRecord;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x0600260A RID: 9738 RVA: 0x000A3013 File Offset: 0x000A1213
		internal bool IsUpdating
		{
			get
			{
				return null != this._beginUpdateInfo;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x000A3021 File Offset: 0x000A1221
		internal global::System.Collections.IList List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x0600260C RID: 9740 RVA: 0x000A3029 File Offset: 0x000A1229
		internal int NestingDepth
		{
			get
			{
				return this._nestingDepth;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x0600260D RID: 9741 RVA: 0x000A3031 File Offset: 0x000A1231
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection RecordFiltersResolved
		{
			get
			{
				if (this._recordFiltersResolved == null)
				{
					this._recordFiltersResolved = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection(this);
				}
				return this._recordFiltersResolved;
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x0600260E RID: 9742 RVA: 0x000A304D File Offset: 0x000A124D
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection RecordFiltersResolvedIfAllocated
		{
			get
			{
				return this._recordFiltersResolved;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x000A3058 File Offset: 0x000A1258
		internal int ScrollCountVersion
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				return this._scrollCountVersion + ((dataPresenter != null) ? dataPresenter._cachedScrollCountRecalcVersion : 0);
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x000A307F File Offset: 0x000A127F
		internal global::Infragistics.Windows.DataPresenter.DataRecordCollection SortedInternal
		{
			get
			{
				return this._sortedRecords;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002611 RID: 9745 RVA: 0x000A3087 File Offset: 0x000A1287
		internal global::Infragistics.Windows.DataPresenter.SortEvaluationMode SortEvaluationModeResolved
		{
			get
			{
				if (this._fieldLayout == null)
				{
					return global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Auto;
				}
				return this._fieldLayout.SortEvaluationModeResolvedDefault;
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x000A309E File Offset: 0x000A129E
		internal int UnderlyingDataVersion
		{
			get
			{
				return this._underlyingDataVersion;
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x000A30A6 File Offset: 0x000A12A6
		internal global::Infragistics.Windows.DataPresenter.DataRecordCollection UnsortedInternalVerify
		{
			get
			{
				this.VerifyRootDataSource();
				return this._unsortedRecords;
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x000A30B4 File Offset: 0x000A12B4
		internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableRecords
		{
			get
			{
				if (this.HasGroups)
				{
					return this.Groups.ViewableRecords;
				}
				return this._sortedRecords.ViewableRecords;
			}
		}

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x000A30D8 File Offset: 0x000A12D8
		private int ActiveDataRecordUnsortedIndex
		{
			get
			{
				if (this._parentRecord == null)
				{
					return this.RootActiveDataRecordUnsortedIndex;
				}
				global::Infragistics.Windows.DataPresenter.Record activeRecord = this._dataPresenter.ActiveRecord;
				if (activeRecord == null)
				{
					return -1;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (activeRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord) ? (activeRecord as global::Infragistics.Windows.DataPresenter.DataRecord) : activeRecord.ParentDataRecord;
				while (dataRecord != null && dataRecord.ParentRecord != this._parentRecord)
				{
					dataRecord = dataRecord.ParentDataRecord;
				}
				if (dataRecord == null)
				{
					return -1;
				}
				if (this._resetOperationPending != null)
				{
					this.OnSourceCollectionReset();
				}
				return this._unsortedRecords.IndexOf(dataRecord);
			}
		}

		// Token: 0x17000B46 RID: 2886
		// (get) Token: 0x06002616 RID: 9750 RVA: 0x000A3155 File Offset: 0x000A1355
		private int CollectionViewCurrentPosition
		{
			get
			{
				if (this._collectionViewWrapper != null)
				{
					return this._collectionViewWrapper.CurrentPosition;
				}
				if (this._collectionView != null)
				{
					return this._collectionView.CurrentPosition;
				}
				return -1;
			}
		}

		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002617 RID: 9751 RVA: 0x000A3180 File Offset: 0x000A1380
		private bool IsInSyncWithCurrentPosition
		{
			get
			{
				if (this._dataPresenter == null || this._collectionView == null || !this._dataPresenter.IsInitialized || !this._dataPresenter.IsSynchronizedWithCurrentItem)
				{
					return false;
				}
				if (this._resetOperationPending != null)
				{
					this.OnSourceCollectionReset();
				}
				int activeDataRecordUnsortedIndex = this.ActiveDataRecordUnsortedIndex;
				int collectionViewCurrentPosition = this.CollectionViewCurrentPosition;
				bool flag = collectionViewCurrentPosition < 0 || collectionViewCurrentPosition == this._unsortedRecords.Count;
				if (activeDataRecordUnsortedIndex < 0)
				{
					return flag;
				}
				if (flag)
				{
					return activeDataRecordUnsortedIndex < 0 || (this._currentAddRecord != null && this._currentAddRecord.IsAddRecord);
				}
				return collectionViewCurrentPosition == activeDataRecordUnsortedIndex;
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x000A3214 File Offset: 0x000A1414
		private bool AllowsAddNewCore
		{
			get
			{
				if (this._editableCollectionView != null)
				{
					return this._editableCollectionView.CanAddNew;
				}
				if (this._bindingList == null && this._typeWithPublicCtor != null && this._list != null)
				{
					return !this._list.IsReadOnly && !this._list.IsFixedSize;
				}
				return global::Infragistics.Windows.DataPresenter.RecordManager.DoesBindingListSupportAddNew(this.BindingList, this._canGetPropertiesFromDataSourceWithoutItems);
			}
		}

		// Token: 0x17000B49 RID: 2889
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x000A3282 File Offset: 0x000A1482
		internal bool IsResetPending
		{
			get
			{
				return this._resetOperationPending != null;
			}
		}

		// Token: 0x17000B4A RID: 2890
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x000A3290 File Offset: 0x000A1490
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> RecordsInsertedAtTop
		{
			get
			{
				return this.ViewableRecords.RecordsInsertedAtTop;
			}
		}

		// Token: 0x17000B4B RID: 2891
		// (get) Token: 0x0600261B RID: 9755 RVA: 0x000A32A0 File Offset: 0x000A14A0
		private int RootActiveDataRecordUnsortedIndex
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record activeRecord = this._dataPresenter.ActiveRecord;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (activeRecord != null) ? activeRecord.TopLevelDataRecord : null;
				if (this._resetOperationPending != null)
				{
					this.OnSourceCollectionReset();
				}
				if (dataRecord == null)
				{
					return -1;
				}
				return this._unsortedRecords.IndexOf(dataRecord);
			}
		}

		// Token: 0x17000B4C RID: 2892
		// (get) Token: 0x0600261C RID: 9756 RVA: 0x000A32E5 File Offset: 0x000A14E5
		private bool TreatUpdatesAsResets
		{
			get
			{
				return this._collectionView != null && this._list == null;
			}
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000A32FC File Offset: 0x000A14FC
		public void CommitAddRecord()
		{
			global::Infragistics.Windows.DataPresenter.DataRecord currentAddRecord = this.CurrentAddRecord;
			if (currentAddRecord != null)
			{
				if (currentAddRecord.IsAddRecordTemplate)
				{
					currentAddRecord.OnEditValueChanged(true);
				}
				currentAddRecord.Update();
			}
		}

		// Token: 0x0600261E RID: 9758 RVA: 0x000A332C File Offset: 0x000A152C
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> GetFilteredInDataRecords()
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria criteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaChain(new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordVisible(), new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_FilteredInRecords(), false);
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.DataRecord>(this.Sorted, criteria);
		}

		// Token: 0x0600261F RID: 9759 RVA: 0x000A3358 File Offset: 0x000A1558
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> GetFilteredOutDataRecords()
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria meetsCriteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_FilteredInRecords();
			meetsCriteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaComplement(meetsCriteria);
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.DataRecord>(this.Sorted, meetsCriteria);
		}

		// Token: 0x06002620 RID: 9760 RVA: 0x000A337E File Offset: 0x000A157E
		public global::Infragistics.Windows.DataPresenter.RecordFilterCollection GetRecordFiltersResolved(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return this.RecordFiltersResolved.GetRecordFilters(fieldLayout, true);
		}

		// Token: 0x06002621 RID: 9761 RVA: 0x000A3390 File Offset: 0x000A1590
		public void ResetDataValueHistory(bool recursive)
		{
			foreach (object obj in this._unsortedRecords.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)obj;
				dataRecord.ResetDataValueHistory(recursive);
			}
		}

		// Token: 0x06002622 RID: 9762 RVA: 0x000A33F4 File Offset: 0x000A15F4
		internal object AddNew()
		{
			return this.AddNew(0);
		}

		// Token: 0x06002623 RID: 9763 RVA: 0x000A3400 File Offset: 0x000A1600
		internal object AddNew(int recordOnTopOffset)
		{
			global::System.ComponentModel.IBindingList bindingList = this.BindingList;
			if (this._editableCollectionView == null)
			{
				if (bindingList != null)
				{
					if (!bindingList.AllowNew)
					{
						return null;
					}
				}
				else if (!this.DataSourceAllowsAddNew)
				{
					return null;
				}
			}
			this._inAddNew = true;
			object result;
			try
			{
				global::Infragistics.Windows.DataPresenter.DataRecord currentAddRecord = this.CurrentAddRecord;
				bool isAddRecordOnTop = this.IsAddRecordOnTop;
				int newRecordOnTopOffset = 0;
				if (isAddRecordOnTop)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> recordsInsertedAtTop = this.RecordsInsertedAtTop;
					newRecordOnTopOffset = global::System.Math.Max(0, global::System.Math.Min(recordsInsertedAtTop.Count, recordOnTopOffset));
				}
				this._newRecordOnTopOffset = newRecordOnTopOffset;
				object obj;
				if (this._editableCollectionView != null)
				{
					obj = this._editableCollectionView.AddNew();
				}
				else if (bindingList != null)
				{
					obj = bindingList.AddNew();
				}
				else
				{
					try
					{
						if (this._typeWithPublicCtor == typeof(string))
						{
							obj = string.Empty;
						}
						else
						{
							obj = global::System.Activator.CreateInstance(this._typeWithPublicCtor);
						}
					}
					catch (global::System.Exception ex)
					{
						this._dataPresenter.RaiseDataError(null, (this._parentRecord != null) ? this._parentRecord.Field : null, ex, global::Infragistics.Windows.DataPresenter.DataErrorOperation.RecordAdd, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DataErrorUnableToCreateInstance", new object[]
						{
							this._typeWithPublicCtor,
							ex.InnerException
						}));
						return null;
					}
					int startingIndex = this._list.Add(obj);
					if (this._list.Count > this._unsortedRecords.Count)
					{
						this.OnSourceCollectionAddOrRemove(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, new global::System.Collections.Generic.List<object>
						{
							obj
						}, startingIndex));
					}
				}
				if (this.IsAddRecordOnTop)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> recordsInsertedAtTop2 = this.RecordsInsertedAtTop;
					if (recordOnTopOffset == 0)
					{
						recordsInsertedAtTop2.Add(currentAddRecord);
					}
					else
					{
						int index = global::System.Math.Max(0, global::System.Math.Min(recordsInsertedAtTop2.Count, recordsInsertedAtTop2.Count - recordOnTopOffset));
						recordsInsertedAtTop2.Insert(index, currentAddRecord);
					}
				}
				result = obj;
			}
			finally
			{
				this._newRecordOnTopOffset = 0;
				this._inAddNew = false;
			}
			return result;
		}

		// Token: 0x17000B4D RID: 2893
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x000A35F8 File Offset: 0x000A17F8
		internal global::Infragistics.Windows.DataPresenter.AddNewRecordLocation AddNewRecordLocation
		{
			get
			{
				if (!this.DataSourceAllowsAddNew)
				{
					return global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter == null)
				{
					return global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default;
				}
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
				if (currentViewInternal == null || !currentViewInternal.IsAddNewRecordSupported)
				{
					return global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default;
				}
				if (this.HasGroups)
				{
					return global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default;
				}
				if (this._fieldLayout != null && this._fieldLayout.HasGroupBySortFields)
				{
					return global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default;
				}
				if (this._fieldLayout == null)
				{
					global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection = (this._parentRecord != null) ? this._parentRecord.ChildRecords : null;
					this.InitializeFieldLayout(dataPresenter.FieldLayouts.GetDefaultLayoutForItem(null, this._sourceItems, parentRecordCollection));
					if (this._fieldLayout != null && !this._fieldLayout.AreFieldsInitialized)
					{
						this._fieldLayout.InitializeFields(null, this._sourceItems, parentRecordCollection);
					}
				}
				if (this._fieldLayout != null && this._fieldLayout.AllowAddNewResolved)
				{
					global::Infragistics.Windows.DataPresenter.AddNewRecordLocation addNewRecordLocation = this._fieldLayout.AddNewRecordLocationResolved;
					if (!currentViewInternal.IsFixedRecordsSupported)
					{
						if (addNewRecordLocation == global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTopFixed)
						{
							addNewRecordLocation = global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTop;
						}
						else if (addNewRecordLocation == global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnBottomFixed)
						{
							addNewRecordLocation = global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnBottom;
						}
					}
					return addNewRecordLocation;
				}
				return global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.Default;
			}
		}

		// Token: 0x06002625 RID: 9765 RVA: 0x000A36EA File Offset: 0x000A18EA
		internal void BeginUpdate()
		{
			if (this._beginUpdateInfo == null)
			{
				this._beginUpdateInfo = new global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation(this);
			}
			this._beginUpdateInfo._beginUpdateCount++;
		}

		// Token: 0x06002626 RID: 9766 RVA: 0x000A3713 File Offset: 0x000A1913
		internal void Clear()
		{
			this.Clear(true, true);
		}

		// Token: 0x06002627 RID: 9767 RVA: 0x000A3720 File Offset: 0x000A1920
		private void Clear(bool notifyListeners, bool clearGroups)
		{
			this.ClearCachedRecordsOnTop();
			this.ViewableRecords.ClearFixedRecords();
			if (this._unsortedRecords.Count > 0)
			{
				if (notifyListeners)
				{
					this._unsortedRecords.Clear();
					base.RaisePropertyChangedEvent("Unsorted");
				}
				else
				{
					this._unsortedRecords.SparseArray.Clear();
				}
			}
			if (this._sortedRecords != null && this._sortedRecords.Count > 0)
			{
				if (notifyListeners)
				{
					this._sortedRecords.Clear();
					base.RaisePropertyChangedEvent("Sorted");
				}
				else
				{
					this._sortedRecords.SparseArray.Clear();
				}
			}
			if (clearGroups && this._groups != null && this._groups.Count > 0)
			{
				if (notifyListeners)
				{
					this._groups.Clear();
					base.RaisePropertyChangedEvent("Groups");
					return;
				}
				this._groups.SparseArray.Clear();
			}
		}

		// Token: 0x06002628 RID: 9768 RVA: 0x000A37FC File Offset: 0x000A19FC
		internal bool CommitRecord(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			record.IsDataChangedSinceLastCommitAttempt = false;
			this._recordBeingCommitted = record;
			bool isAddRecord = record.IsAddRecord;
			bool result;
			try
			{
				if (this._editableCollectionView != null)
				{
					if (this._editableCollectionView.IsAddingNew && global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(this.EditableCollectionView.CurrentAddItem, record.DataItem))
					{
						this._editableCollectionView.CommitNew();
					}
					else if (this._editableCollectionView.IsEditingItem && global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(this._editableCollectionView.CurrentEditItem, record.DataItem))
					{
						this._editableCollectionView.CommitEdit();
					}
				}
				else
				{
					global::System.ComponentModel.IEditableObject editableObject = record.DataItem as global::System.ComponentModel.IEditableObject;
					if (editableObject != null && (isAddRecord || record.WasBeginEditCalled))
					{
						editableObject.EndEdit();
					}
					if (isAddRecord)
					{
						global::System.Collections.IList list = this.List;
						global::System.ComponentModel.ICancelAddNew cancelAddNew = list as global::System.ComponentModel.ICancelAddNew;
						if (cancelAddNew != null)
						{
							int dataItemIndex = record.DataItemIndex;
							if (dataItemIndex >= 0 && dataItemIndex < list.Count)
							{
								cancelAddNew.EndNew(dataItemIndex);
							}
						}
					}
				}
				result = true;
			}
			finally
			{
				this._recordBeingCommitted = null;
			}
			return result;
		}

		// Token: 0x06002629 RID: 9769 RVA: 0x000A3900 File Offset: 0x000A1B00
		internal bool ContainsFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			return this._fieldLayout == fl || (this._sortGroupByVersionTrackers != null && this._sortGroupByVersionTrackers.ContainsKey(fl));
		}

		// Token: 0x0600262A RID: 9770 RVA: 0x000A3924 File Offset: 0x000A1B24
		internal void DeleteRecord(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			if (this.DataPresenter == null || !this.DataSourceAllowsDelete)
			{
				return;
			}
			if (record.ParentCollection.ParentRecordManager != this)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this.DataPresenter.ActiveCell;
			if (activeCell != null && record == activeCell.Record && activeCell.IsInEditMode)
			{
				activeCell.EndEditMode(true, true);
			}
			try
			{
				this._recordBeingDeleted = record;
				if (record.IsDataChanged)
				{
					record.CancelUpdate();
				}
				if (!record.IsAddRecord)
				{
					int num = record.DataItemIndex;
					if (num >= 0 && num < this._list.Count && global::Infragistics.Windows.DataPresenter.GridUtilities.AreEqual(this._list[num], record.DataItem))
					{
						this._list.RemoveAt(num);
					}
					else
					{
						num = -1;
						if (record.DataItem != null)
						{
							num = this._list.IndexOf(record.DataItem);
							if (num >= 0)
							{
								this._list.RemoveAt(num);
							}
						}
					}
					if (num >= 0 && !record.IsDeleted)
					{
						int num2 = this._unsortedRecords.IndexOf(record);
						if (num2 >= 0)
						{
							this.RemoveRecordHelper(num2);
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				this.DataPresenter.RaiseDataError(record, null, ex, global::Infragistics.Windows.DataPresenter.DataErrorOperation.RecordDelete, global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("DataErrorDeleteRecordUnableToDelete", new object[]
				{
					ex.Message
				}));
			}
			finally
			{
				this._recordBeingDeleted = null;
			}
		}

		// Token: 0x0600262B RID: 9771 RVA: 0x000A3A88 File Offset: 0x000A1C88
		internal static void DirtySummaryResults(global::Infragistics.Windows.DataPresenter.Record recordContext, global::Infragistics.Windows.DataPresenter.Field fieldContext, global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordsContext, global::Infragistics.Windows.DataPresenter.RecordManager recordManagerContext)
		{
			if (recordManagerContext != null && recordManagerContext._sortedFieldsToCollectionViewSynchronizer != null && recordManagerContext._sortedFieldsToCollectionViewSynchronizer.IsUpdatingCollectionView)
			{
				return;
			}
			if (recordContext != null && recordsContext == null)
			{
				recordsContext = recordContext.ParentCollection;
			}
			if (recordsContext != null)
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord;
				for (global::Infragistics.Windows.DataPresenter.RecordCollectionBase recordCollectionBase = recordsContext; recordCollectionBase != null; recordCollectionBase = ((parentRecord != null) ? parentRecord.ParentCollection : null))
				{
					global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResultsIfAllocated = recordCollectionBase.SummaryResultsIfAllocated;
					if (summaryResultsIfAllocated != null)
					{
						summaryResultsIfAllocated.DirtyAffectedSummariesAsync(fieldContext, recordsContext.FieldLayout);
					}
					parentRecord = recordCollectionBase.ParentRecord;
				}
				return;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldLayout(recordContext, fieldContext, recordsContext, recordManagerContext);
			global::Infragistics.Windows.DataPresenter.SummaryDefinitionCollection summaryDefinitionCollection = (fieldLayout != null) ? fieldLayout.SummaryDefinitionsIfAllocated : null;
			if (summaryDefinitionCollection != null)
			{
				summaryDefinitionCollection.BumpDataVersion();
			}
		}

		// Token: 0x0600262C RID: 9772 RVA: 0x000A3B15 File Offset: 0x000A1D15
		internal static bool DoesBindingListSupportAddNew(global::System.ComponentModel.IBindingList bindingList, bool canGetPropertiesFromDataSourceWithoutItems)
		{
			return bindingList != null && bindingList.AllowNew && (canGetPropertiesFromDataSourceWithoutItems || bindingList.Count > 0);
		}

		// Token: 0x0600262D RID: 9773 RVA: 0x000A3B34 File Offset: 0x000A1D34
		internal void EndUpdate(bool dirtyScrollCount)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation beginUpdateInfo = this._beginUpdateInfo;
			if (beginUpdateInfo != null)
			{
				if (dirtyScrollCount)
				{
					beginUpdateInfo._dirtyScrollCount = true;
				}
				beginUpdateInfo._beginUpdateCount--;
				if (beginUpdateInfo._beginUpdateCount == 0)
				{
					if (beginUpdateInfo._dirtyScrollCount)
					{
						this._scrollCountVersion++;
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
						global::Infragistics.Windows.DataPresenter.MainRecordSparseArray mainRecordSparseArray = (viewableRecords != null) ? viewableRecords.RecordCollectionSparseArray : null;
						if (mainRecordSparseArray != null)
						{
							mainRecordSparseArray.DirtyScrollCount();
						}
					}
					this._beginUpdateInfo = null;
					beginUpdateInfo.ProcessPendingNotifications();
				}
			}
		}

		// Token: 0x0600262E RID: 9774 RVA: 0x000A3BAB File Offset: 0x000A1DAB
		internal object GetAddRecordCellData(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._addRecordCellDataDictionary != null && this._addRecordCellDataDictionary.Count > 0 && this._addRecordCellDataDictionary.Contains(field))
			{
				return this._addRecordCellDataDictionary[field];
			}
			return null;
		}

		// Token: 0x0600262F RID: 9775 RVA: 0x000A3BE0 File Offset: 0x000A1DE0
		internal global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecordInternal(global::Infragistics.Windows.DataPresenter.Record record)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this._dataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
			if (dataPresenterExportControlBase == null)
			{
				return null;
			}
			if (dataPresenterExportControlBase.ReportVersion != this._reportVersion)
			{
				this._associatedRecordMap = null;
			}
			if (this._associatedRecordMap == null)
			{
				this._associatedRecordMap = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.Record>((int)((double)this._unsortedRecords.Count * 1.5));
				global::Infragistics.Windows.DataPresenter.RecordManager associatedRecordManager = this.AssociatedRecordManager;
				if (associatedRecordManager == null)
				{
					return null;
				}
				int count = this._unsortedRecords.Count;
				if (associatedRecordManager.DataSource != associatedRecordManager.DataPresenter.DataSourceInternal)
				{
					associatedRecordManager.DataPresenter.VerifyRecordManagerDataSource();
				}
				if (associatedRecordManager.IsResetPending)
				{
					associatedRecordManager.OnSourceCollectionReset();
				}
				if (associatedRecordManager._unsortedRecords.Count == 0)
				{
					return null;
				}
				if (count != associatedRecordManager._unsortedRecords.Count)
				{
					return null;
				}
				for (int i = 0; i < count; i++)
				{
					this._associatedRecordMap[this._unsortedRecords[i]] = associatedRecordManager._unsortedRecords[i];
				}
				this.VerifySort();
				associatedRecordManager.VerifySort();
				if (this.HasGroups && associatedRecordManager.HasGroups)
				{
					this.MapAssociatedGroupByRecords(this.Groups, associatedRecordManager.Groups);
				}
			}
			global::Infragistics.Windows.DataPresenter.Record result;
			this._associatedRecordMap.TryGetValue(record, out result);
			return result;
		}

		// Token: 0x06002630 RID: 9776 RVA: 0x000A3D14 File Offset: 0x000A1F14
		internal void InitializeAddRecordCellValuesFromCache(global::Infragistics.Windows.DataPresenter.DataRecord addRecord)
		{
			if (this._currentAddRecord == addRecord && this._addRecordCellDataDictionary != null && this._addRecordCellDataDictionary.Count > 0)
			{
				global::System.Collections.Generic.List<global::System.Collections.DictionaryEntry> list = new global::System.Collections.Generic.List<global::System.Collections.DictionaryEntry>(this._addRecordCellDataDictionary.Count);
				foreach (object obj in this._addRecordCellDataDictionary)
				{
					global::System.Collections.DictionaryEntry item = (global::System.Collections.DictionaryEntry)obj;
					list.Add(item);
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = addRecord.FieldLayout;
				foreach (global::System.Collections.DictionaryEntry dictionaryEntry in list)
				{
					global::Infragistics.Windows.DataPresenter.Field field = (global::Infragistics.Windows.DataPresenter.Field)dictionaryEntry.Key;
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = (field != null) ? field.Owner : null;
					if (fieldLayout2 == null || fieldLayout2 != fieldLayout)
					{
						if (fieldLayout2 == null || this._dataPresenter.FieldLayouts.Contains(fieldLayout2))
						{
							this._addRecordCellDataDictionary.Remove(field);
						}
					}
					else
					{
						addRecord.SetCellValue(field, dictionaryEntry.Value, false);
					}
				}
			}
		}

		// Token: 0x06002631 RID: 9777 RVA: 0x000A3E4C File Offset: 0x000A204C
		private void InsertRecord(int index, int sortedIndex, global::Infragistics.Windows.DataPresenter.DataRecord record, bool notifyListeners)
		{
			if (notifyListeners)
			{
				this._unsortedRecords.InsertRecord(index, record);
				this._sortedRecords.InsertRecord(sortedIndex, record);
				base.RaisePropertyChangedEvent("Unsorted");
			}
			else
			{
				this._unsortedRecords.SparseArray.Insert(index, record);
				this._sortedRecords.SparseArray.Insert(sortedIndex, record);
			}
			if (this._groups != null && this._groups.Count > 0)
			{
				this._groups.ViewableRecords.InsertDataRecordInGroupBySlot(record);
			}
		}

		// Token: 0x06002632 RID: 9778 RVA: 0x000A3ED0 File Offset: 0x000A20D0
		internal bool IsFixedRecord(global::Infragistics.Windows.DataPresenter.Record record)
		{
			switch (this.AddNewRecordLocation)
			{
			case global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTopFixed:
			case global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnBottomFixed:
				return this._currentAddRecord == record;
			}
			return false;
		}

		// Token: 0x06002633 RID: 9779 RVA: 0x000A3F05 File Offset: 0x000A2105
		internal void OnCellValueChangeNotification(global::Infragistics.Windows.DataPresenter.DataRecord record, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnChangeNotification(record, e, false);
		}

		// Token: 0x06002634 RID: 9780 RVA: 0x000A3F10 File Offset: 0x000A2110
		internal void OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType dataChangeType, global::Infragistics.Windows.DataPresenter.DataRecord recordContext, global::Infragistics.Windows.DataPresenter.Field fieldContext)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = global::Infragistics.Windows.DataPresenter.GridUtilities.GetFieldLayout(recordContext, fieldContext, null, this);
			if (fieldLayout == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager.DirtySummaryResults(recordContext, fieldContext, null, this);
			this.OnDataChanged_DirtyFiltersHelper(dataChangeType, fieldLayout, recordContext, fieldContext);
			this.NotifyCalcAdapterHelper(dataChangeType, recordContext, fieldContext);
			fieldLayout.AutoSizeInfo.OnDataChanged(dataChangeType, recordContext, fieldContext, this);
		}

		// Token: 0x06002635 RID: 9781 RVA: 0x000A3F58 File Offset: 0x000A2158
		internal void OnDataChanged_DirtyFiltersHelper(global::Infragistics.Windows.DataPresenter.DataChangeType dataChangeType, global::Infragistics.Windows.DataPresenter.FieldLayout fl, global::Infragistics.Windows.DataPresenter.DataRecord recordContext, global::Infragistics.Windows.DataPresenter.Field fieldContext)
		{
			global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection recordFiltersResolved = this._recordFiltersResolved;
			if (recordFiltersResolved != null)
			{
				bool flag = false;
				if (dataChangeType == global::Infragistics.Windows.DataPresenter.DataChangeType.Reset)
				{
					if (this._sortedFieldsToCollectionViewSynchronizer == null || !this._sortedFieldsToCollectionViewSynchronizer.IsUpdatingCollectionView)
					{
						flag = true;
					}
				}
				else if (fl.ReevaluateFiltersOnDataChangeResolved)
				{
					if (global::Infragistics.Windows.DataPresenter.DataChangeType.CellDataChange == dataChangeType || global::Infragistics.Windows.DataPresenter.DataChangeType.RecordDataChange == dataChangeType)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
						global::Infragistics.Windows.DataPresenter.Record record = (dataPresenter != null) ? dataPresenter.ActiveRecordInternal : null;
						if (recordContext != null && record == recordContext)
						{
							global::Infragistics.Windows.DataPresenter.Record activeRecordWithPendingDirtyFilterState = dataPresenter._activeRecordWithPendingDirtyFilterState;
							if (activeRecordWithPendingDirtyFilterState != null && activeRecordWithPendingDirtyFilterState != record)
							{
								activeRecordWithPendingDirtyFilterState.DirtyFilterState();
							}
							dataPresenter._activeRecordWithPendingDirtyFilterState = recordContext;
						}
						else
						{
							if (recordFiltersResolved.DoesFilterCriteriaUseAllValues(fieldContext, recordContext))
							{
								flag = true;
							}
							if (!flag && recordContext != null && recordContext.HasFilterCriteriaBeenApplied)
							{
								recordContext.DirtyFilterState();
							}
						}
					}
					else if ((global::Infragistics.Windows.DataPresenter.DataChangeType.AddRecord == dataChangeType || global::Infragistics.Windows.DataPresenter.DataChangeType.RemoveRecord == dataChangeType) && recordFiltersResolved.DoesFilterCriteriaUseAllValues(fieldContext, recordContext))
					{
						flag = true;
					}
				}
				if (flag)
				{
					recordFiltersResolved.BumpVersion();
				}
			}
		}

		// Token: 0x06002636 RID: 9782 RVA: 0x000A4024 File Offset: 0x000A2224
		internal void OnDataItemRemoved(global::Infragistics.Windows.DataPresenter.DataRecord rcd, object dataItem)
		{
			if (this._list.Count == this._unsortedRecords.Count)
			{
				return;
			}
			int num = this._unsortedRecords.SparseArray.IndexOf(rcd);
			if (num >= 0)
			{
				this.RemoveAt(num);
			}
		}

		// Token: 0x06002637 RID: 9783 RVA: 0x000A4068 File Offset: 0x000A2268
		internal void OnIsNestedDataDisplayEnabledChanged()
		{
			if (this._currentAddRecord != null)
			{
				this._currentAddRecord.OnIsNestedDataDisplayEnabledChanged();
			}
			if (this._unsortedRecords.Count == 0)
			{
				return;
			}
			foreach (object obj in this._unsortedRecords.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)obj;
				dataRecord.OnIsNestedDataDisplayEnabledChanged();
			}
		}

		// Token: 0x06002638 RID: 9784 RVA: 0x000A40EC File Offset: 0x000A22EC
		internal void PrepareForNewCurrentAddRecord()
		{
			this._currentAddRecord = null;
			if (this._addRecordCellDataDictionary != null)
			{
				this._addRecordCellDataDictionary.Clear();
			}
			this.BumpUnderlyingDataVersion();
			if (this._sortedRecords != null)
			{
				this._sortedRecords.ViewableRecords.DirtySpecialRecords(true);
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x000A4128 File Offset: 0x000A2328
		internal void ProcessQueuedChangeNotifications(bool calledFromDelayedChange)
		{
			this._dataPresenter.VerifyAccess();
			if (this._inProcessQueuedChangs)
			{
				return;
			}
			this._inProcessQueuedChangs = true;
			try
			{
				lock (this._asyncChangeList.SyncRoot)
				{
					global::System.Collections.ArrayList asyncChangeList = this._asyncChangeList;
					if (this._processAsyncChangeList == null)
					{
						this._processAsyncChangeList = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification>(asyncChangeList.Count);
						this._processAsyncChangeListSet = new global::Infragistics.Windows.Helpers.HashSet(asyncChangeList.Count, 0.8f, new global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification.EqualityComparer());
					}
					int i = 0;
					int count = asyncChangeList.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification item = asyncChangeList[i] as global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification;
						if (!this._processAsyncChangeListSet.Contains(item))
						{
							this._processAsyncChangeList.Add(item);
							this._processAsyncChangeListSet.Add(item);
						}
						i++;
					}
					asyncChangeList.Clear();
				}
				if (this._processAsyncChangeList != null)
				{
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification> processAsyncChangeList = this._processAsyncChangeList;
					global::System.DateTime now = global::System.DateTime.Now;
					int num = -1;
					for (int j = 0; j < processAsyncChangeList.Count; j++)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification changeNotification = processAsyncChangeList[j];
						num = j;
						this._processAsyncChangeListSet.Remove(changeNotification);
						this.ProcessChangeNotification(changeNotification.Sender, changeNotification.EventArgs);
						if (calledFromDelayedChange && j % 50 == 0 && (global::System.DateTime.Now - now).TotalMilliseconds > 50.0)
						{
							break;
						}
					}
					processAsyncChangeList.RemoveRange(0, 1 + num);
				}
			}
			finally
			{
				if ((this._processAsyncChangeList != null && this._processAsyncChangeList.Count > 0) || global::Infragistics.Windows.DataPresenter.GridUtilities.GetSyncLockedCount(this._asyncChangeList) > 0)
				{
					this._asyncChangePending = this._dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnDelayedChange));
				}
				else
				{
					this._asyncChangePending = null;
				}
				this._inProcessQueuedChangs = false;
			}
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000A4324 File Offset: 0x000A2524
		internal void RemoveAt(int index)
		{
			this.RemoveAt(index, true);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000A4330 File Offset: 0x000A2530
		private void RemoveAt(int index, bool notifyListeners)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._unsortedRecords.SparseArray.GetItem(index, false) as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (this._unsortedRecords.Count > 0)
			{
				if (notifyListeners)
				{
					if (dataRecord != null)
					{
						this._unsortedRecords.RemoveRecord(dataRecord);
					}
					else
					{
						this._unsortedRecords.RemoveAt(index);
					}
					base.RaisePropertyChangedEvent("Unsorted");
				}
				else
				{
					this._unsortedRecords.SparseArray.RemoveAt(index);
				}
			}
			if (this._sortedRecords != null && this._sortedRecords.Count > 0)
			{
				if (dataRecord != null)
				{
					this._sortedRecords.ViewableRecords.RemoveRecord(dataRecord, notifyListeners);
				}
				else
				{
					this._sortedRecords.ViewableRecords.RemoveRecordAtUnsortedIndex(index, notifyListeners);
				}
			}
			if (this._groups != null && this._groups.Count > 0 && dataRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = dataRecord.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null)
				{
					groupByRecord.ChildRecords.ViewableRecords.RemoveRecord(dataRecord, notifyListeners);
				}
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x000A4420 File Offset: 0x000A2620
		internal void ReselectRecordAtSortedIndex(int index)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			int count = this._sortedRecords.Count;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			if (index >= 0 && index < count)
			{
				record = this._sortedRecords[index];
			}
			else if (count > 0)
			{
				record = this._sortedRecords[count - 1];
			}
			if (record != null && record.IsActivatable)
			{
				dataPresenter.ActiveRecord = record;
				return;
			}
			if (record == null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._sortedRecords.ViewableRecords;
				int count2 = viewableRecords.Count;
				for (int i = count2 - 1; i >= 0; i--)
				{
					record = viewableRecords[i];
					if (record.IsActivatable)
					{
						dataPresenter.ActiveRecord = record;
						return;
					}
				}
				record = null;
			}
			if (record == null)
			{
				record = this._parentRecord;
			}
			if (record != null)
			{
				bool flag = false;
				int overallScrollPosition = record.GetOverallScrollPosition(true, ref flag);
				record = global::Infragistics.Windows.DataPresenter.RecordManager.GetActivatableRecordFromScrollPos(dataPresenter, overallScrollPosition, true);
				if (record != null && record.IsActivatable)
				{
					dataPresenter.ActiveRecord = record;
					return;
				}
				record = global::Infragistics.Windows.DataPresenter.RecordManager.GetActivatableRecordFromScrollPos(dataPresenter, overallScrollPosition, false);
				if (record != null && record.IsActivatable)
				{
					dataPresenter.ActiveRecord = record;
				}
			}
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x000A4518 File Offset: 0x000A2718
		internal void SetAddRecordCellData(global::Infragistics.Windows.DataPresenter.Field field, object newValue)
		{
			if (this._addRecordCellDataDictionary == null)
			{
				this._addRecordCellDataDictionary = new global::System.Collections.Specialized.HybridDictionary();
			}
			if (this._addRecordCellDataDictionary.Contains(field))
			{
				this._addRecordCellDataDictionary[field] = newValue;
				return;
			}
			this._addRecordCellDataDictionary.Add(field, newValue);
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x000A4556 File Offset: 0x000A2756
		internal void SetActiveRecordFromCurrentItem()
		{
			this.SetActiveRecordFromCurrentItem(false);
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000A4560 File Offset: 0x000A2760
		private void SetActiveRecordFromCurrentItem(bool calledFromCurrentItemChanged)
		{
			if (this._dataPresenter == null || this._collectionView == null || !this._dataPresenter.IsInitialized || !this._dataPresenter.IsSynchronizedWithCurrentItem)
			{
				return;
			}
			if (this._parentRecord != null && (!calledFromCurrentItemChanged || !this.IsInActiveRecordChain))
			{
				return;
			}
			if (this._isSynchronizingWithCurrentItem)
			{
				return;
			}
			this._isSynchronizingWithCurrentItem = true;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
			try
			{
				if (this._resetOperationPending != null)
				{
					this.OnSourceCollectionReset();
				}
				if (!this.SetActiveRecordFromCurrentItemHelper(out dataRecord))
				{
					return;
				}
			}
			finally
			{
				this._isSynchronizingWithCurrentItem = false;
			}
			if (dataRecord == this._dataPresenter.ActiveRecord || (dataRecord != null && this._dataPresenter.ActiveRecord != null && dataRecord.IsAncestorOf(this._dataPresenter.ActiveRecord)))
			{
				if (dataRecord != null)
				{
					this._dataPresenter.BringRecordIntoView(dataRecord);
					return;
				}
			}
			else
			{
				if (calledFromCurrentItemChanged)
				{
					this._dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.RecordManager.BoolReturnMethodDelegate(this.SetCurrentItemFromActiveRecord));
					return;
				}
				this.SetCurrentItemFromActiveRecord();
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000A4660 File Offset: 0x000A2860
		private bool SetActiveRecordFromCurrentItemHelper(out global::Infragistics.Windows.DataPresenter.DataRecord dr)
		{
			dr = null;
			int collectionViewCurrentPosition = this.CollectionViewCurrentPosition;
			if (collectionViewCurrentPosition < 0 || collectionViewCurrentPosition >= this._unsortedRecords.Count)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._dataPresenter.ActiveRecord as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null && !dataRecord.IsAddRecord)
				{
					this._dataPresenter.ActiveRecord = ((this._parentRecord != null) ? this._parentRecord.ParentDataRecord : null);
					return true;
				}
				return false;
			}
			else
			{
				if (collectionViewCurrentPosition > this._unsortedRecords.Count)
				{
					return false;
				}
				dr = this._unsortedRecords[collectionViewCurrentPosition];
				global::Infragistics.Windows.DataPresenter.Record activeRecord = this._dataPresenter.ActiveRecord;
				if (activeRecord == null || (dr != activeRecord && !dr.IsAncestorOf(activeRecord)))
				{
					this._dataPresenter.ActiveRecord = dr;
				}
				return true;
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x000A4714 File Offset: 0x000A2914
		internal bool SetCurrentItemFromActiveRecord()
		{
			if (this._dataPresenter == null || this._collectionView == null || !this._dataPresenter.IsInitialized || !this._dataPresenter.IsSynchronizedWithCurrentItem)
			{
				return true;
			}
			if (this._isSynchronizingWithCurrentItem)
			{
				return true;
			}
			this._isSynchronizingWithCurrentItem = true;
			bool result;
			try
			{
				int activeDataRecordUnsortedIndex = this.ActiveDataRecordUnsortedIndex;
				if (this._collectionViewWrapper != null)
				{
					this._collectionViewWrapper.MoveCurrentToPosition(activeDataRecordUnsortedIndex);
				}
				else
				{
					this._collectionView.MoveCurrentToPosition(activeDataRecordUnsortedIndex);
				}
				if (!this.IsInSyncWithCurrentPosition)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
					this.SetActiveRecordFromCurrentItemHelper(out dataRecord);
					result = false;
				}
				else
				{
					result = true;
				}
			}
			finally
			{
				this._isSynchronizingWithCurrentItem = false;
			}
			return result;
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x000A47BC File Offset: 0x000A29BC
		internal global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker TrackSortGroupVersionNumberChanges(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker sortGroupVersionTracker;
			if (this._sortGroupByVersionTrackers.TryGetValue(fl, out sortGroupVersionTracker))
			{
				return sortGroupVersionTracker;
			}
			sortGroupVersionTracker = new global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker(this, fl);
			this._sortGroupByVersionTrackers.Add(fl, sortGroupVersionTracker);
			if (this._trackSortGroupOperationPending == null && this._dataPresenter != null && fl.HasSortedFields)
			{
				this._trackSortGroupOperationPending = this._dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnSortGroupByVersionChanged));
			}
			return sortGroupVersionTracker;
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x000A482D File Offset: 0x000A2A2D
		internal void UnwireCollectionViewEvents()
		{
			if (this._collectionView != null)
			{
				global::System.ComponentModel.CurrentChangingEventManager.RemoveListener(this._collectionView, this);
				global::System.ComponentModel.CurrentChangedEventManager.RemoveListener(this._collectionView, this);
			}
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x000A4850 File Offset: 0x000A2A50
		internal void UpdateRecordsWithPendingChanges(bool discardChanges, bool recursive)
		{
			if (this._currentAddRecord != null && this._currentAddRecord.DataItem != null)
			{
				this._currentAddRecord.ProcessPendingChanges(discardChanges, false);
			}
			foreach (object obj in this.Sorted.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)obj;
				dataRecord.ProcessPendingChanges(discardChanges, recursive);
			}
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000A48D8 File Offset: 0x000A2AD8
		private void SortByFieldLayout(global::Infragistics.Windows.DataPresenter.Record[] records, out int[] segments)
		{
			int i = 0;
			global::System.Collections.Generic.List<int> list = new global::System.Collections.Generic.List<int>(4);
			while (i < records.Length)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = records[i].FieldLayout;
				i++;
				for (int j = i; j < records.Length; j++)
				{
					global::Infragistics.Windows.DataPresenter.Record record = records[j];
					if (fieldLayout == record.FieldLayout)
					{
						if (j != i)
						{
							records[j] = records[i];
							records[i] = record;
						}
						i++;
					}
				}
				list.Add(i);
			}
			segments = list.ToArray();
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000A4944 File Offset: 0x000A2B44
		private void SortHelper(global::Infragistics.Windows.DataPresenter.Record[] records, bool hasGroupByFields, out bool hasMultipleFieldLayouts, bool areRecordsInUnsortedOrder)
		{
			int[] array;
			this.SortByFieldLayout(records, out array);
			hasMultipleFieldLayouts = (array.Length > 1);
			global::Infragistics.Windows.DataPresenter.Record[] tempArray = new global::Infragistics.Windows.DataPresenter.Record[records.Length];
			for (int i = 0; i < array.Length; i++)
			{
				int num = (i > 0) ? array[i - 1] : 0;
				int num2 = array[i] - 1;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = records[num].FieldLayout;
				global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer comparer = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer(fieldLayout, 1 + num2 - num, areRecordsInUnsortedOrder);
				global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.DataPresenter.Record>(records, tempArray, comparer, num, num2);
			}
			if (!hasGroupByFields && (!hasMultipleFieldLayouts || !this._dataPresenter.SortRecordsByDataType))
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.MoveFixedRecords(records);
				if (this._fieldLayout != null && this._fieldLayout.FixedRecordSortOrderResolved == global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Sorted)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
					if (viewableRecords != null)
					{
						viewableRecords.RefreshSortOrderOfFixedRecords();
					}
				}
			}
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x000A4A04 File Offset: 0x000A2C04
		internal bool VerifySort()
		{
			if (this.IsInVerifySort)
			{
				return false;
			}
			if (this._field != null && !this._field.IsExpandableByDefault)
			{
				return false;
			}
			bool flag = false;
			bool flag2 = false;
			if (this.DataPresenter != null)
			{
				this.ProcessQueuedChangeNotifications(false);
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this.DataPresenter.CurrentViewInternal;
				flag2 = (currentViewInternal != null && currentViewInternal.IsGroupBySupported);
			}
			if (this._isGroupBySupported != flag2)
			{
				if (!flag2)
				{
					if (this.HasGroups)
					{
						this._unsortedRecordsDirty = true;
					}
				}
				else
				{
					this._unsortedRecordsDirty = true;
				}
				this._isGroupBySupported = flag2;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionStatus sortGroupByVersionStatus = this.GetSortGroupByVersionStatus();
			if (this._unsortedRecordsDirty)
			{
				this._unsortedRecordsDirty = false;
			}
			else if (this._fieldLayout != null)
			{
				if (!sortGroupByVersionStatus.IsSortVersionChanged && !sortGroupByVersionStatus.IsGroupByVersionChanged)
				{
					return false;
				}
				if (this.HasGroups && !sortGroupByVersionStatus.IsGroupByVersionChanged)
				{
					this.SyncSortGroupByVersions();
					if (this._parentRecord == null || this._parentRecord.IsExpanded)
					{
						this.Groups.VerifySortOrder(true);
					}
					flag = true;
				}
			}
			this._hasMultipleFieldLayouts = false;
			bool isSorted = this._isSorted;
			this.IsInVerifySort = true;
			bool flag3 = true;
			if (this._sortedRecords.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._unsortedRecords[0].FieldLayout;
				sortGroupByVersionStatus = this.GetSortGroupByVersionStatus();
				this._isSorted = false;
				this.InitializeFieldLayout(fieldLayout);
				bool flag4 = this.DataPresenter.SortRecordsByDataType || sortGroupByVersionStatus.HasSortFields;
				if (flag4)
				{
					if (!this.SortViaCollectionViewHelper() && global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Auto == this.SortEvaluationModeResolved)
					{
						this._isSorted = true;
						this._sortedRecords.BeginUpdate();
						bool hasMultipleFieldLayouts;
						try
						{
							global::Infragistics.Windows.DataPresenter.Record[] array = this._unsortedRecords.SparseArray.ToArray(true);
							this.SortHelper(array, sortGroupByVersionStatus.HasGroupByFields, out hasMultipleFieldLayouts, true);
							this._sortedRecords.SparseArray.Clear();
							this._sortedRecords.SparseArray.AddRange(array);
							if (!sortGroupByVersionStatus.HasGroupByFields)
							{
								this._sortedRecords.ViewableRecords.VerifyFixedRecordLists();
							}
						}
						finally
						{
							this._sortedRecords.EndUpdate(false);
						}
						this._hasMultipleFieldLayouts = hasMultipleFieldLayouts;
					}
					sortGroupByVersionStatus = this.GetSortGroupByVersionStatus();
				}
				else
				{
					if (isSorted && this._sortedRecords.SparseArray.Count > 1)
					{
						this._sortedRecords.BeginUpdate();
						try
						{
							this._sortedRecords.SparseArray.Sort(new global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer(true));
						}
						finally
						{
							if (this._fieldLayout != null && this._fieldLayout.FixedRecordSortOrderResolved == global::Infragistics.Windows.DataPresenter.FixedRecordSortOrder.Sorted)
							{
								this._sortedRecords.ViewableRecords.DirtyFixedRecordOrder();
							}
							this._sortedRecords.EndUpdate(false);
						}
					}
					this._isSorted = false;
				}
				if (flag)
				{
					flag3 = false;
				}
				else if (this._isGroupBySupported && ((this._hasMultipleFieldLayouts && this.DataPresenter.SortRecordsByDataType) || sortGroupByVersionStatus.HasGroupByFields))
				{
					if (global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.UseCollectionView == this.GroupByEvaluationModeResolved && sortGroupByVersionStatus.HasGroupByFields)
					{
						this.SortViaCollectionViewHelper();
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.DataRecord[] records = this._sortedRecords.SparseArray.ToArray(true, typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord[];
						if (!this._isSorted)
						{
							bool flag5;
							this.SortHelper(records, true, out flag5, !isSorted);
						}
						this.Groups.CreateGroupByRecordsHelper(records);
						this.Groups.RaiseChangeEvents(true);
					}
					flag3 = false;
				}
			}
			else
			{
				this._isSorted = false;
			}
			this.SyncSortGroupByVersions();
			if (flag3 && this._groups != null && this._groups.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.Record record in this._sortedRecords)
				{
					record.InitializeParentCollection(this._sortedRecords);
				}
				this._groups.Clear();
				this._groups.RaiseChangeEvents(true);
			}
			this.IsInVerifySort = false;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
			if (viewableRecords != null)
			{
				viewableRecords.DirtySpecialRecords(false);
			}
			global::Infragistics.Windows.DataPresenter.SummaryResultCollection summaryResultCollection = (this._sortedRecords != null) ? this._sortedRecords.SummaryResultsIfAllocated : null;
			if (summaryResultCollection != null)
			{
				summaryResultCollection.RefreshSummariesAffectedBySort();
			}
			base.RaisePropertyChangedEvent("Current");
			base.RaisePropertyChangedEvent("Sorted");
			if (this._parentRecord != null)
			{
				this._parentRecord.OnViewableChildRecordsChanged();
			}
			if (this._sortedRecords != null)
			{
				this._sortedRecords.RaiseChangeEvents(true);
			}
			if (this._isInitializingDataSource)
			{
				this._isInitializingDataSource = false;
			}
			else if (this._fieldLayout != null)
			{
				this._fieldLayout.BumpSortOperationVersion();
			}
			return true;
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x000A4E70 File Offset: 0x000A3070
		internal void WireCollectionViewEvents()
		{
			if (this._collectionView != null)
			{
				global::System.ComponentModel.CurrentChangingEventManager.AddListener(this._collectionView, this);
				global::System.ComponentModel.CurrentChangedEventManager.AddListener(this._collectionView, this);
			}
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x000A4E92 File Offset: 0x000A3092
		private void BumpUnderlyingDataVersion()
		{
			this._underlyingDataVersion++;
			base.RaisePropertyChangedEvent("UnderlyingDataVersion");
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000A4EB0 File Offset: 0x000A30B0
		private void CleanupUnusedSortGroupByVersionTrackers()
		{
			this._cleanupTrackersOperationPending = null;
			if (this._unsortedRecords.Count == 0)
			{
				this._sortGroupByVersionTrackers.Clear();
				return;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionStatus sortGroupByVersionStatus = this.GetSortGroupByVersionStatus();
			int count = this._sortGroupByVersionTrackers.Count;
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.FieldLayout> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.FieldLayout>();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
			foreach (object obj in this._unsortedRecords.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)obj;
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = record.FieldLayout;
				if (fieldLayout2 != fieldLayout)
				{
					if (count == 1 && this._sortGroupByVersionTrackers.ContainsKey(fieldLayout2))
					{
						return;
					}
					fieldLayout = fieldLayout2;
					if (!dictionary.ContainsKey(fieldLayout2))
					{
						dictionary.Add(fieldLayout2, fieldLayout2);
					}
				}
			}
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FieldLayout>(this._sortGroupByVersionTrackers.Keys);
			bool flag = false;
			foreach (global::Infragistics.Windows.DataPresenter.FieldLayout key in list)
			{
				if (!dictionary.ContainsKey(key))
				{
					this._sortGroupByVersionTrackers.Remove(key);
					flag = true;
				}
			}
			if (flag && sortGroupByVersionStatus.HasGroupByFields)
			{
				if (this._sortGroupByVersionTrackers.Count > 0)
				{
					foreach (global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker sortGroupVersionTracker in this._sortGroupByVersionTrackers.Values)
					{
						sortGroupVersionTracker.DirtyVersionNumbers();
					}
				}
				this.VerifySort();
			}
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000A5060 File Offset: 0x000A3260
		private void ClearAddRecordOnDataSourceChange()
		{
			if (this._currentAddRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._sortedRecords.ViewableRecords;
				this._currentAddRecord = null;
				if (viewableRecords != null)
				{
					viewableRecords.DirtySpecialRecords(false);
				}
			}
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x000A5094 File Offset: 0x000A3294
		private void ClearCachedRecordsOnTop()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._sortedRecords.ViewableRecords;
			if (viewableRecords != null)
			{
				viewableRecords.ClearCachedRecordsOnTop();
			}
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x000A50B6 File Offset: 0x000A32B6
		private bool DoesTypeSupportEditInList()
		{
			return !this._typeIsKnownType || (this._list != null && !this._list.IsReadOnly);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000A50D8 File Offset: 0x000A32D8
		private static global::Infragistics.Windows.DataPresenter.Record GetActivatableRecordFromScrollPos(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, int scrollpos, bool dataRecordsOnly)
		{
			if (scrollpos >= 0)
			{
				for (int i = scrollpos; i < ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)dp).OverallScrollCount; i++)
				{
					global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)dp).GetRecordAtOverallScrollPosition(i);
					if (recordAtOverallScrollPosition != null && (!dataRecordsOnly || recordAtOverallScrollPosition.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord) && recordAtOverallScrollPosition.IsActivatable)
					{
						return recordAtOverallScrollPosition;
					}
				}
			}
			scrollpos--;
			if (scrollpos >= 0)
			{
				for (int j = scrollpos; j >= 0; j--)
				{
					global::Infragistics.Windows.DataPresenter.Record recordAtOverallScrollPosition = ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)dp).GetRecordAtOverallScrollPosition(j);
					if (recordAtOverallScrollPosition != null && (!dataRecordsOnly || recordAtOverallScrollPosition.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord) && recordAtOverallScrollPosition.IsActivatable)
					{
						return recordAtOverallScrollPosition;
					}
				}
			}
			return null;
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000A5154 File Offset: 0x000A3354
		private global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider GetPropertyDescriptorProvider()
		{
			if (this._unsortedRecords != null && this._unsortedRecords.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
				using (global::System.Collections.IEnumerator enumerator = this._unsortedRecords.SparseArray.NonNullItems.GetEnumerator())
				{
					if (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						dataRecord = (obj as global::Infragistics.Windows.DataPresenter.DataRecord);
					}
				}
				if (dataRecord != null)
				{
					return dataRecord.PropertyDescriptorProvider;
				}
			}
			return this._typedListDefaultProvider;
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000A51DC File Offset: 0x000A33DC
		private global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionStatus GetSortGroupByVersionStatus()
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			if (this._sortGroupByVersionTrackers != null && this._sortGroupByVersionTrackers.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker sortGroupVersionTracker in this._sortGroupByVersionTrackers.Values)
				{
					if (sortGroupVersionTracker != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = sortGroupVersionTracker.FieldLayout;
						if (!flag && sortGroupVersionTracker.SortVersion != fieldLayout.SortVersion)
						{
							flag = true;
						}
						if (!flag2 && sortGroupVersionTracker.GroupByVersion != fieldLayout.GroupByVersion)
						{
							flag2 = true;
						}
						if (!flag3 && fieldLayout.HasSortedFields)
						{
							flag3 = true;
						}
						if (!flag4 && fieldLayout.HasGroupBySortFields)
						{
							flag4 = true;
						}
					}
				}
			}
			return new global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionStatus(flag, flag2, flag3, flag4);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000A52B0 File Offset: 0x000A34B0
		private void InitializeFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			if (fl != this._fieldLayout)
			{
				if (this._fieldLayout != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this.FieldLayout, this, string.Empty);
				}
				this._fieldLayout = fl;
				if (this._fieldLayout != null)
				{
					global::System.ComponentModel.PropertyChangedEventManager.AddListener(this.FieldLayout, this, string.Empty);
				}
				this._unsortedRecords.InitializeFieldLayout(this._fieldLayout);
				this._sortedRecords.InitializeFieldLayout(this._fieldLayout);
				if (this._groups != null)
				{
					this._groups.InitializeFieldLayout(this._fieldLayout);
				}
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ViewableRecords;
				if (viewableRecords != null)
				{
					viewableRecords.DirtySpecialRecords(false);
				}
				this.SortViaCollectionViewHelper();
				if (this._recordFiltersResolved != null && this._fieldLayout != null)
				{
					this._recordFiltersResolved.OnFieldLayoutAdded(this._fieldLayout);
				}
			}
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000A5378 File Offset: 0x000A3578
		private void MapAssociatedGroupByRecords(global::Infragistics.Windows.DataPresenter.RecordCollectionBase collection, global::Infragistics.Windows.DataPresenter.RecordCollectionBase associatedCollection)
		{
			if (collection == null || collection.Count == 0 || associatedCollection == null || associatedCollection.Count == 0)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
			if (collection.GroupByField != null)
			{
				if (associatedCollection.GroupByField == null)
				{
					return;
				}
				if (collection.GroupByField.Name != associatedCollection.GroupByField.Name)
				{
					return;
				}
				if (dataPresenterExportControlBase != null && dataPresenterExportControlBase.GetClonedField(associatedCollection.GroupByField) != collection.GroupByField)
				{
					return;
				}
			}
			else
			{
				if (associatedCollection.GroupByField != null)
				{
					return;
				}
				if (!(collection[0] is global::Infragistics.Windows.DataPresenter.GroupByRecord) || !(associatedCollection[0] is global::Infragistics.Windows.DataPresenter.GroupByRecord))
				{
					return;
				}
			}
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.GroupByRecord> dictionary = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.DataPresenter.GroupByRecord>(collection.Count);
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)collection))
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = record as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null)
				{
					dictionary[global::Infragistics.Windows.DataPresenter.RecordCollectionBase.GetValueKey(groupByRecord.Value)] = groupByRecord;
				}
			}
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.GroupByRecord, global::Infragistics.Windows.DataPresenter.GroupByRecord> dictionary2 = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.GroupByRecord, global::Infragistics.Windows.DataPresenter.GroupByRecord>(collection.Count + 10);
			foreach (global::Infragistics.Windows.DataPresenter.Record record2 in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)associatedCollection))
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord2 = record2 as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord2 != null)
				{
					object obj = global::Infragistics.Windows.DataPresenter.RecordCollectionBase.GetValueKey(groupByRecord2.Value);
					if (groupByRecord2.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = obj as global::Infragistics.Windows.DataPresenter.FieldLayout;
						if (fieldLayout != null && dataPresenterExportControlBase != null)
						{
							obj = dataPresenterExportControlBase.GetClonedFieldLayout(fieldLayout);
						}
					}
					global::Infragistics.Windows.DataPresenter.GroupByRecord key;
					if (dictionary.TryGetValue(obj, out key))
					{
						dictionary2.Add(key, groupByRecord2);
					}
				}
			}
			bool flag = global::Infragistics.Windows.DataPresenter.RecordCollectionBase.HasAdditionalGroupByFields(collection.FieldLayout, collection.GroupByField) && global::Infragistics.Windows.DataPresenter.RecordCollectionBase.HasAdditionalGroupByFields(associatedCollection.FieldLayout, associatedCollection.GroupByField);
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DataPresenter.GroupByRecord, global::Infragistics.Windows.DataPresenter.GroupByRecord> keyValuePair in dictionary2)
			{
				this._associatedRecordMap.Add(keyValuePair.Key, keyValuePair.Value);
				if (flag)
				{
					this.MapAssociatedGroupByRecords(keyValuePair.Key.ChildRecords, keyValuePair.Value.ChildRecords);
				}
			}
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000A55B0 File Offset: 0x000A37B0
		internal void NotifyCalcAdapterHelper(global::Infragistics.Windows.DataPresenter.DataChangeType dataChangeType, global::Infragistics.Windows.DataPresenter.DataRecord recordContext, global::Infragistics.Windows.DataPresenter.Field fieldContext)
		{
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._dataPresenter;
			global::Infragistics.Windows.DataPresenter.Calculations.IDataPresenterCalculationAdapterInternal dataPresenterCalculationAdapterInternal = (dataPresenter != null) ? dataPresenter._calculationAdapter : null;
			if (dataPresenterCalculationAdapterInternal != null)
			{
				switch (dataChangeType)
				{
				case global::Infragistics.Windows.DataPresenter.DataChangeType.Reset:
					dataPresenterCalculationAdapterInternal.OnPropertyValueChanged(this.Current, "Reset", null);
					break;
				case global::Infragistics.Windows.DataPresenter.DataChangeType.CellDataChange:
					dataPresenterCalculationAdapterInternal.OnPropertyValueChanged(recordContext, "CellValue", fieldContext);
					return;
				case global::Infragistics.Windows.DataPresenter.DataChangeType.RecordDataChange:
					dataPresenterCalculationAdapterInternal.OnPropertyValueChanged(recordContext, "Record", null);
					return;
				case global::Infragistics.Windows.DataPresenter.DataChangeType.AddRecord:
					dataPresenterCalculationAdapterInternal.OnPropertyValueChanged(recordContext, "Add", null);
					return;
				case global::Infragistics.Windows.DataPresenter.DataChangeType.RemoveRecord:
					dataPresenterCalculationAdapterInternal.OnPropertyValueChanged(recordContext, "Remove", null);
					return;
				case global::Infragistics.Windows.DataPresenter.DataChangeType.ItemMoved:
					dataPresenterCalculationAdapterInternal.OnPropertyValueChanged(this.Current, "ItemMoved", null);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000A5654 File Offset: 0x000A3854
		private void OnBindingListChanged(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			global::System.Collections.IList list = sender as global::System.Collections.IList;
			if (list != this._sourceItems && list != this._bindingList)
			{
				return;
			}
			switch (e.ListChangedType)
			{
			case global::System.ComponentModel.ListChangedType.Reset:
				if (this._firstResetProcessed)
				{
					this.OnSourceCollectionReset();
					return;
				}
				this.PostDelayedReset();
				break;
			case global::System.ComponentModel.ListChangedType.ItemAdded:
				if (this.IsResetPending)
				{
					this.OnSourceCollectionReset();
					return;
				}
				this.OnSourceCollectionAddOrRemove(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, list[e.NewIndex], e.NewIndex));
				return;
			case global::System.ComponentModel.ListChangedType.ItemDeleted:
				if (this.IsResetPending)
				{
					this.OnSourceCollectionReset();
					return;
				}
				this.OnSourceCollectionAddOrRemove(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, this._unsortedRecords.SparseArray.GetItem(e.NewIndex, false), e.NewIndex));
				return;
			case global::System.ComponentModel.ListChangedType.ItemMoved:
				if (this.IsResetPending)
				{
					this.OnSourceCollectionReset();
					return;
				}
				this.OnSourceCollectionItemMoved(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Move, this._unsortedRecords[e.OldIndex], e.NewIndex, e.OldIndex));
				return;
			case global::System.ComponentModel.ListChangedType.ItemChanged:
			{
				int newIndex = e.NewIndex;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
				if (newIndex >= 0 && newIndex < this._unsortedRecords.Count)
				{
					dataRecord = (this._unsortedRecords.SparseArray.GetItem(newIndex, false) as global::Infragistics.Windows.DataPresenter.DataRecord);
				}
				if (dataRecord == null)
				{
					return;
				}
				if (e.PropertyDescriptor == null)
				{
					if (list != null && list.Count > newIndex)
					{
						dataRecord.InitializeDataItem(list[newIndex], newIndex);
					}
					dataRecord.RefreshCellValues(true, true);
					this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.RecordDataChange, dataRecord, null);
					return;
				}
				global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = dataRecord.AssociatedRecordPresenter;
				dataRecord.RefreshCellValue(e.PropertyDescriptor.Name, true, associatedRecordPresenter != null && associatedRecordPresenter.IsDeactivated);
				return;
			}
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorAdded:
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorDeleted:
			case global::System.ComponentModel.ListChangedType.PropertyDescriptorChanged:
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider propertyDescriptorProvider = this.GetPropertyDescriptorProvider();
				if (propertyDescriptorProvider != null && propertyDescriptorProvider.FieldLayout.DataPresenter != null)
				{
					propertyDescriptorProvider.FieldLayout.DataPresenter.FieldLayouts.OnListMetaDataChanged(e, propertyDescriptorProvider.Provider);
					return;
				}
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x000A582C File Offset: 0x000A3A2C
		private void OnChangeNotification(object sender, object eventArgs, bool isReset)
		{
			if (this._dataPresenter.IsSynchronousControl)
			{
				return;
			}
			if (isReset && (!(eventArgs is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs) || this._bindingList == null || !this._bindingList.SupportsChangeNotification))
			{
				lock (this._asyncChangeList.SyncRoot)
				{
					this._asyncChangePending = null;
					this._asyncChangeList.Clear();
					this._processAsyncChangeList = null;
					this._processAsyncChangeListSet = null;
					if (this._dataPresenter.CheckAccess())
					{
						this.ProcessChangeNotification(sender, eventArgs);
						return;
					}
				}
			}
			if (this._dataPresenter.CheckAccess())
			{
				this.ProcessQueuedChangeNotifications(false);
				this.ProcessChangeNotification(sender, eventArgs);
				return;
			}
			if (!(eventArgs is global::System.ComponentModel.PropertyChangedEventArgs))
			{
				global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs = eventArgs as global::System.ComponentModel.ListChangedEventArgs;
				if (listChangedEventArgs == null || listChangedEventArgs.ListChangedType != global::System.ComponentModel.ListChangedType.ItemChanged)
				{
					throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_14"));
				}
			}
			lock (this._asyncChangeList.SyncRoot)
			{
				this._asyncChangeList.Add(new global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification(sender, eventArgs));
				if (this._asyncChangePending == null)
				{
					this._asyncChangePending = this._dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Input, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnDelayedChange));
				}
			}
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000A598C File Offset: 0x000A3B8C
		private void OnCollectionViewCurrentChanged(object sender, global::System.EventArgs e)
		{
			this.SetActiveRecordFromCurrentItem(true);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000A5998 File Offset: 0x000A3B98
		private void OnCollectionViewCurrentChanging(object sender, global::System.ComponentModel.CurrentChangingEventArgs e)
		{
			if (this._isSynchronizingWithCurrentItem)
			{
				return;
			}
			if (this._dataPresenter == null || this._collectionView == null || !this._dataPresenter.IsInitialized || !this._dataPresenter.IsSynchronizedWithCurrentItem)
			{
				return;
			}
			if (!this.IsInSyncWithCurrentPosition)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.Cell activeCell = this._dataPresenter.ActiveCell;
			if (activeCell != null && activeCell.IsInEditMode && !activeCell.Record.IsAddRecord)
			{
				activeCell.EndEditMode(true, !e.IsCancelable);
				if (activeCell.IsInEditMode && e.IsCancelable)
				{
					e.Cancel = true;
				}
			}
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x000A5A2E File Offset: 0x000A3C2E
		private void OnDelayedChange()
		{
			this.ProcessQueuedChangeNotifications(true);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x000A5A37 File Offset: 0x000A3C37
		internal void OnDelayedReset()
		{
			if (this.IsResetPending)
			{
				this.OnSourceCollectionReset();
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000A5A48 File Offset: 0x000A3C48
		private void OnFieldLayoutPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName;
			if ((propertyName = e.PropertyName) != null)
			{
				if (!(propertyName == "GroupByVersion") && !(propertyName == "SortVersion"))
				{
					return;
				}
				if (this._dataPresenter != null && this._parentRecord != null && !this._dataPresenter.IsSynchronousControl)
				{
					this._dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.RecordManager.VerifySortDelegate(this.VerifySort));
				}
			}
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000A5AB8 File Offset: 0x000A3CB8
		private void OnSourceCollectionAddOrRemove(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._sourceItems == null)
			{
				return;
			}
			global::System.Collections.IList list = null;
			int num = -1;
			if (e.NewItems != null)
			{
				list = e.NewItems;
				num = e.NewStartingIndex;
			}
			else if (e.OldItems != null)
			{
				list = e.OldItems;
				num = e.OldStartingIndex;
			}
			if (num < 0)
			{
				this.PostDelayedReset();
				return;
			}
			foreach (object obj in list)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
				int sortedIndex = num;
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
				{
					this.RemoveRecordHelper(num);
				}
				else
				{
					if (list.Count == 1)
					{
						if (this._inAddNew)
						{
							dataRecord = this.CurrentAddRecord;
							if (this.IsAddRecordOnTop)
							{
								sortedIndex = this._newRecordOnTopOffset;
							}
							switch (this.AddNewRecordLocation)
							{
							}
						}
						else
						{
							sortedIndex = this._sortedRecords.ViewableRecords.GetSortedIndexFromUnsortedIndex(num);
							global::System.Collections.IList list2 = this.List;
							if (list2 != null && this._unsortedRecords.SparseArray.Count == list2.Count)
							{
								dataRecord = this.CurrentAddRecord;
								if (dataRecord != null)
								{
									if (dataRecord.IsDataItemEqual(obj))
									{
										dataRecord.InitializeDataItem(obj, num);
									}
									this.BumpUnderlyingDataVersion();
									this._recordBeingCommitted = null;
									this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.AddRecord, dataRecord, null);
								}
								else if (num >= 0 && num < this._unsortedRecords.Count)
								{
									dataRecord = this._unsortedRecords[num];
									if (dataRecord != null && dataRecord.AssociatedRecordPresenter != null)
									{
										dataRecord.RefreshCellValues(false, true);
									}
								}
								break;
							}
							dataRecord = null;
						}
					}
					if (this._unsortedRecords.Count == 0)
					{
						this.OnSourceCollectionReset();
						break;
					}
					if (dataRecord == null)
					{
						dataRecord = global::Infragistics.Windows.DataPresenter.DataRecord.Create(this._sortedRecords, obj, false, num);
					}
					this.InsertRecord(num, sortedIndex, dataRecord, true);
					dataRecord.DirtyScrollCount();
					this.BumpUnderlyingDataVersion();
					dataRecord.FireInitializeRecord();
					num++;
					this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.AddRecord, dataRecord, null);
					if (this._dataPresenter.ScrollBehaviorOnListChange == global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange.PreserveRecordsInView && !dataRecord.IsFixed)
					{
						global::System.Windows.Controls.Primitives.IScrollInfo scrollInfo = this._dataPresenter.ScrollInfo;
						if (scrollInfo != null)
						{
							global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = this._dataPresenter.CurrentViewInternal;
							bool flag = currentViewInternal.HasLogicalOrientation && currentViewInternal.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal;
							if ((flag && scrollInfo.ExtentWidth > scrollInfo.ViewportWidth) || (!flag && scrollInfo.ExtentHeight > scrollInfo.ViewportHeight))
							{
								int scrollCountInternal = dataRecord.ScrollCountInternal;
								if (scrollCountInternal > 0 && dataRecord.OverallScrollPosition <= ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this._dataPresenter).OverallScrollPosition)
								{
									((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this._dataPresenter).OverallScrollPosition += scrollCountInternal;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x000A5D74 File Offset: 0x000A3F74
		private void OnSourceCollectionItemMoved(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			int newStartingIndex = e.NewStartingIndex;
			int oldStartingIndex = e.OldStartingIndex;
			if (newStartingIndex < 0 || newStartingIndex > this._unsortedRecords.Count - 1)
			{
				return;
			}
			if (oldStartingIndex < 0 || oldStartingIndex > this._unsortedRecords.Count - 1)
			{
				return;
			}
			int sortedIndexFromUnsortedIndex = this._sortedRecords.ViewableRecords.GetSortedIndexFromUnsortedIndex(oldStartingIndex);
			int sortedIndexFromUnsortedIndex2 = this._sortedRecords.ViewableRecords.GetSortedIndexFromUnsortedIndex(newStartingIndex);
			global::Infragistics.Windows.DataPresenter.Record item = this._unsortedRecords.SparseArray.GetItem(oldStartingIndex, false);
			this._unsortedRecords.SparseArray.RemoveAt(oldStartingIndex);
			this._unsortedRecords.SparseArray.Insert(newStartingIndex, item);
			bool flag = !this._isSorted;
			if (item is global::Infragistics.Windows.DataPresenter.DataRecord)
			{
				if (item == this._recordBeingCommitted && ((global::Infragistics.Windows.DataPresenter.DataRecord)item).IsAddRecord)
				{
					flag = false;
				}
				else
				{
					global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> recordsInsertedAtTop = this.RecordsInsertedAtTop;
					if (recordsInsertedAtTop != null && recordsInsertedAtTop.Contains(item as global::Infragistics.Windows.DataPresenter.DataRecord))
					{
						flag = false;
					}
				}
			}
			if (flag && sortedIndexFromUnsortedIndex2 != sortedIndexFromUnsortedIndex)
			{
				this._sortedRecords.ViewableRecords.MoveRecord(item, sortedIndexFromUnsortedIndex2, sortedIndexFromUnsortedIndex);
			}
			this.BumpUnderlyingDataVersion();
			this._unsortedRecords.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Move, this._unsortedRecords[newStartingIndex], newStartingIndex, oldStartingIndex);
			this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.ItemMoved, item as global::Infragistics.Windows.DataPresenter.DataRecord, null);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000A5EB0 File Offset: 0x000A40B0
		private void OnSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._firstResetProcessed)
			{
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset && this._collectionView != null)
				{
					if (this._collectionView.SourceCollection != this._underlyingSourceItems)
					{
						this.SetDataSource(this._collectionView, false);
						return;
					}
					if (this.VerifyListSourceToUse())
					{
						this.SetDataSource(this._collectionView, false);
						return;
					}
				}
				if (this._bindingList != null && this._bindingList.SupportsChangeNotification)
				{
					return;
				}
			}
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (this.IsResetPending || this.TreatUpdatesAsResets)
				{
					this.OnSourceCollectionReset();
					return;
				}
				this.OnSourceCollectionAddOrRemove(e);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				if (e.OldItems != null)
				{
					if (e.NewItems == null)
					{
						return;
					}
					if (this.IsResetPending || this.TreatUpdatesAsResets)
					{
						this.OnSourceCollectionReset();
						return;
					}
					int oldStartingIndex = e.OldStartingIndex;
					if (oldStartingIndex >= 0 && e.NewItems != null && e.OldItems != null && e.NewItems.Count == e.OldItems.Count)
					{
						int count = e.OldItems.Count;
						for (int i = 0; i < count; i++)
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._unsortedRecords.SparseArray.GetItem(oldStartingIndex + i, false) as global::Infragistics.Windows.DataPresenter.DataRecord;
							if (dataRecord != null)
							{
								dataRecord.InitializeDataItem(e.NewItems[i], oldStartingIndex);
								dataRecord.FireInitializeRecord(true, true);
							}
						}
						return;
					}
					this.OnSourceCollectionReset();
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				if (this.IsResetPending || this.TreatUpdatesAsResets)
				{
					this.OnSourceCollectionReset();
					return;
				}
				this.OnSourceCollectionItemMoved(e);
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				if (this._firstResetProcessed)
				{
					this.OnSourceCollectionReset();
					return;
				}
				this.PostDelayedReset();
				return;
			default:
				return;
			}
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x000A6058 File Offset: 0x000A4258
		internal void OnSourceCollectionReset()
		{
			if (this._isInReset && this._sourceItems != null)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(string.Format("DataSource reset notification received recursively. DataSource should not send a change notifcation during a reset, DataSource: {0}{1}", this._sourceItems, global::System.Environment.NewLine));
			}
			bool flag = false;
			lock (this._asyncChangeList.SyncRoot)
			{
				this._isInReset = true;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				try
				{
					this._asyncChangePending = null;
					this._asyncChangeList.Clear();
					this._processAsyncChangeList = null;
					this._processAsyncChangeListSet = null;
					this._resetOperationPending = null;
					if (this._sourceItems == null)
					{
						this.Clear();
						this.ClearCachedRecordsOnTop();
						this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.Reset, null, null);
						return;
					}
					this.BumpUnderlyingDataVersion();
					int count = this._unsortedRecords.Count;
					this.InitializeFieldLayout(null);
					bool flag3 = false;
					global::System.Collections.IEnumerable enumerable = this._list;
					if (enumerable == null)
					{
						if (this._collectionView != null)
						{
							enumerable = this._collectionView;
						}
						else
						{
							enumerable = this._sourceItems;
						}
					}
					global::System.Collections.ICollection list = this._list;
					int num = 0;
					if (list != null)
					{
						num = list.Count;
					}
					else
					{
						try
						{
							foreach (object obj in enumerable)
							{
								if (!(obj is global::System.Xml.XmlComment))
								{
									num++;
								}
							}
						}
						catch (global::System.Exception exception)
						{
							dataPresenter.RaiseDataError(null, (this._parentRecord != null) ? this._parentRecord.Field : null, exception, global::Infragistics.Windows.DataPresenter.DataErrorOperation.RecordDelete, null, true);
							num = 0;
							enumerable = new global::Infragistics.Windows.DataPresenter.GridUtilities.EmptyEnumerable<object>();
						}
					}
					global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list2 = (num > 0 && this._unsortedRecords.Count > 0) ? new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord>(global::System.Math.Min(100, this._unsortedRecords.Count)) : null;
					this._firstResetProcessed = true;
					global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior dataSourceResetBehavior = (dataPresenter != null) ? dataPresenter.DataSourceResetBehavior : global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.ReuseRecordsViaEnumerator;
					if (dataSourceResetBehavior == global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.ReuseRecordsViaEnumerator && enumerable != null && this._unsortedRecords.Count == num)
					{
						flag3 = true;
						int i = 0;
						foreach (object obj2 in enumerable)
						{
							if (!(obj2 is global::System.Xml.XmlComment))
							{
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)this._unsortedRecords.SparseArray.GetItem(i, false);
								if (dataRecord != null && !dataRecord.IsDataItemEqual(obj2))
								{
									flag3 = false;
									break;
								}
								i++;
							}
						}
					}
					this.BeginUpdate();
					if (!flag3)
					{
						global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = this._unsortedRecords.SparseArray;
						global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray2 = this._sortedRecords.SparseArray;
						global::Infragistics.Windows.DataPresenter.Record activeRecordInternal = dataPresenter.ActiveRecordInternal;
						bool flag4 = activeRecordInternal != null && sparseArray.Contains(activeRecordInternal);
						int num2 = 0;
						bool flag5 = dataPresenter.RecordLoadMode == global::Infragistics.Windows.DataPresenter.RecordLoadMode.PreloadRecords || null == this._list;
						global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord> collection;
						bool flag6;
						if (this._list != null && (global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.ReuseRecordsViaIndexOf == dataSourceResetBehavior || global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.DiscardExistingRecords == dataSourceResetBehavior))
						{
							global::System.Collections.IList list3 = this._list;
							global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> list4 = global::Infragistics.Windows.DataPresenter.GridUtilities.ToList<global::Infragistics.Windows.DataPresenter.DataRecord>(this._unsortedRecords.SparseArray.NonNullItems, false);
							this.Clear(false, false);
							sparseArray.Expand(num);
							sparseArray2.Expand(num);
							if (global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.DiscardExistingRecords != dataSourceResetBehavior)
							{
								int count2 = list4.Count;
								for (int i = 0; i < count2; i++)
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = list4[i];
									object obj3 = (dataRecord2 != null) ? dataRecord2.DataItemInternal : null;
									int num3 = (obj3 != null) ? list3.IndexOf(obj3) : -1;
									if (num3 >= 0)
									{
										sparseArray[num3] = dataRecord2;
										sparseArray2[num3] = dataRecord2;
										dataRecord2.InitializeDataItem(obj3, num3);
										list4[i] = null;
										num2++;
										if (list2 != null && dataRecord2.AssociatedRecordPresenter != null)
										{
											list2.Add(dataRecord2);
										}
									}
								}
							}
							if (this._inAddNew && this._currentAddRecord != null && num > 0 && this._unsortedRecords[num - 1] == null)
							{
								this._unsortedRecords[num - 1] = this._currentAddRecord;
							}
							if (num2 > 0)
							{
								global::Infragistics.CoreUtilities.RemoveAll<global::Infragistics.Windows.DataPresenter.DataRecord>(list4, null);
							}
							collection = list4;
							flag6 = true;
							if (flag5)
							{
								for (int i = 0; i < num; i++)
								{
									if (sparseArray[i] == null)
									{
										object listObject = list3[i];
										global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = global::Infragistics.Windows.DataPresenter.DataRecord.Create(this._sortedRecords, listObject, false, i);
										sparseArray[i] = dataRecord3;
										sparseArray2[i] = dataRecord3;
										dataRecord3.FireInitializeRecord();
									}
								}
							}
						}
						else
						{
							global::System.Collections.Hashtable hashtable = null;
							int num4 = 0;
							int num5 = 0;
							if (this._unsortedRecords.Count > 0)
							{
								hashtable = new global::System.Collections.Hashtable(this._unsortedRecords.Count, 0.9f);
								foreach (object obj4 in this._unsortedRecords.SparseArray.NonNullItems)
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord4 = (global::Infragistics.Windows.DataPresenter.DataRecord)obj4;
									num4++;
									global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder dataRecordHolder = new global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder(dataRecord4, dataRecord4.DataItemForComparison);
									hashtable[dataRecordHolder] = dataRecordHolder;
								}
								num5 = hashtable.Count;
							}
							this.Clear(false, false);
							int num6 = 0;
							sparseArray.Expand(num);
							sparseArray2.Expand(num);
							if (flag5 || hashtable != null || this._inAddNew)
							{
								bool flag7 = false;
								foreach (object obj5 in enumerable)
								{
									if (!(obj5 is global::System.Xml.XmlComment))
									{
										if (obj5 != null)
										{
											global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder dataRecordHolder = null;
											if (hashtable != null && hashtable.Count > 0 && global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.DiscardExistingRecords != dataSourceResetBehavior)
											{
												dataRecordHolder = (global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder)hashtable[new global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder(global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(obj5))];
												if (dataRecordHolder != null)
												{
													hashtable.Remove(dataRecordHolder);
												}
											}
											global::Infragistics.Windows.DataPresenter.DataRecord dataRecord5 = null;
											if (dataRecordHolder == null)
											{
												if (1 + num6 == num && this._inAddNew && !flag7 && this._currentAddRecord != null)
												{
													dataRecord5 = this._currentAddRecord;
													flag7 = true;
												}
												else if (!flag5)
												{
													if (hashtable == null || hashtable.Count != 0)
													{
														num6++;
														continue;
													}
													break;
												}
											}
											if (dataRecordHolder != null)
											{
												dataRecord5 = dataRecordHolder.record;
												dataRecord5.InitializeDataItem(obj5, num6);
												num2++;
												if (list2 != null && dataRecord5.AssociatedRecordPresenter != null)
												{
													list2.Add(dataRecord5);
												}
											}
											else if (dataRecord5 == null)
											{
												dataRecord5 = global::Infragistics.Windows.DataPresenter.DataRecord.Create(this._sortedRecords, obj5, false, num6);
											}
											if (this._fieldLayout == null)
											{
												this.InitializeFieldLayout(dataRecord5.FieldLayout);
											}
											sparseArray[num6] = dataRecord5;
											sparseArray2[num6] = dataRecord5;
											if (dataRecordHolder == null)
											{
												dataRecord5.FireInitializeRecord();
											}
										}
										num6++;
									}
								}
							}
							flag6 = (num5 == num4);
							global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord> collection2;
							if (hashtable != null)
							{
								collection2 = global::Infragistics.Windows.DataPresenter.GridUtilities.GetConvertedCollection<global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder, global::Infragistics.Windows.DataPresenter.DataRecord>(hashtable.Values, hashtable.Count, (global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder drh) => drh.record);
							}
							else
							{
								collection2 = new global::Infragistics.Windows.DataPresenter.GridUtilities.EnumeratorCollection<global::Infragistics.Windows.DataPresenter.DataRecord>(new global::Infragistics.Windows.DataPresenter.GridUtilities.EmptyEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord>(), 0);
							}
							collection = collection2;
						}
						if (activeRecordInternal != null && flag4 && !sparseArray.Contains(activeRecordInternal))
						{
							dataPresenter.ClearActiveRecord(true);
						}
						if (dataPresenter != null)
						{
							if (num2 == 0 && this._dataPresenter.RecordManager == this)
							{
								this._dataPresenter.SelectedItems.InternalClearSelection(true, true, false, false);
							}
							else
							{
								global::Infragistics.Windows.DataPresenter.RecordManager.UpdateSelectedItems(this._dataPresenter, flag6 ? collection : null);
							}
						}
					}
					else if (list2 != null)
					{
						foreach (object obj6 in this._unsortedRecords.SparseArray.NonNullItems)
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord6 = (global::Infragistics.Windows.DataPresenter.DataRecord)obj6;
							if (dataRecord6 != null && dataRecord6.AssociatedRecordPresenter != null)
							{
								list2.Add(dataRecord6);
							}
						}
					}
					this._unsortedRecordsDirty = true;
					if (this._unsortedRecords.Count == 0)
					{
						global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentRecordCollection = (this._parentRecord != null) ? this._parentRecord.ChildRecords : null;
						global::Infragistics.Windows.DataPresenter.FieldLayout defaultLayoutForItem = this._dataPresenter.FieldLayouts.GetDefaultLayoutForItem(null, this._underlyingSourceItems, parentRecordCollection);
						if (defaultLayoutForItem != null)
						{
							if (!defaultLayoutForItem.AreFieldsInitialized)
							{
								defaultLayoutForItem.InitializeFields(null, this._underlyingSourceItems, parentRecordCollection);
							}
							this.InitializeFieldLayout(defaultLayoutForItem);
						}
					}
					if (this._dataPresenter != null && !this._dataPresenter.IsSynchronousControl)
					{
						if (this._cleanupTrackersOperationPending == null)
						{
							this._cleanupTrackersOperationPending = this._dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Send, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.CleanupUnusedSortGroupByVersionTrackers));
						}
					}
					else
					{
						this.CleanupUnusedSortGroupByVersionTrackers();
					}
					flag = this.VerifySort();
					this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.Reset, null, null);
					this.EndUpdate(!flag3);
					if (list2 != null)
					{
						int count3 = list2.Count;
						for (int i = 0; i < count3; i++)
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord7 = list2[i];
							if (dataRecord7.AssociatedRecordPresenter != null)
							{
								dataRecord7.RefreshCellValues(false, false, true, true);
							}
						}
					}
				}
				finally
				{
					this._isInReset = false;
				}
			}
			base.RaisePropertyChangedEvent("Unsorted");
			base.RaisePropertyChangedEvent("Sorted");
			base.RaisePropertyChangedEvent("Groups");
			base.RaisePropertyChangedEvent("Current");
			this._unsortedRecords.RaiseChangeEvents(true);
			if (!flag)
			{
				this._sortedRecords.RaiseChangeEvents(true);
			}
			this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.Reset, null, null);
			this.SetActiveRecordFromCurrentItem();
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x000A6A04 File Offset: 0x000A4C04
		private void OnSortGroupByVersionChanged()
		{
			this._trackSortGroupOperationPending = null;
			this.VerifySort();
		}

		// Token: 0x06002660 RID: 9824 RVA: 0x000A6A14 File Offset: 0x000A4C14
		private void PostDelayedReset()
		{
			if (this._unsortedRecords.Count == 0 || this._sourceItems == null)
			{
				this.OnSourceCollectionReset();
				return;
			}
			if (!this.IsResetPending)
			{
				if (this._dataPresenter != null)
				{
					if (this._dataPresenter.IsSynchronousControl)
					{
						this.OnSourceCollectionReset();
						return;
					}
					this._resetOperationPending = this._dataPresenter.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.DataBind, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.OnDelayedReset));
					return;
				}
				else
				{
					this.OnSourceCollectionReset();
				}
			}
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x000A6A8C File Offset: 0x000A4C8C
		private void ProcessChangeNotification(object sender, object eventArgs)
		{
			global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = eventArgs as global::System.ComponentModel.PropertyChangedEventArgs;
			if (propertyChangedEventArgs != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = sender as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null && !dataRecord.IsDeleted)
				{
					if (propertyChangedEventArgs.PropertyName == string.Empty)
					{
						dataRecord.RefreshCellValues(true, true);
						this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.RecordDataChange, dataRecord, null);
						return;
					}
					global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = dataRecord.AssociatedRecordPresenter;
					dataRecord.RefreshCellValue(propertyChangedEventArgs.PropertyName, true, associatedRecordPresenter != null && associatedRecordPresenter.IsDeactivated);
				}
				return;
			}
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = eventArgs as global::System.Collections.Specialized.NotifyCollectionChangedEventArgs;
			if (notifyCollectionChangedEventArgs != null)
			{
				this.OnSourceCollectionChanged(sender, (global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)eventArgs);
				return;
			}
			global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs = eventArgs as global::System.ComponentModel.ListChangedEventArgs;
			if (listChangedEventArgs != null)
			{
				this.OnBindingListChanged(sender, (global::System.ComponentModel.ListChangedEventArgs)eventArgs);
			}
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x000A6B2C File Offset: 0x000A4D2C
		private void RemoveRecordHelper(int index)
		{
			bool flag = false;
			int index2 = -1;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._unsortedRecords.SparseArray.GetItem(index, false) as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null && dataRecord.IsActive)
			{
				index2 = dataRecord.SortIndex;
				global::Infragistics.Windows.DataPresenter.Cell activeCell = this._dataPresenter.ActiveCell;
				if (activeCell != null && activeCell.IsInEditMode)
				{
					activeCell.EndEditMode(false, true);
				}
			}
			if (dataRecord != null)
			{
				if (this._dataPresenter.ScrollBehaviorOnListChange == global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange.PreserveRecordsInView && !dataRecord.IsFixed)
				{
					int scrollCountInternal = dataRecord.ScrollCountInternal;
					if (scrollCountInternal > 0 && dataRecord.OverallScrollPosition <= ((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this._dataPresenter).OverallScrollPosition)
					{
						((global::Infragistics.Windows.DataPresenter.IViewPanelInfo)this._dataPresenter).OverallScrollPosition -= scrollCountInternal;
					}
				}
				if (dataRecord.IsSelected)
				{
					this._dataPresenter.SelectedItems.Records.Remove(dataRecord);
					this._dataPresenter.RaiseSelectedItemsChangedAsync(typeof(global::Infragistics.Windows.DataPresenter.Record));
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells = this._dataPresenter.SelectedItems.Cells;
					int count = cells.Count;
					bool flag2 = false;
					for (int i = count - 1; i >= 0; i--)
					{
						global::Infragistics.Windows.DataPresenter.Cell cell = cells[i];
						if (cell != null && cell.Record == dataRecord)
						{
							cells.RemoveAt(i);
							flag2 = true;
						}
					}
					if (flag2)
					{
						this._dataPresenter.RaiseSelectedItemsChangedAsync(typeof(global::Infragistics.Windows.DataPresenter.Cell));
					}
				}
			}
			this.RemoveAt(index, true);
			if (dataRecord != null)
			{
				bool isActive = dataRecord.IsActive;
				if (!dataRecord.IsAddRecord)
				{
					dataRecord.InternalSetIsDeleted();
					dataRecord.DirtyScrollCount();
				}
				if (isActive && !dataRecord.IsAddRecord)
				{
					flag = true;
					this._dataPresenter.ActiveRecord = null;
				}
			}
			this.BumpUnderlyingDataVersion();
			if (dataRecord != null && dataRecord.IsAddRecord && this._editableCollectionView != null)
			{
				dataRecord.SetDataItemHelper(null);
				dataRecord.InternalSetDataChanged(false);
				this.PrepareForNewCurrentAddRecord();
			}
			this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.RemoveRecord, dataRecord, null);
			if (flag && this._recordBeingDeleted == null)
			{
				this.ReselectRecordAtSortedIndex(index2);
			}
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000A6D04 File Offset: 0x000A4F04
		private bool SortViaCollectionViewHelper()
		{
			bool flag = global::Infragistics.Windows.DataPresenter.SortEvaluationMode.UseCollectionView == this.SortEvaluationModeResolved;
			bool flag2 = global::Infragistics.Windows.DataPresenter.GroupByEvaluationMode.UseCollectionView == this.GroupByEvaluationModeResolved;
			if (this._sortedFieldsToCollectionViewSynchronizer != null && this._fieldLayout != null && (this._fieldLayout != this._sortedFieldsToCollectionViewSynchronizer._fieldLayout || (!flag && !flag2)))
			{
				this._sortedFieldsToCollectionViewSynchronizer.Dispose();
				this._sortedFieldsToCollectionViewSynchronizer = null;
			}
			if (flag || flag2)
			{
				if (this._sortedFieldsToCollectionViewSynchronizer == null)
				{
					this._sortedFieldsToCollectionViewSynchronizer = global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer.CreateHelper(this);
				}
				this._sortedFieldsToCollectionViewSynchronizer.Synchronize(true);
				return true;
			}
			return false;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000A6D8C File Offset: 0x000A4F8C
		private void SyncSortGroupByVersions()
		{
			if (this._sortGroupByVersionTrackers != null && this._sortGroupByVersionTrackers.Count > 0)
			{
				foreach (global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker sortGroupVersionTracker in this._sortGroupByVersionTrackers.Values)
				{
					if (sortGroupVersionTracker != null)
					{
						sortGroupVersionTracker.SyncVersionNumbers();
					}
				}
			}
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x000A6DF8 File Offset: 0x000A4FF8
		private static void UpdateSelectedItems(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord> discardedRecords)
		{
			if (dp == null)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selectedItems = dp.SelectedItems;
			bool hasRecords = selectedItems.HasRecords;
			if (!hasRecords && !selectedItems.HasCells)
			{
				return;
			}
			int num = (discardedRecords != null) ? discardedRecords.Count : 0;
			int num2 = hasRecords ? num : (num * 5);
			int num3 = hasRecords ? selectedItems.Records.Count : selectedItems.Cells.Count;
			if (discardedRecords != null && num3 > num2)
			{
				new global::System.Collections.Generic.List<object>();
				global::Infragistics.Windows.DataPresenter.SelectedItemCollectionBase selectedItemCollectionBase = hasRecords ? selectedItems.Records : selectedItems.Cells;
				selectedItemCollectionBase.BeginUpdate();
				try
				{
					foreach (global::Infragistics.Windows.DataPresenter.DataRecord record in discardedRecords)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager.UnselectItems(!hasRecords, record, selectedItems);
					}
					return;
				}
				finally
				{
					selectedItemCollectionBase.EndUpdate();
				}
			}
			if (hasRecords)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>();
				foreach (global::Infragistics.Windows.DataPresenter.Record record2 in selectedItems.Records)
				{
					if (record2.IsStillValid)
					{
						list.Add(record2);
					}
				}
				if (list.Count == 0)
				{
					dp.SelectedItems.InternalClearSelection(true, true, false, false);
					return;
				}
				dp.SelectedItems.Records.InternalAddRange(list, true);
				return;
			}
			else
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Cell> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Cell>();
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = null;
				bool flag = false;
				foreach (global::Infragistics.Windows.DataPresenter.Cell cell in selectedItems.Cells)
				{
					global::Infragistics.Windows.DataPresenter.DataRecord record3 = cell.Record;
					if (record3 != dataRecord)
					{
						dataRecord = record3;
						flag = record3.IsStillValid;
					}
					if (flag)
					{
						list2.Add(cell);
					}
				}
				if (list2.Count == 0)
				{
					dp.SelectedItems.InternalClearSelection(true, true, false, false);
					return;
				}
				dp.SelectedItems.Cells.InternalAddRange(list2, true);
			}
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x000A7004 File Offset: 0x000A5204
		private static void UnselectItems(bool cells, global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder selected)
		{
			if (cells)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = record as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.FieldCollection fields = dataRecord.FieldLayout.Fields;
					int i = 0;
					int count = fields.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.Cell cellIfAllocated = dataRecord.GetCellIfAllocated(fields[i]);
						if (cellIfAllocated != null && cellIfAllocated.IsSelected)
						{
							selected.Cells.InternalRemove(cellIfAllocated);
						}
						i++;
					}
				}
			}
			else if (record.IsSelected)
			{
				selected.Records.InternalRemove(record);
			}
			if (record.HasChildrenInternal)
			{
				foreach (object obj in record.ChildRecordsInternal.SparseArray.NonNullItems)
				{
					global::Infragistics.Windows.DataPresenter.Record record2 = (global::Infragistics.Windows.DataPresenter.Record)obj;
					global::Infragistics.Windows.DataPresenter.RecordManager.UnselectItems(cells, record2, selected);
				}
			}
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000A70E4 File Offset: 0x000A52E4
		private bool VerifyListSourceToUse()
		{
			global::System.Collections.IList list = null;
			global::System.ComponentModel.IBindingList bindingList = null;
			global::Infragistics.Windows.CollectionViewWrapper collectionViewWrapper = null;
			global::Infragistics.Windows.EditableCollectionViewProxy editableCollectionViewProxy = global::Infragistics.Windows.DataPresenter.RecordManager.GetEditableCollectionViewProxy(this._collectionView, this._editableCollectionView);
			bool flag = editableCollectionViewProxy != null;
			global::System.Windows.Data.CollectionView collectionView = this._collectionView as global::System.Windows.Data.CollectionView;
			if (!flag)
			{
				if ((this._collectionView != null && ((this._collectionView.CanFilter && this._collectionView.Filter != null) || (this._collectionView.CanSort && this._collectionView.SortDescriptions.Count > 0))) || this._underlyingSourceItems is global::System.Windows.Data.CompositeCollection)
				{
					list = null;
				}
				else
				{
					list = (this._underlyingSourceItems as global::System.Collections.IList);
					bindingList = (this._underlyingSourceItems as global::System.ComponentModel.IBindingList);
					if (list == null)
					{
						list = (this._collectionView as global::System.Collections.IList);
					}
				}
			}
			if (flag)
			{
				if (this._collectionViewWrapper != null && this._collectionViewWrapper.View == collectionView && this._collectionViewWrapper.EditableCollectionViewProxy == editableCollectionViewProxy)
				{
					collectionViewWrapper = this._collectionViewWrapper;
				}
				else
				{
					collectionViewWrapper = new global::Infragistics.Windows.CollectionViewWrapper(collectionView, editableCollectionViewProxy);
				}
				list = collectionViewWrapper;
			}
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = (collectionViewWrapper != null) ? collectionViewWrapper : (this._sourceItems as global::System.Collections.Specialized.INotifyCollectionChanged);
			if (list == this._list && bindingList == this._bindingList && editableCollectionViewProxy == this._editableCollectionView && collectionViewWrapper == this._collectionViewWrapper && notifyCollectionChanged == this._notifyCollectionChangedHooked)
			{
				if (!this.DataSourceAllowsAddNew)
				{
					this.ClearAddRecordOnDataSourceChange();
				}
				return false;
			}
			this._typeWithPublicCtor = null;
			this._list = list;
			this._editableCollectionView = editableCollectionViewProxy;
			this._collectionViewWrapper = collectionViewWrapper;
			this._dataSourceRaisesCellValueChangeEvents = false;
			if (bindingList != this._bindingList)
			{
				if (this._bindingList != null)
				{
					global::Infragistics.Windows.Helpers.BindingListChangedEventManager.RemoveListener(this._bindingList, this);
				}
				this._bindingList = bindingList;
				if (this._bindingList != null)
				{
					global::System.ComponentModel.IRaiseItemChangedEvents raiseItemChangedEvents = this._underlyingSourceItems as global::System.ComponentModel.IRaiseItemChangedEvents;
					if (collectionView == null)
					{
						this._dataSourceRaisesCellValueChangeEvents = (raiseItemChangedEvents == null || raiseItemChangedEvents.RaisesItemChangedEvents);
					}
					global::Infragistics.Windows.Helpers.BindingListChangedEventManager.AddListener(this._bindingList, this);
				}
			}
			if (notifyCollectionChanged != this._notifyCollectionChangedHooked)
			{
				if (this._notifyCollectionChangedHooked != null)
				{
					global::System.Collections.Specialized.CollectionChangedEventManager.RemoveListener(this._notifyCollectionChangedHooked, this);
				}
				if (notifyCollectionChanged != null)
				{
					global::System.Collections.Specialized.CollectionChangedEventManager.AddListener(notifyCollectionChanged, this);
				}
				this._notifyCollectionChangedHooked = notifyCollectionChanged;
			}
			global::System.ComponentModel.ITypedList typedList = null;
			this._typeIsKnownType = false;
			if (this._underlyingSourceItems == null)
			{
				this._canGetPropertiesFromDataSourceWithoutItems = false;
			}
			else
			{
				global::System.Type type;
				typedList = global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(this._underlyingSourceItems, out type);
				this._canGetPropertiesFromDataSourceWithoutItems = (typedList != null || type != null);
				if (type != null && !type.IsAbstract)
				{
					this._typeIsKnownType = global::Infragistics.CoreUtilities.IsKnownType(type);
					if (type.IsPrimitive || type == typeof(string) || type.GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.CreateInstance, null, global::System.Type.EmptyTypes, null) != null)
					{
						this._typeWithPublicCtor = type;
					}
				}
			}
			if (this._parentRecord == null && this._dataPresenter != null)
			{
				this._typedListDefaultProvider = this._dataPresenter.FieldLayouts.InitializeFieldLayoutStructureFromTypedList(typedList);
			}
			else
			{
				this._typedListDefaultProvider = null;
			}
			if (!this.DataSourceAllowsAddNew)
			{
				this.ClearAddRecordOnDataSourceChange();
			}
			return true;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000A73BE File Offset: 0x000A55BE
		private void VerifyRootDataSource()
		{
			if (this._parentRecord != null || this._dataPresenter == null)
			{
				return;
			}
			if (this.DataSource == null)
			{
				this._dataPresenter.VerifyRecordManagerDataSource();
			}
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000A73E4 File Offset: 0x000A55E4
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.CurrentChangedEventManager))
			{
				this.OnCollectionViewCurrentChanged(sender, e);
				return true;
			}
			if (managerType == typeof(global::System.ComponentModel.CurrentChangingEventManager) && e is global::System.ComponentModel.CurrentChangingEventArgs)
			{
				this.OnCollectionViewCurrentChanging(sender, (global::System.ComponentModel.CurrentChangingEventArgs)e);
				return true;
			}
			if (managerType == typeof(global::System.Collections.Specialized.CollectionChangedEventManager) && e is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)
			{
				this.OnChangeNotification(sender, e, ((global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)e).Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
				return true;
			}
			if (managerType == typeof(global::Infragistics.Windows.Helpers.BindingListChangedEventManager) && e is global::System.ComponentModel.ListChangedEventArgs)
			{
				this.OnChangeNotification(sender, e, ((global::System.ComponentModel.ListChangedEventArgs)e).ListChangedType == global::System.ComponentModel.ListChangedType.Reset);
				return true;
			}
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager) && e is global::System.ComponentModel.PropertyChangedEventArgs)
			{
				this.OnFieldLayoutPropertyChanged(sender, e as global::System.ComponentModel.PropertyChangedEventArgs);
				return true;
			}
			return false;
		}

		// Token: 0x040011E2 RID: 4578
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040011E3 RID: 4579
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord _parentRecord;

		// Token: 0x040011E4 RID: 4580
		private global::Infragistics.Windows.DataPresenter.DataRecordCollection _unsortedRecords;

		// Token: 0x040011E5 RID: 4581
		private global::Infragistics.Windows.DataPresenter.DataRecordCollection _sortedRecords;

		// Token: 0x040011E6 RID: 4582
		private global::Infragistics.Windows.DataPresenter.GroupByRecordCollection _groups;

		// Token: 0x040011E7 RID: 4583
		private global::System.Collections.IEnumerable _sourceItems;

		// Token: 0x040011E8 RID: 4584
		private global::System.Collections.IEnumerable _underlyingSourceItems;

		// Token: 0x040011E9 RID: 4585
		private global::System.ComponentModel.IBindingList _bindingList;

		// Token: 0x040011EA RID: 4586
		private global::System.Collections.IList _list;

		// Token: 0x040011EB RID: 4587
		private global::System.ComponentModel.ICollectionView _collectionView;

		// Token: 0x040011EC RID: 4588
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040011ED RID: 4589
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x040011EE RID: 4590
		private global::System.Windows.Threading.DispatcherOperation _resetOperationPending;

		// Token: 0x040011EF RID: 4591
		private global::System.Windows.Threading.DispatcherOperation _trackSortGroupOperationPending;

		// Token: 0x040011F0 RID: 4592
		private global::System.Windows.Threading.DispatcherOperation _cleanupTrackersOperationPending;

		// Token: 0x040011F1 RID: 4593
		private bool _isSorted;

		// Token: 0x040011F2 RID: 4594
		private bool _hasSourceBeenSetAtLeastOnce;

		// Token: 0x040011F3 RID: 4595
		private bool _hasMultipleFieldLayouts;

		// Token: 0x040011F4 RID: 4596
		private bool _unsortedRecordsDirty;

		// Token: 0x040011F5 RID: 4597
		private bool _firstResetProcessed;

		// Token: 0x040011F6 RID: 4598
		private bool _isInitializingDataSource;

		// Token: 0x040011F7 RID: 4599
		private global::System.Collections.Specialized.INotifyCollectionChanged _notifyCollectionChangedHooked;

		// Token: 0x040011F8 RID: 4600
		private bool _inAddNew;

		// Token: 0x040011F9 RID: 4601
		private bool _isInReset;

		// Token: 0x040011FA RID: 4602
		private global::Infragistics.Windows.DataPresenter.DataRecord _recordBeingCommitted;

		// Token: 0x040011FB RID: 4603
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker> _sortGroupByVersionTrackers = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker>(true, true);

		// Token: 0x040011FC RID: 4604
		private int _underlyingDataVersion;

		// Token: 0x040011FD RID: 4605
		private global::Infragistics.Windows.DataPresenter.DataRecord _currentAddRecord;

		// Token: 0x040011FE RID: 4606
		private global::Infragistics.Windows.DataPresenter.DataRecord _recordBeingDeleted;

		// Token: 0x040011FF RID: 4607
		private global::System.Collections.Specialized.HybridDictionary _addRecordCellDataDictionary;

		// Token: 0x04001200 RID: 4608
		private bool _isGroupBySupported;

		// Token: 0x04001201 RID: 4609
		private global::Infragistics.Windows.EditableCollectionViewProxy _editableCollectionView;

		// Token: 0x04001202 RID: 4610
		private global::Infragistics.Windows.CollectionViewWrapper _collectionViewWrapper;

		// Token: 0x04001203 RID: 4611
		private bool _dataSourceRaisesCellValueChangeEvents;

		// Token: 0x04001204 RID: 4612
		private bool _canGetPropertiesFromDataSourceWithoutItems;

		// Token: 0x04001205 RID: 4613
		private bool _isSynchronizingWithCurrentItem;

		// Token: 0x04001206 RID: 4614
		private global::System.Type _typeWithPublicCtor;

		// Token: 0x04001207 RID: 4615
		private bool _typeIsKnownType;

		// Token: 0x04001208 RID: 4616
		private global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider _typedListDefaultProvider;

		// Token: 0x04001209 RID: 4617
		private global::System.Collections.ArrayList _asyncChangeList;

		// Token: 0x0400120A RID: 4618
		private global::System.Windows.Threading.DispatcherOperation _asyncChangePending;

		// Token: 0x0400120B RID: 4619
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification> _processAsyncChangeList;

		// Token: 0x0400120C RID: 4620
		private global::Infragistics.Windows.Helpers.HashSet _processAsyncChangeListSet;

		// Token: 0x0400120D RID: 4621
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.Record> _associatedRecordMap;

		// Token: 0x0400120E RID: 4622
		private global::Infragistics.Windows.DataPresenter.RecordManager _associatedRecordManager;

		// Token: 0x0400120F RID: 4623
		private int _reportVersion;

		// Token: 0x04001210 RID: 4624
		private global::Infragistics.Windows.DataPresenter.RecordFilterCollection _recordFilters;

		// Token: 0x04001211 RID: 4625
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _recordFiltersResolved;

		// Token: 0x04001212 RID: 4626
		private global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection _filteredInDataItems;

		// Token: 0x04001213 RID: 4627
		internal global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation _beginUpdateInfo;

		// Token: 0x04001214 RID: 4628
		private int _scrollCountVersion;

		// Token: 0x04001215 RID: 4629
		private int _newRecordOnTopOffset;

		// Token: 0x04001216 RID: 4630
		private int _nestingDepth;

		// Token: 0x04001217 RID: 4631
		private int _fieldAutoSizeVersion = 1;

		// Token: 0x04001218 RID: 4632
		private global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer _sortedFieldsToCollectionViewSynchronizer;

		// Token: 0x04001219 RID: 4633
		private bool _inProcessQueuedChangs;

		// Token: 0x02000318 RID: 792
		// (Invoke) Token: 0x0600266C RID: 9836
		private delegate bool BoolReturnMethodDelegate();

		// Token: 0x02000319 RID: 793
		// (Invoke) Token: 0x06002670 RID: 9840
		internal delegate bool VerifySortDelegate();

		// Token: 0x0200031A RID: 794
		internal class BeginUpdateInformation
		{
			// Token: 0x06002673 RID: 9843 RVA: 0x000A74C4 File Offset: 0x000A56C4
			internal BeginUpdateInformation(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				this._recordManager = recordManager;
			}

			// Token: 0x17000B4E RID: 2894
			// (get) Token: 0x06002674 RID: 9844 RVA: 0x000A74D3 File Offset: 0x000A56D3
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo> PendingNotificationList
			{
				get
				{
					if (this._pendingNotificationList == null)
					{
						this._pendingNotificationList = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo>();
					}
					return this._pendingNotificationList;
				}
			}

			// Token: 0x17000B4F RID: 2895
			// (get) Token: 0x06002675 RID: 9845 RVA: 0x000A74EE File Offset: 0x000A56EE
			private global::Infragistics.Windows.Helpers.HashSet PendingResetVRCs
			{
				get
				{
					if (this._pendingResetVRCs == null)
					{
						this._pendingResetVRCs = new global::Infragistics.Windows.Helpers.HashSet();
					}
					return this._pendingResetVRCs;
				}
			}

			// Token: 0x06002676 RID: 9846 RVA: 0x000A7509 File Offset: 0x000A5709
			internal void EnqueNotification(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc, global::System.EventArgs eventArgs)
			{
				if (eventArgs is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs && global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset == ((global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)eventArgs).Action)
				{
					this.PendingResetVRCs.Add(vrc);
				}
				this.PendingNotificationList.Add(new global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo(vrc, eventArgs));
			}

			// Token: 0x06002677 RID: 9847 RVA: 0x000A753F File Offset: 0x000A573F
			internal bool HasPendingResetNotification(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc)
			{
				return this._pendingResetVRCs != null && this._pendingResetVRCs.Exists(vrc);
			}

			// Token: 0x06002678 RID: 9848 RVA: 0x000A7558 File Offset: 0x000A5758
			internal void ProcessPendingNotifications()
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._recordManager.ViewableRecords;
				bool flag = false;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo> pendingNotificationList = this._pendingNotificationList;
				if (pendingNotificationList != null && pendingNotificationList.Count > 0)
				{
					global::Infragistics.Windows.Helpers.HashSet hashSet = new global::Infragistics.Windows.Helpers.HashSet();
					int i = 0;
					int count = pendingNotificationList.Count;
					while (i < count)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo pendingNotificationInfo = pendingNotificationList[i];
						if (hashSet.Exists(pendingNotificationInfo._vrc))
						{
							this.PendingResetVRCs.Add(pendingNotificationInfo._vrc);
						}
						else
						{
							hashSet.Add(pendingNotificationInfo._vrc);
						}
						i++;
					}
					int j = 0;
					int count2 = pendingNotificationList.Count;
					while (j < count2)
					{
						global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo pendingNotificationInfo2 = pendingNotificationList[j];
						if (this._pendingResetVRCs == null || !this._pendingResetVRCs.Exists(pendingNotificationInfo2._vrc))
						{
							if (pendingNotificationInfo2._eventArgs is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)
							{
								pendingNotificationInfo2._vrc.RaiseCollectionChanged((global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)pendingNotificationInfo2._eventArgs);
							}
							else if (pendingNotificationInfo2._eventArgs is global::System.ComponentModel.PropertyChangedEventArgs)
							{
								pendingNotificationInfo2._vrc.RaisePropertyChangedEvent(((global::System.ComponentModel.PropertyChangedEventArgs)pendingNotificationInfo2._eventArgs).PropertyName);
							}
							else
							{
								this.PendingResetVRCs.Add(pendingNotificationInfo2._vrc);
							}
						}
						j++;
					}
					if (this._pendingResetVRCs != null)
					{
						foreach (object obj in this._pendingResetVRCs)
						{
							global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = (global::Infragistics.Windows.DataPresenter.ViewableRecordCollection)obj;
							global::Infragistics.Windows.DataPresenter.MainRecordSparseArray recordCollectionSparseArray = viewableRecordCollection.RecordCollectionSparseArray;
							if (recordCollectionSparseArray != null)
							{
								recordCollectionSparseArray.DirtyScrollCount();
								if (viewableRecordCollection == viewableRecords)
								{
									flag = true;
								}
							}
							viewableRecordCollection.RaiseChangeEvents(true);
						}
					}
				}
				if (viewableRecords != null && this._scrollCountDirtied && !flag)
				{
					viewableRecords.OnScrollCountDirtiedHelper();
				}
			}

			// Token: 0x0400121C RID: 4636
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x0400121D RID: 4637
			internal int _beginUpdateCount;

			// Token: 0x0400121E RID: 4638
			private global::Infragistics.Windows.Helpers.HashSet _pendingResetVRCs;

			// Token: 0x0400121F RID: 4639
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo> _pendingNotificationList;

			// Token: 0x04001220 RID: 4640
			internal bool _dirtyScrollCount;

			// Token: 0x04001221 RID: 4641
			internal bool _scrollCountDirtied;

			// Token: 0x0200031B RID: 795
			private class PendingNotificationInfo
			{
				// Token: 0x06002679 RID: 9849 RVA: 0x000A7720 File Offset: 0x000A5920
				internal PendingNotificationInfo(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc, global::System.EventArgs eventArgs)
				{
					this._vrc = vrc;
					this._eventArgs = eventArgs;
				}

				// Token: 0x04001222 RID: 4642
				internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _vrc;

				// Token: 0x04001223 RID: 4643
				internal global::System.EventArgs _eventArgs;
			}
		}

		// Token: 0x0200031C RID: 796
		internal class RecordsSortComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>
		{
			// Token: 0x0600267A RID: 9850 RVA: 0x000A7736 File Offset: 0x000A5936
			internal RecordsSortComparer(bool originalUnsortedOrder)
			{
				this._originalUnsortedOrder = originalUnsortedOrder;
			}

			// Token: 0x0600267B RID: 9851 RVA: 0x000A775C File Offset: 0x000A595C
			private global::Infragistics.Windows.DataPresenter.IGroupByEvaluator GetGroupByEvaluator(global::Infragistics.Windows.DataPresenter.Field field)
			{
				global::Infragistics.Windows.DataPresenter.IGroupByEvaluator groupByEvaluator = null;
				if (this._groupByEvaluators == null)
				{
					this._groupByEvaluators = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.IGroupByEvaluator>();
				}
				else
				{
					this._groupByEvaluators.TryGetValue(field, out groupByEvaluator);
					if (groupByEvaluator != null)
					{
						return groupByEvaluator;
					}
				}
				groupByEvaluator = field.GroupByEvaluatorResolved;
				if (groupByEvaluator != null)
				{
					this._groupByEvaluators.Add(field, groupByEvaluator);
				}
				return groupByEvaluator;
			}

			// Token: 0x0600267C RID: 9852 RVA: 0x000A77AC File Offset: 0x000A59AC
			internal static int DefaultCompare(object x, object y, global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer.DefaultCompare(x, y, true, field);
			}

			// Token: 0x0600267D RID: 9853 RVA: 0x000A77B7 File Offset: 0x000A59B7
			internal static int DefaultCompare(object x, object y, bool duringSort, global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer.DefaultCompare(x, y, duringSort, field != null && global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive == field.SortComparisonTypeResolved);
			}

			// Token: 0x0600267E RID: 9854 RVA: 0x000A77D0 File Offset: 0x000A59D0
			internal static int DefaultCompare(object x, object y, bool duringSort, bool caseInSensitive)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.DefaultCompare(x, y, duringSort, caseInSensitive);
			}

			// Token: 0x0600267F RID: 9855 RVA: 0x000A77DC File Offset: 0x000A59DC
			int global::System.Collections.IComparer.Compare(object x, object y)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = x as global::Infragistics.Windows.DataPresenter.DataRecord;
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord2 = y as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord == dataRecord2)
				{
					return 0;
				}
				global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedRecordLocation = (dataRecord != null) ? dataRecord.FixedLocation : global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable;
				global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedRecordLocation2 = (dataRecord2 != null) ? dataRecord2.FixedLocation : global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable;
				if ((fixedRecordLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable && fixedRecordLocation2 == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable) || fixedRecordLocation == fixedRecordLocation2)
				{
					if (dataRecord == null || dataRecord2 == null)
					{
						if (dataRecord != null)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataRecord.FieldLayout;
							if (fieldLayout.HasSortedFields && fieldLayout.SortedFields[0].Direction == global::System.ComponentModel.ListSortDirection.Descending)
							{
								return 1;
							}
							return -1;
						}
						else if (dataRecord2 != null)
						{
							global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = dataRecord2.FieldLayout;
							if (fieldLayout2.HasSortedFields && fieldLayout2.SortedFields[0].Direction == global::System.ComponentModel.ListSortDirection.Descending)
							{
								return -1;
							}
							return 1;
						}
					}
					int num = 0;
					if (!this._originalUnsortedOrder)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataRecord.FieldLayout;
						global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout2 = dataRecord2.FieldLayout;
						if (fieldLayout != fieldLayout2)
						{
							if (fieldLayout.Index >= fieldLayout2.Index)
							{
								return 1;
							}
							return -1;
						}
						else
						{
							global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer sameFieldRecordsSortComparer;
							if (!this._sameFieldRecordComparers.TryGetValue(fieldLayout, out sameFieldRecordsSortComparer))
							{
								sameFieldRecordsSortComparer = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer(fieldLayout, 0, true);
								this._sameFieldRecordComparers[fieldLayout] = sameFieldRecordsSortComparer;
							}
							if (sameFieldRecordsSortComparer != null)
							{
								num = sameFieldRecordsSortComparer.Compare(dataRecord, dataRecord2);
							}
						}
					}
					if (num == 0)
					{
						num = ((dataRecord.DataItemIndex < dataRecord2.DataItemIndex) ? -1 : 1);
					}
					return num;
				}
				if (fixedRecordLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop)
				{
					return -1;
				}
				if (fixedRecordLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToBottom)
				{
					return 1;
				}
				if (fixedRecordLocation2 == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop)
				{
					return 1;
				}
				return -1;
			}

			// Token: 0x06002680 RID: 9856 RVA: 0x000A791E File Offset: 0x000A5B1E
			public int Compare(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
			{
				return ((global::System.Collections.IComparer)this).Compare(x, y);
			}

			// Token: 0x04001224 RID: 4644
			private bool _originalUnsortedOrder;

			// Token: 0x04001225 RID: 4645
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.IGroupByEvaluator> _groupByEvaluators;

			// Token: 0x04001226 RID: 4646
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellTextConverterInfo> _cellTextConverters = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellTextConverterInfo>();

			// Token: 0x04001227 RID: 4647
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer> _sameFieldRecordComparers = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer>();
		}

		// Token: 0x0200031D RID: 797
		internal class SameFieldRecordsSortComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>
		{
			// Token: 0x06002681 RID: 9857 RVA: 0x000A7928 File Offset: 0x000A5B28
			internal SameFieldRecordsSortComparer(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, int recordsBeingSortedCount, bool areRecordsInUnsortedOrder)
			{
				this._fieldLayout = fieldLayout;
				this._recordsBeingSortedCount = recordsBeingSortedCount;
				this._areRecordsInUnsortedOrder = areRecordsInUnsortedOrder;
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = fieldLayout.SortedFields;
				this._sortedFields = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo[sortedFields.Count];
				int num = 0;
				for (int i = 0; i < sortedFields.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[i];
					global::Infragistics.Windows.DataPresenter.Field field = (fieldSortDescription != null) ? fieldSortDescription.Field : null;
					if (field == null || fieldSortDescription.Field == null || fieldSortDescription.Field.Index < 0)
					{
						num++;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo fieldSortInfo = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo(fieldSortDescription, this, fieldLayout);
						this._sortedFields[i] = fieldSortInfo;
						if (fieldSortInfo._isGroupBy && fieldSortInfo._groupByEvaluatorSortComparer != null)
						{
							if (this._firstGroupByFieldWithGroupBySortComparer < 0)
							{
								this._firstGroupByFieldWithGroupBySortComparer = i - num;
							}
							this._lastGroupByFieldWithGroupBySortComparer = i - num;
						}
					}
				}
				if (num > 0)
				{
					this._sortedFields = global::Infragistics.Windows.DataPresenter.GridUtilities.RemoveAll<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo>(this._sortedFields, null);
				}
			}

			// Token: 0x06002682 RID: 9858 RVA: 0x000A7A19 File Offset: 0x000A5C19
			internal static int DefaultCompare(object x, object y, global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.DefaultCompare(x, y, true, field);
			}

			// Token: 0x06002683 RID: 9859 RVA: 0x000A7A24 File Offset: 0x000A5C24
			internal static int DefaultCompare(object x, object y, bool duringSort, global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.DefaultCompare(x, y, duringSort, field != null && global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive == field.SortComparisonTypeResolved);
			}

			// Token: 0x06002684 RID: 9860 RVA: 0x000A7A40 File Offset: 0x000A5C40
			private static int CompareTypeHelper(global::System.Type x, global::System.Type y)
			{
				global::System.Collections.Generic.Dictionary<global::System.Type, int> dictionary = global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.g_typeOrderTable;
				if (dictionary == null)
				{
					global::System.Type[] array = new global::System.Type[]
					{
						typeof(string),
						typeof(char),
						typeof(bool),
						typeof(sbyte),
						typeof(byte),
						typeof(short),
						typeof(ushort),
						typeof(int),
						typeof(uint),
						typeof(long),
						typeof(ulong),
						typeof(decimal),
						typeof(float),
						typeof(double),
						typeof(global::System.DayOfWeek),
						typeof(global::System.DateTime),
						typeof(global::System.Drawing.Color),
						typeof(global::System.Windows.Media.Color)
					};
					dictionary = new global::System.Collections.Generic.Dictionary<global::System.Type, int>(array.Length);
					for (int i = 0; i < array.Length; i++)
					{
						dictionary.Add(array[i], i);
					}
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.g_typeOrderTable = dictionary;
				}
				int num;
				int num2;
				if (!dictionary.TryGetValue(x, out num) || !dictionary.TryGetValue(y, out num2))
				{
					return -2;
				}
				if (num < num2)
				{
					return -1;
				}
				if (num <= num2)
				{
					return 0;
				}
				return 1;
			}

			// Token: 0x06002685 RID: 9861 RVA: 0x000A7BB9 File Offset: 0x000A5DB9
			private static int CompareStringHelper(string xxStr, string yyStr, bool caseInSensitive)
			{
				return string.Compare(xxStr, yyStr, caseInSensitive, global::System.Globalization.CultureInfo.CurrentCulture);
			}

			// Token: 0x06002686 RID: 9862 RVA: 0x000A7BC8 File Offset: 0x000A5DC8
			internal static int DefaultCompare(object x, object y, bool duringSort, bool caseInSensitive)
			{
				string text = x as string;
				string text2 = y as string;
				if (text != null && text2 != null)
				{
					return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CompareStringHelper(text, text2, caseInSensitive);
				}
				if (x == null || global::System.DBNull.Value == x)
				{
					if (y == null || global::System.DBNull.Value == y)
					{
						return 0;
					}
					return -1;
				}
				else
				{
					if (y == null || global::System.DBNull.Value == y)
					{
						return 1;
					}
					global::System.Type type = x.GetType();
					global::System.Type type2 = y.GetType();
					if (type != type2)
					{
						int num = global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CompareTypeHelper(type, type2);
						if (-2 != num)
						{
							return num;
						}
					}
					global::System.IComparable comparable = x as global::System.IComparable;
					if (comparable != null)
					{
						return comparable.CompareTo(y);
					}
					if (type == type2)
					{
						int result = 0;
						if (type == typeof(global::System.DayOfWeek))
						{
							if ((global::System.DayOfWeek)x < (global::System.DayOfWeek)y)
							{
								result = -1;
							}
							else if ((global::System.DayOfWeek)x > (global::System.DayOfWeek)y)
							{
								result = 1;
							}
							return result;
						}
						if (type == typeof(global::System.Drawing.Color))
						{
							int num2 = ((global::System.Drawing.Color)x).ToArgb();
							int num3 = ((global::System.Drawing.Color)y).ToArgb();
							if (num2 < num3)
							{
								result = -1;
							}
							else if (num2 > num3)
							{
								result = 1;
							}
							return result;
						}
					}
					if (duringSort)
					{
						return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CompareStringHelper(x.ToString(), y.ToString(), caseInSensitive);
					}
					if (!x.Equals(y))
					{
						return -2;
					}
					return 0;
				}
			}

			// Token: 0x06002687 RID: 9863 RVA: 0x000A7D10 File Offset: 0x000A5F10
			int global::System.Collections.IComparer.Compare(object x, object y)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord recordX = x as global::Infragistics.Windows.DataPresenter.DataRecord;
				global::Infragistics.Windows.DataPresenter.DataRecord recordY = y as global::Infragistics.Windows.DataPresenter.DataRecord;
				return this.CompareHelper(recordX, recordY);
			}

			// Token: 0x06002688 RID: 9864 RVA: 0x000A7D34 File Offset: 0x000A5F34
			private int CompareHelper(global::Infragistics.Windows.DataPresenter.DataRecord recordX, global::Infragistics.Windows.DataPresenter.DataRecord recordY)
			{
				if (recordX == recordY)
				{
					return 0;
				}
				global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo[] sortedFields = this._sortedFields;
				if (recordX == null || recordY == null)
				{
					int num = (recordX != null) ? 1 : -1;
					if (sortedFields.Length > 0)
					{
						return num * sortedFields[0]._direction;
					}
				}
				int num2 = 0;
				global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo = null;
				global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo2 = null;
				bool flag = this._lastGroupByFieldWithGroupBySortComparer >= 0;
				int num3 = sortedFields.Length - 1;
				for (int i = 0; i <= num3; i++)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo fieldSortInfo = sortedFields[i];
					global::Infragistics.Windows.DataPresenter.Field field = fieldSortInfo._field;
					global::System.Collections.IComparer comparer = null;
					if (flag && fieldSortInfo._isGroupBy)
					{
						comparer = fieldSortInfo._groupByEvaluatorSortComparer;
						if (fieldSortInfo._comparer != null && fieldSortInfo._groupByEvaluator is global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator)
						{
							comparer = null;
						}
					}
					cellInfo = fieldSortInfo.GetCachedCellInfoX(recordX);
					cellInfo2 = fieldSortInfo.GetCachedCellInfoY(recordY);
					if (comparer != null)
					{
						global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo> comparer2 = comparer as global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>;
						if (comparer2 != null)
						{
							num2 = comparer2.Compare(cellInfo, cellInfo2);
						}
						else
						{
							num2 = comparer.Compare(recordX.Cells[field], recordY.Cells[field]);
						}
					}
					else
					{
						global::System.Collections.IComparer comparer3 = fieldSortInfo._comparer;
						if (comparer3 != null)
						{
							num2 = comparer3.Compare(cellInfo._value, cellInfo2._value);
						}
						else
						{
							object compareValue = cellInfo.GetCompareValue();
							object compareValue2 = cellInfo2.GetCompareValue();
							num2 = global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.DefaultCompare(compareValue, compareValue2, true, global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive == fieldSortInfo._comparisonType);
						}
					}
					if (num2 != 0)
					{
						return num2 * fieldSortInfo._direction;
					}
					if (flag && i == num3)
					{
						flag = false;
						i = this._firstGroupByFieldWithGroupBySortComparer - 1;
						num3 = this._lastGroupByFieldWithGroupBySortComparer;
					}
				}
				if (num2 == 0 && !this._areRecordsInUnsortedOrder)
				{
					int num4 = (cellInfo != null) ? cellInfo.DataItemIndex : recordX.DataItemIndex;
					int num5 = (cellInfo2 != null) ? cellInfo2.DataItemIndex : recordY.DataItemIndex;
					num2 = ((num4 < num5) ? -1 : 1);
				}
				return num2;
			}

			// Token: 0x06002689 RID: 9865 RVA: 0x000A7EF0 File Offset: 0x000A60F0
			public int Compare(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
			{
				return this.CompareHelper(x as global::Infragistics.Windows.DataPresenter.DataRecord, y as global::Infragistics.Windows.DataPresenter.DataRecord);
			}

			// Token: 0x04001228 RID: 4648
			private int _recordsBeingSortedCount;

			// Token: 0x04001229 RID: 4649
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x0400122A RID: 4650
			private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo[] _sortedFields;

			// Token: 0x0400122B RID: 4651
			private bool _areRecordsInUnsortedOrder;

			// Token: 0x0400122C RID: 4652
			private int _firstGroupByFieldWithGroupBySortComparer = -1;

			// Token: 0x0400122D RID: 4653
			private int _lastGroupByFieldWithGroupBySortComparer = -1;

			// Token: 0x0400122E RID: 4654
			private static global::System.Collections.Generic.Dictionary<global::System.Type, int> g_typeOrderTable;

			// Token: 0x0200031E RID: 798
			internal class CellInfo
			{
				// Token: 0x0600268A RID: 9866 RVA: 0x000A7F04 File Offset: 0x000A6104
				internal CellInfo(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo info)
				{
					this._record = record;
					this._fieldSortInfo = info;
					object cellValue = record.GetCellValue(info._field, true);
					if (info._editAsTypeUnderlying != info._dataTypeUnderlying && cellValue != null && !(cellValue is global::System.DBNull))
					{
						this._value = global::Infragistics.CoreUtilities.ConvertDataValue(cellValue, info._editAsTypeUnderlying, info._converterCultureResolved, null);
						return;
					}
					this._value = cellValue;
				}

				// Token: 0x17000B50 RID: 2896
				// (get) Token: 0x0600268B RID: 9867 RVA: 0x000A7F7C File Offset: 0x000A617C
				internal int DataItemIndex
				{
					get
					{
						if (this._dataItemIndex > 0)
						{
							return this._dataItemIndex;
						}
						return this._dataItemIndex = this._record.DataItemIndex;
					}
				}

				// Token: 0x0600268C RID: 9868 RVA: 0x000A7FAD File Offset: 0x000A61AD
				internal string GetCellText()
				{
					if (this._text == null)
					{
						this._text = this._fieldSortInfo._cellTextConverter.ConvertCellValue(this._value);
					}
					return this._text;
				}

				// Token: 0x0600268D RID: 9869 RVA: 0x000A7FDC File Offset: 0x000A61DC
				internal object GetCompareValue()
				{
					if (this._cachedCompareValue != null)
					{
						return this._cachedCompareValue;
					}
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo fieldSortInfo = this._fieldSortInfo;
					bool flag = !fieldSortInfo._cellTextConverter.SortByText;
					if (flag)
					{
						this._cachedCompareValue = this._value;
					}
					else
					{
						this._cachedCompareValue = this.GetCellText();
					}
					return this._cachedCompareValue;
				}

				// Token: 0x0400122F RID: 4655
				internal global::Infragistics.Windows.DataPresenter.DataRecord _record;

				// Token: 0x04001230 RID: 4656
				private int _dataItemIndex = -1;

				// Token: 0x04001231 RID: 4657
				internal object _value;

				// Token: 0x04001232 RID: 4658
				private object _cachedCompareValue;

				// Token: 0x04001233 RID: 4659
				private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo _fieldSortInfo;

				// Token: 0x04001234 RID: 4660
				private string _text;
			}

			// Token: 0x0200031F RID: 799
			internal class FieldSortInfo
			{
				// Token: 0x0600268E RID: 9870 RVA: 0x000A8034 File Offset: 0x000A6234
				internal FieldSortInfo(global::Infragistics.Windows.DataPresenter.Field field)
				{
					this.Initialize(new global::Infragistics.Windows.DataPresenter.FieldSortDescription
					{
						Field = field
					}, null, field.Owner);
				}

				// Token: 0x0600268F RID: 9871 RVA: 0x000A8062 File Offset: 0x000A6262
				internal FieldSortInfo(global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer comparerInfo, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
				{
					this.Initialize(fieldSortDescription, comparerInfo, fieldLayout);
				}

				// Token: 0x06002690 RID: 9872 RVA: 0x000A8074 File Offset: 0x000A6274
				private void Initialize(global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer comparerInfo, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldSortDescription.Field;
					if (field == null)
					{
						throw new global::System.ArgumentException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_8", new object[]
						{
							fieldSortDescription.FieldName,
							fieldLayout.Description
						}), "FieldName");
					}
					this._fieldSortDescription = fieldSortDescription;
					this._field = field;
					this._comparer = field.SortComparerResolved;
					this._groupByEvaluator = field.GroupByEvaluatorResolved;
					this._groupByEvaluatorSortComparer = ((this._groupByEvaluator != null) ? this._groupByEvaluator.SortComparer : null);
					this._direction = ((global::System.ComponentModel.ListSortDirection.Descending == fieldSortDescription.Direction) ? -1 : 1);
					this._comparisonType = field.SortComparisonTypeResolved;
					this._isGroupBy = field.IsGroupBy;
					this._dataTypeUnderlying = field.DataTypeUnderlying;
					this._editAsTypeUnderlying = global::Infragistics.CoreUtilities.GetUnderlyingType(field.EditAsTypeResolved);
					this._converterCultureResolved = field.ConverterCultureResolved;
					this._cellInfo = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo>(global::System.Math.Max(2, (comparerInfo != null && comparerInfo._recordsBeingSortedCount > 0) ? comparerInfo._recordsBeingSortedCount : 10), new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.ReferenceEqualityComparer<global::Infragistics.Windows.DataPresenter.Record>());
					this._cellTextConverter = global::Infragistics.Windows.DataPresenter.CellTextConverterInfo.GetCachedConverter(field);
				}

				// Token: 0x06002691 RID: 9873 RVA: 0x000A8188 File Offset: 0x000A6388
				internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo GetCellInfo(global::Infragistics.Windows.DataPresenter.DataRecord record)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo result;
					if (!this._cellInfo.TryGetValue(record, out result))
					{
						result = (this._cellInfo[record] = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo(record, this));
					}
					return result;
				}

				// Token: 0x06002692 RID: 9874 RVA: 0x000A81BC File Offset: 0x000A63BC
				internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo GetCachedCellInfoX(global::Infragistics.Windows.DataPresenter.DataRecord record)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo = this._lastInfoX;
					if (cellInfo != null && cellInfo._record == record)
					{
						return cellInfo;
					}
					cellInfo = this.GetCellInfo(record);
					this._lastInfoX = cellInfo;
					return cellInfo;
				}

				// Token: 0x06002693 RID: 9875 RVA: 0x000A81F0 File Offset: 0x000A63F0
				internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo GetCachedCellInfoY(global::Infragistics.Windows.DataPresenter.DataRecord record)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo cellInfo = this._lastInfoY;
					if (cellInfo != null && cellInfo._record == record)
					{
						return cellInfo;
					}
					cellInfo = this.GetCellInfo(record);
					this._lastInfoY = cellInfo;
					return cellInfo;
				}

				// Token: 0x06002694 RID: 9876 RVA: 0x000A8224 File Offset: 0x000A6424
				internal object GetCellValueAsEditAsType(global::Infragistics.Windows.DataPresenter.DataRecord record)
				{
					object obj = record.GetCellValue(this._field, true);
					if (this._editAsTypeUnderlying != this._dataTypeUnderlying && obj != null && !(obj is global::System.DBNull))
					{
						obj = global::Infragistics.CoreUtilities.ConvertDataValue(obj, this._editAsTypeUnderlying, this._converterCultureResolved, null);
					}
					return obj;
				}

				// Token: 0x04001235 RID: 4661
				internal global::Infragistics.Windows.DataPresenter.FieldSortDescription _fieldSortDescription;

				// Token: 0x04001236 RID: 4662
				internal global::Infragistics.Windows.DataPresenter.Field _field;

				// Token: 0x04001237 RID: 4663
				internal global::System.Collections.IComparer _comparer;

				// Token: 0x04001238 RID: 4664
				internal global::Infragistics.Windows.DataPresenter.IGroupByEvaluator _groupByEvaluator;

				// Token: 0x04001239 RID: 4665
				internal global::System.Collections.IComparer _groupByEvaluatorSortComparer;

				// Token: 0x0400123A RID: 4666
				internal int _direction;

				// Token: 0x0400123B RID: 4667
				internal global::Infragistics.Windows.DataPresenter.FieldSortComparisonType _comparisonType;

				// Token: 0x0400123C RID: 4668
				internal bool _isGroupBy;

				// Token: 0x0400123D RID: 4669
				internal global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo> _cellInfo;

				// Token: 0x0400123E RID: 4670
				internal global::System.Type _dataTypeUnderlying;

				// Token: 0x0400123F RID: 4671
				internal global::System.Type _editAsTypeUnderlying;

				// Token: 0x04001240 RID: 4672
				internal global::System.Globalization.CultureInfo _converterCultureResolved;

				// Token: 0x04001241 RID: 4673
				internal global::Infragistics.Windows.DataPresenter.CellTextConverterInfo _cellTextConverter;

				// Token: 0x04001242 RID: 4674
				private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo _lastInfoX;

				// Token: 0x04001243 RID: 4675
				private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo _lastInfoY;
			}

			// Token: 0x02000320 RID: 800
			private class ReferenceEqualityComparer<T> : global::System.Collections.Generic.IEqualityComparer<T>
			{
				// Token: 0x06002695 RID: 9877 RVA: 0x000A8272 File Offset: 0x000A6472
				public bool Equals(T x, T y)
				{
					return object.ReferenceEquals(x, y);
				}

				// Token: 0x06002696 RID: 9878 RVA: 0x000A8285 File Offset: 0x000A6485
				public int GetHashCode(T obj)
				{
					return obj.GetHashCode();
				}
			}
		}

		// Token: 0x02000321 RID: 801
		private class DataRecordHolder
		{
			// Token: 0x06002698 RID: 9880 RVA: 0x000A829C File Offset: 0x000A649C
			internal DataRecordHolder(global::Infragistics.Windows.DataPresenter.DataRecord record, object comparisionListObject) : this(comparisionListObject)
			{
				this.record = record;
			}

			// Token: 0x06002699 RID: 9881 RVA: 0x000A82AC File Offset: 0x000A64AC
			internal DataRecordHolder(object comparisionListObject)
			{
				this.comparisionListObject = comparisionListObject;
			}

			// Token: 0x0600269A RID: 9882 RVA: 0x000A82BB File Offset: 0x000A64BB
			public override int GetHashCode()
			{
				if (this.comparisionListObject != null)
				{
					return this.comparisionListObject.GetHashCode();
				}
				return 0;
			}

			// Token: 0x0600269B RID: 9883 RVA: 0x000A82D4 File Offset: 0x000A64D4
			public override bool Equals(object o)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder dataRecordHolder = o as global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder;
				return dataRecordHolder != null && dataRecordHolder.comparisionListObject == this.comparisionListObject;
			}

			// Token: 0x04001244 RID: 4676
			internal object comparisionListObject;

			// Token: 0x04001245 RID: 4677
			internal global::Infragistics.Windows.DataPresenter.DataRecord record;
		}

		// Token: 0x02000322 RID: 802
		private class ChangeNotification
		{
			// Token: 0x0600269C RID: 9884 RVA: 0x000A82FB File Offset: 0x000A64FB
			internal ChangeNotification(object sender, object eventArgs)
			{
				this.Sender = sender;
				this.EventArgs = eventArgs;
			}

			// Token: 0x04001246 RID: 4678
			internal object Sender;

			// Token: 0x04001247 RID: 4679
			internal object EventArgs;

			// Token: 0x02000323 RID: 803
			internal class EqualityComparer : global::System.Collections.IEqualityComparer
			{
				// Token: 0x0600269D RID: 9885 RVA: 0x000A8311 File Offset: 0x000A6511
				private static string GetPropertyName(global::System.ComponentModel.PropertyDescriptor pd)
				{
					if (pd == null)
					{
						return null;
					}
					return pd.Name;
				}

				// Token: 0x0600269E RID: 9886 RVA: 0x000A831E File Offset: 0x000A651E
				private static int GetHashCodeHelper(object s)
				{
					if (s == null)
					{
						return 0;
					}
					return s.GetHashCode();
				}

				// Token: 0x0600269F RID: 9887 RVA: 0x000A832C File Offset: 0x000A652C
				bool global::System.Collections.IEqualityComparer.Equals(object x, object y)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification changeNotification = x as global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification;
					global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification changeNotification2 = y as global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification;
					if (changeNotification != null && changeNotification2 != null)
					{
						global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = changeNotification.EventArgs as global::System.ComponentModel.PropertyChangedEventArgs;
						if (propertyChangedEventArgs != null)
						{
							global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs2 = changeNotification2.EventArgs as global::System.ComponentModel.PropertyChangedEventArgs;
							if (propertyChangedEventArgs != null && propertyChangedEventArgs2 != null && changeNotification.Sender == changeNotification2.Sender && propertyChangedEventArgs.PropertyName == propertyChangedEventArgs2.PropertyName)
							{
								return true;
							}
						}
						else
						{
							global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs = changeNotification.EventArgs as global::System.ComponentModel.ListChangedEventArgs;
							if (listChangedEventArgs != null)
							{
								global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs2 = changeNotification2.EventArgs as global::System.ComponentModel.ListChangedEventArgs;
								if (listChangedEventArgs != null && listChangedEventArgs2 != null && listChangedEventArgs.NewIndex == listChangedEventArgs2.NewIndex && global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification.EqualityComparer.GetPropertyName(listChangedEventArgs.PropertyDescriptor) == global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification.EqualityComparer.GetPropertyName(listChangedEventArgs2.PropertyDescriptor) && global::System.ComponentModel.ListChangedType.ItemChanged == listChangedEventArgs.ListChangedType && global::System.ComponentModel.ListChangedType.ItemChanged == listChangedEventArgs2.ListChangedType)
								{
									return true;
								}
							}
						}
					}
					return false;
				}

				// Token: 0x060026A0 RID: 9888 RVA: 0x000A840C File Offset: 0x000A660C
				int global::System.Collections.IEqualityComparer.GetHashCode(object obj)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification changeNotification = obj as global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification;
					if (changeNotification != null)
					{
						global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = changeNotification.EventArgs as global::System.ComponentModel.PropertyChangedEventArgs;
						if (propertyChangedEventArgs != null)
						{
							return global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification.EqualityComparer.GetHashCodeHelper(changeNotification.Sender) ^ global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification.EqualityComparer.GetHashCodeHelper(propertyChangedEventArgs.PropertyName);
						}
						global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs = changeNotification.EventArgs as global::System.ComponentModel.ListChangedEventArgs;
						if (listChangedEventArgs != null)
						{
							return listChangedEventArgs.NewIndex.GetHashCode() ^ global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification.EqualityComparer.GetHashCodeHelper(global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification.EqualityComparer.GetPropertyName(listChangedEventArgs.PropertyDescriptor));
						}
					}
					return 0;
				}
			}
		}

		// Token: 0x02000324 RID: 804
		private struct SortGroupVersionStatus
		{
			// Token: 0x060026A2 RID: 9890 RVA: 0x000A8482 File Offset: 0x000A6682
			internal SortGroupVersionStatus(bool isSortVersionChanged, bool isGroupByVersionChanged, bool hasSortFields, bool hasGroupByFields)
			{
				this._hasGroupByFields = hasGroupByFields;
				this._hasSortFields = hasSortFields;
				this._isGroupByVersionChanged = isGroupByVersionChanged;
				this._isSortVersionChanged = isSortVersionChanged;
			}

			// Token: 0x17000B51 RID: 2897
			// (get) Token: 0x060026A3 RID: 9891 RVA: 0x000A84A1 File Offset: 0x000A66A1
			internal bool HasSortFields
			{
				get
				{
					return this._hasSortFields;
				}
			}

			// Token: 0x17000B52 RID: 2898
			// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000A84A9 File Offset: 0x000A66A9
			internal bool HasGroupByFields
			{
				get
				{
					return this._hasGroupByFields;
				}
			}

			// Token: 0x17000B53 RID: 2899
			// (get) Token: 0x060026A5 RID: 9893 RVA: 0x000A84B1 File Offset: 0x000A66B1
			internal bool IsSortVersionChanged
			{
				get
				{
					return this._isSortVersionChanged;
				}
			}

			// Token: 0x17000B54 RID: 2900
			// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000A84B9 File Offset: 0x000A66B9
			internal bool IsGroupByVersionChanged
			{
				get
				{
					return this._isGroupByVersionChanged;
				}
			}

			// Token: 0x04001248 RID: 4680
			private bool _isSortVersionChanged;

			// Token: 0x04001249 RID: 4681
			private bool _isGroupByVersionChanged;

			// Token: 0x0400124A RID: 4682
			private bool _hasSortFields;

			// Token: 0x0400124B RID: 4683
			private bool _hasGroupByFields;
		}

		// Token: 0x02000325 RID: 805
		internal class SortGroupVersionTracker
		{
			// Token: 0x060026A7 RID: 9895 RVA: 0x000A84C4 File Offset: 0x000A66C4
			internal SortGroupVersionTracker(global::Infragistics.Windows.DataPresenter.RecordManager rm, global::Infragistics.Windows.DataPresenter.FieldLayout fl)
			{
				this._fl = fl;
				this._sortVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fl, "SortVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(rm.OnSortGroupByVersionChanged), true);
				this._groupByVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fl, "GroupByVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(rm.OnSortGroupByVersionChanged), true);
			}

			// Token: 0x17000B55 RID: 2901
			// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000A851A File Offset: 0x000A671A
			internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
			{
				get
				{
					return this._fl;
				}
			}

			// Token: 0x17000B56 RID: 2902
			// (get) Token: 0x060026A9 RID: 9897 RVA: 0x000A8522 File Offset: 0x000A6722
			internal int GroupByVersion
			{
				get
				{
					return this._groupByVersion;
				}
			}

			// Token: 0x17000B57 RID: 2903
			// (get) Token: 0x060026AA RID: 9898 RVA: 0x000A852A File Offset: 0x000A672A
			internal int SortVersion
			{
				get
				{
					return this._sortVersion;
				}
			}

			// Token: 0x060026AB RID: 9899 RVA: 0x000A8532 File Offset: 0x000A6732
			internal void DirtyVersionNumbers()
			{
				this._sortVersion--;
				this._groupByVersion--;
			}

			// Token: 0x060026AC RID: 9900 RVA: 0x000A8550 File Offset: 0x000A6750
			internal void SyncVersionNumbers()
			{
				this._sortVersion = this._fl.SortVersion;
				this._groupByVersion = this._fl.GroupByVersion;
			}

			// Token: 0x0400124C RID: 4684
			private global::Infragistics.Windows.Internal.PropertyValueTracker _sortVersionTracker;

			// Token: 0x0400124D RID: 4685
			private global::Infragistics.Windows.Internal.PropertyValueTracker _groupByVersionTracker;

			// Token: 0x0400124E RID: 4686
			private int _sortVersion;

			// Token: 0x0400124F RID: 4687
			private int _groupByVersion;

			// Token: 0x04001250 RID: 4688
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fl;
		}
	}
}
