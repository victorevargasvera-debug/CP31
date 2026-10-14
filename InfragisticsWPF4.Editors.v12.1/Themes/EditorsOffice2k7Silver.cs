using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D2 RID: 210
	public class EditorsOffice2k7Silver : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Silver.Locator>
	{
		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x0002DF55 File Offset: 0x0002C155
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7Silver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2k7Silver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2k7Silver.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7Silver();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2k7Silver.g_Instance;
			}
		}

		// Token: 0x040003AE RID: 942
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7Silver g_Instance;

		// Token: 0x020000D3 RID: 211
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002A4 RID: 676
			// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0002DF75 File Offset: 0x0002C175
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0002DF82 File Offset: 0x0002C182
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000A72 RID: 2674 RVA: 0x0002DF89 File Offset: 0x0002C189
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0002DF90 File Offset: 0x0002C190
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsOffice2k7Silver_Express.xaml;ResourceSets\\Editors\\EditorsOffice2k7Silver.xaml";
				}
			}
		}
	}
}
