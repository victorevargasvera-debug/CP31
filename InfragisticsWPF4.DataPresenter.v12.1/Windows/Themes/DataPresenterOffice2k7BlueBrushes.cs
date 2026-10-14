using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000182 RID: 386
	public class DataPresenterOffice2k7BlueBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes.Locator>
	{
		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06001616 RID: 5654 RVA: 0x00063508 File Offset: 0x00061708
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes.g_Instance;
			}
		}

		// Token: 0x040008BB RID: 2235
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes g_Instance;

		// Token: 0x02000183 RID: 387
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x06001618 RID: 5656 RVA: 0x00063528 File Offset: 0x00061728
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700059C RID: 1436
			// (get) Token: 0x06001619 RID: 5657 RVA: 0x00063535 File Offset: 0x00061735
			public override string Theme
			{
				get
				{
					return "Office2k7BlueBrushes";
				}
			}

			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x0600161A RID: 5658 RVA: 0x0006353C File Offset: 0x0006173C
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x0600161B RID: 5659 RVA: 0x00063543 File Offset: 0x00061743
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOffice2k7Blue_Brushes.xaml";
				}
			}
		}
	}
}
