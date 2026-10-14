using System;
using System.ComponentModel;
using System.Reflection;

namespace Infragistics.Windows.Themes
{
	// Token: 0x020001AB RID: 427
	public class DataPresenterOffice2010BlueBrushes : global::Infragistics.Windows.Themes.DataPresenterBrushes<global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.Locator>
	{
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x00077C14 File Offset: 0x00075E14
		public static global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes Instance
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.g_Instance == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.g_Instance = new global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes();
				}
				return global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes.g_Instance;
			}
		}

		// Token: 0x04000AB3 RID: 2739
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.DataPresenterOffice2010BlueBrushes g_Instance;

		// Token: 0x020001AC RID: 428
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public class Locator : global::Infragistics.Windows.Themes.ResourceSetLocator
		{
			// Token: 0x17000730 RID: 1840
			// (get) Token: 0x06001A4E RID: 6734 RVA: 0x00077C34 File Offset: 0x00075E34
			public override global::System.Reflection.Assembly Assembly
			{
				get
				{
					return base.GetType().Assembly;
				}
			}

			// Token: 0x17000731 RID: 1841
			// (get) Token: 0x06001A4F RID: 6735 RVA: 0x00077C41 File Offset: 0x00075E41
			public override string Theme
			{
				get
				{
					return "Office2010BlueBrushes";
				}
			}

			// Token: 0x17000732 RID: 1842
			// (get) Token: 0x06001A50 RID: 6736 RVA: 0x00077C48 File Offset: 0x00075E48
			public override string Grouping
			{
				get
				{
					return "DataPresenter";
				}
			}

			// Token: 0x17000733 RID: 1843
			// (get) Token: 0x06001A51 RID: 6737 RVA: 0x00077C4F File Offset: 0x00075E4F
			public override string ResourcePath
			{
				get
				{
					return "ResourceSets\\DataPresenterBrushes\\DataPresenterOffice2010Blue_Brushes.xaml";
				}
			}
		}
	}
}
