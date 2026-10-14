using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200009A RID: 154
	public class DockManagerLunaOliveBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerLunaOliveBrushes.Locator>
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060005A9 RID: 1449 RVA: 0x0001D8BC File Offset: 0x0001BABC
		public static global::Infragistics.Windows.Themes.DockManagerLunaOliveBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerLunaOliveBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerLunaOliveBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerLunaOliveBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerLunaOliveBrushes.g_Instance;
			}
		}

		// Token: 0x04000362 RID: 866
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerLunaOliveBrushes g_Instance;

		// Token: 0x0200009B RID: 155
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000149 RID: 329
			// (get) Token: 0x060005AA RID: 1450 RVA: 0x0001D8D4 File Offset: 0x0001BAD4
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x0001D8E1 File Offset: 0x0001BAE1
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060005AC RID: 1452 RVA: 0x0001D8E8 File Offset: 0x0001BAE8
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001D8EF File Offset: 0x0001BAEF
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerLunaOlive_Brushes.xaml";
				}
			}
		}
	}
}
