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
	// Token: 0x020001BE RID: 446
	internal class DataPresenterReportControl : global::Infragistics.Windows.DataPresenter.DataPresenterExportControlBase, global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator
	{
		// Token: 0x06001A8C RID: 6796 RVA: 0x00077EC0 File Offset: 0x000760C0
		internal DataPresenterReportControl(global::Infragistics.Windows.DataPresenter.DataPresenterBase sourceDataPresenter) : base(sourceDataPresenter)
		{
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001A8D RID: 6797 RVA: 0x00077EC9 File Offset: 0x000760C9
		internal override bool IsTreeView
		{
			get
			{
				return base.CurrentViewInternal.IsTreeView;
			}
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x00077ED8 File Offset: 0x000760D8
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

		// Token: 0x06001A8F RID: 6799 RVA: 0x00077F5F File Offset: 0x0007615F
		protected override void OnCloneDataSourceRequested()
		{
			base.OnCloneDataSourceRequested();
			base.Style = global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.DataPresenterReportControlStyle;
			base.InvalidateMeasure();
			base.UpdateLayout();
			base.BindToDataSource();
			this.CreateFlattenedListOfData();
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x00077F8A File Offset: 0x0007618A
		protected override void OnEndCloneSource(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			base.OnEndCloneSource(section);
			((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).BeginPagination(section);
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001A91 RID: 6801 RVA: 0x00077FA4 File Offset: 0x000761A4
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

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x06001A92 RID: 6802 RVA: 0x00077FC0 File Offset: 0x000761C0
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

		// Token: 0x06001A93 RID: 6803 RVA: 0x0007809C File Offset: 0x0007629C
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

		// Token: 0x06001A94 RID: 6804 RVA: 0x0007811A File Offset: 0x0007631A
		void global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.BeginPagination(global::Infragistics.Windows.Reporting.ReportSection section)
		{
			base.CurrentViewInternal = global::Infragistics.Windows.DataPresenter.ReportViewBase.CloneView(base.SourceDataPresenter);
			base.SourceDataPresenter.ExportHelper.AccessAllRecords();
			base.CloneSourceDataPresenter(section, base.CurrentViewInternal as global::Infragistics.Windows.DataPresenter.IExportOptions);
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0007814F File Offset: 0x0007634F
		object global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.CurrentPageDataContext
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).CurrentPageDataContext;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06001A96 RID: 6806 RVA: 0x00078161 File Offset: 0x00076361
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.EstimatedPageCount
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).EstimatedPageCount;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06001A97 RID: 6807 RVA: 0x00078173 File Offset: 0x00076373
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPageNumber
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).LogicalPageNumber;
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001A98 RID: 6808 RVA: 0x00078185 File Offset: 0x00076385
		int global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.LogicalPagePartNumber
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).LogicalPagePartNumber;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x00078197 File Offset: 0x00076397
		global::Infragistics.Windows.Reporting.PagePosition global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.CurrentPagePosition
		{
			get
			{
				return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).CurrentPagePosition;
			}
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000781AC File Offset: 0x000763AC
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

		// Token: 0x06001A9B RID: 6811 RVA: 0x000781FB File Offset: 0x000763FB
		bool global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.MoveToNextPage()
		{
			base.ScrollVersion++;
			return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).MoveToNextPage();
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0007821B File Offset: 0x0007641B
		bool global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator.MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition pagePosition)
		{
			base.ScrollVersion++;
			return ((global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)base.CurrentPanel).MoveToPosition(pagePosition);
		}

		// Token: 0x04000ABC RID: 2748
		private global::Infragistics.Windows.DataPresenter.DataPresenterReportControl.SectionContainer _sectionContainer;

		// Token: 0x04000ABD RID: 2749
		private static global::System.Windows.Style s_DataPresenterReportControlStyle;

		// Token: 0x020001BF RID: 447
		internal class SectionContainer : global::System.Windows.FrameworkElement
		{
			// Token: 0x06001A9D RID: 6813 RVA: 0x0007823C File Offset: 0x0007643C
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

			// Token: 0x06001A9E RID: 6814 RVA: 0x000782DF File Offset: 0x000764DF
			internal SectionContainer()
			{
			}

			// Token: 0x06001A9F RID: 6815 RVA: 0x000782E7 File Offset: 0x000764E7
			private static void OnRoutedEvent(object sender, global::System.Windows.RoutedEventArgs e)
			{
				e.Handled = true;
			}

			// Token: 0x17000764 RID: 1892
			// (get) Token: 0x06001AA0 RID: 6816 RVA: 0x000782F0 File Offset: 0x000764F0
			protected override global::System.Collections.IEnumerator LogicalChildren
			{
				get
				{
					return new global::Infragistics.Collections.SingleItemEnumerator(this._section);
				}
			}

			// Token: 0x17000765 RID: 1893
			// (get) Token: 0x06001AA1 RID: 6817 RVA: 0x000782FD File Offset: 0x000764FD
			// (set) Token: 0x06001AA2 RID: 6818 RVA: 0x00078308 File Offset: 0x00076508
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

			// Token: 0x04000ABE RID: 2750
			private global::System.Windows.DependencyObject _section;
		}
	}
}
