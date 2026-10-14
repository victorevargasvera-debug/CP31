using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D2 RID: 210
	public class EditorsLunaOlive : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaOlive.Locator>
	{
		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x0002FEC1 File Offset: 0x0002E0C1
		public static global::Infragistics.Windows.Themes.EditorsLunaOlive Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaOlive.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaOlive.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaOlive();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaOlive.g_Instance;
			}
		}

		// Token: 0x040003E1 RID: 993
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsLunaOlive g_Instance;

		// Token: 0x020000D3 RID: 211
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002AA RID: 682
			// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x0002FEE1 File Offset: 0x0002E0E1
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002AB RID: 683
			// (get) Token: 0x06000ACA RID: 2762 RVA: 0x0002FEEE File Offset: 0x0002E0EE
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x170002AC RID: 684
			// (get) Token: 0x06000ACB RID: 2763 RVA: 0x0002FEF5 File Offset: 0x0002E0F5
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002AD RID: 685
			// (get) Token: 0x06000ACC RID: 2764 RVA: 0x0002FEFC File Offset: 0x0002E0FC
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsLunaOlive_Express.xaml;ResourceSets\\Editors\\EditorsLunaOlive.xaml";
				}
			}
		}
	}
}
