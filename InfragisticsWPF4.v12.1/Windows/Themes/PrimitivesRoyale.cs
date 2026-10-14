using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000244 RID: 580
	public class PrimitivesRoyale : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesRoyale.Locator>
	{
		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x0005C1D1 File Offset: 0x0005A3D1
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

		// Token: 0x04000B7A RID: 2938
		private static global::Infragistics.Windows.Themes.PrimitivesRoyale g_Instance;

		// Token: 0x02000245 RID: 581
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700057A RID: 1402
			// (get) Token: 0x060017CA RID: 6090 RVA: 0x0005C1F1 File Offset: 0x0005A3F1
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700057B RID: 1403
			// (get) Token: 0x060017CB RID: 6091 RVA: 0x0005C1FE File Offset: 0x0005A3FE
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x1700057C RID: 1404
			// (get) Token: 0x060017CC RID: 6092 RVA: 0x0005C205 File Offset: 0x0005A405
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x1700057D RID: 1405
			// (get) Token: 0x060017CD RID: 6093 RVA: 0x0005C20C File Offset: 0x0005A40C
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
