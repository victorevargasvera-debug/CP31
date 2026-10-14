using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Infragistics.Windows.Scrolling
{
	// Token: 0x020001BC RID: 444
	public interface IDeferredScrollPanel
	{
		// Token: 0x06000FF0 RID: 4080
		bool SupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer);

		// Token: 0x06000FF1 RID: 4081
		void OnThumbDragStart(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation);

		// Token: 0x06000FF2 RID: 4082
		void OnThumbDragComplete(bool cancelled);
	}
}
