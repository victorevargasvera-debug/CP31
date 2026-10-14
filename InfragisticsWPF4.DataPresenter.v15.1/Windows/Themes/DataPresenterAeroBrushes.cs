using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200019D RID: 413
	public class DataPresenterAeroBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterAeroBrushes.Locator>
	{
		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00077A0E File Offset: 0x00075C0E
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

		// Token: 0x04000AAC RID: 2732
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterAeroBrushes g_Instance;

		// Token: 0x0200019E RID: 414
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700070D RID: 1805
			// (get) Token: 0x06001A1D RID: 6685 RVA: 0x00077A2E File Offset: 0x00075C2E
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700070E RID: 1806
			// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00077A3B File Offset: 0x00075C3B
			public override string Theme
			{
				get
				{
					return "AeroBrushes";
				}
			}

			// Token: 0x1700070F RID: 1807
			// (get) Token: 0x06001A1F RID: 6687 RVA: 0x00077A42 File Offset: 0x00075C42
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000710 RID: 1808
			// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00077A49 File Offset: 0x00075C49
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
