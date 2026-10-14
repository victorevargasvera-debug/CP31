using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000DC RID: 220
	public class EditorsOffice2010Blue : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2010Blue.Locator>
	{
		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000AEA RID: 2794 RVA: 0x00030033 File Offset: 0x0002E233
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

		// Token: 0x040003E6 RID: 998
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2010Blue g_Instance;

		// Token: 0x020000DD RID: 221
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002C3 RID: 707
			// (get) Token: 0x06000AEC RID: 2796 RVA: 0x00030053 File Offset: 0x0002E253
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002C4 RID: 708
			// (get) Token: 0x06000AED RID: 2797 RVA: 0x00030060 File Offset: 0x0002E260
			public override string Theme
			{
				get
				{
					return "Office2010Blue";
				}
			}

			// Token: 0x170002C5 RID: 709
			// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00030067 File Offset: 0x0002E267
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002C6 RID: 710
			// (get) Token: 0x06000AEF RID: 2799 RVA: 0x0003006E File Offset: 0x0002E26E
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
