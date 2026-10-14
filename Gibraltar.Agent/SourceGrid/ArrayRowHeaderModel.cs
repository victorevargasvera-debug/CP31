using System;
using SourceGrid.Cells.Models;

namespace SourceGrid
{
	// Token: 0x02000411 RID: 1041
	internal class ArrayRowHeaderModel : global::SourceGrid.Cells.Models.IValueModel, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002D90 RID: 11664 RVA: 0x000992A4 File Offset: 0x000974A4
		public virtual object GetValue(global::SourceGrid.CellContext cellContext)
		{
			return cellContext.Position.Row - cellContext.Grid.FixedRows;
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x000992C4 File Offset: 0x000974C4
		public virtual void SetValue(global::SourceGrid.CellContext cellContext, object p_Value)
		{
			throw new global::System.ApplicationException("Not supported");
		}
	}
}
