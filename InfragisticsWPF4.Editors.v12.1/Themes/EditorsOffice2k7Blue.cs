using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D0 RID: 208
	public class EditorsOffice2k7Blue : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Blue.Locator>
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0002DF0B File Offset: 0x0002C10B
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

		// Token: 0x040003AD RID: 941
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7Blue g_Instance;

		// Token: 0x020000D1 RID: 209
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700029F RID: 671
			// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0002DF2B File Offset: 0x0002C12B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000A6A RID: 2666 RVA: 0x0002DF38 File Offset: 0x0002C138
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0002DF3F File Offset: 0x0002C13F
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000A6C RID: 2668 RVA: 0x0002DF46 File Offset: 0x0002C146
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
