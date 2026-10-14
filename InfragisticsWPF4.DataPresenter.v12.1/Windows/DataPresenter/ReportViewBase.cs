using System;
using System.ComponentModel;
using System.Windows.Controls;
using Infragistics.Windows.Themes.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000199 RID: 409
	public abstract class ReportViewBase : global::Infragistics.Windows.DataPresenter.ViewBase, global::Infragistics.Windows.DataPresenter.IExportOptions
	{
		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00063CA1 File Offset: 0x00061EA1
		protected internal override global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001674 RID: 5748 RVA: 0x00063CA4 File Offset: 0x00061EA4
		protected internal override bool IsFixedRecordsSupported
		{
			get
			{
				return this._uiView.IsFixedRecordsSupported;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001675 RID: 5749 RVA: 0x00063CB1 File Offset: 0x00061EB1
		protected internal override global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return global::System.Windows.Controls.ScrollBarVisibility.Hidden;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001676 RID: 5750 RVA: 0x00063CB4 File Offset: 0x00061EB4
		protected global::Infragistics.Windows.DataPresenter.ViewBase UiView
		{
			get
			{
				return this._uiView;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001677 RID: 5751 RVA: 0x00063CBC File Offset: 0x00061EBC
		// (set) Token: 0x06001678 RID: 5752 RVA: 0x00063CC4 File Offset: 0x00061EC4
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

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06001679 RID: 5753 RVA: 0x00063CF3 File Offset: 0x00061EF3
		// (set) Token: 0x0600167A RID: 5754 RVA: 0x00063CFB File Offset: 0x00061EFB
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

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x00063D04 File Offset: 0x00061F04
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x00063D0C File Offset: 0x00061F0C
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

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00063D15 File Offset: 0x00061F15
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x00063D1D File Offset: 0x00061F1D
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

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x00063D26 File Offset: 0x00061F26
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x00063D2E File Offset: 0x00061F2E
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

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00063D37 File Offset: 0x00061F37
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x00063D3F File Offset: 0x00061F3F
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

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x00063D48 File Offset: 0x00061F48
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x00063D50 File Offset: 0x00061F50
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ExcludeGroupBySettings
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

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001685 RID: 5765 RVA: 0x00063D59 File Offset: 0x00061F59
		// (set) Token: 0x06001686 RID: 5766 RVA: 0x00063D61 File Offset: 0x00061F61
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

		// Token: 0x170005E1 RID: 1505
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x00063D6A File Offset: 0x00061F6A
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x00063D72 File Offset: 0x00061F72
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

		// Token: 0x170005E2 RID: 1506
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00063D7B File Offset: 0x00061F7B
		// (set) Token: 0x0600168A RID: 5770 RVA: 0x00063D83 File Offset: 0x00061F83
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

		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x00063D8C File Offset: 0x00061F8C
		// (set) Token: 0x0600168C RID: 5772 RVA: 0x00063D94 File Offset: 0x00061F94
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

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x0600168D RID: 5773 RVA: 0x00063D9D File Offset: 0x00061F9D
		// (set) Token: 0x0600168E RID: 5774 RVA: 0x00063DA5 File Offset: 0x00061FA5
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

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x00063DAE File Offset: 0x00061FAE
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00063DB6 File Offset: 0x00061FB6
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

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06001692 RID: 5778 RVA: 0x00063DC8 File Offset: 0x00061FC8
		// (set) Token: 0x06001691 RID: 5777 RVA: 0x00063DBF File Offset: 0x00061FBF
		[global::System.ComponentModel.DefaultValue(null)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.DataPresenterThemeTypeConverter))]
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

		// Token: 0x06001693 RID: 5779 RVA: 0x00063DD0 File Offset: 0x00061FD0
		internal static global::Infragistics.Windows.DataPresenter.ReportViewBase CloneView(global::Infragistics.Windows.DataPresenter.DataPresenterBase uiDP)
		{
			global::Infragistics.Windows.DataPresenter.ViewBase uiView = global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(uiDP.CurrentViewInternal, false) as global::Infragistics.Windows.DataPresenter.ViewBase;
			global::Infragistics.Windows.DataPresenter.ReportViewBase reportViewBase;
			if (uiDP.ReportView != null)
			{
				reportViewBase = (global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase.CloneHelper(uiDP.ReportView, false) as global::Infragistics.Windows.DataPresenter.ReportViewBase);
			}
			else
			{
				reportViewBase = new global::Infragistics.Windows.DataPresenter.TabularReportView();
			}
			reportViewBase._uiView = uiView;
			return reportViewBase;
		}

		// Token: 0x040008C8 RID: 2248
		private global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy _cellPageSpanStrategy = global::Infragistics.Windows.DataPresenter.CellPageSpanStrategy.NextPageFillWithPreviousCell;

		// Token: 0x040008C9 RID: 2249
		private bool _excludeExpandedState;

		// Token: 0x040008CA RID: 2250
		private bool _excludeRecordVisibility;

		// Token: 0x040008CB RID: 2251
		private bool _excludeFieldLayoutSettings;

		// Token: 0x040008CC RID: 2252
		private bool _excludeFieldSettings;

		// Token: 0x040008CD RID: 2253
		private bool _excludeCellValuePresenterStyles;

		// Token: 0x040008CE RID: 2254
		private bool _excludeLabelPresenterStyles;

		// Token: 0x040008CF RID: 2255
		private bool _excludeEditorSettings;

		// Token: 0x040008D0 RID: 2256
		private bool _excludeGroupBySettings;

		// Token: 0x040008D1 RID: 2257
		private bool _excludeSortOrder;

		// Token: 0x040008D2 RID: 2258
		private bool _excludeSummaries;

		// Token: 0x040008D3 RID: 2259
		private bool _excludeRecordSizing;

		// Token: 0x040008D4 RID: 2260
		private bool _excludeRecordFilters;

		// Token: 0x040008D5 RID: 2261
		private string _theme;

		// Token: 0x040008D6 RID: 2262
		private global::Infragistics.Windows.DataPresenter.ViewBase _uiView;
	}
}
