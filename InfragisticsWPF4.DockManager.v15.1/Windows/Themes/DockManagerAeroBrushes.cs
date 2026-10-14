using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200009E RID: 158
	public class DockManagerAeroBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerAeroBrushes.Locator>
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0001D954 File Offset: 0x0001BB54
		public static global::Infragistics.Windows.Themes.DockManagerAeroBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerAeroBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerAeroBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerAeroBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerAeroBrushes.g_Instance;
			}
		}

		// Token: 0x04000364 RID: 868
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerAeroBrushes g_Instance;

		// Token: 0x0200009F RID: 159
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060005BA RID: 1466 RVA: 0x0001D96C File Offset: 0x0001BB6C
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x060005BB RID: 1467 RVA: 0x0001D979 File Offset: 0x0001BB79
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x17000155 RID: 341
			// (get) Token: 0x060005BC RID: 1468 RVA: 0x0001D980 File Offset: 0x0001BB80
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x060005BD RID: 1469 RVA: 0x0001D987 File Offset: 0x0001BB87
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerAero_Brushes.xaml";
				}
			}
		}
	}
}
