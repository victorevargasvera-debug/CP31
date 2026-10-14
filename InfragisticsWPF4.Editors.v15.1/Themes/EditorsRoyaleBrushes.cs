using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000058 RID: 88
	public class EditorsRoyaleBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsRoyaleBrushes.Locator>
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00017F4B File Offset: 0x0001614B
		public static global::Infragistics.Windows.Themes.EditorsRoyaleBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsRoyaleBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsRoyaleBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyaleBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsRoyaleBrushes.g_Instance;
			}
		}

		// Token: 0x04000201 RID: 513
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsRoyaleBrushes g_Instance;

		// Token: 0x02000059 RID: 89
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700014B RID: 331
			// (get) Token: 0x060005A1 RID: 1441 RVA: 0x00017F63 File Offset: 0x00016163
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700014C RID: 332
			// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00017F70 File Offset: 0x00016170
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x060005A3 RID: 1443 RVA: 0x00017F77 File Offset: 0x00016177
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00017F7E File Offset: 0x0001617E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsRoyale_Brushes.xaml";
				}
			}
		}
	}
}
