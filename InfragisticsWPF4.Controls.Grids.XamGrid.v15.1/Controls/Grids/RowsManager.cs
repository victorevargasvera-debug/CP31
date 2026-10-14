using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using Infragistics.Collections;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200028B RID: 651
	public class RowsManager : global::Infragistics.Controls.Grids.RowsManagerBase, global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>
	{
		// Token: 0x0600156C RID: 5484 RVA: 0x0004E028 File Offset: 0x0004C228
		internal RowsManager(int level, global::Infragistics.Controls.Grids.ColumnLayout columnLayout, global::Infragistics.Controls.Grids.RowBase parentLayoutRow) : base(columnLayout)
		{
			this.Level = level;
			this.ParentRow = parentLayoutRow;
			this._rows = new global::Infragistics.Controls.Grids.RowCollection(this, columnLayout);
			this._rowObjectCache = new global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Grids.Row>();
			this._cachedRows = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Grids.Row>(new global::Infragistics.DataKeyComparer());
			this._cachedGroupByRows = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Grids.Row>();
			this._duplicateObjectValidator = new global::System.Collections.Generic.Dictionary<object, int>(new global::Infragistics.DataKeyComparer());
			this.HeaderSupported = (this.FooterSupported = true);
			this.InvalidateAddNewRowVisibility(true);
			this.EnsureDataManager();
			if (columnLayout != null && columnLayout.Grid != null)
			{
				this._isInDesigner = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(columnLayout.Grid);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x0004E0EC File Offset: 0x0004C2EC
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x0004E0F4 File Offset: 0x0004C2F4
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return this._itemSource;
			}
			protected internal set
			{
				if (this._itemSource != value)
				{
					if (this._itemSource != null && base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
					{
						this.AttachDetachPropertyChanged(false);
					}
					this._itemSource = value;
					this.OnItemsSourceChanged(this.ParentRow == null || this.ParentRow.RowType != global::Infragistics.Controls.Grids.RowType.GroupByRow);
					if (this._itemSource != null && base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
					{
						this.AttachDetachPropertyChanged(true);
					}
				}
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x0004E17F File Offset: 0x0004C37F
		public global::Infragistics.Controls.Grids.Primitives.HeaderRow HeaderRow
		{
			get
			{
				if (this._headerRow == null)
				{
					this._headerRow = new global::Infragistics.Controls.Grids.Primitives.HeaderRow(this);
				}
				return this._headerRow;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x0004E19B File Offset: 0x0004C39B
		public global::Infragistics.Controls.Grids.Primitives.FooterRow FooterRow
		{
			get
			{
				if (this._footerRow == null)
				{
					this._footerRow = new global::Infragistics.Controls.Grids.Primitives.FooterRow(this);
				}
				return this._footerRow;
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x0004E1B7 File Offset: 0x0004C3B7
		public global::Infragistics.Controls.Grids.Primitives.AddNewRow AddNewRowTop
		{
			get
			{
				if (this._addNewRowTop == null)
				{
					this._addNewRowTop = new global::Infragistics.Controls.Grids.Primitives.AddNewRow(this);
				}
				return this._addNewRowTop;
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x06001572 RID: 5490 RVA: 0x0004E1D3 File Offset: 0x0004C3D3
		public global::Infragistics.Controls.Grids.Primitives.AddNewRow AddNewRowBottom
		{
			get
			{
				if (this._addNewRowBottom == null)
				{
					this._addNewRowBottom = new global::Infragistics.Controls.Grids.Primitives.AddNewRow(this);
				}
				return this._addNewRowBottom;
			}
		}

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06001573 RID: 5491 RVA: 0x0004E1EF File Offset: 0x0004C3EF
		public global::Infragistics.Controls.Grids.Primitives.PagerRow PagerRowTop
		{
			get
			{
				if (this._topPagerRow == null)
				{
					this._topPagerRow = new global::Infragistics.Controls.Grids.Primitives.PagerRow(this);
				}
				return this._topPagerRow;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x0004E20B File Offset: 0x0004C40B
		public global::Infragistics.Controls.Grids.Primitives.PagerRow PagerRowBottom
		{
			get
			{
				if (this._bottomPagerRow == null)
				{
					this._bottomPagerRow = new global::Infragistics.Controls.Grids.Primitives.PagerRow(this);
				}
				return this._bottomPagerRow;
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001575 RID: 5493 RVA: 0x0004E227 File Offset: 0x0004C427
		public global::Infragistics.Controls.Grids.Primitives.FilterRow FilterRowTop
		{
			get
			{
				if (this._filterRowTop == null)
				{
					this._filterRowTop = new global::Infragistics.Controls.Grids.Primitives.FilterRow(this);
				}
				return this._filterRowTop;
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x0004E243 File Offset: 0x0004C443
		public global::Infragistics.Controls.Grids.Primitives.FilterRow FilterRowBottom
		{
			get
			{
				if (this._filterRowBottom == null)
				{
					this._filterRowBottom = new global::Infragistics.Controls.Grids.Primitives.FilterRow(this);
				}
				return this._filterRowBottom;
			}
		}

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x0004E25F File Offset: 0x0004C45F
		public global::Infragistics.Controls.Grids.Primitives.SummaryRow SummaryRowTop
		{
			get
			{
				if (this._summaryRowTop == null)
				{
					this._summaryRowTop = new global::Infragistics.Controls.Grids.Primitives.SummaryRow(this);
				}
				return this._summaryRowTop;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x0004E27B File Offset: 0x0004C47B
		public global::Infragistics.Controls.Grids.Primitives.SummaryRow SummaryRowBottom
		{
			get
			{
				if (this._summaryRowBottom == null)
				{
					this._summaryRowBottom = new global::Infragistics.Controls.Grids.Primitives.SummaryRow(this);
				}
				return this._summaryRowBottom;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001579 RID: 5497 RVA: 0x0004E298 File Offset: 0x0004C498
		// (set) Token: 0x0600157A RID: 5498 RVA: 0x0004E2B8 File Offset: 0x0004C4B8
		public int CurrentPageIndex
		{
			get
			{
				global::Infragistics.DataManagerBase dataManager = this.DataManager;
				if (dataManager != null)
				{
					return dataManager.CurrentPage;
				}
				return 0;
			}
			set
			{
				if (value < 0)
				{
					throw new global::Infragistics.Controls.Grids.InvalidPageIndexException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Infragistics.SRGrid.GetString("InvalidPageIndexException"), new object[]
					{
						value
					}));
				}
				if (value != this._currentPageIndex)
				{
					if (base.ColumnLayout.Grid.CurrentEditCell != null || base.ColumnLayout.Grid.CurrentEditRow != null)
					{
						base.ColumnLayout.Grid.ExitEditMode(true);
					}
					bool flag = false;
					if (base.ColumnLayout != null)
					{
						flag = base.ColumnLayout.Grid.OnPageIndexChanging(value, this.Level, this._rows, base.ColumnLayout);
					}
					if (flag)
					{
						this.InvalidatePager();
						return;
					}
					int currentPageIndex = this._currentPageIndex;
					this._currentPageIndex = value;
					this.AttachDetachPropertyChanged(false);
					global::Infragistics.DataManagerBase dataManager = this.DataManager;
					if (dataManager != null)
					{
						dataManager.CurrentPage = value;
					}
					base.ColumnLayout.Grid.OnPageIndexChanged(currentPageIndex);
					if (this.ParentRow == null && this.Rows.Count > 0 && this.Rows[0].Cells.Count > 0)
					{
						base.ColumnLayout.Grid.ScrollCellIntoView(this.Rows[0].Cells[0]);
						return;
					}
				}
				else
				{
					global::Infragistics.DataManagerBase dataManager2 = this.DataManager;
					if (dataManager2 != null)
					{
						dataManager2.CurrentPage = value;
					}
				}
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600157B RID: 5499 RVA: 0x0004E414 File Offset: 0x0004C614
		protected internal int PageCount
		{
			get
			{
				int result = 0;
				global::Infragistics.DataManagerBase dataManager = this.DataManager;
				if (dataManager != null)
				{
					if (dataManager.PageCount < 1)
					{
						result = 1;
					}
					else
					{
						result = dataManager.PageCount;
					}
				}
				return result;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600157C RID: 5500 RVA: 0x0004E442 File Offset: 0x0004C642
		// (set) Token: 0x0600157D RID: 5501 RVA: 0x0004E44A File Offset: 0x0004C64A
		public int GroupByLevel
		{
			get
			{
				return this._groupByLevel;
			}
			protected set
			{
				this._groupByLevel = value;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x0004E453 File Offset: 0x0004C653
		// (set) Token: 0x0600157F RID: 5503 RVA: 0x0004E45B File Offset: 0x0004C65B
		public global::Infragistics.Controls.Grids.Column GroupedColumn { get; protected internal set; }

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x0004E464 File Offset: 0x0004C664
		internal global::Infragistics.Controls.Grids.Primitives.GroupByColumn GroupByColumn
		{
			get
			{
				if (this._groupByColumn == null)
				{
					this._groupByColumn = new global::Infragistics.Controls.Grids.Primitives.GroupByColumn();
					this._groupByColumn.ColumnLayout = base.ColumnLayout;
				}
				return this._groupByColumn;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x0004E490 File Offset: 0x0004C690
		internal global::Infragistics.Controls.Grids.ColumnLayoutTemplateColumn ColumnLayoutTemplateColumn
		{
			get
			{
				if (this._columnLayoutTemplateColumn == null)
				{
					this._columnLayoutTemplateColumn = new global::Infragistics.Controls.Grids.ColumnLayoutTemplateColumn();
					this._columnLayoutTemplateColumn.ColumnLayout = base.ColumnLayout;
				}
				return this._columnLayoutTemplateColumn;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x0004E4BC File Offset: 0x0004C6BC
		public global::Infragistics.Controls.Grids.RowFiltersCollection RowFiltersCollection
		{
			get
			{
				if (this._rowFiltersCollection == null)
				{
					this._rowFiltersCollection = new global::Infragistics.Controls.Grids.RowFiltersCollection();
					this._rowFiltersCollection.PropertyChanged += this.RowFiltersCollection_PropertyChanged;
					this._rowFiltersCollection.CollectionChanged += this.RowFiltersCollection_CollectionChanged;
					this._rowFiltersCollection.CollectionItemChanged += this.RowFiltersCollection_CollectionItemChanged;
				}
				return this._rowFiltersCollection;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x0004E528 File Offset: 0x0004C728
		public global::Infragistics.Controls.Grids.RowFiltersCollection RowFiltersCollectionResolved
		{
			get
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.ColumnLayout;
				if (columnLayout != null)
				{
					global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettings = columnLayout.FilteringSettings;
					if (filteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ColumnLayout)
					{
						return filteringSettings.RowFiltersCollection;
					}
				}
				return this.RowFiltersCollection;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x06001584 RID: 5508 RVA: 0x0004E55C File Offset: 0x0004C75C
		public global::Infragistics.SummaryDefinitionCollection SummaryDefinitionCollection
		{
			get
			{
				if (this._summaryDefinitionCollection == null)
				{
					this._summaryDefinitionCollection = new global::Infragistics.SummaryDefinitionCollection();
					this._summaryDefinitionCollection.CollectionChanged += this.SummaryDefinitionCollection_CollectionChanged;
				}
				return this._summaryDefinitionCollection;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x0004E590 File Offset: 0x0004C790
		public global::Infragistics.SummaryDefinitionCollection SummaryDefinitionCollectionResolved
		{
			get
			{
				global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettings = base.ColumnLayout.SummaryRowSettings;
				if (summaryRowSettings.SummaryScopeResolved == global::Infragistics.Controls.Grids.SummaryScope.ColumnLayout)
				{
					return summaryRowSettings.SummaryDefinitionCollection;
				}
				return this.SummaryDefinitionCollection;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001586 RID: 5510 RVA: 0x0004E5BF File Offset: 0x0004C7BF
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryResult> SummaryResultCollection
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryResult>(this.SummaryResultCollectionInternal);
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x0004E5CC File Offset: 0x0004C7CC
		protected internal virtual global::Infragistics.DataManagerBase DataManager
		{
			get
			{
				this.EnsureDataManager();
				return this._dataManager;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001588 RID: 5512 RVA: 0x0004E5DC File Offset: 0x0004C7DC
		protected virtual int DataCount
		{
			get
			{
				global::Infragistics.DataManagerBase dataManager = this.DataManager;
				if (dataManager != null)
				{
					dataManager.EnablePaging = (base.ColumnLayout.PagerSettings.AllowPagingResolved != global::Infragistics.Controls.Grids.PagingLocation.None);
					if (dataManager.EnablePaging)
					{
						dataManager.PageSize = base.ColumnLayout.PagerSettings.PageSizeResolved;
					}
					return dataManager.RecordCount;
				}
				return 0;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x0004E635 File Offset: 0x0004C835
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x0004E63D File Offset: 0x0004C83D
		protected internal global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Grids.Row> CachedRows
		{
			get
			{
				return this._cachedRows;
			}
			set
			{
				this._cachedRows = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x0004E646 File Offset: 0x0004C846
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x0004E64E File Offset: 0x0004C84E
		protected virtual bool FooterSupported { get; set; }

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x0004E657 File Offset: 0x0004C857
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x0004E65F File Offset: 0x0004C85F
		protected virtual bool HeaderSupported { get; set; }

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x0004E668 File Offset: 0x0004C868
		protected internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> RegisteredTopRows
		{
			get
			{
				if (this._registeredTopRows == null)
				{
					this._registeredTopRows = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>();
				}
				return this._registeredTopRows;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x0004E683 File Offset: 0x0004C883
		protected internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> RegisteredBottomRows
		{
			get
			{
				if (this._registeredBottomRows == null)
				{
					this._registeredBottomRows = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>();
				}
				return this._registeredBottomRows;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x0004E6A0 File Offset: 0x0004C8A0
		protected internal virtual bool ChildrenShouldBeDisplayedResolved
		{
			get
			{
				if (base.ColumnLayout.Visibility != global::System.Windows.Visibility.Visible)
				{
					return false;
				}
				if (this.ParentRow != null && base.ColumnLayout.InternalTemplate != null)
				{
					return true;
				}
				if (this.ItemsSource == null)
				{
					return false;
				}
				if (this._displayableRowCount > 0)
				{
					foreach (global::Infragistics.Controls.Grids.RowBase rowBase in this.RegisteredBottomRows)
					{
						if (rowBase.IsStandAloneRowResolved)
						{
							return true;
						}
					}
					foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this.RegisteredTopRows)
					{
						if (rowBase2.IsStandAloneRowResolved)
						{
							return true;
						}
					}
				}
				global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = this.RowFiltersCollectionResolved;
				for (int i = 0; i < rowFiltersCollectionResolved.Count; i++)
				{
					global::Infragistics.ConditionCollection conditions = rowFiltersCollectionResolved[i].Conditions;
					if (conditions.Count > 0 && this.DataManager != null && this.DataManager.TotalRecordCount > 0)
					{
						return true;
					}
				}
				return this.DataCount > 0;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x0004E7D4 File Offset: 0x0004C9D4
		protected internal global::Infragistics.SummaryResultCollection SummaryResultCollectionInternal
		{
			get
			{
				if (this._summaryResultCollection == null)
				{
					this._summaryResultCollection = new global::Infragistics.SummaryResultCollection();
				}
				return this._summaryResultCollection;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x0004E7EF File Offset: 0x0004C9EF
		protected internal global::Infragistics.Controls.Grids.ConditionalFormatCollection ConditionalFormattingRulesResolved
		{
			get
			{
				return base.ColumnLayout.ConditionalFormatCollection;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0004E7FC File Offset: 0x0004C9FC
		protected internal global::Infragistics.Controls.Grids.ConditionalFormatProxyCollection ConditionalFormattingProxyRulesResolved
		{
			get
			{
				return this.ConditionalFormatProxyCollection;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x0004E804 File Offset: 0x0004CA04
		protected global::Infragistics.Controls.Grids.ConditionalFormatProxyCollection ConditionalFormatProxyCollection
		{
			get
			{
				if (this._conditionalFormatProxyCollection == null)
				{
					this._conditionalFormatProxyCollection = new global::Infragistics.Controls.Grids.ConditionalFormatProxyCollection();
				}
				return this._conditionalFormatProxyCollection;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x0004E81F File Offset: 0x0004CA1F
		// (set) Token: 0x06001597 RID: 5527 RVA: 0x0004E827 File Offset: 0x0004CA27
		internal global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Grids.Row> RowObjectCache
		{
			get
			{
				return this._rowObjectCache;
			}
			set
			{
				this._rowObjectCache = value;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06001598 RID: 5528 RVA: 0x0004E830 File Offset: 0x0004CA30
		// (set) Token: 0x06001599 RID: 5529 RVA: 0x0004E838 File Offset: 0x0004CA38
		internal global::System.Collections.Generic.Dictionary<object, int> DuplicateObjectValidator
		{
			get
			{
				return this._duplicateObjectValidator;
			}
			set
			{
				this._duplicateObjectValidator = value;
			}
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0004E844 File Offset: 0x0004CA44
		private void BuildConditionalFormats()
		{
			this.ConditionalFormatProxyCollection.Clear();
			foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRule conditionalFormattingRule in base.ColumnLayout.ConditionalFormatCollection)
			{
				global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy conditionalFormattingRuleProxy = conditionalFormattingRule.CreateProxy();
				conditionalFormattingRuleProxy.Parent = conditionalFormattingRule;
				this.ConditionalFormatProxyCollection.Add(conditionalFormattingRuleProxy);
			}
			this.InvalidateConditionalFormatting();
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x0004E8C8 File Offset: 0x0004CAC8
		private void SetupDataManager()
		{
			this._dataManager = global::Infragistics.DataManagerBase.CreateDataManager(this.ItemsSource, base.ColumnLayout.Grid.DataManagerProvider);
			if (this._dataManager != null)
			{
				if (this.Level == 0 && this.ParentRow != null && this.ParentRow.RowType == global::Infragistics.Controls.Grids.RowType.GroupByRow)
				{
					this._dataManager.CachedTypedInfo = ((global::Infragistics.Controls.Grids.RowsManager)this.ParentRow.Manager).DataManager.CachedTypedInfo;
				}
				this._dataManager.CollectionChanged += this.DataManager_CollectionChanged;
				this._dataManager.NewObjectGeneration += this.DataManager_NewObjectGeneration;
				this._dataManager.ResolvingData += this.DataManager_ResolvingData;
				this._dataManager.DataUpdated += this.DataManager_DataUpdated;
				this._dataManager.CurrentItemChanged += this.DataManager_CurrentItemChanged;
				this._dataManager.SuspendInvalidateDataSource = true;
				this.InitializeData();
				if (base.ColumnLayout.SortingSettings.SortedColumns.Count > 0)
				{
					this.InvalidateSort();
				}
				if (base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					this._dataManager.ConditionalFormattingRules = this.ConditionalFormatProxyCollection.GenerateIRuleCollection();
				}
				else
				{
					this._dataManager.ConditionalFormattingRules = null;
				}
				this._dataManager.SummaryResultCollection = this.SummaryResultCollectionInternal;
				this._dataManager.Filters = this.RowFiltersCollectionResolved;
				this._dataManager.SummaryExecution = base.ColumnLayout.SummaryRowSettings.SummaryExecutionResolved;
				this._dataManager.Summaries = this.SummaryDefinitionCollectionResolved;
				this._dataManager.CurrentPage = this._currentPageIndex;
				this._dataManager.SuspendInvalidateDataSource = false;
				return;
			}
			global::System.Collections.Specialized.INotifyCollectionChanged notifyCollectionChanged = this.ItemsSource as global::System.Collections.Specialized.INotifyCollectionChanged;
			if (notifyCollectionChanged != null)
			{
				if (this._weakItemsSourceCollectionChanged != null)
				{
					this._weakItemsSourceCollectionChanged.Detach();
					this._weakItemsSourceCollectionChanged = null;
				}
				this._weakItemsSourceCollectionChanged = new global::Infragistics.WeakCollectionChangedHandler<global::Infragistics.Controls.Grids.RowsManager>(this, notifyCollectionChanged, delegate(global::Infragistics.Controls.Grids.RowsManager instance, object s, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
				{
					instance.ItemsSource_CollectionChanged(s, e);
				});
				notifyCollectionChanged.CollectionChanged += this._weakItemsSourceCollectionChanged.OnEvent;
			}
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x0004EB0C File Offset: 0x0004CD0C
		protected void EnsureDataManager()
		{
			if (this.ItemsSource == null)
			{
				if (this.ParentRow != null)
				{
					if (this.ParentRow.ItemSource != null)
					{
						this.ItemsSource = this.ParentRow.ItemSource;
					}
					else
					{
						object data = this.ParentRow.Data;
						if (data != null)
						{
							global::System.Reflection.PropertyInfo propertyInfo = base.ColumnLayout.ResovlePropertyInfo(data);
							if (propertyInfo != null)
							{
								this.ItemsSource = (propertyInfo.GetValue(this.ParentRow.Data, null) as global::System.Collections.IEnumerable);
							}
							else
							{
								object obj = global::Infragistics.DataManagerBase.ResolveValueFromPropertyPath(base.ColumnLayout.Key, data);
								this.ItemsSource = (obj as global::System.Collections.IEnumerable);
							}
							global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = data as global::System.ComponentModel.INotifyPropertyChanged;
							if (notifyPropertyChanged != null)
							{
								global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager> @object = new global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager>(this, notifyPropertyChanged, delegate(global::Infragistics.Controls.Grids.RowsManager instance, object s, global::System.ComponentModel.PropertyChangedEventArgs e)
								{
									instance.ItemSource_PropertyChanged(s, e);
								});
								notifyPropertyChanged.PropertyChanged += @object.OnEvent;
							}
						}
					}
					if (this.ItemsSource != null && this._dataManager == null)
					{
						this.SetupDataManager();
						return;
					}
				}
			}
			else if (this._dataManager == null)
			{
				this.SetupDataManager();
				if (this.ParentRow != null)
				{
					object data2 = this.ParentRow.Data;
					if (data2 != null)
					{
						global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged2 = data2 as global::System.ComponentModel.INotifyPropertyChanged;
						if (notifyPropertyChanged2 != null)
						{
							global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager> object2 = new global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager>(this, notifyPropertyChanged2, delegate(global::Infragistics.Controls.Grids.RowsManager instance, object s, global::System.ComponentModel.PropertyChangedEventArgs e)
							{
								instance.ItemSource_PropertyChanged(s, e);
							});
							notifyPropertyChanged2.PropertyChanged += object2.OnEvent;
						}
					}
				}
			}
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x0004EC80 File Offset: 0x0004CE80
		private void InvalidateItemSource(bool validateInList, bool invalidateSelection, bool invalidateSort)
		{
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
			{
				global::System.ComponentModel.ICollectionView collectionView = this.ItemsSource as global::System.ComponentModel.ICollectionView;
				global::Infragistics.IPagedCollectionView pagedCollectionView = this.ItemsSource as global::Infragistics.IPagedCollectionView;
				if ((this.ParentRow == null || this.ParentRow.RowType != global::Infragistics.Controls.Grids.RowType.GroupByRow) && invalidateSelection)
				{
					this.InvalidateSelectionAndActivation(validateInList);
				}
				if (collectionView != null && collectionView.CanSort)
				{
					bool flag = false;
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = base.ColumnLayout.Grid.GroupBySettings.GroupByColumns[base.ColumnLayout];
					int num = (collectionView.GroupDescriptions == null) ? 0 : collectionView.GroupDescriptions.Count;
					if (num > 0 && readOnlyCollection.Count > 0)
					{
						global::System.Windows.Data.PropertyGroupDescription propertyGroupDescription = collectionView.GroupDescriptions[0] as global::System.Windows.Data.PropertyGroupDescription;
						if (propertyGroupDescription.PropertyName != readOnlyCollection[0].Key)
						{
							flag = true;
						}
					}
					else if (readOnlyCollection.Count == 0 && num > 0)
					{
						flag = true;
					}
					if (flag)
					{
						this._deferInvalidatingSort = true;
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(readOnlyCollection);
						global::Infragistics.Controls.Grids.GroupByColumnsCollection groupByColumns = base.ColumnLayout.Grid.GroupBySettings.GroupByColumns;
						foreach (global::Infragistics.Controls.Grids.Column item in list)
						{
							groupByColumns.Remove(item);
						}
						foreach (global::System.ComponentModel.GroupDescription groupDescription in collectionView.GroupDescriptions)
						{
							global::System.Windows.Data.PropertyGroupDescription propertyGroupDescription2 = groupDescription as global::System.Windows.Data.PropertyGroupDescription;
							if (propertyGroupDescription2 != null)
							{
								global::Infragistics.Controls.Grids.Column column = base.ColumnLayout.Columns.DataColumns[propertyGroupDescription2.PropertyName];
								if (column != null)
								{
									column.IsGroupBy = true;
								}
							}
						}
						this._deferInvalidatingSort = false;
					}
					global::Infragistics.Controls.Grids.SortedColumnsCollection sortedColumns = base.ColumnLayout.SortingSettings.SortedColumns;
					int count = collectionView.SortDescriptions.Count;
					if (count != sortedColumns.Count)
					{
						flag = true;
					}
					else if (count != 0)
					{
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(sortedColumns);
						int num2 = 0;
						if (this.GroupedColumn != null)
						{
							global::System.ComponentModel.SortDescription sortDescription = collectionView.SortDescriptions[0];
							bool flag2 = this.GroupedColumn.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending;
							bool flag3 = sortDescription.Direction == global::System.ComponentModel.ListSortDirection.Ascending;
							if (this.GroupedColumn.Key != sortDescription.PropertyName || flag2 != flag3)
							{
								flag = true;
							}
							list2.Remove(this.GroupedColumn);
							num2 = 1;
						}
						if (!flag)
						{
							for (int i = num2; i < count; i++)
							{
								global::System.ComponentModel.SortDescription sortDescription2 = collectionView.SortDescriptions[i];
								global::Infragistics.Controls.Grids.Column column2 = list2[i - num2];
								bool flag4 = column2.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending;
								bool flag5 = sortDescription2.Direction == global::System.ComponentModel.ListSortDirection.Ascending;
								if (column2.Key != sortDescription2.PropertyName || flag4 != flag5)
								{
									flag = true;
									break;
								}
							}
						}
					}
					if (flag && !this._deferInvalidatingSort)
					{
						if (count > sortedColumns.Count)
						{
							this._deferInvalidatingSort = true;
							sortedColumns.Clear();
							foreach (global::System.ComponentModel.SortDescription sortDescription3 in collectionView.SortDescriptions)
							{
								global::Infragistics.Controls.Grids.Column column3 = base.ColumnLayout.Columns.DataColumns[sortDescription3.PropertyName];
								if (column3 != null)
								{
									column3.IsSorted = ((sortDescription3.Direction == global::System.ComponentModel.ListSortDirection.Ascending) ? global::Infragistics.Controls.Grids.SortDirection.Ascending : global::Infragistics.Controls.Grids.SortDirection.Descending);
								}
							}
							this._deferInvalidatingSort = false;
						}
						this.InvalidateSort();
					}
					global::Infragistics.Controls.Grids.PagerSettingsOverride pagerSettings = base.ColumnLayout.PagerSettings;
					if (pagedCollectionView == null)
					{
						this.ValidatePagerInformation();
						return;
					}
					if (pagedCollectionView.PageIndex != -1)
					{
						if (pagerSettings.PageSizeResolved != pagedCollectionView.PageSize)
						{
							pagerSettings.PageSize = pagedCollectionView.PageSize;
						}
						int num3 = pagedCollectionView.PageIndex + 1;
						if (this.CurrentPageIndex != num3)
						{
							this.CurrentPageIndex = num3;
							return;
						}
					}
					else if (pagerSettings.AllowPagingResolved != global::Infragistics.Controls.Grids.PagingLocation.None && pagedCollectionView.PageSize != 0)
					{
						pagedCollectionView.PageSize = pagerSettings.PageSizeResolved;
						return;
					}
				}
				else if (invalidateSort)
				{
					this.InvalidateSort();
				}
			}
		}

		// Token: 0x0600159E RID: 5534 RVA: 0x0004F0A0 File Offset: 0x0004D2A0
		private void InvalidateSelectionAndActivation(bool validateInList)
		{
			global::System.ComponentModel.ICollectionView collectionView = this.ItemsSource as global::System.ComponentModel.ICollectionView;
			global::System.Collections.IList list = this.ItemsSource as global::System.Collections.IList;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Row> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Row>();
			global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRows = base.ColumnLayout.Grid.SelectionSettings.SelectedRows;
			foreach (global::Infragistics.Controls.Grids.Row row in selectedRows)
			{
				if (row.Manager == this)
				{
					bool? flag = null;
					if (collectionView != null)
					{
						flag = new bool?(collectionView.Contains(row.Data));
					}
					else if (list != null)
					{
						flag = new bool?(list.Contains(row.Data));
					}
					if (flag != null && flag.Value == !validateInList)
					{
						collection.Add(row);
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.Row item in collection)
			{
				selectedRows.Remove(item);
			}
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Cell> collection2 = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Cell>();
			global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCells = base.ColumnLayout.Grid.SelectionSettings.SelectedCells;
			foreach (global::Infragistics.Controls.Grids.Cell cell in selectedCells)
			{
				global::Infragistics.Controls.Grids.RowBase row2 = cell.Row;
				if (row2.Manager == this)
				{
					bool? flag2 = null;
					if (collectionView != null)
					{
						flag2 = new bool?(collectionView.Contains(row2.Data));
					}
					else if (list != null)
					{
						flag2 = new bool?(list.Contains(row2.Data));
					}
					if (flag2 != null && flag2.Value == !validateInList)
					{
						collection2.Add(cell);
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.Cell item2 in collection2)
			{
				selectedCells.Remove(item2);
			}
			global::Infragistics.Controls.Grids.CellBase activeCell = base.ColumnLayout.Grid.ActiveCell;
			if (activeCell != null)
			{
				global::Infragistics.Controls.Grids.RowBase row3 = activeCell.Row;
				if (row3.Manager == this && !this.RegisteredTopRows.Contains(row3) && !this.RegisteredBottomRows.Contains(row3))
				{
					bool? flag3 = null;
					if (collectionView != null)
					{
						flag3 = new bool?(collectionView.Contains(row3.Data));
					}
					else if (list != null)
					{
						flag3 = new bool?(list.Contains(row3.Data));
					}
					if (!validateInList)
					{
						if (flag3 == true)
						{
							base.ColumnLayout.Grid.ActiveCell = null;
							return;
						}
					}
					else if (flag3 == false)
					{
						global::System.Collections.IList list2 = null;
						if (collectionView != null)
						{
							list2 = (collectionView.SourceCollection as global::System.Collections.IList);
						}
						if ((list2 == null || !list2.Contains(row3.Data)) && row3.Data != null)
						{
							base.ColumnLayout.Grid.ActiveCell = null;
						}
					}
				}
			}
		}

		// Token: 0x0600159F RID: 5535 RVA: 0x0004F3D0 File Offset: 0x0004D5D0
		private void UnhookDataManager(bool clearChildRows, bool clearSelection, bool clearGroupBy)
		{
			if (this.ParentRow != null)
			{
				object data = this.ParentRow.Data;
				if (data != null)
				{
					global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = data as global::System.ComponentModel.INotifyPropertyChanged;
					if (notifyPropertyChanged != null)
					{
						notifyPropertyChanged.PropertyChanged -= this.ItemSource_PropertyChanged;
					}
				}
			}
			if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && clearSelection)
			{
				this.InvalidateSelectionAndActivation(false);
			}
			if (clearChildRows)
			{
				bool flag = false;
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && base.ColumnLayout.Grid.GridIsGoingToBeDestroyed)
				{
					flag = true;
				}
				if (!flag)
				{
					foreach (global::Infragistics.Controls.Grids.Row row in this._rowObjectCache)
					{
						if (row.Manager == this && row.ChildRowsManager != null)
						{
							row.ChildRowsManager.UnregisterRowsManager(true, true, true);
						}
					}
				}
				this._rowObjectCache.Clear();
				this._cachedRows.Clear();
			}
			if (clearGroupBy)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Controls.Grids.Row> keyValuePair in this._cachedGroupByRows)
				{
					if (keyValuePair.Value.Manager == this && keyValuePair.Value.ChildRowsManager != null)
					{
						((global::Infragistics.Controls.Grids.RowsManager)keyValuePair.Value.ChildRowsManager).UnregisterRowsManager(true, clearChildRows, clearSelection);
					}
				}
				if (this.GroupedColumn != null && !this.GroupedColumn.IsGroupBy)
				{
					this.GroupedColumn.SetSortedColumnStateInternally(global::Infragistics.Controls.Grids.SortDirection.None, true);
					this.GroupedColumn = null;
				}
				this._cachedGroupByRows.Clear();
			}
			this.InvalidateRows();
			this.HeaderRow.Cells.Reset();
			if (this._dataManager != null)
			{
				this._dataManager.DataSource = null;
				this._dataManager.CollectionChanged -= this.DataManager_CollectionChanged;
				this._dataManager.NewObjectGeneration -= this.DataManager_NewObjectGeneration;
				this._dataManager.ResolvingData -= this.DataManager_ResolvingData;
				this._dataManager.DataUpdated -= this.DataManager_DataUpdated;
				this._dataManager.CurrentItemChanged -= this.DataManager_CurrentItemChanged;
				this._dataManager.Filters = null;
				this._dataManager = null;
			}
		}

		// Token: 0x060015A0 RID: 5536 RVA: 0x0004F63C File Offset: 0x0004D83C
		private void ClearSpecializedRows()
		{
			if (this._addNewRowBottom != null)
			{
				this.UnregisterBottomRow(this.AddNewRowBottom);
				this._addNewRowBottom.Cells.Reset();
				this._addNewRowBottom.Manager = null;
			}
			if (this._addNewRowTop != null)
			{
				this.UnregisterTopRow(this.AddNewRowTop);
				this._addNewRowTop.Cells.Reset();
				this._addNewRowTop.Manager = null;
			}
			if (this._filterRowTop != null)
			{
				this.UnregisterTopRow(this.FilterRowTop);
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this._filterRowTop.Cells)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = cellBase as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
					if (filterRowCell != null)
					{
						filterRowCell.FilterCellValue = null;
					}
				}
				this._filterRowTop.Cells.Reset();
				this._filterRowTop.Manager = null;
			}
			if (this._filterRowBottom != null)
			{
				this.UnregisterBottomRow(this.FilterRowBottom);
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in this._filterRowBottom.Cells)
				{
					global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell2 = cellBase2 as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
					if (filterRowCell2 != null)
					{
						filterRowCell2.FilterCellValue = null;
					}
				}
				this._filterRowBottom.Cells.Clear();
				this._filterRowBottom.Manager = null;
			}
			if (this._summaryRowTop != null)
			{
				this.UnregisterTopRow(this.SummaryRowTop);
				this._summaryRowTop.Cells.Clear();
				this._summaryRowTop.Manager = null;
			}
			if (this._summaryRowBottom != null)
			{
				this.UnregisterBottomRow(this.SummaryRowBottom);
				this._summaryRowBottom.Cells.Clear();
				this._summaryRowBottom.Manager = null;
			}
			if (this._topPagerRow != null)
			{
				this.UnregisterTopRow(this.PagerRowTop);
				this._topPagerRow.Cells.Reset();
				this._topPagerRow.Manager = null;
			}
			if (this._bottomPagerRow != null)
			{
				this.UnregisterBottomRow(this.PagerRowBottom);
				this._bottomPagerRow.Cells.Reset();
				this._bottomPagerRow.Manager = null;
			}
			this._filterRowBottom = null;
			this._filterRowTop = null;
			this._addNewRowBottom = null;
			this._addNewRowTop = null;
			this._summaryRowBottom = null;
			this._summaryRowTop = null;
			this._topPagerRow = null;
			this._bottomPagerRow = null;
		}

		// Token: 0x060015A1 RID: 5537 RVA: 0x0004F8A8 File Offset: 0x0004DAA8
		private void InitializeDataManagerOnEmptyCollectionChanged()
		{
			this._dataManager = global::Infragistics.DataManagerBase.CreateDataManager(this.ItemsSource, base.ColumnLayout.Grid.DataManagerProvider);
			if (this._dataManager != null)
			{
				if (this._weakItemsSourceCollectionChanged != null)
				{
					this._weakItemsSourceCollectionChanged.Detach();
					this._weakItemsSourceCollectionChanged = null;
				}
				this._dataManager.CollectionChanged += this.DataManager_CollectionChanged;
				this._dataManager.NewObjectGeneration += this.DataManager_NewObjectGeneration;
				this._dataManager.ResolvingData += this.DataManager_ResolvingData;
				this._dataManager.DataUpdated += this.DataManager_DataUpdated;
				this._dataManager.CurrentItemChanged += this.DataManager_CurrentItemChanged;
				this._deferInvalidatingSort = true;
				this.InitializeData();
				this._deferInvalidatingSort = false;
				this.InvalidateGroupBy(false);
				this.InvalidateSort();
				this.InvalidateFiltering();
				this.InvalidateConditionalFormatting();
				this.InvalidateSummaries();
			}
			this._isInitializingDataManager = false;
		}

		// Token: 0x060015A2 RID: 5538 RVA: 0x0004F9A8 File Offset: 0x0004DBA8
		protected virtual global::Infragistics.Controls.Grids.Row GetDataItem(int index)
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager == null)
			{
				return null;
			}
			global::Infragistics.Controls.Grids.PagerSettingsOverride pagerSettings = base.ColumnLayout.PagerSettings;
			dataManager.EnablePaging = (pagerSettings.AllowPagingResolved != global::Infragistics.Controls.Grids.PagingLocation.None);
			if (dataManager.EnablePaging)
			{
				dataManager.PageSize = pagerSettings.PageSizeResolved;
			}
			object obj = dataManager.GetRecord(index);
			global::Infragistics.GroupByDataContext groupByDataContext = obj as global::Infragistics.GroupByDataContext;
			if (groupByDataContext == null)
			{
				global::Infragistics.MergedRowInfo mergedRowInfo = obj as global::Infragistics.MergedRowInfo;
				if (mergedRowInfo != null)
				{
					obj = mergedRowInfo.Data;
				}
				global::Infragistics.Controls.Grids.Row row = null;
				if (obj != null)
				{
					if (this._cachedRows.ContainsKey(obj))
					{
						if (!this._duplicateObjectValidator.ContainsKey(obj))
						{
							row = this._cachedRows[obj];
							row.Manager = this;
							this._duplicateObjectValidator.Add(obj, index);
							row.Index = index;
							if (row.ContainsChildBandRowsManager)
							{
								global::Infragistics.Controls.Grids.ChildBandRowsManager childBandRowsManager = (global::Infragistics.Controls.Grids.ChildBandRowsManager)row.ChildRowsManager;
								if (childBandRowsManager != null)
								{
									childBandRowsManager.InvalidateManager();
								}
							}
							if (row.IsExpanded)
							{
								base.RegisterChildRowsManager(row.ChildRowsManager);
							}
							row.MergeData = mergedRowInfo;
							return row;
						}
						global::Infragistics.Controls.Grids.Row row2 = new global::Infragistics.Controls.Grids.Row(index, this, obj)
						{
							MergeData = mergedRowInfo
						};
						this._rowObjectCache.Add(row2);
						return row2;
					}
					else
					{
						global::Infragistics.Controls.Grids.CellBase activeCell = base.ColumnLayout.Grid.ActiveCell;
						if (activeCell != null && activeCell.Row.Manager == this && activeCell.Row.ColumnLayout == base.ColumnLayout && activeCell.Row.Index == index && activeCell.Row.Data == null)
						{
							row = (global::Infragistics.Controls.Grids.Row)activeCell.Row;
							row.Data = obj;
							if (row.Control != null)
							{
								row.Control.DataContext = obj;
							}
						}
						if (row == null)
						{
							global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRows = base.ColumnLayout.Grid.SelectionSettings.SelectedRows;
							if (selectedRows.Count > index)
							{
								global::Infragistics.Controls.Grids.Row row3 = selectedRows[index];
								if (row3.RowType != global::Infragistics.Controls.Grids.RowType.GroupByRow && row3.Data == null && row3.Index == index)
								{
									row3.Data = obj;
									row = row3;
									if (row3.Control != null)
									{
										row3.Control.DataContext = obj;
									}
								}
							}
							if (row == null)
							{
								row = new global::Infragistics.Controls.Grids.Row(index, this, obj);
							}
						}
						this._rowObjectCache.Add(row);
						this._cachedRows.Add(obj, row);
						this._duplicateObjectValidator.Add(obj, index);
					}
				}
				else
				{
					row = new global::Infragistics.Controls.Grids.Row(index, this, obj);
					this._rowObjectCache.Add(row);
				}
				base.ColumnLayout.Grid.OnInitializeRow(row);
				row.MergeData = mergedRowInfo;
				return row;
			}
			object obj2 = groupByDataContext.Value;
			if (obj2 == null)
			{
				obj2 = "ig:XNull";
			}
			groupByDataContext.GroupBySummaries = this.GroupedColumn.SummaryColumnSettings.GroupBySummaryDefinitions;
			global::Infragistics.Controls.Grids.Primitives.GroupByRow groupByRow;
			if (this._cachedGroupByRows.ContainsKey(obj2))
			{
				groupByRow = (global::Infragistics.Controls.Grids.Primitives.GroupByRow)this._cachedGroupByRows[obj2];
				groupByRow.Manager = this;
				groupByRow.Index = index;
				groupByRow.Data = groupByDataContext.Value;
				groupByRow.GroupByData = groupByDataContext;
				global::Infragistics.Controls.Grids.RowsManager rowsManager = groupByRow.ChildRowsManager as global::Infragistics.Controls.Grids.RowsManager;
				rowsManager._deferClearGroupByCache = true;
				groupByRow.ItemSource = groupByDataContext.Records;
				rowsManager._deferClearGroupByCache = false;
				rowsManager.InvalidateItemSource(false, true, true);
				if (groupByRow.IsExpanded)
				{
					base.RegisterChildRowsManager(groupByRow.ChildRowsManager);
				}
				return groupByRow;
			}
			groupByRow = new global::Infragistics.Controls.Grids.Primitives.GroupByRow(index, this, groupByDataContext);
			this._cachedGroupByRows.Add(obj2, groupByRow);
			return groupByRow;
		}

		// Token: 0x060015A3 RID: 5539 RVA: 0x0004FD20 File Offset: 0x0004DF20
		protected virtual global::Infragistics.Controls.Grids.ColumnBase GenerateColumnForField(global::Infragistics.DataField field)
		{
			global::Infragistics.Controls.Grids.ColumnTypeMappingsCollection columnTypeMappings = base.ColumnLayout.Grid.ColumnTypeMappings;
			global::Infragistics.Controls.Grids.ColumnBase columnBase = null;
			if (typeof(global::System.Collections.IEnumerable).IsAssignableFrom(field.FieldType) && !typeof(string).IsAssignableFrom(field.FieldType))
			{
				columnBase = base.ColumnLayout.Grid.ColumnLayouts.InternalFromKey(field.Name);
			}
			if (columnBase == null)
			{
				foreach (global::Infragistics.Controls.Grids.ColumnTypeMapping columnTypeMapping in columnTypeMappings)
				{
					if (columnTypeMapping.DataType != null && columnTypeMapping.ColumnType != null && (columnTypeMapping.DataType == field.FieldType || (columnTypeMapping.DataType.IsAssignableFrom(field.FieldType) && !typeof(string).IsAssignableFrom(field.FieldType) && field.FieldType.GetInterface("IDictionary", false) == null)))
					{
						bool flag = columnTypeMapping.DataType.Name.Contains("Nullable`1");
						bool flag2 = field.FieldType.Name.Contains("Nullable`1");
						if (flag == flag2)
						{
							columnBase = (global::System.Activator.CreateInstance(columnTypeMapping.ColumnType) as global::Infragistics.Controls.Grids.ColumnBase);
							break;
						}
					}
				}
			}
			if (columnBase == null)
			{
				columnBase = new global::Infragistics.Controls.Grids.TextColumn();
			}
			return columnBase;
		}

		// Token: 0x060015A4 RID: 5540 RVA: 0x0004FE98 File Offset: 0x0004E098
		protected internal virtual void ResetAddNewRows(bool generateNewData)
		{
			if (generateNewData && base.ColumnLayout.AddNewRowSettings.AllowAddNewRowResolved != global::Infragistics.Controls.Grids.AddNewRowLocation.None)
			{
				object data = this.GenerateNewObject(global::Infragistics.Controls.Grids.RowType.AddNewRow);
				if (this.AddNewRowBottom.Control != null)
				{
					global::Infragistics.RecyclingManager.Manager.ReleaseElement(this.AddNewRowBottom, base.ColumnLayout.Grid.Panel);
				}
				if (this.AddNewRowTop.Control != null)
				{
					global::Infragistics.RecyclingManager.Manager.ReleaseElement(this.AddNewRowTop, base.ColumnLayout.Grid.Panel);
				}
				this.AddNewRowBottom.SetData(data);
				this.AddNewRowTop.SetData(data);
			}
		}

		// Token: 0x060015A5 RID: 5541 RVA: 0x0004FF3C File Offset: 0x0004E13C
		protected internal virtual void ResetFilterRows(bool generateNewData)
		{
			global::Infragistics.Controls.Grids.FilterUIType allowFilteringResolved = base.ColumnLayout.FilteringSettings.AllowFilteringResolved;
			if (generateNewData && allowFilteringResolved != global::Infragistics.Controls.Grids.FilterUIType.None && allowFilteringResolved != global::Infragistics.Controls.Grids.FilterUIType.None)
			{
				object obj;
				if (base.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ChildBand)
				{
					obj = this.GenerateNewObject(global::Infragistics.Controls.Grids.RowType.FilterRow);
				}
				else
				{
					obj = base.ColumnLayout.ColumnLayoutFilteringObject;
					if (obj == null)
					{
						obj = (base.ColumnLayout.ColumnLayoutFilteringObject = this.GenerateNewObject(global::Infragistics.Controls.Grids.RowType.FilterRow));
					}
				}
				if (this.FilterRowBottom.Control != null)
				{
					global::Infragistics.RecyclingManager.Manager.ReleaseElement(this.FilterRowBottom, base.ColumnLayout.Grid.Panel);
				}
				if (this.FilterRowTop.Control != null)
				{
					global::Infragistics.RecyclingManager.Manager.ReleaseElement(this.FilterRowTop, base.ColumnLayout.Grid.Panel);
				}
				this.FilterRowBottom.SetData(obj);
				this.FilterRowTop.SetData(obj);
			}
		}

		// Token: 0x060015A6 RID: 5542 RVA: 0x00050024 File Offset: 0x0004E224
		protected internal virtual object GenerateNewObject(global::Infragistics.Controls.Grids.RowType rowType)
		{
			object result = null;
			if (this._dataManager != null)
			{
				this._newDataObjectRowType = new global::Infragistics.Controls.Grids.RowType?(rowType);
				result = this._dataManager.GenerateNewObject();
			}
			return result;
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00050054 File Offset: 0x0004E254
		protected virtual void InitializeData()
		{
			if (this._dataManager != null)
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = null;
				global::System.Type cachedType = this._dataManager.CachedType;
				if (cachedType != null)
				{
					columnLayout = base.ColumnLayout.Grid.ColumnLayouts.InternalFromType(cachedType);
				}
				if (columnLayout == null)
				{
					columnLayout = base.ColumnLayout.Grid.ColumnLayouts.InternalFromKey(base.ColumnLayout.Key);
				}
				if (columnLayout != null && base.ColumnLayout != columnLayout)
				{
					columnLayout.Grid = base.ColumnLayout.Grid;
					base.ColumnLayout = columnLayout;
				}
				global::Infragistics.Controls.Grids.ColumnLayoutAssignedEventArgs columnLayoutAssignedEventArgs = new global::Infragistics.Controls.Grids.ColumnLayoutAssignedEventArgs
				{
					ColumnLayout = base.ColumnLayout,
					Level = this.Level,
					DataType = cachedType,
					Key = base.ColumnLayout.Key,
					Rows = this._rows
				};
				base.ColumnLayout.Grid.OnColumnLayoutAssigned(columnLayoutAssignedEventArgs);
				if (columnLayoutAssignedEventArgs.ColumnLayout != null && columnLayoutAssignedEventArgs.ColumnLayout != base.ColumnLayout)
				{
					columnLayoutAssignedEventArgs.ColumnLayout.Grid = base.ColumnLayout.Grid;
					base.ColumnLayout = columnLayoutAssignedEventArgs.ColumnLayout;
					if (string.IsNullOrEmpty(columnLayoutAssignedEventArgs.ColumnLayout.Key) && !this._isInDesigner)
					{
						throw new global::Infragistics.Controls.Grids.EmptyColumnKeyException();
					}
				}
				if (!base.ColumnLayout.Grid.ColumnLayouts.Contains(base.ColumnLayout))
				{
					base.ColumnLayout.Grid.ColumnLayouts.AddItemLocally(base.ColumnLayout);
				}
				if (!base.ColumnLayout.IsInitialized)
				{
					if (base.ColumnLayout.DataType == null)
					{
						base.ColumnLayout.DataType = this.ItemsSource.GetType();
					}
					base.ColumnLayout.ObjectDataType = this._dataManager.CachedType;
					base.ColumnLayout.ObjectDataTypeInfo = this._dataManager.CachedTypedInfo;
					base.ColumnLayout.IsInitialized = true;
					global::System.Collections.Generic.IEnumerable<global::Infragistics.DataField> dataProperties = this._dataManager.GetDataProperties();
					base.ColumnLayout.DataFields = dataProperties;
					if (base.ColumnLayout.AutoGenerateColumnsResolved)
					{
						global::System.Collections.ObjectModel.Collection<string> collection = new global::System.Collections.ObjectModel.Collection<string>();
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> allColumns = base.ColumnLayout.Columns.AllColumns;
						foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in allColumns)
						{
							if (!string.IsNullOrEmpty(columnBase.Key))
							{
								collection.Add(columnBase.Key);
							}
						}
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.DataField> enumerator2 = dataProperties.GetEnumerator())
						{
							while (enumerator2.MoveNext())
							{
								global::Infragistics.DataField dataField = enumerator2.Current;
								if (dataField.AutoGenerate && !collection.Contains(dataField.Name))
								{
									global::Infragistics.Controls.Grids.ColumnBase columnBase2 = this.GenerateColumnForField(dataField);
									if (columnBase2 != null)
									{
										columnBase2.DataField = dataField;
										columnBase2.IsAutoGenerated = true;
										columnBase2.Key = dataField.Name;
										columnBase2.DataType = dataField.FieldType;
										global::Infragistics.Controls.Grids.ColumnAutoGeneratedEventArgs columnAutoGeneratedEventArgs = new global::Infragistics.Controls.Grids.ColumnAutoGeneratedEventArgs
										{
											Column = columnBase2
										};
										base.ColumnLayout.Grid.OnColumnAutoGenerated(columnAutoGeneratedEventArgs);
										columnBase2 = columnAutoGeneratedEventArgs.Column;
										if (columnBase2 != null)
										{
											base.ColumnLayout.Columns.Add(columnBase2);
										}
									}
								}
							}
							goto IL_41C;
						}
					}
					if (base.ColumnLayout.Grid.ShouldAddColumnLayouts(base.ColumnLayout))
					{
						global::Infragistics.Controls.Grids.ColumnLayoutCollection columnLayouts = base.ColumnLayout.Grid.ColumnLayouts;
						foreach (global::Infragistics.DataField dataField2 in dataProperties)
						{
							global::System.Type type = null;
							if (dataField2.FieldType.IsGenericType)
							{
								global::System.Type[] genericArguments = dataField2.FieldType.GetGenericArguments();
								if (genericArguments.Length > 0)
								{
									type = genericArguments[0];
								}
							}
							global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 = null;
							if (type != null)
							{
								columnLayout2 = columnLayouts.InternalFromType(type);
							}
							if (columnLayout2 == null)
							{
								columnLayout2 = columnLayouts.InternalFromKey(dataField2.Name);
							}
							if (columnLayout2 != null && base.ColumnLayout.Columns[columnLayout2.Key] == null)
							{
								base.ColumnLayout.Columns.Add(columnLayout2);
							}
						}
					}
					IL_41C:
					global::System.Collections.ObjectModel.Collection<string> collection2 = new global::System.Collections.ObjectModel.Collection<string>();
					foreach (global::Infragistics.DataField dataField3 in dataProperties)
					{
						global::Infragistics.Controls.Grids.ColumnBase columnBase3 = base.ColumnLayout.Columns[dataField3.Name];
						if (columnBase3 != null)
						{
							columnBase3.DataType = dataField3.FieldType;
							columnBase3.DataField = dataField3;
							if (string.IsNullOrEmpty(columnBase3.HeaderText))
							{
								columnBase3.HeaderText = (dataField3.DisplayName ?? dataField3.Name);
							}
						}
						collection2.Add(dataField3.Name);
					}
					base.ColumnLayout.Columns.DataType = cachedType;
					foreach (global::Infragistics.Controls.Grids.Column column in base.ColumnLayout.Columns.DataColumns)
					{
						if (base.ColumnLayout.FilteringSettings.FilteringScopeResolved == global::Infragistics.Controls.Grids.FilteringScope.ColumnLayout)
						{
							global::Infragistics.Controls.Grids.FilterOperand filteringOperandResolved = column.FilterColumnSettings.FilteringOperandResolved;
							if (filteringOperandResolved != null)
							{
								if (filteringOperandResolved.RequiresFilteringInput && column.FilterColumnSettings.FilterCellValue != null)
								{
									object obj = column.ResolveValue(column.FilterColumnSettings.FilterCellValue);
									if (obj == column.FilterColumnSettings.FilterCellValue)
									{
										global::Infragistics.Controls.Grids.RowsFilter rowsFilter = base.ColumnLayout.FilteringSettings.RowFiltersCollection[column.Key];
										if (rowsFilter == null || rowsFilter.Conditions.Count == 0)
										{
											column.FilterColumnSettings.BuildFilters(true);
										}
									}
									else
									{
										column.FilterColumnSettings.FilterCellValue = obj;
									}
								}
								else
								{
									column.FilterColumnSettings.BuildFilters(false, false);
								}
							}
						}
						else
						{
							global::Infragistics.Controls.Grids.Primitives.FilterRow filterRow = null;
							if (base.ColumnLayout.FilteringSettings.AllowFilteringResolved == global::Infragistics.Controls.Grids.FilterUIType.FilterRowTop)
							{
								filterRow = this.FilterRowTop;
							}
							else if (base.ColumnLayout.FilteringSettings.AllowFilteringResolved == global::Infragistics.Controls.Grids.FilterUIType.FilterRowTop)
							{
								filterRow = this.FilterRowBottom;
							}
							if (filterRow != null)
							{
								global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = filterRow.Cells[column.Key] as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
								if (filterRowCell != null)
								{
									global::Infragistics.Controls.Grids.FilterOperand filteringOperandResolved2 = filterRowCell.FilteringOperandResolved;
									if (filteringOperandResolved2 != null)
									{
										if (filteringOperandResolved2.RequiresFilteringInput && filterRowCell.FilterCellValueResolved != null)
										{
											object obj2 = column.ResolveValue(filterRowCell.FilterCellValueResolved);
											if (obj2 == filterRowCell.FilterCellValueResolved)
											{
												filterRow.BuildFilters(filterRowCell, filterRowCell.FilterCellValueResolved, false);
											}
											else
											{
												filterRowCell.FilterCellValue = obj2;
											}
										}
										else
										{
											column.FilterColumnSettings.BuildFilters(false, false);
										}
									}
								}
							}
						}
					}
					global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> allColumns2 = base.ColumnLayout.Columns.AllColumns;
					global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = this.DataManager.CachedTypedInfo.PropertyDescriptors;
					foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase4 in allColumns2)
					{
						if (columnBase4.Key.Contains("[") && columnBase4.Key.Contains("]"))
						{
							try
							{
								global::System.Linq.Expressions.Expression expression = global::Infragistics.DataManagerBase.BuildPropertyExpressionFromPropertyName(columnBase4.Key, global::System.Linq.Expressions.Expression.Parameter(cachedType, "param"));
								if (expression != null && columnBase4.DataType == null)
								{
									columnBase4.DataType = expression.Type;
								}
								continue;
							}
							catch (global::System.Exception)
							{
								continue;
							}
						}
						if (propertyDescriptors != null)
						{
							global::System.ComponentModel.PropertyDescriptor propertyDescriptor = propertyDescriptors[columnBase4.Key];
							if (propertyDescriptor != null)
							{
								if (propertyDescriptor.PropertyType.IsValueType && propertyDescriptor.ComponentType == typeof(global::System.Data.DataRowView))
								{
									columnBase4.DataType = typeof(global::System.Nullable<>).MakeGenericType(new global::System.Type[]
									{
										propertyDescriptor.PropertyType
									});
									continue;
								}
								columnBase4.DataType = propertyDescriptor.PropertyType;
								continue;
							}
						}
						string[] array = columnBase4.Key.Split(new char[]
						{
							'.'
						});
						if (array.Length > 0)
						{
							if (!collection2.Contains(array[0]))
							{
								global::Infragistics.Controls.Grids.ColumnLayout columnLayout3 = columnBase4 as global::Infragistics.Controls.Grids.ColumnLayout;
								if (columnBase4.RequiresBoundDataKey && (columnLayout3 == null || (!columnLayout3.IsDefinedGloballyResolved && string.IsNullOrEmpty(columnLayout3.TargetTypeName))))
								{
									base.ColumnLayout.Grid.ThrowInvalidColumnKeyException(columnBase4.Key);
								}
							}
							else
							{
								global::System.Type type2 = cachedType;
								bool flag = true;
								foreach (string propertyName in array)
								{
									global::System.Reflection.PropertyInfo propertyInfo = global::Infragistics.DataManagerBase.ResolveProperty(type2, propertyName);
									if (propertyInfo == null)
									{
										global::Infragistics.Controls.Grids.ColumnLayout columnLayout4 = columnBase4 as global::Infragistics.Controls.Grids.ColumnLayout;
										if (!columnBase4.RequiresBoundDataKey)
										{
											flag = false;
											break;
										}
										if (columnLayout4 == null || (!columnLayout4.IsDefinedGloballyResolved && string.IsNullOrEmpty(columnLayout4.TargetTypeName)))
										{
											base.ColumnLayout.Grid.ThrowInvalidColumnKeyException(columnBase4.Key);
										}
									}
									else
									{
										type2 = propertyInfo.PropertyType;
									}
								}
								if (flag)
								{
									columnBase4.DataType = type2;
								}
							}
						}
					}
					base.ColumnLayout.IsXamlComplete = true;
				}
				this.InvalidateItemSource(false, true, true);
				this.ResetAddNewRows(true);
				this.ResetFilterRows(true);
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					base.ColumnLayout.Grid.InvalidateScrollPanel(true);
				}
			}
		}

		// Token: 0x060015A8 RID: 5544 RVA: 0x00050A5C File Offset: 0x0004EC5C
		protected virtual void OnItemsSourceChanged(bool invalidateSelectionAndActivation)
		{
			if (this._dataManager != null)
			{
				global::Infragistics.Controls.Grids.XamGrid grid = base.ColumnLayout.Grid;
				if (grid != null)
				{
					if (invalidateSelectionAndActivation)
					{
						if (grid.ActiveCell != null && (grid.ActiveCell.Row.Level > this.Level || grid.ActiveCell.Row.ColumnLayout == base.ColumnLayout))
						{
							grid.ActiveCell = null;
						}
						global::Infragistics.Controls.Grids.SelectionSettings selectionSettings = grid.SelectionSettings;
						selectionSettings.SelectedCells.Clear();
						selectionSettings.SelectedColumns.Clear();
						selectionSettings.SelectedRows.Clear();
					}
					if (grid.CurrentEditCell != null)
					{
						if (grid.CurrentEditCell.Row.ColumnLayout == base.ColumnLayout && grid.CurrentEditCell.Row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
						{
							grid.ExitEditModeInternal(true);
						}
					}
					else if (grid.CurrentEditRow != null && grid.CurrentEditRow.ColumnLayout == base.ColumnLayout && grid.CurrentEditRow.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
					{
						grid.ExitEditModeInternal(true);
					}
					if (this.ItemsSource != null)
					{
						global::System.Type left = global::Infragistics.DataManagerBase.ResolveItemType(this.ItemsSource);
						bool flag = left == this._dataManager.CachedType;
						global::Infragistics.CachedTypedInfo cachedTypedInfo = this._dataManager.CachedTypedInfo;
						flag &= (cachedTypedInfo.PropertyDescriptors == null || cachedTypedInfo.PropertyDescriptors.Count == 0 || this._deferClearGroupByCache);
						if (flag)
						{
							this.UnhookDataManager(true, true, false);
							this.EnsureDataManager();
							this.InvalidateRows();
							this.InvalidateData();
							return;
						}
					}
					else
					{
						this._dataManager.DataSource = this.ItemsSource;
					}
					this._deferInvalidatingSort = true;
					grid.SummaryRowSettings.SummaryDefinitionCollection.Clear();
					this.ClearSpecializedRows();
					base.ColumnLayout.DefaultDataObject = null;
					grid.ResetPanelRows();
					grid.GroupBySettings.GroupByColumns.Clear();
					global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.ColumnBase> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.ColumnBase>();
					foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in base.ColumnLayout.Columns.AllColumns)
					{
						if (columnBase.IsAutoGenerated)
						{
							collection.Add(columnBase);
						}
						else if (this.ItemsSource == null)
						{
							global::Infragistics.Controls.Grids.ColumnLayout columnLayout = columnBase as global::Infragistics.Controls.Grids.ColumnLayout;
							if (columnLayout != null)
							{
								columnLayout.OnColumnLayoutReset();
							}
						}
						global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
						if (column != null)
						{
							column.IsInitialAutoSet = false;
							column.CachedPropertyReadOnly = null;
							column.FilterColumnSettings.FilterCellValue = null;
							if (!column.IsAutoGenerated)
							{
								column.SummaryColumnSettings.RepopulateSummaryDefinitionCollection();
							}
						}
					}
					grid.FilteringSettings.RowFiltersCollection.Clear();
					foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase2 in collection)
					{
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 = columnBase2 as global::Infragistics.Controls.Grids.ColumnLayout;
						if (columnLayout2 != null)
						{
							if (columnLayout2.IsDefinedGloballyResolved)
							{
								continue;
							}
							if (grid.ColumnLayouts.Contains(columnLayout2))
							{
								grid.ColumnLayouts.Remove(columnLayout2);
							}
						}
						base.ColumnLayout.Columns.Remove(columnBase2);
					}
					this.UnhookDataManager(true, true, true);
					base.ColumnLayout.IsInitialized = false;
					base.ColumnLayout.DataFields = null;
					this._deferInvalidatingSort = false;
					grid.InvalidateScrollPanel(true, true);
				}
			}
			else if (this.ItemsSource != null)
			{
				this.EnsureDataManager();
				bool flag2 = this.SummaryDefinitionCollectionResolved.Count == 0;
				foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase3 in base.ColumnLayout.Columns.AllColumns)
				{
					global::Infragistics.Controls.Grids.Column column2 = columnBase3 as global::Infragistics.Controls.Grids.Column;
					if (column2 != null)
					{
						column2.IsInitialAutoSet = false;
						if (flag2)
						{
							column2.SummaryColumnSettings.RepopulateSummaryDefinitionCollection();
						}
					}
				}
			}
			if (base.ColumnLayout.Grid != null)
			{
				this.InvalidateGroupBy(false);
			}
		}

		// Token: 0x060015A9 RID: 5545 RVA: 0x00050E4C File Offset: 0x0004F04C
		internal void AttachDetachPropertyChanged(bool attach)
		{
			if (attach)
			{
				if (this.ItemsSource == null)
				{
					return;
				}
				using (global::System.Collections.IEnumerator enumerator = this.ItemsSource.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						global::System.ComponentModel.INotifyPropertyChanged notifyPropertyChanged = obj as global::System.ComponentModel.INotifyPropertyChanged;
						if (notifyPropertyChanged != null)
						{
							this.AttachDetachPropertyChanged(notifyPropertyChanged, true);
						}
					}
					return;
				}
			}
			this.DetachPropertyChanged();
		}

		// Token: 0x060015AA RID: 5546 RVA: 0x00050EC8 File Offset: 0x0004F0C8
		internal void AttachDetachPropertyChanged(global::System.ComponentModel.INotifyPropertyChanged propertyChangedDataObject, bool attach)
		{
			if (propertyChangedDataObject != null)
			{
				if (attach && this.GroupedColumn == null)
				{
					global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager> weakPropertyChangedHandler = new global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager>(this, propertyChangedDataObject, delegate(global::Infragistics.Controls.Grids.RowsManager instance, object s, global::System.ComponentModel.PropertyChangedEventArgs e)
					{
						instance.PropertyChangedDataObject_PropertyChanged(s, e);
					});
					propertyChangedDataObject.PropertyChanged += weakPropertyChangedHandler.OnEvent;
					if (!this._weakPropertyChangedHandlers.ContainsKey(propertyChangedDataObject))
					{
						this._weakPropertyChangedHandlers.Add(propertyChangedDataObject, weakPropertyChangedHandler);
						return;
					}
				}
				else if (!attach)
				{
					global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager> weakPropertyChangedHandler2 = null;
					if (this._weakPropertyChangedHandlers.TryGetValue(propertyChangedDataObject, out weakPropertyChangedHandler2) && weakPropertyChangedHandler2 != null)
					{
						weakPropertyChangedHandler2.Detach();
						this._weakPropertyChangedHandlers.Remove(propertyChangedDataObject);
					}
				}
			}
		}

		// Token: 0x060015AB RID: 5547 RVA: 0x00050F64 File Offset: 0x0004F164
		internal void DetachPropertyChanged()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager>> keyValuePair in ((global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager>>>)this._weakPropertyChangedHandlers))
			{
				global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager> value = keyValuePair.Value;
				if (value != null)
				{
					value.Detach();
				}
			}
			this._weakPropertyChangedHandlers.Clear();
		}

		// Token: 0x060015AC RID: 5548 RVA: 0x00050FC8 File Offset: 0x0004F1C8
		protected virtual void RegisterTopRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (!this.RegisteredTopRows.Contains(row))
			{
				if (row.IsStandAloneRow)
				{
					this._displayableRowCount++;
				}
				this.RegisteredTopRows.Add(row);
				this.RegisteredTopRows.Sort(this._fixedRowsOrderComparer);
			}
		}

		// Token: 0x060015AD RID: 5549 RVA: 0x00051018 File Offset: 0x0004F218
		protected virtual void RegisterBottomRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (!this.RegisteredBottomRows.Contains(row))
			{
				if (row.IsStandAloneRow)
				{
					this._displayableRowCount++;
				}
				this.RegisteredBottomRows.Add(row);
				this.RegisteredBottomRows.Sort(this._fixedRowsOrderComparer);
			}
		}

		// Token: 0x060015AE RID: 5550 RVA: 0x00051066 File Offset: 0x0004F266
		protected virtual void UnregisterTopRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row.IsStandAloneRow && this.RegisteredTopRows.Contains(row))
			{
				this._displayableRowCount--;
			}
			this.RegisteredTopRows.Remove(row);
		}

		// Token: 0x060015AF RID: 5551 RVA: 0x00051099 File Offset: 0x0004F299
		protected virtual void UnregisterBottomRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (row.IsStandAloneRow && this.RegisteredBottomRows.Contains(row))
			{
				this._displayableRowCount--;
			}
			this.RegisteredBottomRows.Remove(row);
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000510CC File Offset: 0x0004F2CC
		protected virtual void InvalidateHeaderRowVisibility()
		{
			if (base.ColumnLayout.HeaderVisibilityResolved == global::System.Windows.Visibility.Visible)
			{
				this.RegisterTopRow(this.HeaderRow);
				return;
			}
			this.UnregisterTopRow(this.HeaderRow);
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000510F4 File Offset: 0x0004F2F4
		protected virtual void InvalidateFooterRowVisibility()
		{
			if (base.ColumnLayout.FooterVisibilityResolved == global::System.Windows.Visibility.Visible)
			{
				this.RegisterBottomRow(this.FooterRow);
				return;
			}
			this.UnregisterBottomRow(this.FooterRow);
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x0005111C File Offset: 0x0004F31C
		protected virtual void InvalidateAddNewRowVisibility(bool generateNewData)
		{
			if (this.GroupByLevel != -1 || (this.ParentRow != null && this.ParentRow is global::Infragistics.Controls.Grids.Primitives.GroupByRow))
			{
				this.UnregisterTopRow(this.AddNewRowTop);
				this.UnregisterBottomRow(this.AddNewRowBottom);
				return;
			}
			global::Infragistics.Controls.Grids.AddNewRowSettingsOverride addNewRowSettings = base.ColumnLayout.AddNewRowSettings;
			switch (addNewRowSettings.AllowAddNewRowResolved)
			{
			case global::Infragistics.Controls.Grids.AddNewRowLocation.None:
				this.UnregisterTopRow(this.AddNewRowTop);
				this.UnregisterBottomRow(this.AddNewRowBottom);
				return;
			case global::Infragistics.Controls.Grids.AddNewRowLocation.Top:
				this.ResetAddNewRows(generateNewData);
				this.RegisterTopRow(this.AddNewRowTop);
				this.UnregisterBottomRow(this.AddNewRowBottom);
				return;
			case global::Infragistics.Controls.Grids.AddNewRowLocation.Bottom:
				this.ResetAddNewRows(generateNewData);
				this.RegisterBottomRow(this.AddNewRowBottom);
				this.UnregisterTopRow(this.AddNewRowTop);
				return;
			case global::Infragistics.Controls.Grids.AddNewRowLocation.Both:
				this.ResetAddNewRows(generateNewData);
				this.RegisterBottomRow(this.AddNewRowBottom);
				this.RegisterTopRow(this.AddNewRowTop);
				return;
			default:
				return;
			}
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x00051204 File Offset: 0x0004F404
		protected virtual void InvalidateSummaryRowVisibility()
		{
			if (this.GroupByLevel != -1)
			{
				this.UnregisterTopRow(this.SummaryRowTop);
				this.UnregisterBottomRow(this.SummaryRowBottom);
				return;
			}
			global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettings = base.ColumnLayout.SummaryRowSettings;
			switch (summaryRowSettings.AllowSummaryRowResolved)
			{
			case global::Infragistics.Controls.Grids.SummaryRowLocation.None:
				this.UnregisterTopRow(this.SummaryRowTop);
				this.UnregisterBottomRow(this.SummaryRowBottom);
				return;
			case global::Infragistics.Controls.Grids.SummaryRowLocation.Top:
				this.RegisterTopRow(this.SummaryRowTop);
				this.UnregisterBottomRow(this.SummaryRowBottom);
				return;
			case global::Infragistics.Controls.Grids.SummaryRowLocation.Bottom:
				this.UnregisterTopRow(this.SummaryRowTop);
				this.RegisterBottomRow(this.SummaryRowBottom);
				return;
			case global::Infragistics.Controls.Grids.SummaryRowLocation.Both:
				this.RegisterTopRow(this.SummaryRowTop);
				this.RegisterBottomRow(this.SummaryRowBottom);
				return;
			default:
				return;
			}
		}

		// Token: 0x060015B4 RID: 5556 RVA: 0x000512C0 File Offset: 0x0004F4C0
		protected virtual void InvalidateFilterRowVisibility(bool generateNewData)
		{
			if (this.GroupByLevel != -1)
			{
				this.UnregisterTopRow(this.FilterRowTop);
				this.UnregisterBottomRow(this.FilterRowBottom);
				return;
			}
			global::Infragistics.Controls.Grids.FilteringSettingsOverride filteringSettings = base.ColumnLayout.FilteringSettings;
			switch (filteringSettings.AllowFilteringResolved)
			{
			case global::Infragistics.Controls.Grids.FilterUIType.FilterRowTop:
				this.ResetFilterRows(generateNewData);
				this.RegisterTopRow(this.FilterRowTop);
				this.UnregisterBottomRow(this.FilterRowBottom);
				return;
			case global::Infragistics.Controls.Grids.FilterUIType.FilterRowBottom:
				this.ResetFilterRows(generateNewData);
				this.RegisterBottomRow(this.FilterRowBottom);
				this.UnregisterTopRow(this.FilterRowTop);
				return;
			default:
				this.UnregisterTopRow(this.FilterRowTop);
				this.UnregisterBottomRow(this.FilterRowBottom);
				return;
			}
		}

		// Token: 0x060015B5 RID: 5557 RVA: 0x0005136C File Offset: 0x0004F56C
		protected virtual void InvalidatePagerRowVisibility()
		{
			global::Infragistics.Controls.Grids.PagerSettingsOverride pagerSettings = base.ColumnLayout.PagerSettings;
			if (base.ColumnLayout.Grid != null && !base.ColumnLayout.Grid.PagerSettings.DisplayPagerWhenOnlyOnePage && this.PageCount <= 1)
			{
				this.UnregisterTopRow(this.PagerRowTop);
				this.UnregisterBottomRow(this.PagerRowBottom);
				return;
			}
			switch (pagerSettings.AllowPagingResolved)
			{
			case global::Infragistics.Controls.Grids.PagingLocation.None:
			case global::Infragistics.Controls.Grids.PagingLocation.Hidden:
				this.UnregisterTopRow(this.PagerRowTop);
				this.UnregisterBottomRow(this.PagerRowBottom);
				return;
			case global::Infragistics.Controls.Grids.PagingLocation.Top:
				this.RegisterTopRow(this.PagerRowTop);
				this.UnregisterBottomRow(this.PagerRowBottom);
				return;
			case global::Infragistics.Controls.Grids.PagingLocation.Bottom:
				this.RegisterBottomRow(this.PagerRowBottom);
				this.UnregisterTopRow(this.PagerRowTop);
				return;
			case global::Infragistics.Controls.Grids.PagingLocation.Both:
				this.RegisterBottomRow(this.PagerRowBottom);
				this.RegisterTopRow(this.PagerRowTop);
				return;
			default:
				return;
			}
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x00051450 File Offset: 0x0004F650
		protected virtual void ValidatePagerInformation()
		{
			if (this.Rows.Count == 0)
			{
				this.CurrentPageIndex = 1;
				return;
			}
			if (this.CurrentPageIndex > this.PageCount)
			{
				this.CurrentPageIndex = this.PageCount;
			}
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x00051484 File Offset: 0x0004F684
		protected virtual void InvalidateSort()
		{
			if (!this._deferInvalidatingSort)
			{
				global::Infragistics.DataManagerBase dataManager = this.DataManager;
				if (dataManager != null)
				{
					bool flag = false;
					global::Infragistics.Controls.Grids.SortedColumnsCollection sortedColumns = base.ColumnLayout.SortingSettings.SortedColumns;
					int count = sortedColumns.Count;
					int count2 = dataManager.Sort.Count;
					dataManager.Sort.Clear();
					global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
					if (dataManager.GroupByObject != null)
					{
						if (this.GroupedColumn.IsSorted != global::Infragistics.Controls.Grids.SortDirection.None)
						{
							dataManager.GroupBySortAscending = (this.GroupedColumn.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending);
						}
						else
						{
							this.GroupedColumn.SetSortedColumnStateInternally(dataManager.GroupBySortAscending ? global::Infragistics.Controls.Grids.SortDirection.Ascending : global::Infragistics.Controls.Grids.SortDirection.Descending, true);
						}
						flag = true;
						global::Infragistics.Controls.Grids.UnboundColumn unboundColumn = this.GroupedColumn as global::Infragistics.Controls.Grids.UnboundColumn;
						if (unboundColumn != null)
						{
							dataManager.GroupBySortContext = global::Infragistics.SortContext.CreateGenericSort(dataManager.CachedTypedInfo, dataManager.GroupBySortAscending, this.GroupedColumn.SortComparer, this.GroupedColumn.ValueConverter, this.GroupedColumn.ValueConverterParameter);
						}
						else
						{
							dataManager.GroupBySortContext = global::Infragistics.SortContext.CreateGenericSort(dataManager.CachedTypedInfo, this.GroupedColumn.Key, dataManager.GroupBySortAscending, this.GroupedColumn.AllowCaseSensitiveSort, this.GroupedColumn.SortComparer);
						}
						list.Add(this.GroupedColumn);
					}
					else if (dataManager.MergeDataContexts.Count > 0)
					{
						global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = base.ColumnLayout.Grid.GroupBySettings.GroupByColumns[base.ColumnLayout];
						int num = 0;
						foreach (global::Infragistics.Controls.Grids.Column column in readOnlyCollection)
						{
							global::Infragistics.MergedDataContext mergedDataContext = dataManager.MergeDataContexts[num];
							if (column.IsSorted != global::Infragistics.Controls.Grids.SortDirection.None)
							{
								mergedDataContext.SortAscending = (column.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending);
							}
							else
							{
								column.SetSortedColumnStateInternally(mergedDataContext.SortAscending ? global::Infragistics.Controls.Grids.SortDirection.Ascending : global::Infragistics.Controls.Grids.SortDirection.Descending, true);
							}
							flag = true;
							global::Infragistics.Controls.Grids.UnboundColumn unboundColumn2 = column as global::Infragistics.Controls.Grids.UnboundColumn;
							if (unboundColumn2 != null)
							{
								mergedDataContext.SortContext = global::Infragistics.SortContext.CreateGenericSort(dataManager.CachedTypedInfo, mergedDataContext.SortAscending, column.SortComparer, column.ValueConverter, column.ValueConverterParameter);
							}
							else
							{
								mergedDataContext.SortContext = global::Infragistics.SortContext.CreateGenericSort(dataManager.CachedTypedInfo, column.Key, mergedDataContext.SortAscending, column.AllowCaseSensitiveSort, column.SortComparer);
							}
							list.Add(column);
							num++;
						}
					}
					if (count > 0)
					{
						for (int i = 0; i < count; i++)
						{
							global::Infragistics.Controls.Grids.Column column2 = sortedColumns[i];
							if (!list.Contains(column2))
							{
								global::Infragistics.Controls.Grids.UnboundColumn unboundColumn3 = column2 as global::Infragistics.Controls.Grids.UnboundColumn;
								if (unboundColumn3 != null)
								{
									dataManager.Sort.Add(global::Infragistics.SortContext.CreateGenericSort(dataManager.CachedTypedInfo, column2.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending, column2.SortComparer, unboundColumn3.ValueConverter, unboundColumn3.ValueConverterParameter));
								}
								else
								{
									dataManager.Sort.Add(global::Infragistics.SortContext.CreateGenericSort(dataManager.CachedTypedInfo, column2.Key, column2.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending, column2.AllowCaseSensitiveSort, column2.SortComparer));
								}
							}
							flag = true;
						}
					}
					if (count2 != count)
					{
						flag = true;
					}
					if (flag)
					{
						dataManager.UpdateData();
					}
				}
			}
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000517B4 File Offset: 0x0004F9B4
		protected virtual void InvalidateFiltering()
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				dataManager.Filters = this.RowFiltersCollectionResolved;
				global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = base.ColumnLayout.Grid.CurrentEditCell as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
				if (!(base.ColumnLayout.Grid.CurrentEditRow is global::Infragistics.Controls.Grids.Primitives.FilterRow) && filterRowCell == null)
				{
					base.ColumnLayout.Grid.ExitEditMode(true);
				}
				this.InvalidatePager();
				global::Infragistics.Controls.Grids.XamGrid grid = base.ColumnLayout.Grid;
				if (grid.ConditionalFormattingSettings.AllowConditionalFormatting && grid.Panel != null)
				{
					grid.Panel.ResetDataRows();
				}
			}
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00051850 File Offset: 0x0004FA50
		protected virtual void InvalidateSummaries()
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				dataManager.SummaryExecution = base.ColumnLayout.SummaryRowSettings.SummaryExecutionResolved;
				dataManager.Summaries = this.SummaryDefinitionCollectionResolved;
				dataManager.SummaryResultCollection = this.SummaryResultCollectionInternal;
				base.ColumnLayout.Grid.ResetPanelRows();
				this.InvalidateRows();
			}
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x000518AC File Offset: 0x0004FAAC
		protected virtual void InvalidateConditionalFormatting()
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				if (base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting)
				{
					dataManager.ConditionalFormattingRules = this.ConditionalFormatProxyCollection.GenerateIRuleCollection();
				}
				else
				{
					dataManager.ConditionalFormattingRules = null;
				}
				dataManager.UpdateData();
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x000518FC File Offset: 0x0004FAFC
		protected internal virtual int ResolveGroupByLevel(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			int num = 0;
			if (this.ParentRow != null)
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = this.ParentRow.Manager as global::Infragistics.Controls.Grids.RowsManager;
				if (rowsManager != null && rowsManager.ColumnLayout == layout)
				{
					num += rowsManager.ResolveGroupByLevel(layout) + 1;
				}
			}
			return num;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00051940 File Offset: 0x0004FB40
		protected virtual void InvalidateGroupBy(bool reset)
		{
			if (base.ColumnLayout != null && this._dataManager != null)
			{
				this._supressCFUpdating = true;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = base.ColumnLayout.Grid.GroupBySettings.GroupByColumns[base.ColumnLayout];
				if (base.ColumnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.GroupByRows)
				{
					int num = (this.GroupByLevel == -1) ? this.ResolveGroupByLevel(base.ColumnLayout) : this.GroupByLevel;
					if (readOnlyCollection.Count > num)
					{
						global::Infragistics.Controls.Grids.Column column = readOnlyCollection[num];
						global::Infragistics.DataManagerBase dataManager = this.DataManager;
						if (this.GroupedColumn != column || (reset && dataManager != null))
						{
							if (this.GroupedColumn != null)
							{
								this.GroupByLevel = -1;
								if (!this.GroupedColumn.IsGroupBy)
								{
									this.GroupedColumn.SetSortedColumnStateInternally(global::Infragistics.Controls.Grids.SortDirection.None, true);
								}
								this.GroupedColumn = null;
								if (dataManager != null)
								{
									dataManager.GroupByObject = null;
								}
								if (!(base.ColumnLayout.Grid.ActiveCell is global::Infragistics.Controls.Grids.Primitives.FilterRowCell))
								{
									base.ColumnLayout.Grid.ActiveCell = null;
								}
								if (!this._deferClearGroupByCache)
								{
									foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Controls.Grids.Row> keyValuePair in this._cachedGroupByRows)
									{
										keyValuePair.Value.ChildRowsManager.UnregisterRowsManager(true, false, false);
									}
									this._cachedGroupByRows.Clear();
								}
							}
							this.GroupedColumn = column;
							this.GroupByLevel = num;
							if (dataManager != null)
							{
								dataManager.MergeDataContexts.Clear();
								if (this.GroupedColumn is global::Infragistics.Controls.Grids.UnboundColumn)
								{
									dataManager.GroupByObject = global::Infragistics.GroupByContext.CreateGenericCustomGroup(dataManager.CachedTypedInfo, this.GroupedColumn.GroupByComparer, this.GroupedColumn.ValueConverter, this.GroupedColumn.ValueConverterParameter);
								}
								else
								{
									dataManager.GroupByObject = global::Infragistics.GroupByContext.CreateGenericCustomGroup(dataManager.CachedTypedInfo, this.GroupedColumn.Key, this.GroupedColumn.GroupByComparer);
								}
								dataManager.GroupBySortAscending = true;
							}
							else
							{
								this.GroupedColumn = null;
							}
							this.FooterSupported = (this.HeaderSupported = false);
							base.OverrideHorizontalMax = -1.0;
							this.InvalidateSort();
							this.InvalidatePagerRowVisibility();
						}
					}
					else if (this.GroupByLevel != -1)
					{
						this.GroupByLevel = -1;
						if (this.GroupedColumn != null)
						{
							if (!this.GroupedColumn.IsGroupBy)
							{
								this.GroupedColumn.SetSortedColumnStateInternally(global::Infragistics.Controls.Grids.SortDirection.None, true);
							}
							this.GroupedColumn = null;
						}
						global::Infragistics.DataManagerBase dataManager2 = this.DataManager;
						if (dataManager2 != null)
						{
							dataManager2.GroupBySortContext = null;
							dataManager2.GroupByObject = null;
							dataManager2.UpdateData();
						}
						base.ColumnLayout.Grid.ActiveCell = null;
						if (!this._deferClearGroupByCache)
						{
							foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Controls.Grids.Row> keyValuePair2 in this._cachedGroupByRows)
							{
								keyValuePair2.Value.ChildRowsManager.UnregisterRowsManager(true, false, false);
							}
							this._cachedGroupByRows.Clear();
						}
						this.FooterSupported = (this.HeaderSupported = true);
						this.InvalidatePagerRowVisibility();
					}
				}
				else
				{
					bool flag = false;
					bool flag2 = false;
					global::Infragistics.DataManagerBase dataManager3 = this.DataManager;
					if (dataManager3 != null)
					{
						if (dataManager3.GroupByObject != null)
						{
							this.GroupByLevel = -1;
							this.GroupedColumn = null;
							dataManager3.GroupBySortContext = null;
							dataManager3.GroupByObject = null;
							flag2 = true;
						}
						foreach (global::Infragistics.MergedDataContext mergedDataContext in dataManager3.MergeDataContexts)
						{
							global::Infragistics.Controls.Grids.Column column2 = (global::Infragistics.Controls.Grids.Column)mergedDataContext.MergedObject;
							if (!column2.IsGroupBy)
							{
								column2.SetSortedColumnStateInternally(global::Infragistics.Controls.Grids.SortDirection.None, true);
							}
							flag = true;
						}
						dataManager3.MergeDataContexts.Clear();
						if (dataManager3.CachedType != null)
						{
							foreach (global::Infragistics.Controls.Grids.Column column3 in readOnlyCollection)
							{
								global::Infragistics.MergedDataContext mergedDataContext2;
								if (column3 is global::Infragistics.Controls.Grids.UnboundColumn)
								{
									mergedDataContext2 = global::Infragistics.MergedDataContext.CreateGenericCustomMerge(dataManager3.CachedTypedInfo, column3.GroupByComparer, column3.ValueConverter, column3.ValueConverterParameter);
								}
								else
								{
									mergedDataContext2 = global::Infragistics.MergedDataContext.CreateGenericCustomMerge(dataManager3.CachedTypedInfo, column3.Key, column3.GroupByComparer);
								}
								mergedDataContext2.MergedObject = column3;
								mergedDataContext2.SortAscending = true;
								dataManager3.MergeDataContexts.Add(mergedDataContext2);
								flag = false;
							}
						}
						this.InvalidateSort();
						if (flag || flag2)
						{
							dataManager3.UpdateData();
						}
					}
				}
				this._supressCFUpdating = false;
			}
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00051DFC File Offset: 0x0004FFFC
		protected internal virtual global::Infragistics.Controls.Grids.Row CreateItem(object data, global::Infragistics.DataManagerBase dataManager)
		{
			global::Infragistics.Controls.Grids.Row result = null;
			if (dataManager != null)
			{
				if (data == null)
				{
					throw new global::Infragistics.Controls.Grids.NullDataException();
				}
				if (!this._dataManager.CachedType.IsAssignableFrom(data.GetType()))
				{
					throw new global::Infragistics.Controls.Grids.DataTypeMismatchException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Infragistics.SRGrid.GetString("DataTypeMismatchExceptionVerbose"), new object[]
					{
						data.GetType(),
						dataManager.CachedType
					}));
				}
				result = new global::Infragistics.Controls.Grids.Row(-1, this, data);
			}
			return result;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00051E70 File Offset: 0x00050070
		protected internal virtual global::Infragistics.Controls.Grids.Row CreateItem()
		{
			global::Infragistics.Controls.Grids.Row result = null;
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				result = this.CreateItem(dataManager.GenerateNewObject(), dataManager);
			}
			return result;
		}

		// Token: 0x060015BF RID: 5567 RVA: 0x00051E98 File Offset: 0x00050098
		protected internal virtual global::Infragistics.Controls.Grids.Row CreateItem(object data)
		{
			return this.CreateItem(data, this.DataManager);
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00051EA8 File Offset: 0x000500A8
		protected internal virtual void InsertItem(int index, global::Infragistics.Controls.Grids.Row insertedObject)
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (insertedObject.ColumnLayout != base.ColumnLayout)
			{
				throw new global::Infragistics.Controls.Grids.ColumnLayoutException();
			}
			if (insertedObject.Manager != this)
			{
				insertedObject.Manager = this;
			}
			global::Infragistics.Controls.Grids.XamGrid grid = base.ColumnLayout.Grid;
			if (!grid.OnRowAdding(insertedObject, index))
			{
				this._supressInvalidateRows = true;
				dataManager.InsertRecord(index, insertedObject.Data);
				if (insertedObject.ChildRowsManager != null)
				{
					insertedObject.ChildRowsManager.ColumnLayout = base.ColumnLayout;
				}
				if (!this._cachedRows.ContainsKey(insertedObject.Data))
				{
					this._cachedRows.Add(insertedObject.Data, insertedObject);
				}
				if (!this._rowObjectCache.Contains(insertedObject))
				{
					this._rowObjectCache.Add(insertedObject);
				}
				this._supressInvalidateRows = false;
				this.InvalidateRows();
				insertedObject = (global::Infragistics.Controls.Grids.Row)this.Rows[index];
				grid.OnRowAdded(insertedObject);
				if (base.ColumnLayout.Grid != null)
				{
					base.ColumnLayout.Grid.InvalidateScrollPanel(true, false);
				}
			}
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x00051FAC File Offset: 0x000501AC
		protected internal virtual void AddItem(global::Infragistics.Controls.Grids.Row addedObject)
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (addedObject.ColumnLayout != base.ColumnLayout)
			{
				throw new global::Infragistics.Controls.Grids.ColumnLayoutException();
			}
			if (addedObject.Manager != this)
			{
				addedObject.Manager = this;
			}
			global::Infragistics.Controls.Grids.XamGrid grid = base.ColumnLayout.Grid;
			if (!grid.OnRowAdding(addedObject, dataManager.RecordCount))
			{
				this._supressInvalidateRows = true;
				dataManager.AddRecord(addedObject.Data);
				if (addedObject.ChildRowsManager != null)
				{
					addedObject.ChildRowsManager.ColumnLayout = base.ColumnLayout;
				}
				if (!this._cachedRows.ContainsKey(addedObject.Data))
				{
					this._cachedRows.Add(addedObject.Data, addedObject);
				}
				if (!this._rowObjectCache.Contains(addedObject))
				{
					this._rowObjectCache.Add(addedObject);
				}
				this._supressInvalidateRows = false;
				this.InvalidateRows();
				int num = dataManager.ResolveIndexForRecord(addedObject.Data);
				if (num != -1)
				{
					addedObject = (global::Infragistics.Controls.Grids.Row)this.Rows[num];
				}
				grid.OnRowAdded(addedObject);
				if (base.ColumnLayout.Grid != null)
				{
					base.ColumnLayout.Grid.InvalidateScrollPanel(true, false);
				}
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x000520C5 File Offset: 0x000502C5
		protected bool RemoveItem(global::Infragistics.Controls.Grids.Row removedObject)
		{
			return this.RemoveItem(removedObject, true, this.DataManager);
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x000520D8 File Offset: 0x000502D8
		protected virtual bool RemoveItem(global::Infragistics.Controls.Grids.Row removedObject, bool invalidate, global::Infragistics.DataManagerBase manager)
		{
			if (removedObject == null)
			{
				return false;
			}
			if (removedObject.ParentRow is global::Infragistics.Controls.Grids.Primitives.GroupByRow)
			{
				global::Infragistics.Controls.Grids.RowBase parentRow = removedObject.ParentRow;
				global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase = null;
				while (parentRow is global::Infragistics.Controls.Grids.Primitives.GroupByRow)
				{
					rowsManagerBase = parentRow.Manager;
					parentRow = rowsManagerBase.ParentRow;
				}
				global::Infragistics.Controls.Grids.RowsManager rowsManager = rowsManagerBase as global::Infragistics.Controls.Grids.RowsManager;
				if (rowsManager != null)
				{
					manager = rowsManager.DataManager;
				}
			}
			global::Infragistics.Controls.Grids.XamGrid grid = base.ColumnLayout.Grid;
			if (grid.OnRowDeleting(removedObject))
			{
				return false;
			}
			if ((grid.CurrentEditCell != null && grid.CurrentEditCell.Row == removedObject) || grid.CurrentEditRow == removedObject)
			{
				grid.ExitEditModeInternal(true, global::Infragistics.Controls.Grids.ExitEditModeBehavior.Forceful);
			}
			this._deferItemSourceInvalidation = true;
			manager.RemoveRecord(removedObject.Data);
			this._deferItemSourceInvalidation = false;
			grid.OnRowDeleted(removedObject);
			if (removedObject.ChildRowsManager != null)
			{
				removedObject.ChildRowsManager.ColumnLayout = null;
			}
			this._cachedRows.Remove(removedObject.Data);
			if (invalidate)
			{
				this.InvalidateItemSource(true, true, true);
			}
			return true;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x000521C0 File Offset: 0x000503C0
		protected virtual void RemoveRange(global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row> itemsToRemove)
		{
			if (itemsToRemove == null || itemsToRemove.Count == 0)
			{
				return;
			}
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			foreach (global::Infragistics.Controls.Grids.Row row in itemsToRemove)
			{
				if (row.CanBeDeleted)
				{
					this.RemoveItem(row, false, dataManager);
				}
			}
			this.InvalidateItemSource(true, true, true);
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x00052230 File Offset: 0x00050430
		protected override void InvalidateData()
		{
			bool flag = true;
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				if (!dataManager.Defer)
				{
					dataManager.Defer = true;
				}
				else
				{
					flag = false;
				}
				dataManager.Reset();
				if (this.Level == 0 && this.ParentRow != null && this.ParentRow.RowType == global::Infragistics.Controls.Grids.RowType.GroupByRow)
				{
					dataManager.CachedTypedInfo = ((global::Infragistics.Controls.Grids.RowsManager)this.ParentRow.Manager).DataManager.CachedTypedInfo;
				}
			}
			this.InvalidateGroupBy(true);
			this.InvalidateSort();
			this.InvalidateFiltering();
			this.InvalidateConditionalFormatting();
			this.InvalidatePager();
			if (dataManager != null)
			{
				if (flag)
				{
					dataManager.Defer = false;
				}
				dataManager.UpdateData();
				if (!dataManager.SupportsChangeNotification)
				{
					this.InvalidateRows();
					this.InvalidatePagerRowVisibility();
				}
			}
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x000522E8 File Offset: 0x000504E8
		internal global::System.Threading.Tasks.Task<global::System.Collections.IList> GetDistinctItemsForColumn(global::Infragistics.Controls.Grids.CellBase cellBase, bool respectPreviousFilters, global::System.Threading.CancellationToken token)
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			bool filterCaseSensitive = cellBase.Column.FilterColumnSettings.FilterCaseSensitive;
			global::Infragistics.CachedTypedInfo cachedTypedInfo = dataManager.CachedTypedInfo;
			string key = cellBase.Column.Key;
			bool sortAscending = true;
			bool fromDateColumn = cellBase.Column is global::Infragistics.Controls.Grids.DateColumnBase;
			global::Infragistics.InformationContext informationContext = global::Infragistics.InformationContext.CreateGenericInformationContext(cachedTypedInfo, key, sortAscending, filterCaseSensitive, null, fromDateColumn);
			global::System.Threading.Tasks.Task<global::System.Collections.IList> distinctValuesAsync;
			if (respectPreviousFilters && dataManager.SortedFilteredList != null)
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = cellBase.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
				global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollectionResolved = rowsManager.RowFiltersCollectionResolved;
				global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowFiltersCollectionResolved[cellBase.Column.Key];
				bool flag = rowsFilter != null && rowsFilter.Conditions.Count > 0;
				if (flag && rowsFilter.Conditions.Count > 0)
				{
					global::Infragistics.Controls.Grids.RowFiltersCollection rowFiltersCollection = new global::Infragistics.Controls.Grids.RowFiltersCollection();
					foreach (global::Infragistics.IRecordFilter recordFilter in rowFiltersCollectionResolved)
					{
						if (recordFilter != rowsFilter)
						{
							rowFiltersCollection.Add(recordFilter);
						}
					}
					global::System.Collections.IList list = dataManager.FilterItems(dataManager.OriginalDataSource, rowFiltersCollection);
					distinctValuesAsync = informationContext.GetDistinctValuesAsync(list, token, true);
				}
				else
				{
					distinctValuesAsync = informationContext.GetDistinctValuesAsync(dataManager.SortedFilteredList, token, true);
				}
			}
			else
			{
				distinctValuesAsync = informationContext.GetDistinctValuesAsync(dataManager.OriginalDataSource, token, true);
			}
			return distinctValuesAsync;
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x00052444 File Offset: 0x00050644
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> GetRowScopedConditions()
		{
			return this.ConditionalFormatProxyCollection.GetRowScopedConditions();
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00052451 File Offset: 0x00050651
		public override global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> GetCellScopedConditions(string columnKey)
		{
			return this.ConditionalFormatProxyCollection.GetCellScopedConditionsForKey(columnKey);
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x0005245F File Offset: 0x0005065F
		protected virtual void ResetRows()
		{
			this._rowObjectCache.Clear();
			this.CachedRows.Clear();
			this.InvalidateRows();
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x0005247D File Offset: 0x0005067D
		protected virtual void OnCurrentItemChanged(object data)
		{
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060015CB RID: 5579 RVA: 0x0005247F File Offset: 0x0005067F
		public override global::Infragistics.Controls.Grids.Primitives.RowBaseCollection Rows
		{
			get
			{
				if (this._rowBaseCollection == null)
				{
					this._rowBaseCollection = new global::Infragistics.Controls.Grids.Primitives.RowBaseCollection(this._rows);
				}
				return this._rowBaseCollection;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x000524A0 File Offset: 0x000506A0
		protected internal override int FullRowCount
		{
			get
			{
				int num = 0;
				if (base.ColumnLayout != null)
				{
					if (this.ParentRow != null && base.ColumnLayout.InternalTemplate != null)
					{
						num = 1;
					}
					else
					{
						num = this.DataCount;
						if ((num > 0 || this.ChildrenShouldBeDisplayedResolved) && base.ColumnLayout.Visibility == global::System.Windows.Visibility.Visible)
						{
							if (this.HeaderSupported)
							{
								num += this.RegisteredTopRows.Count;
							}
							if (this.FooterSupported)
							{
								num += this.RegisteredBottomRows.Count;
							}
						}
						else
						{
							num = 0;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00052524 File Offset: 0x00050724
		protected internal override global::Infragistics.Controls.Grids.RowBase ResolveRowForIndex(int index)
		{
			if (this.ParentRow != null && base.ColumnLayout.InternalTemplate != null)
			{
				if (this._columnLayoutTemplateRow == null)
				{
					this._columnLayoutTemplateRow = new global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateRow(this, this.ParentRow.Data);
				}
				return this._columnLayoutTemplateRow;
			}
			if (index < 0 || index > this.FullRowCount - 1)
			{
				return null;
			}
			if (this.HeaderSupported && index < this.RegisteredTopRows.Count)
			{
				return this.RegisteredTopRows[index];
			}
			if (this.FooterSupported)
			{
				int fullRowCount = this.FullRowCount;
				int num = fullRowCount - this.RegisteredBottomRows.Count;
				if (index >= num)
				{
					return this.RegisteredBottomRows[fullRowCount - index - 1];
				}
				index -= this.RegisteredTopRows.Count;
			}
			return this.Rows[index];
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x000525F0 File Offset: 0x000507F0
		protected internal override int ResolveIndexForRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			int num;
			if (this.HeaderSupported)
			{
				num = this.RegisteredTopRows.IndexOf(row);
				if (num != -1)
				{
					return num;
				}
			}
			if (this.FooterSupported)
			{
				num = this.RegisteredBottomRows.IndexOf(row);
				if (num != -1)
				{
					int num2 = this.RegisteredBottomRows.Count - 1;
					int num3 = this.Rows.Count;
					if (this.HeaderSupported)
					{
						num3 += this.RegisteredTopRows.Count;
					}
					return num2 - num + num3;
				}
			}
			int num4 = this.HeaderSupported ? this.RegisteredTopRows.Count : 0;
			num = this.Rows.IndexOf((global::Infragistics.Controls.Grids.Row)row) + num4;
			if (num < 0)
			{
				num = row.Index;
			}
			if (num < 0)
			{
				num = 0;
			}
			return num;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x000526A8 File Offset: 0x000508A8
		protected override int CompareTo(global::Infragistics.Controls.Grids.RowsManagerBase other)
		{
			int num = this.ParentRow.Manager.ColumnLayout.Columns.IndexOf(this.ParentRow.ColumnLayout);
			int num2 = other.ParentRow.Manager.ColumnLayout.Columns.IndexOf(other.ParentRow.ColumnLayout);
			if (num == num2)
			{
				int index = this.ParentRow.Index;
				int index2 = other.ParentRow.Index;
				return index.CompareTo(index2);
			}
			return num.CompareTo(num2);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00052730 File Offset: 0x00050930
		protected override void OnColumnLayoutPropertyChanged(global::Infragistics.Controls.Grids.ColumnLayout layout, string propertyName)
		{
			base.OnColumnLayoutPropertyChanged(layout, propertyName);
			switch (propertyName)
			{
			case "SummaryScope":
				if (base.ColumnLayout != null)
				{
					base.ColumnLayout.SummaryRowSettings.SummaryDefinitionCollection.Clear();
				}
				this.SummaryDefinitionCollection.Clear();
				break;
			case "HeaderVisibility":
				this.InvalidateHeaderRowVisibility();
				break;
			case "FooterVisibility":
				this.InvalidateFooterRowVisibility();
				break;
			case "SortingInvalidated":
				this.InvalidateSort();
				break;
			case "PagerLocation":
				this.InvalidatePagerRowVisibility();
				break;
			case "AllowPaging":
				this.InvalidatePagerRowVisibility();
				break;
			case "PageSize":
				if (base.ColumnLayout != null)
				{
					global::Infragistics.DataManagerBase dataManager = this.DataManager;
					if (dataManager != null)
					{
						dataManager.PageSize = base.ColumnLayout.PagerSettings.PageSizeResolved;
					}
				}
				this.CurrentPageIndex = 1;
				break;
			case "GroupByInvalidated":
				this.InvalidateGroupBy(false);
				break;
			case "GroupByInvalidatedReset":
				this.InvalidateGroupBy(true);
				break;
			case "AddNewRowSettings":
			case "AllowAddNewRow":
				this.InvalidateAddNewRowVisibility(true);
				break;
			case "FilteringSettings":
			case "AllowFiltering":
				this.InvalidateFilterRowVisibility(true);
				break;
			case "AllowSummaryRow":
				this.InvalidateSummaryRowVisibility();
				break;
			case "FilteringInvalidated":
				this.InvalidateFiltering();
				this.InvalidatePager();
				break;
			case "ColumnLayoutFilteringInvalidated":
				this.InvalidateFiltering();
				this.InvalidatePager();
				break;
			case "InvalidateSummaries":
				this.InvalidateSummaries();
				break;
			case "SummaryExecution":
				if (this._dataManager != null && base.ColumnLayout != null)
				{
					this._dataManager.SummaryExecution = base.ColumnLayout.SummaryRowSettings.SummaryExecutionResolved;
					this.InvalidateRows();
				}
				break;
			case "ClearFilterProxies":
				this.ConditionalFormatProxyCollection.Clear();
				break;
			case "InvalidateConditionalFormatting":
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && !base.ColumnLayout.Grid.SuspendConditionalFormatUpdates)
				{
					if (this.DataManager != null)
					{
						this.DataManager.SuspendInvalidateDataSource = true;
					}
					this.BuildConditionalFormats();
					this.InvalidateData();
					if (this.DataManager != null)
					{
						this.DataManager.SuspendInvalidateDataSource = false;
					}
					if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
					{
						global::Infragistics.Controls.Grids.Primitives.RowsPanel panel = base.ColumnLayout.Grid.Panel;
						if (panel != null && !panel.InLayoutPhase)
						{
							base.ColumnLayout.Grid.ResetPanelRows(true);
						}
					}
				}
				break;
			case "ConditionalFormatRule":
				if (this.DataManager != null)
				{
					this.DataManager.SuspendInvalidateDataSource = true;
				}
				this.BuildConditionalFormats();
				this.InvalidateData();
				if (this.DataManager != null)
				{
					this.DataManager.SuspendInvalidateDataSource = false;
				}
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					base.ColumnLayout.Grid.ResetPanelRows();
				}
				break;
			case "ClearCachedRows":
				this.ResetRows();
				break;
			case "RefreshSummaryRowVisual":
				this.InvalidateSummaryRowsVisual();
				break;
			case "AllowConditionalFormatting":
				this.AttachDetachPropertyChanged(base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting);
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null && !base.ColumnLayout.Grid.SuspendConditionalFormatUpdates)
				{
					bool flag = true;
					if (this.DataManager != null)
					{
						if (!this.DataManager.Defer)
						{
							this.DataManager.Defer = true;
						}
						else
						{
							flag = false;
						}
					}
					this.BuildConditionalFormats();
					if (flag && this.DataManager != null)
					{
						this.DataManager.Defer = false;
					}
					this.InvalidateData();
					if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
					{
						base.ColumnLayout.Grid.ResetPanelRows(true);
					}
				}
				break;
			}
			base.ColumnLayout.Grid.InvalidateScrollPanel(true);
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00052C5C File Offset: 0x00050E5C
		protected override void OnColumnLayoutAssigned(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			base.OnColumnLayoutAssigned(layout);
			this.InvalidateTopAndBottomRows();
			this.BuildConditionalFormats();
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00052C74 File Offset: 0x00050E74
		protected override void OnChildColumnLayoutRemoved(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			bool flag = false;
			for (int i = base.VisibleChildManagers.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Grids.ChildBandRowsManager childBandRowsManager = base.VisibleChildManagers[i] as global::Infragistics.Controls.Grids.ChildBandRowsManager;
				if (childBandRowsManager != null)
				{
					int num = 0;
					foreach (object obj in childBandRowsManager.Rows)
					{
						global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = (global::Infragistics.Controls.Grids.Primitives.ChildBand)obj;
						if (childBand.ResolveIsVisible)
						{
							num++;
							flag = true;
							break;
						}
					}
					for (int j = childBandRowsManager.VisibleChildManagers.Count - 1; j >= 0; j--)
					{
						global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase = childBandRowsManager.VisibleChildManagers[j];
						if (rowsManagerBase.ColumnLayout == layout)
						{
							childBandRowsManager.UnregisterChildRowsManager(rowsManagerBase);
						}
					}
					if (childBandRowsManager.VisibleChildManagers.Count == 0 && !flag)
					{
						base.UnregisterChildRowsManager(childBandRowsManager);
					}
					if (num == 1 && base.ColumnLayout.ColumnLayoutHeaderVisibilityResolved != global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility.Always)
					{
						flag = false;
					}
				}
			}
			this.InvalidateRows(!flag);
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x00052D8C File Offset: 0x00050F8C
		protected override void OnChildColumnLayoutVisibilityChanged(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			if (layout.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				this.OnChildColumnLayoutRemoved(layout);
				return;
			}
			for (int i = base.VisibleChildManagers.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Grids.ChildBandRowsManager childBandRowsManager = base.VisibleChildManagers[i] as global::Infragistics.Controls.Grids.ChildBandRowsManager;
				if (childBandRowsManager != null)
				{
					foreach (object obj in childBandRowsManager.Rows)
					{
						global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = (global::Infragistics.Controls.Grids.Primitives.ChildBand)obj;
						if (childBand.ColumnLayout == layout)
						{
							if (childBand.IsExpanded)
							{
								childBandRowsManager.RegisterChildRowsManager(childBand.ChildRowsManager);
								break;
							}
							break;
						}
					}
				}
			}
			this.InvalidateRows();
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00052E44 File Offset: 0x00051044
		public override void InvalidateRows()
		{
			this.InvalidateRows(true);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00052E4D File Offset: 0x0005104D
		private void InvalidateRows(bool unregister)
		{
			if (!this._supressInvalidateRows)
			{
				if (unregister)
				{
					base.UnregisterAllChildRowsManager();
					this.ClearRows();
				}
				if (base.ColumnLayout != null && base.ColumnLayout.Grid != null)
				{
					base.ColumnLayout.Grid.InvalidateScrollPanel(true, false);
				}
			}
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00052E8D File Offset: 0x0005108D
		public virtual void InvalidateTopAndBottomRows()
		{
			this.InvalidateHeaderRowVisibility();
			this.InvalidateFooterRowVisibility();
			this.InvalidatePagerRowVisibility();
			this.InvalidateAddNewRowVisibility(false);
			this.InvalidateFilterRowVisibility(false);
			this.InvalidateSummaryRowVisibility();
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00052EB8 File Offset: 0x000510B8
		private void InvalidatePager()
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				global::Infragistics.Controls.Grids.Primitives.PagerCell pagerCell = this.PagerRowBottom.Cells[0] as global::Infragistics.Controls.Grids.Primitives.PagerCell;
				if (pagerCell != null && pagerCell.Control != null)
				{
					global::Infragistics.Controls.Grids.Primitives.PagerControlBase pagerControl = ((global::Infragistics.Controls.Grids.Primitives.PagerCellControl)pagerCell.Control).PagerControl;
					int pageCount = dataManager.PageCount;
					if (pagerControl.TotalPages > pageCount)
					{
						pagerControl.TotalPages = pageCount;
						this.CurrentPageIndex = 1;
					}
					pagerControl.InvalidateItems();
				}
				pagerCell = (this.PagerRowTop.Cells[0] as global::Infragistics.Controls.Grids.Primitives.PagerCell);
				if (pagerCell != null && pagerCell.Control != null)
				{
					global::Infragistics.Controls.Grids.Primitives.PagerControlBase pagerControl2 = ((global::Infragistics.Controls.Grids.Primitives.PagerCellControl)pagerCell.Control).PagerControl;
					int pageCount2 = dataManager.PageCount;
					if (pagerControl2.TotalPages != pageCount2)
					{
						pagerControl2.TotalPages = pageCount2;
					}
					pagerControl2.InvalidateItems();
				}
			}
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00052F80 File Offset: 0x00051180
		protected internal override void UnregisterRowsManager(bool removeColumnLayout, bool clearChildRowsManager, bool clearSelection)
		{
			this.AttachDetachPropertyChanged(false);
			this.UnhookDataManager(clearChildRowsManager, clearSelection, true);
			base.UnregisterRowsManager(removeColumnLayout, clearChildRowsManager, clearSelection);
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00052F9B File Offset: 0x0005119B
		private void InvalidateSummaryRowsVisual()
		{
			this.InvalidateSummaryRowVisualHelper(this._summaryRowBottom);
			this.InvalidateSummaryRowVisualHelper(this._summaryRowTop);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00052FB8 File Offset: 0x000511B8
		private void InvalidateSummaryRowVisualHelper(global::Infragistics.Controls.Grids.Primitives.SummaryRow sr)
		{
			if (sr != null && base.ColumnLayout != null)
			{
				global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> dataColumns = base.ColumnLayout.Columns.DataColumns;
				foreach (global::Infragistics.Controls.Grids.Column column in dataColumns)
				{
					sr.Cells[column].Refresh();
				}
			}
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00053028 File Offset: 0x00051228
		public override void RefreshSummaries()
		{
			base.RefreshSummaries();
			this.DataManager.RefreshSummaries();
			if (this._summaryRowBottom != null)
			{
				this._summaryRowBottom.InvalidateRow();
			}
			if (this._summaryRowTop != null)
			{
				this._summaryRowTop.InvalidateRow();
			}
			if (this.ParentRow != null && this.ParentRow.RowType == global::Infragistics.Controls.Grids.RowType.GroupByRow)
			{
				global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)this.ParentRow.Manager;
				if (rowsManager.GroupedColumn.GroupByItemTemplate != null)
				{
					((global::Infragistics.Controls.Grids.Primitives.GroupByRow)this.ParentRow).GroupByData.Reload();
					base.ColumnLayout.Grid.ResetPanelRows();
				}
			}
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x000530C5 File Offset: 0x000512C5
		internal void ClearRows()
		{
			this.Rows.Clear();
			this._duplicateObjectValidator.Clear();
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x000530E0 File Offset: 0x000512E0
		protected override void OnColumnLayoutReset()
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				dataManager.DataSource = null;
			}
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00053100 File Offset: 0x00051300
		protected override void Dispose(bool disposing)
		{
			if (this._rows != null)
			{
				this._rows.Dispose();
			}
			if (this._headerRow != null)
			{
				this._headerRow.Dispose();
			}
			if (this._footerRow != null)
			{
				this._footerRow.Dispose();
			}
			if (this._cachedRows != null)
			{
				this._cachedRows.Clear();
			}
			if (this._rowObjectCache != null)
			{
				this._rowObjectCache.Clear();
			}
			if (this._topPagerRow != null)
			{
				this._topPagerRow.Dispose();
				this._topPagerRow = null;
			}
			if (this._bottomPagerRow != null)
			{
				this._bottomPagerRow.Dispose();
				this._bottomPagerRow = null;
			}
			if (this._addNewRowBottom != null)
			{
				this._addNewRowBottom.Dispose();
				this._addNewRowBottom = null;
			}
			if (this._addNewRowTop != null)
			{
				this._addNewRowTop.Dispose();
				this._addNewRowTop = null;
			}
			if (this._filterRowTop != null)
			{
				this._filterRowTop.Dispose();
				this._filterRowTop = null;
			}
			if (this._filterRowBottom != null)
			{
				this._filterRowBottom.Dispose();
				this._filterRowBottom = null;
			}
			if (this._summaryRowTop != null)
			{
				this._summaryRowTop.Dispose();
				this._summaryRowTop = null;
			}
			if (this._summaryRowBottom != null)
			{
				this._summaryRowBottom.Dispose();
				this._summaryRowBottom = null;
			}
			if (this._rowFiltersCollection != null)
			{
				this._rowFiltersCollection.PropertyChanged -= this.RowFiltersCollection_PropertyChanged;
				this._rowFiltersCollection.CollectionChanged -= this.RowFiltersCollection_CollectionChanged;
				this._rowFiltersCollection.CollectionItemChanged -= this.RowFiltersCollection_CollectionItemChanged;
				this._rowFiltersCollection.Dispose();
				this._rowFiltersCollection = null;
			}
			if (this._columnLayoutTemplateRow != null)
			{
				this._columnLayoutTemplateRow.Dispose();
			}
			if (this._summaryDefinitionCollection != null)
			{
				this._summaryDefinitionCollection.Dispose();
			}
			if (this._summaryResultCollection != null)
			{
				this._summaryResultCollection.Dispose();
			}
			if (this._conditionalFormatProxyCollection != null)
			{
				this._conditionalFormatProxyCollection.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x000532EE File Offset: 0x000514EE
		int global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.DataCount
		{
			get
			{
				return this.DataCount;
			}
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x000532F6 File Offset: 0x000514F6
		global::Infragistics.Controls.Grids.Row global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.GetDataItem(int index)
		{
			return this.GetDataItem(index);
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x000532FF File Offset: 0x000514FF
		global::Infragistics.Controls.Grids.Row global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.CreateItem()
		{
			return this.CreateItem();
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00053307 File Offset: 0x00051507
		global::Infragistics.Controls.Grids.Row global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.CreateItem(object dataObject)
		{
			return this.CreateItem(dataObject);
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00053310 File Offset: 0x00051510
		bool global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.RemoveItem(global::Infragistics.Controls.Grids.Row removedObject)
		{
			return this.RemoveItem(removedObject);
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00053319 File Offset: 0x00051519
		void global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.AddItem(global::Infragistics.Controls.Grids.Row addedObject)
		{
			this.AddItem(addedObject);
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00053322 File Offset: 0x00051522
		void global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.InsertItem(int index, global::Infragistics.Controls.Grids.Row addedObject)
		{
			this.InsertItem(index, addedObject);
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x0005332C File Offset: 0x0005152C
		void global::Infragistics.IProvideDataItems<global::Infragistics.Controls.Grids.Row>.RemoveRange(global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Row> itemsToRemove)
		{
			this.RemoveRange(itemsToRemove);
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00053338 File Offset: 0x00051538
		private void DataManager_NewObjectGeneration(object sender, global::Infragistics.HandleableObjectGenerationEventArgs e)
		{
			global::Infragistics.Controls.Grids.RowBase parentRow = this.ParentRow;
			while (parentRow != null && !(parentRow is global::Infragistics.Controls.Grids.Row))
			{
				global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = parentRow as global::Infragistics.Controls.Grids.Primitives.ChildBand;
				if (childBand != null)
				{
					parentRow = childBand.ParentRow;
				}
			}
			base.ColumnLayout.Grid.OnDataObjectRequested(e, base.ColumnLayout, parentRow as global::Infragistics.Controls.Grids.Row, this._newDataObjectRowType);
			this._newDataObjectRowType = null;
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x000533B0 File Offset: 0x000515B0
		private void DataManager_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			bool allowConditionalFormatting = base.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting;
			if (!this._deferItemSourceInvalidation)
			{
				bool invalidateSelection = true;
				bool invalidateSort = true;
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
				{
					invalidateSelection = false;
					invalidateSort = false;
				}
				else if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
				{
					invalidateSelection = false;
					foreach (object obj in e.OldItems)
					{
						if (obj != null)
						{
							invalidateSelection = true;
							break;
						}
					}
					invalidateSort = false;
				}
				if (this.GroupByLevel != -1)
				{
					base.ColumnLayout.Grid.ResetPanelRows(false);
				}
				this.InvalidateItemSource(true, invalidateSelection, invalidateSort);
			}
			bool flag = false;
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
			{
				global::Infragistics.Controls.Grids.RowBase rowBase = base.ColumnLayout.Grid.CurrentEditRow;
				global::Infragistics.Controls.Grids.Cell currentEditCell = base.ColumnLayout.Grid.CurrentEditCell;
				if (rowBase == null && currentEditCell != null)
				{
					rowBase = currentEditCell.Row;
				}
				using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						this.AttachDetachPropertyChanged(obj2 as global::System.ComponentModel.INotifyPropertyChanged, false);
						if (obj2 != null && this._cachedRows.ContainsKey(obj2))
						{
							global::Infragistics.Controls.Grids.Row item = this._cachedRows[obj2];
							this._rowObjectCache.Remove(item);
							this._cachedRows.Remove(obj2);
						}
						if (rowBase != null && object.Equals(obj2, rowBase.Data))
						{
							flag = true;
						}
					}
					goto IL_2D3;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				if (!allowConditionalFormatting)
				{
					goto IL_2D3;
				}
				using (global::System.Collections.IEnumerator enumerator3 = e.NewItems.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						object obj3 = enumerator3.Current;
						this.AttachDetachPropertyChanged(obj3 as global::System.ComponentModel.INotifyPropertyChanged, true);
					}
					goto IL_2D3;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this.DetachPropertyChanged();
				if (allowConditionalFormatting)
				{
					this.AttachDetachPropertyChanged(true);
				}
				global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Grids.Row> dictionary = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Grids.Row>();
				foreach (object obj4 in this.ItemsSource)
				{
					if (obj4 != null && this._cachedRows.ContainsKey(obj4))
					{
						dictionary.Add(obj4, this._cachedRows[obj4]);
					}
				}
				this._cachedRows.Clear();
				this._rowObjectCache.Clear();
				foreach (global::System.Collections.Generic.KeyValuePair<object, global::Infragistics.Controls.Grids.Row> keyValuePair in dictionary)
				{
					this._cachedRows.Add(keyValuePair.Key, keyValuePair.Value);
					this._rowObjectCache.Add(keyValuePair.Value);
				}
				flag = true;
			}
			IL_2D3:
			if (allowConditionalFormatting && !this._supressCFUpdating)
			{
				bool flag2 = false;
				foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRule conditionalFormattingRule in this.ConditionalFormattingRulesResolved)
				{
					if (conditionalFormattingRule.ShouldRefreshOnDataChange && conditionalFormattingRule.RuleExecution != global::Infragistics.EvaluationStage.None)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					base.ColumnLayout.Grid.NeedConditionalFormatUpdate = true;
					if (!base.ColumnLayout.Grid.SuspendConditionalFormatUpdates)
					{
						global::System.Windows.DependencyObject control = global::Infragistics.PlatformProxy.GetFocusedElement(base.ColumnLayout.Grid) as global::System.Windows.DependencyObject;
						bool flag3 = base.ColumnLayout.Grid.IsDependancyObjectInsideGrid(control);
						base.ColumnLayout.InvalidateConditionalFormatting();
						if (flag3)
						{
							base.ColumnLayout.Grid.Focus();
						}
					}
				}
			}
			if (flag)
			{
				base.ColumnLayout.Grid.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					base.ColumnLayout.Grid.ExitEditModeInternal(true, global::Infragistics.Controls.Grids.ExitEditModeBehavior.Forceful);
				}), new object[0]);
			}
			base.ColumnLayout.Grid.CloseOpenHeaderDropDownControl();
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				base.ColumnLayout.Grid.ResetPanelRows(false);
			}
			if (allowConditionalFormatting)
			{
				this._weakPropertyChangedHandlers.Compact(false);
			}
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00053818 File Offset: 0x00051A18
		private void ItemsSource_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._isInitializingDataManager)
			{
				return;
			}
			this._isInitializingDataManager = true;
			base.ColumnLayout.Grid.Dispatcher.BeginInvoke(new global::System.Action(this.InitializeDataManagerOnEmptyCollectionChanged), new object[0]);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00053854 File Offset: 0x00051A54
		private void DataManager_ResolvingData(object sender, global::Infragistics.DataAcquisitionEventArgs e)
		{
			global::Infragistics.Controls.Grids.DataLimitingEventArgs dataLimitingEventArgs = new global::Infragistics.Controls.Grids.DataLimitingEventArgs(e);
			global::Infragistics.Controls.Grids.RowBase parentRow = this.ParentRow;
			while (parentRow != null && !(parentRow is global::Infragistics.Controls.Grids.Row))
			{
				global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = parentRow as global::Infragistics.Controls.Grids.Primitives.ChildBand;
				if (childBand != null)
				{
					parentRow = childBand.ParentRow;
				}
			}
			dataLimitingEventArgs.ParentRow = (parentRow as global::Infragistics.Controls.Grids.Row);
			dataLimitingEventArgs.ColumnLayout = base.ColumnLayout;
			base.ColumnLayout.Grid.OnDataResolution(dataLimitingEventArgs);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000538B8 File Offset: 0x00051AB8
		private void ItemSource_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string[] array = (base.ColumnLayout != null) ? base.ColumnLayout.Key.Split(new char[]
			{
				'.'
			}) : null;
			if (array != null && (e.PropertyName == array[array.Length - 1] || e.PropertyName == array[0]))
			{
				object data = this.ParentRow.Data;
				global::System.Reflection.PropertyInfo propertyInfo = base.ColumnLayout.ResovlePropertyInfo(data);
				if (propertyInfo != null)
				{
					this.ItemsSource = (propertyInfo.GetValue(data, null) as global::System.Collections.IEnumerable);
				}
				else
				{
					object obj = global::Infragistics.DataManagerBase.ResolveValueFromPropertyPath(base.ColumnLayout.Key, data);
					this.ItemsSource = (obj as global::System.Collections.IEnumerable);
				}
				if (this.ItemsSource != null)
				{
					this.SetupDataManager();
				}
				base.ColumnLayout.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x0005398F File Offset: 0x00051B8F
		private void RowFiltersCollection_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.InvalidateFiltering();
			this.InvalidatePager();
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x0005399D File Offset: 0x00051B9D
		private void RowFiltersCollection_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.InvalidateFiltering();
			this.InvalidatePager();
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000539AB File Offset: 0x00051BAB
		private void RowFiltersCollection_CollectionItemChanged(object sender, global::System.EventArgs e)
		{
			this.InvalidateFiltering();
			this.InvalidatePager();
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000539BC File Offset: 0x00051BBC
		private void SummaryDefinitionCollection_CollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (base.ColumnLayout != null)
			{
				switch (e.Action)
				{
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
					if (e.NewItems == null)
					{
						goto IL_155;
					}
					using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							global::Infragistics.SummaryDefinition summaryDefinition = (global::Infragistics.SummaryDefinition)obj;
							global::Infragistics.Controls.Grids.Column column = base.ColumnLayout.Columns.DataColumns[summaryDefinition.ColumnKey];
							if (column != null && column.SummaryColumnSettings.SummaryOperands.Contains(summaryDefinition.SummaryOperand))
							{
								summaryDefinition.SummaryOperand.IsApplied = true;
							}
						}
						goto IL_155;
					}
					break;
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
					break;
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
					goto IL_155;
				default:
					goto IL_155;
				}
				if (e.OldItems != null)
				{
					foreach (object obj2 in e.OldItems)
					{
						global::Infragistics.SummaryDefinition summaryDefinition2 = (global::Infragistics.SummaryDefinition)obj2;
						global::Infragistics.Controls.Grids.Column column2 = base.ColumnLayout.Columns.DataColumns[summaryDefinition2.ColumnKey];
						if (column2 != null && column2.SummaryColumnSettings.SummaryOperands.Contains(summaryDefinition2.SummaryOperand))
						{
							summaryDefinition2.SummaryOperand.IsApplied = false;
						}
					}
				}
			}
			IL_155:
			this.InvalidateSummaries();
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00053B40 File Offset: 0x00051D40
		private void DataManager_DataUpdated(object sender, global::System.EventArgs e)
		{
			this.InvalidateRows();
			this.InvalidatePagerRowVisibility();
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x00053B50 File Offset: 0x00051D50
		private void PropertyChangedDataObject_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Grids.Column column = base.ColumnLayout.Columns.AllColumns[e.PropertyName] as global::Infragistics.Controls.Grids.Column;
			if (column != null && column.ConditionalFormatCollection.Count > 0)
			{
				foreach (global::Infragistics.Controls.Grids.IConditionalFormattingRule conditionalFormattingRule in column.ConditionalFormatCollection)
				{
					if (conditionalFormattingRule.ShouldRefreshOnDataChange)
					{
						if (conditionalFormattingRule.RuleExecution != global::Infragistics.EvaluationStage.None)
						{
							base.ColumnLayout.Grid.NeedConditionalFormatUpdate = true;
							if (!base.ColumnLayout.Grid.SuspendConditionalFormatUpdates)
							{
								base.ColumnLayout.InvalidateConditionalFormatting();
								break;
							}
							break;
						}
						else if (conditionalFormattingRule.StyleScope != global::Infragistics.Controls.Grids.StyleScope.Cell)
						{
							column.ForceUpdateRowStyle = true;
							break;
						}
					}
				}
			}
		}

		// Token: 0x060015F2 RID: 5618 RVA: 0x00053C1C File Offset: 0x00051E1C
		private void DataManager_CurrentItemChanged(object sender, global::Infragistics.CurrentItemEventArgs e)
		{
			this.OnCurrentItemChanged(e.Item);
		}

		// Token: 0x04000673 RID: 1651
		private bool _isInDesigner;

		// Token: 0x04000674 RID: 1652
		private bool _isInitializingDataManager;

		// Token: 0x04000675 RID: 1653
		private global::Infragistics.DataManagerBase _dataManager;

		// Token: 0x04000676 RID: 1654
		private global::Infragistics.Controls.Grids.Primitives.RowBaseCollection _rowBaseCollection;

		// Token: 0x04000677 RID: 1655
		private global::Infragistics.Controls.Grids.RowCollection _rows;

		// Token: 0x04000678 RID: 1656
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> _registeredTopRows;

		// Token: 0x04000679 RID: 1657
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> _registeredBottomRows;

		// Token: 0x0400067A RID: 1658
		private global::Infragistics.Controls.Grids.Primitives.HeaderRow _headerRow;

		// Token: 0x0400067B RID: 1659
		private global::Infragistics.Controls.Grids.Primitives.FooterRow _footerRow;

		// Token: 0x0400067C RID: 1660
		private global::Infragistics.Controls.Grids.Primitives.PagerRow _topPagerRow;

		// Token: 0x0400067D RID: 1661
		private global::Infragistics.Controls.Grids.Primitives.PagerRow _bottomPagerRow;

		// Token: 0x0400067E RID: 1662
		private global::Infragistics.Controls.Grids.Primitives.GroupByColumn _groupByColumn;

		// Token: 0x0400067F RID: 1663
		private global::Infragistics.Controls.Grids.Primitives.AddNewRow _addNewRowTop;

		// Token: 0x04000680 RID: 1664
		private global::Infragistics.Controls.Grids.Primitives.AddNewRow _addNewRowBottom;

		// Token: 0x04000681 RID: 1665
		private global::Infragistics.Controls.Grids.Primitives.FilterRow _filterRowTop;

		// Token: 0x04000682 RID: 1666
		private global::Infragistics.Controls.Grids.Primitives.FilterRow _filterRowBottom;

		// Token: 0x04000683 RID: 1667
		private global::Infragistics.Controls.Grids.Primitives.SummaryRow _summaryRowTop;

		// Token: 0x04000684 RID: 1668
		private global::Infragistics.Controls.Grids.Primitives.SummaryRow _summaryRowBottom;

		// Token: 0x04000685 RID: 1669
		private global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Grids.Row> _rowObjectCache;

		// Token: 0x04000686 RID: 1670
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Grids.Row> _cachedRows;

		// Token: 0x04000687 RID: 1671
		private global::System.Collections.Generic.Dictionary<object, int> _duplicateObjectValidator;

		// Token: 0x04000688 RID: 1672
		private int _currentPageIndex = 1;

		// Token: 0x04000689 RID: 1673
		private int _groupByLevel = -1;

		// Token: 0x0400068A RID: 1674
		private int _displayableRowCount;

		// Token: 0x0400068B RID: 1675
		private global::Infragistics.FixedRowsOrderComparer _fixedRowsOrderComparer = new global::Infragistics.FixedRowsOrderComparer();

		// Token: 0x0400068C RID: 1676
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Controls.Grids.Row> _cachedGroupByRows;

		// Token: 0x0400068D RID: 1677
		private global::Infragistics.Controls.Grids.ColumnLayoutTemplateColumn _columnLayoutTemplateColumn;

		// Token: 0x0400068E RID: 1678
		private global::Infragistics.Controls.Grids.Primitives.ColumnLayoutTemplateRow _columnLayoutTemplateRow;

		// Token: 0x0400068F RID: 1679
		private bool _deferInvalidatingSort;

		// Token: 0x04000690 RID: 1680
		private bool _deferItemSourceInvalidation;

		// Token: 0x04000691 RID: 1681
		private bool _supressInvalidateRows;

		// Token: 0x04000692 RID: 1682
		private bool _deferClearGroupByCache;

		// Token: 0x04000693 RID: 1683
		private bool _supressCFUpdating;

		// Token: 0x04000694 RID: 1684
		private global::System.Collections.IEnumerable _itemSource;

		// Token: 0x04000695 RID: 1685
		private global::Infragistics.Controls.Grids.RowFiltersCollection _rowFiltersCollection;

		// Token: 0x04000696 RID: 1686
		private global::Infragistics.SummaryDefinitionCollection _summaryDefinitionCollection;

		// Token: 0x04000697 RID: 1687
		private global::Infragistics.SummaryResultCollection _summaryResultCollection;

		// Token: 0x04000698 RID: 1688
		private global::Infragistics.Controls.Grids.RowType? _newDataObjectRowType;

		// Token: 0x04000699 RID: 1689
		private global::Infragistics.Controls.Grids.ConditionalFormatProxyCollection _conditionalFormatProxyCollection;

		// Token: 0x0400069A RID: 1690
		private global::Infragistics.Collections.WeakDictionary<global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager>> _weakPropertyChangedHandlers = new global::Infragistics.Collections.WeakDictionary<global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.WeakPropertyChangedHandler<global::Infragistics.Controls.Grids.RowsManager>>(true, false);

		// Token: 0x0400069B RID: 1691
		private global::Infragistics.WeakCollectionChangedHandler<global::Infragistics.Controls.Grids.RowsManager> _weakItemsSourceCollectionChanged;
	}
}
