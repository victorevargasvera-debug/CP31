using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000186 RID: 390
	public class DataPresenterOffice2010BlueBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.Locator>
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001624 RID: 5668 RVA: 0x0006359C File Offset: 0x0006179C
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.g_Instance;
			}
		}

		// Token: 0x040008BD RID: 2237
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes g_Instance;

		// Token: 0x02000187 RID: 391
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06001626 RID: 5670 RVA: 0x000635BC File Offset: 0x000617BC
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005A6 RID: 1446
			// (get) Token: 0x06001627 RID: 5671 RVA: 0x000635C9 File Offset: 0x000617C9
			public override string Theme
			{
				get
				{
					return "Office2010BlueBrushes";
				}
			}

			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x06001628 RID: 5672 RVA: 0x000635D0 File Offset: 0x000617D0
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x06001629 RID: 5673 RVA: 0x000635D7 File Offset: 0x000617D7
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOffice2010Blue_Brushes.xaml";
				}
			}
		}
	}
}
