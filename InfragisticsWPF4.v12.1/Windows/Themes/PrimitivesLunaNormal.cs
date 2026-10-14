using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000248 RID: 584
	public class PrimitivesLunaNormal : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaNormal.Locator>
	{
		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x060017D6 RID: 6102 RVA: 0x0005C265 File Offset: 0x0005A465
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

		// Token: 0x04000B7C RID: 2940
		private static global::Infragistics.Windows.Themes.PrimitivesLunaNormal g_Instance;

		// Token: 0x02000249 RID: 585
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000584 RID: 1412
			// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0005C285 File Offset: 0x0005A485
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000585 RID: 1413
			// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0005C292 File Offset: 0x0005A492
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x17000586 RID: 1414
			// (get) Token: 0x060017DA RID: 6106 RVA: 0x0005C299 File Offset: 0x0005A499
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000587 RID: 1415
			// (get) Token: 0x060017DB RID: 6107 RVA: 0x0005C2A0 File Offset: 0x0005A4A0
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
