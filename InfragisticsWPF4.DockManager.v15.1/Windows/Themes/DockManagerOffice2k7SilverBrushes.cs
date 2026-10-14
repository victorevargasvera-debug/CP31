using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000A4 RID: 164
	public class DockManagerOffice2k7SilverBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerOffice2k7SilverBrushes.Locator>
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x0001DA38 File Offset: 0x0001BC38
		public static global::Infragistics.Windows.Themes.DockManagerOffice2k7SilverBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerOffice2k7SilverBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerOffice2k7SilverBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerOffice2k7SilverBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerOffice2k7SilverBrushes.g_Instance;
			}
		}

		// Token: 0x04000367 RID: 871
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerOffice2k7SilverBrushes g_Instance;

		// Token: 0x020000A5 RID: 165
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000162 RID: 354
			// (get) Token: 0x060005D2 RID: 1490 RVA: 0x0001DA50 File Offset: 0x0001BC50
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000163 RID: 355
			// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0001DA5D File Offset: 0x0001BC5D
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x060005D4 RID: 1492 RVA: 0x0001DA64 File Offset: 0x0001BC64
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0001DA6B File Offset: 0x0001BC6B
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerOffice2k7Silver_Brushes.xaml";
				}
			}
		}
	}
}
