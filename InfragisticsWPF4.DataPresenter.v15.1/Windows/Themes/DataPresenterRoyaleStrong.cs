using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200037A RID: 890
	public class DataPresenterRoyaleStrong : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong.Locator>
	{
		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002B67 RID: 11111 RVA: 0x000C05DB File Offset: 0x000BE7DB
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

		// Token: 0x04001501 RID: 5377
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterRoyaleStrong g_Instance;

		// Token: 0x0200037B RID: 891
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x06002B69 RID: 11113 RVA: 0x000C05FB File Offset: 0x000BE7FB
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D24 RID: 3364
			// (get) Token: 0x06002B6A RID: 11114 RVA: 0x000C0608 File Offset: 0x000BE808
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x17000D25 RID: 3365
			// (get) Token: 0x06002B6B RID: 11115 RVA: 0x000C060F File Offset: 0x000BE80F
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D26 RID: 3366
			// (get) Token: 0x06002B6C RID: 11116 RVA: 0x000C0616 File Offset: 0x000BE816
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
