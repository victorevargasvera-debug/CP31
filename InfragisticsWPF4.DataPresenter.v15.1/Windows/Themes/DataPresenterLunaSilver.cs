using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000380 RID: 896
	public class DataPresenterLunaSilver : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaSilver.Locator>
	{
		// Token: 0x17000D31 RID: 3377
		// (get) Token: 0x06002B7C RID: 11132 RVA: 0x000C06B9 File Offset: 0x000BE8B9
		public static global::Infragistics.Windows.Themes.DataPresenterLunaSilver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaSilver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaSilver.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaSilver();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaSilver.g_Instance;
			}
		}

		// Token: 0x04001504 RID: 5380
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterLunaSilver g_Instance;

		// Token: 0x02000381 RID: 897
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D32 RID: 3378
			// (get) Token: 0x06002B7E RID: 11134 RVA: 0x000C06D9 File Offset: 0x000BE8D9
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D33 RID: 3379
			// (get) Token: 0x06002B7F RID: 11135 RVA: 0x000C06E6 File Offset: 0x000BE8E6
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x17000D34 RID: 3380
			// (get) Token: 0x06002B80 RID: 11136 RVA: 0x000C06ED File Offset: 0x000BE8ED
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D35 RID: 3381
			// (get) Token: 0x06002B81 RID: 11137 RVA: 0x000C06F4 File Offset: 0x000BE8F4
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterLunaSilver_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterLunaSilver.xaml";
				}
			}
		}
	}
}
