using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000285 RID: 645
	public class PrimitivesMetroDark : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesMetroDark.Locator>
	{
		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x00062E05 File Offset: 0x00061005
		public static global::Infragistics.Windows.Themes.PrimitivesMetroDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesMetroDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesMetroDark.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesMetroDark();
				}
				return global::Infragistics.Windows.Themes.PrimitivesMetroDark.g_Instance;
			}
		}

		// Token: 0x04000CE3 RID: 3299
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesMetroDark g_Instance;

		// Token: 0x02000286 RID: 646
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000615 RID: 1557
			// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00062E25 File Offset: 0x00061025
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000616 RID: 1558
			// (get) Token: 0x060019F7 RID: 6647 RVA: 0x00062E32 File Offset: 0x00061032
			public override string Theme
			{
				get
				{
					return "MetroDark";
				}
			}

			// Token: 0x17000617 RID: 1559
			// (get) Token: 0x060019F8 RID: 6648 RVA: 0x00062E39 File Offset: 0x00061039
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000618 RID: 1560
			// (get) Token: 0x060019F9 RID: 6649 RVA: 0x00062E40 File Offset: 0x00061040
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesMetroDark_Express.xaml;ResourceSets\\Primitives\\PrimitivesMetroDark.xaml";
				}
			}
		}
	}
}
