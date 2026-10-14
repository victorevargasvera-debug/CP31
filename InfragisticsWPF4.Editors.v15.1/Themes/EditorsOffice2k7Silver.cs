using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000DA RID: 218
	public class EditorsOffice2k7Silver : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Silver.Locator>
	{
		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x0002FFE9 File Offset: 0x0002E1E9
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

		// Token: 0x040003E5 RID: 997
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7Silver g_Instance;

		// Token: 0x020000DB RID: 219
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00030009 File Offset: 0x0002E209
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x00030016 File Offset: 0x0002E216
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x0003001D File Offset: 0x0002E21D
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002C1 RID: 705
			// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x00030024 File Offset: 0x0002E224
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
