using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C8 RID: 200
	public class EditorsOnyx : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsOnyx.Locator>
	{
		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0002FD4F File Offset: 0x0002DF4F
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

		// Token: 0x040003DC RID: 988
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsOnyx g_Instance;

		// Token: 0x020000C9 RID: 201
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000291 RID: 657
			// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x0002FD6F File Offset: 0x0002DF6F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000292 RID: 658
			// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0002FD7C File Offset: 0x0002DF7C
			public override string Theme
			{
				get
				{
					return "Onyx";
				}
			}

			// Token: 0x17000293 RID: 659
			// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0002FD83 File Offset: 0x0002DF83
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000294 RID: 660
			// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0002FD8A File Offset: 0x0002DF8A
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
