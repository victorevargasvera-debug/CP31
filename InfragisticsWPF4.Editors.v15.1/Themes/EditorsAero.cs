using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000CA RID: 202
	public class EditorsAero : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsAero.Locator>
	{
		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0002FD99 File Offset: 0x0002DF99
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

		// Token: 0x040003DD RID: 989
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsAero g_Instance;

		// Token: 0x020000CB RID: 203
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000AAD RID: 2733 RVA: 0x0002FDB9 File Offset: 0x0002DFB9
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000297 RID: 663
			// (get) Token: 0x06000AAE RID: 2734 RVA: 0x0002FDC6 File Offset: 0x0002DFC6
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x17000298 RID: 664
			// (get) Token: 0x06000AAF RID: 2735 RVA: 0x0002FDCD File Offset: 0x0002DFCD
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000299 RID: 665
			// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x0002FDD4 File Offset: 0x0002DFD4
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
