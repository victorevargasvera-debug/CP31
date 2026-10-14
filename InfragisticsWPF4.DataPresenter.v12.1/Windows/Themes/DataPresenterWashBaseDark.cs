using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000348 RID: 840
	public class DataPresenterWashBaseDark : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.Locator>
	{
		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x000ABC63 File Offset: 0x000A9E63
		public static global::Infragistics.Windows.Themes.DataPresenterWashBaseDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterWashBaseDark();
				}
				return global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.g_Instance;
			}
		}

		// Token: 0x040012E3 RID: 4835
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseDark g_Instance;

		// Token: 0x02000349 RID: 841
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BFD RID: 3069
			// (get) Token: 0x060027C7 RID: 10183 RVA: 0x000ABC83 File Offset: 0x000A9E83
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BFE RID: 3070
			// (get) Token: 0x060027C8 RID: 10184 RVA: 0x000ABC90 File Offset: 0x000A9E90
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x17000BFF RID: 3071
			// (get) Token: 0x060027C9 RID: 10185 RVA: 0x000ABC97 File Offset: 0x000A9E97
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000C00 RID: 3072
			// (get) Token: 0x060027CA RID: 10186 RVA: 0x000ABC9E File Offset: 0x000A9E9E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterWashBaseDark.xaml";
				}
			}
		}
	}
}
