using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000254 RID: 596
	public class PrimitivesOffice2k7Silver : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver.Locator>
	{
		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x0005C421 File Offset: 0x0005A621
		public static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver.g_Instance;
			}
		}

		// Token: 0x04000B82 RID: 2946
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver g_Instance;

		// Token: 0x02000255 RID: 597
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005A2 RID: 1442
			// (get) Token: 0x06001802 RID: 6146 RVA: 0x0005C441 File Offset: 0x0005A641
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005A3 RID: 1443
			// (get) Token: 0x06001803 RID: 6147 RVA: 0x0005C44E File Offset: 0x0005A64E
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x170005A4 RID: 1444
			// (get) Token: 0x06001804 RID: 6148 RVA: 0x0005C455 File Offset: 0x0005A655
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005A5 RID: 1445
			// (get) Token: 0x06001805 RID: 6149 RVA: 0x0005C45C File Offset: 0x0005A65C
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOffice2k7Silver_Express.xaml;ResourceSets\\Primitives\\PrimitivesOffice2k7Silver.xaml";
				}
			}
		}
	}
}
