using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Views;

namespace SourceGrid.Planning
{
	// Token: 0x020003FC RID: 1020
	internal interface IAppointment
	{
		// Token: 0x17000D25 RID: 3365
		// (get) Token: 0x06002D0B RID: 11531
		string Title { get; }

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002D0C RID: 11532
		global::SourceGrid.Cells.Views.IView View { get; }

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002D0D RID: 11533
		global::System.DateTime DateTimeStart { get; }

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002D0E RID: 11534
		global::System.DateTime DateTimeEnd { get; }

		// Token: 0x06002D0F RID: 11535
		bool ContainsDateTime(global::System.DateTime p_DateTime);

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002D10 RID: 11536
		// (set) Token: 0x06002D11 RID: 11537
		global::SourceGrid.Cells.Controllers.IController Controller { get; set; }
	}
}
