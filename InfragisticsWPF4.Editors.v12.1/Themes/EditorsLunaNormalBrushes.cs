using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000047 RID: 71
	public class EditorsLunaNormalBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes.Locator>
	{
		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001703F File Offset: 0x0001523F
		public static global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes.g_Instance;
			}
		}

		// Token: 0x040001DF RID: 479
		private static global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes();

		// Token: 0x02000048 RID: 72
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x00017046 File Offset: 0x00015246
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x00017053 File Offset: 0x00015253
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000544 RID: 1348 RVA: 0x0001705A File Offset: 0x0001525A
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x06000545 RID: 1349 RVA: 0x00017061 File Offset: 0x00015261
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsLunaNormal_Brushes.xaml";
				}
			}
		}
	}
}
