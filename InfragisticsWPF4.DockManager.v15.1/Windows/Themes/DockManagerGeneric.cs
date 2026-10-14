using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000AF RID: 175
	public class DockManagerGeneric : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerGeneric.Locator>
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000613 RID: 1555 RVA: 0x0001E109 File Offset: 0x0001C309
		public static global::Infragistics.Windows.Themes.DockManagerGeneric Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerGeneric.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerGeneric.g_Instance = new global::Infragistics.Windows.Themes.DockManagerGeneric();
				}
				return global::Infragistics.Windows.Themes.DockManagerGeneric.g_Instance;
			}
		}

		// Token: 0x04000389 RID: 905
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerGeneric g_Instance;

		// Token: 0x020000B0 RID: 176
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000196 RID: 406
			// (get) Token: 0x06000615 RID: 1557 RVA: 0x0001E129 File Offset: 0x0001C329
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000197 RID: 407
			// (get) Token: 0x06000616 RID: 1558 RVA: 0x0001E136 File Offset: 0x0001C336
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x17000198 RID: 408
			// (get) Token: 0x06000617 RID: 1559 RVA: 0x0001E13D File Offset: 0x0001C33D
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000199 RID: 409
			// (get) Token: 0x06000618 RID: 1560 RVA: 0x0001E144 File Offset: 0x0001C344
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerGeneric.xaml";
				}
			}
		}
	}
}
