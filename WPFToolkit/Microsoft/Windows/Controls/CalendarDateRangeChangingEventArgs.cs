using System;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000014 RID: 20
	internal class CalendarDateRangeChangingEventArgs : global::System.EventArgs
	{
		// Token: 0x06000144 RID: 324 RVA: 0x000056BA File Offset: 0x000038BA
		public CalendarDateRangeChangingEventArgs(global::System.DateTime start, global::System.DateTime end)
		{
			this._start = start;
			this._end = end;
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000145 RID: 325 RVA: 0x000056D0 File Offset: 0x000038D0
		public global::System.DateTime Start
		{
			get
			{
				return this._start;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000056D8 File Offset: 0x000038D8
		public global::System.DateTime End
		{
			get
			{
				return this._end;
			}
		}

		// Token: 0x04000061 RID: 97
		private global::System.DateTime _start;

		// Token: 0x04000062 RID: 98
		private global::System.DateTime _end;
	}
}
