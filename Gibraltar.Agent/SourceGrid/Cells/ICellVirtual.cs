using System;
using SourceGrid.Cells.Controllers;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Views;

namespace SourceGrid.Cells
{
	// Token: 0x02000355 RID: 853
	internal interface ICellVirtual
	{
		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060029C4 RID: 10692
		// (set) Token: 0x060029C5 RID: 10693
		global::SourceGrid.Cells.Editors.EditorBase Editor { get; set; }

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060029C6 RID: 10694
		global::SourceGrid.Cells.Controllers.ControllerContainer Controller { get; }

		// Token: 0x060029C7 RID: 10695
		void AddController(global::SourceGrid.Cells.Controllers.IController controller);

		// Token: 0x060029C8 RID: 10696
		void RemoveController(global::SourceGrid.Cells.Controllers.IController controller);

		// Token: 0x060029C9 RID: 10697
		global::SourceGrid.Cells.Controllers.IController FindController(global::System.Type pControllerType);

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060029CA RID: 10698
		// (set) Token: 0x060029CB RID: 10699
		global::SourceGrid.Cells.Views.IView View { get; set; }

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x060029CC RID: 10700
		// (set) Token: 0x060029CD RID: 10701
		global::SourceGrid.Cells.Models.ModelContainer Model { get; set; }

		// Token: 0x060029CE RID: 10702
		global::SourceGrid.Cells.ICellVirtual Copy();
	}
}
