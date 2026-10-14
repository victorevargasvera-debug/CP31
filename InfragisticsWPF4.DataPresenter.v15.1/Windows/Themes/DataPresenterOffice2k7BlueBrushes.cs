using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001A7 RID: 423
	public class DataPresenterOffice2k7BlueBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes.Locator>
	{
		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06001A3E RID: 6718 RVA: 0x00077B80 File Offset: 0x00075D80
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

		// Token: 0x04000AB1 RID: 2737
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7BlueBrushes g_Instance;

		// Token: 0x020001A8 RID: 424
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000726 RID: 1830
			// (get) Token: 0x06001A40 RID: 6720 RVA: 0x00077BA0 File Offset: 0x00075DA0
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000727 RID: 1831
			// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00077BAD File Offset: 0x00075DAD
			public override string Theme
			{
				get
				{
					return "Office2k7BlueBrushes";
				}
			}

			// Token: 0x17000728 RID: 1832
			// (get) Token: 0x06001A42 RID: 6722 RVA: 0x00077BB4 File Offset: 0x00075DB4
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000729 RID: 1833
			// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00077BBB File Offset: 0x00075DBB
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
