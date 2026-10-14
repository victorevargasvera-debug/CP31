using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200037C RID: 892
	public class DataPresenterLunaNormal : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaNormal.Locator>
	{
		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000C0625 File Offset: 0x000BE825
		public static global::Infragistics.Windows.Themes.DataPresenterLunaNormal Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterLunaNormal.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterLunaNormal.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterLunaNormal();
				}
				return global::Infragistics.Windows.Themes.DataPresenterLunaNormal.g_Instance;
			}
		}

		// Token: 0x04001502 RID: 5378
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterLunaNormal g_Instance;

		// Token: 0x0200037D RID: 893
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D28 RID: 3368
			// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000C0645 File Offset: 0x000BE845
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D29 RID: 3369
			// (get) Token: 0x06002B71 RID: 11121 RVA: 0x000C0652 File Offset: 0x000BE852
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x17000D2A RID: 3370
			// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000C0659 File Offset: 0x000BE859
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D2B RID: 3371
			// (get) Token: 0x06002B73 RID: 11123 RVA: 0x000C0660 File Offset: 0x000BE860
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterLunaNormal_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterLunaNormal.xaml";
				}
			}
		}
	}
}
