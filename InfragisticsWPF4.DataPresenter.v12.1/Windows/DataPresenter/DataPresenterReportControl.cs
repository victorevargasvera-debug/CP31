using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;
using Infragistics.Windows.Editors;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000197 RID: 407
	internal class DataPresenterReportControl : global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase, global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator
	{
		// Token: 0x0600165D RID: 5725 RVA: 0x000637FE File Offset: 0x000619FE
		internal DataPresenterReportControl(global::Infragistics.Windows.DataPresenter.DataPresenterBase sourceDataPresenter) : base(sourceDataPresenter)
		{
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x00063808 File Offset: 0x00061A08
		protected override void OnBeginCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			base.OnBeginCloneSource(section);
			if (this._sectionContainer == null)
			{
				this._sectionContainer = new global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer();
				this._sectionContainer.Section = section;
				base.SourceDataPresenter.InternalAddLogicalChild(this._sectionContainer);
			}
			else
			{
				this._sectionContainer.Section = section;
			}
			object obj = base.ReadLocalValue(global::System.Windows.FrameworkElement.FlowDirectionProperty);
			if (obj == global::System.Windows.DependencyProperty.UnsetValue && this._sectionContainer.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				this._sectionContainer.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
				base.FlowDirection = global::System.Windows.FlowDirection.RightToLeft;
			}
		}

		// Token: 0x0600165F RID: 5727 RVA: 0x0006388F File Offset: 0x00061A8F
		protected override void OnCloneDataSourceRequested()
		{
			base.OnCloneDataSourceRequested();
			base.Style = global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.DataPresenterReportControlStyle;
			base.InvalidateMeasure();
			base.UpdateLayout();
			base.BindToDataSource();
			this.CreateFlattenedListOfData();
		}

		// Token: 0x06001660 RID: 5728 RVA: 0x000638BA File Offset: 0x00061ABA
		protected override void OnEndCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			base.OnEndCloneSource(section);
			((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).BeginPagination(section);
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x000638D4 File Offset: 0x00061AD4
		internal global::Infragistics.Windows.Reporting.ReportSection Section
		{
			get
			{
				if (this._sectionContainer == null)
				{
					return null;
				}
				return this._sectionContainer.Section as global::Infragistics.Windows.Reporting.ReportSection;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x000638F0 File Offset: 0x00061AF0
		private static global::System.Windows.Style DataPresenterReportControlStyle
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.s_DataPresenterReportControlStyle == null)
				{
					global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.s_DataPresenterReportControlStyle = new global::System.Windows.Style(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl));
					global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Border));
					global::System.Windows.FrameworkElementFactory frameworkElementFactory2 = new global::System.Windows.FrameworkElementFactory(typeof(global::System.Windows.Controls.Grid));
					frameworkElementFactory2.Name = "PART_ContentSiteGrid";
					frameworkElementFactory.SetBinding(global::System.Windows.Controls.Border.BackgroundProperty, global::Infragistics.Windows.Utilities.CreateBindingObjectLikeAlias(global::System.Windows.Controls.Control.BackgroundProperty));
					frameworkElementFactory.SetBinding(global::System.Windows.Controls.Border.BorderBrushProperty, global::Infragistics.Windows.Utilities.CreateBindingObjectLikeAlias(global::System.Windows.Controls.Control.BorderBrushProperty));
					frameworkElementFactory.SetBinding(global::System.Windows.Controls.Border.BorderThicknessProperty, global::Infragistics.Windows.Utilities.CreateBindingObjectLikeAlias(global::System.Windows.Controls.Control.BorderThicknessProperty));
					frameworkElementFactory.AppendChild(frameworkElementFactory2);
					global::System.Windows.Controls.ControlTemplate controlTemplate = new global::System.Windows.Controls.ControlTemplate(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl));
					controlTemplate.VisualTree = frameworkElementFactory;
					global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.s_DataPresenterReportControlStyle.Setters.Add(new global::System.Windows.Setter(global::System.Windows.Controls.Control.TemplateProperty, controlTemplate));
					global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.s_DataPresenterReportControlStyle.Seal();
				}
				return global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.s_DataPresenterReportControlStyle;
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000639CC File Offset: 0x00061BCC
		private void CreateFlattenedListOfData()
		{
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Record>(base.ViewableRecords.ScrollCount);
			global::Infragistics.Windows.DataPresenter.ReportRecordEnumerator reportRecordEnumerator = new global::Infragistics.Windows.DataPresenter.ReportRecordEnumerator(this, base.ViewableRecords, base.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.IExportOptions, list);
			reportRecordEnumerator.Process(null);
			if (list.Count == 0)
			{
				global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = base.ViewableRecords.FieldLayout;
				if (fieldLayout != null && fieldLayout.TemplateDataRecord != null)
				{
					list.Add(fieldLayout.TemplateDataRecord);
				}
			}
			base.CurrentRecordListControl.ItemsSource = list;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00063A4A File Offset: 0x00061C4A
		void global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.BeginPagination(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			base.CurrentViewInternal = global::Infragistics.Windows.DataPresenter.ReportViewBase.CloneView(base.SourceDataPresenter);
			base.SourceDataPresenter.ExportHelper.AccessAllRecords();
			base.CloneSourceDataPresenter(section, base.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.IExportOptions);
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x00063A7F File Offset: 0x00061C7F
		object global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.CurrentPageDataContext
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).CurrentPageDataContext;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00063A91 File Offset: 0x00061C91
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.EstimatedPageCount
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).EstimatedPageCount;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00063AA3 File Offset: 0x00061CA3
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPageNumber
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).LogicalPageNumber;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001668 RID: 5736 RVA: 0x00063AB5 File Offset: 0x00061CB5
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPagePartNumber
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).LogicalPagePartNumber;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00063AC7 File Offset: 0x00061CC7
		global::Infragistics.Windows.Reporting.PagePosition global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.CurrentPagePosition
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).CurrentPagePosition;
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00063ADC File Offset: 0x00061CDC
		void global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.EndPagination()
		{
			((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).EndPagination();
			if (this._sectionContainer != null)
			{
				this._sectionContainer.Section = null;
				base.SourceDataPresenter.InternalRemoveLogicalChild(this._sectionContainer);
				this._sectionContainer = null;
			}
			base.ClearResources();
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x00063B2B File Offset: 0x00061D2B
		bool global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.MoveToNextPage()
		{
			base.ScrollVersion++;
			return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).MoveToNextPage();
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x00063B4B File Offset: 0x00061D4B
		bool global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition pagePosition)
		{
			base.ScrollVersion++;
			return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).MoveToPosition(pagePosition);
		}

		// Token: 0x040008C5 RID: 2245
		private global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer _sectionContainer;

		// Token: 0x040008C6 RID: 2246
		private static global::System.Windows.Style s_DataPresenterReportControlStyle;

		// Token: 0x02000198 RID: 408
		internal class SectionContainer : global::System.Windows.FrameworkElement
		{
			// Token: 0x0600166D RID: 5741 RVA: 0x00063B6C File Offset: 0x00061D6C
			static SectionContainer()
			{
				global::System.Windows.RoutedEvent[] routedEventsForOwner = global::System.Windows.EventManager.GetRoutedEventsForOwner(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterBase));
				foreach (global::System.Windows.RoutedEvent routedEvent in routedEventsForOwner)
				{
					global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer), routedEvent, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer.OnRoutedEvent));
				}
				global::System.Windows.RoutedEvent editModeEndedEvent = global::Infragistics.Windows.Editors.ValueEditor.EditModeEndedEvent;
				routedEventsForOwner = global::System.Windows.EventManager.GetRoutedEventsForOwner(typeof(global::Infragistics.Windows.Editors.ValueEditor));
				if (routedEventsForOwner != null)
				{
					foreach (global::System.Windows.RoutedEvent routedEvent2 in routedEventsForOwner)
					{
						global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer), routedEvent2, new global::System.Windows.RoutedEventHandler(global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer.OnRoutedEvent));
					}
				}
			}

			// Token: 0x0600166E RID: 5742 RVA: 0x00063C0F File Offset: 0x00061E0F
			internal SectionContainer()
			{
			}

			// Token: 0x0600166F RID: 5743 RVA: 0x00063C17 File Offset: 0x00061E17
			private static void OnRoutedEvent(object sender, global::System.Windows.RoutedEventArgs e)
			{
				e.Handled = true;
			}

			// Token: 0x170005D3 RID: 1491
			// (get) Token: 0x06001670 RID: 5744 RVA: 0x00063C20 File Offset: 0x00061E20
			protected override global::System.Collections.IEnumerator LogicalChildren
			{
				get
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._section);
				}
			}

			// Token: 0x170005D4 RID: 1492
			// (get) Token: 0x06001671 RID: 5745 RVA: 0x00063C2D File Offset: 0x00061E2D
			// (set) Token: 0x06001672 RID: 5746 RVA: 0x00063C38 File Offset: 0x00061E38
			internal global::System.Windows.DependencyObject Section
			{
				get
				{
					return this._section;
				}
				set
				{
					if (value != this._section)
					{
						if (this._section != null && global::System.Windows.LogicalTreeHelper.GetParent(this._section) == this)
						{
							base.RemoveLogicalChild(this._section);
						}
						this._section = value;
						if (this._section != null)
						{
							global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer sectionContainer = global::System.Windows.LogicalTreeHelper.GetParent(value) as global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer;
							if (sectionContainer != null)
							{
								sectionContainer.RemoveLogicalChild(value);
							}
							base.AddLogicalChild(this._section);
						}
					}
				}
			}

			// Token: 0x040008C7 RID: 2247
			private global::System.Windows.DependencyObject _section;
		}
	}
}
