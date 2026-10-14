using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000E0 RID: 224
	public class EditorsWashBaseDark : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsWashBaseDark.Locator>
	{
		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x000300C7 File Offset: 0x0002E2C7
		public static global::Infragistics.Windows.Themes.EditorsWashBaseDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsWashBaseDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsWashBaseDark.g_Instance = new global::Infragistics.Windows.Themes.EditorsWashBaseDark();
				}
				return global::Infragistics.Windows.Themes.EditorsWashBaseDark.g_Instance;
			}
		}

		// Token: 0x040003E8 RID: 1000
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsWashBaseDark g_Instance;

		// Token: 0x020000E1 RID: 225
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002CD RID: 717
			// (get) Token: 0x06000AFA RID: 2810 RVA: 0x000300E7 File Offset: 0x0002E2E7
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002CE RID: 718
			// (get) Token: 0x06000AFB RID: 2811 RVA: 0x000300F4 File Offset: 0x0002E2F4
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x170002CF RID: 719
			// (get) Token: 0x06000AFC RID: 2812 RVA: 0x000300FB File Offset: 0x0002E2FB
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002D0 RID: 720
			// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00030102 File Offset: 0x0002E302
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsWashBaseDark_Express.xaml;ResourceSets\\Editors\\EditorsWashBaseDark.xaml";
				}
			}
		}
	}
}
