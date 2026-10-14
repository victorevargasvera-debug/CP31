using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001B7 RID: 439
	public class DataPresenterWashBaseLightBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes.Locator>
	{
		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06001A76 RID: 6774 RVA: 0x00077DD0 File Offset: 0x00075FD0
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

		// Token: 0x04000AB9 RID: 2745
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseLightBrushes g_Instance;

		// Token: 0x020001B8 RID: 440
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x06001A78 RID: 6776 RVA: 0x00077DF0 File Offset: 0x00075FF0
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x06001A79 RID: 6777 RVA: 0x00077DFD File Offset: 0x00075FFD
			public override string Theme
			{
				get
				{
					return "HighContrastBrushes";
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x06001A7A RID: 6778 RVA: 0x00077E04 File Offset: 0x00076004
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x06001A7B RID: 6779 RVA: 0x00077E0B File Offset: 0x0007600B
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
