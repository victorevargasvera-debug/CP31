using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Resizing
{
	// Token: 0x0200026A RID: 618
	public interface IResizeHostMulti : global::Infragistics.Windows.Resizing.IResizeHost
	{
		// Token: 0x06001888 RID: 6280
		bool CanResizeInBothDimensions(global::System.Windows.FrameworkElement resizableItem);

		// Token: 0x06001889 RID: 6281
		global::System.Windows.Input.Cursor GetMultiResizeCursor(global::System.Windows.FrameworkElement resizableItem, global::System.Windows.Input.Cursor cursor);

		// Token: 0x0600188A RID: 6282
		void ResizeBothDimensions(global::System.Windows.FrameworkElement resizableItem, double deltaX, double deltaY);
	}
}
