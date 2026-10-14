using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000051 RID: 81
	public class EditorsOffice2k7BlueBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes.Locator>
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000569 RID: 1385 RVA: 0x00017198 File Offset: 0x00015398
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes.g_Instance;
			}
		}

		// Token: 0x040001E4 RID: 484
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7BlueBrushes();

		// Token: 0x02000052 RID: 82
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700013D RID: 317
			// (get) Token: 0x0600056A RID: 1386 RVA: 0x0001719F File Offset: 0x0001539F
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x0600056B RID: 1387 RVA: 0x000171AC File Offset: 0x000153AC
			public override string Theme
			{
				get
				{
					return "Office2k7Blue";
				}
			}

			// Token: 0x1700013F RID: 319
			// (get) Token: 0x0600056C RID: 1388 RVA: 0x000171B3 File Offset: 0x000153B3
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000140 RID: 320
			// (get) Token: 0x0600056D RID: 1389 RVA: 0x000171BA File Offset: 0x000153BA
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsOffice2k7Blue_Brushes.xaml";
				}
			}
		}
	}
}
