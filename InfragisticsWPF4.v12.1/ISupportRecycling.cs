using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x0200006C RID: 108
	public interface ISupportRecycling
	{
		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000461 RID: 1121
		global::System.Type RecyclingElementType { get; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000462 RID: 1122
		string RecyclingIdentifier { get; }

		// Token: 0x06000463 RID: 1123
		global::System.Windows.FrameworkElement CreateInstanceOfRecyclingElement();

		// Token: 0x06000464 RID: 1124
		void OnElementAttached(global::System.Windows.FrameworkElement element);

		// Token: 0x06000465 RID: 1125
		bool OnElementReleasing(global::System.Windows.FrameworkElement element);

		// Token: 0x06000466 RID: 1126
		void OnElementReleased(global::System.Windows.FrameworkElement element);

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000467 RID: 1127
		// (set) Token: 0x06000468 RID: 1128
		bool IsDirty { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000469 RID: 1129
		// (set) Token: 0x0600046A RID: 1130
		global::System.Windows.FrameworkElement AttachedElement { get; set; }
	}
}
