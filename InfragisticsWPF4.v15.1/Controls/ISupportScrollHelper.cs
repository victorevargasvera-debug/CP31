using System;
using System.Windows;

namespace Infragistics.Controls
{
	// Token: 0x020000EB RID: 235
	internal interface ISupportScrollHelper
	{
		// Token: 0x0600085A RID: 2138
		double GetFirstItemHeight();

		// Token: 0x0600085B RID: 2139
		double GetFirstItemWidth();

		// Token: 0x0600085C RID: 2140
		global::Infragistics.Controls.TouchScrollMode GetScrollModeFromPoint(global::System.Windows.Point point, global::System.Windows.UIElement elementDirectlyOver);

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600085D RID: 2141
		double HorizontalMax { get; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600085E RID: 2142
		global::Infragistics.Controls.ScrollType HorizontalScrollType { get; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600085F RID: 2143
		// (set) Token: 0x06000860 RID: 2144
		double HorizontalValue { get; set; }

		// Token: 0x06000861 RID: 2145
		void InvalidateScrollLayout();

		// Token: 0x06000862 RID: 2146
		void OnPanComplete();

		// Token: 0x06000863 RID: 2147
		void OnStateChanged(global::Infragistics.Controls.TouchState newState, global::Infragistics.Controls.TouchState oldState);

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000864 RID: 2148
		double VerticalMax { get; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000865 RID: 2149
		global::Infragistics.Controls.ScrollType VerticalScrollType { get; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000866 RID: 2150
		// (set) Token: 0x06000867 RID: 2151
		double VerticalValue { get; set; }
	}
}
