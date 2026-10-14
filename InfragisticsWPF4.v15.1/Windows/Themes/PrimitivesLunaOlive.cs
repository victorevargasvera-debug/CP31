using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200027F RID: 639
	public class PrimitivesLunaOlive : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaOlive.Locator>
	{
		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060019DF RID: 6623 RVA: 0x00062D27 File Offset: 0x00060F27
		public static global::Infragistics.Windows.Themes.PrimitivesLunaOlive Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesLunaOlive.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesLunaOlive.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesLunaOlive();
				}
				return global::Infragistics.Windows.Themes.PrimitivesLunaOlive.g_Instance;
			}
		}

		// Token: 0x04000CE0 RID: 3296
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesLunaOlive g_Instance;

		// Token: 0x02000280 RID: 640
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000606 RID: 1542
			// (get) Token: 0x060019E1 RID: 6625 RVA: 0x00062D47 File Offset: 0x00060F47
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000607 RID: 1543
			// (get) Token: 0x060019E2 RID: 6626 RVA: 0x00062D54 File Offset: 0x00060F54
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x060019E3 RID: 6627 RVA: 0x00062D5B File Offset: 0x00060F5B
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x060019E4 RID: 6628 RVA: 0x00062D62 File Offset: 0x00060F62
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesLunaOlive_Express.xaml;ResourceSets\\Primitives\\PrimitivesLunaOlive.xaml";
				}
			}
		}
	}
}
