using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000334 RID: 820
	public class DataPresenterAero : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterAero.Locator>
	{
		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600277F RID: 10111 RVA: 0x000AB97F File Offset: 0x000A9B7F
		public static global::Infragistics.Windows.Themes.DataPresenterAero Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterAero.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterAero.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterAero();
				}
				return global::Infragistics.Windows.Themes.DataPresenterAero.g_Instance;
			}
		}

		// Token: 0x040012D9 RID: 4825
		private static global::Infragistics.Windows.Themes.DataPresenterAero g_Instance;

		// Token: 0x02000335 RID: 821
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BCB RID: 3019
			// (get) Token: 0x06002781 RID: 10113 RVA: 0x000AB99F File Offset: 0x000A9B9F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BCC RID: 3020
			// (get) Token: 0x06002782 RID: 10114 RVA: 0x000AB9AC File Offset: 0x000A9BAC
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x06002783 RID: 10115 RVA: 0x000AB9B3 File Offset: 0x000A9BB3
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BCE RID: 3022
			// (get) Token: 0x06002784 RID: 10116 RVA: 0x000AB9BA File Offset: 0x000A9BBA
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenter\\DataPresenterAero_Express.xaml;ResourceSets\\DataPresenter\\DataPresenterAero.xaml";
				}
			}
		}
	}
}
