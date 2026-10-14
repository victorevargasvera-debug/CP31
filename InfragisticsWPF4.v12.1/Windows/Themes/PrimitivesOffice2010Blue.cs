using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000256 RID: 598
	public class PrimitivesOffice2010Blue : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.Locator>
	{
		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001807 RID: 6151 RVA: 0x0005C46B File Offset: 0x0005A66B
		public static global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue();
				}
				return global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue.g_Instance;
			}
		}

		// Token: 0x04000B83 RID: 2947
		private static global::Infragistics.Windows.Themes.PrimitivesOffice2010Blue g_Instance;

		// Token: 0x02000257 RID: 599
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170005A7 RID: 1447
			// (get) Token: 0x06001809 RID: 6153 RVA: 0x0005C48B File Offset: 0x0005A68B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170005A8 RID: 1448
			// (get) Token: 0x0600180A RID: 6154 RVA: 0x0005C498 File Offset: 0x0005A698
			public override string Theme
			{
				get
				{
					return "Office2010Blue";
				}
			}

			// Token: 0x170005A9 RID: 1449
			// (get) Token: 0x0600180B RID: 6155 RVA: 0x0005C49F File Offset: 0x0005A69F
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x170005AA RID: 1450
			// (get) Token: 0x0600180C RID: 6156 RVA: 0x0005C4A6 File Offset: 0x0005A6A6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesOffice2010Blue_Express.xaml;ResourceSets\\Primitives\\PrimitivesOffice2010Blue.xaml";
				}
			}
		}
	}
}
