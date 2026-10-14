using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001B1 RID: 433
	public class DataPresenterRoyaleBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes.Locator>
	{
		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06001A61 RID: 6753 RVA: 0x00077CF2 File Offset: 0x00075EF2
		public static global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes.g_Instance;
			}
		}

		// Token: 0x04000AB6 RID: 2742
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes g_Instance;

		// Token: 0x020001B2 RID: 434
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001A63 RID: 6755 RVA: 0x00077D12 File Offset: 0x00075F12
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06001A64 RID: 6756 RVA: 0x00077D1F File Offset: 0x00075F1F
			public override string Theme
			{
				get
				{
					return "RoyaleBrushes";
				}
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06001A65 RID: 6757 RVA: 0x00077D26 File Offset: 0x00075F26
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06001A66 RID: 6758 RVA: 0x00077D2D File Offset: 0x00075F2D
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterRoyale_Brushes.xaml";
				}
			}
		}
	}
}
