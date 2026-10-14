using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CA RID: 202
	public class EditorsLunaOlive : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaOlive.Locator>
	{
		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x0002DE2D File Offset: 0x0002C02D
		public static global::Infragistics.Windows.Themes.EditorsLunaOlive Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaOlive.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaOlive.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaOlive();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaOlive.g_Instance;
			}
		}

		// Token: 0x040003AA RID: 938
		private static global::Infragistics.Windows.Themes.EditorsLunaOlive g_Instance;

		// Token: 0x020000CB RID: 203
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000290 RID: 656
			// (get) Token: 0x06000A54 RID: 2644 RVA: 0x0002DE4D File Offset: 0x0002C04D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000A55 RID: 2645 RVA: 0x0002DE5A File Offset: 0x0002C05A
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000A56 RID: 2646 RVA: 0x0002DE61 File Offset: 0x0002C061
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000A57 RID: 2647 RVA: 0x0002DE68 File Offset: 0x0002C068
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsLunaOlive_Express.xaml;ResourceSets\\Editors\\EditorsLunaOlive.xaml";
				}
			}
		}
	}
}
