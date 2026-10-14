using System;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x0200013A RID: 314
	public class DMin : global::NPOI.SS.Formula.Functions.IDStarAlgorithm
	{
		// Token: 0x06000A27 RID: 2599 RVA: 0x0001A828 File Offset: 0x00018A28
		public bool ProcessMatch(global::NPOI.SS.Formula.Eval.ValueEval eval)
		{
			if (eval is global::NPOI.SS.Formula.Eval.NumericValueEval)
			{
				if (this.minimumValue == null)
				{
					this.minimumValue = eval;
				}
				else
				{
					double numberValue = ((global::NPOI.SS.Formula.Eval.NumericValueEval)eval).NumberValue;
					double numberValue2 = ((global::NPOI.SS.Formula.Eval.NumericValueEval)this.minimumValue).NumberValue;
					if (numberValue < numberValue2)
					{
						this.minimumValue = eval;
					}
				}
			}
			return true;
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x0001A875 File Offset: 0x00018A75
		public global::NPOI.SS.Formula.Eval.ValueEval Result
		{
			get
			{
				if (this.minimumValue == null)
				{
					return global::NPOI.SS.Formula.Eval.NumberEval.ZERO;
				}
				return this.minimumValue;
			}
		}

		// Token: 0x04000514 RID: 1300
		private global::NPOI.SS.Formula.Eval.ValueEval minimumValue;
	}
}
