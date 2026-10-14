using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000070 RID: 112
	public interface IFormulaEvaluator
	{
		// Token: 0x06000404 RID: 1028
		void ClearAllCachedResultValues();

		// Token: 0x06000405 RID: 1029
		void NotifySetFormula(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x06000406 RID: 1030
		void NotifyDeleteCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x06000407 RID: 1031
		void NotifyUpdateCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x06000408 RID: 1032
		global::NPOI.SS.UserModel.CellValue Evaluate(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x06000409 RID: 1033
		void EvaluateAll();

		// Token: 0x0600040A RID: 1034
		global::NPOI.SS.UserModel.CellType EvaluateFormulaCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x0600040B RID: 1035
		global::NPOI.SS.UserModel.ICell EvaluateInCell(global::NPOI.SS.UserModel.ICell cell);

		// Token: 0x0600040C RID: 1036
		void SetupReferencedWorkbooks(global::System.Collections.Generic.Dictionary<string, global::NPOI.SS.UserModel.IFormulaEvaluator> workbooks);

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600040D RID: 1037
		// (set) Token: 0x0600040E RID: 1038
		bool IgnoreMissingWorkbooks { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600040F RID: 1039
		// (set) Token: 0x06000410 RID: 1040
		bool DebugEvaluationOutputForNextEval { get; set; }
	}
}
