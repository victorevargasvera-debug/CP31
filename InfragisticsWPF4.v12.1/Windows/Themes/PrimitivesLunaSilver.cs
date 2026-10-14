using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200024C RID: 588
	public class PrimitivesLunaSilver : global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesLunaSilver.Locator>
	{
		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x0005C2F9 File Offset: 0x0005A4F9
		public static global::Infragistics.Windows.Themes.PrimitivesLunaSilver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.PrimitivesLunaSilver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.PrimitivesLunaSilver.g_Instance = new global::Infragistics.Windows.Themes.PrimitivesLunaSilver();
				}
				return global::Infragistics.Windows.Themes.PrimitivesLunaSilver.g_Instance;
			}
		}

		// Token: 0x04000B7E RID: 2942
		private static global::Infragistics.Windows.Themes.PrimitivesLunaSilver g_Instance;

		// Token: 0x0200024D RID: 589
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700058E RID: 1422
			// (get) Token: 0x060017E6 RID: 6118 RVA: 0x0005C319 File Offset: 0x0005A519
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700058F RID: 1423
			// (get) Token: 0x060017E7 RID: 6119 RVA: 0x0005C326 File Offset: 0x0005A526
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x17000590 RID: 1424
			// (get) Token: 0x060017E8 RID: 6120 RVA: 0x0005C32D File Offset: 0x0005A52D
			public override string Grouping
			{
				get
				{
					return "Primitives";
				}
			}

			// Token: 0x17000591 RID: 1425
			// (get) Token: 0x060017E9 RID: 6121 RVA: 0x0005C334 File Offset: 0x0005A534
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Primitives\\PrimitivesLunaSilver_Express.xaml;ResourceSets\\Primitives\\PrimitivesLunaSilver.xaml";
				}
			}
		}
	}
}
