using System;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000127 RID: 295
	public abstract class ScalarConstantPtg : global::NPOI.SS.Formula.PTG.Ptg
	{
		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060009C3 RID: 2499 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsBaseToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060009C4 RID: 2500 RVA: 0x000162C8 File Offset: 0x000144C8
		public override byte DefaultOperandClass
		{
			get
			{
				return 32;
			}
		}
	}
}
