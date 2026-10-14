using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SourceGrid.Cells;
using SourceGrid.Cells.Controllers;

namespace SourceGrid.Planning
{
	// Token: 0x020003F3 RID: 1011
	internal class PlanningGrid : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06002CEF RID: 11503 RVA: 0x00097648 File Offset: 0x00095848
		public PlanningGrid()
		{
			this.InitializeComponent();
			this.grid.Selection.FocusStyle = global::SourceGrid.FocusStyle.None;
		}

		// Token: 0x06002CF0 RID: 11504 RVA: 0x00097684 File Offset: 0x00095884
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x000976AC File Offset: 0x000958AC
		private void InitializeComponent()
		{
			this.grid = new global::SourceGrid.Grid();
			base.SuspendLayout();
			this.grid.AutoStretchColumnsToFitWidth = false;
			this.grid.AutoStretchRowsToFitHeight = false;
			this.grid.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.grid.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new global::System.Drawing.Point(0, 0);
			this.grid.Name = "grid";
			this.grid.Size = new global::System.Drawing.Size(360, 340);
			this.grid.SpecialKeys = global::SourceGrid.GridSpecialKeys.Default;
			this.grid.TabIndex = 0;
			base.Controls.Add(this.grid);
			base.Name = "PlanningGrid";
			base.Size = new global::System.Drawing.Size(360, 340);
			base.ResumeLayout(false);
		}

		// Token: 0x06002CF2 RID: 11506 RVA: 0x00097790 File Offset: 0x00095990
		protected override void OnLoad(global::System.EventArgs e)
		{
			base.OnLoad(e);
			this.grid.Controller.AddController(new global::SourceGrid.Planning.PlanningGrid.AppointmentController(this));
		}

		// Token: 0x17000D1D RID: 3357
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x000977B0 File Offset: 0x000959B0
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::SourceGrid.Planning.AppointmentCollection Appointments
		{
			get
			{
				return this.m_Appointments;
			}
		}

		// Token: 0x17000D1E RID: 3358
		// (get) Token: 0x06002CF4 RID: 11508 RVA: 0x000977B8 File Offset: 0x000959B8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Grid Grid
		{
			get
			{
				return this.grid;
			}
		}

