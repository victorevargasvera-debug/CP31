using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200019A RID: 410
	public class TabularReportView : global::Infragistics.Windows.DataPresenter.ReportViewBase
	{
		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x06001695 RID: 5781 RVA: 0x00063E28 File Offset: 0x00062028
		protected internal override bool AutoFitToRecord
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001696 RID: 5782 RVA: 0x00063E2B File Offset: 0x0006202B
		protected internal override global::Infragistics.Windows.DataPresenter.CellPresentation CellPresentation
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.CellPresentation.GridView;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x00063E2E File Offset: 0x0006202E
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

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x00063E3C File Offset: 0x0006203C
		protected internal override bool HasLogicalOrientation
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x00063E3F File Offset: 0x0006203F
		protected internal override bool IsAutoFitHeightSupported
		{
			get
			{
				return this.LogicalOrientation == global::System.Windows.Controls.Orientation.Horizontal;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x00063E4A File Offset: 0x0006204A
		protected internal override bool IsAutoFitWidthSupported
		{
			get
			{
				return this.LogicalOrientation == global::System.Windows.Controls.Orientation.Vertical;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x00063E55 File Offset: 0x00062055
		protected internal override bool IsChildRecordsDisplayOrderSupported
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600169C RID: 5788 RVA: 0x00063E58 File Offset: 0x00062058
		protected internal override global::System.Type ItemsPanelType
		{
			get
			{
				return typeof(global::Infragistics.Windows.DataPresenter.TabularReportViewPanel);
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600169D RID: 5789 RVA: 0x00063E64 File Offset: 0x00062064
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

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x0600169E RID: 5790 RVA: 0x00063EAB File Offset: 0x000620AB
		protected internal override global::Infragistics.Windows.DataPresenter.DataDisplayMode SupportedDataDisplayMode
		{
			get
			{
				return global::Infragistics.Windows.DataPresenter.DataDisplayMode.Hierarchical;
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00063EAE File Offset: 0x000620AE
		protected internal override global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator GetFieldLayoutTemplateGenerator(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout)
		{
			return new global::Infragistics.Windows.DataPresenter.HeaderedGridViewFieldLayoutTemplateGenerator(fieldLayout, this.LogicalOrientation);
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00063EBC File Offset: 0x000620BC
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x00063ECE File Offset: 0x000620CE
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

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060016A2 RID: 5794 RVA: 0x00063EE1 File Offset: 0x000620E1
		// (set) Token: 0x060016A3 RID: 5795 RVA: 0x00063EF3 File Offset: 0x000620F3
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

		// Token: 0x040008D7 RID: 2263
		internal const double DEFAULT_LEVELINDENTATION = 10.0;

		// Token: 0x040008D8 RID: 2264
		public static readonly global::System.Windows.DependencyProperty LevelIndentationProperty = global::System.Windows.DependencyProperty.Register("LevelIndentation", typeof(double), typeof(global::Infragistics.Windows.DataPresenter.TabularReportView), new global::System.Windows.FrameworkPropertyMetadata(10.0));

		// Token: 0x040008D9 RID: 2265
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation?), typeof(global::Infragistics.Windows.DataPresenter.TabularReportView), new global::System.Windows.FrameworkPropertyMetadata(null));
	}
}
