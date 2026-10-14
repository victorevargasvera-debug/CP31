using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000382 RID: 898
	public class DataPresenterOffice2k7Blue : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue.Locator>
	{
		// Token: 0x17000D36 RID: 3382
		// (get) Token: 0x06002B83 RID: 11139 RVA: 0x000C0703 File Offset: 0x000BE903
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

		// Token: 0x04001505 RID: 5381
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2k7Blue g_Instance;

		// Token: 0x02000383 RID: 899
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D37 RID: 3383
			// (get) Token: 0x06002B85 RID: 11141 RVA: 0x000C0723 File Offset: 0x000BE923
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D38 RID: 3384
			// (get) Token: 0x06002B86 RID: 11142 RVA: 0x000C0730 File Offset: 0x000BE930
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x17000D39 RID: 3385
			// (get) Token: 0x06002B87 RID: 11143 RVA: 0x000C0737 File Offset: 0x000BE937
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D3A RID: 3386
			// (get) Token: 0x06002B88 RID: 11144 RVA: 0x000C073E File Offset: 0x000BE93E
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
