using System;
using System.Windows;
using System.Windows.Input;

namespace Infragistics.Windows.Resizing
{
	// Token: 0x02000269 RID: 617
	public interface IResizeHost
	{
		// Token: 0x170005C8 RID: 1480
		// (get) Token: 0x0600187F RID: 6271
		global::Infragistics.Windows.Resizing.ResizeController Controller { get; }

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001880 RID: 6272
		global::System.Windows.FrameworkElement RootElement { get; }

		// Token: 0x06001881 RID: 6273
		void AddResizerBar(global::System.Windows.FrameworkElement resizerBar);

		// Token: 0x06001882 RID: 6274
		bool CanResize(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis);

		// Token: 0x06001883 RID: 6275
		global::System.Windows.FrameworkElement GetResizeAreaForItem(global::System.Windows.FrameworkElement resizableItem);

		// Token: 0x06001884 RID: 6276
		void RemoveResizerBar(global::System.Windows.FrameworkElement resizerBar);

		// Token: 0x06001885 RID: 6277
		void Resize(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis, double delta);

		// Token: 0x06001886 RID: 6278
		global::System.Windows.Input.Cursor GetResizeCursor(global::System.Windows.FrameworkElement resizableItem, bool resizeInXAxis, global::System.Windows.Input.Cursor cursor);

		// Token: 0x06001887 RID: 6279
		void InitializeResizeConstraints(global::System.Windows.FrameworkElement resizeArea, global::System.Windows.FrameworkElement resizableItem, global::Infragistics.Windows.Resizing.ResizeConstraints constraints);
	}
}
