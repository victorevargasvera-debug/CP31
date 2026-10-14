using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000178 RID: 376
	public class DataPresenterAeroBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterAeroBrushes.Locator>
	{
		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x060015F3 RID: 5619 RVA: 0x00063396 File Offset: 0x00061596
		public static global::Infragistics.Windows.Themes.DataPresenterAeroBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterAeroBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterAeroBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterAeroBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterAeroBrushes.g_Instance;
			}
		}

		// Token: 0x040008B6 RID: 2230
		private static global::Infragistics.Windows.Themes.DataPresenterAeroBrushes g_Instance;

		// Token: 0x02000179 RID: 377
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000582 RID: 1410
			// (get) Token: 0x060015F5 RID: 5621 RVA: 0x000633B6 File Offset: 0x000615B6
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000583 RID: 1411
			// (get) Token: 0x060015F6 RID: 5622 RVA: 0x000633C3 File Offset: 0x000615C3
			public override string Theme
			{
				get
				{
					return "AeroBrushes";
				}
			}

			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x060015F7 RID: 5623 RVA: 0x000633CA File Offset: 0x000615CA
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x060015F8 RID: 5624 RVA: 0x000633D1 File Offset: 0x000615D1
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterAero_Brushes.xaml";
				}
			}
		}
	}
}
