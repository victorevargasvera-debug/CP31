using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000D8 RID: 216
	public class EditorsWashBaseLight : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsWashBaseLight.Locator>
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000A83 RID: 2691 RVA: 0x0002E033 File Offset: 0x0002C233
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

		// Token: 0x040003B1 RID: 945
		private static global::Infragistics.Windows.Themes.EditorsWashBaseLight g_Instance;

		// Token: 0x020000D9 RID: 217
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x170002B3 RID: 691
			// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0002E053 File Offset: 0x0002C253
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x170002B4 RID: 692
			// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0002E060 File Offset: 0x0002C260
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x170002B5 RID: 693
			// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0002E067 File Offset: 0x0002C267
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x170002B6 RID: 694
			// (get) Token: 0x06000A88 RID: 2696 RVA: 0x0002E06E File Offset: 0x0002C26E
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
