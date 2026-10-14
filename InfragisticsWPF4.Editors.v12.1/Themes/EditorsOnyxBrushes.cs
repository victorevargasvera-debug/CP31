using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000059 RID: 89
	public class EditorsOnyxBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOnyxBrushes.Locator>
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x000172AC File Offset: 0x000154AC
		public static global::Infragistics.Windows.Themes.EditorsOnyxBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsOnyxBrushes.g_Instance;
			}
		}

		// Token: 0x040001E8 RID: 488
		private static global::Infragistics.Windows.Themes.EditorsOnyxBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsOnyxBrushes();

		// Token: 0x0200005A RID: 90
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000151 RID: 337
			// (get) Token: 0x0600058A RID: 1418 RVA: 0x000172B3 File Offset: 0x000154B3
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x0600058B RID: 1419 RVA: 0x000172C0 File Offset: 0x000154C0
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x0600058C RID: 1420 RVA: 0x000172C7 File Offset: 0x000154C7
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000154 RID: 340
			// (get) Token: 0x0600058D RID: 1421 RVA: 0x000172CE File Offset: 0x000154CE
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
