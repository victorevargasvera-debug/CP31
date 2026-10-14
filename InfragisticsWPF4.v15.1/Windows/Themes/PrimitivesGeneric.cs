using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000272 RID: 626
	public class PrimitivesGeneric : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>
	{
		// Token: 0x170005E3 RID: 1507
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00062B63 File Offset: 0x00060D63
		public static global::Infragistics.Windows.Themes.PrimitivesGeneric Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesGeneric.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesGeneric.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesGeneric();
				}
				return global::Infragistics.Windows.Themes.PrimitivesGeneric.g_Instance;
			}
		}

		// Token: 0x04000CDA RID: 3290
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesGeneric g_Instance;

		// Token: 0x02000274 RID: 628
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005E8 RID: 1512
			// (get) Token: 0x060019B7 RID: 6583 RVA: 0x00062B8B File Offset: 0x00060D8B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005E9 RID: 1513
			// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00062B98 File Offset: 0x00060D98
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x170005EA RID: 1514
			// (get) Token: 0x060019B9 RID: 6585 RVA: 0x00062B9F File Offset: 0x00060D9F
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005EB RID: 1515
			// (get) Token: 0x060019BA RID: 6586 RVA: 0x00062BA6 File Offset: 0x00060DA6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesGeneric_Express.xaml;ResourceSets\\Primitives\\PrimitivesGeneric.xaml;generic_shared.xaml";
				}
			}
		}
	}
}
