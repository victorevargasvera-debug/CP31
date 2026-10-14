using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000056 RID: 86
	public class EditorsOffice2k7SilverBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes.Locator>
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000598 RID: 1432 RVA: 0x00017EFF File Offset: 0x000160FF
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes.g_Instance;
			}
		}

		// Token: 0x04000200 RID: 512
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes g_Instance;

		// Token: 0x02000057 RID: 87
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000146 RID: 326
			// (get) Token: 0x06000599 RID: 1433 RVA: 0x00017F17 File Offset: 0x00016117
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000147 RID: 327
			// (get) Token: 0x0600059A RID: 1434 RVA: 0x00017F24 File Offset: 0x00016124
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x17000148 RID: 328
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x00017F2B File Offset: 0x0001612B
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000149 RID: 329
			// (get) Token: 0x0600059C RID: 1436 RVA: 0x00017F32 File Offset: 0x00016132
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsOffice2k7Silver_Brushes.xaml";
				}
			}
		}
	}
}
