using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000083 RID: 131
	public interface ISupportRecycling
	{
		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000522 RID: 1314
		global::System.Type RecyclingElementType { get; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000523 RID: 1315
		string RecyclingIdentifier { get; }

		// Token: 0x06000524 RID: 1316
		global::System.Windows.FrameworkElement CreateInstanceOfRecyclingElement();

		// Token: 0x06000525 RID: 1317
		void OnElementAttached(global::System.Windows.FrameworkElement element);

		// Token: 0x06000526 RID: 1318
		bool OnElementReleasing(global::System.Windows.FrameworkElement element);

		// Token: 0x06000527 RID: 1319
		void OnElementReleased(global::System.Windows.FrameworkElement element);

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000528 RID: 1320
		// (set) Token: 0x06000529 RID: 1321
		bool IsDirty { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600052A RID: 1322
		// (set) Token: 0x0600052B RID: 1323
		global::System.Windows.FrameworkElement AttachedElement { get; set; }
	}
}
