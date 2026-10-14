using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C3 RID: 195
	public class DockManagerRoyale : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerRoyale.Locator>
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x0001E3ED File Offset: 0x0001C5ED
		public static global::Infragistics.Windows.Themes.DockManagerRoyale Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerRoyale.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerRoyale.g_Instance = new global::Infragistics.Windows.Themes.DockManagerRoyale();
				}
				return global::Infragistics.Windows.Themes.DockManagerRoyale.g_Instance;
			}
		}

		// Token: 0x04000393 RID: 915
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerRoyale g_Instance;

		// Token: 0x020000C4 RID: 196
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001C8 RID: 456
			// (get) Token: 0x0600065B RID: 1627 RVA: 0x0001E40D File Offset: 0x0001C60D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001C9 RID: 457
			// (get) Token: 0x0600065C RID: 1628 RVA: 0x0001E41A File Offset: 0x0001C61A
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x170001CA RID: 458
			// (get) Token: 0x0600065D RID: 1629 RVA: 0x0001E421 File Offset: 0x0001C621
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001CB RID: 459
			// (get) Token: 0x0600065E RID: 1630 RVA: 0x0001E428 File Offset: 0x0001C628
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerRoyale.xaml";
				}
			}
		}
	}
}
