using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000386 RID: 902
	public class DataPresenterOffice2k7Silver : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver.Locator>
	{
		// Token: 0x17000D40 RID: 3392
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x000C0797 File Offset: 0x000BE997
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver.g_Instance;
			}
		}

		// Token: 0x04001507 RID: 5383
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver g_Instance;

		// Token: 0x02000387 RID: 903
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D41 RID: 3393
			// (get) Token: 0x06002B93 RID: 11155 RVA: 0x000C07B7 File Offset: 0x000BE9B7
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D42 RID: 3394
			// (get) Token: 0x06002B94 RID: 11156 RVA: 0x000C07C4 File Offset: 0x000BE9C4
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x17000D43 RID: 3395
			// (get) Token: 0x06002B95 RID: 11157 RVA: 0x000C07CB File Offset: 0x000BE9CB
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D44 RID: 3396
			// (get) Token: 0x06002B96 RID: 11158 RVA: 0x000C07D2 File Offset: 0x000BE9D2
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOffice2k7Silver_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOffice2k7Silver.xaml";
				}
			}
		}
	}
}
