using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000390 RID: 912
	public class DataPresenterPrintBasic : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterPrintBasic.Locator>
	{
		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x000C0909 File Offset: 0x000BEB09
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

		// Token: 0x0400150C RID: 5388
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterPrintBasic g_Instance;

		// Token: 0x02000391 RID: 913
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D5A RID: 3418
			// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x000C0929 File Offset: 0x000BEB29
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D5B RID: 3419
			// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x000C0936 File Offset: 0x000BEB36
			public override string Theme
			{
				get
				{
					return "Print Basic";
				}
			}

			// Token: 0x17000D5C RID: 3420
			// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000C093D File Offset: 0x000BEB3D
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D5D RID: 3421
			// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x000C0944 File Offset: 0x000BEB44
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
