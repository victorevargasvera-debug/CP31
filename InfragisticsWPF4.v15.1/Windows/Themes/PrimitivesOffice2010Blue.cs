using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200028D RID: 653
	public class PrimitivesOffice2010Blue : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.Locator>
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06001A10 RID: 6672 RVA: 0x00062F2D File Offset: 0x0006112D
		public static global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.g_Instance;
			}
		}

		// Token: 0x04000CE7 RID: 3303
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue g_Instance;

		// Token: 0x0200028E RID: 654
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000629 RID: 1577
			// (get) Token: 0x06001A12 RID: 6674 RVA: 0x00062F4D File Offset: 0x0006114D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700062A RID: 1578
			// (get) Token: 0x06001A13 RID: 6675 RVA: 0x00062F5A File Offset: 0x0006115A
			public override string Theme
			{
				get
				{
					return "Office2010Blue";
				}
			}

			// Token: 0x1700062B RID: 1579
			// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00062F61 File Offset: 0x00061161
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700062C RID: 1580
			// (get) Token: 0x06001A15 RID: 6677 RVA: 0x00062F68 File Offset: 0x00061168
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOffice2010Blue_Express.xaml;ResourceSets\\Primitives\\PrimitivesOffice2010Blue.xaml";
				}
			}
		}
	}
}
