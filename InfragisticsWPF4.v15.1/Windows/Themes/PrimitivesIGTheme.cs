using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000295 RID: 661
	public class PrimitivesIGTheme : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesIGTheme.Locator>
	{
		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x06001A2C RID: 6700 RVA: 0x00063055 File Offset: 0x00061255
		public static global::Infragistics.Windows.Themes.PrimitivesIGTheme Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesIGTheme.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesIGTheme.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesIGTheme();
				}
				return global::Infragistics.Windows.Themes.PrimitivesIGTheme.g_Instance;
			}
		}

		// Token: 0x04000CEB RID: 3307
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesIGTheme g_Instance;

		// Token: 0x02000296 RID: 662
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700063D RID: 1597
			// (get) Token: 0x06001A2E RID: 6702 RVA: 0x00063075 File Offset: 0x00061275
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700063E RID: 1598
			// (get) Token: 0x06001A2F RID: 6703 RVA: 0x00063082 File Offset: 0x00061282
			public override string Theme
			{
				get
				{
					return "IGTheme";
				}
			}

			// Token: 0x1700063F RID: 1599
			// (get) Token: 0x06001A30 RID: 6704 RVA: 0x00063089 File Offset: 0x00061289
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000640 RID: 1600
			// (get) Token: 0x06001A31 RID: 6705 RVA: 0x00063090 File Offset: 0x00061290
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesIGTheme_Express.xaml;ResourceSets\\Primitives\\PrimitivesIGTheme.xaml";
				}
			}
		}
	}
}
