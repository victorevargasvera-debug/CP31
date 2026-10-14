using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000344 RID: 836
	public class DataPresenterOffice2k7Silver : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver.Locator>
	{
		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x060027B7 RID: 10167 RVA: 0x000ABBCF File Offset: 0x000A9DCF
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

		// Token: 0x040012E1 RID: 4833
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Silver g_Instance;

		// Token: 0x02000345 RID: 837
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BF3 RID: 3059
			// (get) Token: 0x060027B9 RID: 10169 RVA: 0x000ABBEF File Offset: 0x000A9DEF
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BF4 RID: 3060
			// (get) Token: 0x060027BA RID: 10170 RVA: 0x000ABBFC File Offset: 0x000A9DFC
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x17000BF5 RID: 3061
			// (get) Token: 0x060027BB RID: 10171 RVA: 0x000ABC03 File Offset: 0x000A9E03
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BF6 RID: 3062
			// (get) Token: 0x060027BC RID: 10172 RVA: 0x000ABC0A File Offset: 0x000A9E0A
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
