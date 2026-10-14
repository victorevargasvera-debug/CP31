using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000E8 RID: 232
	public class EditorsMetro : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsMetro.Locator>
	{
		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x000301EF File Offset: 0x0002E3EF
		public static global::Infragistics.Windows.Themes.EditorsMetro Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsMetro.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsMetro.g_Instance = new global::Infragistics.Windows.Themes.EditorsMetro();
				}
				return global::Infragistics.Windows.Themes.EditorsMetro.g_Instance;
			}
		}

		// Token: 0x040003EC RID: 1004
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsMetro g_Instance;

		// Token: 0x020000E9 RID: 233
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002E1 RID: 737
			// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0003020F File Offset: 0x0002E40F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002E2 RID: 738
			// (get) Token: 0x06000B17 RID: 2839 RVA: 0x0003021C File Offset: 0x0002E41C
			public override string Theme
			{
				get
				{
					return "Metro";
				}
			}

			// Token: 0x170002E3 RID: 739
			// (get) Token: 0x06000B18 RID: 2840 RVA: 0x00030223 File Offset: 0x0002E423
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002E4 RID: 740
			// (get) Token: 0x06000B19 RID: 2841 RVA: 0x0003022A File Offset: 0x0002E42A
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsMetro_Express.xaml;ResourceSets\\Editors\\EditorsMetro.xaml";
				}
			}
		}
	}
}
