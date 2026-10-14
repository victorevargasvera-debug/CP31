using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CD RID: 205
	public class DockManagerMetroDark : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerMetroDark.Locator>
	{
		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x0001E55F File Offset: 0x0001C75F
		public static global::Infragistics.Windows.Themes.DockManagerMetroDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerMetroDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerMetroDark.g_Instance = new global::Infragistics.Windows.Themes.DockManagerMetroDark();
				}
				return global::Infragistics.Windows.Themes.DockManagerMetroDark.g_Instance;
			}
		}

		// Token: 0x04000398 RID: 920
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerMetroDark g_Instance;

		// Token: 0x020000CE RID: 206
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001E1 RID: 481
			// (get) Token: 0x0600067E RID: 1662 RVA: 0x0001E57F File Offset: 0x0001C77F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001E2 RID: 482
			// (get) Token: 0x0600067F RID: 1663 RVA: 0x0001E58C File Offset: 0x0001C78C
			public override string Theme
			{
				get
				{
					return "MetroDark";
				}
			}

			// Token: 0x170001E3 RID: 483
			// (get) Token: 0x06000680 RID: 1664 RVA: 0x0001E593 File Offset: 0x0001C793
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001E4 RID: 484
			// (get) Token: 0x06000681 RID: 1665 RVA: 0x0001E59A File Offset: 0x0001C79A
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerMetroDark.xaml";
				}
			}
		}
	}
}
