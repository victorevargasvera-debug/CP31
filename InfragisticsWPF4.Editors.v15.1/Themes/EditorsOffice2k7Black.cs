using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D6 RID: 214
	public class EditorsOffice2k7Black : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Black.Locator>
	{
		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x0002FF55 File Offset: 0x0002E155
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7Black Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2k7Black.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2k7Black.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7Black();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2k7Black.g_Instance;
			}
		}

		// Token: 0x040003E3 RID: 995
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7Black g_Instance;

		// Token: 0x020000D7 RID: 215
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x0002FF75 File Offset: 0x0002E175
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000AD8 RID: 2776 RVA: 0x0002FF82 File Offset: 0x0002E182
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x0002FF89 File Offset: 0x0002E189
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002B7 RID: 695
			// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0002FF90 File Offset: 0x0002E190
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsOffice2k7Black_Express.xaml;ResourceSets\\Editors\\EditorsOffice2k7Black.xaml";
				}
			}
		}
	}
}