		// Token: 0x06002CF5 RID: 11509 RVA: 0x000977C0 File Offset: 0x000959C0
		public void LoadPlanning(global::System.DateTime dateTimeStart, global::System.DateTime dateTimeEnd, int minAppointmentLength)
		{
			this.m_DateTimeStart = dateTimeStart;
			this.m_DateTimeEnd = dateTimeEnd;
			this.m_MinAppointmentLength = minAppointmentLength;
			if (dateTimeStart >= dateTimeEnd)
			{
				throw new global::System.ApplicationException("Invalid Planning Range");
			}
			if (dateTimeStart.TimeOfDay >= dateTimeEnd.TimeOfDay)
			{
				throw new global::System.ApplicationException("Invalid Plannnin Range");
			}
			if (dateTimeStart.TimeOfDay.Minutes != 0 || dateTimeEnd.TimeOfDay.Minutes != 0)
			{
				throw new global::System.ApplicationException("Invalid Start or End hours must be with 0 minutes");
			}
			if (minAppointmentLength <= 0 || minAppointmentLength > 60)
			{
				throw new global::System.ApplicationException("Invalid Minimum Appointment Length");
			}
			if (60 % minAppointmentLength != 0)
			{
				throw new global::System.ApplicationException("Invalid Minimum Appointment Length must be multiple of 60");
			}
			global::System.TimeSpan timeSpan = dateTimeEnd - dateTimeStart;
			global::System.TimeSpan timeSpan2 = dateTimeEnd.TimeOfDay - dateTimeStart.TimeOfDay;
			int num = 60 / minAppointmentLength;
			if (timeSpan.TotalDays > 30.0)
			{
				throw new global::System.ApplicationException("Range too big");
			}
			if (timeSpan2.TotalMinutes < (double)minAppointmentLength)
			{
				throw new global::System.ApplicationException("Invalid Minimum Appointment Length for current Planning Range");
			}
			this.grid.Redim((int)((timeSpan2.TotalHours + 1.0) * (double)num + 2.0), (int)(timeSpan.TotalDays + 1.0 + 2.0));
			this.grid[0, 0] = new global::SourceGrid.Planning.Header00(null);
			this.grid[0, 0].RowSpan = 2;
			this.grid[0, 0].ColumnSpan = 2;
			global::System.DateTime dateTime = dateTimeStart;
			for (int i = 2; i < this.grid.ColumnsCount; i++)
			{
				this.grid[0, i] = new global::SourceGrid.Planning.HeaderDay1(dateTime.ToShortDateString());
				this.grid[1, i] = new global::SourceGrid.Planning.HeaderDay2(dateTime.ToString("dddd"));
				dateTime = dateTime.AddDays(1.0);
			}
			int num2 = dateTimeStart.Hour;
			for (int j = 2; j < this.grid.RowsCount; j += num)
			{
				this.grid[j, 0] = new global::SourceGrid.Planning.HeaderHour1(num2);
				this.grid[j, 0].RowSpan = num;
				int num3 = 0;
				for (int k = j; k < j + num; k++)
				{
					this.grid[k, 1] = new global::SourceGrid.Planning.HeaderHour2(num3);
					num3 += minAppointmentLength;
				}
				num2++;
			}
			this.grid.FixedColumns = 2;
			this.grid.FixedRows = 2;
			this.grid.Columns[0].Width = 40;
			this.grid.Columns[0].AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			this.grid.Columns[1].Width = 40;
			this.grid.Columns[1].AutoSizeMode = global::SourceGrid.AutoSizeMode.None;
			this.grid.AutoStretchColumnsToFitWidth = true;
			this.grid.AutoStretchRowsToFitHeight = true;
			this.grid.AutoSizeCells();
			for (int l = 2; l < this.grid.ColumnsCount; l++)
			{
				global::System.DateTime dateTime2 = dateTimeStart.AddDays((double)(l - 2));
				int num4 = -1;
				global::SourceGrid.Cells.Cell cell = null;
				for (int m = 2; m < this.grid.RowsCount; m += num)
				{
					for (int n = m; n < m + num; n++)
					{
						bool flag = false;
						int num5 = 0;
						while (num5 < this.m_Appointments.Count)
						{
							if (this.m_Appointments[num5].ContainsDateTime(dateTime2))
							{
								flag = true;
								if (num4 != num5)
								{
									cell = new global::SourceGrid.Planning.CellAppointment(this.m_Appointments[num5]);
									cell.View = this.m_Appointments[num5].View;
									if (this.m_Appointments[num5].Controller != null)
									{
										cell.AddController(this.m_Appointments[num5].Controller);
									}
									this.grid[n, l] = cell;
									num4 = num5;
									break;
								}
								this.grid[n, l] = null;
								cell.RowSpan++;
								break;
							}
							else
							{
								num5++;
							}
						}
						if (!flag)
						{
							this.grid[n, l] = new global::SourceGrid.Planning.CellEmpty(dateTime2, dateTime2.AddMinutes((double)minAppointmentLength));
							num4 = -1;
							cell = null;
						}
						dateTime2 = dateTime2.AddMinutes((double)minAppointmentLength);
					}
				}
			}
		}

		// Token: 0x06002CF6 RID: 11510 RVA: 0x00097C84 File Offset: 0x00095E84
		public void UnLoadPlanning()
		{
			this.grid.Redim(0, 0);
		}

		// Token: 0x140000DE RID: 222
		// (add) Token: 0x06002CF7 RID: 11511 RVA: 0x00097C94 File Offset: 0x00095E94
		// (remove) Token: 0x06002CF8 RID: 11512 RVA: 0x00097CB0 File Offset: 0x00095EB0
		public event global::SourceGrid.Planning.PlanningGrid.AppointmentEventHandler AppointmentClick;

		// Token: 0x06002CF9 RID: 11513 RVA: 0x00097CCC File Offset: 0x00095ECC
		protected virtual void OnAppointmentClick(global::SourceGrid.Planning.AppointmentEventArgs e)
		{
			if (this.AppointmentClick != null)
			{
				this.AppointmentClick(this, e);
			}
		}

		// Token: 0x140000DF RID: 223
		// (add) Token: 0x06002CFA RID: 11514 RVA: 0x00097CE8 File Offset: 0x00095EE8
		// (remove) Token: 0x06002CFB RID: 11515 RVA: 0x00097D04 File Offset: 0x00095F04
		public event global::SourceGrid.Planning.PlanningGrid.AppointmentEventHandler AppointmentDoubleClick;

