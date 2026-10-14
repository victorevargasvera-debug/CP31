using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200005A RID: 90
	public class EditorsRoyaleStrongBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes.Locator>
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060005A8 RID: 1448 RVA: 0x00017F97 File Offset: 0x00016197
		public static global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes.g_Instance;
			}
		}

		// Token: 0x04000202 RID: 514
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes g_Instance;

		// Token: 0x0200005B RID: 91
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000150 RID: 336
			// (get) Token: 0x060005A9 RID: 1449 RVA: 0x00017FAF File Offset: 0x000161AF
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x060005AA RID: 1450 RVA: 0x00017FBC File Offset: 0x000161BC
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x060005AB RID: 1451 RVA: 0x00017FC3 File Offset: 0x000161C3
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000153 RID: 339
			// (get) Token: 0x060005AC RID: 1452 RVA: 0x00017FCA File Offset: 0x000161CA
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsRoyaleStrong_Brushes.xaml";
				}
			}
		}
	}
}
