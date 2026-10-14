using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000BB RID: 187
	public class DockManagerOffice2k7Blue : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue.Locator>
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x0001E2C5 File Offset: 0x0001C4C5
		public static global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue.g_Instance;
			}
		}

		// Token: 0x0400038F RID: 911
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2k7Blue g_Instance;

		// Token: 0x020000BC RID: 188
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001B4 RID: 436
			// (get) Token: 0x0600063F RID: 1599 RVA: 0x0001E2E5 File Offset: 0x0001C4E5
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001B5 RID: 437
			// (get) Token: 0x06000640 RID: 1600 RVA: 0x0001E2F2 File Offset: 0x0001C4F2
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x170001B6 RID: 438
			// (get) Token: 0x06000641 RID: 1601 RVA: 0x0001E2F9 File Offset: 0x0001C4F9
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001B7 RID: 439
			// (get) Token: 0x06000642 RID: 1602 RVA: 0x0001E300 File Offset: 0x0001C500
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerOffice2k7Blue.xaml";
				}
			}
		}
	}
}
