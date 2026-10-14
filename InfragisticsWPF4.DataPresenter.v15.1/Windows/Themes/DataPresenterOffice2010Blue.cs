using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000388 RID: 904
	public class DataPresenterOffice2010Blue : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.Locator>
	{
		// Token: 0x17000D45 RID: 3397
		// (get) Token: 0x06002B98 RID: 11160 RVA: 0x000C07E1 File Offset: 0x000BE9E1
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue.g_Instance;
			}
		}

		// Token: 0x04001508 RID: 5384
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2010Blue g_Instance;

		// Token: 0x02000389 RID: 905
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D46 RID: 3398
			// (get) Token: 0x06002B9A RID: 11162 RVA: 0x000C0801 File Offset: 0x000BEA01
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D47 RID: 3399
			// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000C080E File Offset: 0x000BEA0E
			public override string Theme
			{
				get
				{
					return "Office2010Blue";
				}
			}

			// Token: 0x17000D48 RID: 3400
			// (get) Token: 0x06002B9C RID: 11164 RVA: 0x000C0815 File Offset: 0x000BEA15
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D49 RID: 3401
			// (get) Token: 0x06002B9D RID: 11165 RVA: 0x000C081C File Offset: 0x000BEA1C
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOffice2010Blue_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOffice2010Blue.xaml";
				}
			}
		}
	}
}
