using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000C8 RID: 200
	public class EditorsLunaNormal : global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsLunaNormal.Locator>
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000A4B RID: 2635 RVA: 0x0002DDE3 File Offset: 0x0002BFE3
		public static global::Infragistics.Windows.Themes.EditorsLunaNormal Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaNormal.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaNormal.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaNormal();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaNormal.g_Instance;
			}
		}

		// Token: 0x040003A9 RID: 937
		private static global::Infragistics.Windows.Themes.EditorsLunaNormal g_Instance;

		// Token: 0x020000C9 RID: 201
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000A4D RID: 2637 RVA: 0x0002DE03 File Offset: 0x0002C003
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000A4E RID: 2638 RVA: 0x0002DE10 File Offset: 0x0002C010
			public override string Theme
			{
				get
				{
					return "LunaNormal";
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000A4F RID: 2639 RVA: 0x0002DE17 File Offset: 0x0002C017
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700028E RID: 654
			// (get) Token: 0x06000A50 RID: 2640 RVA: 0x0002DE1E File Offset: 0x0002C01E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\Editors\\EditorsLunaNormal_Express.xaml;ResourceSets\\Editors\\EditorsLunaNormal.xaml";
				}
			}
		}
	}
}
