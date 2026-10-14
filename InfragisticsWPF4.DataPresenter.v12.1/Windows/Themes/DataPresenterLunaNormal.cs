using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200033A RID: 826
	public class DataPresenterLunaNormal : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterLunaNormal.Locator>
	{
		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x000ABA5D File Offset: 0x000A9C5D
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

		// Token: 0x040012DC RID: 4828
		private static global::Infragistics.Windows.Themes.DataPresenterLunaNormal g_Instance;

		// Token: 0x0200033B RID: 827
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BDA RID: 3034
			// (get) Token: 0x06002796 RID: 10134 RVA: 0x000ABA7D File Offset: 0x000A9C7D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BDB RID: 3035
			// (get) Token: 0x06002797 RID: 10135 RVA: 0x000ABA8A File Offset: 0x000A9C8A
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x17000BDC RID: 3036
			// (get) Token: 0x06002798 RID: 10136 RVA: 0x000ABA91 File Offset: 0x000A9C91
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BDD RID: 3037
			// (get) Token: 0x06002799 RID: 10137 RVA: 0x000ABA98 File Offset: 0x000A9C98
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
