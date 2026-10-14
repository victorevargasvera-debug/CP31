using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001B3 RID: 435
	public class DataPresenterRoyaleStrongBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.Locator>
	{
		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001A68 RID: 6760 RVA: 0x00077D3C File Offset: 0x00075F3C
		public static global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.g_Instance;
			}
		}

		// Token: 0x04000AB7 RID: 2743
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes g_Instance;

		// Token: 0x020001B4 RID: 436
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06001A6A RID: 6762 RVA: 0x00077D5C File Offset: 0x00075F5C
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001A6B RID: 6763 RVA: 0x00077D69 File Offset: 0x00075F69
			public override string Theme
			{
				get
				{
					return "RoyaleStrongBrushes";
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06001A6C RID: 6764 RVA: 0x00077D70 File Offset: 0x00075F70
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06001A6D RID: 6765 RVA: 0x00077D77 File Offset: 0x00075F77
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterRoyaleStrong_Brushes.xaml";
				}
			}
		}
	}
}
