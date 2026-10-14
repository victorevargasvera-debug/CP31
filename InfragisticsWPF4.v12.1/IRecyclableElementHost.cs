using System;
using System.Windows;

namespace Infragistics
{
	// Token: 0x02000070 RID: 112
	internal interface IRecyclableElementHost
	{
		// Token: 0x0600049E RID: 1182
		void OnElementAttached(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element, bool isNewlyRealized);

		// Token: 0x0600049F RID: 1183
		void OnElementReleased(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element, bool isRemoved);

		// Token: 0x060004A0 RID: 1184
		bool ShouldRemove(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element);
	}
}
