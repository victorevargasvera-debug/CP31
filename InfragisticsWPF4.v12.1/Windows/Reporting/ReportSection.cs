using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x020001D9 RID: 473
	public abstract class ReportSection : global::System.Windows.FrameworkContentElement
	{
		// Token: 0x0600116B RID: 4459 RVA: 0x0003F5D8 File Offset: 0x0003D7D8
		public ReportSection()
		{
			base.SetValue(global::Infragistics.Windows.Reporting.ReportSection.IsInReportPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600116C RID: 4460
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public abstract int GeneratedPageCount { get; }

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600116D RID: 4461
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract bool IsEndReached { get; }

		// Token: 0x0600116E RID: 4462 RVA: 0x0003F5F0 File Offset: 0x0003D7F0
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public static bool GetIsInReport(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Reporting.ReportSection.IsInReportProperty);
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0003F602 File Offset: 0x0003D802
		protected static void SetIsInReport(global::System.Windows.DependencyObject d, bool value)
		{
			d.SetValue(global::Infragistics.Windows.Reporting.ReportSection.IsInReportPropertyKey, value);
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001170 RID: 4464
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public abstract int LogicalPageNumber { get; }

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001171 RID: 4465
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract int LogicalPagePartNumber { get; }

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001172 RID: 4466 RVA: 0x0003F615 File Offset: 0x0003D815
		// (set) Token: 0x06001173 RID: 4467 RVA: 0x0003F61D File Offset: 0x0003D81D
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

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001174 RID: 4468 RVA: 0x0003F626 File Offset: 0x0003D826
		// (set) Token: 0x06001175 RID: 4469 RVA: 0x0003F62E File Offset: 0x0003D82E
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

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001176 RID: 4470 RVA: 0x0003F637 File Offset: 0x0003D837
		// (set) Token: 0x06001177 RID: 4471 RVA: 0x0003F63F File Offset: 0x0003D83F
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

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001178 RID: 4472 RVA: 0x0003F648 File Offset: 0x0003D848
		// (set) Token: 0x06001179 RID: 4473 RVA: 0x0003F650 File Offset: 0x0003D850
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

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0003F659 File Offset: 0x0003D859
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x0003F661 File Offset: 0x0003D861
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

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0003F66A File Offset: 0x0003D86A
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x0003F672 File Offset: 0x0003D872
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

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x0003F67B File Offset: 0x0003D87B
		// (set) Token: 0x0600117F RID: 4479 RVA: 0x0003F683 File Offset: 0x0003D883
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

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001180 RID: 4480 RVA: 0x0003F68C File Offset: 0x0003D88C
		// (set) Token: 0x06001181 RID: 4481 RVA: 0x0003F694 File Offset: 0x0003D894
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

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0003F69D File Offset: 0x0003D89D
		// (set) Token: 0x06001183 RID: 4483 RVA: 0x0003F6A5 File Offset: 0x0003D8A5
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

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001184 RID: 4484
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public abstract int PhysicalPageNumber { get; }

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0003F6AE File Offset: 0x0003D8AE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Reporting.ReportBase Report
		{
			get
			{
				return this._report;
			}
		}

		// Token: 0x06001186 RID: 4486
		public abstract global::System.Windows.Documents.DocumentPage GetPage(int pageNumber);

		// Token: 0x06001187 RID: 4487 RVA: 0x0003F6B6 File Offset: 0x0003D8B6
		public virtual void OnBeginPagination(global::Infragistics.Windows.Reporting.ReportBase report)
		{
			global::Infragistics.Windows.Utilities.ThrowIfNull(report, "report");
			this._report = report;
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0003F6CA File Offset: 0x0003D8CA
		public virtual void OnEndPagination()
		{
		}

		// Token: 0x04000914 RID: 2324
		private global::Infragistics.Windows.Reporting.ReportBase _report;

		// Token: 0x04000915 RID: 2325
		private object _pageFooter;

		// Token: 0x04000916 RID: 2326
		private object _pageHeader;

		// Token: 0x04000917 RID: 2327
		private global::System.Windows.Controls.DataTemplateSelector _pageHeaderTemplateSelector;

		// Token: 0x04000918 RID: 2328
		private global::System.Windows.Controls.DataTemplateSelector _pageContentTemplateSelector;

		// Token: 0x04000919 RID: 2329
		private global::System.Windows.Controls.DataTemplateSelector _pageFooterTemplateSelector;

		// Token: 0x0400091A RID: 2330
		private global::System.Windows.DataTemplate _pageFooterTemplate;

		// Token: 0x0400091B RID: 2331
		private global::System.Windows.DataTemplate _pageContentTemplate;

		// Token: 0x0400091C RID: 2332
		private global::System.Windows.DataTemplate _pageHeaderTemplate;

		// Token: 0x0400091D RID: 2333
		private global::System.Windows.Style _pagePresenterStyle;

		// Token: 0x0400091E RID: 2334
		private static readonly global::System.Windows.DependencyPropertyKey IsInReportPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsInReport", typeof(bool), typeof(global::Infragistics.Windows.Reporting.ReportSection), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x0400091F RID: 2335
		public static readonly global::System.Windows.DependencyProperty IsInReportProperty = global::Infragistics.Windows.Reporting.ReportSection.IsInReportPropertyKey.DependencyProperty;
	}
}
