using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000B3 RID: 179
	public class DockManagerLunaOlive : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerLunaOlive.Locator>
	{
		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000621 RID: 1569 RVA: 0x0001E19D File Offset: 0x0001C39D
		public static global::Infragistics.Windows.Themes.DockManagerLunaOlive Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerLunaOlive.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerLunaOlive.g_Instance = new global::Infragistics.Windows.Themes.DockManagerLunaOlive();
				}
				return global::Infragistics.Windows.Themes.DockManagerLunaOlive.g_Instance;
			}
		}

		// Token: 0x0400038B RID: 907
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerLunaOlive g_Instance;

		// Token: 0x020000B4 RID: 180
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170001A0 RID: 416
			// (get) Token: 0x06000623 RID: 1571 RVA: 0x0001E1BD File Offset: 0x0001C3BD
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170001A1 RID: 417
			// (get) Token: 0x06000624 RID: 1572 RVA: 0x0001E1CA File Offset: 0x0001C3CA
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x06000625 RID: 1573 RVA: 0x0001E1D1 File Offset: 0x0001C3D1
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x06000626 RID: 1574 RVA: 0x0001E1D8 File Offset: 0x0001C3D8
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerLunaOlive.xaml";
				}
			}
		}
	}
}
