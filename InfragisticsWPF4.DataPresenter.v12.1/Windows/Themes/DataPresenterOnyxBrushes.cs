using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000188 RID: 392
	public class DataPresenterOnyxBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.Locator>
	{
		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x0600162B RID: 5675 RVA: 0x000635E6 File Offset: 0x000617E6
		public static global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes.g_Instance;
			}
		}

		// Token: 0x040008BE RID: 2238
		private static global::Infragistics.Windows.Themes.DataPresenterOnyxBrushes g_Instance;

		// Token: 0x02000189 RID: 393
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x0600162D RID: 5677 RVA: 0x00063606 File Offset: 0x00061806
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005AB RID: 1451
			// (get) Token: 0x0600162E RID: 5678 RVA: 0x00063613 File Offset: 0x00061813
			public override string Theme
			{
				get
				{
					return "OnyxBrushes";
				}
			}

			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x0600162F RID: 5679 RVA: 0x0006361A File Offset: 0x0006181A
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x06001630 RID: 5680 RVA: 0x00063621 File Offset: 0x00061821
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOnyx_Brushes.xaml";
				}
			}
		}
	}
}
