using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using System.Windows;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000300 RID: 768
	public class ExpandableFieldRecord : global::Infragistics.Windows.DataPresenter.Record, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060023E9 RID: 9193 RVA: 0x0009CBC4 File Offset: 0x0009ADC4
		internal ExpandableFieldRecord(global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection, global::Infragistics.Windows.DataPresenter.Field field) : base(field.Owner, parentCollection)
		{
			if (field == null)
			{
				throw new global::System.ArgumentNullException("field", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_4"));
			}
			this._field = field;
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(field, this, "VisibilityResolved");
			global::System.ComponentModel.PropertyChangedEventManager.AddListener(field, this, "PropertyDescriptorVersion");
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x060023EA RID: 9194 RVA: 0x0009CC15 File Offset: 0x0009AE15
		internal override global::Infragistics.Windows.DataPresenter.Field AssociatedField
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x060023EB RID: 9195 RVA: 0x0009CC1D File Offset: 0x0009AE1D
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return this.GetChildRcdCollection(false);
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x0009CC26 File Offset: 0x0009AE26
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return this.ChildRecords;
			}
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0009CC30 File Offset: 0x0009AE30
		internal override void CloneAssociatedRecordSettings(global::Infragistics.Windows.DataPresenter.Record associatedRecord, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			base.CloneAssociatedRecordSettings(associatedRecord, options);
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = associatedRecord as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			if (expandableFieldRecord != null)
			{
				this._isExpandedAlwaysLastReturned = expandableFieldRecord._isExpandedAlwaysLastReturned;
				this._isExpandedLastReturned = expandableFieldRecord._isExpandedLastReturned;
			}
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0009CC67 File Offset: 0x0009AE67
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter();
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0009CC70 File Offset: 0x0009AE70
		// (set) Token: 0x060023F0 RID: 9200 RVA: 0x0009CD07 File Offset: 0x0009AF07
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override string Description
		{
			get
			{
				string description = base.Description;
				if (description != null && description.Length > 0)
				{
					return description;
				}
				if (this.AssociatedField == null)
				{
					return string.Empty;
				}
				global::Infragistics.Windows.DataPresenter.FieldLayout.FieldDescriptor fieldDescriptor = (base.ParentDataRecord == null) ? null : base.ParentDataRecord.PropertyDescriptorProvider.GetFieldDescriptor(this.AssociatedField);
				if (fieldDescriptor != null && fieldDescriptor.DataColumn != null)
				{
					return fieldDescriptor.DataColumn.Caption;
				}
				if (this.AssociatedField.Label is string)
				{
					return this.AssociatedField.Label as string;
				}
				return this.AssociatedField.Name;
			}
			set
			{
				base.Description = value;
			}
		}

		// Token: 0x060023F1 RID: 9201 RVA: 0x0009CD10 File Offset: 0x0009AF10
		public override global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord()
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = base.ParentRecord.GetAssociatedRecord() as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord == null)
			{
				return null;
			}
			foreach (global::Infragistics.Windows.DataPresenter.Record record in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)dataRecord.ViewableChildRecords))
			{
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)record;
				if (expandableFieldRecord != null && expandableFieldRecord.Field.Name == this.Field.Name)
				{
					return expandableFieldRecord;
				}
			}
			return null;
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0009CD98 File Offset: 0x0009AF98
		internal override bool HasChildrenInternal
		{
			get
			{
				if (!this.Field.IsExpandableByDefault)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsIfNeeded = this.ChildRecordsIfNeeded;
				if (childRecordsIfNeeded == null)
				{
					return false;
				}
				if (childRecordsIfNeeded.Count > 0)
				{
					return true;
				}
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecords = base.ViewableChildRecords;
				return viewableChildRecords != null && viewableChildRecords.Count > 0;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x0009CDE0 File Offset: 0x0009AFE0
		internal override bool HasChildData
		{
			get
			{
				return !this.IsExpanded || this.CheckHasChildData();
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0009CDF4 File Offset: 0x0009AFF4
		internal override bool HasVisibleChildren
		{
			get
			{
				if (base.HasVisibleChildren)
				{
					return true;
				}
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = this.ViewableChildRecordsIfNeeded;
				return viewableChildRecordsIfNeeded != null && viewableChildRecordsIfNeeded.Count > 0;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0009CE20 File Offset: 0x0009B020
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x0009CE6C File Offset: 0x0009B06C
		public override bool IsExpanded
		{
			get
			{
				bool flag = false;
				if (base.CanExpand)
				{
					flag = (this.IsExpandedAlways || base.IsExpanded);
				}
				if (flag != this._isExpandedLastReturned)
				{
					this._isExpandedLastReturned = flag;
					base.DirtyScrollCount();
					base.RaisePropertyChangedEvent("IsExpanded");
				}
				return flag;
			}
			set
			{
				base.IsExpanded = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x0009CE78 File Offset: 0x0009B078
		internal override bool OccupiesScrollPosition
		{
			get
			{
				if (base.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = base.DataPresenter;
				bool flag = dataPresenter != null && dataPresenter.IsFlatView;
				bool isExpanded = this.IsExpanded;
				if (isExpanded && this.Field.IsExpandableByDefault && !flag)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = this.ViewableChildRecordsIfNeeded;
					if ((viewableChildRecordsIfNeeded != null && viewableChildRecordsIfNeeded.Count > 0) || !this.IsHeaderVisible)
					{
						return false;
					}
				}
				if (flag && isExpanded && !this.IsHeaderVisible && this.Field.IsExpandableByDefault && global::System.Windows.Visibility.Collapsed == base.ExpansionIndicatorVisibility)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Record parentRecord = base.ParentRecord;
				return parentRecord != null && !parentRecord.IsSpecialRecord;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x060023F8 RID: 9208 RVA: 0x0009CF19 File Offset: 0x0009B119
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x0009CF1C File Offset: 0x0009B11C
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0009CF20 File Offset: 0x0009B120
		internal override void SortChildren()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = this.ChildRecordManagerIfNeeded;
			if (childRecordManagerIfNeeded != null)
			{
				childRecordManagerIfNeeded.VerifySort();
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0009CF40 File Offset: 0x0009B140
		public override string ToString()
		{
			global::Infragistics.Windows.DataPresenter.Field field = this.Field;
			global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = base.ParentDataRecord;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("ExpandableFieldRecord: ");
			if (field != null)
			{
				stringBuilder.Append(field);
			}
			if (parentDataRecord != null)
			{
				stringBuilder.Append(", ");
				stringBuilder.Append(parentDataRecord.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x0009CF9A File Offset: 0x0009B19A
		internal override void VerifySortOrderOfChildren()
		{
			if (this._records == null || this._records.Unsorted.Count < 1)
			{
				return;
			}
			this.SortChildren();
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x0009CFC0 File Offset: 0x0009B1C0
		public override global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				global::System.Windows.Visibility visibilityResolved = base.VisibilityResolved;
				if (visibilityResolved == global::System.Windows.Visibility.Collapsed)
				{
					return visibilityResolved;
				}
				if (!this.OccupiesScrollPosition && !this.HasChildData)
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return visibilityResolved;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x0009CFED File Offset: 0x0009B1ED
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.RecordManager ChildRecordManager
		{
			get
			{
				this.VerifyChildRecordManager(true);
				return this._records;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0009CFFC File Offset: 0x0009B1FC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecords
		{
			get
			{
				return this.GetChildRcdCollection(true);
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x0009D005 File Offset: 0x0009B205
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x0009D00D File Offset: 0x0009B20D
		internal global::Infragistics.Windows.DataPresenter.RecordManager ChildRecordManagerIfAllocated
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x0009D015 File Offset: 0x0009B215
		internal global::Infragistics.Windows.DataPresenter.RecordManager ChildRecordManagerIfNeeded
		{
			get
			{
				this.VerifyChildRecordManager(false);
				return this._records;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x0009D024 File Offset: 0x0009B224
		internal bool IsExpandedAlways
		{
			get
			{
				bool flag = false;
				switch (this.Field.ExpandableFieldRecordExpansionModeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.ExpandAlways:
					flag = true;
					break;
				case global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordExpansionMode.ShowExpansionIndicatorIfSiblingsExist:
					if (base.ParentDataRecord.ChildRecords.Count < 2)
					{
						flag = true;
					}
					break;
				}
				if (flag != this._isExpandedAlwaysLastReturned)
				{
					this._isExpandedAlwaysLastReturned = flag;
					base.DirtyScrollCount();
					base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
				}
				return flag;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x0009D090 File Offset: 0x0009B290
		internal bool IsHeaderVisible
		{
			get
			{
				bool result = true;
				switch (this.Field.ExpandableFieldRecordHeaderDisplayModeResolved)
				{
				case global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.NeverDisplayHeader:
					result = false;
					break;
				case global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.DisplayHeaderOnlyWhenExpanded:
					result = this.IsExpanded;
					break;
				case global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordHeaderDisplayMode.DisplayHeaderOnlyWhenCollapsed:
					result = !this.IsExpanded;
					break;
				}
				return result;
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x0009D0DC File Offset: 0x0009B2DC
		internal bool CheckHasChildData()
		{
			if (!this.Field.IsExpandableByDefault)
			{
				object cellValue = base.ParentDataRecord.GetCellValue(this.Field, true);
				return cellValue != null && !(cellValue is global::System.DBNull);
			}
			if (this.HasVisibleChildren)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = this.ChildRecordManagerIfNeeded;
			if (childRecordManagerIfNeeded == null)
			{
				return false;
			}
			if (childRecordManagerIfNeeded.Unsorted.Count > 0)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = childRecordManagerIfNeeded.FieldLayout;
				if (fieldLayout.HasSeparateHeader && fieldLayout.FilterUITypeResolved == global::Infragistics.Windows.DataPresenter.FilterUIType.LabelIcons)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x0009D15A File Offset: 0x0009B35A
		internal void Initialize()
		{
			base.Visibility = this.Field.VisibilityResolved;
			base.FireInitializeRecord();
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0009D174 File Offset: 0x0009B374
		internal void OnDataChanged()
		{
			if (this._trackingInfo != null)
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

		// Token: 0x06002408 RID: 9224 RVA: 0x0009D1A8 File Offset: 0x0009B3A8
		private void ClearChildDataCache(bool unwireEvents)
		{
			if (this._trackingInfo == null)
			{
				return;
			}
			if (unwireEvents)
			{
				this._trackingInfo.Unwire(this);
			}
			this._trackingInfo = null;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0009D1CC File Offset: 0x0009B3CC
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase GetChildRcdCollection(bool alwaysCreateifEnumerable)
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager;
			if (alwaysCreateifEnumerable)
			{
				recordManager = this.ChildRecordManager;
			}
			else
			{
				recordManager = this.ChildRecordManagerIfNeeded;
			}
			if (recordManager == null)
			{
				return null;
			}
			return recordManager.Current;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0009D1F8 File Offset: 0x0009B3F8
		private void OnPropertyDescriptorChanged()
		{
			if (this._records == null)
			{
				return;
			}
			if (this._field.IsExpandableByDefault)
			{
				this._records.DataSource = (base.ParentDataRecord.GetCellValue(this._field, true) as global::System.Collections.IEnumerable);
				return;
			}
			this._records.DataSource = null;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0009D24C File Offset: 0x0009B44C
		private void VerifyChildRecordManager(bool alwaysCreateIfEnumerable)
		{
			if (this._records != null)
			{
				return;
			}
			if (!this.Field.IsExpandableByDefault)
			{
				return;
			}
			bool flag = false;
			bool flag2 = alwaysCreateIfEnumerable;
			if (this._trackingInfo == null)
			{
				this._trackingInfo = new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo(base.ParentDataRecord.GetCellValue(this._field, true) as global::System.Collections.IEnumerable);
				if (this._trackingInfo._childData != null)
				{
					flag = true;
					flag2 = this._trackingInfo.Initialize(base.DataPresenter, alwaysCreateIfEnumerable);
				}
			}
			if (flag2)
			{
				this._records = new global::Infragistics.Windows.DataPresenter.RecordManager(base.DataPresenter, this, this._field);
				this._records.DataSource = this._trackingInfo._childData;
				this.ClearChildDataCache(!flag);
				return;
			}
			if (flag)
			{
				this._trackingInfo.Wire(this);
			}
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0009D30C File Offset: 0x0009B50C
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				string propertyName;
				if ((propertyName = ((global::System.ComponentModel.PropertyChangedEventArgs)e).PropertyName) != null)
				{
					if (!(propertyName == "VisibilityResolved"))
					{
						if (propertyName == "PropertyDescriptorVersion")
						{
							this.OnPropertyDescriptorChanged();
						}
					}
					else
					{
						base.Visibility = this._field.VisibilityResolved;
					}
				}
				return true;
			}
			if (managerType == typeof(global::System.Collections.Specialized.CollectionChangedEventManager) || managerType == typeof(global::Infragistics.Windows.Helpers.BindingListChangedEventManager))
			{
				this.OnDataChanged();
				return true;
			}
			return false;
		}

		// Token: 0x04001175 RID: 4469
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001176 RID: 4470
		private global::Infragistics.Windows.DataPresenter.RecordManager _records;

		// Token: 0x04001177 RID: 4471
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo _trackingInfo;

		// Token: 0x04001178 RID: 4472
		private bool _isExpandedLastReturned;

		// Token: 0x04001179 RID: 4473
		private bool _isExpandedAlwaysLastReturned;

		// Token: 0x02000301 RID: 769
		internal class ChildDataTrackingInfo
		{
			// Token: 0x0600240D RID: 9229 RVA: 0x0009D39E File Offset: 0x0009B59E
			internal ChildDataTrackingInfo(global::System.Collections.IEnumerable childData)
			{
				this._childData = childData;
				if (this._childData != null)
				{
					this._underlyingData = global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(this._childData, false);
				}
			}

			// Token: 0x0600240E RID: 9230 RVA: 0x0009D3C8 File Offset: 0x0009B5C8
			internal bool Initialize(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp, bool bypassAddNewCheck)
			{
				if (bypassAddNewCheck)
				{
					return true;
				}
				if (this._underlyingData == null)
				{
					return false;
				}
				global::System.Collections.ICollection collection = this._underlyingData as global::System.Collections.ICollection;
				bool flag;
				if (collection != null)
				{
					flag = (collection.Count > 0);
				}
				else
				{
					flag = this._underlyingData.GetEnumerator().MoveNext();
				}
				if (!flag)
				{
					bool flag2 = false;
					this._proxy = global::Infragistics.Windows.DataPresenter.RecordManager.GetEditableCollectionViewProxy(this._underlyingData, this._proxy);
					if (this._proxy != null)
					{
						flag2 = this._proxy.CanAddNew;
					}
					else
					{
						global::System.ComponentModel.IBindingList bindingList = this._underlyingData as global::System.ComponentModel.IBindingList;
						if (bindingList != null && bindingList.AllowNew)
						{
							global::System.Type left;
							flag2 = (global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(this._underlyingData, out left) != null || left != null);
						}
					}
					if (flag2)
					{
						flag = true;
						if (dp != null && dp.FieldLayoutSettingsIfAllocated != null)
						{
							bool? allowAddNew = dp.FieldLayoutSettingsIfAllocated.AllowAddNew;
							if (allowAddNew != null)
							{
								flag = allowAddNew.Value;
							}
						}
					}
				}
				return flag;
			}

			// Token: 0x0600240F RID: 9231 RVA: 0x0009D4AC File Offset: 0x0009B6AC
			internal void Unwire(global::System.Windows.IWeakEventListener listener)
			{
				if (this._proxy != null)
				{
					global::System.Collections.Specialized.CollectionChangedEventManager.RemoveListener(this._proxy.View, listener);
					return;
				}
				global::System.ComponentModel.IBindingList bindingList = this._underlyingData as global::System.ComponentModel.IBindingList;
				if (bindingList != null)
				{
					global::Infragistics.Windows.Helpers.BindingListChangedEventManager.RemoveListener(bindingList, listener);
					return;
				}
				global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this._underlyingData as global::System.Collections.Specialized.INotifyCollectionChanged;
				if (notifyCollectionChanged != null)
				{
					global::System.Collections.Specialized.CollectionChangedEventManager.RemoveListener(notifyCollectionChanged, listener);
				}
			}

			// Token: 0x06002410 RID: 9232 RVA: 0x0009D500 File Offset: 0x0009B700
			internal void Wire(global::System.Windows.IWeakEventListener listener)
			{
				if (this._proxy != null)
				{
					global::System.Collections.Specialized.CollectionChangedEventManager.AddListener(this._proxy.View, listener);
					return;
				}
				global::System.ComponentModel.IBindingList bindingList = this._underlyingData as global::System.ComponentModel.IBindingList;
				if (bindingList != null)
				{
					global::Infragistics.Windows.Helpers.BindingListChangedEventManager.AddListener(bindingList, listener);
					return;
				}
				global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this._underlyingData as global::System.Collections.Specialized.INotifyCollectionChanged;
				if (notifyCollectionChanged != null)
				{
					global::System.Collections.Specialized.CollectionChangedEventManager.AddListener(notifyCollectionChanged, listener);
				}
			}

			// Token: 0x0400117A RID: 4474
			internal global::System.Collections.IEnumerable _childData;

			// Token: 0x0400117B RID: 4475
			internal global::System.Collections.IEnumerable _underlyingData;

			// Token: 0x0400117C RID: 4476
			internal global::Infragistics.Windows.EditableCollectionViewProxy _proxy;
		}
	}
}
