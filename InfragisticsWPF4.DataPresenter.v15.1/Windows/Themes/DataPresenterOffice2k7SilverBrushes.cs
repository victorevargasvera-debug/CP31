using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001A9 RID: 425
	public class DataPresenterOffice2k7SilverBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes.Locator>
	{
		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00077BCA File Offset: 0x00075DCA
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes.g_Instance;
			}
		}

		// Token: 0x04000AB2 RID: 2738
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes g_Instance;

		// Token: 0x020001AA RID: 426
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700072B RID: 1835
			// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00077BEA File Offset: 0x00075DEA
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700072C RID: 1836
			// (get) Token: 0x06001A48 RID: 6728 RVA: 0x00077BF7 File Offset: 0x00075DF7
			public override string Theme
			{
				get
				{
					return "Office2k7SilverBrushes";
				}
			}

			// Token: 0x1700072D RID: 1837
			// (get) Token: 0x06001A49 RID: 6729 RVA: 0x00077BFE File Offset: 0x00075DFE
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700072E RID: 1838
			// (get) Token: 0x06001A4A RID: 6730 RVA: 0x00077C05 File Offset: 0x00075E05
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOffice2k7Silver_Brushes.xaml";
				}
			}
		}
	}
}
