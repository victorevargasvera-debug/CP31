using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C5 RID: 197
	public class DockManagerWashBaseDark : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerWashBaseDark.Locator>
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x0001E437 File Offset: 0x0001C637
		public static global::Infragistics.Windows.Themes.DockManagerWashBaseDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerWashBaseDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerWashBaseDark.g_Instance = new global::Infragistics.Windows.Themes.DockManagerWashBaseDark();
				}
				return global::Infragistics.Windows.Themes.DockManagerWashBaseDark.g_Instance;
			}
		}

		// Token: 0x04000394 RID: 916
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerWashBaseDark g_Instance;

		// Token: 0x020000C6 RID: 198
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001CD RID: 461
			// (get) Token: 0x06000662 RID: 1634 RVA: 0x0001E457 File Offset: 0x0001C657
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001CE RID: 462
			// (get) Token: 0x06000663 RID: 1635 RVA: 0x0001E464 File Offset: 0x0001C664
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x170001CF RID: 463
			// (get) Token: 0x06000664 RID: 1636 RVA: 0x0001E46B File Offset: 0x0001C66B
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001D0 RID: 464
			// (get) Token: 0x06000665 RID: 1637 RVA: 0x0001E472 File Offset: 0x0001C672
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerWashBaseDark.xaml";
				}
			}
		}
	}
}
