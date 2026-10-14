using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200023D RID: 573
	public class PrimitivesGeneric : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>
	{
		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0005C0EB File Offset: 0x0005A2EB
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

		// Token: 0x04000B77 RID: 2935
		private static global::Infragistics.Windows.Themes.PrimitivesGeneric g_Instance;

		// Token: 0x0200023F RID: 575
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700056B RID: 1387
			// (get) Token: 0x060017B5 RID: 6069 RVA: 0x0005C113 File Offset: 0x0005A313
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700056C RID: 1388
			// (get) Token: 0x060017B6 RID: 6070 RVA: 0x0005C120 File Offset: 0x0005A320
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x1700056D RID: 1389
			// (get) Token: 0x060017B7 RID: 6071 RVA: 0x0005C127 File Offset: 0x0005A327
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700056E RID: 1390
			// (get) Token: 0x060017B8 RID: 6072 RVA: 0x0005C12E File Offset: 0x0005A32E
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
