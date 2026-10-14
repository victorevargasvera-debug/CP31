using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000277 RID: 631
	public class PrimitivesAero : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesAero.Locator>
	{
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060019C3 RID: 6595 RVA: 0x00062BFF File Offset: 0x00060DFF
		public static global::Infragistics.Windows.Themes.PrimitivesAero Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesAero.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesAero.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesAero();
				}
				return global::Infragistics.Windows.Themes.PrimitivesAero.g_Instance;
			}
		}

		// Token: 0x04000CDC RID: 3292
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesAero g_Instance;

		// Token: 0x02000278 RID: 632
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005F2 RID: 1522
			// (get) Token: 0x060019C5 RID: 6597 RVA: 0x00062C1F File Offset: 0x00060E1F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005F3 RID: 1523
			// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00062C2C File Offset: 0x00060E2C
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x170005F4 RID: 1524
			// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00062C33 File Offset: 0x00060E33
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005F5 RID: 1525
			// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00062C3A File Offset: 0x00060E3A
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesAero_Express.xaml;ResourceSets\\Primitives\\PrimitivesAero.xaml";
				}
			}
		}
	}
}
