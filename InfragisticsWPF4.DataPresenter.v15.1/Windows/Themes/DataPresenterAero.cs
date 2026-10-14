using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000376 RID: 886
	public class DataPresenterAero : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterAero.Locator>
	{
		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x000C0547 File Offset: 0x000BE747
		public static global::Infragistics.Windows.Themes.DataPresenterAero Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterAero.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterAero.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterAero();
				}
				return global::Infragistics.Windows.Themes.DataPresenterAero.g_Instance;
			}
		}

		// Token: 0x040014FF RID: 5375
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterAero g_Instance;

		// Token: 0x02000377 RID: 887
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D19 RID: 3353
			// (get) Token: 0x06002B5B RID: 11099 RVA: 0x000C0567 File Offset: 0x000BE767
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D1A RID: 3354
			// (get) Token: 0x06002B5C RID: 11100 RVA: 0x000C0574 File Offset: 0x000BE774
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x17000D1B RID: 3355
			// (get) Token: 0x06002B5D RID: 11101 RVA: 0x000C057B File Offset: 0x000BE77B
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D1C RID: 3356
			// (get) Token: 0x06002B5E RID: 11102 RVA: 0x000C0582 File Offset: 0x000BE782
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterAero_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterAero.xaml";
				}
			}
		}
	}
}
