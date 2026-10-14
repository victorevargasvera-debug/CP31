using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200005F RID: 95
	public class EditorsPrintBasicBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes.Locator>
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005A1 RID: 1441 RVA: 0x0001737B File Offset: 0x0001557B
		public static global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes.g_Instance;
			}
		}

		// Token: 0x040001EB RID: 491
		private static global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsPrintBasicBrushes();

		// Token: 0x02000060 RID: 96
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000160 RID: 352
			// (get) Token: 0x060005A2 RID: 1442 RVA: 0x00017382 File Offset: 0x00015582
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000161 RID: 353
			// (get) Token: 0x060005A3 RID: 1443 RVA: 0x0001738F File Offset: 0x0001558F
			public override string Theme
			{
				get
				{
					return "Print Basic";
				}
			}

			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060005A4 RID: 1444 RVA: 0x00017396 File Offset: 0x00015596
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x060005A5 RID: 1445 RVA: 0x0001739D File Offset: 0x0001559D
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
