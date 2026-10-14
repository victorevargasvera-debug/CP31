using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200038C RID: 908
	public class DataPresenterWashBaseDark : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.Locator>
	{
		// Token: 0x17000D4F RID: 3407
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x000C0875 File Offset: 0x000BEA75
		public static global::Infragistics.Windows.Themes.DataPresenterWashBaseDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterWashBaseDark();
				}
				return global::Infragistics.Windows.Themes.DataPresenterWashBaseDark.g_Instance;
			}
		}

		// Token: 0x0400150A RID: 5386
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterWashBaseDark g_Instance;

		// Token: 0x0200038D RID: 909
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D50 RID: 3408
			// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x000C0895 File Offset: 0x000BEA95
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D51 RID: 3409
			// (get) Token: 0x06002BA9 RID: 11177 RVA: 0x000C08A2 File Offset: 0x000BEAA2
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x17000D52 RID: 3410
			// (get) Token: 0x06002BAA RID: 11178 RVA: 0x000C08A9 File Offset: 0x000BEAA9
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D53 RID: 3411
			// (get) Token: 0x06002BAB RID: 11179 RVA: 0x000C08B0 File Offset: 0x000BEAB0
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterWashBaseDark.xaml";
				}
			}
		}
	}
}
