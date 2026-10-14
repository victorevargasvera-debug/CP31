using System;
using System.Windows;
using System.Windows.Controls;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200010D RID: 269
	public class MergedContentControl : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x0600090E RID: 2318 RVA: 0x00024598 File Offset: 0x00022798
		static MergedContentControl()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.MergedContentControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.MergedContentControl)));
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000245BD File Offset: 0x000227BD
		public MergedContentControl()
		{
			base.IsHitTestVisible = false;
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x000245CC File Offset: 0x000227CC
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x000245D4 File Offset: 0x000227D4
		internal global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase ContentProvider { get; set; }
	}
}
