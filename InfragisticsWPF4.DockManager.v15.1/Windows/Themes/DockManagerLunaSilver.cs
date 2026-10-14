using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000B5 RID: 181
	public class DockManagerLunaSilver : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerLunaSilver.Locator>
	{
		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0001E1E7 File Offset: 0x0001C3E7
		public static global::Infragistics.Windows.Themes.DockManagerLunaSilver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerLunaSilver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerLunaSilver.g_Instance = new global::Infragistics.Windows.Themes.DockManagerLunaSilver();
				}
				return global::Infragistics.Windows.Themes.DockManagerLunaSilver.g_Instance;
			}
		}

		// Token: 0x0400038C RID: 908
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerLunaSilver g_Instance;

		// Token: 0x020000B6 RID: 182
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x0600062A RID: 1578 RVA: 0x0001E207 File Offset: 0x0001C407
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x0600062B RID: 1579 RVA: 0x0001E214 File Offset: 0x0001C414
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x0600062C RID: 1580 RVA: 0x0001E21B File Offset: 0x0001C41B
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x0600062D RID: 1581 RVA: 0x0001E222 File Offset: 0x0001C422
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerLunaSilver.xaml";
				}
			}
		}
	}
}
