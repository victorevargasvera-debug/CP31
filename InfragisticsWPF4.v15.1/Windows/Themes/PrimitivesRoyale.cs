using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000279 RID: 633
	public class PrimitivesRoyale : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesRoyale.Locator>
	{
		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00062C49 File Offset: 0x00060E49
		public static global::Infragistics.Windows.Themes.PrimitivesRoyale Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesRoyale.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesRoyale.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesRoyale();
				}
				return global::Infragistics.Windows.Themes.PrimitivesRoyale.g_Instance;
			}
		}

		// Token: 0x04000CDD RID: 3293
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesRoyale g_Instance;

		// Token: 0x0200027A RID: 634
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005F7 RID: 1527
			// (get) Token: 0x060019CC RID: 6604 RVA: 0x00062C69 File Offset: 0x00060E69
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005F8 RID: 1528
			// (get) Token: 0x060019CD RID: 6605 RVA: 0x00062C76 File Offset: 0x00060E76
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x170005F9 RID: 1529
			// (get) Token: 0x060019CE RID: 6606 RVA: 0x00062C7D File Offset: 0x00060E7D
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005FA RID: 1530
			// (get) Token: 0x060019CF RID: 6607 RVA: 0x00062C84 File Offset: 0x00060E84
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesRoyale_Express.xaml;ResourceSets\\Primitives\\PrimitivesRoyale.xaml";
				}
			}
		}
	}
}
