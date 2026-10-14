using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000332 RID: 818
	public class DataPresenterOnyx : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOnyx.Locator>
	{
		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000AB935 File Offset: 0x000A9B35
		public static global::Infragistics.Windows.Themes.DataPresenterOnyx Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOnyx.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOnyx.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOnyx();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOnyx.g_Instance;
			}
		}

		// Token: 0x040012D8 RID: 4824
		private static global::Infragistics.Windows.Themes.DataPresenterOnyx g_Instance;

		// Token: 0x02000333 RID: 819
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BC6 RID: 3014
			// (get) Token: 0x0600277A RID: 10106 RVA: 0x000AB955 File Offset: 0x000A9B55
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BC7 RID: 3015
			// (get) Token: 0x0600277B RID: 10107 RVA: 0x000AB962 File Offset: 0x000A9B62
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x17000BC8 RID: 3016
			// (get) Token: 0x0600277C RID: 10108 RVA: 0x000AB969 File Offset: 0x000A9B69
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BC9 RID: 3017
			// (get) Token: 0x0600277D RID: 10109 RVA: 0x000AB970 File Offset: 0x000A9B70
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOnyx_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOnyx.xaml";
				}
			}
		}
	}
}
