using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200004A RID: 74
	public class EditorsLunaNormalBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes.Locator>
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000568 RID: 1384 RVA: 0x00017D37 File Offset: 0x00015F37
		public static global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes.g_Instance;
			}
		}

		// Token: 0x040001FA RID: 506
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsLunaNormalBrushes g_Instance;

		// Token: 0x0200004B RID: 75
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000569 RID: 1385 RVA: 0x00017D4F File Offset: 0x00015F4F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x00017D5C File Offset: 0x00015F5C
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x0600056B RID: 1387 RVA: 0x00017D63 File Offset: 0x00015F63
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x0600056C RID: 1388 RVA: 0x00017D6A File Offset: 0x00015F6A
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
