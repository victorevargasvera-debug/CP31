using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200018C RID: 396
	public class DataPresenterRoyaleStrongBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.Locator>
	{
		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x0006367A File Offset: 0x0006187A
		public static global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes.g_Instance;
			}
		}

		// Token: 0x040008C0 RID: 2240
		private static global::Infragistics.Windows.Themes.DataPresenterRoyaleStrongBrushes g_Instance;

		// Token: 0x0200018D RID: 397
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x0600163B RID: 5691 RVA: 0x0006369A File Offset: 0x0006189A
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005B5 RID: 1461
			// (get) Token: 0x0600163C RID: 5692 RVA: 0x000636A7 File Offset: 0x000618A7
			public override string Theme
			{
				get
				{
					return "RoyaleStrongBrushes";
				}
			}

			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x0600163D RID: 5693 RVA: 0x000636AE File Offset: 0x000618AE
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x0600163E RID: 5694 RVA: 0x000636B5 File Offset: 0x000618B5
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterRoyaleStrong_Brushes.xaml";
				}
			}
		}
	}
}
