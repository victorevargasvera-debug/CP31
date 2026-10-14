using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000B9 RID: 185
	public class DockManagerOffice2k7Black : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2k7Black.Locator>
	{
		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0001E27B File Offset: 0x0001C47B
		public static global::Infragistics.Windows.Themes.DockManagerOffice2k7Black Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2k7Black.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2k7Black.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2k7Black();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2k7Black.g_Instance;
			}
		}

		// Token: 0x0400038E RID: 910
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2k7Black g_Instance;

		// Token: 0x020000BA RID: 186
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001AF RID: 431
			// (get) Token: 0x06000638 RID: 1592 RVA: 0x0001E29B File Offset: 0x0001C49B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001B0 RID: 432
			// (get) Token: 0x06000639 RID: 1593 RVA: 0x0001E2A8 File Offset: 0x0001C4A8
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x170001B1 RID: 433
			// (get) Token: 0x0600063A RID: 1594 RVA: 0x0001E2AF File Offset: 0x0001C4AF
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001B2 RID: 434
			// (get) Token: 0x0600063B RID: 1595 RVA: 0x0001E2B6 File Offset: 0x0001C4B6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerOffice2k7Black.xaml";
				}
			}
		}
	}
}
