using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000394 RID: 916
	public class DataPresenterMetro : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterMetro.Locator>
	{
		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000C099D File Offset: 0x000BEB9D
		public static global::Infragistics.Windows.Themes.DataPresenterMetro Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterMetro.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterMetro.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterMetro();
				}
				return global::Infragistics.Windows.Themes.DataPresenterMetro.g_Instance;
			}
		}

		// Token: 0x0400150E RID: 5390
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterMetro g_Instance;

		// Token: 0x02000395 RID: 917
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D64 RID: 3428
			// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x000C09BD File Offset: 0x000BEBBD
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x06002BC5 RID: 11205 RVA: 0x000C09CA File Offset: 0x000BEBCA
			public override string Theme
			{
				get
				{
					return "Metro";
				}
			}

			// Token: 0x17000D66 RID: 3430
			// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x000C09D1 File Offset: 0x000BEBD1
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D67 RID: 3431
			// (get) Token: 0x06002BC7 RID: 11207 RVA: 0x000C09D8 File Offset: 0x000BEBD8
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterMetro.xaml";
				}
			}
		}
	}
}
