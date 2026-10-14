using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200006B RID: 107
	[global::System.Flags]
	public enum MonthCalendarStates : long
	{
		// Token: 0x0400020F RID: 527
		MinDateInView = 1L,
		// Token: 0x04000210 RID: 528
		MaxDateInView = 2L,
		// Token: 0x04000211 RID: 529
		TodayIsEnabled = 4L,
		// Token: 0x04000212 RID: 530
		ActiveDate = 8L,
		// Token: 0x04000213 RID: 531
		CanZoomOutCalendarMode = 16L,
		// Token: 0x04000214 RID: 532
		CanZoomInCalendarMode = 32L,
		// Token: 0x04000215 RID: 533
		CalendarModeDays = 64L,
		// Token: 0x04000216 RID: 534
		CalendarModeMonths = 128L,
		// Token: 0x04000217 RID: 535
		CalendarModeYears = 256L,
		// Token: 0x04000218 RID: 536
		CalendarModeDecades = 512L,
		// Token: 0x04000219 RID: 537
		CalendarModeCenturies = 1024L,
		// Token: 0x0400021A RID: 538
		MinCalendarMode = 2048L,
		// Token: 0x0400021B RID: 539
		RightToLeft = 4096L
	}
}
