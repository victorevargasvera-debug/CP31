using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000252 RID: 594
	public class PrimitivesOffice2k7Blue : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.Locator>
	{
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0005C3D7 File Offset: 0x0005A5D7
		public static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.g_Instance;
			}
		}

		// Token: 0x04000B81 RID: 2945
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue g_Instance;

		// Token: 0x02000253 RID: 595
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700059D RID: 1437
			// (get) Token: 0x060017FB RID: 6139 RVA: 0x0005C3F7 File Offset: 0x0005A5F7
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700059E RID: 1438
			// (get) Token: 0x060017FC RID: 6140 RVA: 0x0005C404 File Offset: 0x0005A604
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x1700059F RID: 1439
			// (get) Token: 0x060017FD RID: 6141 RVA: 0x0005C40B File Offset: 0x0005A60B
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005A0 RID: 1440
			// (get) Token: 0x060017FE RID: 6142 RVA: 0x0005C412 File Offset: 0x0005A612
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOffice2k7Blue_Express.xaml;ResourceSets\\Primitives\\PrimitivesOffice2k7Blue.xaml";
				}
			}
		}
	}
}
