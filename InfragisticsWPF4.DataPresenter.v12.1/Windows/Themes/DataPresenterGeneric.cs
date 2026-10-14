using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000330 RID: 816
	public class DataPresenterGeneric : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterGeneric.Locator>
	{
		// Token: 0x17000BC0 RID: 3008
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000AB8EB File Offset: 0x000A9AEB
		public static global::Infragistics.Windows.Themes.DataPresenterGeneric Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterGeneric.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterGeneric.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterGeneric();
				}
				return global::Infragistics.Windows.Themes.DataPresenterGeneric.g_Instance;
			}
		}

		// Token: 0x040012D7 RID: 4823
		private static global::Infragistics.Windows.Themes.DataPresenterGeneric g_Instance;

		// Token: 0x02000331 RID: 817
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BC1 RID: 3009
			// (get) Token: 0x06002773 RID: 10099 RVA: 0x000AB90B File Offset: 0x000A9B0B
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BC2 RID: 3010
			// (get) Token: 0x06002774 RID: 10100 RVA: 0x000AB918 File Offset: 0x000A9B18
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x17000BC3 RID: 3011
			// (get) Token: 0x06002775 RID: 10101 RVA: 0x000AB91F File Offset: 0x000A9B1F
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BC4 RID: 3012
			// (get) Token: 0x06002776 RID: 10102 RVA: 0x000AB926 File Offset: 0x000A9B26
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterGeneric_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterGeneric.xaml";
				}
			}
		}
	}
}
