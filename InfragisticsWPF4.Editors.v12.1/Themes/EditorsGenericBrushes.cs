using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000045 RID: 69
	public class EditorsGenericBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsGenericBrushes.Locator>
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00016FFA File Offset: 0x000151FA
		public static global::Infragistics.Windows.Themes.EditorsGenericBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsGenericBrushes.g_Instance;
			}
		}

		// Token: 0x040001DE RID: 478
		private static global::Infragistics.Windows.Themes.EditorsGenericBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsGenericBrushes();

		// Token: 0x02000046 RID: 70
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700011F RID: 287
			// (get) Token: 0x0600053A RID: 1338 RVA: 0x00017001 File Offset: 0x00015201
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600053B RID: 1339 RVA: 0x0001700E File Offset: 0x0001520E
			public override string Theme
			{
				get
				{
					return "Generic";
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600053C RID: 1340 RVA: 0x00017015 File Offset: 0x00015215
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x0600053D RID: 1341 RVA: 0x0001701C File Offset: 0x0001521C
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
