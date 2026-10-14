using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000396 RID: 918
	public class DataPresenterMetroDark : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterMetroDark.Locator>
	{
		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002BC9 RID: 11209 RVA: 0x000C09E7 File Offset: 0x000BEBE7
		public static global::Infragistics.Windows.Themes.DataPresenterMetroDark Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterMetroDark.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterMetroDark.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterMetroDark();
				}
				return global::Infragistics.Windows.Themes.DataPresenterMetroDark.g_Instance;
			}
		}

		// Token: 0x0400150F RID: 5391
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterMetroDark g_Instance;

		// Token: 0x02000397 RID: 919
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D69 RID: 3433
			// (get) Token: 0x06002BCB RID: 11211 RVA: 0x000C0A07 File Offset: 0x000BEC07
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D6A RID: 3434
			// (get) Token: 0x06002BCC RID: 11212 RVA: 0x000C0A14 File Offset: 0x000BEC14
			public override string Theme
			{
				get
				{
					return "MetroDark";
				}
			}

			// Token: 0x17000D6B RID: 3435
			// (get) Token: 0x06002BCD RID: 11213 RVA: 0x000C0A1B File Offset: 0x000BEC1B
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D6C RID: 3436
			// (get) Token: 0x06002BCE RID: 11214 RVA: 0x000C0A22 File Offset: 0x000BEC22
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterMetroDark.xaml";
				}
			}
		}
	}
}
