using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000384 RID: 900
	public class DataPresenterOffice2k7Black : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.Locator>
	{
		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002B8A RID: 11146 RVA: 0x000C074D File Offset: 0x000BE94D
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black.g_Instance;
			}
		}

		// Token: 0x04001506 RID: 5382
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Black g_Instance;

		// Token: 0x02000385 RID: 901
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D3C RID: 3388
			// (get) Token: 0x06002B8C RID: 11148 RVA: 0x000C076D File Offset: 0x000BE96D
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D3D RID: 3389
			// (get) Token: 0x06002B8D RID: 11149 RVA: 0x000C077A File Offset: 0x000BE97A
			public override string Theme
			{
				get
				{
					return "Office2k7Black";
				}
			}

			// Token: 0x17000D3E RID: 3390
			// (get) Token: 0x06002B8E RID: 11150 RVA: 0x000C0781 File Offset: 0x000BE981
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D3F RID: 3391
			// (get) Token: 0x06002B8F RID: 11151 RVA: 0x000C0788 File Offset: 0x000BE988
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOffice2k7Black_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOffice2k7Black.xaml";
				}
			}
		}
	}
}
