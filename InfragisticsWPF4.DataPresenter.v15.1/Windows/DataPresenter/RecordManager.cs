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
	// Token: 0x02000358 RID: 856
	public class RecordManager : global::Infragistics.PropertyChangeNotifier, global::System.Windows.IWeakEventListener
	{
		// Token: 0x0600298F RID: 10639 RVA: 0x000B6C20 File Offset: 0x000B4E20
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

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x000B6CBB File Offset: 0x000B4EBB
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002991 RID: 10641 RVA: 0x000B6CD4 File Offset: 0x000B4ED4
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

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x000B6D17 File Offset: 0x000B4F17
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x06002993 RID: 10643 RVA: 0x000B6D1F File Offset: 0x000B4F1F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool DataSourceAllowsAddNew
		{
			get
			{
				return this.AllowsAddNewCore && this.DoesTypeSupportEditInList();
			}
		}

		// Token: 0x17000C47 RID: 3143
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x000B6D34 File Offset: 0x000B4F34
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

		// Token: 0x17000C48 RID: 3144
		// (get) Token: 0x06002995 RID: 10645 RVA: 0x000B6D90 File Offset: 0x000B4F90
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

		// Token: 0x17000C49 RID: 3145
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
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

		// Token: 0x17000C4A RID: 3146
		// (get) Token: 0x06002997 RID: 10647 RVA: 0x000B6DD0 File Offset: 0x000B4FD0
		internal global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection FilteredInDataItemsIfAllocated
		{
			get
			{
				return this._filteredInDataItems;
			}
		}

		// Token: 0x17000C4B RID: 3147
		// (get) Token: 0x06002998 RID: 10648 RVA: 0x000B6DD8 File Offset: 0x000B4FD8
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

		// Token: 0x17000C4C RID: 3148
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x000B6E3F File Offset: 0x000B503F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasGroups
		{
			get
			{
				return this._groups != null && this._groups.Count > 0;
			}
		}

		// Token: 0x17000C4D RID: 3149
		// (get) Token: 0x0600299A RID: 10650 RVA: 0x000B6E59 File Offset: 0x000B5059
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000C4E RID: 3150
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x000B6E61 File Offset: 0x000B5061
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x000B6E69 File Offset: 0x000B5069
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasMultipleFieldLayouts
		{
			get
			{
				return this._hasMultipleFieldLayouts;
			}
			private set
			{
				if (value != this._hasMultipleFieldLayouts)
				{
					this._hasMultipleFieldLayouts = value;
					this.OnPropertyChanged("HasMultipleFieldLayouts");
				}
			}
		}

		// Token: 0x17000C4F RID: 3151
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x000B6E86 File Offset: 0x000B5086
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool IsSorted
		{
			get
			{
				return this._isSorted;
			}
		}

		// Token: 0x17000C50 RID: 3152
		// (get) Token: 0x0600299E RID: 10654 RVA: 0x000B6E8E File Offset: 0x000B508E
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord ParentRecord
		{
			get
			{
				return this._parentRecord;
			}
		}

		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x0600299F RID: 10655 RVA: 0x000B6E96 File Offset: 0x000B5096
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x060029A0 RID: 10656 RVA: 0x000B6EAD File Offset: 0x000B50AD
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

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060029A1 RID: 10657 RVA: 0x000B6EC9 File Offset: 0x000B50C9
		internal global::Infragistics.Windows.DataPresenter.RecordFilterCollection RecordFiltersIfAllocated
		{
			get
			{
				return this._recordFilters;
			}
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000B6ED1 File Offset: 0x000B50D1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerializeRecordFilters()
		{
			return this._recordFilters != null && this._recordFilters.ShouldSerialize();
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000B6EE8 File Offset: 0x000B50E8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public void ResetRecordFilters()
		{
			if (this._recordFilters != null)
			{
				this._recordFilters.Clear();
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x000B6EFD File Offset: 0x000B50FD
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.DataPresenter.DataRecordCollection Sorted
		{
			get
			{
				this.VerifyRootDataSource();
				return this._sortedRecords;
			}
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060029A5 RID: 10661 RVA: 0x000B6F0B File Offset: 0x000B510B
		public global::System.Collections.IEnumerable SourceItems
		{
			get
			{
				return this._sourceItems;
			}
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x000B6F13 File Offset: 0x000B5113
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataRecord> Unsorted
		{
			get
			{
				return this.UnsortedInternalVerify;
			}
		}

		// Token: 0x17000C57 RID: 3159
		// (get) Token: 0x060029A7 RID: 10663 RVA: 0x000B6F1C File Offset: 0x000B511C
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

		// Token: 0x17000C58 RID: 3160
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x000B6FA6 File Offset: 0x000B51A6
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x000B6FAE File Offset: 0x000B51AE
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

		// Token: 0x17000C59 RID: 3161
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x000B6FB7 File Offset: 0x000B51B7
		internal global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation BeginUpdateInfo
		{
			get
			{
				return this._beginUpdateInfo;
			}
		}

		// Token: 0x17000C5A RID: 3162
		// (get) Token: 0x060029AB RID: 10667 RVA: 0x000B6FBF File Offset: 0x000B51BF
		internal global::System.ComponentModel.IBindingList BindingList
		{
			get
			{
				return this._bindingList;
			}
		}

		// Token: 0x17000C5B RID: 3163
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x000B6FC7 File Offset: 0x000B51C7
		internal bool CanGetPropertiesFromDataSourceWithoutItems
		{
			get
			{
				return this._canGetPropertiesFromDataSourceWithoutItems;
			}
		}

		// Token: 0x17000C5C RID: 3164
		// (get) Token: 0x060029AD RID: 10669 RVA: 0x000B6FCF File Offset: 0x000B51CF
		internal global::Infragistics.Windows.DataPresenter.DataRecord CurrentAddRecordInternal
		{
			get
			{
				return this._currentAddRecord;
			}
		}

		// Token: 0x17000C5D RID: 3165
		// (get) Token: 0x060029AE RID: 10670 RVA: 0x000B6FD7 File Offset: 0x000B51D7
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

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x060029AF RID: 10671 RVA: 0x000B6FEE File Offset: 0x000B51EE
		internal global::System.Collections.Generic.IEqualityComparer<object> DataItemComparer
		{
			get
			{
				if (this._dataPresenter == null)
				{
					return global::Infragistics.Windows.DataPresenter.ReferenceEqualityComparer.Instance;
				}
				return this._dataPresenter.DataItemEqualityComparerResolved;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000B7009 File Offset: 0x000B5209
		// (set) Token: 0x060029B1 RID: 10673 RVA: 0x000B7011 File Offset: 0x000B5211
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

		// Token: 0x060029B2 RID: 10674 RVA: 0x000B703C File Offset: 0x000B523C
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
				if (this._collectionView == null && currentValue != null && this._parentRecord == null && this._dataPresenter.IsSynchronizedWithCurrentItem)
				{
					this._collectionView = global::System.Windows.Data.CollectionViewSource.GetDefaultView(currentValue);
				}
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

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x060029B3 RID: 10675 RVA: 0x000B7175 File Offset: 0x000B5375
		internal bool DataSourceRaisesCellValueChangeEvents
		{
			get
			{
				return this._dataSourceRaisesCellValueChangeEvents;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x060029B4 RID: 10676 RVA: 0x000B717D File Offset: 0x000B537D
		internal global::Infragistics.Windows.EditableCollectionViewProxy EditableCollectionView
		{
			get
			{
				return this._editableCollectionView;
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x060029B5 RID: 10677 RVA: 0x000B7185 File Offset: 0x000B5385
		internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x060029B6 RID: 10678 RVA: 0x000B718D File Offset: 0x000B538D
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

		// Token: 0x060029B7 RID: 10679 RVA: 0x000B71A4 File Offset: 0x000B53A4
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

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x060029B8 RID: 10680 RVA: 0x000B71F4 File Offset: 0x000B53F4
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

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x060029B9 RID: 10681 RVA: 0x000B720B File Offset: 0x000B540B
		internal global::Infragistics.Windows.DataPresenter.GroupByRecordCollection GroupsInternal
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x000B7214 File Offset: 0x000B5414
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

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x060029BB RID: 10683 RVA: 0x000B7240 File Offset: 0x000B5440
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

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x000B728F File Offset: 0x000B548F
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x000B7297 File Offset: 0x000B5497
		internal bool IsInBulkOperation { get; set; }

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x000B72A0 File Offset: 0x000B54A0
		internal bool IsInReset
		{
			get
			{
				return this._isInReset;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x060029BF RID: 10687 RVA: 0x000B72A8 File Offset: 0x000B54A8
		internal bool IsCurrentAddRecordAllocated
		{
			get
			{
				return this._currentAddRecord != null;
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000B72B6 File Offset: 0x000B54B6
		internal bool IsCollectionView
		{
			get
			{
				return this._collectionView != null;
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x060029C1 RID: 10689 RVA: 0x000B72C4 File Offset: 0x000B54C4
		// (set) Token: 0x060029C2 RID: 10690 RVA: 0x000B72CC File Offset: 0x000B54CC
		internal bool IsInVerifySort { get; private set; }

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x060029C3 RID: 10691 RVA: 0x000B72D5 File Offset: 0x000B54D5
		internal bool IsObservable
		{
			get
			{
				return this._notifyCollectionChangedHooked != null || this._bindingList != null;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000B72ED File Offset: 0x000B54ED
		internal bool IsRootManager
		{
			get
			{
				return null == this._parentRecord;
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x060029C5 RID: 10693 RVA: 0x000B72F8 File Offset: 0x000B54F8
		internal bool IsStillValid
		{
			get
			{
				if (this._parentRecord == null)
				{
					return this._dataPresenter != null && this._dataPresenter.RecordManager == this;
				}
				return this._parentRecord.IsStillValid;
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000B7326 File Offset: 0x000B5526
		internal bool IsUpdating
		{
			get
			{
				return null != this._beginUpdateInfo;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060029C7 RID: 10695 RVA: 0x000B7334 File Offset: 0x000B5534
		internal global::System.Collections.IList List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000B733C File Offset: 0x000B553C
		internal int NestingDepth
		{
			get
			{
				return this._nestingDepth;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x060029C9 RID: 10697 RVA: 0x000B7354 File Offset: 0x000B5554
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection RecordFiltersResolved
		{
			get
			{
				if (this._recordFiltersResolved == null)
				{
					this._recordFiltersResolved = new global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection(this);
					if (this._parentRecord == null && !this._dataPresenter.IsExportControl)
					{
						this._filterVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._recordFiltersResolved, global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection.VersionProperty, delegate()
						{
							this._dataPresenter.OnRootFilterCriteriaChanged();
						}, false);
					}
				}
				return this._recordFiltersResolved;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x000B73BA File Offset: 0x000B55BA
		internal global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection RecordFiltersResolvedIfAllocated
		{
			get
			{
				return this._recordFiltersResolved;
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060029CB RID: 10699 RVA: 0x000B73C4 File Offset: 0x000B55C4
		internal int ScrollCountVersion
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				return this._scrollCountVersion + ((dataPresenter != null) ? dataPresenter._cachedScrollCountRecalcVersion : 0);
			}
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060029CC RID: 10700 RVA: 0x000B73EB File Offset: 0x000B55EB
		internal global::Infragistics.Windows.DataPresenter.DataRecordCollection SortedInternal
		{
			get
			{
				return this._sortedRecords;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060029CD RID: 10701 RVA: 0x000B73F3 File Offset: 0x000B55F3
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

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x060029CE RID: 10702 RVA: 0x000B740A File Offset: 0x000B560A
		internal int UnderlyingDataVersion
		{
			get
			{
				return this._underlyingDataVersion;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x060029CF RID: 10703 RVA: 0x000B7412 File Offset: 0x000B5612
		internal global::Infragistics.Windows.DataPresenter.DataRecordCollection UnsortedInternalVerify
		{
			get
			{
				this.VerifyRootDataSource();
				return this._unsortedRecords;
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x060029D0 RID: 10704 RVA: 0x000B7420 File Offset: 0x000B5620
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

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060029D1 RID: 10705 RVA: 0x000B7444 File Offset: 0x000B5644
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

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060029D2 RID: 10706 RVA: 0x000B74C1 File Offset: 0x000B56C1
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

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060029D3 RID: 10707 RVA: 0x000B74EC File Offset: 0x000B56EC
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

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x000B7580 File Offset: 0x000B5780
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

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060029D5 RID: 10709 RVA: 0x000B75EE File Offset: 0x000B57EE
		internal bool IsResetPending
		{
			get
			{
				return this._resetOperationPending != null;
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x000B75FC File Offset: 0x000B57FC
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataRecord> RecordsInsertedAtTop
		{
			get
			{
				return this.ViewableRecords.RecordsInsertedAtTop;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x060029D7 RID: 10711 RVA: 0x000B760C File Offset: 0x000B580C
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

		// Token: 0x17000C82 RID: 3202
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x000B7651 File Offset: 0x000B5851
		private bool TreatUpdatesAsResets
		{
			get
			{
				return this._collectionView != null && this._list == null;
			}
		}

		// Token: 0x060029D9 RID: 10713 RVA: 0x000B7668 File Offset: 0x000B5868
		public void CommitAddRecord()
		{
			global::Infragistics.Windows.DataPresenter.DataRecord currentAddRecord = this.CurrentAddRecord;
			if (currentAddRecord != null)
			{
				if (currentAddRecord.IsAddRecordTemplate)
				{
					currentAddRecord.OnEditValueChanged(true, false);
				}
				currentAddRecord.Update();
			}
		}

		// Token: 0x060029DA RID: 10714 RVA: 0x000B7698 File Offset: 0x000B5898
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> GetFilteredInDataRecords()
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria criteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaChain(new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_RecordVisible(), new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_FilteredInRecords(), false);
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.DataRecord>(this.Sorted, criteria);
		}

		// Token: 0x060029DB RID: 10715 RVA: 0x000B76C4 File Offset: 0x000B58C4
		public global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataRecord> GetFilteredOutDataRecords()
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria meetsCriteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteria_FilteredInRecords();
			meetsCriteria = new global::Infragistics.Windows.DataPresenter.GridUtilities.MeetsCriteriaComplement(meetsCriteria);
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.DataRecord>(this.Sorted, meetsCriteria);
		}

		// Token: 0x060029DC RID: 10716 RVA: 0x000B76EA File Offset: 0x000B58EA
		public global::Infragistics.Windows.DataPresenter.RecordFilterCollection GetRecordFiltersResolved(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return this.RecordFiltersResolved.GetRecordFilters(fieldLayout, true);
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000B76FC File Offset: 0x000B58FC
		public void ResetDataValueHistory(bool recursive)
		{
			foreach (object obj in this._unsortedRecords.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)obj;
				dataRecord.ResetDataValueHistory(recursive);
			}
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000B7760 File Offset: 0x000B5960
		internal object AddNew()
		{
			return this.AddNew(0);
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000B776C File Offset: 0x000B596C
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
					this.RecordsInsertedAtTop.Add(currentAddRecord);
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

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x060029E0 RID: 10720 RVA: 0x000B7930 File Offset: 0x000B5B30
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

		// Token: 0x060029E1 RID: 10721 RVA: 0x000B7A22 File Offset: 0x000B5C22
		internal void BeginUpdate()
		{
			if (this._beginUpdateInfo == null)
			{
				this._beginUpdateInfo = new global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation(this);
			}
			this._beginUpdateInfo._beginUpdateCount++;
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000B7A4B File Offset: 0x000B5C4B
		internal void Clear()
		{
			this.Clear(true, true);
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000B7A58 File Offset: 0x000B5C58
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

		// Token: 0x060029E4 RID: 10724 RVA: 0x000B7B33 File Offset: 0x000B5D33
		internal void ClearCachedRecordsAndReset()
		{
			this.Clear();
			this.OnSourceCollectionReset();
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000B7B44 File Offset: 0x000B5D44
		internal void ClearFilters()
		{
			this.ResetRecordFilters();
			if (this._unsortedRecords == null)
			{
				return;
			}
			foreach (object obj in this._unsortedRecords.SparseArray.NonNullItems)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = obj as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordCollection childRecordsIfAllocated = dataRecord.ChildRecordsIfAllocated;
					if (childRecordsIfAllocated != null)
					{
						foreach (object obj2 in childRecordsIfAllocated.SparseArray.NonNullItems)
						{
							global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = obj2 as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
							global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (expandableFieldRecord != null) ? expandableFieldRecord.ChildRecordManagerIfAllocated : null;
							if (recordManager != null)
							{
								recordManager.ClearFilters();
							}
						}
					}
				}
			}
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000B7C34 File Offset: 0x000B5E34
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

		// Token: 0x060029E7 RID: 10727 RVA: 0x000B7D38 File Offset: 0x000B5F38
		internal bool ContainsFieldLayout(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			return this._fieldLayout == fl || (this._sortGroupByVersionTrackers != null && this._sortGroupByVersionTrackers.ContainsKey(fl));
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000B7D5C File Offset: 0x000B5F5C
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

		// Token: 0x060029E9 RID: 10729 RVA: 0x000B7EC0 File Offset: 0x000B60C0
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

		// Token: 0x060029EA RID: 10730 RVA: 0x000B7F4D File Offset: 0x000B614D
		internal static bool DoesBindingListSupportAddNew(global::System.ComponentModel.IBindingList bindingList, bool canGetPropertiesFromDataSourceWithoutItems)
		{
			return bindingList != null && bindingList.AllowNew && (canGetPropertiesFromDataSourceWithoutItems || bindingList.Count > 0);
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x000B7F6C File Offset: 0x000B616C
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

		// Token: 0x060029EC RID: 10732 RVA: 0x000B7FE3 File Offset: 0x000B61E3
		internal object GetAddRecordCellData(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._addRecordCellDataDictionary != null && this._addRecordCellDataDictionary.Count > 0 && this._addRecordCellDataDictionary.Contains(field))
			{
				return this._addRecordCellDataDictionary[field];
			}
			return null;
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000B8018 File Offset: 0x000B6218
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
				if (this._parentRecord == null && associatedRecordManager.DataSource != associatedRecordManager.DataPresenter.DataSourceInternal)
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

		// Token: 0x060029EE RID: 10734 RVA: 0x000B8154 File Offset: 0x000B6354
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

		// Token: 0x060029EF RID: 10735 RVA: 0x000B828C File Offset: 0x000B648C
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

		// Token: 0x060029F0 RID: 10736 RVA: 0x000B8310 File Offset: 0x000B6510
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

		// Token: 0x060029F1 RID: 10737 RVA: 0x000B8345 File Offset: 0x000B6545
		internal void OnCellValueChangeNotification(global::Infragistics.Windows.DataPresenter.DataRecord record, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnChangeNotification(record, e, false, true);
		}

		// Token: 0x060029F2 RID: 10738 RVA: 0x000B8354 File Offset: 0x000B6554
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

		// Token: 0x060029F3 RID: 10739 RVA: 0x000B839C File Offset: 0x000B659C
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
					else if (((global::Infragistics.Windows.DataPresenter.DataChangeType.AddRecord == dataChangeType && fl.ReevaluateFiltersOnRecordsAddedResolved) || global::Infragistics.Windows.DataPresenter.DataChangeType.RemoveRecord == dataChangeType) && recordFiltersResolved.DoesFilterCriteriaUseAllValues(fieldContext, recordContext))
					{
						flag = true;
					}
				}
				if (global::Infragistics.Windows.DataPresenter.DataChangeType.AddRecord == dataChangeType && !fl.ReevaluateFiltersOnRecordsAddedResolved)
				{
					recordContext._cachedFilterState = (global::Infragistics.Windows.DataPresenter.Record.FilterState)((short)(recordContext._cachedFilterState & ~global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter) | 4);
				}
				if (flag)
				{
					recordFiltersResolved.BumpVersion();
				}
			}
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x000B8494 File Offset: 0x000B6694
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

		// Token: 0x060029F5 RID: 10741 RVA: 0x000B84D8 File Offset: 0x000B66D8
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

		// Token: 0x060029F6 RID: 10742 RVA: 0x000B855C File Offset: 0x000B675C
		internal void OnIsSynchronizedWithCurrentItemSet()
		{
			if (this._collectionView == null && this._sourceItems != null)
			{
				this.SetDataSource(this._sourceItems, !this._hasSourceBeenSetAtLeastOnce);
			}
			this.SetActiveRecordFromCurrentItem();
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000B8589 File Offset: 0x000B6789
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

		// Token: 0x060029F8 RID: 10744 RVA: 0x000B85C4 File Offset: 0x000B67C4
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

		// Token: 0x060029F9 RID: 10745 RVA: 0x000B87C0 File Offset: 0x000B69C0
		internal void RaiseCurrentChangedHelper()
		{
			base.RaisePropertyChangedEvent("Current");
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000B87CD File Offset: 0x000B69CD
		internal void RemoveAt(int index)
		{
			this.RemoveAt(index, true);
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x000B87D8 File Offset: 0x000B69D8
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

		// Token: 0x060029FC RID: 10748 RVA: 0x000B88C8 File Offset: 0x000B6AC8
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

		// Token: 0x060029FD RID: 10749 RVA: 0x000B89C0 File Offset: 0x000B6BC0
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

		// Token: 0x060029FE RID: 10750 RVA: 0x000B89FE File Offset: 0x000B6BFE
		internal void SetActiveRecordFromCurrentItem()
		{
			this.SetActiveRecordFromCurrentItem(false);
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x000B8A08 File Offset: 0x000B6C08
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
				if (dataRecord != null && this._dataPresenter.ScrollBehaviorOnListChange != global::Infragistics.Windows.DataPresenter.ScrollBehaviorOnListChange.PreserveRecordsInView)
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

		// Token: 0x06002A00 RID: 10752 RVA: 0x000B8B18 File Offset: 0x000B6D18
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

		// Token: 0x06002A01 RID: 10753 RVA: 0x000B8BCC File Offset: 0x000B6DCC
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

		// Token: 0x06002A02 RID: 10754 RVA: 0x000B8C74 File Offset: 0x000B6E74
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

		// Token: 0x06002A03 RID: 10755 RVA: 0x000B8CE5 File Offset: 0x000B6EE5
		internal void UnwireCollectionViewEvents()
		{
			if (this._collectionView != null)
			{
				global::System.ComponentModel.CurrentChangingEventManager.RemoveListener(this._collectionView, this);
				global::System.ComponentModel.CurrentChangedEventManager.RemoveListener(this._collectionView, this);
			}
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x000B8D08 File Offset: 0x000B6F08
		internal void UnwireAllEvents()
		{
			this.UnwireCollectionViewEvents();
			if (this._notifyCollectionChangedHooked != null)
			{
				global::System.Collections.Specialized.CollectionChangedEventManager.RemoveListener(this._notifyCollectionChangedHooked, this);
				this._notifyCollectionChangedHooked = null;
			}
			if (this._bindingList != null)
			{
				global::Infragistics.Windows.Helpers.BindingListChangedEventManager.RemoveListener(this._bindingList, this);
				this._bindingList = null;
			}
			if (this._fieldLayout != null)
			{
				global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._fieldLayout, this, string.Empty);
			}
		}

		// Token: 0x06002A05 RID: 10757 RVA: 0x000B8D6C File Offset: 0x000B6F6C
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

		// Token: 0x06002A06 RID: 10758 RVA: 0x000B8DF4 File Offset: 0x000B6FF4
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

		// Token: 0x06002A07 RID: 10759 RVA: 0x000B8E60 File Offset: 0x000B7060
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

		// Token: 0x06002A08 RID: 10760 RVA: 0x000B8F20 File Offset: 0x000B7120
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
			bool isSorted = this._isSorted;
			this.IsInVerifySort = true;
			global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
			bool flag3 = false;
			if (dataPresenterExportControlBase != null && this._associatedRecordMap == null && dataPresenterExportControlBase.BypassInitializeRecordEvent && this._unsortedRecords.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager associatedRecordManager = this.AssociatedRecordManager;
				if (associatedRecordManager != null && (associatedRecordManager.HasMultipleFieldLayouts || associatedRecordManager._fieldLayout == null || associatedRecordManager._fieldLayout.HasUnboundFieldsWithoutBindings))
				{
					foreach (global::Infragistics.Windows.DataPresenter.DataRecord dataRecord in this._unsortedRecords)
					{
						if (dataRecord != null && dataRecord.FieldLayout.HasUnboundFieldsWithoutBindings)
						{
							global::Infragistics.Windows.DataPresenter.DataRecord associatedDr = dataRecord.GetAssociatedRecord() as global::Infragistics.Windows.DataPresenter.DataRecord;
							dataRecord.CloneAssociatedCellSettings(associatedDr);
						}
					}
				}
				flag3 = (this._associatedRecordMap != null);
			}
			bool flag4 = true;
			if (this._sortedRecords.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._unsortedRecords[0].FieldLayout;
				sortGroupByVersionStatus = this.GetSortGroupByVersionStatus();
				this._isSorted = false;
				this.InitializeFieldLayout(fieldLayout);
				bool flag5 = this.DataPresenter.SortRecordsByDataType || sortGroupByVersionStatus.HasSortFields;
				bool flag6 = false;
				bool flag7 = false;
				bool flag8 = false;
				if (flag5)
				{
					this.SortViaCollectionViewHelper(out flag6, out flag7);
					flag8 = true;
					if (!flag6 && (!flag7 || this._sortedFieldsToCollectionViewSynchronizer.HasNonGroupBySortFields) && global::Infragistics.Windows.DataPresenter.SortEvaluationMode.Manual != this.SortEvaluationModeResolved)
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
						this.HasMultipleFieldLayouts = hasMultipleFieldLayouts;
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
					flag4 = false;
				}
				else if (this._isGroupBySupported && ((this._hasMultipleFieldLayouts && this.DataPresenter.SortRecordsByDataType) || sortGroupByVersionStatus.HasGroupByFields))
				{
					if (flag3)
					{
						this._associatedRecordMap = null;
					}
					if (!flag8)
					{
						this.SortViaCollectionViewHelper(out flag6, out flag7);
						flag8 = true;
					}
					if (!flag7)
					{
						global::Infragistics.Windows.DataPresenter.DataRecord[] records = this._sortedRecords.SparseArray.ToArray(true, typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord[];
						if (!this._isSorted)
						{
							bool flag9;
							this.SortHelper(records, true, out flag9, !isSorted);
						}
						this.Groups.CreateGroupByRecordsHelper(records);
						this.Groups.RaiseChangeEvents(true);
					}
					flag4 = false;
				}
			}
			else
			{
				this._isSorted = false;
			}
			this.SyncSortGroupByVersions();
			if (flag4 && this._groups != null && this._groups.Count > 0)
			{
				foreach (object obj in this._sortedRecords.SparseArray.NonNullItems)
				{
					global::Infragistics.Windows.DataPresenter.Record record = (global::Infragistics.Windows.DataPresenter.Record)obj;
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
				this._fieldLayout.BumpSortOperationVersionAsync();
			}
			this.NotifyCalcAdapterHelper(global::Infragistics.Windows.DataPresenter.DataChangeType.RecordManagerCurrentChanged, null, null);
			if (this._parentRecord == null)
			{
				this._dataPresenter.BumpRecordNumberVersion();
			}
			return true;
		}

		// Token: 0x06002A09 RID: 10761 RVA: 0x000B94D4 File Offset: 0x000B76D4
		internal void WireCollectionViewEvents()
		{
			if (this._collectionView != null)
			{
				global::System.ComponentModel.CurrentChangingEventManager.AddListener(this._collectionView, this);
				global::System.ComponentModel.CurrentChangedEventManager.AddListener(this._collectionView, this);
			}
		}

		// Token: 0x06002A0A RID: 10762 RVA: 0x000B94F6 File Offset: 0x000B76F6
		private void BumpUnderlyingDataVersion()
		{
			this._underlyingDataVersion++;
			base.RaisePropertyChangedEvent("UnderlyingDataVersion");
		}

		// Token: 0x06002A0B RID: 10763 RVA: 0x000B9514 File Offset: 0x000B7714
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

		// Token: 0x06002A0C RID: 10764 RVA: 0x000B96C4 File Offset: 0x000B78C4
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

		// Token: 0x06002A0D RID: 10765 RVA: 0x000B96F8 File Offset: 0x000B78F8
		private void ClearCachedRecordsOnTop()
		{
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._sortedRecords.ViewableRecords;
			if (viewableRecords != null)
			{
				viewableRecords.ClearCachedRecordsOnTop();
			}
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x000B971A File Offset: 0x000B791A
		private bool DoesTypeSupportEditInList()
		{
			return !this._typeIsKnownType || (this._list != null && !this._list.IsReadOnly);
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x000B973C File Offset: 0x000B793C
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

		// Token: 0x06002A10 RID: 10768 RVA: 0x000B97B8 File Offset: 0x000B79B8
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

		// Token: 0x06002A11 RID: 10769 RVA: 0x000B9840 File Offset: 0x000B7A40
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

		// Token: 0x06002A12 RID: 10770 RVA: 0x000B9914 File Offset: 0x000B7B14
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
				bool flag;
				bool flag2;
				this.SortViaCollectionViewHelper(out flag, out flag2);
				if (this._recordFiltersResolved != null && this._fieldLayout != null)
				{
					this._recordFiltersResolved.OnFieldLayoutAdded(this._fieldLayout);
				}
			}
		}

		// Token: 0x06002A13 RID: 10771 RVA: 0x000B99E0 File Offset: 0x000B7BE0
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

		// Token: 0x06002A14 RID: 10772 RVA: 0x000B9C18 File Offset: 0x000B7E18
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
					return;
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
				case global::Infragistics.Windows.DataPresenter.DataChangeType.RecordManagerCurrentChanged:
					dataPresenterCalculationAdapterInternal.OnPropertyValueChanged(this, "Current", this.Current);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06002A15 RID: 10773 RVA: 0x000B9CD4 File Offset: 0x000B7ED4
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

		// Token: 0x06002A16 RID: 10774 RVA: 0x000B9EAC File Offset: 0x000B80AC
		private void OnChangeNotification(object sender, object eventArgs, bool isReset, bool isCellChangeNotification)
		{
			if (this._dataPresenter.IsSynchronousControl)
			{
				return;
			}
			if (!isCellChangeNotification && !this.IsStillValid)
			{
				this.UnwireAllEvents();
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

		// Token: 0x06002A17 RID: 10775 RVA: 0x000BA01C File Offset: 0x000B821C
		private void OnCollectionViewCurrentChanged(object sender, global::System.EventArgs e)
		{
			this.SetActiveRecordFromCurrentItem(true);
		}

		// Token: 0x06002A18 RID: 10776 RVA: 0x000BA028 File Offset: 0x000B8228
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

		// Token: 0x06002A19 RID: 10777 RVA: 0x000BA0C0 File Offset: 0x000B82C0
		internal void OnDataRecordCreated(global::Infragistics.Windows.DataPresenter.DataRecord dr)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dr.FieldLayout;
			if (this._fieldLayout == null)
			{
				this.InitializeFieldLayout(fieldLayout);
				return;
			}
			if (fieldLayout != this._fieldLayout)
			{
				this.HasMultipleFieldLayouts = true;
			}
		}

		// Token: 0x06002A1A RID: 10778 RVA: 0x000BA0F4 File Offset: 0x000B82F4
		private void OnDelayedChange()
		{
			this.ProcessQueuedChangeNotifications(true);
		}

		// Token: 0x06002A1B RID: 10779 RVA: 0x000BA0FD File Offset: 0x000B82FD
		internal void OnDelayedReset()
		{
			if (this.IsResetPending)
			{
				this.OnSourceCollectionReset();
			}
		}

		// Token: 0x06002A1C RID: 10780 RVA: 0x000BA110 File Offset: 0x000B8310
		private void OnFieldLayoutPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "SortOperationVersion")
			{
				return;
			}
			if (!this.IsStillValid)
			{
				this.UnwireAllEvents();
				return;
			}
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

		// Token: 0x06002A1D RID: 10781 RVA: 0x000BA1A0 File Offset: 0x000B83A0
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
									if (dataRecord.IsDataItemEqual(obj, this.DataItemComparer))
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
					if (this._fieldLayout != null && !this._fieldLayout.ReevaluateFiltersOnRecordsAddedResolved)
					{
						dataRecord._cachedFilterState = (global::Infragistics.Windows.DataPresenter.Record.FilterState)((short)(dataRecord._cachedFilterState & ~global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter) | 4);
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

		// Token: 0x06002A1E RID: 10782 RVA: 0x000BA488 File Offset: 0x000B8688
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

		// Token: 0x06002A1F RID: 10783 RVA: 0x000BA5C4 File Offset: 0x000B87C4
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

		// Token: 0x06002A20 RID: 10784 RVA: 0x000BA76C File Offset: 0x000B896C
		internal void OnSourceCollectionReset()
		{
			if (this._isInReset && this._sourceItems != null)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError(string.Format("DataSource reset notification received recursively. DataSource should not send a change notifcation during a reset, DataSource: {0}{1}", this._sourceItems, global::System.Environment.NewLine));
			}
			bool flag = false;
			bool hasMultipleFieldLayouts = false;
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
						this.HasMultipleFieldLayouts = false;
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
					bool flag4 = (dataPresenter != null && dataPresenter.RecordLoadMode == global::Infragistics.Windows.DataPresenter.RecordLoadMode.PreloadRecords) || null == this._list;
					bool flag5 = false;
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = null;
					if (dataSourceResetBehavior == global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.ReuseRecordsViaEnumerator && enumerable != null && this._unsortedRecords.Count == num)
					{
						flag3 = true;
						bool flag6 = true;
						int i = 0;
						global::System.Collections.Generic.IEqualityComparer<object> dataItemComparer = this.DataItemComparer;
						foreach (object obj2 in enumerable)
						{
							if (!(obj2 is global::System.Xml.XmlComment))
							{
								global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = (global::Infragistics.Windows.DataPresenter.DataRecord)this._unsortedRecords.SparseArray.GetItem(i, false);
								if (dataRecord != null)
								{
									if (!dataRecord.IsDataItemEqual(obj2, dataItemComparer))
									{
										flag3 = false;
										break;
									}
									if (fieldLayout == null)
									{
										fieldLayout = dataRecord.FieldLayout;
									}
									else if (fieldLayout != dataRecord.FieldLayout)
									{
										flag5 = true;
									}
								}
								else
								{
									flag6 = false;
								}
								i++;
							}
						}
						if (flag4 && !flag6)
						{
							flag3 = false;
						}
					}
					this.BeginUpdate();
					if (fieldLayout != null)
					{
						this.InitializeFieldLayout(fieldLayout);
						hasMultipleFieldLayouts = flag5;
					}
					if (!flag3)
					{
						global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray = this._unsortedRecords.SparseArray;
						global::Infragistics.Windows.DataPresenter.RecordSparseArrayBase sparseArray2 = this._sortedRecords.SparseArray;
						global::Infragistics.Windows.DataPresenter.Record activeRecordInternal = dataPresenter.ActiveRecordInternal;
						bool flag7 = activeRecordInternal != null && sparseArray.Contains(activeRecordInternal);
						int num2 = 0;
						global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataRecord> collection;
						bool flag8;
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
										if (this._fieldLayout == null)
										{
											this.InitializeFieldLayout(dataRecord2.FieldLayout);
										}
										else if (this._fieldLayout != dataRecord2.FieldLayout)
										{
											hasMultipleFieldLayouts = true;
										}
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
							flag8 = true;
							if (flag4)
							{
								for (int i = 0; i < num; i++)
								{
									if (sparseArray[i] == null)
									{
										object listObject = list3[i];
										global::Infragistics.Windows.DataPresenter.DataRecord dataRecord3 = global::Infragistics.Windows.DataPresenter.DataRecord.Create(this._sortedRecords, listObject, false, i);
										if (dataRecord3.FieldLayout != this._fieldLayout)
										{
											hasMultipleFieldLayouts = true;
										}
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
							global::System.Collections.Generic.IEqualityComparer<object> dataItemComparer2 = this.DataItemComparer;
							if (this._unsortedRecords.Count > 0)
							{
								hashtable = new global::System.Collections.Hashtable(this._unsortedRecords.Count, 0.9f);
								foreach (object obj4 in this._unsortedRecords.SparseArray.NonNullItems)
								{
									global::Infragistics.Windows.DataPresenter.DataRecord dataRecord4 = (global::Infragistics.Windows.DataPresenter.DataRecord)obj4;
									num4++;
									global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder dataRecordHolder = new global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder(dataRecord4, dataRecord4.DataItemForComparison, dataItemComparer2);
									hashtable[dataRecordHolder] = dataRecordHolder;
								}
								num5 = hashtable.Count;
							}
							this.Clear(false, false);
							int num6 = 0;
							sparseArray.Expand(num);
							sparseArray2.Expand(num);
							if (flag4 || hashtable != null || this._inAddNew)
							{
								bool flag9 = false;
								foreach (object obj5 in enumerable)
								{
									if (!(obj5 is global::System.Xml.XmlComment))
									{
										if (obj5 != null)
										{
											global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder dataRecordHolder = null;
											if (hashtable != null && hashtable.Count > 0 && global::Infragistics.Windows.DataPresenter.DataSourceResetBehavior.DiscardExistingRecords != dataSourceResetBehavior)
											{
												dataRecordHolder = (global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder)hashtable[new global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder(global::Infragistics.Windows.DataPresenter.DataRecord.GetObjectForRecordComparision(obj5), dataItemComparer2)];
												if (dataRecordHolder != null)
												{
													hashtable.Remove(dataRecordHolder);
												}
											}
											global::Infragistics.Windows.DataPresenter.DataRecord dataRecord5 = null;
											if (dataRecordHolder == null)
											{
												if (1 + num6 == num && this._inAddNew && !flag9 && this._currentAddRecord != null)
												{
													dataRecord5 = this._currentAddRecord;
													flag9 = true;
												}
												else if (!flag4)
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
											else if (this._fieldLayout != dataRecord5.FieldLayout)
											{
												hasMultipleFieldLayouts = true;
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
							flag8 = (num5 == num4);
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
						if (activeRecordInternal != null && flag7 && !sparseArray.Contains(activeRecordInternal))
						{
							dataPresenter.ClearActiveRecord(true);
						}
						if (dataPresenter != null)
						{
							if (num2 == 0 && this._dataPresenter.RecordManager == this)
							{
								this._dataPresenter.SelectedItems.InternalClearSelection(true, true, false, true);
							}
							else
							{
								global::Infragistics.Windows.DataPresenter.RecordManager.UpdateSelectedItems(this._dataPresenter, flag8 ? collection : null);
							}
						}
					}
					else if (list2 != null)
					{
						foreach (object obj6 in this._unsortedRecords.SparseArray.NonNullItems)
						{
							global::Infragistics.Windows.DataPresenter.DataRecord dataRecord6 = (global::Infragistics.Windows.DataPresenter.DataRecord)obj6;
							if (dataRecord6 != null)
							{
								if (this._fieldLayout != null && this._fieldLayout != dataRecord6.FieldLayout)
								{
									hasMultipleFieldLayouts = true;
								}
								if (dataRecord6.AssociatedRecordPresenter != null)
								{
									list2.Add(dataRecord6);
								}
							}
						}
					}
					this._unsortedRecordsDirty = true;
					if (this._unsortedRecords.Count == 0)
					{
						hasMultipleFieldLayouts = false;
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
					this.HasMultipleFieldLayouts = hasMultipleFieldLayouts;
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

		// Token: 0x06002A21 RID: 10785 RVA: 0x000BB200 File Offset: 0x000B9400
		private void OnSortGroupByVersionChanged()
		{
			this._trackSortGroupOperationPending = null;
			this.VerifySort();
		}

		// Token: 0x06002A22 RID: 10786 RVA: 0x000BB210 File Offset: 0x000B9410
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

		// Token: 0x06002A23 RID: 10787 RVA: 0x000BB288 File Offset: 0x000B9488
		private void ProcessChangeNotification(object sender, object eventArgs)
		{
			global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = eventArgs as global::System.ComponentModel.PropertyChangedEventArgs;
			if (propertyChangedEventArgs != null)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = sender as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null && !dataRecord.IsDeleted)
				{
					if (string.IsNullOrEmpty(propertyChangedEventArgs.PropertyName))
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

		// Token: 0x06002A24 RID: 10788 RVA: 0x000BB324 File Offset: 0x000B9524
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
			bool flag2 = false;
			bool flag3 = false;
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
					flag2 = true;
					this._dataPresenter.SelectedItems.Records.BeginUpdate();
					this._dataPresenter.SelectedItems.Records.Remove(dataRecord);
					this._dataPresenter.RaiseSelectedItemsChangedAsync(typeof(global::Infragistics.Windows.DataPresenter.Record));
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.SelectedCellCollection cells = this._dataPresenter.SelectedItems.Cells;
					int count = cells.Count;
					bool flag4 = false;
					for (int i = count - 1; i >= 0; i--)
					{
						global::Infragistics.Windows.DataPresenter.Cell cell = cells[i];
						if (cell != null && cell.Record == dataRecord)
						{
							if (!flag3)
							{
								cells.BeginUpdate();
								flag3 = true;
							}
							cells.RemoveAt(i);
							flag4 = true;
						}
					}
					if (flag4)
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
				dataRecord.InternalSetDataChanged(false, false);
				this.PrepareForNewCurrentAddRecord();
			}
			this.OnDataChanged(global::Infragistics.Windows.DataPresenter.DataChangeType.RemoveRecord, dataRecord, null);
			if (flag2)
			{
				this._dataPresenter.SelectedItems.Records.EndUpdate();
			}
			if (flag3)
			{
				this._dataPresenter.SelectedItems.Cells.EndUpdate();
			}
			if (flag && this._recordBeingDeleted == null)
			{
				this.ReselectRecordAtSortedIndex(index2);
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000BB55C File Offset: 0x000B975C
		private void SortViaCollectionViewHelper(out bool sortedViaCollectionView, out bool groupedViaCollectionView)
		{
			sortedViaCollectionView = (groupedViaCollectionView = false);
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
				this._sortedFieldsToCollectionViewSynchronizer.Synchronize(true, null);
				sortedViaCollectionView = (flag && this._sortedFieldsToCollectionViewSynchronizer.HasNonGroupBySortFields);
				groupedViaCollectionView = (flag2 && this._sortedFieldsToCollectionViewSynchronizer.HasGroupByFields);
			}
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000BB618 File Offset: 0x000B9818
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

		// Token: 0x06002A27 RID: 10791 RVA: 0x000BB684 File Offset: 0x000B9884
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

		// Token: 0x06002A28 RID: 10792 RVA: 0x000BB890 File Offset: 0x000B9A90
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

		// Token: 0x06002A29 RID: 10793 RVA: 0x000BB970 File Offset: 0x000B9B70
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

		// Token: 0x06002A2A RID: 10794 RVA: 0x000BBC4A File Offset: 0x000B9E4A
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

		// Token: 0x06002A2B RID: 10795 RVA: 0x000BBC70 File Offset: 0x000B9E70
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
				this.OnChangeNotification(sender, e, ((global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)e).Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, false);
				return true;
			}
			if (managerType == typeof(global::Infragistics.Windows.Helpers.BindingListChangedEventManager) && e is global::System.ComponentModel.ListChangedEventArgs)
			{
				this.OnChangeNotification(sender, e, ((global::System.ComponentModel.ListChangedEventArgs)e).ListChangedType == global::System.ComponentModel.ListChangedType.Reset, false);
				return true;
			}
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager) && e is global::System.ComponentModel.PropertyChangedEventArgs)
			{
				this.OnFieldLayoutPropertyChanged(sender, e as global::System.ComponentModel.PropertyChangedEventArgs);
				return true;
			}
			return false;
		}

		// Token: 0x04001403 RID: 5123
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04001404 RID: 5124
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord _parentRecord;

		// Token: 0x04001405 RID: 5125
		private global::Infragistics.Windows.DataPresenter.DataRecordCollection _unsortedRecords;

		// Token: 0x04001406 RID: 5126
		private global::Infragistics.Windows.DataPresenter.DataRecordCollection _sortedRecords;

		// Token: 0x04001407 RID: 5127
		private global::Infragistics.Windows.DataPresenter.GroupByRecordCollection _groups;

		// Token: 0x04001408 RID: 5128
		private global::System.Collections.IEnumerable _sourceItems;

		// Token: 0x04001409 RID: 5129
		private global::System.Collections.IEnumerable _underlyingSourceItems;

		// Token: 0x0400140A RID: 5130
		private global::System.ComponentModel.IBindingList _bindingList;

		// Token: 0x0400140B RID: 5131
		private global::System.Collections.IList _list;

		// Token: 0x0400140C RID: 5132
		private global::System.ComponentModel.ICollectionView _collectionView;

		// Token: 0x0400140D RID: 5133
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x0400140E RID: 5134
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400140F RID: 5135
		private global::System.Windows.Threading.DispatcherOperation _resetOperationPending;

		// Token: 0x04001410 RID: 5136
		private global::System.Windows.Threading.DispatcherOperation _trackSortGroupOperationPending;

		// Token: 0x04001411 RID: 5137
		private global::System.Windows.Threading.DispatcherOperation _cleanupTrackersOperationPending;

		// Token: 0x04001412 RID: 5138
		private bool _isSorted;

		// Token: 0x04001413 RID: 5139
		private bool _hasSourceBeenSetAtLeastOnce;

		// Token: 0x04001414 RID: 5140
		private bool _hasMultipleFieldLayouts;

		// Token: 0x04001415 RID: 5141
		private bool _unsortedRecordsDirty;

		// Token: 0x04001416 RID: 5142
		private bool _firstResetProcessed;

		// Token: 0x04001417 RID: 5143
		private bool _isInitializingDataSource;

		// Token: 0x04001418 RID: 5144
		private global::System.Collections.Specialized.INotifyCollectionChanged _notifyCollectionChangedHooked;

		// Token: 0x04001419 RID: 5145
		private bool _inAddNew;

		// Token: 0x0400141A RID: 5146
		private bool _isInReset;

		// Token: 0x0400141B RID: 5147
		private global::Infragistics.Windows.DataPresenter.DataRecord _recordBeingCommitted;

		// Token: 0x0400141C RID: 5148
		private global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker> _sortGroupByVersionTrackers = new global::Infragistics.Collections.WeakDictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SortGroupVersionTracker>(true, true);

		// Token: 0x0400141D RID: 5149
		private int _underlyingDataVersion;

		// Token: 0x0400141E RID: 5150
		private global::Infragistics.Windows.DataPresenter.DataRecord _currentAddRecord;

		// Token: 0x0400141F RID: 5151
		private global::Infragistics.Windows.DataPresenter.DataRecord _recordBeingDeleted;

		// Token: 0x04001420 RID: 5152
		private global::System.Collections.Specialized.HybridDictionary _addRecordCellDataDictionary;

		// Token: 0x04001421 RID: 5153
		private bool _isGroupBySupported;

		// Token: 0x04001422 RID: 5154
		private global::Infragistics.Windows.EditableCollectionViewProxy _editableCollectionView;

		// Token: 0x04001423 RID: 5155
		private global::Infragistics.Windows.CollectionViewWrapper _collectionViewWrapper;

		// Token: 0x04001424 RID: 5156
		private bool _dataSourceRaisesCellValueChangeEvents;

		// Token: 0x04001425 RID: 5157
		private bool _canGetPropertiesFromDataSourceWithoutItems;

		// Token: 0x04001426 RID: 5158
		private bool _isSynchronizingWithCurrentItem;

		// Token: 0x04001427 RID: 5159
		private global::System.Type _typeWithPublicCtor;

		// Token: 0x04001428 RID: 5160
		private bool _typeIsKnownType;

		// Token: 0x04001429 RID: 5161
		private global::Infragistics.Windows.DataPresenter.FieldLayout.LayoutPropertyDescriptorProvider _typedListDefaultProvider;

		// Token: 0x0400142A RID: 5162
		private global::System.Collections.ArrayList _asyncChangeList;

		// Token: 0x0400142B RID: 5163
		private global::System.Windows.Threading.DispatcherOperation _asyncChangePending;

		// Token: 0x0400142C RID: 5164
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.ChangeNotification> _processAsyncChangeList;

		// Token: 0x0400142D RID: 5165
		private global::Infragistics.Windows.Helpers.HashSet _processAsyncChangeListSet;

		// Token: 0x0400142E RID: 5166
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.Record> _associatedRecordMap;

		// Token: 0x0400142F RID: 5167
		private global::Infragistics.Windows.DataPresenter.RecordManager _associatedRecordManager;

		// Token: 0x04001430 RID: 5168
		private int _reportVersion;

		// Token: 0x04001431 RID: 5169
		private global::Infragistics.Windows.DataPresenter.RecordFilterCollection _recordFilters;

		// Token: 0x04001432 RID: 5170
		private global::Infragistics.Windows.DataPresenter.ResolvedRecordFilterCollection _recordFiltersResolved;

		// Token: 0x04001433 RID: 5171
		private global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection _filteredInDataItems;

		// Token: 0x04001434 RID: 5172
		internal global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation _beginUpdateInfo;

		// Token: 0x04001435 RID: 5173
		private int _scrollCountVersion;

		// Token: 0x04001436 RID: 5174
		private int _newRecordOnTopOffset;

		// Token: 0x04001437 RID: 5175
		private int _nestingDepth;

		// Token: 0x04001438 RID: 5176
		private int _fieldAutoSizeVersion = 1;

		// Token: 0x04001439 RID: 5177
		internal global::Infragistics.Windows.DataPresenter.SortedFieldsToCollectionViewSynchronizer _sortedFieldsToCollectionViewSynchronizer;

		// Token: 0x0400143A RID: 5178
		private global::Infragistics.Windows.Internal.PropertyValueTracker _filterVersionTracker;

		// Token: 0x0400143B RID: 5179
		private bool _inProcessQueuedChangs;

		// Token: 0x02000359 RID: 857
		// (Invoke) Token: 0x06002A2F RID: 10799
		private delegate bool BoolReturnMethodDelegate();

		// Token: 0x0200035A RID: 858
		// (Invoke) Token: 0x06002A33 RID: 10803
		internal delegate bool VerifySortDelegate();

		// Token: 0x0200035B RID: 859
		internal class BeginUpdateInformation
		{
			// Token: 0x06002A36 RID: 10806 RVA: 0x000BBD52 File Offset: 0x000B9F52
			internal BeginUpdateInformation(global::Infragistics.Windows.DataPresenter.RecordManager recordManager)
			{
				this._recordManager = recordManager;
			}

			// Token: 0x17000C84 RID: 3204
			// (get) Token: 0x06002A37 RID: 10807 RVA: 0x000BBD61 File Offset: 0x000B9F61
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

			// Token: 0x17000C85 RID: 3205
			// (get) Token: 0x06002A38 RID: 10808 RVA: 0x000BBD7C File Offset: 0x000B9F7C
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

			// Token: 0x06002A39 RID: 10809 RVA: 0x000BBD97 File Offset: 0x000B9F97
			internal void EnqueNotification(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc, global::System.EventArgs eventArgs)
			{
				if (eventArgs is global::System.Collections.Specialized.NotifyCollectionChangedEventArgs && global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset == ((global::System.Collections.Specialized.NotifyCollectionChangedEventArgs)eventArgs).Action)
				{
					this.PendingResetVRCs.Add(vrc);
				}
				this.PendingNotificationList.Add(new global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo(vrc, eventArgs));
			}

			// Token: 0x06002A3A RID: 10810 RVA: 0x000BBDCD File Offset: 0x000B9FCD
			internal bool HasPendingResetNotification(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc)
			{
				return this._pendingResetVRCs != null && this._pendingResetVRCs.Exists(vrc);
			}

			// Token: 0x06002A3B RID: 10811 RVA: 0x000BBDE8 File Offset: 0x000B9FE8
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

			// Token: 0x0400143F RID: 5183
			private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

			// Token: 0x04001440 RID: 5184
			internal int _beginUpdateCount;

			// Token: 0x04001441 RID: 5185
			private global::Infragistics.Windows.Helpers.HashSet _pendingResetVRCs;

			// Token: 0x04001442 RID: 5186
			private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.BeginUpdateInformation.PendingNotificationInfo> _pendingNotificationList;

			// Token: 0x04001443 RID: 5187
			internal bool _dirtyScrollCount;

			// Token: 0x04001444 RID: 5188
			internal bool _scrollCountDirtied;

			// Token: 0x0200035C RID: 860
			private class PendingNotificationInfo
			{
				// Token: 0x06002A3C RID: 10812 RVA: 0x000BBFB0 File Offset: 0x000BA1B0
				internal PendingNotificationInfo(global::Infragistics.Windows.DataPresenter.ViewableRecordCollection vrc, global::System.EventArgs eventArgs)
				{
					this._vrc = vrc;
					this._eventArgs = eventArgs;
				}

				// Token: 0x04001445 RID: 5189
				internal global::Infragistics.Windows.DataPresenter.ViewableRecordCollection _vrc;

				// Token: 0x04001446 RID: 5190
				internal global::System.EventArgs _eventArgs;
			}
		}

		// Token: 0x0200035D RID: 861
		internal class RecordsSortComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>
		{
			// Token: 0x06002A3D RID: 10813 RVA: 0x000BBFC6 File Offset: 0x000BA1C6
			internal RecordsSortComparer(bool originalUnsortedOrder)
			{
				this._originalUnsortedOrder = originalUnsortedOrder;
			}

			// Token: 0x06002A3E RID: 10814 RVA: 0x000BBFEC File Offset: 0x000BA1EC
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

			// Token: 0x06002A3F RID: 10815 RVA: 0x000BC03C File Offset: 0x000BA23C
			internal static int DefaultCompare(object x, object y, global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer.DefaultCompare(x, y, true, field);
			}

			// Token: 0x06002A40 RID: 10816 RVA: 0x000BC047 File Offset: 0x000BA247
			internal static int DefaultCompare(object x, object y, bool duringSort, global::Infragistics.Windows.DataPresenter.Field field)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.RecordsSortComparer.DefaultCompare(x, y, duringSort, field != null && global::Infragistics.Windows.DataPresenter.FieldSortComparisonType.CaseInsensitive == field.SortComparisonTypeResolved);
			}

			// Token: 0x06002A41 RID: 10817 RVA: 0x000BC060 File Offset: 0x000BA260
			internal static int DefaultCompare(object x, object y, bool duringSort, bool caseInSensitive)
			{
				return global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.DefaultCompare(x, y, duringSort, caseInSensitive);
			}

			// Token: 0x06002A42 RID: 10818 RVA: 0x000BC06C File Offset: 0x000BA26C
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

			// Token: 0x06002A43 RID: 10819 RVA: 0x000BC1AE File Offset: 0x000BA3AE
			public int Compare(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
			{
				return ((global::System.Collections.IComparer)this).Compare(x, y);
			}

			// Token: 0x04001447 RID: 5191
			private bool _originalUnsortedOrder;

			// Token: 0x04001448 RID: 5192
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.IGroupByEvaluator> _groupByEvaluators;

			// Token: 0x04001449 RID: 5193
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellTextConverterInfo> _cellTextConverters = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Field, global::Infragistics.Windows.DataPresenter.CellTextConverterInfo>();

			// Token: 0x0400144A RID: 5194
			private global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer> _sameFieldRecordComparers = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.FieldLayout, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer>();
		}

		// Token: 0x0200035E RID: 862
		internal class SameFieldRecordsSortComparer : global::System.Collections.IComparer, global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>
		{
			// Token: 0x06002A44 RID: 10820 RVA: 0x000BC1B8 File Offset: 0x000BA3B8
			internal SameFieldRecordsSortComparer(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, int recordsBeingSortedCount, bool areRecordsInUnsortedOrder)
			{
				this._fieldLayout = fieldLayout;
				this._recordsBeingSortedCount = recordsBeingSortedCount;
				this._areRecordsInUnsortedOrder = areRecordsInUnsortedOrder;
				global::Infragistics.Windows.DataPresenter.FieldSortDescriptionCollection sortedFields = fieldLayout.SortedFields;
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo>();
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list2 = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
				int num = 0;
				for (int i = 0; i < sortedFields.Count; i++)
				{
					global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription = sortedFields[i];
					global::Infragistics.Windows.DataPresenter.Field field = (fieldSortDescription != null) ? fieldSortDescription.Field : null;
					if (field == null || fieldSortDescription.Field == null || !fieldSortDescription.Field.IsValid)
					{
						num++;
					}
					else
					{
						global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo fieldSortInfo = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo(fieldSortDescription, fieldSortDescription.IsGroupBy, this, fieldLayout);
						list.Insert(i - num, fieldSortInfo);
						if (fieldSortDescription.IsGroupBy)
						{
							bool flag;
							if (fieldSortInfo._comparer != null)
							{
								flag = (fieldSortInfo._groupByEvaluatorSortComparer != fieldSortInfo._comparer);
							}
							else
							{
								flag = (!(fieldSortInfo._groupByEvaluator is global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator) && !(fieldSortInfo._groupByEvaluator is global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.ValueEvaluator));
							}
							if (flag)
							{
								if (!sortedFields.Contains(fieldSortDescription.Field, new bool?(false)))
								{
									list.Add(new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo(fieldSortDescription, false, this, fieldLayout));
								}
							}
							else
							{
								list2.Add(fieldSortDescription.Field);
							}
						}
						else if (list2.Contains(fieldSortDescription.Field))
						{
							list[i - num] = null;
							num++;
						}
					}
				}
				this._sortedFields = list.ToArray();
				if (num > 0)
				{
					this._sortedFields = global::Infragistics.Windows.DataPresenter.GridUtilities.RemoveAll<global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo>(this._sortedFields, null);
				}
			}

			// Token: 0x06002A45 RID: 10821 RVA: 0x000BC334 File Offset: 0x000BA534
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

			// Token: 0x06002A46 RID: 10822 RVA: 0x000BC4AD File Offset: 0x000BA6AD
			private static int CompareStringHelper(string xxStr, string yyStr, bool caseInSensitive)
			{
				return string.Compare(xxStr, yyStr, caseInSensitive, global::System.Globalization.CultureInfo.CurrentCulture);
			}

			// Token: 0x06002A47 RID: 10823 RVA: 0x000BC4BC File Offset: 0x000BA6BC
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

			// Token: 0x06002A48 RID: 10824 RVA: 0x000BC604 File Offset: 0x000BA804
			int global::System.Collections.IComparer.Compare(object x, object y)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord recordX = x as global::Infragistics.Windows.DataPresenter.DataRecord;
				global::Infragistics.Windows.DataPresenter.DataRecord recordY = y as global::Infragistics.Windows.DataPresenter.DataRecord;
				return this.CompareHelper(recordX, recordY);
			}

			// Token: 0x06002A49 RID: 10825 RVA: 0x000BC628 File Offset: 0x000BA828
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
				foreach (global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo fieldSortInfo in sortedFields)
				{
					global::Infragistics.Windows.DataPresenter.Field field = fieldSortInfo._field;
					global::System.Collections.IComparer comparer = null;
					if (fieldSortInfo._firstGroupByPass && fieldSortInfo._isGroupBy)
					{
						comparer = fieldSortInfo._groupByEvaluatorSortComparer;
						if (fieldSortInfo._comparer != null && (fieldSortInfo._groupByEvaluator is global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.CellTextEvaluator || fieldSortInfo._groupByEvaluator is global::Infragistics.Windows.DataPresenter.GroupByEvaluatorFactory.ValueEvaluator))
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
				}
				if (num2 == 0 && !this._areRecordsInUnsortedOrder)
				{
					int num3 = (cellInfo != null) ? cellInfo.DataItemIndex : recordX.DataItemIndex;
					int num4 = (cellInfo2 != null) ? cellInfo2.DataItemIndex : recordY.DataItemIndex;
					num2 = ((num3 < num4) ? -1 : 1);
				}
				return num2;
			}

			// Token: 0x06002A4A RID: 10826 RVA: 0x000BC7C4 File Offset: 0x000BA9C4
			public int Compare(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
			{
				return this.CompareHelper(x as global::Infragistics.Windows.DataPresenter.DataRecord, y as global::Infragistics.Windows.DataPresenter.DataRecord);
			}

			// Token: 0x0400144B RID: 5195
			private int _recordsBeingSortedCount;

			// Token: 0x0400144C RID: 5196
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

			// Token: 0x0400144D RID: 5197
			private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo[] _sortedFields;

			// Token: 0x0400144E RID: 5198
			private bool _areRecordsInUnsortedOrder;

			// Token: 0x0400144F RID: 5199
			private static global::System.Collections.Generic.Dictionary<global::System.Type, int> g_typeOrderTable;

			// Token: 0x0200035F RID: 863
			internal class CellInfo
			{
				// Token: 0x06002A4B RID: 10827 RVA: 0x000BC7D8 File Offset: 0x000BA9D8
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

				// Token: 0x17000C86 RID: 3206
				// (get) Token: 0x06002A4C RID: 10828 RVA: 0x000BC850 File Offset: 0x000BAA50
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

				// Token: 0x06002A4D RID: 10829 RVA: 0x000BC881 File Offset: 0x000BAA81
				internal string GetCellText()
				{
					if (this._text == null)
					{
						this._text = this._fieldSortInfo._cellTextConverter.ConvertCellValue(this._value);
					}
					return this._text;
				}

				// Token: 0x06002A4E RID: 10830 RVA: 0x000BC8B0 File Offset: 0x000BAAB0
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

				// Token: 0x04001450 RID: 5200
				internal global::Infragistics.Windows.DataPresenter.DataRecord _record;

				// Token: 0x04001451 RID: 5201
				private int _dataItemIndex = -1;

				// Token: 0x04001452 RID: 5202
				internal object _value;

				// Token: 0x04001453 RID: 5203
				private object _cachedCompareValue;

				// Token: 0x04001454 RID: 5204
				private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.FieldSortInfo _fieldSortInfo;

				// Token: 0x04001455 RID: 5205
				private string _text;
			}

			// Token: 0x02000360 RID: 864
			internal class FieldSortInfo
			{
				// Token: 0x06002A4F RID: 10831 RVA: 0x000BC908 File Offset: 0x000BAB08
				internal FieldSortInfo(global::Infragistics.Windows.DataPresenter.Field field)
				{
					this.Initialize(new global::Infragistics.Windows.DataPresenter.FieldSortDescription
					{
						Field = field
					}, false, null, field.Owner);
				}

				// Token: 0x06002A50 RID: 10832 RVA: 0x000BC937 File Offset: 0x000BAB37
				internal FieldSortInfo(global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription, bool firstGroupByPass, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer comparerInfo, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
				{
					this.Initialize(fieldSortDescription, firstGroupByPass, comparerInfo, fieldLayout);
				}

				// Token: 0x06002A51 RID: 10833 RVA: 0x000BC94C File Offset: 0x000BAB4C
				private void Initialize(global::Infragistics.Windows.DataPresenter.FieldSortDescription fieldSortDescription, bool firstGroupByPass, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer comparerInfo, global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
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
					this._firstGroupByPass = firstGroupByPass;
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

				// Token: 0x06002A52 RID: 10834 RVA: 0x000BCA68 File Offset: 0x000BAC68
				internal global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo GetCellInfo(global::Infragistics.Windows.DataPresenter.DataRecord record)
				{
					global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo result;
					if (!this._cellInfo.TryGetValue(record, out result))
					{
						result = (this._cellInfo[record] = new global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo(record, this));
					}
					return result;
				}

				// Token: 0x06002A53 RID: 10835 RVA: 0x000BCA9C File Offset: 0x000BAC9C
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

				// Token: 0x06002A54 RID: 10836 RVA: 0x000BCAD0 File Offset: 0x000BACD0
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

				// Token: 0x06002A55 RID: 10837 RVA: 0x000BCB04 File Offset: 0x000BAD04
				internal object GetCellValueAsEditAsType(global::Infragistics.Windows.DataPresenter.DataRecord record)
				{
					object obj = record.GetCellValue(this._field, true);
					if (this._editAsTypeUnderlying != this._dataTypeUnderlying && obj != null && !(obj is global::System.DBNull))
					{
						obj = global::Infragistics.CoreUtilities.ConvertDataValue(obj, this._editAsTypeUnderlying, this._converterCultureResolved, null);
					}
					return obj;
				}

				// Token: 0x04001456 RID: 5206
				internal global::Infragistics.Windows.DataPresenter.FieldSortDescription _fieldSortDescription;

				// Token: 0x04001457 RID: 5207
				internal global::Infragistics.Windows.DataPresenter.Field _field;

				// Token: 0x04001458 RID: 5208
				internal global::System.Collections.IComparer _comparer;

				// Token: 0x04001459 RID: 5209
				internal global::Infragistics.Windows.DataPresenter.IGroupByEvaluator _groupByEvaluator;

				// Token: 0x0400145A RID: 5210
				internal global::System.Collections.IComparer _groupByEvaluatorSortComparer;

				// Token: 0x0400145B RID: 5211
				internal int _direction;

				// Token: 0x0400145C RID: 5212
				internal global::Infragistics.Windows.DataPresenter.FieldSortComparisonType _comparisonType;

				// Token: 0x0400145D RID: 5213
				internal bool _isGroupBy;

				// Token: 0x0400145E RID: 5214
				internal global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DataPresenter.Record, global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo> _cellInfo;

				// Token: 0x0400145F RID: 5215
				internal global::System.Type _dataTypeUnderlying;

				// Token: 0x04001460 RID: 5216
				internal global::System.Type _editAsTypeUnderlying;

				// Token: 0x04001461 RID: 5217
				internal global::System.Globalization.CultureInfo _converterCultureResolved;

				// Token: 0x04001462 RID: 5218
				internal global::Infragistics.Windows.DataPresenter.CellTextConverterInfo _cellTextConverter;

				// Token: 0x04001463 RID: 5219
				internal bool _firstGroupByPass;

				// Token: 0x04001464 RID: 5220
				private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo _lastInfoX;

				// Token: 0x04001465 RID: 5221
				private global::Infragistics.Windows.DataPresenter.RecordManager.SameFieldRecordsSortComparer.CellInfo _lastInfoY;
			}

			// Token: 0x02000361 RID: 865
			private class ReferenceEqualityComparer<T> : global::System.Collections.Generic.IEqualityComparer<T>
			{
				// Token: 0x06002A56 RID: 10838 RVA: 0x000BCB52 File Offset: 0x000BAD52
				public bool Equals(T x, T y)
				{
					return object.ReferenceEquals(x, y);
				}

				// Token: 0x06002A57 RID: 10839 RVA: 0x000BCB65 File Offset: 0x000BAD65
				public int GetHashCode(T obj)
				{
					return obj.GetHashCode();
				}
			}
		}

		// Token: 0x02000362 RID: 866
		private class DataRecordHolder
		{
			// Token: 0x06002A59 RID: 10841 RVA: 0x000BCB7C File Offset: 0x000BAD7C
			internal DataRecordHolder(global::Infragistics.Windows.DataPresenter.DataRecord record, object comparisionListObject, global::System.Collections.Generic.IEqualityComparer<object> comparer) : this(comparisionListObject, comparer)
			{
				this.record = record;
			}

			// Token: 0x06002A5A RID: 10842 RVA: 0x000BCB8D File Offset: 0x000BAD8D
			internal DataRecordHolder(object comparisionListObject, global::System.Collections.Generic.IEqualityComparer<object> comparer)
			{
				this.comparisionListObject = comparisionListObject;
				this.comparer = comparer;
			}

			// Token: 0x06002A5B RID: 10843 RVA: 0x000BCBA3 File Offset: 0x000BADA3
			public override int GetHashCode()
			{
				return this.comparer.GetHashCode(this.comparisionListObject);
			}

			// Token: 0x06002A5C RID: 10844 RVA: 0x000BCBB8 File Offset: 0x000BADB8
			public override bool Equals(object o)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder dataRecordHolder = o as global::Infragistics.Windows.DataPresenter.RecordManager.DataRecordHolder;
				return dataRecordHolder != null && this.comparer.Equals(dataRecordHolder.comparisionListObject, this.comparisionListObject);
			}

			// Token: 0x04001466 RID: 5222
			private global::System.Collections.Generic.IEqualityComparer<object> comparer;

			// Token: 0x04001467 RID: 5223
			internal object comparisionListObject;

			// Token: 0x04001468 RID: 5224
			internal global::Infragistics.Windows.DataPresenter.DataRecord record;
		}

		// Token: 0x02000363 RID: 867
		private class ChangeNotification
		{
			// Token: 0x06002A5D RID: 10845 RVA: 0x000BCBE8 File Offset: 0x000BADE8
			internal ChangeNotification(object sender, object eventArgs)
			{
				this.Sender = sender;
				this.EventArgs = eventArgs;
			}

			// Token: 0x04001469 RID: 5225
			internal object Sender;

			// Token: 0x0400146A RID: 5226
			internal object EventArgs;

			// Token: 0x02000364 RID: 868
			internal class EqualityComparer : global::System.Collections.IEqualityComparer
			{
				// Token: 0x06002A5E RID: 10846 RVA: 0x000BCBFE File Offset: 0x000BADFE
				private static string GetPropertyName(global::System.ComponentModel.PropertyDescriptor pd)
				{
					if (pd == null)
					{
						return null;
					}
					return pd.Name;
				}

				// Token: 0x06002A5F RID: 10847 RVA: 0x000BCC0B File Offset: 0x000BAE0B
				private static int GetHashCodeHelper(object s)
				{
					if (s == null)
					{
						return 0;
					}
					return s.GetHashCode();
				}

				// Token: 0x06002A60 RID: 10848 RVA: 0x000BCC18 File Offset: 0x000BAE18
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

				// Token: 0x06002A61 RID: 10849 RVA: 0x000BCCF8 File Offset: 0x000BAEF8
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

		// Token: 0x02000365 RID: 869
		private struct SortGroupVersionStatus
		{
			// Token: 0x06002A63 RID: 10851 RVA: 0x000BCD6E File Offset: 0x000BAF6E
			internal SortGroupVersionStatus(bool isSortVersionChanged, bool isGroupByVersionChanged, bool hasSortFields, bool hasGroupByFields)
			{
				this._hasGroupByFields = hasGroupByFields;
				this._hasSortFields = hasSortFields;
				this._isGroupByVersionChanged = isGroupByVersionChanged;
				this._isSortVersionChanged = isSortVersionChanged;
			}

			// Token: 0x17000C87 RID: 3207
			// (get) Token: 0x06002A64 RID: 10852 RVA: 0x000BCD8D File Offset: 0x000BAF8D
			internal bool HasSortFields
			{
				get
				{
					return this._hasSortFields;
				}
			}

			// Token: 0x17000C88 RID: 3208
			// (get) Token: 0x06002A65 RID: 10853 RVA: 0x000BCD95 File Offset: 0x000BAF95
			internal bool HasGroupByFields
			{
				get
				{
					return this._hasGroupByFields;
				}
			}

			// Token: 0x17000C89 RID: 3209
			// (get) Token: 0x06002A66 RID: 10854 RVA: 0x000BCD9D File Offset: 0x000BAF9D
			internal bool IsSortVersionChanged
			{
				get
				{
					return this._isSortVersionChanged;
				}
			}

			// Token: 0x17000C8A RID: 3210
			// (get) Token: 0x06002A67 RID: 10855 RVA: 0x000BCDA5 File Offset: 0x000BAFA5
			internal bool IsGroupByVersionChanged
			{
				get
				{
					return this._isGroupByVersionChanged;
				}
			}

			// Token: 0x0400146B RID: 5227
			private bool _isSortVersionChanged;

			// Token: 0x0400146C RID: 5228
			private bool _isGroupByVersionChanged;

			// Token: 0x0400146D RID: 5229
			private bool _hasSortFields;

			// Token: 0x0400146E RID: 5230
			private bool _hasGroupByFields;
		}

		// Token: 0x02000366 RID: 870
		internal class SortGroupVersionTracker
		{
			// Token: 0x06002A68 RID: 10856 RVA: 0x000BCDB0 File Offset: 0x000BAFB0
			internal SortGroupVersionTracker(global::Infragistics.Windows.DataPresenter.RecordManager rm, global::Infragistics.Windows.DataPresenter.FieldLayout fl)
			{
				this._fl = fl;
				this._sortVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fl, "SortVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(rm.OnSortGroupByVersionChanged), true);
				this._groupByVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(fl, "GroupByVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(rm.OnSortGroupByVersionChanged), true);
			}

			// Token: 0x17000C8B RID: 3211
			// (get) Token: 0x06002A69 RID: 10857 RVA: 0x000BCE06 File Offset: 0x000BB006
			internal global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
			{
				get
				{
					return this._fl;
				}
			}

			// Token: 0x17000C8C RID: 3212
			// (get) Token: 0x06002A6A RID: 10858 RVA: 0x000BCE0E File Offset: 0x000BB00E
			internal int GroupByVersion
			{
				get
				{
					return this._groupByVersion;
				}
			}

			// Token: 0x17000C8D RID: 3213
			// (get) Token: 0x06002A6B RID: 10859 RVA: 0x000BCE16 File Offset: 0x000BB016
			internal int SortVersion
			{
				get
				{
					return this._sortVersion;
				}
			}

			// Token: 0x06002A6C RID: 10860 RVA: 0x000BCE1E File Offset: 0x000BB01E
			internal void DirtyVersionNumbers()
			{
				this._sortVersion--;
				this._groupByVersion--;
			}

			// Token: 0x06002A6D RID: 10861 RVA: 0x000BCE3C File Offset: 0x000BB03C
			internal void SyncVersionNumbers()
			{
				this._sortVersion = this._fl.SortVersion;
				this._groupByVersion = this._fl.GroupByVersion;
			}

			// Token: 0x0400146F RID: 5231
			private global::Infragistics.Windows.Internal.PropertyValueTracker _sortVersionTracker;

			// Token: 0x04001470 RID: 5232
			private global::Infragistics.Windows.Internal.PropertyValueTracker _groupByVersionTracker;

			// Token: 0x04001471 RID: 5233
			private int _sortVersion;

			// Token: 0x04001472 RID: 5234
			private int _groupByVersion;

			// Token: 0x04001473 RID: 5235
			private global::Infragistics.Windows.DataPresenter.FieldLayout _fl;
		}
	}
}
