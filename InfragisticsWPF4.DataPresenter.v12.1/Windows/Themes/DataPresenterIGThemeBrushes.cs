using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000194 RID: 404
	public class DataPresenterIGThemeBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes.Locator>
	{
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x000637A2 File Offset: 0x000619A2
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

		// Token: 0x040008C4 RID: 2244
		private static global::Infragistics.Windows.Themes.DataPresenterIGThemeBrushes g_Instance;

		// Token: 0x02000195 RID: 405
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005C8 RID: 1480
			// (get) Token: 0x06001657 RID: 5719 RVA: 0x000637C2 File Offset: 0x000619C2
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005C9 RID: 1481
			// (get) Token: 0x06001658 RID: 5720 RVA: 0x000637CF File Offset: 0x000619CF
			public override string Theme
			{
				get
				{
					return "IGThemeBrushes";
				}
			}

			// Token: 0x170005CA RID: 1482
			// (get) Token: 0x06001659 RID: 5721 RVA: 0x000637D6 File Offset: 0x000619D6
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005CB RID: 1483
			// (get) Token: 0x0600165A RID: 5722 RVA: 0x000637DD File Offset: 0x000619DD
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
