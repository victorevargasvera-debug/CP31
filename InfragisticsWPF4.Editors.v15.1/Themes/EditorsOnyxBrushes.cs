using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200005C RID: 92
	public class EditorsOnyxBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOnyxBrushes.Locator>
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x00017FE3 File Offset: 0x000161E3
		public static global::Infragistics.Windows.Themes.EditorsOnyxBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOnyxBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOnyxBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsOnyxBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsOnyxBrushes.g_Instance;
			}
		}

		// Token: 0x04000203 RID: 515
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOnyxBrushes g_Instance;

		// Token: 0x0200005D RID: 93
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000155 RID: 341
			// (get) Token: 0x060005B1 RID: 1457 RVA: 0x00017FFB File Offset: 0x000161FB
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000156 RID: 342
			// (get) Token: 0x060005B2 RID: 1458 RVA: 0x00018008 File Offset: 0x00016208
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0001800F File Offset: 0x0001620F
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00018016 File Offset: 0x00016216
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsOnyx_Brushes.xaml";
				}
			}
		}
	}
}
