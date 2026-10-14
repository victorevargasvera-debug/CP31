using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000053 RID: 83
	public class EditorsOffice2k7SilverBrushes : global::Infragistics.Windows.Themes.EditorBrushes<global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes.Locator>
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x000171DD File Offset: 0x000153DD
		public static global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes Instance
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes.g_Instance;
			}
		}

		// Token: 0x040001E5 RID: 485
		private static global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes g_Instance = new global::Infragistics.Windows.Themes.EditorsOffice2k7SilverBrushes();

		// Token: 0x02000054 RID: 84
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000142 RID: 322
			// (get) Token: 0x06000572 RID: 1394 RVA: 0x000171E4 File Offset: 0x000153E4
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000143 RID: 323
			// (get) Token: 0x06000573 RID: 1395 RVA: 0x000171F1 File Offset: 0x000153F1
			public override string Theme
			{
				get
				{
					return "Office2k7Silver";
				}
			}

			// Token: 0x17000144 RID: 324
			// (get) Token: 0x06000574 RID: 1396 RVA: 0x000171F8 File Offset: 0x000153F8
			public override string Grouping
			{
				get
				{
					return "Editors";
				}
			}

			// Token: 0x17000145 RID: 325
			// (get) Token: 0x06000575 RID: 1397 RVA: 0x000171FF File Offset: 0x000153FF
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\EditorsBrushes\\EditorsOffice2k7Silver_Brushes.xaml";
				}
			}
		}
	}
}
