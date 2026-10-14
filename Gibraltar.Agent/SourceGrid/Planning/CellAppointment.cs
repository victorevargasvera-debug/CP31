using System;
using SourceGrid.Cells;

namespace SourceGrid.Planning
{
	// Token: 0x020003F4 RID: 1012
	internal class CellAppointment : global::SourceGrid.Cells.Cell
	{
		// Token: 0x06002CFD RID: 11517 RVA: 0x00097D3C File Offset: 0x00095F3C
		public CellAppointment(global::SourceGrid.Planning.IAppointment appointment) : base(appointment.Title)
		{
			this.m_Appointment = appointment;
		}

		// Token: 0x17000D1F RID: 3359
		// (get) Token: 0x06002CFE RID: 11518 RVA: 0x00097D54 File Offset: 0x00095F54
		public global::SourceGrid.Planning.IAppointment Appointment
		{
			get
			{
				return this.m_Appointment;
			}
		}

		// Token: 0x04000F4A RID: 3914
		private global::SourceGrid.Planning.IAppointment m_Appointment;
	}
}
