using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D4 RID: 212
	public class EditorsOffice2010Blue : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2010Blue.Locator>
	{
		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0002DF9F File Offset: 0x0002C19F
		public static global::Infragistics.Windows.Themes.EditorsOffice2010Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2010Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2010Blue.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2010Blue();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2010Blue.g_Instance;
			}
		}

		// Token: 0x040003AF RID: 943
		private static global::Infragistics.Windows.Themes.EditorsOffice2010Blue g_Instance;

		// Token: 0x020000D5 RID: 213
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002A9 RID: 681
			// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0002DFBF File Offset: 0x0002C1BF
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000A78 RID: 2680 RVA: 0x0002DFCC File Offset: 0x0002C1CC
			public override string Theme
			{
				get
				{
					return "Office2010Blue";
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0002DFD3 File Offset: 0x0002C1D3
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000A7A RID: 2682 RVA: 0x0002DFDA File Offset: 0x0002C1DA
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsOffice2010Blue_Express.xaml;ResourceSets\\Editors\\EditorsOffice2010Blue.xaml";
				}
			}
		}
	}
}
