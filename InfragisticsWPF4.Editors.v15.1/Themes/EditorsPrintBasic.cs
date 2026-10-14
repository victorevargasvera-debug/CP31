using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000E4 RID: 228
	public class EditorsPrintBasic : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsPrintBasic.Locator>
	{
		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0003015B File Offset: 0x0002E35B
		public static global::Infragistics.Windows.Themes.EditorsPrintBasic Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsPrintBasic.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsPrintBasic.g_Instance = new global::Infragistics.Windows.Themes.EditorsPrintBasic();
				}
				return global::Infragistics.Windows.Themes.EditorsPrintBasic.g_Instance;
			}
		}

		// Token: 0x040003EA RID: 1002
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsPrintBasic g_Instance;

		// Token: 0x020000E5 RID: 229
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002D7 RID: 727
			// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0003017B File Offset: 0x0002E37B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002D8 RID: 728
			// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00030188 File Offset: 0x0002E388
			public override string Theme
			{
				get
				{
					return "Print Basic";
				}
			}

			// Token: 0x170002D9 RID: 729
			// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0003018F File Offset: 0x0002E38F
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002DA RID: 730
			// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00030196 File Offset: 0x0002E396
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsPrintBasic_Express.xaml;ResourceSets\\Editors\\EditorsPrintBasic.xaml";
				}
			}
		}
	}
}
