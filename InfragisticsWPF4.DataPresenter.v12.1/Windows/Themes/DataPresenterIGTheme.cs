using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200034E RID: 846
	public class DataPresenterIGTheme : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterIGTheme.Locator>
	{
		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x000ABD41 File Offset: 0x000A9F41
		public static global::Infragistics.Windows.Themes.DataPresenterIGTheme Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterIGTheme.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterIGTheme.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterIGTheme();
				}
				return global::Infragistics.Windows.Themes.DataPresenterIGTheme.g_Instance;
			}
		}

		// Token: 0x040012E6 RID: 4838
		private static global::Infragistics.Windows.Themes.DataPresenterIGTheme g_Instance;

		// Token: 0x0200034F RID: 847
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000C0C RID: 3084
			// (get) Token: 0x060027DC RID: 10204 RVA: 0x000ABD61 File Offset: 0x000A9F61
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000C0D RID: 3085
			// (get) Token: 0x060027DD RID: 10205 RVA: 0x000ABD6E File Offset: 0x000A9F6E
			public override string Theme
			{
				get
				{
					return "IGTheme";
				}
			}

			// Token: 0x17000C0E RID: 3086
			// (get) Token: 0x060027DE RID: 10206 RVA: 0x000ABD75 File Offset: 0x000A9F75
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000C0F RID: 3087
			// (get) Token: 0x060027DF RID: 10207 RVA: 0x000ABD7C File Offset: 0x000A9F7C
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterIGTheme_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterIGTheme.xaml";
				}
			}
		}
	}
}
