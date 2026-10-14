using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000CD RID: 205
	internal interface ISupportScrollHelper
	{
		// Token: 0x0600075B RID: 1883
		double GetFirstItemHeight();

		// Token: 0x0600075C RID: 1884
		double GetFirstItemWidth();

		// Token: 0x0600075D RID: 1885
		global::Infragistics.Controls.TouchScrollMode GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver);

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600075E RID: 1886
		double HorizontalMax { get; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600075F RID: 1887
		global::Infragistics.Controls.ScrollType HorizontalScrollType { get; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000760 RID: 1888
		// (set) Token: 0x06000761 RID: 1889
		double HorizontalValue { get; set; }

		// Token: 0x06000762 RID: 1890
		void InvalidateScrollLayout();

		// Token: 0x06000763 RID: 1891
		void OnPanComplete();

		// Token: 0x06000764 RID: 1892
		void OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState);

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000765 RID: 1893
		double VerticalMax { get; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000766 RID: 1894
		global::Infragistics.Controls.ScrollType VerticalScrollType { get; }

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000767 RID: 1895
		// (set) Token: 0x06000768 RID: 1896
		double VerticalValue { get; set; }
	}
}
