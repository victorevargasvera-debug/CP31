using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200038E RID: 910
	public class DataPresenterWashBaseLight : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterWashBaseLight.Locator>
	{
		// Token: 0x17000D54 RID: 3412
		// (get) Token: 0x06002BAD RID: 11181 RVA: 0x000C08BF File Offset: 0x000BEABF
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

		// Token: 0x0400150B RID: 5387
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseLight g_Instance;

		// Token: 0x0200038F RID: 911
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D55 RID: 3413
			// (get) Token: 0x06002BAF RID: 11183 RVA: 0x000C08DF File Offset: 0x000BEADF
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D56 RID: 3414
			// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x000C08EC File Offset: 0x000BEAEC
			public override string Theme
			{
				get
				{
					return "WashBaseLight";
				}
			}

			// Token: 0x17000D57 RID: 3415
			// (get) Token: 0x06002BB1 RID: 11185 RVA: 0x000C08F3 File Offset: 0x000BEAF3
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D58 RID: 3416
			// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x000C08FA File Offset: 0x000BEAFA
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
