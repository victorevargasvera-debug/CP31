using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200033E RID: 830
	public class DataPresenterLunaSilver : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaSilver.Locator>
	{
		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x000ABAF1 File Offset: 0x000A9CF1
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

		// Token: 0x040012DE RID: 4830
		private static global::Infragistics.Windows.Themes.DataPresenterLunaSilver g_Instance;

		// Token: 0x0200033F RID: 831
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BE4 RID: 3044
			// (get) Token: 0x060027A4 RID: 10148 RVA: 0x000ABB11 File Offset: 0x000A9D11
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BE5 RID: 3045
			// (get) Token: 0x060027A5 RID: 10149 RVA: 0x000ABB1E File Offset: 0x000A9D1E
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x17000BE6 RID: 3046
			// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000ABB25 File Offset: 0x000A9D25
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BE7 RID: 3047
			// (get) Token: 0x060027A7 RID: 10151 RVA: 0x000ABB2C File Offset: 0x000A9D2C
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
