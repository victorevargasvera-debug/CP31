using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CC RID: 204
	public class EditorsRoyale : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsRoyale.Locator>
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000AB2 RID: 2738 RVA: 0x0002FDE3 File Offset: 0x0002DFE3
		public static global::Infragistics.Windows.Themes.EditorsRoyale Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsRoyale.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsRoyale.g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyale();
				}
				return global::Infragistics.Windows.Themes.EditorsRoyale.g_Instance;
			}
		}

		// Token: 0x040003DE RID: 990
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsRoyale g_Instance;

		// Token: 0x020000CD RID: 205
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700029B RID: 667
			// (get) Token: 0x06000AB4 RID: 2740 RVA: 0x0002FE03 File Offset: 0x0002E003
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700029C RID: 668
			// (get) Token: 0x06000AB5 RID: 2741 RVA: 0x0002FE10 File Offset: 0x0002E010
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x1700029D RID: 669
			// (get) Token: 0x06000AB6 RID: 2742 RVA: 0x0002FE17 File Offset: 0x0002E017
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700029E RID: 670
			// (get) Token: 0x06000AB7 RID: 2743 RVA: 0x0002FE1E File Offset: 0x0002E01E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsRoyale_Express.xaml;ResourceSets\\Editors\\EditorsRoyale.xaml";
				}
			}
		}
	}
}
