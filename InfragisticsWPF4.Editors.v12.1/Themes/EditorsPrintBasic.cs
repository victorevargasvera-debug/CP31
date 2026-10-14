using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000DA RID: 218
	public class EditorsPrintBasic : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsPrintBasic.Locator>
	{
		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000A8A RID: 2698 RVA: 0x0002E07D File Offset: 0x0002C27D
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

		// Token: 0x040003B2 RID: 946
		private static global::Infragistics.Windows.Themes.EditorsPrintBasic g_Instance;

		// Token: 0x020000DB RID: 219
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002B8 RID: 696
			// (get) Token: 0x06000A8C RID: 2700 RVA: 0x0002E09D File Offset: 0x0002C29D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002B9 RID: 697
			// (get) Token: 0x06000A8D RID: 2701 RVA: 0x0002E0AA File Offset: 0x0002C2AA
			public override string Theme
			{
				get
				{
					return "Print Basic";
				}
			}

			// Token: 0x170002BA RID: 698
			// (get) Token: 0x06000A8E RID: 2702 RVA: 0x0002E0B1 File Offset: 0x0002C2B1
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002BB RID: 699
			// (get) Token: 0x06000A8F RID: 2703 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
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
