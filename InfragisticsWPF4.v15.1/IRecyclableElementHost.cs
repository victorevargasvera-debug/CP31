using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000087 RID: 135
	internal interface IRecyclableElementHost
	{
		// Token: 0x0600055F RID: 1375
		void OnElementAttached(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element, bool isNewlyRealized);

		// Token: 0x06000560 RID: 1376
		void OnElementReleased(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element, bool isRemoved);

		// Token: 0x06000561 RID: 1377
		bool ShouldRemove(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element);
	}
}
