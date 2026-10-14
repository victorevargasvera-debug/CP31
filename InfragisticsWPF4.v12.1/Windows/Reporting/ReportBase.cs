using System;
using System.ComponentModel;
using System.Printing;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x020001D5 RID: 469
	public abstract class ReportBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001146 RID: 4422 RVA: 0x0003F108 File Offset: 0x0003D308
		// (set) Token: 0x06001147 RID: 4423 RVA: 0x0003F110 File Offset: 0x0003D310
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

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001148 RID: 4424 RVA: 0x0003F119 File Offset: 0x0003D319
		// (set) Token: 0x06001149 RID: 4425 RVA: 0x0003F121 File Offset: 0x0003D321
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

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600114A RID: 4426 RVA: 0x0003F12A File Offset: 0x0003D32A
		// (set) Token: 0x0600114B RID: 4427 RVA: 0x0003F132 File Offset: 0x0003D332
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

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0003F13B File Offset: 0x0003D33B
		// (set) Token: 0x0600114D RID: 4429 RVA: 0x0003F143 File Offset: 0x0003D343
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

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600114E RID: 4430 RVA: 0x0003F14C File Offset: 0x0003D34C
		// (set) Token: 0x0600114F RID: 4431 RVA: 0x0003F154 File Offset: 0x0003D354
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

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0003F15D File Offset: 0x0003D35D
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0003F165 File Offset: 0x0003D365
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

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001152 RID: 4434 RVA: 0x0003F16E File Offset: 0x0003D36E
		// (set) Token: 0x06001153 RID: 4435 RVA: 0x0003F176 File Offset: 0x0003D376
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

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0003F17F File Offset: 0x0003D37F
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0003F187 File Offset: 0x0003D387
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

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0003F190 File Offset: 0x0003D390
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(false)]
		public global::System.Windows.Size PageImageableAreaExtent
		{
			get
			{
				this.GetPageSizeInternal();
				return this._imageableAreaExtent;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001157 RID: 4439 RVA: 0x0003F19F File Offset: 0x0003D39F
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		public global::System.Windows.Vector PageOrigin
		{
			get
			{
				this.GetPageSizeInternal();
				return this._origin;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0003F1AE File Offset: 0x0003D3AE
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0003F1B6 File Offset: 0x0003D3B6
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

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x0600115A RID: 4442 RVA: 0x0003F1BF File Offset: 0x0003D3BF
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual global::System.Windows.Size PageSizeResolved
		{
			get
			{
				return this.GetPageSizeInternal();
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600115B RID: 4443
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public abstract global::Infragistics.Windows.Reporting.ReportSettings ReportSettings { get; }

		// Token: 0x0600115C RID: 4444 RVA: 0x0003F1C7 File Offset: 0x0003D3C7
		protected void ClearCachedOriginAndSize()
		{
			this._origin = default(global::System.Windows.Vector);
			this._imageableAreaExtent = global::System.Windows.Size.Empty;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x0003F1E0 File Offset: 0x0003D3E0
		private static global::System.Windows.Size GetPageSizeFromQueue(global::System.Printing.PrintQueue queue, out global::System.Windows.Vector origin, out global::System.Windows.Size imageableAreaExtent)
		{
			if (queue == null)
			{
				origin = default(global::System.Windows.Vector);
				imageableAreaExtent = global::System.Windows.Size.Empty;
				return global::System.Windows.Size.Empty;
			}
			global::System.Printing.PrintTicket printTicket = queue.UserPrintTicket;
			if (printTicket == null)
			{
				printTicket = queue.DefaultPrintTicket;
			}
			global::System.Printing.PageImageableArea pageImageableArea = null;
			try
			{
				global::System.Printing.PrintCapabilities printCapabilities;
				if (printTicket != null)
				{
					printCapabilities = queue.GetPrintCapabilities(printTicket);
				}
				else
				{
					printCapabilities = queue.GetPrintCapabilities();
				}
				pageImageableArea = printCapabilities.PageImageableArea;
			}
			catch (global::System.Printing.PrintQueueException)
			{
			}
			if (pageImageableArea != null)
			{
				origin = new global::System.Windows.Vector(pageImageableArea.OriginWidth, pageImageableArea.OriginHeight);
				imageableAreaExtent = new global::System.Windows.Size(pageImageableArea.ExtentWidth, pageImageableArea.ExtentHeight);
			}
			else
			{
				origin = default(global::System.Windows.Vector);
				imageableAreaExtent = global::System.Windows.Size.Empty;
			}
			if (printTicket != null)
			{
				global::System.Printing.PageMediaSize pageMediaSize = printTicket.PageMediaSize;
				if (pageMediaSize.Height != null && pageMediaSize.Width != null)
				{
					if (imageableAreaExtent.IsEmpty)
					{
						return new global::System.Windows.Size(pageMediaSize.Width.Value, pageMediaSize.Height.Value);
					}
					global::System.Windows.Size size = new global::System.Windows.Size(pageMediaSize.Width.Value, pageMediaSize.Height.Value);
					global::System.Windows.Size size2 = new global::System.Windows.Size(pageImageableArea.ExtentWidth, pageImageableArea.ExtentHeight);
					if (size.Width > size.Height != size2.Width > size2.Height)
					{
						double width = size.Width;
						size.Width = size.Height;
						size.Height = width;
					}
					return new global::System.Windows.Size(global::System.Math.Min(size2.Width, size.Width), global::System.Math.Min(size2.Height, size.Height));
				}
			}
			if (pageImageableArea != null)
			{
				return new global::System.Windows.Size(pageImageableArea.ExtentWidth, pageImageableArea.ExtentHeight);
			}
			return global::System.Windows.Size.Empty;
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0003F3B4 File Offset: 0x0003D5B4
		private global::System.Windows.Size GetPageSizeInternal()
		{
			global::Infragistics.Windows.Reporting.ReportSettings reportSettings = this.ReportSettings;
			global::Infragistics.Windows.Reporting.ReportSettings reportSettings2 = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastSettings) as global::Infragistics.Windows.Reporting.ReportSettings;
			if (reportSettings != reportSettings2 || (reportSettings != null && reportSettings.PageMetricsVersion != this._pageMetricsVersion))
			{
				this._imageableAreaExtent = global::System.Windows.Size.Empty;
			}
			if (!this._imageableAreaExtent.IsEmpty)
			{
				return this._imageableAreaExtent;
			}
			this._lastSettings = ((reportSettings != null) ? new global::System.WeakReference(reportSettings) : null);
			this._pageMetricsVersion = ((reportSettings != null) ? reportSettings.PageMetricsVersion : 0);
			this._origin = default(global::System.Windows.Vector);
			this._imageableAreaExtent = global::System.Windows.Size.Empty;
			global::System.Windows.Size size = global::System.Windows.Size.Empty;
			if (!this._accessFailed)
			{
				try
				{
					global::System.Printing.PrintQueue printQueue = (reportSettings != null) ? reportSettings.PrintQueue : null;
					if (printQueue != null)
					{
						size = global::Infragistics.Windows.Reporting.ReportBase.GetPageSizeFromQueue(printQueue, out this._origin, out this._imageableAreaExtent);
					}
					if (printQueue == null || size.IsEmpty)
					{
						size = global::Infragistics.Windows.Reporting.ReportBase.GetPageSizeFromQueue(global::System.Printing.LocalPrintServer.GetDefaultPrintQueue(), out this._origin, out this._imageableAreaExtent);
					}
				}
				catch (global::System.Exception)
				{
					this._accessFailed = true;
				}
			}
			global::System.Windows.Size result = global::System.Windows.Size.Empty;
			if (reportSettings != null)
			{
				result = reportSettings.PageSize;
				if (result.IsEmpty || result.Width < 1.0 || result.Height < 1.0)
				{
					result = size;
				}
				else if (!size.IsEmpty && size.Width > 0.0 && size.Height > 0.0)
				{
					result.Width = global::System.Math.Min(result.Width, size.Width);
					result.Height = global::System.Math.Min(result.Height, size.Height);
				}
			}
			else
			{
				result = size;
			}
			if (result.IsEmpty || result.Width < 1.0 || result.Height < 1.0)
			{
				result = new global::System.Windows.Size(816.0, 1056.0);
			}
			return result;
		}

		// Token: 0x04000903 RID: 2307
		private global::System.Windows.Controls.DataTemplateSelector _pageHeaderTemplateSelector;

		// Token: 0x04000904 RID: 2308
		private global::System.Windows.Controls.DataTemplateSelector _pageContentTemplateSelector;

		// Token: 0x04000905 RID: 2309
		private global::System.Windows.Controls.DataTemplateSelector _pageFooterTemplateSelector;

		// Token: 0x04000906 RID: 2310
		private global::System.Windows.DataTemplate _pageFooterTemplate;

		// Token: 0x04000907 RID: 2311
		private global::System.Windows.DataTemplate _pageContentTemplate;

		// Token: 0x04000908 RID: 2312
		private global::System.Windows.DataTemplate _pageHeaderTemplate;

		// Token: 0x04000909 RID: 2313
		private object _pageFooter;

		// Token: 0x0400090A RID: 2314
		private object _pageHeader;

		// Token: 0x0400090B RID: 2315
		private global::System.Windows.Style _pagePresenterStyle;

		// Token: 0x0400090C RID: 2316
		private bool _accessFailed;

		// Token: 0x0400090D RID: 2317
		private global::System.Windows.Vector _origin = default(global::System.Windows.Vector);

		// Token: 0x0400090E RID: 2318
		private global::System.Windows.Size _imageableAreaExtent = global::System.Windows.Size.Empty;

		// Token: 0x0400090F RID: 2319
		private int _pageMetricsVersion;

		// Token: 0x04000910 RID: 2320
		private global::System.WeakReference _lastSettings;
	}
}
