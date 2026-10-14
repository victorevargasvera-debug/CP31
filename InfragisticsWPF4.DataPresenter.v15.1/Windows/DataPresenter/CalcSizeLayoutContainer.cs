using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200018C RID: 396
	internal class CalcSizeLayoutContainer : global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x06001906 RID: 6406 RVA: 0x00073EDE File Offset: 0x000720DE
		private CalcSizeLayoutContainer()
		{
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00073EE6 File Offset: 0x000720E6
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00073EEE File Offset: 0x000720EE
		void global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
		{
		}

		// Token: 0x04000A3F RID: 2623
		internal static readonly global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer Instance = new global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer();
	}
}
