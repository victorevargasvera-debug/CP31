using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000184 RID: 388
	public class DataPresenterOffice2k7SilverBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes.Locator>
	{
		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00063552 File Offset: 0x00061752
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

		// Token: 0x040008BC RID: 2236
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7SilverBrushes g_Instance;

		// Token: 0x02000185 RID: 389
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x0600161F RID: 5663 RVA: 0x00063572 File Offset: 0x00061772
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005A1 RID: 1441
			// (get) Token: 0x06001620 RID: 5664 RVA: 0x0006357F File Offset: 0x0006177F
			public override string Theme
			{
				get
				{
					return "Office2k7SilverBrushes";
				}
			}

			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x06001621 RID: 5665 RVA: 0x00063586 File Offset: 0x00061786
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x06001622 RID: 5666 RVA: 0x0006358D File Offset: 0x0006178D
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
