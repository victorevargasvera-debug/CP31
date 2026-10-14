using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000DE RID: 222
	public class EditorsMetro : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsMetro.Locator>
	{
		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0002E111 File Offset: 0x0002C311
		public static global::Infragistics.Windows.Themes.EditorsMetro Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsMetro.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsMetro.g_Instance = new global::Infragistics.Windows.Themes.EditorsMetro();
				}
				return global::Infragistics.Windows.Themes.EditorsMetro.g_Instance;
			}
		}

		// Token: 0x040003B4 RID: 948
		private static global::Infragistics.Windows.Themes.EditorsMetro g_Instance;

		// Token: 0x020000DF RID: 223
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002C2 RID: 706
			// (get) Token: 0x06000A9A RID: 2714 RVA: 0x0002E131 File Offset: 0x0002C331
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x06000A9B RID: 2715 RVA: 0x0002E13E File Offset: 0x0002C33E
			public override string Theme
			{
				get
				{
					return "Metro";
				}
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0002E145 File Offset: 0x0002C345
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0002E14C File Offset: 0x0002C34C
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsMetro_Express.xaml;ResourceSets\\Editors\\EditorsMetro.xaml";
				}
			}
		}
	}
}
