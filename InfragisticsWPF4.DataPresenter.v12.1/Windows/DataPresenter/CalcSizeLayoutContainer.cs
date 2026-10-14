using System;
using System.Windows;
using Infragistics.Controls.Layouts.Primitives;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000170 RID: 368
	internal class CalcSizeLayoutContainer : global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer
	{
		// Token: 0x06001584 RID: 5508 RVA: 0x00061D8A File Offset: 0x0005FF8A
		private CalcSizeLayoutContainer()
		{
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00061D92 File Offset: 0x0005FF92
		global::System.Windows.Rect global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.GetBounds(object containerContext)
		{
			return (global::System.Windows.Rect)containerContext;
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00061D9A File Offset: 0x0005FF9A
		void global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer.PositionItem(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, global::System.Windows.Rect rect, object containerContext)
		{
		}

		// Token: 0x04000889 RID: 2185
		internal static readonly global::Infragistics.Controls.Layouts.Primitives.ILayoutContainer Instance = new global::Infragistics.Windows.DataPresenter.CalcSizeLayoutContainer();
	}
}
