using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000180 RID: 384
	public class DataPresenterOffice2k7BlackBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes.Locator>
	{
		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x0600160F RID: 5647 RVA: 0x000634BE File Offset: 0x000616BE
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

		// Token: 0x040008BA RID: 2234
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlackBrushes g_Instance;

		// Token: 0x02000181 RID: 385
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x06001611 RID: 5649 RVA: 0x000634DE File Offset: 0x000616DE
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000597 RID: 1431
			// (get) Token: 0x06001612 RID: 5650 RVA: 0x000634EB File Offset: 0x000616EB
			public override string Theme
			{
				get
				{
					return "Office2k7BlackBrushes";
				}
			}

			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x06001613 RID: 5651 RVA: 0x000634F2 File Offset: 0x000616F2
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x06001614 RID: 5652 RVA: 0x000634F9 File Offset: 0x000616F9
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
