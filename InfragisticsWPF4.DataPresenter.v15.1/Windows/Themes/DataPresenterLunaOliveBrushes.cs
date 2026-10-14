using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001A1 RID: 417
	public class DataPresenterLunaOliveBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.Locator>
	{
		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001A29 RID: 6697 RVA: 0x00077AA2 File Offset: 0x00075CA2
		public static global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.g_Instance;
			}
		}

		// Token: 0x04000AAE RID: 2734
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes g_Instance;

		// Token: 0x020001A2 RID: 418
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000717 RID: 1815
			// (get) Token: 0x06001A2B RID: 6699 RVA: 0x00077AC2 File Offset: 0x00075CC2
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00077ACF File Offset: 0x00075CCF
			public override string Theme
			{
				get
				{
					return "LunaOliveBrushes";
				}
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x06001A2D RID: 6701 RVA: 0x00077AD6 File Offset: 0x00075CD6
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00077ADD File Offset: 0x00075CDD
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterLunaOlive_Brushes.xaml";
				}
			}
		}
	}
}
