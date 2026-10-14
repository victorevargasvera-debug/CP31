using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200038A RID: 906
	public class DataPresenterOffice2013 : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterOffice2013.Locator>
	{
		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002B9F RID: 11167 RVA: 0x000C082B File Offset: 0x000BEA2B
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2013 Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2013.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2013.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2013();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2013.g_Instance;
			}
		}

		// Token: 0x04001509 RID: 5385
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2013 g_Instance;

		// Token: 0x0200038B RID: 907
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D4B RID: 3403
			// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x000C084B File Offset: 0x000BEA4B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D4C RID: 3404
			// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x000C0858 File Offset: 0x000BEA58
			public override string Theme
			{
				get
				{
					return "Office2013";
				}
			}

			// Token: 0x17000D4D RID: 3405
			// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x000C085F File Offset: 0x000BEA5F
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D4E RID: 3406
			// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x000C0866 File Offset: 0x000BEA66
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterOffice2013_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterOffice2013.xaml";
				}
			}
		}
	}
}
