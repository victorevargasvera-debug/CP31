using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200016C RID: 364
	public class And : global::NPOI.SS.Formula.Functions.BooleanFunction
	{
		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00008875 File Offset: 0x00006A75
		protected override bool InitialResultValue
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0001D2CF File Offset: 0x0001B4CF
		protected override bool PartialEvaluate(bool cumulativeResult, bool currentValue)
		{
			return cumulativeResult && currentValue;
		}
	}
}
