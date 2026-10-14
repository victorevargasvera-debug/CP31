using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000289 RID: 649
	public class PrimitivesOffice2k7Blue : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.Locator>
	{
		// Token: 0x1700061E RID: 1566
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x00062E99 File Offset: 0x00061099
		public static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue.g_Instance;
			}
		}

		// Token: 0x04000CE5 RID: 3301
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2k7Blue g_Instance;

		// Token: 0x0200028A RID: 650
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700061F RID: 1567
			// (get) Token: 0x06001A04 RID: 6660 RVA: 0x00062EB9 File Offset: 0x000610B9
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000620 RID: 1568
			// (get) Token: 0x06001A05 RID: 6661 RVA: 0x00062EC6 File Offset: 0x000610C6
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x17000621 RID: 1569
			// (get) Token: 0x06001A06 RID: 6662 RVA: 0x00062ECD File Offset: 0x000610CD
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000622 RID: 1570
			// (get) Token: 0x06001A07 RID: 6663 RVA: 0x00062ED4 File Offset: 0x000610D4
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOffice2k7Blue_Express.xaml;ResourceSets\\Primitives\\PrimitivesOffice2k7Blue.xaml";
				}
			}
		}
	}
}
