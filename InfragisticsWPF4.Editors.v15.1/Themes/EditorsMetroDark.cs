using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000EA RID: 234
	public class EditorsMetroDark : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsMetroDark.Locator>
	{
		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00030239 File Offset: 0x0002E439
		public static global::Infragistics.Windows.Themes.EditorsMetroDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsMetroDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsMetroDark.g_Instance = new global::Infragistics.Windows.Themes.EditorsMetroDark();
				}
				return global::Infragistics.Windows.Themes.EditorsMetroDark.g_Instance;
			}
		}

		// Token: 0x040003ED RID: 1005
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsMetroDark g_Instance;

		// Token: 0x020000EB RID: 235
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002E6 RID: 742
			// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00030259 File Offset: 0x0002E459
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002E7 RID: 743
			// (get) Token: 0x06000B1E RID: 2846 RVA: 0x00030266 File Offset: 0x0002E466
			public override string Theme
			{
				get
				{
					return "MetroDark";
				}
			}

			// Token: 0x170002E8 RID: 744
			// (get) Token: 0x06000B1F RID: 2847 RVA: 0x0003026D File Offset: 0x0002E46D
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002E9 RID: 745
			// (get) Token: 0x06000B20 RID: 2848 RVA: 0x00030274 File Offset: 0x0002E474
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsMetroDark_Express.xaml;ResourceSets\\Editors\\EditorsMetroDark.xaml";
				}
			}
		}
	}
}
