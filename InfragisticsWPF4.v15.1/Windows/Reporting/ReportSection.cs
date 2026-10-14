using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000207 RID: 519
	public abstract class ReportSection : global::System.Windows.FrameworkContentElement
	{
		// Token: 0x0600133D RID: 4925 RVA: 0x00044E00 File Offset: 0x00043000
		public ReportSection()
		{
			base.SetValue(global::Infragistics.Windows.Reporting.ReportSection.IsInReportPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x0600133E RID: 4926
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public abstract int GeneratedPageCount { get; }

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x0600133F RID: 4927
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public abstract bool IsEndReached { get; }

		// Token: 0x06001340 RID: 4928 RVA: 0x00044E18 File Offset: 0x00043018
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public static bool GetIsInReport(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Reporting.ReportSection.IsInReportProperty);
		}

		// Token: 0x06001341 RID: 4929 RVA: 0x00044E2A File Offset: 0x0004302A
		protected static void SetIsInReport(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Reporting.ReportSection.IsInReportPropertyKey, value);
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001342 RID: 4930
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract int LogicalPageNumber { get; }

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06001343 RID: 4931
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract int LogicalPagePartNumber { get; }

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06001344 RID: 4932 RVA: 0x00044E3D File Offset: 0x0004303D
		// (set) Token: 0x06001345 RID: 4933 RVA: 0x00044E45 File Offset: 0x00043045
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.DataTemplate PageContentTemplate
		{
			get
			{
				return this._pageContentTemplate;
			}
			set
			{
				this._pageContentTemplate = value;
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001346 RID: 4934 RVA: 0x00044E4E File Offset: 0x0004304E
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x00044E56 File Offset: 0x00043056
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Controls.DataTemplateSelector PageContentTemplateSelector
		{
			get
			{
				return this._pageContentTemplateSelector;
			}
			set
			{
				this._pageContentTemplateSelector = value;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x00044E5F File Offset: 0x0004305F
		// (set) Token: 0x06001349 RID: 4937 RVA: 0x00044E67 File Offset: 0x00043067
		[global::System.ComponentModel.DefaultValue(null)]
		public object PageFooter
		{
			get
			{
				return this._pageFooter;
			}
			set
			{
				this._pageFooter = value;
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x0600134A RID: 4938 RVA: 0x00044E70 File Offset: 0x00043070
		// (set) Token: 0x0600134B RID: 4939 RVA: 0x00044E78 File Offset: 0x00043078
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.DataTemplate PageFooterTemplate
		{
			get
			{
				return this._pageFooterTemplate;
			}
			set
			{
				this._pageFooterTemplate = value;
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x0600134C RID: 4940 RVA: 0x00044E81 File Offset: 0x00043081
		// (set) Token: 0x0600134D RID: 4941 RVA: 0x00044E89 File Offset: 0x00043089
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Controls.DataTemplateSelector PageFooterTemplateSelector
		{
			get
			{
				return this._pageFooterTemplateSelector;
			}
			set
			{
				this._pageFooterTemplateSelector = value;
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600134E RID: 4942 RVA: 0x00044E92 File Offset: 0x00043092
		// (set) Token: 0x0600134F RID: 4943 RVA: 0x00044E9A File Offset: 0x0004309A
		[global::System.ComponentModel.DefaultValue(null)]
		public object PageHeader
		{
			get
			{
				return this._pageHeader;
			}
			set
			{
				this._pageHeader = value;
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06001350 RID: 4944 RVA: 0x00044EA3 File Offset: 0x000430A3
		// (set) Token: 0x06001351 RID: 4945 RVA: 0x00044EAB File Offset: 0x000430AB
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.DataTemplate PageHeaderTemplate
		{
			get
			{
				return this._pageHeaderTemplate;
			}
			set
			{
				this._pageHeaderTemplate = value;
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06001352 RID: 4946 RVA: 0x00044EB4 File Offset: 0x000430B4
		// (set) Token: 0x06001353 RID: 4947 RVA: 0x00044EBC File Offset: 0x000430BC
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Controls.DataTemplateSelector PageHeaderTemplateSelector
		{
			get
			{
				return this._pageHeaderTemplateSelector;
			}
			set
			{
				this._pageHeaderTemplateSelector = value;
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x00044EC5 File Offset: 0x000430C5
		// (set) Token: 0x06001355 RID: 4949 RVA: 0x00044ECD File Offset: 0x000430CD
		[global::System.ComponentModel.DefaultValue(null)]
		public global::System.Windows.Style PagePresenterStyle
		{
			get
			{
				return this._pagePresenterStyle;
			}
			set
			{
				this._pagePresenterStyle = value;
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06001356 RID: 4950
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract int PhysicalPageNumber { get; }

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x00044ED6 File Offset: 0x000430D6
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Reporting.ReportBase Report
		{
			get
			{
				return this._report;
			}
		}

		// Token: 0x06001358 RID: 4952
		public abstract global::System.Windows.Documents.DocumentPage GetPage(int pageNumber);

		// Token: 0x06001359 RID: 4953 RVA: 0x00044EDE File Offset: 0x000430DE
		public virtual void OnBeginPagination(global::Infragistics.Windows.Reporting.ReportBase report)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(report, "report");
			this._report = report;
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x00044EF2 File Offset: 0x000430F2
		public virtual void OnEndPagination()
		{
		}

		// Token: 0x04000A57 RID: 2647
		private global::Infragistics.Windows.Reporting.ReportBase _report;

		// Token: 0x04000A58 RID: 2648
		private object _pageFooter;

		// Token: 0x04000A59 RID: 2649
		private object _pageHeader;

		// Token: 0x04000A5A RID: 2650
		private global::System.Windows.Controls.DataTemplateSelector _pageHeaderTemplateSelector;

		// Token: 0x04000A5B RID: 2651
		private global::System.Windows.Controls.DataTemplateSelector _pageContentTemplateSelector;

		// Token: 0x04000A5C RID: 2652
		private global::System.Windows.Controls.DataTemplateSelector _pageFooterTemplateSelector;

		// Token: 0x04000A5D RID: 2653
		private global::System.Windows.DataTemplate _pageFooterTemplate;

		// Token: 0x04000A5E RID: 2654
		private global::System.Windows.DataTemplate _pageContentTemplate;

		// Token: 0x04000A5F RID: 2655
		private global::System.Windows.DataTemplate _pageHeaderTemplate;

		// Token: 0x04000A60 RID: 2656
		private global::System.Windows.Style _pagePresenterStyle;

		// Token: 0x04000A61 RID: 2657
		private static readonly global::System.Windows.DependencyPropertyKey IsInReportPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsInReport", typeof(bool), typeof(global::Infragistics.Windows.Reporting.ReportSection), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x04000A62 RID: 2658
		public static readonly global::System.Windows.DependencyProperty IsInReportProperty = global::Infragistics.Windows.Reporting.ReportSection.IsInReportPropertyKey.DependencyProperty;
	}
}
