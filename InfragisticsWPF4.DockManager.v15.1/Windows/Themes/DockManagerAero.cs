using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000B7 RID: 183
	public class DockManagerAero : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerAero.Locator>
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x0600062F RID: 1583 RVA: 0x0001E231 File Offset: 0x0001C431
		public static global::Infragistics.Windows.Themes.DockManagerAero Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerAero.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerAero.g_Instance = new global::Infragistics.Windows.Themes.DockManagerAero();
				}
				return global::Infragistics.Windows.Themes.DockManagerAero.g_Instance;
			}
		}

		// Token: 0x0400038D RID: 909
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerAero g_Instance;

		// Token: 0x020000B8 RID: 184
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001AA RID: 426
			// (get) Token: 0x06000631 RID: 1585 RVA: 0x0001E251 File Offset: 0x0001C451
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001AB RID: 427
			// (get) Token: 0x06000632 RID: 1586 RVA: 0x0001E25E File Offset: 0x0001C45E
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x170001AC RID: 428
			// (get) Token: 0x06000633 RID: 1587 RVA: 0x0001E265 File Offset: 0x0001C465
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001AD RID: 429
			// (get) Token: 0x06000634 RID: 1588 RVA: 0x0001E26C File Offset: 0x0001C46C
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerAero.xaml";
				}
			}
		}
	}
}
