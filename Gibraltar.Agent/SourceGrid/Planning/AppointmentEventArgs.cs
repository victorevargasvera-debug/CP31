using System;

namespace SourceGrid.Planning
{
	// Token: 0x020003FB RID: 1019
	internal class AppointmentEventArgs : global::System.EventArgs
	{
		// Token: 0x06002D07 RID: 11527 RVA: 0x00097DC0 File Offset: 0x00095FC0
		public AppointmentEventArgs(global::System.DateTime start, global::System.DateTime end, global::SourceGrid.Planning.IAppointment appointment)
		{
			this.m_DateTimeEnd = end;
			this.m_DateTimeStart = start;
			this.m_Appointment = appointment;
		}

		// Token: 0x17000D22 RID: 3362
		// (get) Token: 0x06002D08 RID: 11528 RVA: 0x00097DE0 File Offset: 0x00095FE0
		public global::System.DateTime DateTimeStart
		{
			get
			{
				return this.m_DateTimeStart;
			}
		}

		// Token: 0x17000D23 RID: 3363
		// (get) Token: 0x06002D09 RID: 11529 RVA: 0x00097DE8 File Offset: 0x00095FE8
		public global::System.DateTime DateTimeEnd
		{
			get
			{
				return this.m_DateTimeEnd;
			}
		}

		// Token: 0x17000D24 RID: 3364
		// (get) Token: 0x06002D0A RID: 11530 RVA: 0x00097DF0 File Offset: 0x00095FF0
		public global::SourceGrid.Planning.IAppointment Appointment
		{
			get
			{
				return this.m_Appointment;
			}
		}

		// Token: 0x04000F4D RID: 3917
		private global::System.DateTime m_DateTimeStart;

		// Token: 0x04000F4E RID: 3918
		private global::System.DateTime m_DateTimeEnd;

		// Token: 0x04000F4F RID: 3919
		private global::SourceGrid.Planning.IAppointment m_Appointment;
	}
}
