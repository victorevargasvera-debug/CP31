using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000293 RID: 659
	public class PrimitivesWashBaseLight : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesWashBaseLight.Locator>
	{
		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001A25 RID: 6693 RVA: 0x0006300B File Offset: 0x0006120B
		public static global::Infragistics.Windows.Themes.PrimitivesWashBaseLight Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesWashBaseLight.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesWashBaseLight.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesWashBaseLight();
				}
				return global::Infragistics.Windows.Themes.PrimitivesWashBaseLight.g_Instance;
			}
		}

		// Token: 0x04000CEA RID: 3306
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesWashBaseLight g_Instance;

		// Token: 0x02000294 RID: 660
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x06001A27 RID: 6695 RVA: 0x0006302B File Offset: 0x0006122B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06001A28 RID: 6696 RVA: 0x00063038 File Offset: 0x00061238
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x06001A29 RID: 6697 RVA: 0x0006303F File Offset: 0x0006123F
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700063B RID: 1595
			// (get) Token: 0x06001A2A RID: 6698 RVA: 0x00063046 File Offset: 0x00061246
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesWashBaseLight.xaml";
				}
			}
		}
	}
}
