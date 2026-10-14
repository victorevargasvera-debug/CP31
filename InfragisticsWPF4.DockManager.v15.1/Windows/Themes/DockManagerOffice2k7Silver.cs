using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000BD RID: 189
	public class DockManagerOffice2k7Silver : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver.Locator>
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x0001E30F File Offset: 0x0001C50F
		public static global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver.g_Instance;
			}
		}

		// Token: 0x04000390 RID: 912
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2k7Silver g_Instance;

		// Token: 0x020000BE RID: 190
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001B9 RID: 441
			// (get) Token: 0x06000646 RID: 1606 RVA: 0x0001E32F File Offset: 0x0001C52F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001BA RID: 442
			// (get) Token: 0x06000647 RID: 1607 RVA: 0x0001E33C File Offset: 0x0001C53C
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x170001BB RID: 443
			// (get) Token: 0x06000648 RID: 1608 RVA: 0x0001E343 File Offset: 0x0001C543
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001BC RID: 444
			// (get) Token: 0x06000649 RID: 1609 RVA: 0x0001E34A File Offset: 0x0001C54A
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerOffice2k7Silver.xaml";
				}
			}
		}
	}
}
