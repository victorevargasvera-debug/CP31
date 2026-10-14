using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CE RID: 206
	public class EditorsRoyaleStrong : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsRoyaleStrong.Locator>
	{
		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x0002FE2D File Offset: 0x0002E02D
		public static global::Infragistics.Windows.Themes.EditorsRoyaleStrong Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsRoyaleStrong.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsRoyaleStrong.g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyaleStrong();
				}
				return global::Infragistics.Windows.Themes.EditorsRoyaleStrong.g_Instance;
			}
		}

		// Token: 0x040003DF RID: 991
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsRoyaleStrong g_Instance;

		// Token: 0x020000CF RID: 207
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002A0 RID: 672
			// (get) Token: 0x06000ABB RID: 2747 RVA: 0x0002FE4D File Offset: 0x0002E04D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002A1 RID: 673
			// (get) Token: 0x06000ABC RID: 2748 RVA: 0x0002FE5A File Offset: 0x0002E05A
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x170002A2 RID: 674
			// (get) Token: 0x06000ABD RID: 2749 RVA: 0x0002FE61 File Offset: 0x0002E061
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002A3 RID: 675
			// (get) Token: 0x06000ABE RID: 2750 RVA: 0x0002FE68 File Offset: 0x0002E068
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsRoyaleStrong_Express.xaml;ResourceSets\\Editors\\EditorsRoyaleStrong.xaml";
				}
			}
		}
	}
}
