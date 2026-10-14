using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000342 RID: 834
	public class DataPresenterOffice2k7Black : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.Locator>
	{
		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x000ABB85 File Offset: 0x000A9D85
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.g_Instance;
			}
		}

		// Token: 0x040012E0 RID: 4832
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black g_Instance;

		// Token: 0x02000343 RID: 835
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BEE RID: 3054
			// (get) Token: 0x060027B2 RID: 10162 RVA: 0x000ABBA5 File Offset: 0x000A9DA5
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BEF RID: 3055
			// (get) Token: 0x060027B3 RID: 10163 RVA: 0x000ABBB2 File Offset: 0x000A9DB2
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x17000BF0 RID: 3056
			// (get) Token: 0x060027B4 RID: 10164 RVA: 0x000ABBB9 File Offset: 0x000A9DB9
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BF1 RID: 3057
			// (get) Token: 0x060027B5 RID: 10165 RVA: 0x000ABBC0 File Offset: 0x000A9DC0
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOffice2k7Black_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOffice2k7Black.xaml";
				}
			}
		}
	}
}
