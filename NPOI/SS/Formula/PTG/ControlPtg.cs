using System;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x02000101 RID: 257
	public abstract class ControlPtg : global::NPOI.SS.Formula.PTG.Ptg
	{
		// Token: 0x17000256 RID: 598
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsBaseToken
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x00017E2F File Offset: 0x0001602F
		public override byte DefaultOperandClass
		{
			get
			{
				throw new global::System.NotImplementedException("Control tokens are not classified");
			}
		}
	}
}
