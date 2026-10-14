using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C6 RID: 198
	public class EditorsRoyaleStrong : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsRoyaleStrong.Locator>
	{
		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0002DD99 File Offset: 0x0002BF99
		public static global::Infragistics.Windows.Themes.EditorsRoyaleStrong Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsRoyaleStrong.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsRoyaleStrong.g_Instance = new global::Infragistics.Windows.Themes.EditorsRoyaleStrong();
				}
				return global::Infragistics.Windows.Themes.EditorsRoyaleStrong.g_Instance;
			}
		}

		// Token: 0x040003A8 RID: 936
		private static global::Infragistics.Windows.Themes.EditorsRoyaleStrong g_Instance;

		// Token: 0x020000C7 RID: 199
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0002DDB9 File Offset: 0x0002BFB9
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000A47 RID: 2631 RVA: 0x0002DDC6 File Offset: 0x0002BFC6
			public override string Theme
			{
				get
				{
					return "RoyaleStrong";
				}
			}

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000A48 RID: 2632 RVA: 0x0002DDCD File Offset: 0x0002BFCD
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000A49 RID: 2633 RVA: 0x0002DDD4 File Offset: 0x0002BFD4
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsRoyaleStrong_Express.xaml;ResourceSets\\Editors\\EditorsRoyaleStrong.xaml";
				}
			}
		}
	}
}
