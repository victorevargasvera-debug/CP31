using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001BB RID: 443
	public class DataPresenterIGThemeBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes.Locator>
	{
		// Token: 0x17000757 RID: 1879
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x00077E64 File Offset: 0x00076064
		public static global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes.g_Instance;
			}
		}

		// Token: 0x04000ABB RID: 2747
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes g_Instance;

		// Token: 0x020001BC RID: 444
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000758 RID: 1880
			// (get) Token: 0x06001A86 RID: 6790 RVA: 0x00077E84 File Offset: 0x00076084
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000759 RID: 1881
			// (get) Token: 0x06001A87 RID: 6791 RVA: 0x00077E91 File Offset: 0x00076091
			public override string Theme
			{
				get
				{
					return "IGThemeBrushes";
				}
			}

			// Token: 0x1700075A RID: 1882
			// (get) Token: 0x06001A88 RID: 6792 RVA: 0x00077E98 File Offset: 0x00076098
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700075B RID: 1883
			// (get) Token: 0x06001A89 RID: 6793 RVA: 0x00077E9F File Offset: 0x0007609F
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterIGTheme_Brushes.xaml";
				}
			}
		}
	}
}
