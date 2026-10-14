using System;
using System.ComponentModel;
using System.Windows.Controls;
using Infragistics.Windows.Themes.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000195 RID: 405
	public abstract class ReportViewBase : global::Infragistics.Windows.DataPresenter.ViewBase, global::Infragistics.Windows.DataPresenter.IExportOptions
	{
		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x0600197E RID: 6526 RVA: 0x00075A42 File Offset: 0x00073C42
		protected internal override global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x0600197F RID: 6527 RVA: 0x00075A45 File Offset: 0x00073C45
		protected internal override bool IsFixedRecordsSupported
		{
			get
			{
				return this._uiView.IsFixedRecordsSupported;
			}
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x06001980 RID: 6528 RVA: 0x00075A52 File Offset: 0x00073C52
		protected internal override global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001981 RID: 6529 RVA: 0x00075A55 File Offset: 0x00073C55
		protected global::Infragistics.Windows.DataPresenter.ViewBase UiView
		{
			get
			{
				return this._uiView;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001982 RID: 6530 RVA: 0x00075A5D File Offset: 0x00073C5D
		// (set) Token: 0x06001983 RID: 6531 RVA: 0x00075A65 File Offset: 0x00073C65
		[global::System.ComponentModel.DefaultValue(global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy.NextPageFillWithPreviousCell)]
		public global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy CellPageSpanStrategy
		{
			get
			{
				return this._cellPageSpanStrategy;
			}
			set
			{
				if (value != this._cellPageSpanStrategy)
				{
					if (!global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy), value))
					{
						throw new global::System.ArgumentException();
					}
					this._cellPageSpanStrategy = value;
				}
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001984 RID: 6532 RVA: 0x00075A94 File Offset: 0x00073C94
		// (set) Token: 0x06001985 RID: 6533 RVA: 0x00075A9C File Offset: 0x00073C9C
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeCellValuePresenterStyles
		{
			get
			{
				return this._excludeCellValuePresenterStyles;
			}
			set
			{
				this._excludeCellValuePresenterStyles = value;
			}
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001986 RID: 6534 RVA: 0x00075AA5 File Offset: 0x00073CA5
		// (set) Token: 0x06001987 RID: 6535 RVA: 0x00075AAD File Offset: 0x00073CAD
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeEditorSettings
		{
			get
			{
				return this._excludeEditorSettings;
			}
			set
			{
				this._excludeEditorSettings = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001988 RID: 6536 RVA: 0x00075AB6 File Offset: 0x00073CB6
		// (set) Token: 0x06001989 RID: 6537 RVA: 0x00075ABE File Offset: 0x00073CBE
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeExpandedState
		{
			get
			{
				return this._excludeExpandedState;
			}
			set
			{
				this._excludeExpandedState = value;
			}
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x0600198A RID: 6538 RVA: 0x00075AC7 File Offset: 0x00073CC7
		// (set) Token: 0x0600198B RID: 6539 RVA: 0x00075ACF File Offset: 0x00073CCF
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeFieldLayoutSettings
		{
			get
			{
				return this._excludeFieldLayoutSettings;
			}
			set
			{
				this._excludeFieldLayoutSettings = value;
			}
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x0600198C RID: 6540 RVA: 0x00075AD8 File Offset: 0x00073CD8
		// (set) Token: 0x0600198D RID: 6541 RVA: 0x00075AE0 File Offset: 0x00073CE0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeFieldSettings
		{
			get
			{
				return this._excludeFieldSettings;
			}
			set
			{
				this._excludeFieldSettings = value;
			}
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x0600198E RID: 6542 RVA: 0x00075AE9 File Offset: 0x00073CE9
		// (set) Token: 0x0600198F RID: 6543 RVA: 0x00075AF1 File Offset: 0x00073CF1
		[global::System.ComponentModel.DefaultValue(false)]
		public virtual bool ExcludeGroupBySettings
		{
			get
			{
				return this._excludeGroupBySettings;
			}
			set
			{
				this._excludeGroupBySettings = value;
			}
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x06001990 RID: 6544 RVA: 0x00075AFA File Offset: 0x00073CFA
		// (set) Token: 0x06001991 RID: 6545 RVA: 0x00075B02 File Offset: 0x00073D02
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeLabelPresenterStyles
		{
			get
			{
				return this._excludeLabelPresenterStyles;
			}
			set
			{
				this._excludeLabelPresenterStyles = value;
			}
		}

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x06001992 RID: 6546 RVA: 0x00075B0B File Offset: 0x00073D0B
		// (set) Token: 0x06001993 RID: 6547 RVA: 0x00075B13 File Offset: 0x00073D13
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeRecordFilters
		{
			get
			{
				return this._excludeRecordFilters;
			}
			set
			{
				this._excludeRecordFilters = value;
			}
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06001994 RID: 6548 RVA: 0x00075B1C File Offset: 0x00073D1C
		// (set) Token: 0x06001995 RID: 6549 RVA: 0x00075B24 File Offset: 0x00073D24
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeRecordVisibility
		{
			get
			{
				return this._excludeRecordVisibility;
			}
			set
			{
				this._excludeRecordVisibility = value;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x00075B2D File Offset: 0x00073D2D
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00075B35 File Offset: 0x00073D35
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeRecordSizing
		{
			get
			{
				return this._excludeRecordSizing;
			}
			set
			{
				this._excludeRecordSizing = value;
			}
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x00075B3E File Offset: 0x00073D3E
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x00075B46 File Offset: 0x00073D46
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeSortOrder
		{
			get
			{
				return this._excludeSortOrder;
			}
			set
			{
				this._excludeSortOrder = value;
			}
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x0600199A RID: 6554 RVA: 0x00075B4F File Offset: 0x00073D4F
		// (set) Token: 0x0600199B RID: 6555 RVA: 0x00075B57 File Offset: 0x00073D57
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeSummaries
		{
			get
			{
				return this._excludeSummaries;
			}
			set
			{
				this._excludeSummaries = value;
			}
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x00075B69 File Offset: 0x00073D69
		// (set) Token: 0x0600199C RID: 6556 RVA: 0x00075B60 File Offset: 0x00073D60
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.DataPresenterThemeTypeConverter))]
		[global::System.ComponentModel.DefaultValue(null)]
		public string Theme
		{
			get
			{
				return this._theme;
			}
			set
			{
				this._theme = value;
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00075B74 File Offset: 0x00073D74
		internal static global::Infragistics.Windows.DataPresenter.ReportViewBase CloneView(global::Infragistics.Windows.DataPresenter.DataPresenterBase uiDP)
		{
			global::Infragistics.Windows.DataPresenter.ViewBase uiView = global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(uiDP.CurrentViewInternal, false) as global::Infragistics.Windows.DataPresenter.ViewBase;
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase;
			if (uiDP.ReportView != null)
			{
				reportViewBase = (global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(uiDP.ReportView, false) as global::Infragistics.Windows.DataPresenter.ReportViewBase);
			}
			else if (uiDP.IsTreeView)
			{
				reportViewBase = new global::Infragistics.Windows.DataPresenter.TreeReportView();
			}
			else
			{
				reportViewBase = new global::Infragistics.Windows.DataPresenter.TabularReportView();
			}
			reportViewBase._uiView = uiView;
			return reportViewBase;
		}

		// Token: 0x04000A76 RID: 2678
		private global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy _cellPageSpanStrategy = global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy.NextPageFillWithPreviousCell;

		// Token: 0x04000A77 RID: 2679
		private bool _excludeExpandedState;

		// Token: 0x04000A78 RID: 2680
		private bool _excludeRecordVisibility;

		// Token: 0x04000A79 RID: 2681
		private bool _excludeFieldLayoutSettings;

		// Token: 0x04000A7A RID: 2682
		private bool _excludeFieldSettings;

		// Token: 0x04000A7B RID: 2683
		private bool _excludeCellValuePresenterStyles;

		// Token: 0x04000A7C RID: 2684
		private bool _excludeLabelPresenterStyles;

		// Token: 0x04000A7D RID: 2685
		private bool _excludeEditorSettings;

		// Token: 0x04000A7E RID: 2686
		private bool _excludeGroupBySettings;

		// Token: 0x04000A7F RID: 2687
		private bool _excludeSortOrder;

		// Token: 0x04000A80 RID: 2688
		private bool _excludeSummaries;

		// Token: 0x04000A81 RID: 2689
		private bool _excludeRecordSizing;

		// Token: 0x04000A82 RID: 2690
		private bool _excludeRecordFilters;

		// Token: 0x04000A83 RID: 2691
		private string _theme;

		// Token: 0x04000A84 RID: 2692
		private global::Infragistics.Windows.DataPresenter.ViewBase _uiView;
	}
}
