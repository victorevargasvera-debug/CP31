using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000A2 RID: 162
	public class DockManagerOffice2k7BlueBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerOffice2k7BlueBrushes.Locator>
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0001D9EC File Offset: 0x0001BBEC
		public static global::Infragistics.Windows.Themes.DockManagerOffice2k7BlueBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2k7BlueBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2k7BlueBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2k7BlueBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2k7BlueBrushes.g_Instance;
			}
		}

		// Token: 0x04000366 RID: 870
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2k7BlueBrushes g_Instance;

		// Token: 0x020000A3 RID: 163
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700015D RID: 349
			// (get) Token: 0x060005CA RID: 1482 RVA: 0x0001DA04 File Offset: 0x0001BC04
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x060005CB RID: 1483 RVA: 0x0001DA11 File Offset: 0x0001BC11
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x1700015F RID: 351
			// (get) Token: 0x060005CC RID: 1484 RVA: 0x0001DA18 File Offset: 0x0001BC18
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x060005CD RID: 1485 RVA: 0x0001DA1F File Offset: 0x0001BC1F
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerOffice2k7Blue_Brushes.xaml";
				}
			}
		}
	}
}
