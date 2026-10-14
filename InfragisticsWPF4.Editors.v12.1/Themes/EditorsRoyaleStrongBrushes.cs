using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000057 RID: 87
	public class EditorsRoyaleStrongBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes.Locator>
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000581 RID: 1409 RVA: 0x00017267 File Offset: 0x00015467
		public static global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes.g_Instance;
			}
		}

		// Token: 0x040001E7 RID: 487
		private static global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyaleStrongBrushes();

		// Token: 0x02000058 RID: 88
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700014C RID: 332
			// (get) Token: 0x06000582 RID: 1410 RVA: 0x0001726E File Offset: 0x0001546E
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x06000583 RID: 1411 RVA: 0x0001727B File Offset: 0x0001547B
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000584 RID: 1412 RVA: 0x00017282 File Offset: 0x00015482
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000585 RID: 1413 RVA: 0x00017289 File Offset: 0x00015489
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
