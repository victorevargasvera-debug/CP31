using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001A3 RID: 419
	public class DataPresenterLunaSilverBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.Locator>
	{
		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00077AEC File Offset: 0x00075CEC
		public static global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.g_Instance;
			}
		}

		// Token: 0x04000AAF RID: 2735
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes g_Instance;

		// Token: 0x020001A4 RID: 420
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x06001A32 RID: 6706 RVA: 0x00077B0C File Offset: 0x00075D0C
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06001A33 RID: 6707 RVA: 0x00077B19 File Offset: 0x00075D19
			public override string Theme
			{
				get
				{
					return "LunaSilverBrushes";
				}
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06001A34 RID: 6708 RVA: 0x00077B20 File Offset: 0x00075D20
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06001A35 RID: 6709 RVA: 0x00077B27 File Offset: 0x00075D27
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterLunaSilver_Brushes.xaml";
				}
			}
		}
	}
}
