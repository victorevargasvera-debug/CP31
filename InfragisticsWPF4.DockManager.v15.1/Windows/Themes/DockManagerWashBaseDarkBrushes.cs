using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000A8 RID: 168
	public class DockManagerWashBaseDarkBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerWashBaseDarkBrushes.Locator>
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001DAD0 File Offset: 0x0001BCD0
		public static global::Infragistics.Windows.Themes.DockManagerWashBaseDarkBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerWashBaseDarkBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerWashBaseDarkBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerWashBaseDarkBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerWashBaseDarkBrushes.g_Instance;
			}
		}

		// Token: 0x04000369 RID: 873
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerWashBaseDarkBrushes g_Instance;

		// Token: 0x020000A9 RID: 169
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700016C RID: 364
			// (get) Token: 0x060005E2 RID: 1506 RVA: 0x0001DAE8 File Offset: 0x0001BCE8
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x060005E3 RID: 1507 RVA: 0x0001DAF5 File Offset: 0x0001BCF5
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0001DAFC File Offset: 0x0001BCFC
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060005E5 RID: 1509 RVA: 0x0001DB03 File Offset: 0x0001BD03
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerWashBaseDark_Brushes.xaml";
				}
			}
		}
	}
}
