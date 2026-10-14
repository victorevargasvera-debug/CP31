using System;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000095 RID: 149
	public abstract class DockManagerBrushes<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001D7C8 File Offset: 0x0001B9C8
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.DockManagerBrushes<T>.Location.Grouping;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0001D7D4 File Offset: 0x0001B9D4
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.DockManagerBrushes<T>.Location.Theme;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001D7E0 File Offset: 0x0001B9E0
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				return global::Infragistics.Windows.Themes.DockManagerBrushes<T>.ResourcesInternal;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x0001D7E7 File Offset: 0x0001B9E7
		private static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				return global::Infragistics.Windows.Themes.DockManagerBrushes<T>.g_Location;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000596 RID: 1430 RVA: 0x0001D7EE File Offset: 0x0001B9EE
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.DockManagerBrushes<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.DockManagerBrushes<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.DockManagerBrushes<T>.g_Location.Assembly, global::Infragistics.Windows.Themes.DockManagerBrushes<T>.g_Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.DockManagerBrushes<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x0400035E RID: 862
		private static readonly global::Infragistics.Windows.Themes.ResourceSetLocator g_Location = global::System.Activator.CreateInstance<T>();

		// Token: 0x0400035F RID: 863
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;
	}
}
