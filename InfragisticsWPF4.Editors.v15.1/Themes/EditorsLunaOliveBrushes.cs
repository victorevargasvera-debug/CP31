using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200004C RID: 76
	public class EditorsLunaOliveBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes.Locator>
	{
		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00017D83 File Offset: 0x00015F83
		public static global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes.g_Instance;
			}
		}

		// Token: 0x040001FB RID: 507
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes g_Instance;

		// Token: 0x0200004D RID: 77
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000571 RID: 1393 RVA: 0x00017D9B File Offset: 0x00015F9B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000572 RID: 1394 RVA: 0x00017DA8 File Offset: 0x00015FA8
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x00017DAF File Offset: 0x00015FAF
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x00017DB6 File Offset: 0x00015FB6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsLunaOlive_Brushes.xaml";
				}
			}
		}
	}
}
