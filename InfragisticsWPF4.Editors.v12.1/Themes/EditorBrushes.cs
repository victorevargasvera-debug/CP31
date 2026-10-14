using System;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000044 RID: 68
	public abstract class EditorBrushes<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000532 RID: 1330 RVA: 0x00016FB9 File Offset: 0x000151B9
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.Location.Grouping;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000533 RID: 1331 RVA: 0x00016FC5 File Offset: 0x000151C5
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.Location.Theme;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000534 RID: 1332 RVA: 0x00016FD1 File Offset: 0x000151D1
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.ResourcesInternal;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00016FD8 File Offset: 0x000151D8
		private static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.g_Location;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000536 RID: 1334 RVA: 0x00016FDF File Offset: 0x000151DF
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x040001DC RID: 476
		private static readonly global::Infragistics.Windows.Themes.ResourceSetLocator g_Location = global::System.Activator.CreateInstance<T>();

		// Token: 0x040001DD RID: 477
		private static readonly global::System.Windows.ResourceDictionary g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.EditorBrushes<T>.g_Location.Assembly, global::Infragistics.Windows.Themes.EditorBrushes<T>.g_Location.ResourcePath);
	}
}
