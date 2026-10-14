using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200018E RID: 398
	public class DataPresenterWashBaseDarkBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes.Locator>
	{
		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x000636C4 File Offset: 0x000618C4
		public static global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes.g_Instance;
			}
		}

		// Token: 0x040008C1 RID: 2241
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes g_Instance;

		// Token: 0x0200018F RID: 399
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06001642 RID: 5698 RVA: 0x000636E4 File Offset: 0x000618E4
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005BA RID: 1466
			// (get) Token: 0x06001643 RID: 5699 RVA: 0x000636F1 File Offset: 0x000618F1
			public override string Theme
			{
				get
				{
					return "HighContrastBrushes";
				}
			}

			// Token: 0x170005BB RID: 1467
			// (get) Token: 0x06001644 RID: 5700 RVA: 0x000636F8 File Offset: 0x000618F8
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005BC RID: 1468
			// (get) Token: 0x06001645 RID: 5701 RVA: 0x000636FF File Offset: 0x000618FF
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterWashBaseDark_Brushes.xaml";
				}
			}
		}
	}
}
