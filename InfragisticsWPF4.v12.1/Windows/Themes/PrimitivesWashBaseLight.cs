using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200025A RID: 602
	public class PrimitivesWashBaseLight : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesWashBaseLight.Locator>
	{
		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001815 RID: 6165 RVA: 0x0005C4FF File Offset: 0x0005A6FF
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

		// Token: 0x04000B85 RID: 2949
		private static global::Infragistics.Windows.Themes.PrimitivesWashBaseLight g_Instance;

		// Token: 0x0200025B RID: 603
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005B1 RID: 1457
			// (get) Token: 0x06001817 RID: 6167 RVA: 0x0005C51F File Offset: 0x0005A71F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005B2 RID: 1458
			// (get) Token: 0x06001818 RID: 6168 RVA: 0x0005C52C File Offset: 0x0005A72C
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x170005B3 RID: 1459
			// (get) Token: 0x06001819 RID: 6169 RVA: 0x0005C533 File Offset: 0x0005A733
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005B4 RID: 1460
			// (get) Token: 0x0600181A RID: 6170 RVA: 0x0005C53A File Offset: 0x0005A73A
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
