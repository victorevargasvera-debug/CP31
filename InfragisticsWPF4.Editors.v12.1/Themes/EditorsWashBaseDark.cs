using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D6 RID: 214
	public class EditorsWashBaseDark : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsWashBaseDark.Locator>
	{
		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000A7C RID: 2684 RVA: 0x0002DFE9 File Offset: 0x0002C1E9
		public static global::Infragistics.Windows.Themes.EditorsWashBaseDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsWashBaseDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsWashBaseDark.g_Instance = new global::Infragistics.Windows.Themes.EditorsWashBaseDark();
				}
				return global::Infragistics.Windows.Themes.EditorsWashBaseDark.g_Instance;
			}
		}

		// Token: 0x040003B0 RID: 944
		private static global::Infragistics.Windows.Themes.EditorsWashBaseDark g_Instance;

		// Token: 0x020000D7 RID: 215
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002AE RID: 686
			// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0002E009 File Offset: 0x0002C209
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000A7F RID: 2687 RVA: 0x0002E016 File Offset: 0x0002C216
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0002E01D File Offset: 0x0002C21D
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x06000A81 RID: 2689 RVA: 0x0002E024 File Offset: 0x0002C224
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsWashBaseDark_Express.xaml;ResourceSets\\Editors\\EditorsWashBaseDark.xaml";
				}
			}
		}
	}
}
