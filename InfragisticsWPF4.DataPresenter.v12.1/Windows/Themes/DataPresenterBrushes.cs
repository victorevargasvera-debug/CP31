using System;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000177 RID: 375
	public abstract class DataPresenterBrushes<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x0006331A File Offset: 0x0006151A
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.Location.Grouping;
			}
		}

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060015ED RID: 5613 RVA: 0x00063326 File Offset: 0x00061526
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.Location.Theme;
			}
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x00063332 File Offset: 0x00061532
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.ResourcesInternal;
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060015EF RID: 5615 RVA: 0x00063339 File Offset: 0x00061539
		private static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.g_Location == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.g_Location = global::System.Activator.CreateInstance<T>();
				}
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.g_Location;
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x00063356 File Offset: 0x00061556
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.Location.Assembly, global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x040008B3 RID: 2227
		internal static readonly string GroupingName = "";

		// Token: 0x040008B4 RID: 2228
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x040008B5 RID: 2229
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;
	}
}
