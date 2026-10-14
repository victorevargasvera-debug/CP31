using System;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula
{
	// Token: 0x020000CB RID: 203
	public interface IFormulaRenderingWorkbook
	{
		// Token: 0x060006EE RID: 1774
		global::NPOI.SS.Formula.ExternalSheet GetExternalSheet(int externSheetIndex);

		// Token: 0x060006EF RID: 1775
		string GetSheetFirstNameByExternSheet(int externSheetIndex);

		// Token: 0x060006F0 RID: 1776
		string GetSheetLastNameByExternSheet(int externSheetIndex);

		// Token: 0x060006F1 RID: 1777
		string ResolveNameXText(global::NPOI.SS.Formula.PTG.NameXPtg nameXPtg);

		// Token: 0x060006F2 RID: 1778
		string GetNameText(global::NPOI.SS.Formula.PTG.NamePtg namePtg);
	}
}
