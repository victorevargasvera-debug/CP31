using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000060 RID: 96
	public class EditorsWashBaseLightBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes.Locator>
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x0001807B File Offset: 0x0001627B
		public static global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes.g_Instance;
			}
		}

		// Token: 0x04000205 RID: 517
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsWashBaseLightBrushes g_Instance;

		// Token: 0x02000061 RID: 97
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700015F RID: 351
			// (get) Token: 0x060005C1 RID: 1473 RVA: 0x00018093 File Offset: 0x00016293
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000160 RID: 352
			// (get) Token: 0x060005C2 RID: 1474 RVA: 0x000180A0 File Offset: 0x000162A0
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x060005C3 RID: 1475 RVA: 0x000180A7 File Offset: 0x000162A7
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060005C4 RID: 1476 RVA: 0x000180AE File Offset: 0x000162AE
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsWashBaseLight_Brushes.xaml";
				}
			}
		}
	}
}
