using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C0 RID: 192
	public class EditorsOnyx : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOnyx.Locator>
	{
		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0002DCBB File Offset: 0x0002BEBB
		public static global::Infragistics.Windows.Themes.EditorsOnyx Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsOnyx.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsOnyx.g_Instance = new global::Infragistics.Windows.Themes.EditorsOnyx();
				}
				return global::Infragistics.Windows.Themes.EditorsOnyx.g_Instance;
			}
		}

		// Token: 0x040003A5 RID: 933
		private static global::Infragistics.Windows.Themes.EditorsOnyx g_Instance;

		// Token: 0x020000C1 RID: 193
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000277 RID: 631
			// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0002DCDB File Offset: 0x0002BEDB
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000278 RID: 632
			// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0002DCE8 File Offset: 0x0002BEE8
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x17000279 RID: 633
			// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0002DCEF File Offset: 0x0002BEEF
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700027A RID: 634
			// (get) Token: 0x06000A34 RID: 2612 RVA: 0x0002DCF6 File Offset: 0x0002BEF6
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsOnyx_Express.xaml;ResourceSets\\Editors\\EditorsOnyx.xaml";
				}
			}
		}
	}
}
