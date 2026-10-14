using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula
{
	// Token: 0x020000B2 RID: 178
	public interface TwoDEval : global::NPOI.SS.Formula.Eval.ValueEval
	{
		// Token: 0x06000618 RID: 1560
		global::NPOI.SS.Formula.Eval.ValueEval GetValue(int rowIndex, int columnIndex);

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000619 RID: 1561
		int Width { get; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600061A RID: 1562
		int Height { get; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600061B RID: 1563
		bool IsRow { get; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600061C RID: 1564
		bool IsColumn { get; }

		// Token: 0x0600061D RID: 1565
		global::NPOI.SS.Formula.TwoDEval GetRow(int rowIndex);

		// Token: 0x0600061E RID: 1566
		global::NPOI.SS.Formula.TwoDEval GetColumn(int columnIndex);

		// Token: 0x0600061F RID: 1567
		bool IsSubTotal(int rowIndex, int columnIndex);
	}
}
