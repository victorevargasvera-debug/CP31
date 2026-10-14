using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Windows;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000341 RID: 833
	public class ExpandableFieldRecord : global::Infragistics.Windows.DataPresenter.Record, global::System.Windows.IWeakEventListener
	{
		// Token: 0x06002799 RID: 10137 RVA: 0x000B07C8 File Offset: 0x000AE9C8
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

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x000B0819 File Offset: 0x000AEA19
		internal override global::Infragistics.Windows.DataPresenter.Field AssociatedField
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x000B0821 File Offset: 0x000AEA21
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return this.GetChildRcdCollection(false);
			}
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000B082A File Offset: 0x000AEA2A
		internal override global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal
		{
			get
			{
				return this.ChildRecords;
			}
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x000B0834 File Offset: 0x000AEA34
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

		// Token: 0x0600279E RID: 10142 RVA: 0x000B086B File Offset: 0x000AEA6B
		internal override global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter()
		{
			return new global::Infragistics.Windows.DataPresenter.ExpandableFieldRecordPresenter();
		}

		// Token: 0x17000BB0 RID: 2992
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x000B0874 File Offset: 0x000AEA74
		// (set) Token: 0x060027A0 RID: 10144 RVA: 0x000B090B File Offset: 0x000AEB0B
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

		// Token: 0x060027A1 RID: 10145 RVA: 0x000B0914 File Offset: 0x000AEB14
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
			foreach (global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord2 in dataRecord.ChildRecords)
			{
				if (expandableFieldRecord2 != null && expandableFieldRecord2.Field.Name == this.Field.Name)
				{
					return expandableFieldRecord2;
				}
			}
			return null;
		}

		// Token: 0x17000BB1 RID: 2993
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000B0A00 File Offset: 0x000AEC00
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

		// Token: 0x17000BB2 RID: 2994
		// (get) Token: 0x060027A3 RID: 10147 RVA: 0x000B0A48 File Offset: 0x000AEC48
		internal override bool HasChildData
		{
			get
			{
				return !this.IsExpanded || this.CheckHasChildData();
			}
		}

		// Token: 0x17000BB3 RID: 2995
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000B0A5C File Offset: 0x000AEC5C
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

		// Token: 0x17000BB4 RID: 2996
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x000B0A88 File Offset: 0x000AEC88
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x000B0AD4 File Offset: 0x000AECD4
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

		// Token: 0x17000BB5 RID: 2997
		// (get) Token: 0x060027A7 RID: 10151 RVA: 0x000B0AE0 File Offset: 0x000AECE0
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

		// Token: 0x17000BB6 RID: 2998
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x000B0B81 File Offset: 0x000AED81
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::Infragistics.Windows.DataPresenter.RecordType RecordType
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord;
			}
		}

		// Token: 0x17000BB7 RID: 2999
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x000B0B84 File Offset: 0x000AED84
		protected internal override bool IsSelectable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x000B0B88 File Offset: 0x000AED88
		internal override void SortChildren()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager childRecordManagerIfNeeded = this.ChildRecordManagerIfNeeded;
			if (childRecordManagerIfNeeded != null)
			{
				childRecordManagerIfNeeded.VerifySort();
			}
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000B0BA8 File Offset: 0x000AEDA8
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

		// Token: 0x060027AC RID: 10156 RVA: 0x000B0C02 File Offset: 0x000AEE02
		internal override void VerifySortOrderOfChildren()
		{
			if (this._records == null || this._records.Unsorted.Count < 1)
			{
				return;
			}
			this.SortChildren();
		}

		// Token: 0x17000BB8 RID: 3000
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000B0C28 File Offset: 0x000AEE28
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

		// Token: 0x17000BB9 RID: 3001
		// (get) Token: 0x060027AE RID: 10158 RVA: 0x000B0C55 File Offset: 0x000AEE55
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.RecordManager ChildRecordManager
		{
			get
			{
				this.VerifyChildRecordManager(true);
				return this._records;
			}
		}

		// Token: 0x17000BBA RID: 3002
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x000B0C64 File Offset: 0x000AEE64
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecords
		{
			get
			{
				return this.GetChildRcdCollection(true);
			}
		}

		// Token: 0x17000BBB RID: 3003
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x000B0C6D File Offset: 0x000AEE6D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000BBC RID: 3004
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x000B0C75 File Offset: 0x000AEE75
		internal global::Infragistics.Windows.DataPresenter.RecordManager ChildRecordManagerIfAllocated
		{
			get
			{
				return this._records;
			}
		}

		// Token: 0x17000BBD RID: 3005
		// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000B0C7D File Offset: 0x000AEE7D
		internal global::Infragistics.Windows.DataPresenter.RecordManager ChildRecordManagerIfNeeded
		{
			get
			{
				this.VerifyChildRecordManager(false);
				return this._records;
			}
		}

		// Token: 0x17000BBE RID: 3006
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000B0C8C File Offset: 0x000AEE8C
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

		// Token: 0x17000BBF RID: 3007
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000B0CF8 File Offset: 0x000AEEF8
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

		// Token: 0x060027B5 RID: 10165 RVA: 0x000B0D44 File Offset: 0x000AEF44
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

		// Token: 0x060027B6 RID: 10166 RVA: 0x000B0DC2 File Offset: 0x000AEFC2
		internal void Initialize()
		{
			base.Visibility = this.Field.VisibilityResolved;
			base.FireInitializeRecord();
		}

		// Token: 0x060027B7 RID: 10167 RVA: 0x000B0DDC File Offset: 0x000AEFDC
		internal void OnDataChanged()
		{
			if (this._trackingInfo != null)
			{
				this.ClearChildDataCache(true);
				this.CheckHasChildData();
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

		// Token: 0x060027B8 RID: 10168 RVA: 0x000B0E17 File Offset: 0x000AF017
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

		// Token: 0x060027B9 RID: 10169 RVA: 0x000B0E38 File Offset: 0x000AF038
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

		// Token: 0x060027BA RID: 10170 RVA: 0x000B0E64 File Offset: 0x000AF064
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

		// Token: 0x060027BB RID: 10171 RVA: 0x000B0EB8 File Offset: 0x000AF0B8
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

		// Token: 0x060027BC RID: 10172 RVA: 0x000B0F78 File Offset: 0x000AF178
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

		// Token: 0x04001395 RID: 5013
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001396 RID: 5014
		private global::Infragistics.Windows.DataPresenter.RecordManager _records;

		// Token: 0x04001397 RID: 5015
		private global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord.ChildDataTrackingInfo _trackingInfo;

		// Token: 0x04001398 RID: 5016
		private bool _isExpandedLastReturned;

		// Token: 0x04001399 RID: 5017
		private bool _isExpandedAlwaysLastReturned;

		// Token: 0x02000342 RID: 834
		internal class ChildDataTrackingInfo
		{
			// Token: 0x060027BD RID: 10173 RVA: 0x000B100A File Offset: 0x000AF20A
			internal ChildDataTrackingInfo(global::System.Collections.IEnumerable childData)
			{
				this._childData = childData;
				if (this._childData != null)
				{
					this._underlyingData = global::Infragistics.Windows.Internal.DataBindingUtilities.GetUnderlyingItemSource(this._childData, false);
				}
			}

			// Token: 0x060027BE RID: 10174 RVA: 0x000B1034 File Offset: 0x000AF234
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
						if (bindingList != null)
						{
							if (bindingList.AllowNew)
							{
								global::System.Type left;
								flag2 = (global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(this._underlyingData, out left) != null || left != null);
							}
						}
						else
						{
							global::System.Collections.IList list = this._underlyingData as global::System.Collections.IList;
							if (list != null && !list.IsFixedSize && !list.IsReadOnly)
							{
								global::System.Type type;
								global::Infragistics.Windows.Internal.PropertyDescriptorProvider.GetTypedListFromContainingList(this._underlyingData, out type);
								if (type != null && type != typeof(object) && !type.IsAbstract && type != null && !type.IsAbstract && (type.IsPrimitive || type == typeof(string) || type.GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.CreateInstance, null, global::System.Type.EmptyTypes, null) != null))
								{
									flag2 = true;
								}
							}
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

			// Token: 0x060027BF RID: 10175 RVA: 0x000B11D0 File Offset: 0x000AF3D0
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

			// Token: 0x060027C0 RID: 10176 RVA: 0x000B1224 File Offset: 0x000AF424
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

			// Token: 0x0400139A RID: 5018
			internal global::System.Collections.IEnumerable _childData;

			// Token: 0x0400139B RID: 5019
			internal global::System.Collections.IEnumerable _underlyingData;

			// Token: 0x0400139C RID: 5020
			internal global::Infragistics.Windows.EditableCollectionViewProxy _proxy;
		}
	}
}
