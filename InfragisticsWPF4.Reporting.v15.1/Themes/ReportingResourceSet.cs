using System;
using System.Windows;
using Infragistics.Windows.Reporting;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200001B RID: 27
	public abstract class ReportingResourceSet<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00006372 File Offset: 0x00004572
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.ReportingResourceSet<T>.Location.Grouping;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600010B RID: 267 RVA: 0x0000637E File Offset: 0x0000457E
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.ReportingResourceSet<T>.Location.Theme;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000638C File Offset: 0x0000458C
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				global::System.Windows.ResourceDictionary resourcesInternal = global::Infragistics.Windows.Themes.ReportingResourceSet<T>.ResourcesInternal;
				base.VerifyResources();
				return resourcesInternal;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600010D RID: 269 RVA: 0x000063A6 File Offset: 0x000045A6
		public static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				if (global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_Location == null)
				{
					global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_Location = global::System.Activator.CreateInstance<T>();
				}
				return global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_Location;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000063C3 File Offset: 0x000045C3
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.ReportingResourceSet<T>.Location.Assembly, global::Infragistics.Windows.Themes.ReportingResourceSet<T>.Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000063EF File Offset: 0x000045EF
		public static global::System.Windows.Style ReportPagePresenter
		{
			get
			{
				if (global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ReportPagePresenter == null)
				{
					global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ReportPagePresenter = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.ReportingResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Reporting.ReportPagePresenter)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ReportPagePresenter;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000641B File Offset: 0x0000461B
		public static global::System.Windows.Style ReportProgressControl
		{
			get
			{
				if (global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ReportProgressControl == null)
				{
					global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ReportProgressControl = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.ReportingResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Reporting.ReportProgressControl)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_ReportProgressControl;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00006447 File Offset: 0x00004647
		public static global::System.Windows.Style XamReportPreview
		{
			get
			{
				if (global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_XamReportPreview == null)
				{
					global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_XamReportPreview = (global::Infragistics.Windows.Themes.ResourceSet.GetSealedResource(global::Infragistics.Windows.Themes.ReportingResourceSet<T>.ResourcesInternal, typeof(global::Infragistics.Windows.Reporting.XamReportPreview)) as global::System.Windows.Style);
				}
				return global::Infragistics.Windows.Themes.ReportingResourceSet<T>.g_XamReportPreview;
			}
		}

		// Token: 0x0400007A RID: 122
		internal const string GroupingName = "Reporting";

		// Token: 0x0400007B RID: 123
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x0400007C RID: 124
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;

		// Token: 0x0400007D RID: 125
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ReportPagePresenter;

		// Token: 0x0400007E RID: 126
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_ReportProgressControl;

		// Token: 0x0400007F RID: 127
		[global::System.ThreadStatic]
		private static global::System.Windows.Style g_XamReportPreview;
	}
}
