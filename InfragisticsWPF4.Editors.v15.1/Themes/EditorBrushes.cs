using System;
using System.Windows;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000047 RID: 71
	public abstract class EditorBrushes<T> : global::Infragistics.Windows.Themes.ResourceSet where T : global::Infragistics.Windows.Themes.ResourceSetLocator, new()
	{
		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x00017C8F File Offset: 0x00015E8F
		public override string Grouping
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.Location.Grouping;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00017C9B File Offset: 0x00015E9B
		public override string Theme
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.Location.Theme;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600055B RID: 1371 RVA: 0x00017CA7 File Offset: 0x00015EA7
		public override global::System.Windows.ResourceDictionary Resources
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.ResourcesInternal;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600055C RID: 1372 RVA: 0x00017CAE File Offset: 0x00015EAE
		private static global::Infragistics.Windows.Themes.ResourceSetLocator Location
		{
			get
			{
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.g_Location;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600055D RID: 1373 RVA: 0x00017CB5 File Offset: 0x00015EB5
		private static global::System.Windows.ResourceDictionary ResourcesInternal
		{
			get
			{
				if (global::Infragistics.Windows.Themes.EditorBrushes<T>.g_ResourcesInternal == null)
				{
					global::Infragistics.Windows.Themes.EditorBrushes<T>.g_ResourcesInternal = global::Infragistics.Windows.Utilities.CreateResourceSetDictionary(global::Infragistics.Windows.Themes.EditorBrushes<T>.g_Location.Assembly, global::Infragistics.Windows.Themes.EditorBrushes<T>.g_Location.ResourcePath);
				}
				return global::Infragistics.Windows.Themes.EditorBrushes<T>.g_ResourcesInternal;
			}
		}

		// Token: 0x040001F7 RID: 503
		private static readonly global::Infragistics.Windows.Themes.ResourceSetLocator g_Location = global::System.Activator.CreateInstance<T>();

		// Token: 0x040001F8 RID: 504
		[global::System.ThreadStatic]
		private static global::System.Windows.ResourceDictionary g_ResourcesInternal;
	}
}
