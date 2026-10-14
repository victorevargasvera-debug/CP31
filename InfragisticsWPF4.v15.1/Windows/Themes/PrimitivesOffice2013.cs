using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200028F RID: 655
	public class PrimitivesOffice2013 : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2013.Locator>
	{
		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x00062F77 File Offset: 0x00061177
		public static global::Infragistics.Windows.Themes.PrimitivesOffice2013 Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOffice2013.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOffice2013.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOffice2013();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOffice2013.g_Instance;
			}
		}

		// Token: 0x04000CE8 RID: 3304
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2013 g_Instance;

		// Token: 0x02000290 RID: 656
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700062E RID: 1582
			// (get) Token: 0x06001A19 RID: 6681 RVA: 0x00062F97 File Offset: 0x00061197
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700062F RID: 1583
			// (get) Token: 0x06001A1A RID: 6682 RVA: 0x00062FA4 File Offset: 0x000611A4
			public override string Theme
			{
				get
				{
					return "Office2013";
				}
			}

			// Token: 0x17000630 RID: 1584
			// (get) Token: 0x06001A1B RID: 6683 RVA: 0x00062FAB File Offset: 0x000611AB
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000631 RID: 1585
			// (get) Token: 0x06001A1C RID: 6684 RVA: 0x00062FB2 File Offset: 0x000611B2
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOffice2013_Express.xaml;ResourceSets\\Primitives\\PrimitivesOffice2013.xaml";
				}
			}
		}
	}
}
