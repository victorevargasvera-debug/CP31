using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000DE RID: 222
	public class EditorsOffice2013 : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2013.Locator>
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x0003007D File Offset: 0x0002E27D
		public static global::Infragistics.Windows.Themes.EditorsOffice2013 Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2013.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2013.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2013();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2013.g_Instance;
			}
		}

		// Token: 0x040003E7 RID: 999
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2013 g_Instance;

		// Token: 0x020000DF RID: 223
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002C8 RID: 712
			// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x0003009D File Offset: 0x0002E29D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002C9 RID: 713
			// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x000300AA File Offset: 0x0002E2AA
			public override string Theme
			{
				get
				{
					return "Office2013";
				}
			}

			// Token: 0x170002CA RID: 714
			// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x000300B1 File Offset: 0x0002E2B1
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002CB RID: 715
			// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x000300B8 File Offset: 0x0002E2B8
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsOffice2013_Express.xaml;ResourceSets\\Editors\\EditorsOffice2013.xaml";
				}
			}
		}
	}
}
