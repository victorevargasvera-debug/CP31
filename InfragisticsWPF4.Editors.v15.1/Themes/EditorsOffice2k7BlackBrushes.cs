using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000052 RID: 82
	public class EditorsOffice2k7BlackBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes.Locator>
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x00017E67 File Offset: 0x00016067
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes.g_Instance;
			}
		}

		// Token: 0x040001FE RID: 510
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes g_Instance;

		// Token: 0x02000053 RID: 83
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000589 RID: 1417 RVA: 0x00017E7F File Offset: 0x0001607F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600058A RID: 1418 RVA: 0x00017E8C File Offset: 0x0001608C
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x0600058B RID: 1419 RVA: 0x00017E93 File Offset: 0x00016093
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x0600058C RID: 1420 RVA: 0x00017E9A File Offset: 0x0001609A
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsOffice2k7Black_Brushes.xaml";
				}
			}
		}
	}
}
