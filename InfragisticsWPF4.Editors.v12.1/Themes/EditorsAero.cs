using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C2 RID: 194
	public class EditorsAero : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsAero.Locator>
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000A36 RID: 2614 RVA: 0x0002DD05 File Offset: 0x0002BF05
		public static global::Infragistics.Windows.Themes.EditorsAero Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsAero.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsAero.g_Instance = new global::Infragistics.Windows.Themes.EditorsAero();
				}
				return global::Infragistics.Windows.Themes.EditorsAero.g_Instance;
			}
		}

		// Token: 0x040003A6 RID: 934
		private static global::Infragistics.Windows.Themes.EditorsAero g_Instance;

		// Token: 0x020000C3 RID: 195
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700027C RID: 636
			// (get) Token: 0x06000A38 RID: 2616 RVA: 0x0002DD25 File Offset: 0x0002BF25
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700027D RID: 637
			// (get) Token: 0x06000A39 RID: 2617 RVA: 0x0002DD32 File Offset: 0x0002BF32
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x1700027E RID: 638
			// (get) Token: 0x06000A3A RID: 2618 RVA: 0x0002DD39 File Offset: 0x0002BF39
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700027F RID: 639
			// (get) Token: 0x06000A3B RID: 2619 RVA: 0x0002DD40 File Offset: 0x0002BF40
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsAero_Express.xaml;ResourceSets\\Editors\\EditorsAero.xaml";
				}
			}
		}
	}
}
