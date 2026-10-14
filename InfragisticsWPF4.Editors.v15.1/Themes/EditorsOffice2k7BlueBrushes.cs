using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000054 RID: 84
	public class EditorsOffice2k7BlueBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes.Locator>
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x00017EB3 File Offset: 0x000160B3
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes.g_Instance;
			}
		}

		// Token: 0x040001FF RID: 511
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes g_Instance;

		// Token: 0x02000055 RID: 85
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000141 RID: 321
			// (get) Token: 0x06000591 RID: 1425 RVA: 0x00017ECB File Offset: 0x000160CB
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000592 RID: 1426 RVA: 0x00017ED8 File Offset: 0x000160D8
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000593 RID: 1427 RVA: 0x00017EDF File Offset: 0x000160DF
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000594 RID: 1428 RVA: 0x00017EE6 File Offset: 0x000160E6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsOffice2k7Blue_Brushes.xaml";
				}
			}
		}
	}
}
