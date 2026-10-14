using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200017A RID: 378
	public class DataPresenterLunaNormalBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes.Locator>
	{
		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x000633E0 File Offset: 0x000615E0
		public static global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes.g_Instance;
			}
		}

		// Token: 0x040008B7 RID: 2231
		private static global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes g_Instance;

		// Token: 0x0200017B RID: 379
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x060015FC RID: 5628 RVA: 0x00063400 File Offset: 0x00061600
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000588 RID: 1416
			// (get) Token: 0x060015FD RID: 5629 RVA: 0x0006340D File Offset: 0x0006160D
			public override string Theme
			{
				get
				{
					return "LunaNormalBrushes";
				}
			}

			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x060015FE RID: 5630 RVA: 0x00063414 File Offset: 0x00061614
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x060015FF RID: 5631 RVA: 0x0006341B File Offset: 0x0006161B
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterLunaNormal_Brushes.xaml";
				}
			}
		}
	}
}
