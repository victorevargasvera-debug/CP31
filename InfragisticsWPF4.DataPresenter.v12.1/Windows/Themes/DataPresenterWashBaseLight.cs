using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200034A RID: 842
	public class DataPresenterWashBaseLight : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterWashBaseLight.Locator>
	{
		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x000ABCAD File Offset: 0x000A9EAD
		public static global::Infragistics.Windows.Themes.DataPresenterWashBaseLight Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterWashBaseLight.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterWashBaseLight.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterWashBaseLight();
				}
				return global::Infragistics.Windows.Themes.DataPresenterWashBaseLight.g_Instance;
			}
		}

		// Token: 0x040012E4 RID: 4836
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseLight g_Instance;

		// Token: 0x0200034B RID: 843
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000C02 RID: 3074
			// (get) Token: 0x060027CE RID: 10190 RVA: 0x000ABCCD File Offset: 0x000A9ECD
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000C03 RID: 3075
			// (get) Token: 0x060027CF RID: 10191 RVA: 0x000ABCDA File Offset: 0x000A9EDA
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x17000C04 RID: 3076
			// (get) Token: 0x060027D0 RID: 10192 RVA: 0x000ABCE1 File Offset: 0x000A9EE1
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000C05 RID: 3077
			// (get) Token: 0x060027D1 RID: 10193 RVA: 0x000ABCE8 File Offset: 0x000A9EE8
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterWashBaseLight.xaml";
				}
			}
		}
	}
}