		// Token: 0x06002CFC RID: 11516 RVA: 0x00097D20 File Offset: 0x00095F20
		protected virtual void OnAppointmentDoubleClick(global::SourceGrid.Planning.AppointmentEventArgs e)
		{
			if (this.AppointmentDoubleClick != null)
			{
				this.AppointmentDoubleClick(this, e);
			}
		}

		// Token: 0x04000F40 RID: 3904
		private const int c_RowsHeader = 2;

		// Token: 0x04000F41 RID: 3905
		private const int c_ColumnsHeader = 2;

		// Token: 0x04000F42 RID: 3906
		private global::SourceGrid.Grid grid;

		// Token: 0x04000F43 RID: 3907
		private global::System.ComponentModel.Container components;

		// Token: 0x04000F44 RID: 3908
		private global::System.DateTime m_DateTimeStart;

		// Token: 0x04000F45 RID: 3909
		private global::System.DateTime m_DateTimeEnd;

		// Token: 0x04000F46 RID: 3910
		private int m_MinAppointmentLength;

		// Token: 0x04000F47 RID: 3911
		private global::SourceGrid.Planning.AppointmentCollection m_Appointments = new global::SourceGrid.Planning.AppointmentCollection();

		// Token: 0x020004D6 RID: 1238
		// (Invoke) Token: 0x0600346A RID: 13418
		public delegate void AppointmentEventHandler(object sender, global::SourceGrid.Planning.AppointmentEventArgs e);

		// Token: 0x020004D7 RID: 1239
		private class AppointmentController : global::SourceGrid.Cells.Controllers.ControllerBase
		{
			// Token: 0x0600346D RID: 13421 RVA: 0x000BC7BC File Offset: 0x000BA9BC
			public AppointmentController(global::SourceGrid.Planning.PlanningGrid planningGrid)
			{
				this.mPlanningGrid = planningGrid;
			}

			// Token: 0x0600346E RID: 13422 RVA: 0x000BC7CC File Offset: 0x000BA9CC
			public override void OnClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
			{
				base.OnClick(sender, e);
				if (sender.Cell is global::SourceGrid.Planning.CellAppointment)
				{
					global::SourceGrid.Planning.CellAppointment cellAppointment = (global::SourceGrid.Planning.CellAppointment)sender.Cell;
					this.mPlanningGrid.OnAppointmentClick(new global::SourceGrid.Planning.AppointmentEventArgs(cellAppointment.Appointment.DateTimeStart, cellAppointment.Appointment.DateTimeEnd, cellAppointment.Appointment));
					return;
				}
				if (sender.Cell is global::SourceGrid.Planning.CellEmpty)
				{
					global::SourceGrid.Planning.CellEmpty cellEmpty = (global::SourceGrid.Planning.CellEmpty)sender.Cell;
					this.mPlanningGrid.OnAppointmentClick(new global::SourceGrid.Planning.AppointmentEventArgs(cellEmpty.Start, cellEmpty.End, null));
				}
			}

			// Token: 0x0600346F RID: 13423 RVA: 0x000BC86C File Offset: 0x000BAA6C
			public override void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
			{
				base.OnDoubleClick(sender, e);
				if (sender.Cell is global::SourceGrid.Planning.CellAppointment)
				{
					global::SourceGrid.Planning.CellAppointment cellAppointment = (global::SourceGrid.Planning.CellAppointment)sender.Cell;
					this.mPlanningGrid.OnAppointmentDoubleClick(new global::SourceGrid.Planning.AppointmentEventArgs(cellAppointment.Appointment.DateTimeStart, cellAppointment.Appointment.DateTimeEnd, cellAppointment.Appointment));
					return;
				}
				if (sender.Cell is global::SourceGrid.Planning.CellEmpty)
				{
					global::SourceGrid.Planning.CellEmpty cellEmpty = (global::SourceGrid.Planning.CellEmpty)sender.Cell;
					this.mPlanningGrid.OnAppointmentDoubleClick(new global::SourceGrid.Planning.AppointmentEventArgs(cellEmpty.Start, cellEmpty.End, null));
				}
			}

			// Token: 0x040013E1 RID: 5089
			private global::SourceGrid.Planning.PlanningGrid mPlanningGrid;
		}
	}
}
