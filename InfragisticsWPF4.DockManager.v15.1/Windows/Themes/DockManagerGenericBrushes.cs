using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000096 RID: 150
	public class DockManagerGenericBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerGenericBrushes.Locator>
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000599 RID: 1433 RVA: 0x0001D824 File Offset: 0x0001BA24
		public static global::Infragistics.Windows.Themes.DockManagerGenericBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerGenericBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerGenericBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerGenericBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerGenericBrushes.g_Instance;
			}
		}

		// Token: 0x04000360 RID: 864
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerGenericBrushes g_Instance;

		// Token: 0x02000097 RID: 151
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700013F RID: 319
			// (get) Token: 0x0600059A RID: 1434 RVA: 0x0001D83C File Offset: 0x0001BA3C
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x0600059B RID: 1435 RVA: 0x0001D849 File Offset: 0x0001BA49
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x17000141 RID: 321
			// (get) Token: 0x0600059C RID: 1436 RVA: 0x0001D850 File Offset: 0x0001BA50
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000142 RID: 322
			// (get) Token: 0x0600059D RID: 1437 RVA: 0x0001D857 File Offset: 0x0001BA57
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerGeneric_Brushes.xaml";
				}
			}
		}
	}
}
