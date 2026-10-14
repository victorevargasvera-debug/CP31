using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B9 RID: 185
	public interface IEvaluationCell
	{
		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000649 RID: 1609
		global::NPOI.SS.Formula.IEvaluationSheet Sheet { get; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x0600064A RID: 1610
		int RowIndex { get; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600064B RID: 1611
		int ColumnIndex { get; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600064C RID: 1612
		global::NPOI.SS.UserModel.CellType CellType { get; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600064D RID: 1613
		double NumericCellValue { get; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600064E RID: 1614
		string StringCellValue { get; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600064F RID: 1615
		bool BooleanCellValue { get; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000650 RID: 1616
		int ErrorCellValue { get; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000651 RID: 1617
		object IdentityKey { get; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000652 RID: 1618
		global::NPOI.SS.UserModel.CellType CachedFormulaResultType { get; }
	}
}
