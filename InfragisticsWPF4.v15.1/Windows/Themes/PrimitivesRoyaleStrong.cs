using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200027B RID: 635
	public class PrimitivesRoyaleStrong : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong.Locator>
	{
		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060019D1 RID: 6609 RVA: 0x00062C93 File Offset: 0x00060E93
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

		// Token: 0x04000CDE RID: 3294
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesRoyaleStrong g_Instance;

		// Token: 0x0200027C RID: 636
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005FC RID: 1532
			// (get) Token: 0x060019D3 RID: 6611 RVA: 0x00062CB3 File Offset: 0x00060EB3
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005FD RID: 1533
			// (get) Token: 0x060019D4 RID: 6612 RVA: 0x00062CC0 File Offset: 0x00060EC0
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x170005FE RID: 1534
			// (get) Token: 0x060019D5 RID: 6613 RVA: 0x00062CC7 File Offset: 0x00060EC7
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005FF RID: 1535
			// (get) Token: 0x060019D6 RID: 6614 RVA: 0x00062CCE File Offset: 0x00060ECE
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
