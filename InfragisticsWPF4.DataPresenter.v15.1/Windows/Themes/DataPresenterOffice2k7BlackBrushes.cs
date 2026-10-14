using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001A5 RID: 421
	public class DataPresenterOffice2k7BlackBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes.Locator>
	{
		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06001A37 RID: 6711 RVA: 0x00077B36 File Offset: 0x00075D36
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes.g_Instance;
			}
		}

		// Token: 0x04000AB0 RID: 2736
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes g_Instance;

		// Token: 0x020001A6 RID: 422
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06001A39 RID: 6713 RVA: 0x00077B56 File Offset: 0x00075D56
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000722 RID: 1826
			// (get) Token: 0x06001A3A RID: 6714 RVA: 0x00077B63 File Offset: 0x00075D63
			public override string Theme
			{
				get
				{
					return "Office2k7BlackBrushes";
				}
			}

			// Token: 0x17000723 RID: 1827
			// (get) Token: 0x06001A3B RID: 6715 RVA: 0x00077B6A File Offset: 0x00075D6A
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000724 RID: 1828
			// (get) Token: 0x06001A3C RID: 6716 RVA: 0x00077B71 File Offset: 0x00075D71
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOffice2k7Black_Brushes.xaml";
				}
			}
		}
	}
}
