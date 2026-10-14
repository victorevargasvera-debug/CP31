using System;
using NPOI.SS.Formula.PTG;

namespace NPOI.SS.Formula
{
	// Token: 0x020000BA RID: 186
	public interface IEvaluationName
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000653 RID: 1619
		string NameText { get; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000654 RID: 1620
		bool IsFunctionName { get; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000655 RID: 1621
		bool HasFormula { get; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000656 RID: 1622
		global::NPOI.SS.Formula.PTG.Ptg[] NameDefinition { get; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000657 RID: 1623
		bool IsRange { get; }

		// Token: 0x06000658 RID: 1624
		global::NPOI.SS.Formula.PTG.NamePtg CreatePtg();
	}
}
