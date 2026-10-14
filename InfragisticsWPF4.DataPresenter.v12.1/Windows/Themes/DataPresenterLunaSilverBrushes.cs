using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200017E RID: 382
	public class DataPresenterLunaSilverBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.Locator>
	{
		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00063474 File Offset: 0x00061674
		public static global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes.g_Instance;
			}
		}

		// Token: 0x040008B9 RID: 2233
		private static global::Infragistics.Windows.Themes.DataPresenterLunaSilverBrushes g_Instance;

		// Token: 0x0200017F RID: 383
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x0600160A RID: 5642 RVA: 0x00063494 File Offset: 0x00061694
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000592 RID: 1426
			// (get) Token: 0x0600160B RID: 5643 RVA: 0x000634A1 File Offset: 0x000616A1
			public override string Theme
			{
				get
				{
					return "LunaSilverBrushes";
				}
			}

			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x0600160C RID: 5644 RVA: 0x000634A8 File Offset: 0x000616A8
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x0600160D RID: 5645 RVA: 0x000634AF File Offset: 0x000616AF
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterLunaSilver_Brushes.xaml";
				}
			}
		}
	}
}
