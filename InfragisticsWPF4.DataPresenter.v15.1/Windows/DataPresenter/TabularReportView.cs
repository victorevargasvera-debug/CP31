using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001C0 RID: 448
	public class TabularReportView : global::Infragistics.Windows.DataPresenter.ReportViewBase
	{
		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x06001AA4 RID: 6820 RVA: 0x00078379 File Offset: 0x00076579
		protected internal override bool AutoFitToRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x06001AA5 RID: 6821 RVA: 0x0007837C File Offset: 0x0007657C
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x06001AA6 RID: 6822 RVA: 0x0007837F File Offset: 0x0007657F
		protected internal override global::Infragistics.Windows.DataPresenter.AutoArrangeCells DefaultAutoArrangeCells
		{
			get
			{
				if (this.LogicalOrientation != global::System.Windows.Controls.Orientation.Vertical)
				{
					return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.TopToBottom;
				}
				return global::Infragistics.Windows.DataPresenter.AutoArrangeCells.LeftToRight;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001AA7 RID: 6823 RVA: 0x0007838D File Offset: 0x0007658D
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001AA8 RID: 6824 RVA: 0x00078390 File Offset: 0x00076590
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal;
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001AA9 RID: 6825 RVA: 0x0007839B File Offset: 0x0007659B
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001AAA RID: 6826 RVA: 0x000783A6 File Offset: 0x000765A6
		protected internal override bool IsChildRecordsDisplayOrderSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001AAB RID: 6827 RVA: 0x000783A9 File Offset: 0x000765A9
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.TabularReportViewPanel);
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x000783B5 File Offset: 0x000765B5
		internal override double LevelIndentationResolved
		{
			get
			{
				return this.LevelIndentation;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001AAD RID: 6829 RVA: 0x000783C0 File Offset: 0x000765C0
		protected internal override global::System.Windows.Controls.Orientation LogicalOrientation
		{
			get
			{
				global::System.Windows.Controls.Orientation? orientation = this.Orientation;
				if (orientation != null)
				{
					return orientation.Value;
				}
				if (base.UiView != null && base.UiView.HasLogicalOrientation)
				{
					return base.UiView.LogicalOrientation;
				}
				return global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001AAE RID: 6830 RVA: 0x00078407 File Offset: 0x00076607
		protected internal override global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Hierarchical;
			}
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0007840A File Offset: 0x0007660A
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderedGridViewFieldLayoutTemplateGenerator(fieldLayout, this.LogicalOrientation);
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001AB0 RID: 6832 RVA: 0x00078418 File Offset: 0x00076618
		// (set) Token: 0x06001AB1 RID: 6833 RVA: 0x0007842A File Offset: 0x0007662A
		[global::System.ComponentModel.Bindable(true)]
		public double LevelIndentation
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.DataPresenter.TabularReportView.LevelIndentationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TabularReportView.LevelIndentationProperty, value);
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001AB2 RID: 6834 RVA: 0x0007843D File Offset: 0x0007663D
		// (set) Token: 0x06001AB3 RID: 6835 RVA: 0x0007844F File Offset: 0x0007664F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Windows.Controls.Orientation>))]
		public global::System.Windows.Controls.Orientation? Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation?)base.GetValue(global::Infragistics.Windows.DataPresenter.TabularReportView.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.TabularReportView.OrientationProperty, value);
			}
		}

		// Token: 0x04000ABF RID: 2751
		internal const double DEFAULT_LEVELINDENTATION = 10.0;

		// Token: 0x04000AC0 RID: 2752
		public static readonly global::System.Windows.DependencyProperty LevelIndentationProperty = global::System.Windows.DependencyProperty.Register("LevelIndentation", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.TabularReportView), new global::System.Windows.FrameworkPropertyMetadata(10.0));

		// Token: 0x04000AC1 RID: 2753
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation?), typeof(global::Infragistics.Windows.DataPresenter.TabularReportView), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
