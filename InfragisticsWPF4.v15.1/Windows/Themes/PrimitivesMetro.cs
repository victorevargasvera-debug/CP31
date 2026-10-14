using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000283 RID: 643
	public class PrimitivesMetro : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesMetro.Locator>
	{
		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x00062DBB File Offset: 0x00060FBB
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

		// Token: 0x04000CE2 RID: 3298
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesMetro g_Instance;

		// Token: 0x02000284 RID: 644
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000610 RID: 1552
			// (get) Token: 0x060019EF RID: 6639 RVA: 0x00062DDB File Offset: 0x00060FDB
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000611 RID: 1553
			// (get) Token: 0x060019F0 RID: 6640 RVA: 0x00062DE8 File Offset: 0x00060FE8
			public override string Theme
			{
				get
				{
					return "Metro";
				}
			}

			// Token: 0x17000612 RID: 1554
			// (get) Token: 0x060019F1 RID: 6641 RVA: 0x00062DEF File Offset: 0x00060FEF
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000613 RID: 1555
			// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00062DF6 File Offset: 0x00060FF6
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
