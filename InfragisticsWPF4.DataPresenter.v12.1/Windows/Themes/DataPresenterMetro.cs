using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000350 RID: 848
	public class DataPresenterMetro : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterMetro.Locator>
	{
		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000ABD8B File Offset: 0x000A9F8B
		public static global::Infragistics.Windows.Themes.DataPresenterMetro Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterMetro.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterMetro.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterMetro();
				}
				return global::Infragistics.Windows.Themes.DataPresenterMetro.g_Instance;
			}
		}

		// Token: 0x040012E7 RID: 4839
		private static global::Infragistics.Windows.Themes.DataPresenterMetro g_Instance;

		// Token: 0x02000351 RID: 849
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000C11 RID: 3089
			// (get) Token: 0x060027E3 RID: 10211 RVA: 0x000ABDAB File Offset: 0x000A9FAB
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000C12 RID: 3090
			// (get) Token: 0x060027E4 RID: 10212 RVA: 0x000ABDB8 File Offset: 0x000A9FB8
			public override string Theme
			{
				get
				{
					return "Metro";
				}
			}

			// Token: 0x17000C13 RID: 3091
			// (get) Token: 0x060027E5 RID: 10213 RVA: 0x000ABDBF File Offset: 0x000A9FBF
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000C14 RID: 3092
			// (get) Token: 0x060027E6 RID: 10214 RVA: 0x000ABDC6 File Offset: 0x000A9FC6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterMetro.xaml";
				}
			}
		}
	}
}
