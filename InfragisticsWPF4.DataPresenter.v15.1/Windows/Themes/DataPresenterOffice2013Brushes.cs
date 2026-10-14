using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001AD RID: 429
	public class DataPresenterOffice2013Brushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2013Brushes.Locator>
	{
		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x06001A53 RID: 6739 RVA: 0x00077C5E File Offset: 0x00075E5E
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2013Brushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2013Brushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2013Brushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2013Brushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2013Brushes.g_Instance;
			}
		}

		// Token: 0x04000AB4 RID: 2740
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2013Brushes g_Instance;

		// Token: 0x020001AE RID: 430
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000735 RID: 1845
			// (get) Token: 0x06001A55 RID: 6741 RVA: 0x00077C7E File Offset: 0x00075E7E
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06001A56 RID: 6742 RVA: 0x00077C8B File Offset: 0x00075E8B
			public override string Theme
			{
				get
				{
					return "Office2013Brushes";
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06001A57 RID: 6743 RVA: 0x00077C92 File Offset: 0x00075E92
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06001A58 RID: 6744 RVA: 0x00077C99 File Offset: 0x00075E99
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOffice2013_Brushes.xaml";
				}
			}
		}
	}
}
