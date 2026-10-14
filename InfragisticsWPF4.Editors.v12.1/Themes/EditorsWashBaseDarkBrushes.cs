using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200005B RID: 91
	public class EditorsWashBaseDarkBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes.Locator>
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x000172F1 File Offset: 0x000154F1
		public static global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes.g_Instance;
			}
		}

		// Token: 0x040001E9 RID: 489
		private static global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsWashBaseDarkBrushes();

		// Token: 0x0200005C RID: 92
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000156 RID: 342
			// (get) Token: 0x06000592 RID: 1426 RVA: 0x000172F8 File Offset: 0x000154F8
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000157 RID: 343
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x00017305 File Offset: 0x00015505
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x17000158 RID: 344
			// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001730C File Offset: 0x0001550C
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000159 RID: 345
			// (get) Token: 0x06000595 RID: 1429 RVA: 0x00017313 File Offset: 0x00015513
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsWashBaseDark_Brushes.xaml";
				}
			}
		}
	}
}
