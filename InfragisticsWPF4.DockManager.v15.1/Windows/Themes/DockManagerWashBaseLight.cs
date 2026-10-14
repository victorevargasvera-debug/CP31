using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C7 RID: 199
	public class DockManagerWashBaseLight : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerWashBaseLight.Locator>
	{
		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000667 RID: 1639 RVA: 0x0001E481 File Offset: 0x0001C681
		public static global::Infragistics.Windows.Themes.DockManagerWashBaseLight Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerWashBaseLight.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerWashBaseLight.g_Instance = new global::Infragistics.Windows.Themes.DockManagerWashBaseLight();
				}
				return global::Infragistics.Windows.Themes.DockManagerWashBaseLight.g_Instance;
			}
		}

		// Token: 0x04000395 RID: 917
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerWashBaseLight g_Instance;

		// Token: 0x020000C8 RID: 200
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001D2 RID: 466
			// (get) Token: 0x06000669 RID: 1641 RVA: 0x0001E4A1 File Offset: 0x0001C6A1
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001D3 RID: 467
			// (get) Token: 0x0600066A RID: 1642 RVA: 0x0001E4AE File Offset: 0x0001C6AE
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x170001D4 RID: 468
			// (get) Token: 0x0600066B RID: 1643 RVA: 0x0001E4B5 File Offset: 0x0001C6B5
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001D5 RID: 469
			// (get) Token: 0x0600066C RID: 1644 RVA: 0x0001E4BC File Offset: 0x0001C6BC
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerWashBaseLight.xaml";
				}
			}
		}
	}
}
