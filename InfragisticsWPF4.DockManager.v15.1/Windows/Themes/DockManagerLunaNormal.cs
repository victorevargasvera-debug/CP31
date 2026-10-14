using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000B1 RID: 177
	public class DockManagerLunaNormal : global::Infragistics.Windows.Themes.DockManagerResourceSet<global::Infragistics.Windows.Themes.DockManagerLunaNormal.Locator>
	{
		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x0001E153 File Offset: 0x0001C353
		public static global::Infragistics.Windows.Themes.DockManagerLunaNormal Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerLunaNormal.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerLunaNormal.g_Instance = new global::Infragistics.Windows.Themes.DockManagerLunaNormal();
				}
				return global::Infragistics.Windows.Themes.DockManagerLunaNormal.g_Instance;
			}
		}

		// Token: 0x0400038A RID: 906
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerLunaNormal g_Instance;

		// Token: 0x020000B2 RID: 178
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700019B RID: 411
			// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001E173 File Offset: 0x0001C373
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x0600061D RID: 1565 RVA: 0x0001E180 File Offset: 0x0001C380
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x0600061E RID: 1566 RVA: 0x0001E187 File Offset: 0x0001C387
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x0600061F RID: 1567 RVA: 0x0001E18E File Offset: 0x0001C38E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManager\\DockManagerLunaNormal.xaml";
				}
			}
		}
	}
}
