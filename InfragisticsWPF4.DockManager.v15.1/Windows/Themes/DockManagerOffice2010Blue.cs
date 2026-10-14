using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000BF RID: 191
	public class DockManagerOffice2010Blue : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerOffice2010Blue.Locator>
	{
		// Token: 0x170001BD RID: 445
		// (get) Token: 0x0600064B RID: 1611 RVA: 0x0001E359 File Offset: 0x0001C559
		public static global::Infragistics.Windows.Themes.DockManagerOffice2010Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2010Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2010Blue.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2010Blue();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2010Blue.g_Instance;
			}
		}

		// Token: 0x04000391 RID: 913
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2010Blue g_Instance;

		// Token: 0x020000C0 RID: 192
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001BE RID: 446
			// (get) Token: 0x0600064D RID: 1613 RVA: 0x0001E379 File Offset: 0x0001C579
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x0600064E RID: 1614 RVA: 0x0001E386 File Offset: 0x0001C586
			public override string Theme
			{
				get
				{
					return "Office2010Blue";
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x0600064F RID: 1615 RVA: 0x0001E38D File Offset: 0x0001C58D
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x06000650 RID: 1616 RVA: 0x0001E394 File Offset: 0x0001C594
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerOffice2010Blue.xaml";
				}
			}
		}
	}
}
