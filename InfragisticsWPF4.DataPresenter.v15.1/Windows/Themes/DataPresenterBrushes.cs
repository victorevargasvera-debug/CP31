using System;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x0200019C RID: 412
	public abstract class DataPresenterBrushes<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06001A14 RID: 6676 RVA: 0x00077992 File Offset: 0x00075B92
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.Location.Grouping;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001A15 RID: 6677 RVA: 0x0007799E File Offset: 0x00075B9E
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.Location.Theme;
			}
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x06001A16 RID: 6678 RVA: 0x000779AA File Offset: 0x00075BAA
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				return global::Infragistics.Windows.Themes.DataPresenterBrushes<T>.ResourcesInternal;
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x06001A17 RID: 6679 RVA: 0x000779B1 File Offset: 0x00075BB1
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x06001A18 RID: 6680 RVA: 0x000779CE File Offset: 0x00075BCE
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

		// Token: 0x04000AA9 RID: 2729
		internal static readonly string GroupingName = "";

		// Token: 0x04000AAA RID: 2730
		[global::System.ThreadStatic]
		private static global::Infragistics.Windows.Themes.ResourceSetLocator g_Location;

		// Token: 0x04000AAB RID: 2731
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;
	}
}
