using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D0 RID: 208
	public class EditorsLunaNormal : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaNormal.Locator>
	{
		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0002FE77 File Offset: 0x0002E077
		public static global::Infragistics.Windows.Themes.EditorsLunaNormal Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaNormal.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaNormal.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaNormal();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaNormal.g_Instance;
			}
		}

		// Token: 0x040003E0 RID: 992
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsLunaNormal g_Instance;

		// Token: 0x020000D1 RID: 209
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002A5 RID: 677
			// (get) Token: 0x06000AC2 RID: 2754 RVA: 0x0002FE97 File Offset: 0x0002E097
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002A6 RID: 678
			// (get) Token: 0x06000AC3 RID: 2755 RVA: 0x0002FEA4 File Offset: 0x0002E0A4
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x170002A7 RID: 679
			// (get) Token: 0x06000AC4 RID: 2756 RVA: 0x0002FEAB File Offset: 0x0002E0AB
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002A8 RID: 680
			// (get) Token: 0x06000AC5 RID: 2757 RVA: 0x0002FEB2 File Offset: 0x0002E0B2
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsLunaNormal_Express.xaml;ResourceSets\\Editors\\EditorsLunaNormal.xaml";
				}
			}
		}
	}
}
