using System;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x02000170 RID: 368
	public class Or : global::NPOI.SS.Formula.Functions.BooleanFunction
	{
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00006EB4 File Offset: 0x000050B4
		protected override bool InitialResultValue
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0001D4F0 File Offset: 0x0001B6F0
		protected override bool PartialEvaluate(bool cumulativeResult, bool currentValue)
		{
			return cumulativeResult || currentValue;
		}
	}
}
