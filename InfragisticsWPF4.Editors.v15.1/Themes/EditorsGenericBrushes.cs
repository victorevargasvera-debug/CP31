using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000048 RID: 72
	public class EditorsGenericBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsGenericBrushes.Locator>
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00017CEB File Offset: 0x00015EEB
		public static global::Infragistics.Windows.Themes.EditorsGenericBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorsGenericBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.EditorsGenericBrushes.g_Instance = new global::Infragistics.Windows.Themes.EditorsGenericBrushes();
				}
				return global::Infragistics.Windows.Themes.EditorsGenericBrushes.g_Instance;
			}
		}

		// Token: 0x040001F9 RID: 505
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.EditorsGenericBrushes g_Instance;

		// Token: 0x02000049 RID: 73
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000123 RID: 291
			// (get) Token: 0x06000561 RID: 1377 RVA: 0x00017D03 File Offset: 0x00015F03
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000562 RID: 1378 RVA: 0x00017D10 File Offset: 0x00015F10
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000563 RID: 1379 RVA: 0x00017D17 File Offset: 0x00015F17
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000564 RID: 1380 RVA: 0x00017D1E File Offset: 0x00015F1E
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsGeneric_Brushes.xaml";
				}
			}
		}
	}
}
