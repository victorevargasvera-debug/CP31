using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000E2 RID: 226
	public class EditorsWashBaseLight : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsWashBaseLight.Locator>
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x00030111 File Offset: 0x0002E311
		public static global::Infragistics.Windows.Themes.EditorsWashBaseLight Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsWashBaseLight.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsWashBaseLight.g_Instance = new global::Infragistics.Windows.Themes.EditorsWashBaseLight();
				}
				return global::Infragistics.Windows.Themes.EditorsWashBaseLight.g_Instance;
			}
		}

		// Token: 0x040003E9 RID: 1001
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsWashBaseLight g_Instance;

		// Token: 0x020000E3 RID: 227
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002D2 RID: 722
			// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00030131 File Offset: 0x0002E331
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002D3 RID: 723
			// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0003013E File Offset: 0x0002E33E
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x170002D4 RID: 724
			// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00030145 File Offset: 0x0002E345
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002D5 RID: 725
			// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003014C File Offset: 0x0002E34C
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsWashBaseLight_Express.xaml;ResourceSets\\Editors\\EditorsWashBaseLight.xaml";
				}
			}
		}
	}
}
