using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000A0 RID: 160
	public class DockManagerOffice2k7BlackBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerOffice2k7BlackBrushes.Locator>
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0001D9A0 File Offset: 0x0001BBA0
		public static global::Infragistics.Windows.Themes.DockManagerOffice2k7BlackBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2k7BlackBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2k7BlackBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2k7BlackBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2k7BlackBrushes.g_Instance;
			}
		}

		// Token: 0x04000365 RID: 869
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2k7BlackBrushes g_Instance;

		// Token: 0x020000A1 RID: 161
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0001D9B8 File Offset: 0x0001BBB8
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0001D9C5 File Offset: 0x0001BBC5
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x1700015A RID: 346
			// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0001D9CC File Offset: 0x0001BBCC
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x1700015B RID: 347
			// (get) Token: 0x060005C5 RID: 1477 RVA: 0x0001D9D3 File Offset: 0x0001BBD3
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerOffice2k7Black_Brushes.xaml";
				}
			}
		}
	}
}
