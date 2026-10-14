using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000374 RID: 884
	public class DataPresenterOnyx : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOnyx.Locator>
	{
		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002B52 RID: 11090 RVA: 0x000C04FD File Offset: 0x000BE6FD
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

		// Token: 0x040014FE RID: 5374
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOnyx g_Instance;

		// Token: 0x02000375 RID: 885
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D14 RID: 3348
			// (get) Token: 0x06002B54 RID: 11092 RVA: 0x000C051D File Offset: 0x000BE71D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D15 RID: 3349
			// (get) Token: 0x06002B55 RID: 11093 RVA: 0x000C052A File Offset: 0x000BE72A
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x17000D16 RID: 3350
			// (get) Token: 0x06002B56 RID: 11094 RVA: 0x000C0531 File Offset: 0x000BE731
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D17 RID: 3351
			// (get) Token: 0x06002B57 RID: 11095 RVA: 0x000C0538 File Offset: 0x000BE738
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
