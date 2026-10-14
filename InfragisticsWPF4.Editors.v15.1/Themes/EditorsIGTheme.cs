using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000E6 RID: 230
	public class EditorsIGTheme : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsIGTheme.Locator>
	{
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x000301A5 File Offset: 0x0002E3A5
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

		// Token: 0x040003EB RID: 1003
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsIGTheme g_Instance;

		// Token: 0x020000E7 RID: 231
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002DC RID: 732
			// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000301C5 File Offset: 0x0002E3C5
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002DD RID: 733
			// (get) Token: 0x06000B10 RID: 2832 RVA: 0x000301D2 File Offset: 0x0002E3D2
			public override string Theme
			{
				get
				{
					return "IGTheme";
				}
			}

			// Token: 0x170002DE RID: 734
			// (get) Token: 0x06000B11 RID: 2833 RVA: 0x000301D9 File Offset: 0x0002E3D9
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002DF RID: 735
			// (get) Token: 0x06000B12 RID: 2834 RVA: 0x000301E0 File Offset: 0x0002E3E0
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
