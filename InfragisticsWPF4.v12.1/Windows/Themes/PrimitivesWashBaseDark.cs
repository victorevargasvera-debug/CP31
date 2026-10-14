using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000258 RID: 600
	public class PrimitivesWashBaseDark : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesWashBaseDark.Locator>
	{
		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x0600180E RID: 6158 RVA: 0x0005C4B5 File Offset: 0x0005A6B5
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

		// Token: 0x04000B84 RID: 2948
		private static global::Infragistics.Windows.Themes.PrimitivesWashBaseDark g_Instance;

		// Token: 0x02000259 RID: 601
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005AC RID: 1452
			// (get) Token: 0x06001810 RID: 6160 RVA: 0x0005C4D5 File Offset: 0x0005A6D5
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005AD RID: 1453
			// (get) Token: 0x06001811 RID: 6161 RVA: 0x0005C4E2 File Offset: 0x0005A6E2
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x170005AE RID: 1454
			// (get) Token: 0x06001812 RID: 6162 RVA: 0x0005C4E9 File Offset: 0x0005A6E9
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005AF RID: 1455
			// (get) Token: 0x06001813 RID: 6163 RVA: 0x0005C4F0 File Offset: 0x0005A6F0
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
