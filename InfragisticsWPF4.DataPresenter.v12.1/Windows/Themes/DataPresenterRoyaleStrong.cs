using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000338 RID: 824
	public class DataPresenterRoyaleStrong : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong.Locator>
	{
		// Token: 0x17000BD4 RID: 3028
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000ABA13 File Offset: 0x000A9C13
		public static global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong();
				}
				return global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong.g_Instance;
			}
		}

		// Token: 0x040012DB RID: 4827
		private static global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong g_Instance;

		// Token: 0x02000339 RID: 825
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BD5 RID: 3029
			// (get) Token: 0x0600278F RID: 10127 RVA: 0x000ABA33 File Offset: 0x000A9C33
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BD6 RID: 3030
			// (get) Token: 0x06002790 RID: 10128 RVA: 0x000ABA40 File Offset: 0x000A9C40
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x17000BD7 RID: 3031
			// (get) Token: 0x06002791 RID: 10129 RVA: 0x000ABA47 File Offset: 0x000A9C47
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BD8 RID: 3032
			// (get) Token: 0x06002792 RID: 10130 RVA: 0x000ABA4E File Offset: 0x000A9C4E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterRoyaleStrong_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterRoyaleStrong.xaml";
				}
			}
		}
	}
}
