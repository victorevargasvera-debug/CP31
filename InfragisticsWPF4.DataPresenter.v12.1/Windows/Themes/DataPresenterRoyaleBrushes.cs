using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200018A RID: 394
	public class DataPresenterRoyaleBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes.Locator>
	{
		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x00063630 File Offset: 0x00061830
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

		// Token: 0x040008BF RID: 2239
		private static global::Infragistics.Windows.Themes.DataPresenterRoyaleBrushes g_Instance;

		// Token: 0x0200018B RID: 395
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x06001634 RID: 5684 RVA: 0x00063650 File Offset: 0x00061850
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005B0 RID: 1456
			// (get) Token: 0x06001635 RID: 5685 RVA: 0x0006365D File Offset: 0x0006185D
			public override string Theme
			{
				get
				{
					return "RoyaleBrushes";
				}
			}

			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x06001636 RID: 5686 RVA: 0x00063664 File Offset: 0x00061864
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x06001637 RID: 5687 RVA: 0x0006366B File Offset: 0x0006186B
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
