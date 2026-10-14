using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000062 RID: 98
	public class EditorsPrintBasicBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes.Locator>
	{
		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005C8 RID: 1480 RVA: 0x000180C7 File Offset: 0x000162C7
		public static global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes.g_Instance;
			}
		}

		// Token: 0x04000206 RID: 518
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes g_Instance;

		// Token: 0x02000063 RID: 99
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000180DF File Offset: 0x000162DF
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060005CA RID: 1482 RVA: 0x000180EC File Offset: 0x000162EC
			public override string Theme
			{
				get
				{
					return "Print Basic";
				}
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060005CB RID: 1483 RVA: 0x000180F3 File Offset: 0x000162F3
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060005CC RID: 1484 RVA: 0x000180FA File Offset: 0x000162FA
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsPrintBasic_Brushes.xaml";
				}
			}
		}
	}
}
