using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CC RID: 204
	public class EditorsLunaSilver : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaSilver.Locator>
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x0002DE77 File Offset: 0x0002C077
		public static global::Infragistics.Windows.Themes.EditorsLunaSilver Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaSilver.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaSilver.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaSilver();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaSilver.g_Instance;
			}
		}

		// Token: 0x040003AB RID: 939
		private static global::Infragistics.Windows.Themes.EditorsLunaSilver g_Instance;

		// Token: 0x020000CD RID: 205
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000295 RID: 661
			// (get) Token: 0x06000A5B RID: 2651 RVA: 0x0002DE97 File Offset: 0x0002C097
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000A5C RID: 2652 RVA: 0x0002DEA4 File Offset: 0x0002C0A4
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000A5D RID: 2653 RVA: 0x0002DEAB File Offset: 0x0002C0AB
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000A5E RID: 2654 RVA: 0x0002DEB2 File Offset: 0x0002C0B2
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsLunaSilver_Express.xaml;ResourceSets\\Editors\\EditorsLunaSilver.xaml";
				}
			}
		}
	}
}
