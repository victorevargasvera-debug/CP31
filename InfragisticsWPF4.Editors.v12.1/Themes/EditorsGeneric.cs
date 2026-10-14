using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000BE RID: 190
	public class EditorsGeneric : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsGeneric.Locator>
	{
		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0002DC71 File Offset: 0x0002BE71
		public static global::Infragistics.Windows.Themes.EditorsGeneric Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsGeneric.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsGeneric.g_Instance = new global::Infragistics.Windows.Themes.EditorsGeneric();
				}
				return global::Infragistics.Windows.Themes.EditorsGeneric.g_Instance;
			}
		}

		// Token: 0x040003A4 RID: 932
		private static global::Infragistics.Windows.Themes.EditorsGeneric g_Instance;

		// Token: 0x020000BF RID: 191
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000272 RID: 626
			// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0002DC91 File Offset: 0x0002BE91
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000273 RID: 627
			// (get) Token: 0x06000A2B RID: 2603 RVA: 0x0002DC9E File Offset: 0x0002BE9E
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x17000274 RID: 628
			// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0002DCA5 File Offset: 0x0002BEA5
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000275 RID: 629
			// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0002DCAC File Offset: 0x0002BEAC
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsGeneric_Express.xaml;ResourceSets\\Editors\\EditorsGeneric.xaml";
				}
			}
		}
	}
}
