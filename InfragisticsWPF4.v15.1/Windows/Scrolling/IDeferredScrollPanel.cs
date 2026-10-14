using System;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Infragistics.Windows.Scrolling
{
	// Token: 0x020001EA RID: 490
	public interface IDeferredScrollPanel
	{
		// Token: 0x060011BD RID: 4541
		bool SupportsDeferredScrolling(global::System.Windows.Controls.Orientation scrollBarOrientation, global::System.Windows.Controls.ScrollViewer scrollViewer);

		// Token: 0x060011BE RID: 4542
		void OnThumbDragStart(global::System.Windows.Controls.Primitives.Thumb thumb, global::System.Windows.Controls.Orientation scrollBarOrientation);

		// Token: 0x060011BF RID: 4543
		void OnThumbDragComplete(bool cancelled);
	}
}
