using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D4 RID: 212
	public class EditorsLunaSilver : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaSilver.Locator>
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000ACE RID: 2766 RVA: 0x0002FF0B File Offset: 0x0002E10B
		public static global::Infragistics.Windows.Themes.EditorsLunaSilver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaSilver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaSilver.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaSilver();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaSilver.g_Instance;
			}
		}

		// Token: 0x040003E2 RID: 994
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsLunaSilver g_Instance;

		// Token: 0x020000D5 RID: 213
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002AF RID: 687
			// (get) Token: 0x06000AD0 RID: 2768 RVA: 0x0002FF2B File Offset: 0x0002E12B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002B0 RID: 688
			// (get) Token: 0x06000AD1 RID: 2769 RVA: 0x0002FF38 File Offset: 0x0002E138
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x170002B1 RID: 689
			// (get) Token: 0x06000AD2 RID: 2770 RVA: 0x0002FF3F File Offset: 0x0002E13F
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002B2 RID: 690
			// (get) Token: 0x06000AD3 RID: 2771 RVA: 0x0002FF46 File Offset: 0x0002E146
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsLunaSilver_Express.xaml;ResourceSets\\Editors\\EditorsLunaSilver.xaml";
				}
			}
		}
	}
}
