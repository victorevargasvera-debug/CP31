using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000192 RID: 402
	public class DataPresenterPrintBasicBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes.Locator>
	{
		// Token: 0x170005C2 RID: 1474
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00063758 File Offset: 0x00061958
		public static global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes.g_Instance;
			}
		}

		// Token: 0x040008C3 RID: 2243
		private static global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes g_Instance;

		// Token: 0x02000193 RID: 403
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005C3 RID: 1475
			// (get) Token: 0x06001650 RID: 5712 RVA: 0x00063778 File Offset: 0x00061978
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005C4 RID: 1476
			// (get) Token: 0x06001651 RID: 5713 RVA: 0x00063785 File Offset: 0x00061985
			public override string Theme
			{
				get
				{
					return "PrintBrushes";
				}
			}

			// Token: 0x170005C5 RID: 1477
			// (get) Token: 0x06001652 RID: 5714 RVA: 0x0006378C File Offset: 0x0006198C
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005C6 RID: 1478
			// (get) Token: 0x06001653 RID: 5715 RVA: 0x00063793 File Offset: 0x00061993
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterPrintBasic_Brushes.xaml";
				}
			}
		}
	}
}
