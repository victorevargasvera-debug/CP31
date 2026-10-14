using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200004D RID: 77
	public class EditorsAeroBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsAeroBrushes.Locator>
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0001710E File Offset: 0x0001530E
		public static global::Infragistics.Windows.Themes.EditorsAeroBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsAeroBrushes.g_Instance;
			}
		}

		// Token: 0x040001E2 RID: 482
		private static global::Infragistics.Windows.Themes.EditorsAeroBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsAeroBrushes();

		// Token: 0x0200004E RID: 78
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000133 RID: 307
			// (get) Token: 0x0600055A RID: 1370 RVA: 0x00017115 File Offset: 0x00015315
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000134 RID: 308
			// (get) Token: 0x0600055B RID: 1371 RVA: 0x00017122 File Offset: 0x00015322
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x0600055C RID: 1372 RVA: 0x00017129 File Offset: 0x00015329
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x0600055D RID: 1373 RVA: 0x00017130 File Offset: 0x00015330
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsAero_Brushes.xaml";
				}
			}
		}
	}
}
