using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000050 RID: 80
	public class EditorsAeroBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsAeroBrushes.Locator>
	{
		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x00017E1B File Offset: 0x0001601B
		public static global::Infragistics.Windows.Themes.EditorsAeroBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsAeroBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsAeroBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsAeroBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsAeroBrushes.g_Instance;
			}
		}

		// Token: 0x040001FD RID: 509
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsAeroBrushes g_Instance;

		// Token: 0x02000051 RID: 81
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000581 RID: 1409 RVA: 0x00017E33 File Offset: 0x00016033
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000582 RID: 1410 RVA: 0x00017E40 File Offset: 0x00016040
			public override string Theme
			{
				get
				{
					return "Aero";
				}
			}

			// Token: 0x17000139 RID: 313
			// (get) Token: 0x06000583 RID: 1411 RVA: 0x00017E47 File Offset: 0x00016047
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000584 RID: 1412 RVA: 0x00017E4E File Offset: 0x0001604E
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
