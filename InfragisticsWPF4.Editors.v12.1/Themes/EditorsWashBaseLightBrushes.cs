using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200005D RID: 93
	public class EditorsWashBaseLightBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes.Locator>
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x00017336 File Offset: 0x00015536
		public static global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes.g_Instance;
			}
		}

		// Token: 0x040001EA RID: 490
		private static global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes();

		// Token: 0x0200005E RID: 94
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700015B RID: 347
			// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001733D File Offset: 0x0001553D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700015C RID: 348
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001734A File Offset: 0x0001554A
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x0600059C RID: 1436 RVA: 0x00017351 File Offset: 0x00015551
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700015E RID: 350
			// (get) Token: 0x0600059D RID: 1437 RVA: 0x00017358 File Offset: 0x00015558
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsWashBaseLight_Brushes.xaml";
				}
			}
		}
	}
}
