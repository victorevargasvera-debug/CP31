using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000034 RID: 52
	internal interface ICalendarItemArea
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000344 RID: 836
		global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> Items { get; }

		// Token: 0x06000345 RID: 837
		global::Infragistics.Windows.Editors.CalendarItem GetItem(global::System.DateTime date);

		// Token: 0x06000346 RID: 838
		void InitializeItems();

		// Token: 0x06000347 RID: 839
		void InitializeWeekNumbers();

		// Token: 0x06000348 RID: 840
		void InitializeFirstItemOffset();

		// Token: 0x06000349 RID: 841
		void InitializeRowColCount();

		// Token: 0x0600034A RID: 842
		void PrepareForAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action);

		// Token: 0x0600034B RID: 843
		void PerformAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action);

		// Token: 0x0600034C RID: 844
		void ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange change);
	}
}
