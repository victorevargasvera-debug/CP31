using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200001C RID: 28
	public class ReportingGeneric : global::Infragistics.Windows.Themes.ReportingResourceSet<global::Infragistics.Windows.Themes.ReportingGeneric.Locator>
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000647B File Offset: 0x0000467B
		public static global::Infragistics.Windows.Themes.ReportingGeneric Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.ReportingGeneric.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.ReportingGeneric.g_Instance = new global::Infragistics.Windows.Themes.ReportingGeneric();
				}
				return global::Infragistics.Windows.Themes.ReportingGeneric.g_Instance;
			}
		}

		// Token: 0x04000080 RID: 128
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.ReportingGeneric g_Instance;

		// Token: 0x0200001D RID: 29
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700005B RID: 91
			// (get) Token: 0x06000115 RID: 277 RVA: 0x0000649B File Offset: 0x0000469B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x06000116 RID: 278 RVA: 0x000064A8 File Offset: 0x000046A8
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x06000117 RID: 279 RVA: 0x000064AF File Offset: 0x000046AF
			public override string Grouping
			{
				get
				{
					return "Reporting";
				}
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x06000118 RID: 280 RVA: 0x000064B6 File Offset: 0x000046B6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Reporting\\ReportingGeneric.xaml";
				}
			}
		}
	}
}
