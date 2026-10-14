using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001B5 RID: 437
	public class DataPresenterWashBaseDarkBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes.Locator>
	{
		// Token: 0x17000748 RID: 1864
		// (get) Token: 0x06001A6F RID: 6767 RVA: 0x00077D86 File Offset: 0x00075F86
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

		// Token: 0x04000AB8 RID: 2744
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseDarkBrushes g_Instance;

		// Token: 0x020001B6 RID: 438
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x06001A71 RID: 6769 RVA: 0x00077DA6 File Offset: 0x00075FA6
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06001A72 RID: 6770 RVA: 0x00077DB3 File Offset: 0x00075FB3
			public override string Theme
			{
				get
				{
					return "HighContrastBrushes";
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06001A73 RID: 6771 RVA: 0x00077DBA File Offset: 0x00075FBA
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06001A74 RID: 6772 RVA: 0x00077DC1 File Offset: 0x00075FC1
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
