using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000190 RID: 400
	public class DataPresenterWashBaseLightBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes.Locator>
	{
		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x0006370E File Offset: 0x0006190E
		public static global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes.g_Instance;
			}
		}

		// Token: 0x040008C2 RID: 2242
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes g_Instance;

		// Token: 0x02000191 RID: 401
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005BE RID: 1470
			// (get) Token: 0x06001649 RID: 5705 RVA: 0x0006372E File Offset: 0x0006192E
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005BF RID: 1471
			// (get) Token: 0x0600164A RID: 5706 RVA: 0x0006373B File Offset: 0x0006193B
			public override string Theme
			{
				get
				{
					return "HighContrastBrushes";
				}
			}

			// Token: 0x170005C0 RID: 1472
			// (get) Token: 0x0600164B RID: 5707 RVA: 0x00063742 File Offset: 0x00061942
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005C1 RID: 1473
			// (get) Token: 0x0600164C RID: 5708 RVA: 0x00063749 File Offset: 0x00061949
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterWashBaseLight_Brushes.xaml";
				}
			}
		}
	}
}
