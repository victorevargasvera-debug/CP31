using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000055 RID: 85
	public class EditorsRoyaleBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsRoyaleBrushes.Locator>
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00017222 File Offset: 0x00015422
		public static global::Infragistics.Windows.Themes.EditorsRoyaleBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsRoyaleBrushes.g_Instance;
			}
		}

		// Token: 0x040001E6 RID: 486
		private static global::Infragistics.Windows.Themes.EditorsRoyaleBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyaleBrushes();

		// Token: 0x02000056 RID: 86
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000147 RID: 327
			// (get) Token: 0x0600057A RID: 1402 RVA: 0x00017229 File Offset: 0x00015429
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x0600057B RID: 1403 RVA: 0x00017236 File Offset: 0x00015436
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x0600057C RID: 1404 RVA: 0x0001723D File Offset: 0x0001543D
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700014A RID: 330
			// (get) Token: 0x0600057D RID: 1405 RVA: 0x00017244 File Offset: 0x00015444
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
