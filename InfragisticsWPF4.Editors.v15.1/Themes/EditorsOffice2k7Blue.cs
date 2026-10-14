using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D8 RID: 216
	public class EditorsOffice2k7Blue : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Blue.Locator>
	{
		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x0002FF9F File Offset: 0x0002E19F
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2k7Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2k7Blue.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7Blue();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2k7Blue.g_Instance;
			}
		}

		// Token: 0x040003E4 RID: 996
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7Blue g_Instance;

		// Token: 0x020000D9 RID: 217
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0002FFBF File Offset: 0x0002E1BF
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0002FFCC File Offset: 0x0002E1CC
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x0002FFD3 File Offset: 0x0002E1D3
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002BC RID: 700
			// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0002FFDA File Offset: 0x0002E1DA
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsOffice2k7Blue_Express.xaml;ResourceSets\\Editors\\EditorsOffice2k7Blue.xaml";
				}
			}
		}
	}
}
