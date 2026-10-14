using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200033C RID: 828
	public class DataPresenterLunaOlive : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaOlive.Locator>
	{
		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600279B RID: 10139 RVA: 0x000ABAA7 File Offset: 0x000A9CA7
		public static global::Infragistics.Windows.Themes.DataPresenterLunaOlive Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaOlive.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaOlive.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaOlive();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaOlive.g_Instance;
			}
		}

		// Token: 0x040012DD RID: 4829
		private static global::Infragistics.Windows.Themes.DataPresenterLunaOlive g_Instance;

		// Token: 0x0200033D RID: 829
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BDF RID: 3039
			// (get) Token: 0x0600279D RID: 10141 RVA: 0x000ABAC7 File Offset: 0x000A9CC7
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BE0 RID: 3040
			// (get) Token: 0x0600279E RID: 10142 RVA: 0x000ABAD4 File Offset: 0x000A9CD4
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x17000BE1 RID: 3041
			// (get) Token: 0x0600279F RID: 10143 RVA: 0x000ABADB File Offset: 0x000A9CDB
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BE2 RID: 3042
			// (get) Token: 0x060027A0 RID: 10144 RVA: 0x000ABAE2 File Offset: 0x000A9CE2
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterLunaOlive_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterLunaOlive.xaml";
				}
			}
		}
	}
}
