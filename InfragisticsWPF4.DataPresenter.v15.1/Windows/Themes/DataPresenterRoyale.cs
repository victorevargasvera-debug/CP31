using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000378 RID: 888
	public class DataPresenterRoyale : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterRoyale.Locator>
	{
		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002B60 RID: 11104 RVA: 0x000C0591 File Offset: 0x000BE791
		public static global::Infragistics.Windows.Themes.DataPresenterRoyale Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterRoyale.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterRoyale.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterRoyale();
				}
				return global::Infragistics.Windows.Themes.DataPresenterRoyale.g_Instance;
			}
		}

		// Token: 0x04001500 RID: 5376
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterRoyale g_Instance;

		// Token: 0x02000379 RID: 889
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000D1E RID: 3358
			// (get) Token: 0x06002B62 RID: 11106 RVA: 0x000C05B1 File Offset: 0x000BE7B1
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000D1F RID: 3359
			// (get) Token: 0x06002B63 RID: 11107 RVA: 0x000C05BE File Offset: 0x000BE7BE
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x17000D20 RID: 3360
			// (get) Token: 0x06002B64 RID: 11108 RVA: 0x000C05C5 File Offset: 0x000BE7C5
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x06002B65 RID: 11109 RVA: 0x000C05CC File Offset: 0x000BE7CC
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterRoyale_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterRoyale.xaml";
				}
			}
		}
	}
}
