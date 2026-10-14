using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200034C RID: 844
	public class DataPresenterPrintBasic : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterPrintBasic.Locator>
	{
		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x000ABCF7 File Offset: 0x000A9EF7
		public static global::Infragistics.Windows.Themes.DataPresenterPrintBasic Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterPrintBasic.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterPrintBasic.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterPrintBasic();
				}
				return global::Infragistics.Windows.Themes.DataPresenterPrintBasic.g_Instance;
			}
		}

		// Token: 0x040012E5 RID: 4837
		private static global::Infragistics.Windows.Themes.DataPresenterPrintBasic g_Instance;

		// Token: 0x0200034D RID: 845
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000C07 RID: 3079
			// (get) Token: 0x060027D5 RID: 10197 RVA: 0x000ABD17 File Offset: 0x000A9F17
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000C08 RID: 3080
			// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000ABD24 File Offset: 0x000A9F24
			public override string Theme
			{
				get
				{
					return "Print Basic";
				}
			}

			// Token: 0x17000C09 RID: 3081
			// (get) Token: 0x060027D7 RID: 10199 RVA: 0x000ABD2B File Offset: 0x000A9F2B
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000C0A RID: 3082
			// (get) Token: 0x060027D8 RID: 10200 RVA: 0x000ABD32 File Offset: 0x000A9F32
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterPrintBasic.xaml";
				}
			}
		}
	}
}
