using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000098 RID: 152
	public class DockManagerLunaNormalBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerLunaNormalBrushes.Locator>
	{
		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001D870 File Offset: 0x0001BA70
		public static global::Infragistics.Windows.Themes.DockManagerLunaNormalBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerLunaNormalBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerLunaNormalBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerLunaNormalBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerLunaNormalBrushes.g_Instance;
			}
		}

		// Token: 0x04000361 RID: 865
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerLunaNormalBrushes g_Instance;

		// Token: 0x02000099 RID: 153
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000144 RID: 324
			// (get) Token: 0x060005A2 RID: 1442 RVA: 0x0001D888 File Offset: 0x0001BA88
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001D895 File Offset: 0x0001BA95
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x17000146 RID: 326
			// (get) Token: 0x060005A4 RID: 1444 RVA: 0x0001D89C File Offset: 0x0001BA9C
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001D8A3 File Offset: 0x0001BAA3
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerLunaNormal_Brushes.xaml";
				}
			}
		}
	}
}
