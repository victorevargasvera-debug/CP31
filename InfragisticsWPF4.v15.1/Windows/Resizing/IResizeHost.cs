using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Resizing
{
	// Token: 0x020002A4 RID: 676
	public interface IResizeHost
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001A9B RID: 6811
		global::Infragistics.Windows.Resizing.ResizeController Controller { get; }

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x06001A9C RID: 6812
		global::System.Windows.FrameworkElement RootElement { get; }

		// Token: 0x06001A9D RID: 6813
		void AddResizerBar(global::System.Windows.FrameworkElement resizerBar);

		// Token: 0x06001A9E RID: 6814
		bool CanResize(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis);

		// Token: 0x06001A9F RID: 6815
		global::System.Windows.FrameworkElement GetResizeAreaForItem(global::System.Windows.FrameworkElement resizableItem);

		// Token: 0x06001AA0 RID: 6816
		void RemoveResizerBar(global::System.Windows.FrameworkElement resizerBar);

		// Token: 0x06001AA1 RID: 6817
		void Resize(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis, double delta);

		// Token: 0x06001AA2 RID: 6818
		global::System.Windows.Input.Cursor GetResizeCursor(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis, global::System.Windows.Input.Cursor cursor);

		// Token: 0x06001AA3 RID: 6819
		void InitializeResizeConstraints(global::System.Windows.FrameworkElement resizeArea, global::System.Windows.FrameworkElement resizableItem, global::Infragistics.Windows.Resizing.ResizeConstraints constraints);
	}
}
