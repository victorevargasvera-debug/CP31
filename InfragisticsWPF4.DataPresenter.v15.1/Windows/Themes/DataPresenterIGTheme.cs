using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000392 RID: 914
	public class DataPresenterIGTheme : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterIGTheme.Locator>
	{
		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002BBB RID: 11195 RVA: 0x000C0953 File Offset: 0x000BEB53
		public static global::Infragistics.Windows.Themes.DataPresenterIGTheme Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterIGTheme.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterIGTheme.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterIGTheme();
				}
				return global::Infragistics.Windows.Themes.DataPresenterIGTheme.g_Instance;
			}
		}

		// Token: 0x0400150D RID: 5389
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterIGTheme g_Instance;

		// Token: 0x02000393 RID: 915
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D5F RID: 3423
			// (get) Token: 0x06002BBD RID: 11197 RVA: 0x000C0973 File Offset: 0x000BEB73
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D60 RID: 3424
			// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000C0980 File Offset: 0x000BEB80
			public override string Theme
			{
				get
				{
					return "IGTheme";
				}
			}

			// Token: 0x17000D61 RID: 3425
			// (get) Token: 0x06002BBF RID: 11199 RVA: 0x000C0987 File Offset: 0x000BEB87
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D62 RID: 3426
			// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x000C098E File Offset: 0x000BEB8E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterIGTheme_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterIGTheme.xaml";
				}
			}
		}
	}
}
