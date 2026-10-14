using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200009C RID: 156
	public class DockManagerLunaSilverBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerLunaSilverBrushes.Locator>
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x0001D908 File Offset: 0x0001BB08
		public static global::Infragistics.Windows.Themes.DockManagerLunaSilverBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerLunaSilverBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerLunaSilverBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerLunaSilverBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerLunaSilverBrushes.g_Instance;
			}
		}

		// Token: 0x04000363 RID: 867
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerLunaSilverBrushes g_Instance;

		// Token: 0x0200009D RID: 157
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060005B2 RID: 1458 RVA: 0x0001D920 File Offset: 0x0001BB20
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0001D92D File Offset: 0x0001BB2D
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060005B4 RID: 1460 RVA: 0x0001D934 File Offset: 0x0001BB34
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0001D93B File Offset: 0x0001BB3B
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerLunaSilver_Brushes.xaml";
				}
			}
		}
	}
}
