using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CE RID: 206
	public class EditorsOffice2k7Black : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOffice2k7Black.Locator>
	{
		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0002DEC1 File Offset: 0x0002C0C1
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

		// Token: 0x040003AC RID: 940
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7Black g_Instance;

		// Token: 0x020000CF RID: 207
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700029A RID: 666
			// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0002DEE1 File Offset: 0x0002C0E1
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000A63 RID: 2659 RVA: 0x0002DEEE File Offset: 0x0002C0EE
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0002DEF5 File Offset: 0x0002C0F5
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0002DEFC File Offset: 0x0002C0FC
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
