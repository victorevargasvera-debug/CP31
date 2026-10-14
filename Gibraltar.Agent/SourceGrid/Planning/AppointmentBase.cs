using System;
using System.ComponentModel;
using DevAge.Drawing;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Planning
{
	// Token: 0x020003FD RID: 1021
	internal class AppointmentBase : global::SourceGrid.Planning.IAppointment
	{
		// Token: 0x06002D12 RID: 11538 RVA: 0x00097DF8 File Offset: 0x00095FF8
		public AppointmentBase(string title, global::System.DateTime dateTimeStart, global::System.DateTime dateTimeEnd)
		{
			this.m_Title = title;
			this.m_DateTimeEnd = dateTimeEnd;
			this.m_DateTimeStart = dateTimeStart;
			this.m_View = new global::SourceGrid.Cells.Views.Cell();
			this.m_View.Border = global::DevAge.Drawing.RectangleBorder.RectangleBlack1Width;
		}

		// Token: 0x06002D13 RID: 11539 RVA: 0x00097E38 File Offset: 0x00096038
		public AppointmentBase() : this("", global::System.DateTime.Now, global::System.DateTime.Now)
		{
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002D14 RID: 11540 RVA: 0x00097E50 File Offset: 0x00096050
		// (set) Token: 0x06002D15 RID: 11541 RVA: 0x00097E58 File Offset: 0x00096058
		public global::System.DateTime DateTimeStart
		{
			get
			{
				return this.m_DateTimeStart;
			}
			set
			{
				this.m_DateTimeStart = value;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x00097E64 File Offset: 0x00096064
		// (set) Token: 0x06002D17 RID: 11543 RVA: 0x00097E6C File Offset: 0x0009606C
		public global::System.DateTime DateTimeEnd
		{
			get
			{
				return this.m_DateTimeEnd;
			}
			set
			{
				this.m_DateTimeEnd = value;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x06002D18 RID: 11544 RVA: 0x00097E78 File Offset: 0x00096078
		// (set) Token: 0x06002D19 RID: 11545 RVA: 0x00097E80 File Offset: 0x00096080
		public virtual string Title
		{
			get
			{
				return this.m_Title;
			}
			set
			{
				this.m_Title = value;
			}
		}

		// Token: 0x17000D2D RID: 3373
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x00097E8C File Offset: 0x0009608C
		// (set) Token: 0x06002D1B RID: 11547 RVA: 0x00097E94 File Offset: 0x00096094
		[global::System.ComponentModel.Browsable(false)]
		public virtual global::SourceGrid.Cells.Views.IView View
		{
			get
			{
				return this.m_View;
			}
			set
			{
				this.m_View = value;
			}
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00097EA0 File Offset: 0x000960A0
		public bool ContainsDateTime(global::System.DateTime p_DateTime)
		{
			return this.m_DateTimeStart <= p_DateTime && this.m_DateTimeEnd > p_DateTime;
		}

		// Token: 0x17000D2E RID: 3374
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x00097EC4 File Offset: 0x000960C4
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x00097ECC File Offset: 0x000960CC
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Cells.Controllers.IController Controller
		{
			get
			{
				return this.mController;
			}
			set
			{
				this.mController = value;
			}
		}

		// Token: 0x04000F50 RID: 3920
		private global::System.DateTime m_DateTimeStart;

		// Token: 0x04000F51 RID: 3921
		private global::System.DateTime m_DateTimeEnd;

		// Token: 0x04000F52 RID: 3922
		private string m_Title;

		// Token: 0x04000F53 RID: 3923
		private global::SourceGrid.Cells.Views.IView m_View;

		// Token: 0x04000F54 RID: 3924
		private global::SourceGrid.Cells.Controllers.IController mController;
	}
}
