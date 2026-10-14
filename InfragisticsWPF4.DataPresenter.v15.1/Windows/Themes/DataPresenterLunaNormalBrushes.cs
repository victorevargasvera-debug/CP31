using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200019F RID: 415
	public class DataPresenterLunaNormalBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes.Locator>
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00077A58 File Offset: 0x00075C58
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

		// Token: 0x04000AAD RID: 2733
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterLunaNormalBrushes g_Instance;

		// Token: 0x020001A0 RID: 416
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000712 RID: 1810
			// (get) Token: 0x06001A24 RID: 6692 RVA: 0x00077A78 File Offset: 0x00075C78
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000713 RID: 1811
			// (get) Token: 0x06001A25 RID: 6693 RVA: 0x00077A85 File Offset: 0x00075C85
			public override string Theme
			{
				get
				{
					return "LunaNormalBrushes";
				}
			}

			// Token: 0x17000714 RID: 1812
			// (get) Token: 0x06001A26 RID: 6694 RVA: 0x00077A8C File Offset: 0x00075C8C
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000715 RID: 1813
			// (get) Token: 0x06001A27 RID: 6695 RVA: 0x00077A93 File Offset: 0x00075C93
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
