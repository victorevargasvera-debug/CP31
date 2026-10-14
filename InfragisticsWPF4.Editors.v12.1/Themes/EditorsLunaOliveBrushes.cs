using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000049 RID: 73
	public class EditorsLunaOliveBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes.Locator>
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00017084 File Offset: 0x00015284
		public static global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes.g_Instance;
			}
		}

		// Token: 0x040001E0 RID: 480
		private static global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaOliveBrushes();

		// Token: 0x0200004A RID: 74
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000129 RID: 297
			// (get) Token: 0x0600054A RID: 1354 RVA: 0x0001708B File Offset: 0x0001528B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x0600054B RID: 1355 RVA: 0x00017098 File Offset: 0x00015298
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600054C RID: 1356 RVA: 0x0001709F File Offset: 0x0001529F
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x0600054D RID: 1357 RVA: 0x000170A6 File Offset: 0x000152A6
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
