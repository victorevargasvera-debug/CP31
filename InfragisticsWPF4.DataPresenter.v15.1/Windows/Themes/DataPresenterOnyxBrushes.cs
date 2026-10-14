using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001AF RID: 431
	public class DataPresenterOnyxBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.Locator>
	{
		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x06001A5A RID: 6746 RVA: 0x00077CA8 File Offset: 0x00075EA8
		public static global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.g_Instance;
			}
		}

		// Token: 0x04000AB5 RID: 2741
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes g_Instance;

		// Token: 0x020001B0 RID: 432
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06001A5C RID: 6748 RVA: 0x00077CC8 File Offset: 0x00075EC8
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06001A5D RID: 6749 RVA: 0x00077CD5 File Offset: 0x00075ED5
			public override string Theme
			{
				get
				{
					return "OnyxBrushes";
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06001A5E RID: 6750 RVA: 0x00077CDC File Offset: 0x00075EDC
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x06001A5F RID: 6751 RVA: 0x00077CE3 File Offset: 0x00075EE3
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOnyx_Brushes.xaml";
				}
			}
		}
	}
}
