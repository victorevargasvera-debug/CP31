using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Infragistics.Collections;
using Infragistics.Windows.Reporting.Events;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000006 RID: 6
	public class EmbeddedVisualReportSection : global::Infragistics.Windows.Reporting.ReportSection
	{
		// Token: 0x06000018 RID: 24 RVA: 0x0000243D File Offset: 0x0000063D
		public EmbeddedVisualReportSection(global::System.Windows.Media.Visual sourceVisual) : this(sourceVisual, sourceVisual as global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000244C File Offset: 0x0000064C
		public EmbeddedVisualReportSection(global::System.Windows.Media.Visual sourceVisual, global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator visualPaginator)
		{
			if (sourceVisual == null)
			{
				throw new global::System.ArgumentNullException("sourceVisual");
			}
			this._sourceVisual = sourceVisual;
			this._reportVisual = sourceVisual;
			if (visualPaginator != null)
			{
				this._visualPaginator = visualPaginator;
				this._wasPaginatorPassedIntoConstructor = true;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001A RID: 26 RVA: 0x000024A0 File Offset: 0x000006A0
		// (remove) Token: 0x0600001B RID: 27 RVA: 0x000024D8 File Offset: 0x000006D8
		public event global::System.EventHandler<global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs> PaginationEnded;

		// Token: 0x0600001C RID: 28 RVA: 0x0000250D File Offset: 0x0000070D
		protected virtual void OnPaginationEnded(global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs args)
		{
			if (this.PaginationEnded != null)
			{
				this.PaginationEnded(this, args);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002524 File Offset: 0x00000724
		internal void RaisePaginationEnded(global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator paginator)
		{
			global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs args = new global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs(paginator);
			this.OnPaginationEnded(args);
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600001E RID: 30 RVA: 0x00002540 File Offset: 0x00000740
		// (remove) Token: 0x0600001F RID: 31 RVA: 0x00002578 File Offset: 0x00000778
		public event global::System.EventHandler<global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs> PaginationStarted;

		// Token: 0x06000020 RID: 32 RVA: 0x000025AD File Offset: 0x000007AD
		protected virtual void OnPaginationStarted(global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs args)
		{
			if (this.PaginationStarted != null)
			{
				this.PaginationStarted(this, args);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000025C4 File Offset: 0x000007C4
		internal void RaisePaginationStarted(global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator paginator)
		{
			global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs args = new global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs(paginator);
			this.OnPaginationStarted(args);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000022 RID: 34 RVA: 0x000025E0 File Offset: 0x000007E0
		// (remove) Token: 0x06000023 RID: 35 RVA: 0x00002618 File Offset: 0x00000818
		public event global::System.EventHandler<global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs> PaginationStarting;

		// Token: 0x06000024 RID: 36 RVA: 0x0000264D File Offset: 0x0000084D
		protected virtual void OnPaginationStarting(global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs args)
		{
			if (this.PaginationStarting != null)
			{
				this.PaginationStarting(this, args);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002664 File Offset: 0x00000864
		internal void RaisePaginationStarting(global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator paginator)
		{
			global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs args = new global::Infragistics.Windows.Reporting.Events.EmbeddedVisualPaginationEventArgs(paginator);
			this.OnPaginationStarting(args);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000026 RID: 38 RVA: 0x0000267F File Offset: 0x0000087F
		internal int EstmatedPageCount
		{
			get
			{
				if (this.IsSinglePageSection)
				{
					return 1;
				}
				return this._visualPaginator.EstimatedPageCount;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002696 File Offset: 0x00000896
		internal bool IsSinglePageSection
		{
			get
			{
				return this._visualPaginator == null || this._isContentAreaTooSmallForPaginator;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000028 RID: 40 RVA: 0x000026A8 File Offset: 0x000008A8
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::System.Windows.Media.Visual SourceVisual
		{
			get
			{
				return this._sourceVisual;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000026B0 File Offset: 0x000008B0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator VisualPaginator
		{
			get
			{
				return this._visualPaginator;
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000026B8 File Offset: 0x000008B8
		public override global::System.Windows.Documents.DocumentPage GetPage(int pageNumber)
		{
			if (pageNumber < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.Reporting.XamReportPreview.GetString("LE_EmbeddedVisualReportSection_GetPage_LessThanZero"));
			}
			this._currentPageNumber = pageNumber + 1;
			this.InitializePageTemplates();
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (!this.IsSinglePageSection)
			{
				if (pageNumber == 0)
				{
					this._visualPaginator.MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition.FirstPage);
					this._pagePositions.Add(this._visualPaginator.CurrentPagePosition);
				}
				else if (pageNumber <= this._pageNumberOfLastGet)
				{
					this._visualPaginator.MoveToPosition(this._pagePositions[pageNumber]);
				}
				else
				{
					if (this._pagePositions.Count == 0)
					{
						this._visualPaginator.MoveToPosition(global::Infragistics.Windows.Reporting.PagePosition.FirstPage);
						this._pagePositions.Add(this._visualPaginator.CurrentPagePosition);
					}
					else if (!this._visualPaginator.CurrentPagePosition.Equals(this._pagePositions[this._pagePositions.Count - 1]))
					{
						this._visualPaginator.MoveToPosition(this._pagePositions[this._pagePositions.Count - 1]);
					}
					while (this._pageNumberOfLastGet < pageNumber)
					{
						if (!this._visualPaginator.MoveToNextPage())
						{
							return null;
						}
						this._pagePositions.Add(this._visualPaginator.CurrentPagePosition);
						this._pageNumberOfLastGet++;
					}
				}
				this._pagePresenter.DataContext = this._visualPaginator.CurrentPageDataContext;
				return this.CreateDocumentPage(this._pagePresenter);
			}
			if (pageNumber > 0)
			{
				return null;
			}
			this._pagePositions.Add(global::Infragistics.Windows.Reporting.PagePosition.LastPage);
			if (this._isContentAreaTooSmallForPaginator)
			{
				return this.CreateDocumentPage(new global::System.Windows.Controls.ContentControl
				{
					Padding = new global::System.Windows.Thickness(50.0),
					Content = new global::System.Windows.Controls.TextBlock
					{
						Width = this._pageSize.Width - 100.0,
						Height = this._pageSize.Height - 100.0,
						TextWrapping = global::System.Windows.TextWrapping.Wrap,
						Text = global::Infragistics.Windows.Reporting.XamReportPreview.GetString("PageContentAreaTooSmall", new object[]
						{
							this._pageSize,
							this._pagePresenter.ContentAreaAvailableSize,
							new global::System.Windows.Size(100.0, 100.0),
							this._pagePresenter.Margin.Left,
							this._pagePresenter.Margin.Top,
							this._pagePresenter.Margin.Right,
							this._pagePresenter.Margin.Bottom
						})
					}
				});
			}
			return this.CreateDocumentPage(this._pagePresenter);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002997 File Offset: 0x00000B97
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override int GeneratedPageCount
		{
			get
			{
				return this._pagePositions.Count;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000029A4 File Offset: 0x00000BA4
		public override bool IsEndReached
		{
			get
			{
				return this.IsSinglePageSection || this._visualPaginator.CurrentPagePosition == global::Infragistics.Windows.Reporting.PagePosition.LastPage;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000029C5 File Offset: 0x00000BC5
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return new global::Infragistics.Collections.SingleItemEnumerator(this._pagePresenter);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000029D2 File Offset: 0x00000BD2
		public override int LogicalPageNumber
		{
			get
			{
				if (this.IsSinglePageSection)
				{
					return 1;
				}
				return this._visualPaginator.LogicalPageNumber;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000029E9 File Offset: 0x00000BE9
		public override int LogicalPagePartNumber
		{
			get
			{
				if (this.IsSinglePageSection)
				{
					return 1;
				}
				return this._visualPaginator.LogicalPagePartNumber;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002A00 File Offset: 0x00000C00
		public override void OnBeginPagination(global::Infragistics.Windows.Reporting.ReportBase report)
		{
			if (this._sourceVisual is global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginatorFactory && !this._wasPaginatorPassedIntoConstructor)
			{
				global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginatorFactory embeddedVisualPaginatorFactory = this._sourceVisual as global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginatorFactory;
				this._visualPaginator = embeddedVisualPaginatorFactory.Create();
				if (this._visualPaginator == null)
				{
					throw new global::System.NullReferenceException(global::Infragistics.Windows.Reporting.XamReportPreview.GetString("LE_EmbeddedVisualReportSection_NullPaginator"));
				}
				if (this._visualPaginator is global::System.Windows.Media.Visual)
				{
					this._reportVisual = (this._visualPaginator as global::System.Windows.Media.Visual);
				}
			}
			if (this._reportVisual != null)
			{
				global::Infragistics.Windows.Reporting.ReportSection.SetIsInReport(this._reportVisual, true);
			}
			base.OnBeginPagination(report);
			this._pageNumberOfLastGet = 0;
			this._pagePositions.Clear();
			this._pageSize = report.PageSizeResolved;
			this._pageOrigin = report.PageOrigin;
			if (report.ReportSettings.PageOrientation == global::Infragistics.Windows.Reporting.PageOrientation.Landscape && this._pageSize.Width < this._pageSize.Height)
			{
				this._pageSize = new global::System.Windows.Size(this._pageSize.Height, this._pageSize.Width);
				this._pageOrigin = new global::System.Windows.Vector(this._pageOrigin.Y, this._pageOrigin.X);
			}
			this._pageSize.Width = this._pageSize.Width + this._pageOrigin.X;
			this._pageSize.Height = this._pageSize.Height + this._pageOrigin.Y;
			this.CreatePage();
			this.RaisePaginationStarting(this._visualPaginator);
			if (!this.IsSinglePageSection)
			{
				this._visualPaginator.BeginPagination(this);
			}
			this.RaisePaginationStarted(this._visualPaginator);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B8C File Offset: 0x00000D8C
		public override void OnEndPagination()
		{
			if (!this.IsSinglePageSection)
			{
				this._visualPaginator.EndPagination();
			}
			base.OnEndPagination();
			this.RaisePaginationEnded(this._visualPaginator);
			this.ReleasePage();
			if (this._reportVisual != null)
			{
				global::Infragistics.Windows.Reporting.ReportSection.SetIsInReport(this._reportVisual, false);
			}
			if (this._visualPaginator != null && !this._wasPaginatorPassedIntoConstructor)
			{
				if (this._visualPaginator == this._reportVisual)
				{
					this._reportVisual = null;
				}
				this._visualPaginator = null;
			}
			this._pagePositions.Clear();
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002C0F File Offset: 0x00000E0F
		public override int PhysicalPageNumber
		{
			get
			{
				return this._currentPageNumber;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002C18 File Offset: 0x00000E18
		private global::System.Windows.Documents.DocumentPage CreateDocumentPage(global::System.Windows.Media.Visual visual)
		{
			global::System.Windows.Rect rect = new global::System.Windows.Rect(this._pageSize);
			return new global::System.Windows.Documents.DocumentPage(visual, this._pageSize, rect, rect);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002C40 File Offset: 0x00000E40
		private void CreatePage()
		{
			if (base.Report == null)
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Reporting.XamReportPreview.GetString("LE_MustCallCreatePageWithinPagination"));
			}
			this.ReleasePage();
			this._isContentAreaTooSmallForPaginator = false;
			this._pagePresenter = new global::Infragistics.Windows.Reporting.ReportPagePresenter(this);
			this.InitializePageTemplates();
			base.AddLogicalChild(this._pagePresenter);
			global::Infragistics.Windows.Reporting.Report report = base.Report as global::Infragistics.Windows.Reporting.Report;
			if (report != null)
			{
				this._pagePresenter.Margin = report.ReportSettings.Margin;
			}
			this._pagePresenter.PageOriginInternal = this._pageOrigin;
			if (this._visualPaginator != null && this._reportVisual != null)
			{
				global::System.Windows.Data.BindingOperations.SetBinding(this._reportVisual, global::System.Windows.FrameworkContentElement.DataContextProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::System.Windows.FrameworkElement.DataContextProperty, global::System.Windows.Data.BindingMode.OneWay, this));
				this._pagePresenter.Content = this._reportVisual;
			}
			else
			{
				global::System.Windows.UIElement uielement = this._reportVisual as global::System.Windows.UIElement;
				double width;
				double height;
				if (uielement != null)
				{
					global::System.Windows.Size desiredSize = uielement.DesiredSize;
					width = desiredSize.Width;
					height = desiredSize.Height;
					if (desiredSize == default(global::System.Windows.Size))
					{
						uielement.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
						desiredSize = uielement.DesiredSize;
						uielement.Arrange(new global::System.Windows.Rect(desiredSize));
						uielement.UpdateLayout();
					}
					global::System.Windows.Size renderSize = uielement.RenderSize;
					if (renderSize.Height != 0.0 || renderSize.Width != 0.0)
					{
						width = renderSize.Width;
						height = renderSize.Height;
					}
				}
				else
				{
					global::System.Windows.Rect contentBounds = global::System.Windows.Media.VisualTreeHelper.GetContentBounds(this._reportVisual);
					width = contentBounds.Width;
					height = contentBounds.Height;
				}
				if (width != 0.0 && height != 0.0)
				{
					global::System.Windows.Media.VisualBrush visualBrush = new global::System.Windows.Media.VisualBrush(this._reportVisual);
					visualBrush.Stretch = global::System.Windows.Media.Stretch.None;
					visualBrush.AlignmentX = global::System.Windows.Media.AlignmentX.Left;
					visualBrush.AlignmentY = global::System.Windows.Media.AlignmentY.Top;
					global::System.Windows.Shapes.Rectangle rectangle = new global::System.Windows.Shapes.Rectangle();
					rectangle.Height = height;
					rectangle.Width = width;
					rectangle.Fill = visualBrush;
					rectangle.Measure(new global::System.Windows.Size(width, height));
					rectangle.Arrange(new global::System.Windows.Rect(0.0, 0.0, width, height));
					double num = 192.0;
					double num2 = 192.0;
					global::System.Windows.Media.Imaging.RenderTargetBitmap renderTargetBitmap = new global::System.Windows.Media.Imaging.RenderTargetBitmap((int)(width * num / 96.0), (int)(height * num2 / 96.0), num, num2, global::System.Windows.Media.PixelFormats.Pbgra32);
					renderTargetBitmap.Render(rectangle);
					global::System.Windows.Media.ImageBrush fill = new global::System.Windows.Media.ImageBrush(renderTargetBitmap);
					rectangle.Fill = fill;
					this._pagePresenter.InvalidateMeasure();
					this._pagePresenter.Measure(this._pageSize);
					this._pagePresenter.Arrange(new global::System.Windows.Rect(this._pageSize));
					global::System.Windows.Size renderSize2 = this._pagePresenter.RenderSize;
					if ((width > renderSize2.Width || height > renderSize2.Height) && base.Report.ReportSettings.HorizontalPaginationMode == global::Infragistics.Windows.Reporting.HorizontalPaginationMode.Scale)
					{
						double val = renderSize2.Width / width;
						double val2 = renderSize2.Height / height;
						double num3 = global::System.Math.Min(val2, val);
						rectangle.LayoutTransform = new global::System.Windows.Media.ScaleTransform(num3, num3);
					}
					this._pagePresenter.Content = rectangle;
				}
			}
			this._pagePresenter.InvalidateMeasure();
			this._pagePresenter.Measure(this._pageSize);
			this._pagePresenter.Arrange(new global::System.Windows.Rect(this._pageSize));
			this._pagePresenter.UpdateLayout();
			if (this._visualPaginator != null)
			{
				global::System.Windows.Size contentAreaAvailableSize = this._pagePresenter.ContentAreaAvailableSize;
				if (contentAreaAvailableSize.Width < 100.0 || contentAreaAvailableSize.Height < 100.0)
				{
					this._isContentAreaTooSmallForPaginator = true;
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003000 File Offset: 0x00001200
		private void InitializePageTemplates()
		{
			if (this._pagePresenter == null)
			{
				return;
			}
			this._pagePresenter.Header = this.SelectHeader();
			this._pagePresenter.HeaderTemplate = this.SelectHeaderTemplate();
			this._pagePresenter.HeaderTemplateSelector = this.SelectHeaderTemplateSelector();
			this._pagePresenter.ContentTemplate = this.SelectContentTemplate();
			this._pagePresenter.ContentTemplateSelector = this.SelectContentTemplateSelector();
			this._pagePresenter.Footer = this.SelectFooter();
			this._pagePresenter.FooterTemplate = this.SelectFooterTemplate();
			this._pagePresenter.FooterTemplateSelector = this.SelectFooterTemplateSelector();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000030A0 File Offset: 0x000012A0
		private void ReleasePage()
		{
			global::Infragistics.Windows.Reporting.ReportPagePresenter pagePresenter = this._pagePresenter;
			if (pagePresenter != null)
			{
				this._pagePresenter = null;
				pagePresenter.ClearValue(global::System.Windows.Controls.ContentControl.ContentProperty);
				pagePresenter.ClearValue(global::System.Windows.Controls.HeaderedContentControl.HeaderProperty);
				pagePresenter.ClearValue(global::Infragistics.Windows.Reporting.ReportPagePresenter.FooterProperty);
				base.RemoveLogicalChild(pagePresenter);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000030E8 File Offset: 0x000012E8
		private object SelectHeader()
		{
			if (base.PageHeader != null)
			{
				return base.PageHeader;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageHeader != null)
			{
				return report.PageHeader;
			}
			return null;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003120 File Offset: 0x00001320
		private global::System.Windows.DataTemplate SelectHeaderTemplate()
		{
			if (base.PageHeaderTemplate != null)
			{
				return base.PageHeaderTemplate;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageHeaderTemplate != null)
			{
				return report.PageHeaderTemplate;
			}
			return null;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003158 File Offset: 0x00001358
		private global::System.Windows.Controls.DataTemplateSelector SelectHeaderTemplateSelector()
		{
			if (base.PageHeaderTemplateSelector != null)
			{
				return base.PageHeaderTemplateSelector;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageHeaderTemplateSelector != null)
			{
				return report.PageHeaderTemplateSelector;
			}
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003190 File Offset: 0x00001390
		private object SelectFooter()
		{
			if (base.PageFooter != null)
			{
				return base.PageFooter;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageFooter != null)
			{
				return report.PageFooter;
			}
			return null;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000031C8 File Offset: 0x000013C8
		private global::System.Windows.DataTemplate SelectFooterTemplate()
		{
			if (base.PageFooterTemplate != null)
			{
				return base.PageFooterTemplate;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageFooterTemplate != null)
			{
				return report.PageFooterTemplate;
			}
			return null;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003200 File Offset: 0x00001400
		private global::System.Windows.Controls.DataTemplateSelector SelectFooterTemplateSelector()
		{
			if (base.PageFooterTemplateSelector != null)
			{
				return base.PageFooterTemplateSelector;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageFooterTemplateSelector != null)
			{
				return report.PageFooterTemplateSelector;
			}
			return null;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003238 File Offset: 0x00001438
		private global::System.Windows.DataTemplate SelectContentTemplate()
		{
			if (base.PageContentTemplate != null)
			{
				return base.PageContentTemplate;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageContentTemplate != null)
			{
				return report.PageContentTemplate;
			}
			return null;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003270 File Offset: 0x00001470
		private global::System.Windows.Controls.DataTemplateSelector SelectContentTemplateSelector()
		{
			if (base.PageContentTemplateSelector != null)
			{
				return base.PageContentTemplateSelector;
			}
			global::Infragistics.Windows.Reporting.ReportBase report = base.Report;
			if (report == null)
			{
				return null;
			}
			if (report.PageContentTemplateSelector != null)
			{
				return report.PageContentTemplateSelector;
			}
			return null;
		}

		// Token: 0x04000005 RID: 5
		private const double MinimumPageContentWidth = 100.0;

		// Token: 0x04000006 RID: 6
		private const double MinimumPageContentHeight = 100.0;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Size _pageSize;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Vector _pageOrigin;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Media.Visual _reportVisual;

		// Token: 0x0400000A RID: 10
		private global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator _visualPaginator;

		// Token: 0x0400000B RID: 11
		private global::Infragistics.Windows.Reporting.ReportPagePresenter _pagePresenter;

		// Token: 0x0400000C RID: 12
		private int _pageNumberOfLastGet = -1;

		// Token: 0x0400000D RID: 13
		private int _currentPageNumber;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Media.Visual _sourceVisual;

		// Token: 0x0400000F RID: 15
		private bool _wasPaginatorPassedIntoConstructor;

		// Token: 0x04000010 RID: 16
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Reporting.PagePosition> _pagePositions = new global::System.Collections.Generic.List<global::Infragistics.Windows.Reporting.PagePosition>();

		// Token: 0x04000011 RID: 17
		private bool _isContentAreaTooSmallForPaginator;
	}
}
