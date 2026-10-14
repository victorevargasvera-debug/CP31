using System;
using NPOI.Util;

namespace NPOI.SS.Formula.PTG
{
	// Token: 0x0200011A RID: 282
	[global::System.Serializable]
	public abstract class OperandPtg : global::NPOI.SS.Formula.PTG.Ptg
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000952 RID: 2386 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsBaseToken
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00018A2C File Offset: 0x00016C2C
		public global::NPOI.SS.Formula.PTG.OperandPtg Copy()
		{
			global::NPOI.SS.Formula.PTG.OperandPtg result;
			try
			{
				result = (global::NPOI.SS.Formula.PTG.OperandPtg)this.Clone();
			}
			catch (global::System.NotSupportedException e)
			{
				throw new global::NPOI.Util.RuntimeException(e);
			}
			return result;
		}
	}
}
