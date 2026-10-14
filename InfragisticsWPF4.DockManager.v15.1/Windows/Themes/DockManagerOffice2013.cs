using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C1 RID: 193
	public class DockManagerOffice2013 : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2013.Locator>
	{
		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000652 RID: 1618 RVA: 0x0001E3A3 File Offset: 0x0001C5A3
		public static global::Infragistics.Windows.Themes.DockManagerOffice2013 Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2013.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2013.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2013();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2013.g_Instance;
			}
		}

		// Token: 0x04000392 RID: 914
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2013 g_Instance;

		// Token: 0x020000C2 RID: 194
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x06000654 RID: 1620 RVA: 0x0001E3C3 File Offset: 0x0001C5C3
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x06000655 RID: 1621 RVA: 0x0001E3D0 File Offset: 0x0001C5D0
			public override string Theme
			{
				get
				{
					return "Office2013";
				}
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x06000656 RID: 1622 RVA: 0x0001E3D7 File Offset: 0x0001C5D7
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x06000657 RID: 1623 RVA: 0x0001E3DE File Offset: 0x0001C5DE
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerOffice2013.xaml";
				}
			}
		}
	}
}
