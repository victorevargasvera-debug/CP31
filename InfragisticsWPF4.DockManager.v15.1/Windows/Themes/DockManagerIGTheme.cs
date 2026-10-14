using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C9 RID: 201
	public class DockManagerIGTheme : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerIGTheme.Locator>
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x0001E4CB File Offset: 0x0001C6CB
		public static global::Infragistics.Windows.Themes.DockManagerIGTheme Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerIGTheme.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerIGTheme.g_Instance = new global::Infragistics.Windows.Themes.DockManagerIGTheme();
				}
				return global::Infragistics.Windows.Themes.DockManagerIGTheme.g_Instance;
			}
		}

		// Token: 0x04000396 RID: 918
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerIGTheme g_Instance;

		// Token: 0x020000CA RID: 202
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001D7 RID: 471
			// (get) Token: 0x06000670 RID: 1648 RVA: 0x0001E4EB File Offset: 0x0001C6EB
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001D8 RID: 472
			// (get) Token: 0x06000671 RID: 1649 RVA: 0x0001E4F8 File Offset: 0x0001C6F8
			public override string Theme
			{
				get
				{
					return "IGTheme";
				}
			}

			// Token: 0x170001D9 RID: 473
			// (get) Token: 0x06000672 RID: 1650 RVA: 0x0001E4FF File Offset: 0x0001C6FF
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001DA RID: 474
			// (get) Token: 0x06000673 RID: 1651 RVA: 0x0001E506 File Offset: 0x0001C706
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerIGTheme.xaml";
				}
			}
		}
	}
}
