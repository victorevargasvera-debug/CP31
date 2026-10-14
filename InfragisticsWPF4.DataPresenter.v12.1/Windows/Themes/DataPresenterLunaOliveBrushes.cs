using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200017C RID: 380
	public class DataPresenterLunaOliveBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.Locator>
	{
		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x0006342A File Offset: 0x0006162A
		public static global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes.g_Instance;
			}
		}

		// Token: 0x040008B8 RID: 2232
		private static global::Infragistics.Windows.Themes.DataPresenterLunaOliveBrushes g_Instance;

		// Token: 0x0200017D RID: 381
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x06001603 RID: 5635 RVA: 0x0006344A File Offset: 0x0006164A
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700058D RID: 1421
			// (get) Token: 0x06001604 RID: 5636 RVA: 0x00063457 File Offset: 0x00061657
			public override string Theme
			{
				get
				{
					return "LunaOliveBrushes";
				}
			}

			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x06001605 RID: 5637 RVA: 0x0006345E File Offset: 0x0006165E
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x06001606 RID: 5638 RVA: 0x00063465 File Offset: 0x00061665
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterLunaOlive_Brushes.xaml";
				}
			}
		}
	}
}
