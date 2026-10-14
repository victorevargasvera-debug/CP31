using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CB RID: 203
	public class DockManagerMetro : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerMetro.Locator>
	{
		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000675 RID: 1653 RVA: 0x0001E515 File Offset: 0x0001C715
		public static global::Infragistics.Windows.Themes.DockManagerMetro Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerMetro.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerMetro.g_Instance = new global::Infragistics.Windows.Themes.DockManagerMetro();
				}
				return global::Infragistics.Windows.Themes.DockManagerMetro.g_Instance;
			}
		}

		// Token: 0x04000397 RID: 919
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerMetro g_Instance;

		// Token: 0x020000CC RID: 204
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001DC RID: 476
			// (get) Token: 0x06000677 RID: 1655 RVA: 0x0001E535 File Offset: 0x0001C735
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001DD RID: 477
			// (get) Token: 0x06000678 RID: 1656 RVA: 0x0001E542 File Offset: 0x0001C742
			public override string Theme
			{
				get
				{
					return "Metro";
				}
			}

			// Token: 0x170001DE RID: 478
			// (get) Token: 0x06000679 RID: 1657 RVA: 0x0001E549 File Offset: 0x0001C749
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001DF RID: 479
			// (get) Token: 0x0600067A RID: 1658 RVA: 0x0001E550 File Offset: 0x0001C750
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerMetro.xaml";
				}
			}
		}
	}
}
