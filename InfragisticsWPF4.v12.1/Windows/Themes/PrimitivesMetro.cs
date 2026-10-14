using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200024E RID: 590
	public class PrimitivesMetro : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesMetro.Locator>
	{
		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060017EB RID: 6123 RVA: 0x0005C343 File Offset: 0x0005A543
		public static global::Infragistics.Windows.Themes.PrimitivesMetro Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesMetro.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesMetro.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesMetro();
				}
				return global::Infragistics.Windows.Themes.PrimitivesMetro.g_Instance;
			}
		}

		// Token: 0x04000B7F RID: 2943
		private static global::Infragistics.Windows.Themes.PrimitivesMetro g_Instance;

		// Token: 0x0200024F RID: 591
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000593 RID: 1427
			// (get) Token: 0x060017ED RID: 6125 RVA: 0x0005C363 File Offset: 0x0005A563
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000594 RID: 1428
			// (get) Token: 0x060017EE RID: 6126 RVA: 0x0005C370 File Offset: 0x0005A570
			public override string Theme
			{
				get
				{
					return "Metro";
				}
			}

			// Token: 0x17000595 RID: 1429
			// (get) Token: 0x060017EF RID: 6127 RVA: 0x0005C377 File Offset: 0x0005A577
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000596 RID: 1430
			// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0005C37E File Offset: 0x0005A57E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesMetro_Express.xaml;ResourceSets\\Primitives\\PrimitivesMetro.xaml";
				}
			}
		}
	}
}
