using System;
using NPOI.SS.Formula.PTG;
using NPOI.SS.Formula.UDF;

namespace NPOI.SS.Formula
{
	// Token: 0x020000BF RID: 191
	public interface IEvaluationWorkbook
	{
		// Token: 0x06000667 RID: 1639
		string GetSheetName(int sheetIndex);

		// Token: 0x06000668 RID: 1640
		int GetSheetIndex(global::NPOI.SS.Formula.IEvaluationSheet sheet);

		// Token: 0x06000669 RID: 1641
		int GetSheetIndex(string sheetName);

		// Token: 0x0600066A RID: 1642
		global::NPOI.SS.Formula.IEvaluationSheet GetSheet(int sheetIndex);

		// Token: 0x0600066B RID: 1643
		global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(int externSheetIndex);

		// Token: 0x0600066C RID: 1644
		global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(string firstSheetName, string lastSheetName, int externalWorkbookNumber);

		// Token: 0x0600066D RID: 1645
		int ConvertFromExternSheetIndex(int externSheetIndex);

		// Token: 0x0600066E RID: 1646
		global::NPOI.SS.Formula.ExternalName GetExternalName(int externSheetIndex, int externNameIndex);

		// Token: 0x0600066F RID: 1647
		global::NPOI.SS.Formula.ExternalName GetExternalName(string nameName, string sheetName, int externalWorkbookNumber);

		// Token: 0x06000670 RID: 1648
		global::NPOI.SS.Formula.IEvaluationName GetName(global::NPOI.SS.Formula.PTG.NamePtg namePtg);

		// Token: 0x06000671 RID: 1649
		global::NPOI.SS.Formula.IEvaluationName GetName(string name, int sheetIndex);

		// Token: 0x06000672 RID: 1650
		string ResolveNameXText(global::NPOI.SS.Formula.PTG.NameXPtg ptg);

		// Token: 0x06000673 RID: 1651
		global::NPOI.SS.Formula.PTG.Ptg[] GetFormulaTokens(global::NPOI.SS.Formula.IEvaluationCell cell);

		// Token: 0x06000674 RID: 1652
		global::NPOI.SS.Formula.UDF.UDFFinder GetUDFFinder();

		// Token: 0x06000675 RID: 1653
		void ClearAllCachedResultValues();
	}
}
