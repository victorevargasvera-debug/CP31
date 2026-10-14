using System;
using System.Collections.Generic;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000031 RID: 49
	internal interface ICalendarItemArea
	{
		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000324 RID: 804
		global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> Items { get; }

		// Token: 0x06000325 RID: 805
		global::Infragistics.Windows.Editors.CalendarItem GetItem(global::System.DateTime date);

		// Token: 0x06000326 RID: 806
		void InitializeItems();

		// Token: 0x06000327 RID: 807
		void InitializeWeekNumbers();

		// Token: 0x06000328 RID: 808
		void InitializeFirstItemOffset();

		// Token: 0x06000329 RID: 809
		void InitializeRowColCount();

		// Token: 0x0600032A RID: 810
		void PrepareForAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action);

		// Token: 0x0600032B RID: 811
		void PerformAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action);

		// Token: 0x0600032C RID: 812
		void ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange change);
	}
}
