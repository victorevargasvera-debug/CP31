using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C4 RID: 196
	public class EditorsRoyale : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsRoyale.Locator>
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000A3D RID: 2621 RVA: 0x0002DD4F File Offset: 0x0002BF4F
		public static global::Infragistics.Windows.Themes.EditorsRoyale Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsRoyale.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsRoyale.g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyale();
				}
				return global::Infragistics.Windows.Themes.EditorsRoyale.g_Instance;
			}
		}

		// Token: 0x040003A7 RID: 935
		private static global::Infragistics.Windows.Themes.EditorsRoyale g_Instance;

		// Token: 0x020000C5 RID: 197
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000281 RID: 641
			// (get) Token: 0x06000A3F RID: 2623 RVA: 0x0002DD6F File Offset: 0x0002BF6F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000282 RID: 642
			// (get) Token: 0x06000A40 RID: 2624 RVA: 0x0002DD7C File Offset: 0x0002BF7C
			public override string Theme
			{
				get
				{
					return "Royale";
				}
			}

			// Token: 0x17000283 RID: 643
			// (get) Token: 0x06000A41 RID: 2625 RVA: 0x0002DD83 File Offset: 0x0002BF83
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000284 RID: 644
			// (get) Token: 0x06000A42 RID: 2626 RVA: 0x0002DD8A File Offset: 0x0002BF8A
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsRoyale_Express.xaml;ResourceSets\\Editors\\EditorsRoyale.xaml";
				}
			}
		}
	}
}
