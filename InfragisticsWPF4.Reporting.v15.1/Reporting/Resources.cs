using System;
using System.Globalization;
using Infragistics.Shared;

namespace Infragistics.Windows.Reporting
{
	// Token: 0x02000018 RID: 24
	public sealed class Resources
	{
		// Token: 0x060000E9 RID: 233 RVA: 0x000061F8 File Offset: 0x000043F8
		private Resources()
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00006200 File Offset: 0x00004400
		public static global::Infragistics.Shared.ResourceCustomizer Customizer
		{
			get
			{
				return global::ResourceCustomizerLocator.Customizer;
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00006207 File Offset: 0x00004407
		public static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00006210 File Offset: 0x00004410
		public static string GetString(string name)
		{
			return global::SR.GetString(name);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00006218 File Offset: 0x00004418
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name)
		{
			return global::SR.GetDynamicResourceString(name, null, null);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00006222 File Offset: 0x00004422
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args)
		{
			return global::SR.GetDynamicResourceString(name, args, null);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000622C File Offset: 0x0000442C
		public static global::Infragistics.Shared.DynamicResourceString GetDynamicResourceString(string name, object[] args, global::System.Globalization.CultureInfo culture)
		{
			return global::SR.GetDynamicResourceString(name, args, culture);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00006236 File Offset: 0x00004436
		public static object GetObject(string name)
		{
			return global::SR.GetObject(name);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000623E File Offset: 0x0000443E
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.ProgressCancelButton instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString ProgressCancelButton
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("ProgressCancelButton");
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000624A File Offset: 0x0000444A
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.ProgressInitialDescription instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString ProgressInitialDescription
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("ProgressInitialDescription");
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00006256 File Offset: 0x00004456
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewPrintToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewPrintToolTip
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewPrintToolTip");
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00006262 File Offset: 0x00004462
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewZoomInToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewZoomInToolTip
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewZoomInToolTip");
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000626E File Offset: 0x0000446E
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewZoomOutToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewZoomOutToolTip
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewZoomOutToolTip");
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000627A File Offset: 0x0000447A
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewActualSizeToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewActualSizeToolTip
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewActualSizeToolTip");
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00006286 File Offset: 0x00004486
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewPageWidthToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewPageWidthToolTip
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewPageWidthToolTip");
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00006292 File Offset: 0x00004492
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewWholePageToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewWholePageToolTip
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewWholePageToolTip");
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000629E File Offset: 0x0000449E
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewTwoPagesToolTip instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewTwoPagesToolTip
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewTwoPagesToolTip");
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000FA RID: 250 RVA: 0x000062AA File Offset: 0x000044AA
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewContextMenuZoomIn instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewContextMenuZoomIn
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewContextMenuZoomIn");
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000062B6 File Offset: 0x000044B6
		[global::System.Obsolete("This property is deprecated. Use ResourcesReporting.XamReportPreviewContextMenuZoomOut instead.", false)]
		public static global::Infragistics.Shared.DynamicResourceString XamReportPreviewContextMenuZoomOut
		{
			get
			{
				return global::Infragistics.Windows.Reporting.Resources.GetDynamicResourceString("XamReportPreviewContextMenuZoomOut");
			}
		}
	}
}
