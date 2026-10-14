using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200004E RID: 78
	public class EditorsLunaSilverBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes.Locator>
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x00017DCF File Offset: 0x00015FCF
		public static global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes.g_Instance;
			}
		}

		// Token: 0x040001FC RID: 508
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes g_Instance;

		// Token: 0x0200004F RID: 79
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000579 RID: 1401 RVA: 0x00017DE7 File Offset: 0x00015FE7
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x0600057A RID: 1402 RVA: 0x00017DF4 File Offset: 0x00015FF4
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x0600057B RID: 1403 RVA: 0x00017DFB File Offset: 0x00015FFB
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x0600057C RID: 1404 RVA: 0x00017E02 File Offset: 0x00016002
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsLunaSilver_Brushes.xaml";
				}
			}
		}
	}
}
