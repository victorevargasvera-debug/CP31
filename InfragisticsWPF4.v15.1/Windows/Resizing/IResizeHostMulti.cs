using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Resizing
{
	// Token: 0x020002A5 RID: 677
	public interface IResizeHostMulti : global::Infragistics.Windows.Resizing.IResizeHost
	{
		// Token: 0x06001AA4 RID: 6820
		bool CanResizeInBothDimensions(global::System.Windows.FrameworkElement resizableItem);

		// Token: 0x06001AA5 RID: 6821
		global::System.Windows.Input.Cursor GetMultiResizeCursor(global::System.Windows.FrameworkElement resizableItem, global::System.Windows.Input.Cursor cursor);

		// Token: 0x06001AA6 RID: 6822
		void ResizeBothDimensions(global::System.Windows.FrameworkElement resizableItem, double deltaX, double deltaY);
	}
}
