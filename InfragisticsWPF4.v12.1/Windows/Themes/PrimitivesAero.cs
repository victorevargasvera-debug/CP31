using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000242 RID: 578
	public class PrimitivesAero : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesAero.Locator>
	{
		// Token: 0x17000574 RID: 1396
		// (get) Token: 0x060017C1 RID: 6081 RVA: 0x0005C187 File Offset: 0x0005A387
		public static global::Infragistics.Windows.Themes.PrimitivesAero Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesAero.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesAero.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesAero();
				}
				return global::Infragistics.Windows.Themes.PrimitivesAero.g_Instance;
			}
		}

		// Token: 0x04000B79 RID: 2937
		private static global::Infragistics.Windows.Themes.PrimitivesAero g_Instance;

		// Token: 0x02000243 RID: 579
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000575 RID: 1397
			// (get) Token: 0x060017C3 RID: 6083 RVA: 0x0005C1A7 File Offset: 0x0005A3A7
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000576 RID: 1398
			// (get) Token: 0x060017C4 RID: 6084 RVA: 0x0005C1B4 File Offset: 0x0005A3B4
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x17000577 RID: 1399
			// (get) Token: 0x060017C5 RID: 6085 RVA: 0x0005C1BB File Offset: 0x0005A3BB
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000578 RID: 1400
			// (get) Token: 0x060017C6 RID: 6086 RVA: 0x0005C1C2 File Offset: 0x0005A3C2
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesAero_Express.xaml;ResourceSets\\Primitives\\PrimitivesAero.xaml";
				}
			}
		}
	}
}
