using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000372 RID: 882
	public class DataPresenterGeneric : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>
	{
		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06002B4B RID: 11083 RVA: 0x000C04B3 File Offset: 0x000BE6B3
		public static global::Infragistics.Windows.Themes.DataPresenterGeneric Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterGeneric.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterGeneric.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterGeneric();
				}
				return global::Infragistics.Windows.Themes.DataPresenterGeneric.g_Instance;
			}
		}

		// Token: 0x040014FD RID: 5373
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterGeneric g_Instance;

		// Token: 0x02000373 RID: 883
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x06002B4D RID: 11085 RVA: 0x000C04D3 File Offset: 0x000BE6D3
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x06002B4E RID: 11086 RVA: 0x000C04E0 File Offset: 0x000BE6E0
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x17000D11 RID: 3345
			// (get) Token: 0x06002B4F RID: 11087 RVA: 0x000C04E7 File Offset: 0x000BE6E7
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D12 RID: 3346
			// (get) Token: 0x06002B50 RID: 11088 RVA: 0x000C04EE File Offset: 0x000BE6EE
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterGeneric_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterGeneric.xaml";
				}
			}
		}
	}
}
