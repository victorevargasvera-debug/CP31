using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Data;
using Infragistics.AutomationPeers;
using Infragistics.Collections;
using Infragistics.Controls.Layouts.Primitives;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000147 RID: 327
	public abstract class Record : global::Infragistics.PropertyChangeNotifier, global::Infragistics.Collections.ISparseArrayMultiItem, global::Infragistics.Collections.ISparseArrayItem, global::Infragistics.Windows.Selection.ISelectableItem
	{
		// Token: 0x06001197 RID: 4503 RVA: 0x0004C3D0 File Offset: 0x0004A5D0
		protected Record(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection)
		{
			if (layout == null)
			{
				throw new global::System.ArgumentNullException("layout");
			}
			if (parentCollection == null)
			{
				throw new global::System.ArgumentNullException("parentCollection");
			}
			this._fieldLayout = layout;
			this._parentCollection = parentCollection;
			if (!(this is global::Infragistics.Windows.DataPresenter.TemplateDataRecord))
			{
				layout.MaxRecordManagerDepth = parentCollection.ParentRecordManager.NestingDepth;
			}
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x0004C444 File Offset: 0x0004A644
		protected override void OnHasListenersChanged()
		{
			if (base.HasListeners && this._index != -1 && this._parentCollectionVersionTracker == null)
			{
				this._parentCollectionVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._parentCollection, "CollectionVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnParentCollectionVersionChanged));
			}
			else
			{
				this._parentCollectionVersionTracker = null;
			}
			base.OnHasListenersChanged();
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0004C49B File Offset: 0x0004A69B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._parentCollection.ParentRecordManager.DataPresenter;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600119A RID: 4506 RVA: 0x0004C4AD File Offset: 0x0004A6AD
		// (set) Token: 0x0600119B RID: 4507 RVA: 0x0004C4D1 File Offset: 0x0004A6D1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual string Description
		{
			get
			{
				if (this._description != null && this._description.Length > 0)
				{
					return this._description;
				}
				return string.Empty;
			}
			set
			{
				if (this._description != value)
				{
					this._description = value;
					base.RaisePropertyChangedEvent("Description");
				}
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600119C RID: 4508 RVA: 0x0004C4F4 File Offset: 0x0004A6F4
		// (set) Token: 0x0600119D RID: 4509 RVA: 0x0004C736 File Offset: 0x0004A936
		public global::System.Windows.Visibility ExpansionIndicatorVisibility
		{
			get
			{
				if (this.DataPresenter is global::Infragistics.Windows.DataPresenter.DataPresenterReportControl)
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				global::System.Windows.Visibility? visibility = null;
				if (!this.CanExpand)
				{
					visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Collapsed);
				}
				else if (this is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					if (this._explicitExpansionIndicatorVisibility != null)
					{
						visibility = new global::System.Windows.Visibility?(this._explicitExpansionIndicatorVisibility.Value);
					}
					else
					{
						visibility = new global::System.Windows.Visibility?(this.FieldLayout.GroupByExpansionIndicatorVisibilityResolved);
						if (visibility.Value == global::System.Windows.Visibility.Collapsed && this.ParentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
						{
							visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Hidden);
						}
					}
				}
				else
				{
					if (this._explicitExpansionIndicatorVisibility != null)
					{
						visibility = new global::System.Windows.Visibility?(this._explicitExpansionIndicatorVisibility.Value);
					}
					if (visibility == null && this is global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord && ((global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord)this).IsExpandedAlways)
					{
						visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Collapsed);
					}
					global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this as global::Infragistics.Windows.DataPresenter.DataRecord;
					global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = this as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
					bool flag = (dataRecord != null && dataRecord.IsAddRecord) || this is global::Infragistics.Windows.DataPresenter.SummaryRecord || this is global::Infragistics.Windows.DataPresenter.FilterRecord;
					bool flag2 = global::Infragistics.Windows.DataPresenter.RecordType.DataRecord == this.ParentCollection.RecordsType;
					global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode expansionIndicatorDisplayMode;
					if (visibility == null && (flag2 || expandableFieldRecord != null))
					{
						expansionIndicatorDisplayMode = this.FieldLayout.ExpansionIndicatorDisplayModeResolved;
						switch (expansionIndicatorDisplayMode)
						{
						case global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.Always:
							visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Visible);
							break;
						case global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.Never:
							visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Collapsed);
							break;
						}
					}
					else
					{
						expansionIndicatorDisplayMode = global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.Default;
					}
					if (visibility == null && (flag2 || expandableFieldRecord != null))
					{
						if (flag2 && (!this.DataPresenter.IsNestedDataDisplayEnabled || this.FieldLayout.Fields.NotCollapsedExpandableFieldsCount == 0))
						{
							visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Collapsed);
						}
						else if (flag)
						{
							visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Hidden);
						}
						else if (expansionIndicatorDisplayMode == global::Infragistics.Windows.DataPresenter.ExpansionIndicatorDisplayMode.CheckOnDisplay || this.IsExpanded)
						{
							visibility = new global::System.Windows.Visibility?(this.GetExpansionIndicatorVisibilityBasedOnContent());
						}
						else
						{
							visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Visible);
						}
					}
					if (global::System.Windows.Visibility.Collapsed != visibility && flag)
					{
						visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Hidden);
					}
				}
				if (visibility == null)
				{
					visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Visible);
				}
				if (visibility.Value != this._expansionIndicatorVisibilityLastReturned)
				{
					this._expansionIndicatorVisibilityLastReturned = visibility.Value;
					base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
				}
				return visibility.Value;
			}
			set
			{
				if (this._explicitExpansionIndicatorVisibility == null || this._explicitExpansionIndicatorVisibility.Value != value)
				{
					this._explicitExpansionIndicatorVisibility = new global::System.Windows.Visibility?(value);
					base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
				}
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600119E RID: 4510 RVA: 0x0004C76A File Offset: 0x0004A96A
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600119F RID: 4511 RVA: 0x0004C772 File Offset: 0x0004A972
		// (set) Token: 0x060011A0 RID: 4512 RVA: 0x0004C77C File Offset: 0x0004A97C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FixedRecordLocation FixedLocation
		{
			get
			{
				return this._fixedLocation;
			}
			set
			{
				if (this._fixedLocation != value)
				{
					if (!this.IsFixedLocationAllowed(value))
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_14", new object[]
						{
							this.ToString()
						}));
					}
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = (this._parentCollection != null) ? this._parentCollection.ViewableRecords : null;
					this._fixedRecordLocationOverride = global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Default;
					this._fixedLocation = value;
					if (viewableRecordCollection != null)
					{
						viewableRecordCollection.OnFixedStatusChanged(this);
					}
					base.RaisePropertyChangedEvent("IsFixed");
					base.RaisePropertyChangedEvent("FixedLocation");
					this.CheckFixedAndExpandedStates();
				}
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060011A1 RID: 4513 RVA: 0x0004C807 File Offset: 0x0004AA07
		public virtual bool HasChildren
		{
			get
			{
				return this.HasChildrenInternal;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0004C810 File Offset: 0x0004AA10
		public int Index
		{
			get
			{
				if (this._parentCollection == null)
				{
					return -1;
				}
				if (this._index < 0 || this._index >= this._parentCollection.Count || this._parentCollection[this._index] != this)
				{
					if (this._index < 0 && base.HasListeners && this._parentCollectionVersionTracker == null)
					{
						this._parentCollectionVersionTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._parentCollection, "CollectionVersion", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnParentCollectionVersionChanged));
					}
					this._index = this._parentCollection.IndexOf(this);
				}
				return this._index;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060011A3 RID: 4515 RVA: 0x0004C8AA File Offset: 0x0004AAAA
		// (set) Token: 0x060011A4 RID: 4516 RVA: 0x0004C8BA File Offset: 0x0004AABA
		public bool IsActive
		{
			get
			{
				return this.DataPresenter.ActiveRecord == this;
			}
			set
			{
				if (this.IsActive != value)
				{
					if (value)
					{
						this.DataPresenter.SetActiveRecord(this, false);
						return;
					}
					this.DataPresenter.SetActiveRecord(null, false);
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060011A5 RID: 4517 RVA: 0x0004C8E3 File Offset: 0x0004AAE3
		// (set) Token: 0x060011A6 RID: 4518 RVA: 0x0004C8EC File Offset: 0x0004AAEC
		public bool? IsContainingCardCollapsed
		{
			get
			{
				return this._isContainingCardCollapsed;
			}
			set
			{
				if (this._isContainingCardCollapsed != value)
				{
					this._isContainingCardCollapsed = value;
					base.RaisePropertyChangedEvent("IsContainingCardCollapsed");
					base.RaisePropertyChangedEvent("IsContainingCardCollapsedResolved");
				}
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x060011A7 RID: 4519 RVA: 0x0004C948 File Offset: 0x0004AB48
		public bool IsContainingCardCollapsedResolved
		{
			get
			{
				if (this._isContainingCardCollapsed != null)
				{
					return this._isContainingCardCollapsed.Value;
				}
				return this.FieldLayout != null && this.FieldLayout.DataPresenter != null && this.FieldLayout.DataPresenter.CurrentViewInternal != null && this.FieldLayout.DataPresenter.CurrentViewInternal.DefaultShouldCollapseCards;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x060011A8 RID: 4520 RVA: 0x0004C9AC File Offset: 0x0004ABAC
		// (set) Token: 0x060011A9 RID: 4521 RVA: 0x0004C9B4 File Offset: 0x0004ABB4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Obsolete("Use IsEnabled property instead", false)]
		public bool Enabled
		{
			get
			{
				return this.IsEnabled;
			}
			set
			{
				this.IsEnabled = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x060011AA RID: 4522 RVA: 0x0004C9BD File Offset: 0x0004ABBD
		// (set) Token: 0x060011AB RID: 4523 RVA: 0x0004C9C5 File Offset: 0x0004ABC5
		public bool IsEnabled
		{
			get
			{
				return this._enabled;
			}
			set
			{
				if (this._enabled != value)
				{
					this._enabled = value;
					base.RaisePropertyChangedEvent("Enabled");
					base.RaisePropertyChangedEvent("IsEnabled");
					base.RaisePropertyChangedEvent("IsEnabledResolved");
				}
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x060011AC RID: 4524 RVA: 0x0004C9F8 File Offset: 0x0004ABF8
		public bool IsEnabledResolved
		{
			get
			{
				return this._enabled && ((byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable & this._cachedFilterState) == 0 || (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & this._cachedFilterState) == 0);
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x060011AD RID: 4525 RVA: 0x0004CA1E File Offset: 0x0004AC1E
		// (set) Token: 0x060011AE RID: 4526 RVA: 0x0004CA30 File Offset: 0x0004AC30
		public virtual bool IsExpanded
		{
			get
			{
				return this._isExpanded && this.CanExpand;
			}
			set
			{
				this.ExpandCollapse(value, false);
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x060011AF RID: 4527 RVA: 0x0004CA3C File Offset: 0x0004AC3C
		// (set) Token: 0x060011B0 RID: 4528 RVA: 0x0004CAF4 File Offset: 0x0004ACF4
		public bool IsFixed
		{
			get
			{
				bool? flag = null;
				if (!this.DataPresenter.CurrentViewInternal.IsFixedRecordsSupported)
				{
					flag = new bool?(false);
				}
				if (flag == null && this._fixedRecordLocationOverride != global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Default)
				{
					flag = new bool?(global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top == this._fixedRecordLocationOverride || global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom == this._fixedRecordLocationOverride);
				}
				if (flag == null)
				{
					flag = new bool?(this._fixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable);
				}
				if (flag != this._isFixedLastReturned)
				{
					this._isFixedLastReturned = flag.Value;
					base.RaisePropertyChangedEvent("IsFixed");
				}
				return this._isFixedLastReturned;
			}
			set
			{
				if (value == (this._fixedLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable))
				{
					if (!this.CanFixedStatusBeChanged)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_InvalidOperationException_14", new object[]
						{
							this.ToString()
						}));
					}
					if (this._fieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.FixedRecordLocation fixedLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable;
						if (value)
						{
							if (this._fieldLayout.AllowRecordFixingResolved == global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Bottom)
							{
								fixedLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToBottom;
							}
							else
							{
								fixedLocation = global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop;
							}
						}
						this.FixedLocation = fixedLocation;
					}
				}
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x060011B1 RID: 4529 RVA: 0x0004CB5E File Offset: 0x0004AD5E
		// (set) Token: 0x060011B2 RID: 4530 RVA: 0x0004CB68 File Offset: 0x0004AD68
		public bool IsSelected
		{
			get
			{
				return this._selected;
			}
			set
			{
				if (this._selected != value)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
					if (dataPresenter != null)
					{
						global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
						if (fieldLayout != null)
						{
							bool clearExistingSelection = true;
							global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = fieldLayout.GetSelectionStrategyForItem(this);
							if (selectionStrategyForItem != null)
							{
								clearExistingSelection = selectionStrategyForItem.IsSingleSelect;
							}
							if (!dataPresenter.ClearSelectedCells())
							{
								return;
							}
							bool flag = dataPresenter.InternalSelectItem(this, clearExistingSelection, value);
							if (flag && dataPresenter.SelectedItems.Records.Count == 1)
							{
								((global::Infragistics.Windows.Selection.ISelectionHost)dataPresenter).SetPivotItem(this, false);
							}
						}
					}
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060011B3 RID: 4531 RVA: 0x0004CBDC File Offset: 0x0004ADDC
		public int NestingDepth
		{
			get
			{
				int num = 0;
				for (global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord; parentRecord != null; parentRecord = parentRecord.ParentRecord)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060011B4 RID: 4532 RVA: 0x0004CC03 File Offset: 0x0004AE03
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataRecord ParentDataRecord
		{
			get
			{
				return this._parentCollection.ParentDataRecord;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060011B5 RID: 4533 RVA: 0x0004CC10 File Offset: 0x0004AE10
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Record ParentRecord
		{
			get
			{
				return this._parentCollection.ParentRecord;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060011B6 RID: 4534 RVA: 0x0004CC1D File Offset: 0x0004AE1D
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060011B7 RID: 4535
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract global::Infragistics.Windows.DataPresenter.RecordType RecordType { get; }

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060011B8 RID: 4536 RVA: 0x0004CC25 File Offset: 0x0004AE25
		// (set) Token: 0x060011B9 RID: 4537 RVA: 0x0004CC30 File Offset: 0x0004AE30
		public bool? ShouldCollapseEmptyCells
		{
			get
			{
				return this._shouldCollapseEmptyCells;
			}
			set
			{
				if (this._shouldCollapseEmptyCells != value)
				{
					this._shouldCollapseEmptyCells = value;
					base.RaisePropertyChangedEvent("ShouldCollapseEmptyCells");
					base.RaisePropertyChangedEvent("ShouldCollapseEmptyCellsResolved");
					this.BumpCellLayoutVersion();
				}
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060011BA RID: 4538 RVA: 0x0004CC91 File Offset: 0x0004AE91
		public virtual bool ShouldCollapseEmptyCellsResolved
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060011BB RID: 4539 RVA: 0x0004CC94 File Offset: 0x0004AE94
		// (set) Token: 0x060011BC RID: 4540 RVA: 0x0004CC9C File Offset: 0x0004AE9C
		public object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				if (this._tag != value)
				{
					this._tag = value;
					base.RaisePropertyChangedEvent("Tag");
				}
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060011BD RID: 4541 RVA: 0x0004CCBC File Offset: 0x0004AEBC
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.GroupByRecord TopLevelGroup
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				if (parentRecord == null)
				{
					return this as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				}
				if (parentRecord is global::Infragistics.Windows.DataPresenter.GroupByRecord)
				{
					return parentRecord.TopLevelGroup;
				}
				return this as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060011BE RID: 4542 RVA: 0x0004CCF0 File Offset: 0x0004AEF0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Record UltimateParentRecord
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				if (parentRecord != null)
				{
					return parentRecord.UltimateParentRecord;
				}
				return this;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060011BF RID: 4543 RVA: 0x0004CD10 File Offset: 0x0004AF10
		public global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecords
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal = this.ChildRecordsInternal;
				if (childRecordsInternal != null)
				{
					return childRecordsInternal.ViewableRecords;
				}
				return null;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060011C0 RID: 4544 RVA: 0x0004CD2F File Offset: 0x0004AF2F
		// (set) Token: 0x060011C1 RID: 4545 RVA: 0x0004CD38 File Offset: 0x0004AF38
		public global::System.Windows.Visibility Visibility
		{
			get
			{
				return this._visibility;
			}
			set
			{
				if (this._visibility != value)
				{
					this.ChangeVisibilityHelper(new global::System.Windows.Visibility?(value), null);
				}
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060011C2 RID: 4546 RVA: 0x0004CD63 File Offset: 0x0004AF63
		public virtual global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				return this.GetVisibilityResolved(true);
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060011C3 RID: 4547 RVA: 0x0004CD6C File Offset: 0x0004AF6C
		public int VisibleIndex
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordCollection = (this._parentCollection != null) ? this._parentCollection.ViewableRecords : null;
				if (viewableRecordCollection == null)
				{
					return -1;
				}
				return viewableRecordCollection.IndexOf(this);
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060011C4 RID: 4548 RVA: 0x0004CD9C File Offset: 0x0004AF9C
		internal bool AreChildrenAfterParent
		{
			get
			{
				return this.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.AfterParent;
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060011C5 RID: 4549 RVA: 0x0004CDAC File Offset: 0x0004AFAC
		internal virtual global::Infragistics.Windows.DataPresenter.Field AssociatedField
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060011C6 RID: 4550 RVA: 0x0004CDB0 File Offset: 0x0004AFB0
		// (set) Token: 0x060011C7 RID: 4551 RVA: 0x0004CDF4 File Offset: 0x0004AFF4
		internal global::Infragistics.Windows.DataPresenter.RecordPresenter AssociatedRecordPresenter
		{
			get
			{
				if (this._associatedRecordPresenter == null)
				{
					return null;
				}
				global::Infragistics.Windows.DataPresenter.RecordPresenter recordPresenter = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._associatedRecordPresenter) as global::Infragistics.Windows.DataPresenter.RecordPresenter;
				if (recordPresenter == null || recordPresenter.Record != this)
				{
					this._associatedRecordPresenter = null;
					this.OnAssociatedRecordPresenterChanged();
					return null;
				}
				return recordPresenter;
			}
			set
			{
				if (value != this.AssociatedRecordPresenter)
				{
					if (value != null)
					{
						global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer automationPeer = this.AutomationPeer;
						if (automationPeer != null)
						{
							global::System.Windows.Automation.Peers.AutomationPeer automationPeer2 = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(value);
							if (automationPeer2 != null)
							{
								automationPeer2.EventsSource = automationPeer;
							}
						}
					}
					if (value == null)
					{
						this._associatedRecordPresenter = null;
					}
					else
					{
						this._associatedRecordPresenter = value.WeakRef;
					}
					this.OnAssociatedRecordPresenterChanged();
				}
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060011C8 RID: 4552 RVA: 0x0004CE46 File Offset: 0x0004B046
		internal global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer AutomationPeer
		{
			get
			{
				if (this._automationPeer == null)
				{
					return null;
				}
				return (global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer)global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._automationPeer);
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060011C9 RID: 4553 RVA: 0x0004CE62 File Offset: 0x0004B062
		internal virtual bool CanDelete
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060011CA RID: 4554 RVA: 0x0004CE68 File Offset: 0x0004B068
		internal bool CanExpand
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter == null)
				{
					return false;
				}
				if (this is global::Infragistics.Windows.DataPresenter.DataRecord && !dataPresenter.IsNestedDataDisplayEnabled)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
				return currentViewInternal != null && currentViewInternal.SupportedDataDisplayMode != global::Infragistics.Windows.DataPresenter.DataDisplayMode.Flat;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060011CB RID: 4555 RVA: 0x0004CEAB File Offset: 0x0004B0AB
		internal virtual bool CanFixedStatusBeChanged
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060011CC RID: 4556 RVA: 0x0004CEAE File Offset: 0x0004B0AE
		internal virtual global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return this.ChildRecordsInternal;
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060011CD RID: 4557
		internal abstract global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal { get; }

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060011CE RID: 4558 RVA: 0x0004CEB6 File Offset: 0x0004B0B6
		internal double FarOffset
		{
			get
			{
				return this._fieldLayout.TemplateDataRecordCache.GetRecordOffset(this, false);
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060011CF RID: 4559 RVA: 0x0004CECA File Offset: 0x0004B0CA
		// (set) Token: 0x060011D0 RID: 4560 RVA: 0x0004CED2 File Offset: 0x0004B0D2
		internal global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal FixedRecordLocationOverride
		{
			get
			{
				return this._fixedRecordLocationOverride;
			}
			set
			{
				this._fixedRecordLocationOverride = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060011D1 RID: 4561
		internal abstract bool HasChildrenInternal { get; }

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0004CEDC File Offset: 0x0004B0DC
		internal virtual bool HasVisibleChildren
		{
			get
			{
				if (!this.IsExpanded)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = this.ViewableChildRecordsIfNeeded;
				return viewableChildRecordsIfNeeded != null && viewableChildRecordsIfNeeded.Count > 0;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0004CF08 File Offset: 0x0004B108
		internal virtual bool HasChildData
		{
			get
			{
				return this.HasVisibleChildren;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0004CF10 File Offset: 0x0004B110
		internal bool HasCollapsedAncestor
		{
			get
			{
				for (global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord; parentRecord != null; parentRecord = parentRecord.ParentRecord)
				{
					if (!parentRecord.IsExpanded)
					{
						return true;
					}
				}
				return false;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060011D5 RID: 4565 RVA: 0x0004CF3B File Offset: 0x0004B13B
		internal bool HasFilterCriteriaBeenApplied
		{
			get
			{
				return 0 != (byte)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn) & this._cachedFilterState);
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0004CF4C File Offset: 0x0004B14C
		internal bool IsAncestorChainExpanded
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				return parentRecord == null || (parentRecord.IsExpanded && parentRecord.IsAncestorChainExpanded);
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0004CF75 File Offset: 0x0004B175
		internal bool InternalIsFilteredOut_NoVerify
		{
			get
			{
				return this.InternalIsFilteredOutHelper(false);
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0004CF7E File Offset: 0x0004B17E
		internal bool InternalIsFilteredOut_Verify
		{
			get
			{
				return this.InternalIsFilteredOutHelper(true);
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060011D9 RID: 4569 RVA: 0x0004CF87 File Offset: 0x0004B187
		internal bool? InternalIsFilteredOutNullable_NoVerify
		{
			get
			{
				return this.InternalIsFilteredOutNullableHelper(false);
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0004CF90 File Offset: 0x0004B190
		internal bool? InternalIsFilteredOutNullable_Verify
		{
			get
			{
				return this.InternalIsFilteredOutNullableHelper(true);
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x0004CF99 File Offset: 0x0004B199
		protected internal virtual bool IsActivatable
		{
			get
			{
				return this.IsEnabledResolved && this.VisibilityResolved == global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0004CFAE File Offset: 0x0004B1AE
		public virtual bool IsDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0004CFB1 File Offset: 0x0004B1B1
		internal virtual bool IsIndexValid
		{
			get
			{
				return this.IsSpecialRecord || this.Index >= 0;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0004CFCC File Offset: 0x0004B1CC
		internal virtual bool IsOnTopWhenFixed
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Top == this._fixedRecordLocationOverride)
				{
					return true;
				}
				if (global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal.Bottom == this._fixedRecordLocationOverride)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != null)
				{
					if (dataRecord.IsAddRecord)
					{
						switch (this.ParentCollection.ParentRecordManager.AddNewRecordLocation)
						{
						case global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTop:
						case global::Infragistics.Windows.DataPresenter.AddNewRecordLocation.OnTopFixed:
							return true;
						}
					}
					else
					{
						switch (this._fixedLocation)
						{
						case global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop:
							return true;
						case global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToBottom:
							return false;
						default:
							if (this._fieldLayout != null && this._fieldLayout.AllowRecordFixingResolved == global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Bottom)
							{
								return false;
							}
							break;
						}
					}
				}
				return true;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0004D05C File Offset: 0x0004B25C
		protected internal virtual bool IsSelectable
		{
			get
			{
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyDefault = this.SelectionStrategyDefault;
				return selectionStrategyDefault != null && !(selectionStrategyDefault is global::Infragistics.Windows.Selection.SelectionStrategyNone) && this.IsEnabledResolved;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0004D088 File Offset: 0x0004B288
		public virtual bool IsSpecialRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0004D08C File Offset: 0x0004B28C
		internal virtual bool IsStillValid
		{
			get
			{
				if (!this.IsIndexValid)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				if (parentRecord != null)
				{
					return parentRecord.IsStillValid;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter == null)
				{
					return false;
				}
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = this.ParentCollection;
				return parentCollection != null && parentCollection.ParentRecordManager == dataPresenter.RecordManager;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060011E2 RID: 4578 RVA: 0x0004D0DA File Offset: 0x0004B2DA
		internal virtual bool IsTemplateDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0004D0DD File Offset: 0x0004B2DD
		internal global::System.Windows.FrameworkElement NestedContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0004D0E0 File Offset: 0x0004B2E0
		internal int NestingDepthOfGroupByRcds
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
				if (groupByRecord != null)
				{
					return groupByRecord.NestingDepthOfGroupByRcds + 1;
				}
				return 0;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0004D106 File Offset: 0x0004B306
		internal virtual bool OccupiesScrollPosition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060011E6 RID: 4582 RVA: 0x0004D10C File Offset: 0x0004B30C
		internal int OverallScrollPosition
		{
			get
			{
				bool flag = false;
				return this.GetOverallScrollPosition(false, ref flag);
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060011E7 RID: 4583 RVA: 0x0004D124 File Offset: 0x0004B324
		internal long OverallSelectionPosition
		{
			get
			{
				long num = (long)this.OverallScrollPosition;
				if (num < 0L)
				{
					global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
					if (parentRecord != null)
					{
						num = 1L + parentRecord.OverallSelectionPosition;
					}
				}
				else
				{
					num <<= 32;
				}
				return num + (long)this.Index;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060011E8 RID: 4584 RVA: 0x0004D164 File Offset: 0x0004B364
		internal global::Infragistics.Windows.DataPresenter.RecordListControl ParentRecordList
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordListControl recordListControl = null;
				if (this.ParentCollection != null)
				{
					recordListControl = this.ParentCollection.LastRecordList;
					if (recordListControl == null && this.ParentCollection.ParentRecordManager != null)
					{
						global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ParentCollection.ParentRecordManager.ViewableRecords;
						if (viewableRecords != null)
						{
							recordListControl = viewableRecords.LastRecordList;
						}
					}
				}
				return recordListControl;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060011E9 RID: 4585 RVA: 0x0004D1B3 File Offset: 0x0004B3B3
		internal virtual global::Infragistics.Windows.DataPresenter.Record RecordForLayoutCalculations
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004D1B8 File Offset: 0x0004B3B8
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = this._parentCollection;
				if (parentCollection == null)
				{
					return null;
				}
				return parentCollection.ParentRecordManager;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x060011EB RID: 4587 RVA: 0x0004D1D8 File Offset: 0x0004B3D8
		internal int RecordManagerNestingDepth
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
				if (recordManager == null)
				{
					return -1;
				}
				return recordManager.NestingDepth;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x060011EC RID: 4588 RVA: 0x0004D1F7 File Offset: 0x0004B3F7
		internal global::Infragistics.Windows.Selection.SelectionStrategyBase SelectionStrategyDefault
		{
			get
			{
				if (this._fieldLayout == null)
				{
					return new global::Infragistics.Windows.Selection.SelectionStrategyNone(this.DataPresenter);
				}
				return this._fieldLayout.GetSelectionStrategyForItem(this);
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x060011ED RID: 4589 RVA: 0x0004D21C File Offset: 0x0004B41C
		internal int ScrollCountInternal
		{
			get
			{
				if (this.IsSpecialRecord)
				{
					return 0;
				}
				if (this.VisibilityResolved == global::System.Windows.Visibility.Collapsed)
				{
					return 0;
				}
				int num = 0;
				if (this.OccupiesScrollPosition)
				{
					num++;
				}
				if (this.IsExpanded && this.HasChildrenInternal)
				{
					global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = this.ViewableChildRecordsIfNeeded;
					if (viewableChildRecordsIfNeeded != null)
					{
						num += viewableChildRecordsIfNeeded.ScrollCount;
					}
				}
				return num;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x0004D270 File Offset: 0x0004B470
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x0004D278 File Offset: 0x0004B478
		internal global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility SeparatorVisibility
		{
			get
			{
				return this._separatorVisibility;
			}
			set
			{
				if (this._separatorVisibility != value)
				{
					this._separatorVisibility = value;
					base.RaisePropertyChangedEvent("SeparatorVisibility");
				}
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0004D298 File Offset: 0x0004B498
		internal global::Infragistics.Windows.DataPresenter.DataRecord TopLevelDataRecord
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = this.ParentDataRecord;
				if (parentDataRecord != null)
				{
					return parentDataRecord.TopLevelDataRecord;
				}
				return this as global::Infragistics.Windows.DataPresenter.DataRecord;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0004D2BC File Offset: 0x0004B4BC
		internal global::Infragistics.Windows.DataPresenter.GroupByRecord TopLevelGroupByFieldRecord
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				if (parentRecord == null)
				{
					if (this.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByField)
					{
						return this as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					}
					return null;
				}
				else
				{
					if (parentRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByField)
					{
						return parentRecord.TopLevelGroupByFieldRecord;
					}
					if (this.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByField)
					{
						return this as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					}
					return null;
				}
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060011F2 RID: 4594 RVA: 0x0004D308 File Offset: 0x0004B508
		internal int ViewableChildRecordScrollCount
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = this.ViewableChildRecordsIfNeeded;
				if (viewableChildRecordsIfNeeded != null)
				{
					return viewableChildRecordsIfNeeded.ScrollCount;
				}
				return 0;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0004D328 File Offset: 0x0004B528
		internal virtual global::Infragistics.Windows.DataPresenter.ViewableRecordCollection ViewableChildRecordsIfNeeded
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsIfNeeded = this.ChildRecordsIfNeeded;
				if (childRecordsIfNeeded != null)
				{
					return childRecordsIfNeeded.ViewableRecords;
				}
				return null;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0004D347 File Offset: 0x0004B547
		internal global::System.Windows.Visibility VisibilityResolved_NoFiltering
		{
			get
			{
				return this._visibility;
			}
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0004D350 File Offset: 0x0004B550
		public bool IsAncestorOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (record == this)
			{
				return false;
			}
			while (record != null)
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = record.ParentRecord;
				if (parentRecord == this)
				{
					return true;
				}
				record = parentRecord;
			}
			return false;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0004D378 File Offset: 0x0004B578
		public virtual void RefreshSortPosition()
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = this.ParentCollection;
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = (parentCollection != null) ? parentCollection.ParentRecordManager : null;
			if (recordManager == null || recordManager.IsInReset)
			{
				return;
			}
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			if (groupByRecord != null)
			{
				if (this is global::Infragistics.Windows.DataPresenter.DataRecord && !groupByRecord.DoesRecordMatchGroup((global::Infragistics.Windows.DataPresenter.DataRecord)this))
				{
					groupByRecord.ChildRecords.ViewableRecords.RemoveRecord(this, true);
					recordManager.Groups.ViewableRecords.InsertDataRecordInGroupBySlot((global::Infragistics.Windows.DataPresenter.DataRecord)this);
				}
				groupByRecord = (this.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord);
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.ParentCollection.ViewableRecords;
			if (viewableRecords != null)
			{
				viewableRecords.OnRecordRefreshSortPosition(this);
			}
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection2 = this.ParentCollection;
			if (parentCollection2 != parentCollection)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager.DirtySummaryResults(null, null, parentCollection, null);
				global::Infragistics.Windows.DataPresenter.RecordManager.DirtySummaryResults(null, null, parentCollection2, null);
			}
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x0004D438 File Offset: 0x0004B638
		public void ResetExpansionIndicatorVisibility()
		{
			if (this._explicitExpansionIndicatorVisibility != null)
			{
				global::System.Windows.Visibility value = this._explicitExpansionIndicatorVisibility.Value;
				this._explicitExpansionIndicatorVisibility = null;
				if (value != this.ExpansionIndicatorVisibility)
				{
					base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
				}
			}
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x0004D47E File Offset: 0x0004B67E
		internal void BumpCellLayoutVersion()
		{
			if (this._associatedRecordPresenter != null)
			{
				base.RaisePropertyChangedEvent("CellLayoutVersion");
			}
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x0004D494 File Offset: 0x0004B694
		internal double CalculateExtraOffsetInGroupBy(bool isHeader)
		{
			global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = this as global::Infragistics.Windows.DataPresenter.HeaderRecord;
			if (headerRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.Record recordForLayoutCalculations = this.RecordForLayoutCalculations;
				if (recordForLayoutCalculations != null && recordForLayoutCalculations != this)
				{
					return recordForLayoutCalculations.CalculateExtraOffsetInGroupBy(isHeader);
				}
				return 0.0;
			}
			else
			{
				if (!this._fieldLayout.HasGroupBySortFields)
				{
					return 0.0;
				}
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter == null)
				{
					return 0.0;
				}
				if (dataPresenter.IsReportControl)
				{
					global::Infragistics.Windows.DataPresenter.TabularReportView tabularReportView = dataPresenter.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.TabularReportView;
					if (tabularReportView == null)
					{
						return 0.0;
					}
					double levelIndentation = tabularReportView.LevelIndentation;
					return levelIndentation * (double)global::System.Math.Max(this._fieldLayout.SortedFields.CountOfGroupByFields - this.NestingDepthOfGroupByRcds, 0);
				}
				else
				{
					global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this.ParentRecord as global::Infragistics.Windows.DataPresenter.GroupByRecord;
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
					bool flag = false;
					if (groupByRecord == null && (this is global::Infragistics.Windows.DataPresenter.FilterRecord || this is global::Infragistics.Windows.DataPresenter.SummaryRecord || this is global::Infragistics.Windows.DataPresenter.GroupByRecord) && recordManager != null && recordManager.Groups.Count > 0)
					{
						groupByRecord = recordManager.Groups[0];
						flag = true;
					}
					if (groupByRecord == null)
					{
						return 0.0;
					}
					double recordOffset = this._fieldLayout.TemplateDataRecordCache.GetRecordOffset(groupByRecord, true);
					int num = this._fieldLayout.SortedFields.CountOfGroupByFields;
					if (recordManager.HasGroups && recordManager.Groups[0].RecordType == global::Infragistics.Windows.DataPresenter.RecordType.GroupByFieldLayout)
					{
						num++;
					}
					if (!flag)
					{
						num = global::System.Math.Max(0, num - this.NestingDepthOfGroupByRcds);
					}
					double num2 = (double)num * recordOffset;
					if (num > 0 && this._fieldLayout.GroupByExpansionIndicatorVisibilityResolved == global::System.Windows.Visibility.Collapsed)
					{
						num2 -= recordOffset;
					}
					num2 += (double)num * this._fieldLayout.TemplateDataRecordCache.GetNestedContentChrome(groupByRecord, true);
					if (recordManager.Sorted.Count > 0 && !isHeader)
					{
						global::Infragistics.Windows.DataPresenter.Record record = recordManager.Sorted[0];
						if (record.ExpansionIndicatorVisibility == global::System.Windows.Visibility.Collapsed)
						{
							if (this._fieldLayout.IsHorizontal)
							{
								num2 -= this._fieldLayout.ExpansionIndicatorSize.Height;
							}
							else
							{
								num2 -= this._fieldLayout.ExpansionIndicatorSize.Width;
							}
						}
					}
					return num2;
				}
			}
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0004D6B8 File Offset: 0x0004B8B8
		internal double CalculateFlatViewIndent()
		{
			global::Infragistics.Windows.DataPresenter.HeaderRecord headerRecord = this as global::Infragistics.Windows.DataPresenter.HeaderRecord;
			if (headerRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.Record recordForLayoutCalculations = this.RecordForLayoutCalculations;
				if (recordForLayoutCalculations == this || recordForLayoutCalculations == null)
				{
					return 0.0;
				}
				return recordForLayoutCalculations.CalculateFlatViewIndent();
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				if (parentRecord == null)
				{
					return 0.0;
				}
				double num = 0.0;
				num += parentRecord.FieldLayout.TemplateDataRecordCache.GetNestedContentChrome(parentRecord, true);
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = parentRecord.FieldLayout;
				if (parentRecord.ExpansionIndicatorVisibility != global::System.Windows.Visibility.Collapsed)
				{
					num += (fieldLayout.IsHorizontal ? fieldLayout.ExpansionIndicatorSize.Height : fieldLayout.ExpansionIndicatorSize.Width);
				}
				return num + parentRecord.CalculateFlatViewIndent();
			}
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0004D76C File Offset: 0x0004B96C
		internal double CalculateNestedRecordContentNearOffset()
		{
			global::Infragistics.Windows.DataPresenter.Record record = this.RecordForLayoutCalculations;
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record.DataPresenter;
			double num = 0.0;
			while (record != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
				double num2 = fieldLayout.TemplateDataRecordCache.GetRecordOffset(record, true);
				global::System.Windows.Size expansionIndicatorSize = fieldLayout.ExpansionIndicatorSize;
				double num3 = fieldLayout.IsHorizontal ? expansionIndicatorSize.Height : expansionIndicatorSize.Width;
				if (num2 >= num3 && record.ExpansionIndicatorVisibility == global::System.Windows.Visibility.Collapsed)
				{
					num2 -= num3;
				}
				if (dataPresenter != null && dataPresenter.IsFlatView)
				{
					return num2 + this.CalculateFlatViewIndent();
				}
				num += num2;
				global::Infragistics.Windows.DataPresenter.Record parentRecord = record.ParentRecord;
				if (parentRecord != null)
				{
					num += parentRecord.FieldLayout.TemplateDataRecordCache.GetNestedContentChrome(parentRecord, true);
				}
				record = parentRecord;
			}
			return num;
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0004D82C File Offset: 0x0004BA2C
		internal void ChangeVisibilityHelper(global::System.Windows.Visibility? newVisibility, global::Infragistics.Windows.DataPresenter.Record.FilterState? newFilterState)
		{
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = this.ParentCollection;
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = parentCollection.ViewableRecords;
			int oldIndex = -1;
			bool flag = viewableRecords == null || !viewableRecords.ShouldRaiseCollectionNotifications;
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			if (!flag && viewableRecords != null)
			{
				visibility = this.GetVisibilityResolved(false);
				if (visibility != global::System.Windows.Visibility.Collapsed)
				{
					oldIndex = viewableRecords.GetIndexOf(this, false);
				}
			}
			if (newVisibility != null)
			{
				this._visibility = newVisibility.Value;
			}
			if (newFilterState != null)
			{
				this._cachedFilterState = newFilterState.Value;
			}
			this.DirtyScrollCount();
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
			bool flag2 = false;
			if (fieldLayout != null && global::Infragistics.Windows.DataPresenter.CalculationScope.FilteredSortedList == fieldLayout.CalculationScopeResolved)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager.DirtySummaryResults(this, null, null, null);
				flag2 = true;
			}
			if (this._fieldLayout != null)
			{
				this._fieldLayout.AutoSizeInfo.OnRecordVisibilityChanged(this);
			}
			if (!flag && viewableRecords != null)
			{
				viewableRecords.OnRecordVisibilityChanged(this, visibility, oldIndex);
			}
			if (newVisibility != null)
			{
				base.RaisePropertyChangedEvent("Visibility");
			}
			base.RaisePropertyChangedEvent("VisibilityResolved");
			if (flag2)
			{
				global::Infragistics.Windows.DataPresenter.GridUtilities.NotifyCalcAdapter(this.DataPresenter, this, "Visibility", null);
			}
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0004D92E File Offset: 0x0004BB2E
		internal void ClearSizeToContentManager()
		{
			this.ClearSizeToContentManager(null);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0004D937 File Offset: 0x0004BB37
		internal void ClearSizeToContentManager(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (this._layoutManager != null)
			{
				this._layoutManager.InvalidateLayout();
				this.BumpCellLayoutVersion();
			}
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0004D954 File Offset: 0x0004BB54
		internal virtual void CloneAssociatedRecordSettings(global::Infragistics.Windows.DataPresenter.Record associatedRecord, global::Infragistics.Windows.DataPresenter.IExportOptions options)
		{
			this._description = associatedRecord._description;
			this._fixedLocation = associatedRecord._fixedLocation;
			this._separatorVisibility = associatedRecord._separatorVisibility;
			this._enabled = associatedRecord._enabled;
			this._tag = associatedRecord._tag;
			this._selected = associatedRecord._selected;
			if (options != null && !options.ExcludeExpandedState)
			{
				this._isExpanded = associatedRecord._isExpanded;
			}
			else
			{
				this._isExpanded = true;
			}
			if (options == null || !options.ExcludeRecordVisibility)
			{
				this.Visibility = associatedRecord._visibility;
			}
			if (options == null || !options.ExcludeRecordFilters)
			{
				this._cachedFilterState = associatedRecord._cachedFilterState;
			}
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase = options as global::Infragistics.Windows.DataPresenter.ReportViewBase;
			if (associatedRecord._layoutManager != null && reportViewBase != null && !reportViewBase.ExcludeRecordSizing)
			{
				global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager layoutManager = this.GetLayoutManager(true);
				global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase dataPresenterExportControlBase = this.DataPresenter as global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase;
				if (dataPresenterExportControlBase != null)
				{
					foreach (global::Infragistics.Controls.Layouts.Primitives.ILayoutItem layoutItem in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>)associatedRecord._layoutManager.LayoutItems))
					{
						global::Infragistics.Windows.DataPresenter.CellLayoutItem cellLayoutItem = layoutItem as global::Infragistics.Windows.DataPresenter.CellLayoutItem;
						if (cellLayoutItem != null)
						{
							global::Infragistics.Windows.DataPresenter.Field clonedField = dataPresenterExportControlBase.GetClonedField(cellLayoutItem.Field);
							global::Infragistics.Windows.DataPresenter.CellLayoutItem cellLayoutItem2 = layoutManager.GetLayoutItem(clonedField, cellLayoutItem.IsLabel) as global::Infragistics.Windows.DataPresenter.CellLayoutItem;
							if (cellLayoutItem2 != null)
							{
								cellLayoutItem2.InitializeFrom(cellLayoutItem);
							}
						}
					}
				}
			}
		}

		// Token: 0x06001200 RID: 4608
		internal abstract global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter();

		// Token: 0x06001201 RID: 4609 RVA: 0x0004DAB4 File Offset: 0x0004BCB4
		internal void DirtyFilterState()
		{
			this.DirtyFilterState(true);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0004DAC0 File Offset: 0x0004BCC0
		internal void DirtyFilterState(bool reevaluate)
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState && (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) == 0)
			{
				if ((byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended & this._cachedFilterState) == 0)
				{
					this._cachedFilterState |= global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
				}
				if (reevaluate)
				{
					this.InternalIsFilteredOutHelper(true);
				}
				if ((byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & this._cachedFilterState) != 0 && (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) != 0)
				{
					this.DirtyScrollCount();
				}
			}
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0004DB27 File Offset: 0x0004BD27
		internal void DirtyScrollCount()
		{
			if (this._parentCollection != null)
			{
				this._parentCollection.SparseArray.NotifyItemScrollCountChanged(this);
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0004DB42 File Offset: 0x0004BD42
		internal virtual void EnsureFiltersEvaluated()
		{
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0004DB44 File Offset: 0x0004BD44
		internal bool ExpandCollapse(bool expand, bool addToUndo)
		{
			if (expand)
			{
				this.LoadVirtualData();
			}
			if (this.IsExpanded == expand)
			{
				this._isExpanded = expand;
				return false;
			}
			global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
			return dataPresenter != null && dataPresenter.OnRecordExpandStateChanged(this, expand, addToUndo);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0004DB81 File Offset: 0x0004BD81
		internal void FireInitializeRecord()
		{
			this.FireInitializeRecord(false, false);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0004DB8C File Offset: 0x0004BD8C
		internal void FireInitializeRecord(bool reInitialize, bool sortValueChanged)
		{
			if (this is global::Infragistics.Windows.DataPresenter.HeaderRecord)
			{
				return;
			}
			this.DataPresenter.RaiseInitializeRecord(this, reInitialize, sortValueChanged);
			if (this is global::Infragistics.Windows.DataPresenter.DataRecord && !reInitialize && this.FieldLayout != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> fieldsWithDataValueChangedScopeSetToAllRecords = this.FieldLayout.Fields.FieldsWithDataValueChangedScopeSetToAllRecords;
				foreach (global::Infragistics.Windows.DataPresenter.Field field in fieldsWithDataValueChangedScopeSetToAllRecords)
				{
					((global::Infragistics.Windows.DataPresenter.DataRecord)this).Cells[field].AddDataValueChangedHistoryEntryForCurrentValue();
				}
			}
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0004DC24 File Offset: 0x0004BE24
		internal void FocusIfActive()
		{
			if (this.IsActive)
			{
				global::Infragistics.Windows.DataPresenter.RecordPresenter associatedRecordPresenter = this.AssociatedRecordPresenter;
				if (associatedRecordPresenter != null)
				{
					associatedRecordPresenter.FocusIfAppropriate();
				}
			}
		}

		// Token: 0x06001209 RID: 4617
		public abstract global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord();

		// Token: 0x0600120A RID: 4618 RVA: 0x0004DC4C File Offset: 0x0004BE4C
		internal global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager GetLayoutManager(bool createIfNull)
		{
			if (createIfNull && this._layoutManager == null)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._fieldLayout;
				if (fieldLayout != null)
				{
					this._layoutManager = fieldLayout.CellLayoutManager.Clone();
					this._layoutManager.Record = this;
				}
			}
			if (this._layoutManager != null)
			{
				this._layoutManager.VerifyLayout();
			}
			return this._layoutManager;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0004DCA4 File Offset: 0x0004BEA4
		internal global::Infragistics.Windows.DataPresenter.Record GetCrossParentSibling(bool next)
		{
			global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
			if (parentRecord == null)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection = parentRecord.ParentCollection;
			int num = parentRecord.Index;
			int num2 = next ? 1 : -1;
			global::Infragistics.Windows.DataPresenter.Record record = null;
			do
			{
				num += num2;
				global::Infragistics.Windows.DataPresenter.Record record2 = record;
				if (num >= 0 && num < parentCollection.Count)
				{
					record = parentCollection[num];
				}
				else
				{
					record = parentRecord.GetCrossParentSibling(next);
					if (record == null)
					{
						goto IL_87;
					}
				}
				if (record == record2)
				{
					goto IL_87;
				}
			}
			while (!record.HasChildren);
			global::Infragistics.Windows.DataPresenter.RecordCollectionBase childRecordsInternal = record.ChildRecordsInternal;
			if (next)
			{
				return childRecordsInternal[0];
			}
			return childRecordsInternal[childRecordsInternal.Count - 1];
			IL_87:
			return null;
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0004DD39 File Offset: 0x0004BF39
		internal int GetOverallScrollPosition(bool ignoreHiddenItemState, ref bool isRecordHidden)
		{
			return this.GetOverallScrollPosition(ignoreHiddenItemState, false, ref isRecordHidden);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0004DD44 File Offset: 0x0004BF44
		internal int GetOverallScrollPosition(bool ignoreHiddenItemState, bool getMinOfRecordAndFirstChild, ref bool isRecordHidden)
		{
			if (this._parentCollection == null)
			{
				return -1;
			}
			global::System.Windows.Visibility visibilityResolved = this.VisibilityResolved;
			if (!ignoreHiddenItemState && visibilityResolved == global::System.Windows.Visibility.Collapsed)
			{
				return -1;
			}
			global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this._parentCollection.ViewableRecords;
			if (viewableRecords == null)
			{
				return -1;
			}
			if (this.IsSpecialRecord)
			{
				global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
				if (recordManager == null)
				{
					return -1;
				}
				if ((recordManager.SortedInternal == this._parentCollection || recordManager.GroupsInternal == this._parentCollection) && this._parentCollection != recordManager.CurrentInternal)
				{
					return -1;
				}
			}
			int num = 0;
			global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
			if (parentRecord != null)
			{
				if (!parentRecord.IsExpanded || parentRecord.IsSpecialRecord)
				{
					if (!ignoreHiddenItemState)
					{
						return -1;
					}
					isRecordHidden = true;
				}
				num = parentRecord.GetOverallScrollPosition(ignoreHiddenItemState, true, ref isRecordHidden);
				if (isRecordHidden)
				{
					return num;
				}
				if (num < 0)
				{
					return -1;
				}
				if (parentRecord.OccupiesScrollPosition && this.AreChildrenAfterParent)
				{
					num++;
				}
			}
			isRecordHidden = (isRecordHidden || visibilityResolved == global::System.Windows.Visibility.Collapsed);
			int scopedScrollIndexOfRecord = viewableRecords.GetScopedScrollIndexOfRecord(this, ignoreHiddenItemState, getMinOfRecordAndFirstChild);
			if (scopedScrollIndexOfRecord < 0)
			{
				return -1;
			}
			return num + scopedScrollIndexOfRecord;
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0004DE38 File Offset: 0x0004C038
		internal global::Infragistics.Windows.DataPresenter.Record GetRecordInParentChainContainedInCollection(global::Infragistics.Windows.DataPresenter.RecordCollectionBase collection)
		{
			if (collection == this._parentCollection)
			{
				return this;
			}
			global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
			if (parentRecord != null)
			{
				return parentRecord.GetRecordInParentChainContainedInCollection(collection);
			}
			return null;
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0004DE63 File Offset: 0x0004C063
		internal global::System.Windows.Visibility GetVisibilityResolved(bool verifyFiltering)
		{
			if (this.InternalIsFilteredOutHelper(verifyFiltering) && (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & this._cachedFilterState) != 0)
			{
				return global::System.Windows.Visibility.Collapsed;
			}
			return this._visibility;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0004DE84 File Offset: 0x0004C084
		private void FilterStateChanged_RaiseNotificationsHelper(global::Infragistics.Windows.DataPresenter.Record.FilterState oldFilterState, global::Infragistics.Windows.DataPresenter.Record.FilterState newFilterState, bool raiseVisibilityResolvedNotification)
		{
			if (oldFilterState != newFilterState)
			{
				bool flag = (byte)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn) & oldFilterState) != (byte)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn) & newFilterState);
				bool flag2 = (byte)((global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction) & oldFilterState) != (byte)((global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction) & newFilterState);
				bool flag3 = (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & oldFilterState) != (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & newFilterState);
				if (raiseVisibilityResolvedNotification && (flag3 || flag2) && ((byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & oldFilterState) != 0 || (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & newFilterState) != 0))
				{
					this._cachedFilterState &= ~global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
					this.ChangeVisibilityHelper(null, new global::Infragistics.Windows.DataPresenter.Record.FilterState?(newFilterState));
				}
				this._cachedFilterState = newFilterState;
				if (flag)
				{
					base.RaisePropertyChangedEvent("IsFilteredOut");
				}
				if ((flag3 || flag2) && ((byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable & oldFilterState) != 0 || (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable & newFilterState) != 0))
				{
					base.RaisePropertyChangedEvent("IsEnabledResolved");
				}
				if (flag3)
				{
					if (this._fieldLayout != null)
					{
						this._fieldLayout.AutoSizeInfo.OnRecordVisibilityChanged(this);
					}
					global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
					global::Infragistics.Windows.DataPresenter.FilteredDataItemsCollection filteredDataItemsCollection = (recordManager != null) ? recordManager.FilteredInDataItemsIfAllocated : null;
					if (filteredDataItemsCollection != null && this.IsDataRecord)
					{
						filteredDataItemsCollection.OnRecordFilteredOutStateChanged((global::Infragistics.Windows.DataPresenter.DataRecord)this);
					}
				}
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0004DF84 File Offset: 0x0004C184
		internal void InternalSetFilterState(global::Infragistics.Windows.DataPresenter.Record.FilterState newState, bool raiseVisibilityResolvedNotification)
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != newState)
			{
				global::Infragistics.Windows.DataPresenter.RecordFilterAction filterActionResolved = this._fieldLayout.FilterActionResolved;
				global::Infragistics.Windows.DataPresenter.Record.FilterState filterState;
				if (global::Infragistics.Windows.DataPresenter.RecordFilterAction.Hide == filterActionResolved)
				{
					filterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide;
				}
				else if (global::Infragistics.Windows.DataPresenter.RecordFilterAction.Disable == filterActionResolved)
				{
					filterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable;
				}
				else if (global::Infragistics.Windows.DataPresenter.RecordFilterAction.None == filterActionResolved)
				{
					filterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction;
				}
				else
				{
					filterState = ~(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn | global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended);
				}
				newState |= filterState;
				if ((byte)(this._cachedFilterState & (global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction)) == 0)
				{
					this._cachedFilterState |= filterState;
				}
			}
			if (this._cachedFilterState != newState && global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState)
			{
				this.FilterStateChanged_RaiseNotificationsHelper(this._cachedFilterState, newState, raiseVisibilityResolvedNotification);
			}
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0004DFFF File Offset: 0x0004C1FF
		internal void InitializeAutomationPeer(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer peer)
		{
			this._automationPeer = new global::System.WeakReference(peer);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0004E00D File Offset: 0x0004C20D
		internal void InitializeParentCollection(global::Infragistics.Windows.DataPresenter.RecordCollectionBase parentCollection)
		{
			if (parentCollection == null)
			{
				throw new global::System.ArgumentNullException("parentCollection");
			}
			if (parentCollection != this._parentCollection)
			{
				this._parentCollection = parentCollection;
				base.RaisePropertyChangedEvent("ParentRecord");
			}
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0004E038 File Offset: 0x0004C238
		internal void InternalSelect(bool value)
		{
			if (this._selected != value)
			{
				this._selected = value;
				this.RaiseAutomationIsSelectedChanged();
				base.RaisePropertyChangedEvent("IsSelected");
			}
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0004E05B File Offset: 0x0004C25B
		internal bool InternalIsFilteredOutHelper(bool verify)
		{
			if (verify)
			{
				this.EnsureFiltersEvaluated();
			}
			return 0 != (byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & this._cachedFilterState);
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x0004E078 File Offset: 0x0004C278
		internal bool? InternalIsFilteredOutNullableHelper(bool verify)
		{
			if (verify)
			{
				this.EnsureFiltersEvaluated();
			}
			if ((byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & this._cachedFilterState) != 0)
			{
				return new bool?(true);
			}
			if ((byte)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn & this._cachedFilterState) != 0)
			{
				return new bool?(false);
			}
			return null;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0004E0BB File Offset: 0x0004C2BB
		internal void InvalidateExpansionIndicatorVisibility()
		{
			base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x0004E0C8 File Offset: 0x0004C2C8
		internal void InvalidateHasChildren()
		{
			base.RaisePropertyChangedEvent("HasChildren");
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0004E0D8 File Offset: 0x0004C2D8
		internal void InvalidatePeer()
		{
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(automationPeer);
			}
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0004E0F5 File Offset: 0x0004C2F5
		internal bool IsFixedLocationAllowed(global::Infragistics.Windows.DataPresenter.FixedRecordLocation location)
		{
			return true;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0004E0F8 File Offset: 0x0004C2F8
		internal bool IsSiblingOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return record != null && this._parentCollection == record._parentCollection;
		}

		// Token: 0x0600121C RID: 4636 RVA: 0x0004E110 File Offset: 0x0004C310
		internal bool IsTrivialAncestorOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this == record)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Record record2 = (record != null) ? record.ParentRecord : null;
			return record2 != null && this.IsTrivialAncestorOf(record2);
		}

		// Token: 0x0600121D RID: 4637 RVA: 0x0004E13C File Offset: 0x0004C33C
		internal void LoadVirtualData()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			if (groupByRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.GroupInfo groupInfo = groupByRecord.CommonValueInternal as global::Infragistics.Windows.DataPresenter.GroupInfo;
				if (groupInfo != null)
				{
					global::System.Windows.Data.CollectionViewGroup collectionViewGroup = groupInfo.Tag as global::System.Windows.Data.CollectionViewGroup;
					if (collectionViewGroup != null)
					{
						if (!collectionViewGroup.IsBottomLevel)
						{
							global::Infragistics.Windows.DataPresenter.VUtils.CreateGroupByRecordsSynchronizerHelper(groupByRecord.ChildRecords, collectionViewGroup.Items);
							return;
						}
						global::Infragistics.Windows.DataPresenter.VUtils.CreateDataRecordsSynchronizerHelper(groupByRecord.ChildRecords, collectionViewGroup.Items);
					}
				}
			}
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0004E1A3 File Offset: 0x0004C3A3
		internal void OnActiveCellChanged()
		{
			base.RaisePropertyChangedEvent("ActiveCell");
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0004E1B0 File Offset: 0x0004C3B0
		internal virtual void OnActiveRecordChanged()
		{
			base.RaisePropertyChangedEvent("IsActive");
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0004E1BD File Offset: 0x0004C3BD
		internal virtual void OnAssociatedRecordPresenterChanged()
		{
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x0004E1BF File Offset: 0x0004C3BF
		internal void OnCellSelectionChange()
		{
			base.RaisePropertyChangedEvent("CellSelection");
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x0004E1CC File Offset: 0x0004C3CC
		internal void OnViewableChildRecordsChanged()
		{
			base.RaisePropertyChangedEvent("ViewableChildRecords");
			if (this._automationPeer != null && this._automationPeer.IsAlive && this._automationPeer.Target != null)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this._automationPeer.Target as global::System.Windows.Automation.Peers.AutomationPeer;
				if (automationPeer != null)
				{
					if (automationPeer is global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer)
					{
						((global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer)automationPeer).ClearChildRecordsPeer();
					}
					automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
					automationPeer.InvalidatePeer();
					automationPeer.ResetChildrenCache();
				}
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0004E244 File Offset: 0x0004C444
		internal void RaiseAutomationIsSelectedChanged()
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				automationPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, !this._selected, this._selected);
			}
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0004E280 File Offset: 0x0004C480
		internal bool RaiseAutomationSelectedChange(global::System.Windows.Automation.Peers.AutomationEvents eventId)
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				automationPeer.RaiseAutomationEvent(eventId);
				return true;
			}
			return false;
		}

		// Token: 0x06001225 RID: 4645 RVA: 0x0004E2A1 File Offset: 0x0004C4A1
		internal void RaisePropertyChangedEventInternal(string propertyName)
		{
			base.RaisePropertyChangedEvent(propertyName);
		}

		// Token: 0x06001226 RID: 4646 RVA: 0x0004E2AA File Offset: 0x0004C4AA
		internal void ResumeFiltering(bool verify)
		{
			this._cachedFilterState |= global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
			this._cachedFilterState &= ~global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended;
			if (verify)
			{
				this.InternalIsFilteredOutHelper(verify);
			}
		}

		// Token: 0x06001227 RID: 4647 RVA: 0x0004E2D8 File Offset: 0x0004C4D8
		internal void SetIsExpanded(bool isExpanded, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> recordsChanged)
		{
			this._isExpanded = isExpanded;
			if (recordsChanged != null)
			{
				recordsChanged.Add(this);
			}
			if (isExpanded && this.ParentRecord != null && !this.ParentRecord._isExpanded)
			{
				this.ParentRecord.SetIsExpanded(isExpanded, recordsChanged);
			}
			else if (isExpanded && this._fieldLayout != null)
			{
				this._fieldLayout.AutoSizeInfo.OnRecordExpanded(this);
			}
			this.OnIsExpandedStateChanged();
		}

		// Token: 0x06001228 RID: 4648 RVA: 0x0004E33F File Offset: 0x0004C53F
		internal virtual bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return false;
		}

		// Token: 0x06001229 RID: 4649
		internal abstract void SortChildren();

		// Token: 0x0600122A RID: 4650 RVA: 0x0004E344 File Offset: 0x0004C544
		internal void SuspendActiveRecordFiltering()
		{
			if ((byte)(this._cachedFilterState & global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter) != 0)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter != null && dataPresenter.ActiveRecord == this)
				{
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this.FieldLayout;
					if (fieldLayout != null && fieldLayout.ReevaluateFiltersOnDataChangeResolved)
					{
						this._cachedFilterState ^= global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
						dataPresenter._activeRecordWithPendingDirtyFilterState = this;
					}
				}
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x0004E397 File Offset: 0x0004C597
		internal void SuspendFiltering()
		{
			this._cachedFilterState &= ~global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
			this._cachedFilterState |= global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended;
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0004E3BF File Offset: 0x0004C5BF
		internal virtual bool ToggleContainingCardCollapsedState(bool addToUndo)
		{
			return false;
		}

		// Token: 0x0600122D RID: 4653 RVA: 0x0004E3C2 File Offset: 0x0004C5C2
		internal virtual bool ToggleContainingCardEmptyCellsCollapsedState(bool addToUndo)
		{
			return false;
		}

		// Token: 0x0600122E RID: 4654 RVA: 0x0004E3C5 File Offset: 0x0004C5C5
		internal virtual void VerifySortOrderOfChildren()
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0004E3C8 File Offset: 0x0004C5C8
		private void CheckFixedAndExpandedStates()
		{
			if (this.IsExpanded && this.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter != null && dataPresenter.IsNestedDataDisplayEnabled && dataPresenter.CurrentViewInternal.SupportedDataDisplayMode != global::Infragistics.Windows.DataPresenter.DataDisplayMode.Flat && this.HasVisibleChildren)
				{
					global::Infragistics.Windows.DataPresenter.IViewPanelInfo viewPanelInfo = dataPresenter;
					if (this.ParentRecord == null && this.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop)
					{
						viewPanelInfo.OverallScrollPosition = 0;
						return;
					}
					global::Infragistics.Windows.DataPresenter.Record record;
					if (this.FixedLocation == global::Infragistics.Windows.DataPresenter.FixedRecordLocation.FixedToTop)
					{
						record = viewPanelInfo.GetRecordAtOverallScrollPosition(global::System.Math.Min(viewPanelInfo.OverallScrollCount - 1, this.OverallScrollPosition + 1));
					}
					else
					{
						record = this;
					}
					dataPresenter.BringRecordIntoView(record);
				}
			}
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0004E458 File Offset: 0x0004C658
		private global::System.Windows.Visibility GetExpansionIndicatorVisibilityBasedOnContent()
		{
			global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord = this as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
			if (expandableFieldRecord != null)
			{
				if (expandableFieldRecord.CheckHasChildData())
				{
					return global::System.Windows.Visibility.Visible;
				}
				return global::System.Windows.Visibility.Hidden;
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecordsIfNeeded = this.ViewableChildRecordsIfNeeded;
				int num = (viewableChildRecordsIfNeeded != null) ? viewableChildRecordsIfNeeded.Count : 0;
				if (num == 0)
				{
					return global::System.Windows.Visibility.Hidden;
				}
				if (num != 1)
				{
					return global::System.Windows.Visibility.Visible;
				}
				global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord expandableFieldRecord2 = viewableChildRecordsIfNeeded[0] as global::Infragistics.Windows.DataPresenter.ExpandableFieldRecord;
				if (expandableFieldRecord2 != null && !expandableFieldRecord2.CheckHasChildData())
				{
					return global::System.Windows.Visibility.Hidden;
				}
				return global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x06001231 RID: 4657 RVA: 0x0004E4B8 File Offset: 0x0004C6B8
		private void OnIsExpandedStateChanged()
		{
			this.DirtyScrollCount();
			if (this.IsExpanded)
			{
				this.VerifySortOrderOfChildren();
			}
			if (this.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecordsIfAllocated = this.ParentCollection.ViewableRecordsIfAllocated;
				if (viewableRecordsIfAllocated != null)
				{
					viewableRecordsIfAllocated.DirtySpecialRecords(false);
				}
			}
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				automationPeer.InvalidatePeer();
				automationPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, (!this.IsExpanded) ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed, this.IsExpanded ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed);
			}
			base.RaisePropertyChangedEvent("IsExpanded");
			this.CheckFixedAndExpandedStates();
		}

		// Token: 0x06001232 RID: 4658 RVA: 0x0004E545 File Offset: 0x0004C745
		private void OnParentCollectionVersionChanged()
		{
			base.RaisePropertyChangedEvent("Index");
			base.RaisePropertyChangedEvent("VisibleIndex");
		}

		// Token: 0x06001233 RID: 4659 RVA: 0x0004E560 File Offset: 0x0004C760
		object global::Infragistics.Collections.ISparseArrayMultiItem.GetItemAtScrollIndex(int scrollIndex)
		{
			bool occupiesScrollPosition = this.OccupiesScrollPosition;
			bool areChildrenAfterParent = this.AreChildrenAfterParent;
			if (scrollIndex == 0 && occupiesScrollPosition && areChildrenAfterParent)
			{
				return this;
			}
			if (occupiesScrollPosition && areChildrenAfterParent)
			{
				scrollIndex--;
			}
			if (this.IsExpanded && this.HasChildrenInternal)
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableChildRecords = this.ViewableChildRecords;
				int scrollCount = viewableChildRecords.ScrollCount;
				if (viewableChildRecords != null && scrollIndex < scrollCount)
				{
					return viewableChildRecords.GetRecordAtScrollPosition(scrollIndex);
				}
				scrollIndex -= scrollCount;
			}
			if (scrollIndex == 0 && occupiesScrollPosition && !areChildrenAfterParent)
			{
				return this;
			}
			return null;
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001234 RID: 4660 RVA: 0x0004E5CF File Offset: 0x0004C7CF
		int global::Infragistics.Collections.ISparseArrayMultiItem.ScrollCount
		{
			get
			{
				return this.ScrollCountInternal;
			}
		}

		// Token: 0x06001235 RID: 4661 RVA: 0x0004E5D7 File Offset: 0x0004C7D7
		object global::Infragistics.Collections.ISparseArrayItem.GetOwnerData(global::Infragistics.Collections.SparseArray context)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_6"));
		}

		// Token: 0x06001236 RID: 4662 RVA: 0x0004E5E8 File Offset: 0x0004C7E8
		void global::Infragistics.Collections.ISparseArrayItem.SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_7"));
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001237 RID: 4663 RVA: 0x0004E5F9 File Offset: 0x0004C7F9
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x06001238 RID: 4664 RVA: 0x0004E5FC File Offset: 0x0004C7FC
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelectable
		{
			get
			{
				return this.IsSelectable;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001239 RID: 4665 RVA: 0x0004E604 File Offset: 0x0004C804
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x0004E60C File Offset: 0x0004C80C
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsTabStop
		{
			get
			{
				return this.IsEnabledResolved;
			}
		}

		// Token: 0x040006E3 RID: 1763
		internal const global::Infragistics.Windows.DataPresenter.Record.FilterState FILTERED_IN_OUT_FLAGS = global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn;

		// Token: 0x040006E4 RID: 1764
		internal const global::Infragistics.Windows.DataPresenter.Record.FilterState FILTER_ACTION_FLAGS = global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction;

		// Token: 0x040006E5 RID: 1765
		internal const global::Infragistics.Windows.DataPresenter.Record.FilterState FILTER_IN_OUT_AND_ACTION_FLAGS = ~(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended);

		// Token: 0x040006E6 RID: 1766
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040006E7 RID: 1767
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _parentCollection;

		// Token: 0x040006E8 RID: 1768
		private string _description;

		// Token: 0x040006E9 RID: 1769
		private bool _isExpanded;

		// Token: 0x040006EA RID: 1770
		private bool _isFixedLastReturned;

		// Token: 0x040006EB RID: 1771
		private bool _enabled = true;

		// Token: 0x040006EC RID: 1772
		private bool _selected;

		// Token: 0x040006ED RID: 1773
		private global::System.WeakReference _associatedRecordPresenter;

		// Token: 0x040006EE RID: 1774
		private global::System.Windows.Visibility _expansionIndicatorVisibilityLastReturned = global::System.Windows.Visibility.Collapsed;

		// Token: 0x040006EF RID: 1775
		private global::System.Windows.Visibility _visibility;

		// Token: 0x040006F0 RID: 1776
		private global::System.Windows.Visibility? _explicitExpansionIndicatorVisibility;

		// Token: 0x040006F1 RID: 1777
		internal object _sparseArrayOwnerData_Sorted;

		// Token: 0x040006F2 RID: 1778
		internal object _sparseArrayOwnerData_Unsorted;

		// Token: 0x040006F3 RID: 1779
		internal object _sparseArrayOwnerData_Grouped;

		// Token: 0x040006F4 RID: 1780
		private int _index = -1;

		// Token: 0x040006F5 RID: 1781
		private object _tag;

		// Token: 0x040006F6 RID: 1782
		private global::System.WeakReference _automationPeer;

		// Token: 0x040006F7 RID: 1783
		private global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal _fixedRecordLocationOverride;

		// Token: 0x040006F8 RID: 1784
		private global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility _separatorVisibility;

		// Token: 0x040006F9 RID: 1785
		internal global::Infragistics.Windows.DataPresenter.FixedRecordLocation _fixedLocation;

		// Token: 0x040006FA RID: 1786
		internal global::Infragistics.Windows.DataPresenter.Record.FilterState _cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;

		// Token: 0x040006FB RID: 1787
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _layoutManager;

		// Token: 0x040006FC RID: 1788
		private bool? _isContainingCardCollapsed;

		// Token: 0x040006FD RID: 1789
		private bool? _shouldCollapseEmptyCells;

		// Token: 0x040006FE RID: 1790
		private global::Infragistics.Windows.Internal.PropertyValueTracker _parentCollectionVersionTracker;

		// Token: 0x02000148 RID: 328
		[global::System.Flags]
		internal enum FilterState : byte
		{
			// Token: 0x04000700 RID: 1792
			NeedsToRefilter = 1,
			// Token: 0x04000701 RID: 1793
			FilteredOut = 2,
			// Token: 0x04000702 RID: 1794
			FilteredIn = 4,
			// Token: 0x04000703 RID: 1795
			NeverFilter = 8,
			// Token: 0x04000704 RID: 1796
			Hide = 16,
			// Token: 0x04000705 RID: 1797
			Disable = 32,
			// Token: 0x04000706 RID: 1798
			NoAction = 64,
			// Token: 0x04000707 RID: 1799
			FilterSuspended = 128
		}
	}
}
