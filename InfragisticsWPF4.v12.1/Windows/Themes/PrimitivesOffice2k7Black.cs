using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000250 RID: 592
	public class PrimitivesOffice2k7Black : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black.Locator>
	{
		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x060017F2 RID: 6130 RVA: 0x0005C38D File Offset: 0x0005A58D
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

		// Token: 0x04000B80 RID: 2944
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Black g_Instance;

		// Token: 0x02000251 RID: 593
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000598 RID: 1432
			// (get) Token: 0x060017F4 RID: 6132 RVA: 0x0005C3AD File Offset: 0x0005A5AD
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000599 RID: 1433
			// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0005C3BA File Offset: 0x0005A5BA
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x1700059A RID: 1434
			// (get) Token: 0x060017F6 RID: 6134 RVA: 0x0005C3C1 File Offset: 0x0005A5C1
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700059B RID: 1435
			// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
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
