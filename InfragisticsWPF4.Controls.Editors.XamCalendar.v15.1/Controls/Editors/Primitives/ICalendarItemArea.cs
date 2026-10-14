using System;
using System.Collections.Generic;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200001B RID: 27
	internal interface ICalendarItemArea
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F5 RID: 245
		global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItem> Items { get; }

		// Token: 0x060000F6 RID: 246
		global::Infragistics.Controls.Editors.Primitives.CalendarItem GetItem(global::System.DateTime date);

		// Token: 0x060000F7 RID: 247
		global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber GetWeekNumber(int weekNumber);

		// Token: 0x060000F8 RID: 248
		void InitializeItems();

		// Token: 0x060000F9 RID: 249
		void InitializeDaysOfWeek();

		// Token: 0x060000FA RID: 250
		void InitializeWeekNumbers();

		// Token: 0x060000FB RID: 251
		void InitializeFirstItemOffset();

		// Token: 0x060000FC RID: 252
		void InitializeRowColCount();

		// Token: 0x060000FD RID: 253
		void PrepareForAnimationAction(global::Infragistics.Controls.Editors.CalendarAnimation action);

		// Token: 0x060000FE RID: 254
		void PerformAnimationAction(global::Infragistics.Controls.Editors.CalendarAnimation action);

		// Token: 0x060000FF RID: 255
		void ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange change);
	}
}
