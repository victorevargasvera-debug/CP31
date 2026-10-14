using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200025C RID: 604
	public class PrimitivesIGTheme : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesIGTheme.Locator>
	{
		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x0600181C RID: 6172 RVA: 0x0005C549 File Offset: 0x0005A749
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

		// Token: 0x04000B86 RID: 2950
		private static global::Infragistics.Windows.Themes.PrimitivesIGTheme g_Instance;

		// Token: 0x0200025D RID: 605
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005B6 RID: 1462
			// (get) Token: 0x0600181E RID: 6174 RVA: 0x0005C569 File Offset: 0x0005A769
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005B7 RID: 1463
			// (get) Token: 0x0600181F RID: 6175 RVA: 0x0005C576 File Offset: 0x0005A776
			public override string Theme
			{
				get
				{
					return "IGTheme";
				}
			}

			// Token: 0x170005B8 RID: 1464
			// (get) Token: 0x06001820 RID: 6176 RVA: 0x0005C57D File Offset: 0x0005A77D
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005B9 RID: 1465
			// (get) Token: 0x06001821 RID: 6177 RVA: 0x0005C584 File Offset: 0x0005A784
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
