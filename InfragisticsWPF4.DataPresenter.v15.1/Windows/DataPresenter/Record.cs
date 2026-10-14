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
	// Token: 0x02000163 RID: 355
	public abstract class Record : global::Infragistics.PropertyChangeNotifier, global::Infragistics.Collections.ISparseArrayMultiItem, global::Infragistics.Collections.ISparseArrayItem, global::Infragistics.Windows.Selection.ISelectableItem
	{
		// Token: 0x06001503 RID: 5379 RVA: 0x0005DAE4 File Offset: 0x0005BCE4
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

		// Token: 0x06001504 RID: 5380 RVA: 0x0005DB58 File Offset: 0x0005BD58
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

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0005DBAF File Offset: 0x0005BDAF
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._parentCollection.ParentRecordManager.DataPresenter;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0005DBC1 File Offset: 0x0005BDC1
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x0005DBE5 File Offset: 0x0005BDE5
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

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x0005DC08 File Offset: 0x0005BE08
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x0005DE83 File Offset: 0x0005C083
		public global::System.Windows.Visibility ExpansionIndicatorVisibility
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this.DataPresenter;
				if (dataPresenter is global::Infragistics.Windows.DataPresenter.DataPresenterReportControl && !dataPresenter.IsTreeView)
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
						if (flag2 && (!dataPresenter.IsNestedDataDisplayEnabled || this.FieldLayout.Fields.NotCollapsedExpandableFieldsCount == 0))
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
				if (visibility == global::System.Windows.Visibility.Collapsed && dataPresenter.IsTreeView && this is global::Infragistics.Windows.DataPresenter.DataRecord)
				{
					visibility = new global::System.Windows.Visibility?(global::System.Windows.Visibility.Hidden);
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

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0005DEB7 File Offset: 0x0005C0B7
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x0005DEBF File Offset: 0x0005C0BF
		// (set) Token: 0x0600150C RID: 5388 RVA: 0x0005DEC8 File Offset: 0x0005C0C8
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

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600150D RID: 5389 RVA: 0x0005DF53 File Offset: 0x0005C153
		public virtual bool HasChildren
		{
			get
			{
				return this.HasChildrenInternal;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0005DF5C File Offset: 0x0005C15C
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

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0005DFF6 File Offset: 0x0005C1F6
		// (set) Token: 0x06001510 RID: 5392 RVA: 0x0005E006 File Offset: 0x0005C206
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

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0005E02F File Offset: 0x0005C22F
		// (set) Token: 0x06001512 RID: 5394 RVA: 0x0005E038 File Offset: 0x0005C238
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

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0005E094 File Offset: 0x0005C294
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

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0005E0F8 File Offset: 0x0005C2F8
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0005E100 File Offset: 0x0005C300
		[global::System.Obsolete("Use IsEnabled property instead", false)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
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

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0005E109 File Offset: 0x0005C309
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x0005E111 File Offset: 0x0005C311
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

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0005E144 File Offset: 0x0005C344
		public bool IsEnabledResolved
		{
			get
			{
				return this._enabled && ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable & this._cachedFilterState) == 0 || (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & this._cachedFilterState) == 0);
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0005E16A File Offset: 0x0005C36A
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x0005E17C File Offset: 0x0005C37C
		public virtual bool IsExpanded
		{
			get
			{
				return this._isExpanded && this.CanExpand;
			}
			set
			{
				this.ExpandCollapse(value, false, false);
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0005E188 File Offset: 0x0005C388
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x0005E240 File Offset: 0x0005C440
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x0005E2AA File Offset: 0x0005C4AA
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x0005E2B4 File Offset: 0x0005C4B4
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x0005E328 File Offset: 0x0005C528
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

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06001520 RID: 5408 RVA: 0x0005E34F File Offset: 0x0005C54F
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.DataRecord ParentDataRecord
		{
			get
			{
				return this._parentCollection.ParentDataRecord;
			}
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x0005E35C File Offset: 0x0005C55C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.DataPresenter.Record ParentRecord
		{
			get
			{
				return this._parentCollection.ParentRecord;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0005E369 File Offset: 0x0005C569
		public global::Infragistics.Windows.DataPresenter.RecordCollectionBase ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06001523 RID: 5411
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract global::Infragistics.Windows.DataPresenter.RecordType RecordType { get; }

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x0005E371 File Offset: 0x0005C571
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x0005E37C File Offset: 0x0005C57C
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

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0005E3DD File Offset: 0x0005C5DD
		public virtual bool ShouldCollapseEmptyCellsResolved
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x0005E3E0 File Offset: 0x0005C5E0
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x0005E3E8 File Offset: 0x0005C5E8
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

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x0005E408 File Offset: 0x0005C608
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

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x0005E43C File Offset: 0x0005C63C
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

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x0005E45C File Offset: 0x0005C65C
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

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0005E47B File Offset: 0x0005C67B
		// (set) Token: 0x0600152D RID: 5421 RVA: 0x0005E484 File Offset: 0x0005C684
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

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0005E4AF File Offset: 0x0005C6AF
		public virtual global::System.Windows.Visibility VisibilityResolved
		{
			get
			{
				return this.GetVisibilityResolved(true);
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x0005E4B8 File Offset: 0x0005C6B8
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

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06001530 RID: 5424 RVA: 0x0005E4E8 File Offset: 0x0005C6E8
		internal bool AreChildrenAfterParent
		{
			get
			{
				return this.FieldLayout.ChildRecordsDisplayOrderResolved == global::Infragistics.Windows.DataPresenter.ChildRecordsDisplayOrder.AfterParent;
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x0005E4F8 File Offset: 0x0005C6F8
		internal virtual global::Infragistics.Windows.DataPresenter.Field AssociatedField
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x0005E4FC File Offset: 0x0005C6FC
		// (set) Token: 0x06001533 RID: 5427 RVA: 0x0005E540 File Offset: 0x0005C740
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

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06001534 RID: 5428 RVA: 0x0005E592 File Offset: 0x0005C792
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

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0005E5AE File Offset: 0x0005C7AE
		internal virtual bool CanDelete
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x0005E5B4 File Offset: 0x0005C7B4
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

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x0005E5F7 File Offset: 0x0005C7F7
		internal virtual bool CanFixedStatusBeChanged
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001538 RID: 5432 RVA: 0x0005E5FA File Offset: 0x0005C7FA
		internal virtual global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsIfNeeded
		{
			get
			{
				return this.ChildRecordsInternal;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001539 RID: 5433
		internal abstract global::Infragistics.Windows.DataPresenter.RecordCollectionBase ChildRecordsInternal { get; }

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x0600153A RID: 5434 RVA: 0x0005E602 File Offset: 0x0005C802
		internal double FarOffset
		{
			get
			{
				return this._fieldLayout.TemplateDataRecordCache.GetRecordOffset(this, false);
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x0005E616 File Offset: 0x0005C816
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x0005E61E File Offset: 0x0005C81E
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

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600153D RID: 5437
		internal abstract bool HasChildrenInternal { get; }

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0005E628 File Offset: 0x0005C828
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

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0005E654 File Offset: 0x0005C854
		internal virtual bool HasChildData
		{
			get
			{
				return this.HasVisibleChildren;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x0005E65C File Offset: 0x0005C85C
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

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0005E687 File Offset: 0x0005C887
		internal bool HasFilterCriteriaBeenApplied
		{
			get
			{
				return 0 != (short)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn) & this._cachedFilterState);
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001542 RID: 5442 RVA: 0x0005E698 File Offset: 0x0005C898
		internal bool IsAncestorChainExpanded
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord;
				return parentRecord == null || (parentRecord.IsExpanded && parentRecord.IsAncestorChainExpanded);
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0005E6C1 File Offset: 0x0005C8C1
		internal bool InternalIsFilteredOut_NoVerify
		{
			get
			{
				return this.InternalIsFilteredOutHelper(false);
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0005E6CA File Offset: 0x0005C8CA
		internal bool InternalIsFilteredOut_Verify
		{
			get
			{
				return this.InternalIsFilteredOutHelper(true);
			}
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x0005E6D3 File Offset: 0x0005C8D3
		internal bool? InternalIsFilteredOutNullable_NoVerify
		{
			get
			{
				return this.InternalIsFilteredOutNullableHelper(false);
			}
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x0005E6DC File Offset: 0x0005C8DC
		internal bool? InternalIsFilteredOutNullable_Verify
		{
			get
			{
				return this.InternalIsFilteredOutNullableHelper(true);
			}
		}

		// Token: 0x17000570 RID: 1392
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x0005E6E5 File Offset: 0x0005C8E5
		protected internal virtual bool IsActivatable
		{
			get
			{
				return this.IsEnabledResolved && this.VisibilityResolved == global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x17000571 RID: 1393
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0005E6FA File Offset: 0x0005C8FA
		public virtual bool IsDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000572 RID: 1394
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x0005E700 File Offset: 0x0005C900
		internal bool IsFirstVisibleSibling
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.RecordManager.ViewableRecords;
				if (viewableRecords == null)
				{
					return false;
				}
				int num = viewableRecords.IndexOf(this);
				return num == viewableRecords.CountOfSpecialRecordsOnTop;
			}
		}

		// Token: 0x17000573 RID: 1395
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0005E72F File Offset: 0x0005C92F
		internal virtual bool IsIndexValid
		{
			get
			{
				return this.IsSpecialRecord || this.Index >= 0;
			}
		}

		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x0005E748 File Offset: 0x0005C948
		internal bool IsLastVisibleSibling
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.ViewableRecordCollection viewableRecords = this.RecordManager.ViewableRecords;
				if (viewableRecords == null)
				{
					return false;
				}
				int num = viewableRecords.IndexOf(this);
				return num + 1 >= viewableRecords.CountOfNonSpecialRecords + viewableRecords.CountOfSpecialRecordsOnTop;
			}
		}

		// Token: 0x17000575 RID: 1397
		// (get) Token: 0x0600154C RID: 5452 RVA: 0x0005E784 File Offset: 0x0005C984
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

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x0005E814 File Offset: 0x0005CA14
		protected internal virtual bool IsSelectable
		{
			get
			{
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyDefault = this.SelectionStrategyDefault;
				return selectionStrategyDefault != null && !(selectionStrategyDefault is global::Infragistics.Windows.Selection.SelectionStrategyNone) && this.IsEnabledResolved;
			}
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x0600154E RID: 5454 RVA: 0x0005E840 File Offset: 0x0005CA40
		public virtual bool IsSpecialRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x0005E844 File Offset: 0x0005CA44
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

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x06001550 RID: 5456 RVA: 0x0005E892 File Offset: 0x0005CA92
		internal virtual bool IsTemplateDataRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0005E895 File Offset: 0x0005CA95
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x0005E8C2 File Offset: 0x0005CAC2
		internal double LastLayoutExtent
		{
			get
			{
				if (this._fieldLayout == null || this._fieldLayout.LayoutItemVersion != this._lastLayoutExtentVersion)
				{
					return 0.0;
				}
				return this._lastLayoutExtent;
			}
			set
			{
				if (this._fieldLayout != null)
				{
					this._lastLayoutExtentVersion = this._fieldLayout.LayoutItemVersion;
				}
				this._lastLayoutExtent = value;
			}
		}

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x0005E8E4 File Offset: 0x0005CAE4
		internal global::System.Windows.FrameworkElement NestedContent
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06001554 RID: 5460 RVA: 0x0005E8E8 File Offset: 0x0005CAE8
		internal virtual int NestingDepthOfDataRcds
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.DataRecord parentDataRecord = this.ParentDataRecord;
				if (parentDataRecord != null)
				{
					return parentDataRecord.NestingDepthOfDataRcds + 1;
				}
				return 0;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x0005E90C File Offset: 0x0005CB0C
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001556 RID: 5462 RVA: 0x0005E932 File Offset: 0x0005CB32
		internal virtual bool OccupiesScrollPosition
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0005E938 File Offset: 0x0005CB38
		internal int OverallScrollPosition
		{
			get
			{
				bool flag = false;
				return this.GetOverallScrollPosition(false, ref flag);
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06001558 RID: 5464 RVA: 0x0005E950 File Offset: 0x0005CB50
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x0005E990 File Offset: 0x0005CB90
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

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x0600155A RID: 5466 RVA: 0x0005E9DF File Offset: 0x0005CBDF
		internal virtual global::Infragistics.Windows.DataPresenter.Record RecordForLayoutCalculations
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x0005E9E4 File Offset: 0x0005CBE4
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

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x0600155C RID: 5468 RVA: 0x0005EA04 File Offset: 0x0005CC04
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x0005EA23 File Offset: 0x0005CC23
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

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600155E RID: 5470 RVA: 0x0005EA48 File Offset: 0x0005CC48
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

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x0005EA9C File Offset: 0x0005CC9C
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x0005EAA4 File Offset: 0x0005CCA4
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

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x0005EAC4 File Offset: 0x0005CCC4
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06001562 RID: 5474 RVA: 0x0005EAE8 File Offset: 0x0005CCE8
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x0005EB34 File Offset: 0x0005CD34
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001564 RID: 5476 RVA: 0x0005EB54 File Offset: 0x0005CD54
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x0005EB73 File Offset: 0x0005CD73
		internal global::System.Windows.Visibility VisibilityResolved_NoFiltering
		{
			get
			{
				return this._visibility;
			}
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0005EB7C File Offset: 0x0005CD7C
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

		// Token: 0x06001567 RID: 5479 RVA: 0x0005EBA4 File Offset: 0x0005CDA4
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

		// Token: 0x06001568 RID: 5480 RVA: 0x0005EC64 File Offset: 0x0005CE64
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

		// Token: 0x06001569 RID: 5481 RVA: 0x0005ECAA File Offset: 0x0005CEAA
		internal void BumpCellLayoutVersion()
		{
			if (this._associatedRecordPresenter != null)
			{
				base.RaisePropertyChangedEvent("CellLayoutVersion");
			}
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x0005ECC0 File Offset: 0x0005CEC0
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

		// Token: 0x0600156B RID: 5483 RVA: 0x0005EEE4 File Offset: 0x0005D0E4
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

		// Token: 0x0600156C RID: 5484 RVA: 0x0005EF98 File Offset: 0x0005D198
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

		// Token: 0x0600156D RID: 5485 RVA: 0x0005F058 File Offset: 0x0005D258
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

		// Token: 0x0600156E RID: 5486 RVA: 0x0005F15A File Offset: 0x0005D35A
		internal void ClearSizeToContentManager()
		{
			this.ClearSizeToContentManager(null);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x0005F163 File Offset: 0x0005D363
		internal void ClearSizeToContentManager(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			if (this._layoutManager != null)
			{
				this._layoutManager.InvalidateLayout();
				this.BumpCellLayoutVersion();
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x0005F180 File Offset: 0x0005D380
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
				if (!associatedRecord._expandedToRevealFilteredInDescendants)
				{
					this._isExpanded = associatedRecord._isExpanded;
				}
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

		// Token: 0x06001571 RID: 5489
		internal abstract global::Infragistics.Windows.DataPresenter.RecordPresenter CreateRecordPresenter();

		// Token: 0x06001572 RID: 5490 RVA: 0x0005F2E8 File Offset: 0x0005D4E8
		internal void DirtyFilterState()
		{
			this.DirtyFilterState(true);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0005F2F4 File Offset: 0x0005D4F4
		internal void DirtyFilterState(bool reevaluate)
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState && (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) == 0)
			{
				if ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended & this._cachedFilterState) == 0)
				{
					this._cachedFilterState |= global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
				}
				if (reevaluate)
				{
					this.InternalIsFilteredOutHelper(true);
				}
				if ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & this._cachedFilterState) != 0 && (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter & this._cachedFilterState) != 0)
				{
					this.DirtyScrollCount();
				}
			}
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x0005F35B File Offset: 0x0005D55B
		internal void DirtyScrollCount()
		{
			if (this._parentCollection != null)
			{
				this._parentCollection.SparseArray.NotifyItemScrollCountChanged(this);
			}
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x0005F378 File Offset: 0x0005D578
		internal void EnsureAncestorsAreExpanded()
		{
			if (this.IsAncestorChainExpanded)
			{
				return;
			}
			for (global::Infragistics.Windows.DataPresenter.Record parentRecord = this.ParentRecord; parentRecord != null; parentRecord = parentRecord.ParentRecord)
			{
				if (!parentRecord._isExpanded)
				{
					parentRecord.IsExpanded = true;
				}
			}
		}

		// Token: 0x06001576 RID: 5494 RVA: 0x0005F3B0 File Offset: 0x0005D5B0
		internal virtual void EnsureFiltersEvaluated()
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x0005F3B4 File Offset: 0x0005D5B4
		internal bool ExpandCollapse(bool expand, bool addToUndo, bool calledFromTreeFiltering = false)
		{
			if (calledFromTreeFiltering)
			{
				if (this.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.ExpandableFieldRecord)
				{
					return false;
				}
				if (expand)
				{
					if (!this.IsExpanded)
					{
						this._expandedToRevealFilteredInDescendants = true;
					}
				}
				else
				{
					if (!this._expandedToRevealFilteredInDescendants)
					{
						return false;
					}
					this._expandedToRevealFilteredInDescendants = false;
				}
			}
			else
			{
				this._expandedToRevealFilteredInDescendants = false;
			}
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

		// Token: 0x06001578 RID: 5496 RVA: 0x0005F42D File Offset: 0x0005D62D
		internal void FireInitializeRecord()
		{
			this.FireInitializeRecord(false, false);
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x0005F438 File Offset: 0x0005D638
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

		// Token: 0x0600157A RID: 5498 RVA: 0x0005F4D0 File Offset: 0x0005D6D0
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

		// Token: 0x0600157B RID: 5499
		public abstract global::Infragistics.Windows.DataPresenter.Record GetAssociatedRecord();

		// Token: 0x0600157C RID: 5500 RVA: 0x0005F4F8 File Offset: 0x0005D6F8
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

		// Token: 0x0600157D RID: 5501 RVA: 0x0005F550 File Offset: 0x0005D750
		internal int GetOverallScrollPosition(bool ignoreHiddenItemState, ref bool isRecordHidden)
		{
			return this.GetOverallScrollPosition(ignoreHiddenItemState, false, ref isRecordHidden);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0005F55C File Offset: 0x0005D75C
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

		// Token: 0x0600157F RID: 5503 RVA: 0x0005F650 File Offset: 0x0005D850
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

		// Token: 0x06001580 RID: 5504 RVA: 0x0005F67B File Offset: 0x0005D87B
		internal global::System.Windows.Visibility GetVisibilityResolved(bool verifyFiltering)
		{
			if (!this.InternalIsFilteredOutHelper(verifyFiltering) || (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & this._cachedFilterState) == 0)
			{
				return this._visibility;
			}
			if (!this._isVisibleWhenFilteredOut)
			{
				return global::System.Windows.Visibility.Collapsed;
			}
			return global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06001581 RID: 5505 RVA: 0x0005F6A4 File Offset: 0x0005D8A4
		private void FilterStateChanged_RaiseNotificationsHelper(global::Infragistics.Windows.DataPresenter.Record.FilterState oldFilterState, global::Infragistics.Windows.DataPresenter.Record.FilterState newFilterState, bool raiseVisibilityResolvedNotification)
		{
			if (oldFilterState != newFilterState)
			{
				bool flag = (short)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn) & oldFilterState) != (short)((global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn) & newFilterState);
				bool flag2 = (short)((global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity) & oldFilterState) != (short)((global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity) & newFilterState);
				bool flag3 = (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & oldFilterState) != (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & newFilterState);
				if (raiseVisibilityResolvedNotification && (flag3 || flag2) && ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & oldFilterState) != 0 || (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide & newFilterState) != 0))
				{
					this._cachedFilterState &= ~global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
					this.ChangeVisibilityHelper(null, new global::Infragistics.Windows.DataPresenter.Record.FilterState?(newFilterState));
				}
				this._cachedFilterState = newFilterState;
				if (flag)
				{
					base.RaisePropertyChangedEvent("IsFilteredOut");
				}
				if ((flag3 || flag2) && ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable & oldFilterState) != 0 || (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable & newFilterState) != 0))
				{
					base.RaisePropertyChangedEvent("IsEnabledResolved");
				}
				if (flag2)
				{
					base.RaisePropertyChangedEvent("FilterAction");
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

		// Token: 0x06001582 RID: 5506 RVA: 0x0005F7B4 File Offset: 0x0005D9B4
		internal void InternalSetFilterState(global::Infragistics.Windows.DataPresenter.Record.FilterState newState, bool raiseVisibilityResolvedNotification)
		{
			if (global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != newState)
			{
				global::Infragistics.Windows.DataPresenter.Record.FilterState filterState;
				switch (this._fieldLayout.FilterActionResolved)
				{
				case global::Infragistics.Windows.DataPresenter.RecordFilterAction.Hide:
					filterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide;
					break;
				case global::Infragistics.Windows.DataPresenter.RecordFilterAction.Disable:
					filterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable;
					break;
				case global::Infragistics.Windows.DataPresenter.RecordFilterAction.ReduceOpacity:
					filterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity;
					break;
				case global::Infragistics.Windows.DataPresenter.RecordFilterAction.DoNothing:
					filterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction;
					break;
				default:
					filterState = (global::Infragistics.Windows.DataPresenter.Record.FilterState)0;
					break;
				}
				newState |= filterState;
				if ((short)(this._cachedFilterState & (global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity)) == 0)
				{
					this._cachedFilterState |= filterState;
				}
			}
			if (this._cachedFilterState != newState && global::Infragistics.Windows.DataPresenter.Record.FilterState.NeverFilter != this._cachedFilterState)
			{
				this.FilterStateChanged_RaiseNotificationsHelper(this._cachedFilterState, newState, raiseVisibilityResolvedNotification);
			}
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x0005F84A File Offset: 0x0005DA4A
		internal void InitializeAutomationPeer(global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer peer)
		{
			this._automationPeer = new global::System.WeakReference(peer);
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0005F858 File Offset: 0x0005DA58
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

		// Token: 0x06001585 RID: 5509 RVA: 0x0005F883 File Offset: 0x0005DA83
		internal void InternalSelect(bool value)
		{
			if (this._selected != value)
			{
				this._selected = value;
				this.RaiseAutomationIsSelectedChanged();
				base.RaisePropertyChangedEvent("IsSelected");
			}
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x0005F8A6 File Offset: 0x0005DAA6
		internal bool InternalIsFilteredOutHelper(bool verify)
		{
			if (verify)
			{
				this.EnsureFiltersEvaluated();
			}
			return 0 != (short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & this._cachedFilterState);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x0005F8C0 File Offset: 0x0005DAC0
		internal bool? InternalIsFilteredOutNullableHelper(bool verify)
		{
			if (verify)
			{
				this.EnsureFiltersEvaluated();
			}
			if ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut & this._cachedFilterState) != 0)
			{
				return new bool?(true);
			}
			if ((short)(global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn & this._cachedFilterState) != 0)
			{
				return new bool?(false);
			}
			return null;
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x0005F903 File Offset: 0x0005DB03
		internal void InvalidateExpansionIndicatorVisibility()
		{
			base.RaisePropertyChangedEvent("ExpansionIndicatorVisibility");
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0005F910 File Offset: 0x0005DB10
		internal void InvalidateHasChildren()
		{
			base.RaisePropertyChangedEvent("HasChildren");
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x0005F920 File Offset: 0x0005DB20
		internal void InvalidatePeer()
		{
			global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordAutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				global::Infragistics.AutomationPeers.AutomationPeerHelper.InvalidateChildren(automationPeer);
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x0005F93D File Offset: 0x0005DB3D
		internal bool IsFixedLocationAllowed(global::Infragistics.Windows.DataPresenter.FixedRecordLocation location)
		{
			return true;
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0005F940 File Offset: 0x0005DB40
		internal bool IsSiblingOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			return record != null && this._parentCollection == record._parentCollection;
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x0005F958 File Offset: 0x0005DB58
		internal bool IsTrivialAncestorOf(global::Infragistics.Windows.DataPresenter.Record record)
		{
			if (this == record)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.Record record2 = (record != null) ? record.ParentRecord : null;
			return record2 != null && this.IsTrivialAncestorOf(record2);
		}

		// Token: 0x0600158E RID: 5518 RVA: 0x0005F984 File Offset: 0x0005DB84
		internal void LoadVirtualData()
		{
			global::Infragistics.Windows.DataPresenter.RecordManager recordManager = this.RecordManager;
			global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord = this as global::Infragistics.Windows.DataPresenter.GroupByRecord;
			if (recordManager != null && groupByRecord != null)
			{
				global::Infragistics.Windows.DataPresenter.GroupInfo groupInfo = groupByRecord.CommonValueInternal as global::Infragistics.Windows.DataPresenter.GroupInfo;
				if (groupInfo != null)
				{
					global::System.Windows.Data.CollectionViewGroup collectionViewGroup = (groupInfo is global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo) ? ((global::Infragistics.Windows.DataPresenter.CollectionViewGroupInfo)groupInfo).CollectionViewGroup : null;
					if (collectionViewGroup != null)
					{
						if (!collectionViewGroup.IsBottomLevel)
						{
							global::Infragistics.Windows.DataPresenter.VUtils.CreateGroupByRecordsSynchronizerHelper(recordManager._sortedFieldsToCollectionViewSynchronizer, groupByRecord.ChildRecords, collectionViewGroup.Items);
							return;
						}
						global::Infragistics.Windows.DataPresenter.VUtils.CreateDataRecordsSynchronizerHelper(groupByRecord.ChildRecords, collectionViewGroup.Items);
					}
				}
			}
		}

		// Token: 0x0600158F RID: 5519 RVA: 0x0005F9FF File Offset: 0x0005DBFF
		internal void OnActiveCellChanged()
		{
			base.RaisePropertyChangedEvent("ActiveCell");
		}

		// Token: 0x06001590 RID: 5520 RVA: 0x0005FA0C File Offset: 0x0005DC0C
		internal virtual void OnActiveRecordChanged()
		{
			base.RaisePropertyChangedEvent("IsActive");
		}

		// Token: 0x06001591 RID: 5521 RVA: 0x0005FA19 File Offset: 0x0005DC19
		internal virtual void OnAssociatedRecordPresenterChanged()
		{
		}

		// Token: 0x06001592 RID: 5522 RVA: 0x0005FA1B File Offset: 0x0005DC1B
		internal void OnCellSelectionChange()
		{
			base.RaisePropertyChangedEvent("CellSelection");
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x0005FA28 File Offset: 0x0005DC28
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

		// Token: 0x06001594 RID: 5524 RVA: 0x0005FAA0 File Offset: 0x0005DCA0
		internal void RaiseAutomationIsSelectedChanged()
		{
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = this.AutomationPeer;
			if (automationPeer != null)
			{
				automationPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, !this._selected, this._selected);
			}
		}

		// Token: 0x06001595 RID: 5525 RVA: 0x0005FADC File Offset: 0x0005DCDC
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

		// Token: 0x06001596 RID: 5526 RVA: 0x0005FAFD File Offset: 0x0005DCFD
		internal void RaisePropertyChangedEventInternal(string propertyName)
		{
			base.RaisePropertyChangedEvent(propertyName);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x0005FB06 File Offset: 0x0005DD06
		internal void ResumeFiltering(bool verify)
		{
			this._cachedFilterState |= global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
			this._cachedFilterState &= ~global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended;
			if (verify)
			{
				this.InternalIsFilteredOutHelper(verify);
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x0005FB38 File Offset: 0x0005DD38
		internal void SetIsExpanded(bool isExpanded, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> recordsChanged)
		{
			this._isExpanded = isExpanded;
			if (recordsChanged != null)
			{
				recordsChanged.Add(this);
			}
			if (isExpanded && this.ParentRecord != null && !this.ParentRecord._isExpanded)
			{
				if (!this._expandedToRevealFilteredInDescendants)
				{
					this.ParentRecord.SetIsExpanded(isExpanded, recordsChanged);
				}
			}
			else if (isExpanded && this._fieldLayout != null)
			{
				this._fieldLayout.AutoSizeInfo.OnRecordExpanded(this);
			}
			this.OnIsExpandedStateChanged();
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0005FBA8 File Offset: 0x0005DDA8
		internal bool SetIsVisibleWhenFilteredOut(bool newValue, bool invalidateOnChange = false)
		{
			if (this._isVisibleWhenFilteredOut != newValue)
			{
				if (!invalidateOnChange)
				{
					this._isVisibleWhenFilteredOut = newValue;
				}
				else
				{
					bool internalIsFilteredOut_Verify = this.InternalIsFilteredOut_Verify;
					this._isVisibleWhenFilteredOut = newValue;
					if (internalIsFilteredOut_Verify)
					{
						this.DirtyScrollCount();
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0005FBE4 File Offset: 0x0005DDE4
		internal virtual bool ShouldCollapseCell(global::Infragistics.Windows.DataPresenter.Field field)
		{
			return false;
		}

		// Token: 0x0600159B RID: 5531
		internal abstract void SortChildren();

		// Token: 0x0600159C RID: 5532 RVA: 0x0005FBE8 File Offset: 0x0005DDE8
		internal void SuspendActiveRecordFiltering()
		{
			if ((short)(this._cachedFilterState & global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter) != 0)
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

		// Token: 0x0600159D RID: 5533 RVA: 0x0005FC3B File Offset: 0x0005DE3B
		internal void SuspendFiltering()
		{
			this._cachedFilterState &= ~global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;
			this._cachedFilterState |= global::Infragistics.Windows.DataPresenter.Record.FilterState.FilterSuspended;
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0005FC60 File Offset: 0x0005DE60
		internal virtual bool ToggleContainingCardCollapsedState(bool addToUndo)
		{
			return false;
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0005FC63 File Offset: 0x0005DE63
		internal virtual bool ToggleContainingCardEmptyCellsCollapsedState(bool addToUndo)
		{
			return false;
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0005FC66 File Offset: 0x0005DE66
		internal virtual void VerifySortOrderOfChildren()
		{
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0005FC68 File Offset: 0x0005DE68
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

		// Token: 0x060015A2 RID: 5538 RVA: 0x0005FCF8 File Offset: 0x0005DEF8
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

		// Token: 0x060015A3 RID: 5539 RVA: 0x0005FD58 File Offset: 0x0005DF58
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

		// Token: 0x060015A4 RID: 5540 RVA: 0x0005FDE5 File Offset: 0x0005DFE5
		private void OnParentCollectionVersionChanged()
		{
			base.RaisePropertyChangedEvent("Index");
			base.RaisePropertyChangedEvent("VisibleIndex");
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0005FE00 File Offset: 0x0005E000
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0005FE6F File Offset: 0x0005E06F
		int global::Infragistics.Collections.ISparseArrayMultiItem.ScrollCount
		{
			get
			{
				return this.ScrollCountInternal;
			}
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x0005FE77 File Offset: 0x0005E077
		object global::Infragistics.Collections.ISparseArrayItem.GetOwnerData(global::Infragistics.Collections.SparseArray context)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_6"));
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x0005FE88 File Offset: 0x0005E088
		void global::Infragistics.Collections.ISparseArrayItem.SetOwnerData(object ownerData, global::Infragistics.Collections.SparseArray context)
		{
			throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_7"));
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x0005FE99 File Offset: 0x0005E099
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsDraggable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x060015AA RID: 5546 RVA: 0x0005FE9C File Offset: 0x0005E09C
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelectable
		{
			get
			{
				return this.IsSelectable;
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x0005FEA4 File Offset: 0x0005E0A4
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsSelected
		{
			get
			{
				return this.IsSelected;
			}
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060015AC RID: 5548 RVA: 0x0005FEAC File Offset: 0x0005E0AC
		bool global::Infragistics.Windows.Selection.ISelectableItem.IsTabStop
		{
			get
			{
				return this.IsEnabledResolved;
			}
		}

		// Token: 0x0400088E RID: 2190
		internal const global::Infragistics.Windows.DataPresenter.Record.FilterState FILTERED_IN_OUT_FLAGS = global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn;

		// Token: 0x0400088F RID: 2191
		internal const global::Infragistics.Windows.DataPresenter.Record.FilterState FILTER_ACTION_FLAGS = global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity;

		// Token: 0x04000890 RID: 2192
		internal const global::Infragistics.Windows.DataPresenter.Record.FilterState FILTER_IN_OUT_AND_ACTION_FLAGS = global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredOut | global::Infragistics.Windows.DataPresenter.Record.FilterState.FilteredIn | global::Infragistics.Windows.DataPresenter.Record.FilterState.Hide | global::Infragistics.Windows.DataPresenter.Record.FilterState.Disable | global::Infragistics.Windows.DataPresenter.Record.FilterState.NoAction | global::Infragistics.Windows.DataPresenter.Record.FilterState.ReduceOpacity;

		// Token: 0x04000891 RID: 2193
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000892 RID: 2194
		private global::Infragistics.Windows.DataPresenter.RecordCollectionBase _parentCollection;

		// Token: 0x04000893 RID: 2195
		private string _description;

		// Token: 0x04000894 RID: 2196
		private bool _isExpanded;

		// Token: 0x04000895 RID: 2197
		private bool _isFixedLastReturned;

		// Token: 0x04000896 RID: 2198
		private bool _enabled = true;

		// Token: 0x04000897 RID: 2199
		private bool _selected;

		// Token: 0x04000898 RID: 2200
		private global::System.WeakReference _associatedRecordPresenter;

		// Token: 0x04000899 RID: 2201
		private global::System.Windows.Visibility _expansionIndicatorVisibilityLastReturned = global::System.Windows.Visibility.Collapsed;

		// Token: 0x0400089A RID: 2202
		private global::System.Windows.Visibility _visibility;

		// Token: 0x0400089B RID: 2203
		private global::System.Windows.Visibility? _explicitExpansionIndicatorVisibility;

		// Token: 0x0400089C RID: 2204
		internal object _sparseArrayOwnerData_Sorted;

		// Token: 0x0400089D RID: 2205
		internal object _sparseArrayOwnerData_Unsorted;

		// Token: 0x0400089E RID: 2206
		internal object _sparseArrayOwnerData_Grouped;

		// Token: 0x0400089F RID: 2207
		private double _lastLayoutExtent;

		// Token: 0x040008A0 RID: 2208
		private int _lastLayoutExtentVersion;

		// Token: 0x040008A1 RID: 2209
		private int _index = -1;

		// Token: 0x040008A2 RID: 2210
		private object _tag;

		// Token: 0x040008A3 RID: 2211
		private global::System.WeakReference _automationPeer;

		// Token: 0x040008A4 RID: 2212
		private global::Infragistics.Windows.DataPresenter.FixedRecordLocationInternal _fixedRecordLocationOverride;

		// Token: 0x040008A5 RID: 2213
		private global::Infragistics.Windows.DataPresenter.RecordSeparatorVisibility _separatorVisibility;

		// Token: 0x040008A6 RID: 2214
		internal global::Infragistics.Windows.DataPresenter.FixedRecordLocation _fixedLocation;

		// Token: 0x040008A7 RID: 2215
		private bool _isVisibleWhenFilteredOut;

		// Token: 0x040008A8 RID: 2216
		private bool _expandedToRevealFilteredInDescendants;

		// Token: 0x040008A9 RID: 2217
		internal global::Infragistics.Windows.DataPresenter.Record.FilterState _cachedFilterState = global::Infragistics.Windows.DataPresenter.Record.FilterState.NeedsToRefilter;

		// Token: 0x040008AA RID: 2218
		private global::Infragistics.Windows.DataPresenter.FieldGridBagLayoutManager _layoutManager;

		// Token: 0x040008AB RID: 2219
		private bool? _isContainingCardCollapsed;

		// Token: 0x040008AC RID: 2220
		private bool? _shouldCollapseEmptyCells;

		// Token: 0x040008AD RID: 2221
		private global::Infragistics.Windows.Internal.PropertyValueTracker _parentCollectionVersionTracker;

		// Token: 0x02000164 RID: 356
		[global::System.Flags]
		internal enum FilterState : short
		{
			// Token: 0x040008AF RID: 2223
			NeedsToRefilter = 1,
			// Token: 0x040008B0 RID: 2224
			FilteredOut = 2,
			// Token: 0x040008B1 RID: 2225
			FilteredIn = 4,
			// Token: 0x040008B2 RID: 2226
			NeverFilter = 8,
			// Token: 0x040008B3 RID: 2227
			Hide = 16,
			// Token: 0x040008B4 RID: 2228
			Disable = 32,
			// Token: 0x040008B5 RID: 2229
			NoAction = 64,
			// Token: 0x040008B6 RID: 2230
			ReduceOpacity = 128,
			// Token: 0x040008B7 RID: 2231
			FilterSuspended = 256
		}
	}
}
