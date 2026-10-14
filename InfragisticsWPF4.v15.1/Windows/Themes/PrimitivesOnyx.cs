using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000275 RID: 629
	public class PrimitivesOnyx : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOnyx.Locator>
	{
		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060019BC RID: 6588 RVA: 0x00062BB5 File Offset: 0x00060DB5
		public static global::Infragistics.Windows.Themes.PrimitivesOnyx Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOnyx.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOnyx.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOnyx();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOnyx.g_Instance;
			}
		}

		// Token: 0x04000CDB RID: 3291
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesOnyx g_Instance;

		// Token: 0x02000276 RID: 630
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005ED RID: 1517
			// (get) Token: 0x060019BE RID: 6590 RVA: 0x00062BD5 File Offset: 0x00060DD5
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005EE RID: 1518
			// (get) Token: 0x060019BF RID: 6591 RVA: 0x00062BE2 File Offset: 0x00060DE2
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x170005EF RID: 1519
			// (get) Token: 0x060019C0 RID: 6592 RVA: 0x00062BE9 File Offset: 0x00060DE9
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005F0 RID: 1520
			// (get) Token: 0x060019C1 RID: 6593 RVA: 0x00062BF0 File Offset: 0x00060DF0
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOnyx_Express.xaml;ResourceSets\\Primitives\\PrimitivesOnyx.xaml";
				}
			}
		}
	}
}
