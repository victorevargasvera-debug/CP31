using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000071 RID: 113
	[global::System.Flags]
	public enum MonthCalendarStates : long
	{
		// Token: 0x04000242 RID: 578
		MinDateInView = 1L,
		// Token: 0x04000243 RID: 579
		MaxDateInView = 2L,
		// Token: 0x04000244 RID: 580
		TodayIsEnabled = 4L,
		// Token: 0x04000245 RID: 581
		ActiveDate = 8L,
		// Token: 0x04000246 RID: 582
		CanZoomOutCalendarMode = 16L,
		// Token: 0x04000247 RID: 583
		CanZoomInCalendarMode = 32L,
		// Token: 0x04000248 RID: 584
		CalendarModeDays = 64L,
		// Token: 0x04000249 RID: 585
		CalendarModeMonths = 128L,
		// Token: 0x0400024A RID: 586
		CalendarModeYears = 256L,
		// Token: 0x0400024B RID: 587
		CalendarModeDecades = 512L,
		// Token: 0x0400024C RID: 588
		CalendarModeCenturies = 1024L,
		// Token: 0x0400024D RID: 589
		MinCalendarMode = 2048L,
		// Token: 0x0400024E RID: 590
		RightToLeft = 4096L
	}
}
