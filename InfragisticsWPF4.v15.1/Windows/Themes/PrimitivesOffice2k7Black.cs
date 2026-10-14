using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000287 RID: 647
	public class PrimitivesOffice2k7Black : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black.Locator>
	{
		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060019FB RID: 6651 RVA: 0x00062E4F File Offset: 0x0006104F
		public static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black.g_Instance;
			}
		}

		// Token: 0x04000CE4 RID: 3300
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black g_Instance;

		// Token: 0x02000288 RID: 648
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700061A RID: 1562
			// (get) Token: 0x060019FD RID: 6653 RVA: 0x00062E6F File Offset: 0x0006106F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700061B RID: 1563
			// (get) Token: 0x060019FE RID: 6654 RVA: 0x00062E7C File Offset: 0x0006107C
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x1700061C RID: 1564
			// (get) Token: 0x060019FF RID: 6655 RVA: 0x00062E83 File Offset: 0x00061083
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700061D RID: 1565
			// (get) Token: 0x06001A00 RID: 6656 RVA: 0x00062E8A File Offset: 0x0006108A
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOffice2k7Black_Express.xaml;ResourceSets\\Primitives\\PrimitivesOffice2k7Black.xaml";
				}
			}
		}
	}
}
