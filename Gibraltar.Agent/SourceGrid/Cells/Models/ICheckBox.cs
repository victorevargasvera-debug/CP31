using System;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003AD RID: 941
	internal interface ICheckBox : global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B7A RID: 11130
		global::SourceGrid.Cells.Models.CheckBoxStatus GetCheckBoxStatus(global::SourceGrid.CellContext cellContext);

		// Token: 0x06002B7B RID: 11131
		void SetCheckedValue(global::SourceGrid.CellContext cellContext, bool? pChecked);
	}
}
