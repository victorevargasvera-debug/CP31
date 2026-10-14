using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200027D RID: 637
	public class PrimitivesLunaNormal : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaNormal.Locator>
	{
		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x00062CDD File Offset: 0x00060EDD
		public static global::Infragistics.Windows.Themes.PrimitivesLunaNormal Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesLunaNormal.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesLunaNormal.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesLunaNormal();
				}
				return global::Infragistics.Windows.Themes.PrimitivesLunaNormal.g_Instance;
			}
		}

		// Token: 0x04000CDF RID: 3295
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesLunaNormal g_Instance;

		// Token: 0x0200027E RID: 638
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x060019DA RID: 6618 RVA: 0x00062CFD File Offset: 0x00060EFD
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x060019DB RID: 6619 RVA: 0x00062D0A File Offset: 0x00060F0A
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x17000603 RID: 1539
			// (get) Token: 0x060019DC RID: 6620 RVA: 0x00062D11 File Offset: 0x00060F11
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000604 RID: 1540
			// (get) Token: 0x060019DD RID: 6621 RVA: 0x00062D18 File Offset: 0x00060F18
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesLunaNormal_Express.xaml;ResourceSets\\Primitives\\PrimitivesLunaNormal.xaml";
				}
			}
		}
	}
}
