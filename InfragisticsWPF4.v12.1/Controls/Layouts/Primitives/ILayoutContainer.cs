using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x02000041 RID: 65
	public interface ILayoutContainer
	{
		// Token: 0x06000301 RID: 769
		global::System.Windows.Rect GetBounds(object containerContext);

		// Token: 0x06000302 RID: 770
		void PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext);
	}
}
