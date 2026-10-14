using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000240 RID: 576
	public class PrimitivesOnyx : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOnyx.Locator>
	{
		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x0005C13D File Offset: 0x0005A33D
		public static global::Infragistics.Windows.Themes.PrimitivesOnyx Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOnyx.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOnyx.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOnyx();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOnyx.g_Instance;
			}
		}

		// Token: 0x04000B78 RID: 2936
		private static global::Infragistics.Windows.Themes.PrimitivesOnyx g_Instance;

		// Token: 0x02000241 RID: 577
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000570 RID: 1392
			// (get) Token: 0x060017BC RID: 6076 RVA: 0x0005C15D File Offset: 0x0005A35D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000571 RID: 1393
			// (get) Token: 0x060017BD RID: 6077 RVA: 0x0005C16A File Offset: 0x0005A36A
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x17000572 RID: 1394
			// (get) Token: 0x060017BE RID: 6078 RVA: 0x0005C171 File Offset: 0x0005A371
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000573 RID: 1395
			// (get) Token: 0x060017BF RID: 6079 RVA: 0x0005C178 File Offset: 0x0005A378
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOnyx_Express.xaml;ResourceSets\\Primitives\\PrimitivesOnyx.xaml";
				}
			}
		}
	}
}
