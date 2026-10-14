using System;
using System.ComponentModel;
using System.Printing;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000203 RID: 515
	public abstract class ReportBase : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x06001318 RID: 4888 RVA: 0x0004486C File Offset: 0x00042A6C
		// (set) Token: 0x06001319 RID: 4889 RVA: 0x00044874 File Offset: 0x00042A74
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

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x0600131A RID: 4890 RVA: 0x0004487D File Offset: 0x00042A7D
		// (set) Token: 0x0600131B RID: 4891 RVA: 0x00044885 File Offset: 0x00042A85
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

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x0600131C RID: 4892 RVA: 0x0004488E File Offset: 0x00042A8E
		// (set) Token: 0x0600131D RID: 4893 RVA: 0x00044896 File Offset: 0x00042A96
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

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x0600131E RID: 4894 RVA: 0x0004489F File Offset: 0x00042A9F
		// (set) Token: 0x0600131F RID: 4895 RVA: 0x000448A7 File Offset: 0x00042AA7
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

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001320 RID: 4896 RVA: 0x000448B0 File Offset: 0x00042AB0
		// (set) Token: 0x06001321 RID: 4897 RVA: 0x000448B8 File Offset: 0x00042AB8
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

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001322 RID: 4898 RVA: 0x000448C1 File Offset: 0x00042AC1
		// (set) Token: 0x06001323 RID: 4899 RVA: 0x000448C9 File Offset: 0x00042AC9
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

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06001324 RID: 4900 RVA: 0x000448D2 File Offset: 0x00042AD2
		// (set) Token: 0x06001325 RID: 4901 RVA: 0x000448DA File Offset: 0x00042ADA
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

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001326 RID: 4902 RVA: 0x000448E3 File Offset: 0x00042AE3
		// (set) Token: 0x06001327 RID: 4903 RVA: 0x000448EB File Offset: 0x00042AEB
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

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001328 RID: 4904 RVA: 0x000448F4 File Offset: 0x00042AF4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		public global::System.Windows.Size PageImageableAreaExtent
		{
			get
			{
				this.GetPageSizeInternal();
				return this._imageableAreaExtent;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x00044903 File Offset: 0x00042B03
		[global::System.ComponentModel.Bindable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Windows.Vector PageOrigin
		{
			get
			{
				this.GetPageSizeInternal();
				return this._origin;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x0600132A RID: 4906 RVA: 0x00044912 File Offset: 0x00042B12
		// (set) Token: 0x0600132B RID: 4907 RVA: 0x0004491A File Offset: 0x00042B1A
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

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x0600132C RID: 4908 RVA: 0x00044923 File Offset: 0x00042B23
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(false)]
		public virtual global::System.Windows.Size PageSizeResolved
		{
			get
			{
				return this.GetPageSizeInternal();
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x0600132D RID: 4909
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public abstract global::Infragistics.Windows.Reporting.ReportSettings ReportSettings { get; }

		// Token: 0x0600132E RID: 4910 RVA: 0x0004492B File Offset: 0x00042B2B
		protected void ClearCachedOriginAndSize()
		{
			this._origin = default(global::System.Windows.Vector);
			this._imageableAreaExtent = global::System.Windows.Size.Empty;
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x00044944 File Offset: 0x00042B44
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

		// Token: 0x06001330 RID: 4912 RVA: 0x00044B18 File Offset: 0x00042D18
		private global::System.Windows.Size GetPageSizeInternal()
		{
			global::Infragistics.Windows.Reporting.ReportSettings reportSettings = this.ReportSettings;
			global::Infragistics.Windows.Reporting.ReportSettings reportSettings2 = global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._lastSettings) as global::Infragistics.Windows.Reporting.ReportSettings;
			if (reportSettings != reportSettings2 || (reportSettings != null && reportSettings.PageMetricsVersion != this._pageMetricsVersion))
			{
				this._previousPageSize = global::System.Windows.Size.Empty;
				this._imageableAreaExtent = global::System.Windows.Size.Empty;
			}
			if (!this._previousPageSize.IsEmpty)
			{
				return this._previousPageSize;
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
			global::System.Windows.Size size2 = global::System.Windows.Size.Empty;
			if (reportSettings != null)
			{
				size2 = reportSettings.PageSize;
				global::System.Printing.PageMediaSize pageMediaSize = reportSettings.PageMediaSize;
				if (pageMediaSize != null)
				{
					if (pageMediaSize.Width != null)
					{
						double? width = pageMediaSize.Width;
						if (width.GetValueOrDefault() > 0.0 && width != null)
						{
							size2.Width = pageMediaSize.Width.Value;
						}
					}
					if (pageMediaSize.Height != null)
					{
						double? height = pageMediaSize.Height;
						if (height.GetValueOrDefault() > 0.0 && height != null)
						{
							size2.Height = pageMediaSize.Height.Value;
						}
					}
				}
				if (size2.IsEmpty || size2.Width < 1.0 || size2.Height < 1.0)
				{
					size2 = size;
				}
				else if (!size.IsEmpty && size.Width > 0.0 && size.Height > 0.0)
				{
					size2.Width = global::System.Math.Min(size2.Width, size.Width);
					size2.Height = global::System.Math.Min(size2.Height, size.Height);
				}
			}
			else
			{
				size2 = size;
			}
			if (size2.IsEmpty || size2.Width < 1.0 || size2.Height < 1.0)
			{
				size2 = new global::System.Windows.Size(816.0, 1056.0);
			}
			this._previousPageSize = size2;
			return size2;
		}

		// Token: 0x04000A45 RID: 2629
		private global::System.Windows.Controls.DataTemplateSelector _pageHeaderTemplateSelector;

		// Token: 0x04000A46 RID: 2630
		private global::System.Windows.Controls.DataTemplateSelector _pageContentTemplateSelector;

		// Token: 0x04000A47 RID: 2631
		private global::System.Windows.Controls.DataTemplateSelector _pageFooterTemplateSelector;

		// Token: 0x04000A48 RID: 2632
		private global::System.Windows.DataTemplate _pageFooterTemplate;

		// Token: 0x04000A49 RID: 2633
		private global::System.Windows.DataTemplate _pageContentTemplate;

		// Token: 0x04000A4A RID: 2634
		private global::System.Windows.DataTemplate _pageHeaderTemplate;

		// Token: 0x04000A4B RID: 2635
		private object _pageFooter;

		// Token: 0x04000A4C RID: 2636
		private object _pageHeader;

		// Token: 0x04000A4D RID: 2637
		private global::System.Windows.Style _pagePresenterStyle;

		// Token: 0x04000A4E RID: 2638
		private bool _accessFailed;

		// Token: 0x04000A4F RID: 2639
		private global::System.Windows.Vector _origin = default(global::System.Windows.Vector);

		// Token: 0x04000A50 RID: 2640
		private global::System.Windows.Size _imageableAreaExtent = global::System.Windows.Size.Empty;

		// Token: 0x04000A51 RID: 2641
		private global::System.Windows.Size _previousPageSize = global::System.Windows.Size.Empty;

		// Token: 0x04000A52 RID: 2642
		private int _pageMetricsVersion;

		// Token: 0x04000A53 RID: 2643
		private global::System.WeakReference _lastSettings;
	}
}
