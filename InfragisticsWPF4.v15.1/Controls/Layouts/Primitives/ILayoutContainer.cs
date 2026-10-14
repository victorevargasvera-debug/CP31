using System;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x02000055 RID: 85
	public interface ILayoutContainer
	{
		// Token: 0x06000393 RID: 915
		global::System.Windows.Rect GetBounds(object containerContext);

		// Token: 0x06000394 RID: 916
		void PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext);
	}
}
