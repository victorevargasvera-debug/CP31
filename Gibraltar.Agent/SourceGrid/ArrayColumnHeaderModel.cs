using System;
using SourceGrid.Cells.Models;

namespace SourceGrid
{
	// Token: 0x02000412 RID: 1042
	internal class ArrayColumnHeaderModel : global::SourceGrid.Cells.Models.IValueModel, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002D93 RID: 11667 RVA: 0x000992D8 File Offset: 0x000974D8
		public virtual object GetValue(global::SourceGrid.CellContext cellContext)
		{
			return cellContext.Position.Column - cellContext.Grid.FixedColumns;
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x000992F8 File Offset: 0x000974F8
		public virtual void SetValue(global::SourceGrid.CellContext cellContext, object p_Value)
		{
			throw new global::System.ApplicationException("Not supported");
		}
	}
}
