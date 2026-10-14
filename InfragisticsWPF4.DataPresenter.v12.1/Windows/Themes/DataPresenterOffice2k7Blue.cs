using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000340 RID: 832
	public class DataPresenterOffice2k7Blue : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue.Locator>
	{
		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x060027A9 RID: 10153 RVA: 0x000ABB3B File Offset: 0x000A9D3B
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue.g_Instance;
			}
		}

		// Token: 0x040012DF RID: 4831
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue g_Instance;

		// Token: 0x02000341 RID: 833
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BE9 RID: 3049
			// (get) Token: 0x060027AB RID: 10155 RVA: 0x000ABB5B File Offset: 0x000A9D5B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BEA RID: 3050
			// (get) Token: 0x060027AC RID: 10156 RVA: 0x000ABB68 File Offset: 0x000A9D68
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x17000BEB RID: 3051
			// (get) Token: 0x060027AD RID: 10157 RVA: 0x000ABB6F File Offset: 0x000A9D6F
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BEC RID: 3052
			// (get) Token: 0x060027AE RID: 10158 RVA: 0x000ABB76 File Offset: 0x000A9D76
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOffice2k7Blue_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOffice2k7Blue.xaml";
				}
			}
		}
	}
}
