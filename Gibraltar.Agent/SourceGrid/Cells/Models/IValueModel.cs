using System;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003AA RID: 938
	internal interface IValueModel : global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B6F RID: 11119
		object GetValue(global::SourceGrid.CellContext cellContext);

		// Token: 0x06002B70 RID: 11120
		void SetValue(global::SourceGrid.CellContext cellContext, object p_Value);
	}
}
