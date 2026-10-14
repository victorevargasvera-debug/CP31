using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000A6 RID: 166
	public class DockManagerRoyaleBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerRoyaleBrushes.Locator>
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x0001DA84 File Offset: 0x0001BC84
		public static global::Infragistics.Windows.Themes.DockManagerRoyaleBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerRoyaleBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerRoyaleBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerRoyaleBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerRoyaleBrushes.g_Instance;
			}
		}

		// Token: 0x04000368 RID: 872
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerRoyaleBrushes g_Instance;

		// Token: 0x020000A7 RID: 167
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060005DA RID: 1498 RVA: 0x0001DA9C File Offset: 0x0001BC9C
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x060005DB RID: 1499 RVA: 0x0001DAA9 File Offset: 0x0001BCA9
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x17000169 RID: 361
			// (get) Token: 0x060005DC RID: 1500 RVA: 0x0001DAB0 File Offset: 0x0001BCB0
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x1700016A RID: 362
			// (get) Token: 0x060005DD RID: 1501 RVA: 0x0001DAB7 File Offset: 0x0001BCB7
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerRoyale_Brushes.xaml";
				}
			}
		}
	}
}
