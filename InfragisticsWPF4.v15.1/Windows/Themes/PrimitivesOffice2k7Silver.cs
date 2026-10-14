using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200028B RID: 651
	public class PrimitivesOffice2k7Silver : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver.Locator>
	{
		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001A09 RID: 6665 RVA: 0x00062EE3 File Offset: 0x000610E3
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

		// Token: 0x04000CE6 RID: 3302
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Silver g_Instance;

		// Token: 0x0200028C RID: 652
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000624 RID: 1572
			// (get) Token: 0x06001A0B RID: 6667 RVA: 0x00062F03 File Offset: 0x00061103
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000625 RID: 1573
			// (get) Token: 0x06001A0C RID: 6668 RVA: 0x00062F10 File Offset: 0x00061110
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x17000626 RID: 1574
			// (get) Token: 0x06001A0D RID: 6669 RVA: 0x00062F17 File Offset: 0x00061117
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000627 RID: 1575
			// (get) Token: 0x06001A0E RID: 6670 RVA: 0x00062F1E File Offset: 0x0006111E
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
