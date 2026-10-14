using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200005E RID: 94
	public class EditorsWashBaseDarkBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes.Locator>
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x0001802F File Offset: 0x0001622F
		public static global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes.g_Instance;
			}
		}

		// Token: 0x04000204 RID: 516
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes g_Instance;

		// Token: 0x0200005F RID: 95
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060005B9 RID: 1465 RVA: 0x00018047 File Offset: 0x00016247
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060005BA RID: 1466 RVA: 0x00018054 File Offset: 0x00016254
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001805B File Offset: 0x0001625B
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060005BC RID: 1468 RVA: 0x00018062 File Offset: 0x00016262
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsWashBaseDark_Brushes.xaml";
				}
			}
		}
	}
}
