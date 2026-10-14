using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000291 RID: 657
	public class PrimitivesWashBaseDark : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesWashBaseDark.Locator>
	{
		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06001A1E RID: 6686 RVA: 0x00062FC1 File Offset: 0x000611C1
		public static global::Infragistics.Windows.Themes.PrimitivesWashBaseDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesWashBaseDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesWashBaseDark.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesWashBaseDark();
				}
				return global::Infragistics.Windows.Themes.PrimitivesWashBaseDark.g_Instance;
			}
		}

		// Token: 0x04000CE9 RID: 3305
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesWashBaseDark g_Instance;

		// Token: 0x02000292 RID: 658
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000633 RID: 1587
			// (get) Token: 0x06001A20 RID: 6688 RVA: 0x00062FE1 File Offset: 0x000611E1
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000634 RID: 1588
			// (get) Token: 0x06001A21 RID: 6689 RVA: 0x00062FEE File Offset: 0x000611EE
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06001A22 RID: 6690 RVA: 0x00062FF5 File Offset: 0x000611F5
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06001A23 RID: 6691 RVA: 0x00062FFC File Offset: 0x000611FC
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesWashBaseDark.xaml";
				}
			}
		}
	}
}
