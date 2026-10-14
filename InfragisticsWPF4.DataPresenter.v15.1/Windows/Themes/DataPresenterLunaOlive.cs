using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200037E RID: 894
	public class DataPresenterLunaOlive : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaOlive.Locator>
	{
		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002B75 RID: 11125 RVA: 0x000C066F File Offset: 0x000BE86F
		public static global::Infragistics.Windows.Themes.DataPresenterLunaOlive Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaOlive.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaOlive.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaOlive();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaOlive.g_Instance;
			}
		}

		// Token: 0x04001503 RID: 5379
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterLunaOlive g_Instance;

		// Token: 0x0200037F RID: 895
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D2D RID: 3373
			// (get) Token: 0x06002B77 RID: 11127 RVA: 0x000C068F File Offset: 0x000BE88F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D2E RID: 3374
			// (get) Token: 0x06002B78 RID: 11128 RVA: 0x000C069C File Offset: 0x000BE89C
			public override string Theme
			{
				get
				{
					return "LunaOlive";
				}
			}

			// Token: 0x17000D2F RID: 3375
			// (get) Token: 0x06002B79 RID: 11129 RVA: 0x000C06A3 File Offset: 0x000BE8A3
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D30 RID: 3376
			// (get) Token: 0x06002B7A RID: 11130 RVA: 0x000C06AA File Offset: 0x000BE8AA
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterLunaOlive_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterLunaOlive.xaml";
				}
			}
		}
	}
}
