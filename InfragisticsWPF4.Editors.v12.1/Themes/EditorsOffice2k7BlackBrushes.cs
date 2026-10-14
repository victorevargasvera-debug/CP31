using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200004F RID: 79
	public class EditorsOffice2k7BlackBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes.Locator>
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000561 RID: 1377 RVA: 0x00017153 File Offset: 0x00015353
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes.g_Instance;
			}
		}

		// Token: 0x040001E3 RID: 483
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7BlackBrushes();

		// Token: 0x02000050 RID: 80
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x0001715A File Offset: 0x0001535A
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000563 RID: 1379 RVA: 0x00017167 File Offset: 0x00015367
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x0001716E File Offset: 0x0001536E
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000565 RID: 1381 RVA: 0x00017175 File Offset: 0x00015375
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
