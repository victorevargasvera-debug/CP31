using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200004B RID: 75
	public class EditorsLunaSilverBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes.Locator>
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x000170C9 File Offset: 0x000152C9
		public static global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes.g_Instance;
			}
		}

		// Token: 0x040001E1 RID: 481
		private static global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsLunaSilverBrushes();

		// Token: 0x0200004C RID: 76
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000552 RID: 1362 RVA: 0x000170D0 File Offset: 0x000152D0
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000553 RID: 1363 RVA: 0x000170DD File Offset: 0x000152DD
			public override string Theme
			{
				get
				{
					return "LunaSilver";
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000554 RID: 1364 RVA: 0x000170E4 File Offset: 0x000152E4
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000555 RID: 1365 RVA: 0x000170EB File Offset: 0x000152EB
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
