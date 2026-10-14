using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000196 RID: 406
	public class TreeReportView : global::Infragistics.Windows.DataPresenter.ReportViewBase
	{
		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060019A1 RID: 6561 RVA: 0x00075BE4 File Offset: 0x00073DE4
		protected internal override bool AutoFitToRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060019A2 RID: 6562 RVA: 0x00075BE7 File Offset: 0x00073DE7
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060019A3 RID: 6563 RVA: 0x00075BEA File Offset: 0x00073DEA
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
			}
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060019A4 RID: 6564 RVA: 0x00075BED File Offset: 0x00073DED
		// (set) Token: 0x060019A5 RID: 6565 RVA: 0x00075BF0 File Offset: 0x00073DF0
		public override bool ExcludeGroupBySettings
		{
			get
			{
				return true;
			}
			set
			{
				if (!value)
				{
					global::Infragistics.Windows.DataPresenter.GridUtilities.LogDebuggerError("GroupBySettings are ignored in TreeReportView");
				}
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060019A6 RID: 6566 RVA: 0x00075BFF File Offset: 0x00073DFF
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060019A7 RID: 6567 RVA: 0x00075C02 File Offset: 0x00073E02
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060019A8 RID: 6568 RVA: 0x00075C05 File Offset: 0x00073E05
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060019A9 RID: 6569 RVA: 0x00075C08 File Offset: 0x00073E08
		protected internal override bool IsChildRecordsDisplayOrderSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060019AA RID: 6570 RVA: 0x00075C0B File Offset: 0x00073E0B
		internal override bool IsTreeView
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060019AB RID: 6571 RVA: 0x00075C0E File Offset: 0x00073E0E
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.TreeReportViewPanel);
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060019AC RID: 6572 RVA: 0x00075C1A File Offset: 0x00073E1A
		internal override double LevelIndentationResolved
		{
			get
			{
				return this.ViewSettingsResolved.IndentPerLevel;
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060019AD RID: 6573 RVA: 0x00075C27 File Offset: 0x00073E27
		protected internal override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060019AE RID: 6574 RVA: 0x00075C2A File Offset: 0x00073E2A
		protected internal override global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Hierarchical;
			}
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00075C2D File Offset: 0x00073E2D
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderedGridViewFieldLayoutTemplateGenerator(fieldLayout, this.LogicalOrientation);
		}

		// Token: 0x060019B0 RID: 6576 RVA: 0x00075C3B File Offset: 0x00073E3B
		public override string ToString()
		{
			return "TreeReportView";
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x00075C42 File Offset: 0x00073E42
		// (set) Token: 0x060019B2 RID: 6578 RVA: 0x00075C54 File Offset: 0x00073E54
		[global::System.ComponentModel.TypeConverter(typeof(global::System.ComponentModel.ExpandableObjectConverter))]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.TreeViewSettings ViewSettings
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.TreeViewSettings)base.GetValue(global::Infragistics.Windows.DataPresenter.TreeReportView.ViewSettingsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TreeReportView.ViewSettingsProperty, value);
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060019B3 RID: 6579 RVA: 0x00075C64 File Offset: 0x00073E64
		internal global::Infragistics.Windows.DataPresenter.TreeViewSettings ViewSettingsResolved
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.TreeViewSettings viewSettings = this.ViewSettings;
				if (viewSettings != null)
				{
					return viewSettings;
				}
				global::Infragistics.Windows.DataPresenter.TreeView treeView = base.UiView as global::Infragistics.Windows.DataPresenter.TreeView;
				if (treeView != null)
				{
					viewSettings = treeView.ViewSettings;
					if (viewSettings != null)
					{
						return viewSettings;
					}
				}
				if (this._defaultSettings == null)
				{
					this._defaultSettings = new global::Infragistics.Windows.DataPresenter.TreeViewSettings();
				}
				return this._defaultSettings;
			}
		}

		// Token: 0x04000A85 RID: 2693
		private global::Infragistics.Windows.DataPresenter.TreeViewSettings _defaultSettings;

		// Token: 0x04000A86 RID: 2694
		public static readonly global::System.Windows.DependencyProperty ViewSettingsProperty = global::System.Windows.DependencyProperty.Register("ViewSettings", typeof(global::Infragistics.Windows.DataPresenter.TreeViewSettings), typeof(global::Infragistics.Windows.DataPresenter.TreeReportView), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
