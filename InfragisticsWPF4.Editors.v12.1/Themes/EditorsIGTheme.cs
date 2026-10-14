using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000DC RID: 220
	public class EditorsIGTheme : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsIGTheme.Locator>
	{
		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000A91 RID: 2705 RVA: 0x0002E0C7 File Offset: 0x0002C2C7
		public static global::Infragistics.Windows.Themes.EditorsIGTheme Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsIGTheme.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsIGTheme.g_Instance = new global::Infragistics.Windows.Themes.EditorsIGTheme();
				}
				return global::Infragistics.Windows.Themes.EditorsIGTheme.g_Instance;
			}
		}

		// Token: 0x040003B3 RID: 947
		private static global::Infragistics.Windows.Themes.EditorsIGTheme g_Instance;

		// Token: 0x020000DD RID: 221
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002BD RID: 701
			// (get) Token: 0x06000A93 RID: 2707 RVA: 0x0002E0E7 File Offset: 0x0002C2E7
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002BE RID: 702
			// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0002E0F4 File Offset: 0x0002C2F4
			public override string Theme
			{
				get
				{
					return "IGTheme";
				}
			}

			// Token: 0x170002BF RID: 703
			// (get) Token: 0x06000A95 RID: 2709 RVA: 0x0002E0FB File Offset: 0x0002C2FB
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002C0 RID: 704
			// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0002E102 File Offset: 0x0002C302
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsIGTheme_Express.xaml;ResourceSets\\Editors\\EditorsIGTheme.xaml";
				}
			}
		}
	}
}
