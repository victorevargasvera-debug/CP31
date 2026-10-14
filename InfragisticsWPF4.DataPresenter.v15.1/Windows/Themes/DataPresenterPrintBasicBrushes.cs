using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001B9 RID: 441
	public class DataPresenterPrintBasicBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes.Locator>
	{
		// Token: 0x17000752 RID: 1874
		// (get) Token: 0x06001A7D RID: 6781 RVA: 0x00077E1A File Offset: 0x0007601A
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

		// Token: 0x04000ABA RID: 2746
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterPrintBasicBrushes g_Instance;

		// Token: 0x020001BA RID: 442
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000753 RID: 1875
			// (get) Token: 0x06001A7F RID: 6783 RVA: 0x00077E3A File Offset: 0x0007603A
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000754 RID: 1876
			// (get) Token: 0x06001A80 RID: 6784 RVA: 0x00077E47 File Offset: 0x00076047
			public override string Theme
			{
				get
				{
					return "PrintBrushes";
				}
			}

			// Token: 0x17000755 RID: 1877
			// (get) Token: 0x06001A81 RID: 6785 RVA: 0x00077E4E File Offset: 0x0007604E
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000756 RID: 1878
			// (get) Token: 0x06001A82 RID: 6786 RVA: 0x00077E55 File Offset: 0x00076055
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
