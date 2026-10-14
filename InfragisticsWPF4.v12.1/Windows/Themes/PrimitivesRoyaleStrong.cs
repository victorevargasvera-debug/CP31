using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000246 RID: 582
	public class PrimitivesRoyaleStrong : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong.Locator>
	{
		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060017CF RID: 6095 RVA: 0x0005C21B File Offset: 0x0005A41B
		public static global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong();
				}
				return global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong.g_Instance;
			}
		}

		// Token: 0x04000B7B RID: 2939
		private static global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong g_Instance;

		// Token: 0x02000247 RID: 583
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700057F RID: 1407
			// (get) Token: 0x060017D1 RID: 6097 RVA: 0x0005C23B File Offset: 0x0005A43B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000580 RID: 1408
			// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0005C248 File Offset: 0x0005A448
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x17000581 RID: 1409
			// (get) Token: 0x060017D3 RID: 6099 RVA: 0x0005C24F File Offset: 0x0005A44F
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000582 RID: 1410
			// (get) Token: 0x060017D4 RID: 6100 RVA: 0x0005C256 File Offset: 0x0005A456
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesRoyaleStrong_Express.xaml;ResourceSets\\Primitives\\PrimitivesRoyaleStrong.xaml";
				}
			}
		}
	}
}
