using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000336 RID: 822
	public class DataPresenterRoyale : global::Infragistics.Windows.Themes.DataPresenterResourceSet<global::Infragistics.Windows.Themes.DataPresenterRoyale.Locator>
	{
		// Token: 0x17000BCF RID: 3023
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x000AB9C9 File Offset: 0x000A9BC9
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

		// Token: 0x040012DA RID: 4826
		private static global::Infragistics.Windows.Themes.DataPresenterRoyale g_Instance;

		// Token: 0x02000337 RID: 823
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x06002788 RID: 10120 RVA: 0x000AB9E9 File Offset: 0x000A9BE9
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x06002789 RID: 10121 RVA: 0x000AB9F6 File Offset: 0x000A9BF6
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x0600278A RID: 10122 RVA: 0x000AB9FD File Offset: 0x000A9BFD
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000BD3 RID: 3027
			// (get) Token: 0x0600278B RID: 10123 RVA: 0x000ABA04 File Offset: 0x000A9C04
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
