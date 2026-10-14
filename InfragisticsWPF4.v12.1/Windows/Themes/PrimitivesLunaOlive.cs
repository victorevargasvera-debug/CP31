using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200024A RID: 586
	public class PrimitivesLunaOlive : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaOlive.Locator>
	{
		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x060017DD RID: 6109 RVA: 0x0005C2AF File Offset: 0x0005A4AF
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

		// Token: 0x04000B7D RID: 2941
		private static global::Infragistics.Windows.Themes.PrimitivesLunaOlive g_Instance;

		// Token: 0x0200024B RID: 587
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000589 RID: 1417
			// (get) Token: 0x060017DF RID: 6111 RVA: 0x0005C2CF File Offset: 0x0005A4CF
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700058A RID: 1418
			// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0005C2DC File Offset: 0x0005A4DC
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x1700058B RID: 1419
			// (get) Token: 0x060017E1 RID: 6113 RVA: 0x0005C2E3 File Offset: 0x0005A4E3
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700058C RID: 1420
			// (get) Token: 0x060017E2 RID: 6114 RVA: 0x0005C2EA File Offset: 0x0005A4EA
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
