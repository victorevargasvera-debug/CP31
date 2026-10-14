using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000346 RID: 838
	public class DataPresenterOffice2010Blue : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.Locator>
	{
		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x000ABC19 File Offset: 0x000A9E19
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.g_Instance;
			}
		}

		// Token: 0x040012E2 RID: 4834
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue g_Instance;

		// Token: 0x02000347 RID: 839
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BF8 RID: 3064
			// (get) Token: 0x060027C0 RID: 10176 RVA: 0x000ABC39 File Offset: 0x000A9E39
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BF9 RID: 3065
			// (get) Token: 0x060027C1 RID: 10177 RVA: 0x000ABC46 File Offset: 0x000A9E46
			public override string Theme
			{
				get
				{
					return "Office2010Blue";
				}
			}

			// Token: 0x17000BFA RID: 3066
			// (get) Token: 0x060027C2 RID: 10178 RVA: 0x000ABC4D File Offset: 0x000A9E4D
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BFB RID: 3067
			// (get) Token: 0x060027C3 RID: 10179 RVA: 0x000ABC54 File Offset: 0x000A9E54
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOffice2010Blue_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOffice2010Blue.xaml";
				}
			}
		}
	}
}
