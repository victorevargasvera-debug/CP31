using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000281 RID: 641
	public class PrimitivesLunaSilver : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaSilver.Locator>
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060019E6 RID: 6630 RVA: 0x00062D71 File Offset: 0x00060F71
		public static global::Infragistics.Windows.Themes.PrimitivesLunaSilver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesLunaSilver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesLunaSilver.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesLunaSilver();
				}
				return global::Infragistics.Windows.Themes.PrimitivesLunaSilver.g_Instance;
			}
		}

		// Token: 0x04000CE1 RID: 3297
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesLunaSilver g_Instance;

		// Token: 0x02000282 RID: 642
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700060B RID: 1547
			// (get) Token: 0x060019E8 RID: 6632 RVA: 0x00062D91 File Offset: 0x00060F91
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700060C RID: 1548
			// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00062D9E File Offset: 0x00060F9E
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x1700060D RID: 1549
			// (get) Token: 0x060019EA RID: 6634 RVA: 0x00062DA5 File Offset: 0x00060FA5
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700060E RID: 1550
			// (get) Token: 0x060019EB RID: 6635 RVA: 0x00062DAC File Offset: 0x00060FAC
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesLunaSilver_Express.xaml;ResourceSets\\Primitives\\PrimitivesLunaSilver.xaml";
				}
			}
		}
	}
}
