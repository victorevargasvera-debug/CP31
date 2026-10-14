using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C6 RID: 198
	public class EditorsGeneric : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsGeneric.Locator>
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000A9D RID: 2717 RVA: 0x0002FD05 File Offset: 0x0002DF05
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

		// Token: 0x040003DB RID: 987
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsGeneric g_Instance;

		// Token: 0x020000C7 RID: 199
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000A9F RID: 2719 RVA: 0x0002FD25 File Offset: 0x0002DF25
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0002FD32 File Offset: 0x0002DF32
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000AA1 RID: 2721 RVA: 0x0002FD39 File Offset: 0x0002DF39
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700028F RID: 655
			// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0002FD40 File Offset: 0x0002DF40
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
