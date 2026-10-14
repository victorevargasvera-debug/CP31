using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002B RID: 43
	[global::System.Flags]
	public enum CalendarStates : long
	{
		// Token: 0x040000E6 RID: 230
		MinDateInView = 1L,
		// Token: 0x040000E7 RID: 231
		MaxDateInView = 2L,
		// Token: 0x040000E8 RID: 232
		TodayIsEnabled = 4L,
		// Token: 0x040000E9 RID: 233
		ActiveDate = 8L,
		// Token: 0x040000EA RID: 234
		CanZoomOutCalendarMode = 16L,
		// Token: 0x040000EB RID: 235
		CanZoomInCalendarMode = 32L,
		// Token: 0x040000EC RID: 236
		CalendarModeDays = 64L,
		// Token: 0x040000ED RID: 237
		CalendarModeMonths = 128L,
		// Token: 0x040000EE RID: 238
		CalendarModeYears = 256L,
		// Token: 0x040000EF RID: 239
		CalendarModeDecades = 512L,
		// Token: 0x040000F0 RID: 240
		CalendarModeCenturies = 1024L,
		// Token: 0x040000F1 RID: 241
		MinCalendarMode = 2048L,
		// Token: 0x040000F2 RID: 242
		RightToLeft = 4096L
	}
}
