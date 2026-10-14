using System;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000C9 RID: 201
	public interface IFormulaParsingWorkbook
	{
		// Token: 0x060006E2 RID: 1762
		global::NPOI.SS.Formula.IEvaluationName GetName(string name, int sheetIndex);

		// Token: 0x060006E3 RID: 1763
		global::NPOI.SS.UserModel.IName CreateName();

		// Token: 0x060006E4 RID: 1764
		global::NPOI.SS.UserModel.ITable GetTable(string name);

		// Token: 0x060006E5 RID: 1765
		global::NPOI.SS.Formula.PTG.Ptg GetNameXPtg(string name, global::NPOI.SS.Formula.SheetIdentifier sheet);

		// Token: 0x060006E6 RID: 1766
		global::NPOI.SS.Formula.PTG.Ptg Get3DReferencePtg(global::NPOI.SS.Util.CellReference cell, global::NPOI.SS.Formula.SheetIdentifier sheet);

		// Token: 0x060006E7 RID: 1767
		global::NPOI.SS.Formula.PTG.Ptg Get3DReferencePtg(global::NPOI.SS.Util.AreaReference area, global::NPOI.SS.Formula.SheetIdentifier sheet);

		// Token: 0x060006E8 RID: 1768
		int GetExternalSheetIndex(string sheetName);

		// Token: 0x060006E9 RID: 1769
		int GetExternalSheetIndex(string workbookName, string sheetName);

		// Token: 0x060006EA RID: 1770
		global::NPOI.SS.SpreadsheetVersion GetSpreadsheetVersion();
	}
}
