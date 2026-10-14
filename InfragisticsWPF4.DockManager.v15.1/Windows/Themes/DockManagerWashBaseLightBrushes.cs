using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020000AA RID: 170
	public class DockManagerWashBaseLightBrushes : global::Infragistics.Windows.Themes.DockManagerBrushes<global::Infragistics.Windows.Themes.DockManagerWashBaseLightBrushes.Locator>
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005E9 RID: 1513 RVA: 0x0001DB1C File Offset: 0x0001BD1C
		public static global::Infragistics.Windows.Themes.DockManagerWashBaseLightBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerWashBaseLightBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DockManagerWashBaseLightBrushes.g_Instance = new global::Infragistics.Windows.Themes.DockManagerWashBaseLightBrushes();
				}
				return global::Infragistics.Windows.Themes.DockManagerWashBaseLightBrushes.g_Instance;
			}
		}

		// Token: 0x0400036A RID: 874
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DockManagerWashBaseLightBrushes g_Instance;

		// Token: 0x020000AB RID: 171
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000171 RID: 369
			// (get) Token: 0x060005EA RID: 1514 RVA: 0x0001DB34 File Offset: 0x0001BD34
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060005EB RID: 1515 RVA: 0x0001DB41 File Offset: 0x0001BD41
			public override string Theme
			{
				get
				{
					return "WashBaseDark";
				}
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x060005EC RID: 1516 RVA: 0x0001DB48 File Offset: 0x0001BD48
			public override string Grouping
			{
				get
				{
					return "DockManager";
				}
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060005ED RID: 1517 RVA: 0x0001DB4F File Offset: 0x0001BD4F
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DockManagerBrushes\\DockManagerWashBaseLight_Brushes.xaml";
				}
			}
		}
	}
}
